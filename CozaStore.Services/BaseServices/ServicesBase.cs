// <copyright file="RepositoryBase.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Services
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using CozaStore.Data.EntityContext;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// ok.
    /// </summary>
    /// <typeparam name="T">biến T.</typeparam>
    public class ServicesBase<T> : IServicesBase<T>
        where T : class
    {
        private readonly CozaStoreContext _context;

        public ServicesBase(CozaStoreContext context)
        {
            _context = context;
        }

        public void Create(T request)
        {
            _context.Set<T>().Add(request);
            _context.SaveChanges();
        }

        public void Delete(T request)
        {
            _context.Set<T>().Remove(request);
            _context.SaveChanges();
        }

        public void Update(T request)
        {
            _context.Set<T>().Update(request);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsNoTracking();
        }
    }
}
