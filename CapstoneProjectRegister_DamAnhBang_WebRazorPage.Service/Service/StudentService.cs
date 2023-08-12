using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.EntityModel;
using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.IRepository;
using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.Unito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Service.Service
{
    public class StudentService
    {
        private readonly IStudent _studentRepository;

        private readonly IUnitoWork unitoWork;

        public StudentService(IStudent studentRepository, IUnitoWork unitoWork)
        {
            _studentRepository = studentRepository;
            this.unitoWork = unitoWork;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await this.unitoWork.student1.GetAllAsync();
        }

    }
}
