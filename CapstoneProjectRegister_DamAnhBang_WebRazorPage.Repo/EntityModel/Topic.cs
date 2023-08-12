using System;
using System.Collections.Generic;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.EntityModel
{
    public partial class Topic
    {
        public Topic()
        {
            Semesters = new HashSet<Semester>();
            TopicOfLecturers = new HashSet<TopicOfLecturer>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public string? Active { get; set; }
        public int? LectureId { get; set; }

        public virtual Group? Group { get; set; }
        public virtual ICollection<Semester> Semesters { get; set; }
        public virtual ICollection<TopicOfLecturer> TopicOfLecturers { get; set; }
    }
}
