namespace Stumasys.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.Entity;

    [Table("Course")]
    public partial class Course
    {
        public Course()
        {
            Persons = new List<Person>();
        }

        public int CourseID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int Credits { get; set; }

        public ICollection<Person> Persons { get; set; }

        public List<Course> GetAll()
        {
            var courses = new List<Course>();
            try
            {
                using (var context = new StumasysContext())
                {
                    courses = context.Course.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return courses;
        }
    }
}
