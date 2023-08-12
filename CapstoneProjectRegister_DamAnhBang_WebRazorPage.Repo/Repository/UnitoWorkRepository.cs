using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.EntityModel;
using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.IRepository;
using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.Unito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.Repository
{
    public class UnitoWorkRepository : IUnitoWork
    {
        
        
        private readonly CapstoneProjectRegisterContext _context;

        public UnitoWorkRepository(CapstoneProjectRegisterContext context)
        {
            this._context = context;
            student1 = new StudentRepository(_context);

        }

        public IStudent student1 { get; set; }

        public async Task CompleteAsyc()
        {
          await  this._context.SaveChangesAsync();
        }
    }
}
