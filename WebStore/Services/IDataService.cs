using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebStore.Services
{
    interface IDataService<T> where T:class
    {
        void Delete(T entity);
        void Delete(string pkey);
        void Update(T entity);
        void Create(T entity);
        T Read(string pKey);
        IEnumerable<T> ReadAll();
        IEnumerable<T> QueryWhere(Expression<Func<T, bool>> predicate);
        T QueryFirstWhere(Expression<Func<T, bool>> predicate);
         
    }
}
