using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.IRepository
{
    public interface IGenericRepository<T> where T:class
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAsync(int id);

        Task<bool> AddEntiry(T entity);

        Task<bool> UpdateEntiry(T entity);

        Task<bool> DeleteEntiry(int id);
    }
}
