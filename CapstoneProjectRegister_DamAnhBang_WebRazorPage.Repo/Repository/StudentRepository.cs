using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.EntityModel;
using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.Repository
{
    public class StudentRepository : IStudent
    {
        public void AddStudent(Student student)
        {
            try
            {
                using var context = new CapstoneProjectRegisterContext();
                context.Students.Add(student);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Student GetStudent(int id)
        {
            try
            {
                using var context = new CapstoneProjectRegisterContext();
                return context.Students.SingleOrDefault(a => a.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Student> GetStudents()
        {
            try
            {
                using var context = new CapstoneProjectRegisterContext();
                return context.Students.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
