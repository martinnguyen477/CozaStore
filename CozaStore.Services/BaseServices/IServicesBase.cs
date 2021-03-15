// <copyright file="IServicesBase.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using CozaStore.Model;

    public interface IServicesBase<T>
    {
        IQueryable<T> GetAll();

        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);

        void Create(T request);

        void Update(T request);

        void Delete(T request);
    }
}
