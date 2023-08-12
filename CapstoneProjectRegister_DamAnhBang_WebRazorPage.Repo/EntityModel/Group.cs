using System;
using System.Collections.Generic;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.EntityModel
{
    public partial class Group
    {
        public Group()
        {
            StudentInGroups = new HashSet<StudentInGroup>();
        }

        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int? Amount { get; set; }
        public DateTime? Date { get; set; }
        public string? Active { get; set; }
        public int? Status { get; set; }
        public int? SemesterId { get; set; }
        public int? TopicId { get; set; }

        public virtual Semester? Semester { get; set; }
        public virtual Topic? Topic { get; set; }
        public virtual ICollection<StudentInGroup> StudentInGroups { get; set; }
    }
}
