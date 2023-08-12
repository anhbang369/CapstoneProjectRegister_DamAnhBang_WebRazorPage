using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.EntityModel;
using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.Repository
{
    public class StudentRepository : GenericRepository<Student>, IStudent
    {
        public StudentRepository(CapstoneProjectRegisterContext dbRContext) : base(dbRContext)
        {
        }

        public override Task<List<Student>> GetAllAsync()
        {
            return base.GetAllAsync();
        }
    }
}
