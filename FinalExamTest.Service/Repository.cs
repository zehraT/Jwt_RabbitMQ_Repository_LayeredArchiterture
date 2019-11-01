using FinalExamTest.Data.Context;
using FinalExamTest.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FinalExamTest.Service
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _dataContext;
        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;

        }
        public T Add(T entity)
        {
            _dataContext.Set<T>().Add(entity);
            _dataContext.SaveChanges();

            return entity;
        }

        public bool Delete(int id)
        {
            bool result = false;
            var user = Find(id);
            if (user != null)
            {
                _dataContext.Set<T>().Remove(user);
                _dataContext.SaveChanges();
                result = true;
            }

            return result;
        }

        public T Find(int id)
        {
            return _dataContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dataContext.Set<T>().ToList();
        }

        public T Update(T entity)
        {
            _dataContext.Set<T>().Update(entity);
            _dataContext.SaveChanges();

            return entity;
        }
    }
}
