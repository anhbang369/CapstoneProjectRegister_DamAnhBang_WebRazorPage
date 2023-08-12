using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.Unito
{
    public interface IUnitoWork
    {
        IStudent student1 { get; set; }
        Task CompleteAsyc();
    }
}
