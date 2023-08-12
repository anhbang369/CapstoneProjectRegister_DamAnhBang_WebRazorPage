using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.EntityModel;
using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected CapstoneProjectRegisterContext dbContext;
        internal DbSet<T> dbSet { get; set; }
        public GenericRepository(CapstoneProjectRegisterContext dbRContext)
        {
            this.dbContext = dbRContext;
            this.dbSet = this.dbContext.Set<T>();

        }
        public Task<bool> AddEntiry(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEntiry(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<List<T>> GetAllAsync()
        {
            return  this.dbSet.ToListAsync();
        }

        public Task<List<T>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEntiry(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
