using System;
using System.Collections.Generic;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.EntityModel
{
    public partial class StudentInSemester
    {
        public StudentInSemester()
        {
            StudentInGroups = new HashSet<StudentInGroup>();
        }

        public int Id { get; set; }
        public bool? Leader { get; set; }
        public string? Condition { get; set; }
        public int? SemesterId { get; set; }
        public int? StudentId { get; set; }

        public virtual Semester? Semester { get; set; }
        public virtual Student? Student { get; set; }
        public virtual ICollection<StudentInGroup> StudentInGroups { get; set; }
    }
}
