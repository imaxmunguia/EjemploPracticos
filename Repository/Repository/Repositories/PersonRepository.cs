using Repository.Interface;
using System;
using System.Linq;
using Specification.Interface;
using Repository.Context;

namespace Repository.Repositories
{
    public class PersonRepository : AbstractPersonRepository
    {
        private static AbstractPersonRepository instance;
        static PersonRepository()
        {
            instance = new PersonRepository();
        }
        public static AbstractPersonRepository Instance
        {
            get
            {
                return instance;
            }
        }
        public override Person First(ISpecification<Person> specification)
        {
            return ContextFactory.GetContext().Person.Where(specification.Expression.Compile()).FirstOrDefault();
        }
        public override IQueryable<TR> Query<TR>(ISpecification<Func<Person, TR>> specification)
        {
            throw new NotImplementedException();
        }
        public override IQueryable<Person> Filter(ISpecification<Person> specification)
        {
            return ContextFactory.GetContext().Person.Where(specification.Expression.Compile()).AsQueryable();
        }
        public override Person Create(Person itemToCreate)
        {
            var context = ContextFactory.GetContext();
            context.Person.Add(itemToCreate);
            return itemToCreate;
        }
        public override Person Update(Person itemToUpdate)
        {
            ContextFactory.GetContext().SaveChanges();
            return itemToUpdate;
        }
        public override Person Delete(ISpecification<Person> specification)
        {
            var itemToDelete = this.First(specification);
            var context = ContextFactory.GetContext();
            context.Person.Remove(itemToDelete);
            return itemToDelete;
        }
        public override Person Delete(Person itemToDelete)
        {
            var context = ContextFactory.GetContext();
            context.Person.Remove(itemToDelete);
            return itemToDelete;
        }
        public override void SaveChanges()
        {
            ContextFactory.GetContext().SaveChanges();
        }
    }
}
