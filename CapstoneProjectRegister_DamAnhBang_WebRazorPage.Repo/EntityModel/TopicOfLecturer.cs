using System;
using System.Collections.Generic;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.EntityModel
{
    public partial class TopicOfLecturer
    {
        public int Id { get; set; }
        public int? TopicId { get; set; }
        public int? LectureId { get; set; }

        public virtual Lecturer? Lecture { get; set; }
        public virtual Topic? Topic { get; set; }
    }
}
