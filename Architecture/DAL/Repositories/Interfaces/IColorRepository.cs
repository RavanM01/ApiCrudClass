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
    public interface IColorRepository
    {
        public DbSet<Color> Table { get; }
        public Task<Color> GetbyId(int id);
        public IQueryable<Color> GetAll();
        public IQueryable<Color> FindAll(Expression<Func<Color, bool>> expression);
        public Task<Color> Create(Color entity);
        public void Update(Color entity);
        public void Delete(Color entity);
        public Task<int> SaveChangesAsync();
        public Task<bool> IsExsist(Expression<Func<Color, bool>> expression);
    }
}
