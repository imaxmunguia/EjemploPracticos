using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMapper.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public string Discriminator { get; set; }
        public override string ToString()
        {
            return $"{LastName}, {FirstName}.";
        }
    }
}
