using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        CarBookContext c = new CarBookContext();
        public void Delete(T entity)
        {
            c.Set<T>().Remove(entity);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return c.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
           c.Set<T>().Add(entity);
            c.SaveChanges();
        }

        public void Update(T entity)
        {
           c.Set<T>().Update(entity);
            c.SaveChanges();
        }
    }
}
