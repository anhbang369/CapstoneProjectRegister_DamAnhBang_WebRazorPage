using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.IRepository
{
    public interface IStudent
    {
        IEnumerable<Student> GetStudents();
        Student GetStudent(int id);
        void AddStudent(Student student);
    }
}
