using System;
using System.Collections.Generic;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.EntityModel
{
    public partial class Lecturer
    {
        public Lecturer()
        {
            TopicOfLecturers = new HashSet<TopicOfLecturer>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Avatar { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public int? Role { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<TopicOfLecturer> TopicOfLecturers { get; set; }
    }
}
