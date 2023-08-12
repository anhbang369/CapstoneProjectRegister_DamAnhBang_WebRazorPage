using System;
using System.Collections.Generic;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.EntityModel
{
    public partial class Student
    {
        public Student()
        {
            StudentInSemesters = new HashSet<StudentInSemester>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Avatar { get; set; }
        public int? Age { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Fee { get; set; }
        public string? Credit { get; set; }
        public string? Projected { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<StudentInSemester> StudentInSemesters { get; set; }
    }
}
