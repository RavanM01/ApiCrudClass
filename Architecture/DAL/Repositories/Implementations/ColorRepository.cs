using Core.Entities;
using DAL.Context;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Implementations
{
    internal class ColorRepository : IColorRepository
    {
        readonly AppDBContext _context;

        public ColorRepository(AppDBContext context)
        {
            _context = context;
        }

        public DbSet<Color> Table => _context.Set<Color>();

        public async Task<Color> Create(Color entity)
        {
            await Table.AddAsync(entity);
            return entity;
        }

        public void Delete(Color entity)
        {
            Table.Remove(entity);
        }

        public IQueryable<Color> FindAll(Expression<Func<Color, bool>> expression)
        {

            return expression != null ? Table.Where(expression) : Table;
        }

        public IQueryable<Color> GetAll()
        {
            return Table;
        }

        public async Task<Color> GetbyId(int id)
        {
            return await Table.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(Color entity)
        {
            Table.Update(entity);
        }
        public async Task<bool> IsExsist(Expression<Func<Color, bool>> expression)
        {
            return await Table.AnyAsync(expression);
        }

    }
}
