using System;
using System.Collections.Generic;
using System.Linq;
using DataMapper;
using System.Configuration;
using Specification;
using Specification.Interface;
using Repository.Context;
using Repository.Repositories;
using Repository.Specifications;

namespace Repository.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PersonDataMapper personDataMapper = new PersonDataMapper(ConfigurationManager.ConnectionStrings["connectionStringSchool"].ConnectionString);
                /*
                personDataMapper.Insert(new Person
                {
                    LastName = "Munguia",
                    FirstName = "Isack",
                    HireDate = DateTime.Now,
                    EnrollmentDate = DateTime.Now,
                    Discriminator = "Instructor"
                });
                */

                List<DataMapper.Models.Person> personas = personDataMapper.GetFiltered("AND FirstName = 'Isack'", "LastName", 10, 1).ToList();
                //List<Person> personasConApellidoPerez = personDataMapper.GetFiltered("LastName = 'Perez'", "", int.MaxValue, 1).ToList();

                //personas.ForEach(Console.WriteLine);

                //ISpecification<DataMapper.Models.Person> personasQueSeLlamanIsack = new ExpressionSpecification<DataMapper.Models.Person>(persona => persona.FirstName == "Isack");
                //ISpecification<DataMapper.Models.Person> personasConApellidoSuarez = new ExpressionSpecification<DataMapper.Models.Person>(persona => persona.LastName == "Suarez");
                //ISpecification<DataMapper.Models.Person> personasQueNoSonEstudiantes = new ExpressionSpecification<DataMapper.Models.Person>(persona => persona.Discriminator != "Student");
                //ISpecification<DataMapper.Models.Person> todasLasEspecificaciones = personasQueSeLlamanIsack.Or(personasConApellidoSuarez).Or(personasQueNoSonEstudiantes);

                //personas.FindAll(()=>personasQueSeLlamanIsack.IsSatisfiedBy).ForEach(Console.WriteLine);

                //var dataFiltrada = personas.FindAll(persona => todasLasEspecificaciones.IsSatisfiedBy());

                //personas.FindAll(persona => new PropertyEqualsSpecification<DataMapper.Models.Person>("Discriminator", "Student").IsSatisfiedBy(persona)).ForEach(Console.WriteLine);

                var p1 = new Person{
                    LastName = "Munguia",
                    FirstName = "Isack",
                    HireDate = DateTime.Now,
                    EnrollmentDate = DateTime.Now,
                    Discriminator = "Instructor"
                };
                var p2 = new Person
                {
                    LastName = "Herrera",
                    FirstName = "Gysela",
                    HireDate = null,
                    EnrollmentDate = DateTime.Now,
                    Discriminator = "Instructor"
                };

                ISpecification<Person> specification0 = new PersonDiscriminatorSpecification("Instructor");
                ISpecification<Person> specification1 = new PersonFirstNameSpecification("Isack");
                ISpecification<Person> specification2 = new ExpressionSpecification<Person>(p => p.FirstName.FirstOrDefault().Equals('A'));
                ISpecification<Person> specification3 = new ExpressionSpecification<Person>(p => p.LastName.FirstOrDefault().Equals('A'));

                var todasLasEspecificaciones = specification3.Or(specification2);
                
                List<Person> persons = new List<Person>();
                using (new ContextCreation())
                {
                    var repository = PersonRepository.Instance;
                    //var itemToCreate = repository.Create(pp);
                    //var itemToDelete = repository.Delete(specification1);
                    //var itemToDelete = repository.Delete(p2);
                    //repository.SaveChanges();
                    persons = repository.Filter(todasLasEspecificaciones).ToList();

                    //var updateResult = repository.Update(p2);
                }
                Console.WriteLine($"{nameof(persons)}: {persons.Count}");
                persons.ToList().ForEach(Console.WriteLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
