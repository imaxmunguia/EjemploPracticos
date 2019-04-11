namespace Stumasys.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.Entity;
    using System.Data.SqlClient;

    [Table("Person")]
    public partial class Person
    {
        public Person()
        {
            Courses = new List<Course>();
        }

        public int PersonID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(50, ErrorMessage = "The length of the field exceeds the maximum allowed.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(50, ErrorMessage = "The length of the field exceeds the maximum allowed.")]
        public string FirstName { get; set; }

        public DateTime? HireDate { get; set; }

        public DateTime? EnrollmentDate { get; set; }

       public ICollection<Course> Courses { get; set; }

       public ICollection<Attachment> Attachments { get; set; }

        public List<Person> GetAll()
        {
            var students = new List<Person>();
            try
            {
                using (var context = new StumasysContext())
                {
                    students = context.Person.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return students;
        }

        public Person Get(int personId)
        {
            var student = new Person();

            try
            {
                using (var context = new StumasysContext())
                {
                    student = context.Person
                                     .Include("Courses")
                                     .Include("Attachments")
                                     .Where(p => p.PersonID == personId)
                                     .SingleOrDefault();

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return student;
        }

        public void Save()
        {
            var student = new Person();

            try
            {
                using (var context = new StumasysContext())
                {
                    if (this.PersonID == 0)
                    {
                        context.Entry(this).State = EntityState.Added;
                    }
                    else
                    {
                        /*
                        context.Entry(this).State = EntityState.Modified;
                        context.SaveChanges();
                        Person p = context.Person.Include(a => a.Courses).ToList().Find(ca => ca.PersonID == this.PersonID);
                        p.Courses.Clear();
                        foreach(var item in this.Courses)
                        {
                            Course cc = context.Course.Find(item);
                            p.Courses.Add(cc);
                        }
                        
                        List<Course> bkCourses = new List<Course>();
                        Person p = context.Person.Include(a => a.Courses).ToList().Find(ca => ca.PersonID == this.PersonID);
                        bkCourses = p.Courses.ToList();
                        foreach (Course item in bkCourses)
                        {
                            context.Entry(item).State = EntityState.Detached;
                        }
                        p.Courses.Clear();
                        context.Entry(p).State = EntityState.Modified;
                        */
                        context.Database.ExecuteSqlCommand(
                            "DELETE FROM StudentGrade WHERE PersonID = @id",
                            new SqlParameter("id",this.PersonID)
                            );

                        var bkCourses = this.Courses;
                        this.Courses = null;
                        context.Entry(this).State = EntityState.Modified;
                        this.Courses = bkCourses;
                    }

                    foreach (var item in this.Courses)
                        context.Entry(item).State = EntityState.Unchanged;

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Attach(Attachment file)
        {
            try
            {
                using (var context = new StumasysContext())
                {
                    context.Entry(this).State = EntityState.Unchanged;
                    context.Entry(file).State = EntityState.Added;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Delete(int personId)
        {
            try
            {
                using (var context = new StumasysContext())
                {
                    context.Entry(new Person { PersonID = personId }).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Attachment> GetAllAttachments(int _personID)
        {
            var attachments = new List<Attachment>();
            try
            {
                using (var context = new StumasysContext())
                {
                    attachments = context.Attachment
                                         .Where(f => f.PersonID == _personID)
                                         .ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return attachments;
        }
    }
}
