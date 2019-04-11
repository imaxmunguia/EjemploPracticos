using System;
using System.Linq;
using Specification.Interface;

namespace Repository.Interface
{
    public interface IRepository<T>
    {
        T First(ISpecification<T> specification);

        IQueryable<TR> Query<TR>(ISpecification<Func<T, TR>> specification);

        IQueryable<T> Filter(ISpecification<T> specification);

        T Create(T itemToCreate);

        T Update(T itemToUpdate);

        T Delete(ISpecification<T> specification);

        T Delete(T itemToDelete);

        void SaveChanges();
    }
}
