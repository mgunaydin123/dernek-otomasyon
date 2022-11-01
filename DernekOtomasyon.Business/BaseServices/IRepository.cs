using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyon.Business.BaseServices
{
    public interface IRepository<T> where T : class
    {
        void Insert(T entity);
        void Delete(int Id);
        T Update(T entity);
        int Save();
        IEnumerable<T> GetList();
        IQueryable<T> GetListQuerable();
        IEnumerable<T> GetList(Expression<Func<T, bool>> _lambda);
        T Find(int Id);
        T FirstOrDefault(Expression<Func<T, bool>> _lambda);
        bool Any(Expression<Func<T, bool>> _lambda);
        int Count(Expression<Func<T, bool>> _lambda);

    }
}
