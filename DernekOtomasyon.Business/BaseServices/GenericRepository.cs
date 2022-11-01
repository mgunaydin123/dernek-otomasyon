using DernekOtomasyon.DATA.Context;
using DernekOtomasyon.DATA.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyon.Business.BaseServices
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {

        public ApplicationEntityDbContext _context;


        public GenericRepository(ApplicationEntityDbContext context)
        {
            //if (dbContext == null)
            //    throw new ArgumentNullException("dbContext can not be null.");

            // _context = new ApplicationDbContext();
            _context = context;

            // _context.Configuration.LazyLoadingEnabled = false;

        }



        public virtual void Insert(T entity)
        {


            entity.GetType().GetProperty("InsertedDate").SetValue(entity, DateTime.Now);
            _context.Set<T>().Add(entity);


        }

        public virtual T Update(T entity)
        {
            entity.GetType().GetProperty("UpdateDate").SetValue(entity, DateTime.Now);
            _context.Set<T>().Attach(entity);
            _context.Entry<T>(entity).State = EntityState.Modified;

            return entity;
        }


        public virtual void Delete(int Id)
        {
            var entity = Find(Id);
            if (entity != null)
            {


                _context.Set<T>().Remove(entity);
            }
        }

        public int Save()
        {
            return _context.SaveChanges();
            //return 1;
        }

        public virtual IEnumerable<T> GetList()
        {
            //   return _context.Set<T>().AsEnumerable();
            return _context.Set<T>().AsEnumerable();
        }

        public virtual IQueryable<T> GetListQuerable()
        {
            return _context.Set<T>().AsQueryable();
        }

        public virtual IEnumerable<T> GetList(System.Linq.Expressions.Expression<Func<T, bool>> _lambda)
        {
            return _context.Set<T>().Where(_lambda).AsEnumerable();
        }


        public virtual T Find(int Id)
        {
            return _context.Set<T>().First(x => x.ID == Id);
        }




        public virtual T FirstOrDefault(System.Linq.Expressions.Expression<Func<T, bool>> _lambda)
        {
            return _context.Set<T>().FirstOrDefault(_lambda);

        }

        public virtual T First(System.Linq.Expressions.Expression<Func<T, bool>> _lambda)
        {
            return _context.Set<T>().First(_lambda);
        }

        public virtual bool Any(System.Linq.Expressions.Expression<Func<T, bool>> _lambda)
        {
            return _context.Set<T>().Any(_lambda);
        }

        public virtual int Count(System.Linq.Expressions.Expression<Func<T, bool>> _lambda)
        {
            return _context.Set<T>().Count(_lambda);
        }




    }
}

