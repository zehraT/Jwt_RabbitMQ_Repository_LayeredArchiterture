using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamTest.Data.Interfaces
{
    public interface IRepository<T> where T:class
    {
        T Add(T entity);
        T Find(int id);
        bool Delete(int id);
        IEnumerable<T> GetAll();
        T Update(T entity);
    }
}
