using System;
using System.Collections.Generic;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.EntityModel
{
    public partial class Semester
    {
        public Semester()
        {
            Groups = new HashSet<Group>();
            StudentInSemesters = new HashSet<StudentInSemester>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TopicId { get; set; }

        public virtual Topic? Topic { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<StudentInSemester> StudentInSemesters { get; set; }
    }
}
