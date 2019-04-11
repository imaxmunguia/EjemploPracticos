using System;
using System.Linq;
using Specification.Interface;
using Repository.Context;

namespace Repository.Interface
{
    public abstract class BaseRepository<T>: IRepository<T> where T : class
    {
        public abstract T First(ISpecification<T> specification);
        public abstract IQueryable<TR> Query<TR>(ISpecification<Func<T, TR>> specification);
        public abstract IQueryable<T> Filter(ISpecification<T> specification);
        public abstract T Create(T itemToCreate);
        public abstract T Update(T itemToUpdate);
        public abstract T Delete(ISpecification<T> specification);
        public abstract T Delete(T itemToDelete);
        public abstract void SaveChanges();
        public IQueryable<T> GetAll()
        {
            return ContextFactory.GetContext().Set<T>();
        }
    }
}