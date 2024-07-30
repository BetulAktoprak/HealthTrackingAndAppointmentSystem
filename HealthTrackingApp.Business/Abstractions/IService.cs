﻿using HealthTrackingApp.Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HealthTrackingApp.Business.Abstractions
{
    public interface IService<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
        T? GetByID(Guid id);
        IEnumerable<T>? GetAll();
    }
}
