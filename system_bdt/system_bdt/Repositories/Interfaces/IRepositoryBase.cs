using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace system_bdt.Repositories.Interfaces
{
    public interface IRepositoryBase<T>where T : class
    {
        IQueryable<T> Query();

        T GetById(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Save();
    }
}