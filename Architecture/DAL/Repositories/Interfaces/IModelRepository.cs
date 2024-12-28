using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IModelRepository
    {
        public DbSet<Model> Table { get; }
        public Task<Model> GetbyId(int id);
        public IQueryable<Model> GetAll();
        public IQueryable<Model> FindAll(Expression<Func<Model, bool>> expression);
        public Task<Model> Create(Model entity);
        public void Update(Model entity);
        public void Delete(Model entity);
        public Task<int> SaveChangesAsync();
        public Task<bool> IsExsist(Expression<Func<Model, bool>> expression);
    }
}
