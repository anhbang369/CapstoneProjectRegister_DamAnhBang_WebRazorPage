using System;
using System.Collections.Generic;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.EntityModel
{
    public partial class StudentInGroup
    {
        public int Id { get; set; }
        public int? StudentInSemesterId { get; set; }
        public int? GroupId { get; set; }

        public virtual Group? Group { get; set; }
        public virtual StudentInSemester? StudentInSemester { get; set; }
    }
}
