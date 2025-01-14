﻿using Core.Entities;
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
    public class ModelRepository:IModelRepository
    {
        readonly AppDBContext _context;

        public ModelRepository(AppDBContext context)
        {
            _context = context;
        }

        public DbSet<Model> Table => _context.Set<Model>();

        public async Task<Model> Create(Model entity)
        {
            await Table.AddAsync(entity);
            return entity;
        }

        public void Delete(Model entity)
        {
            Table.Remove(entity);
        }

        public IQueryable<Model> FindAll(Expression<Func<Model, bool>> expression)
        {

            return expression != null ? Table.Where(expression) : Table;
        }

        public IQueryable<Model> GetAll()
        {
            return Table;
        }

        public async Task<Model> GetbyId(int id)
        {
            return await Table.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(Model entity)
        {
            Table.Update(entity);
        }
        public async Task<bool> IsExsist(Expression<Func<Model, bool>> expression)
        {
            return await Table.AnyAsync(expression);
        }


    }
}
