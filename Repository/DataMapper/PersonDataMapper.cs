using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataMapper.Models;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace DataMapper
{
    public class PersonDataMapper : IDataMapper<Person>
    {
        private string connectionString;
        private readonly DateTime? defaultDateTime = null;

        public PersonDataMapper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Insert(Person person)
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    var sql = "INSERT INTO PERSON (LastName, FirstName, HireDate, EnrollmentDate, Discriminator) VALUES (@lastName, @firstName, @hireDate, @enrollmentDate, @discriminator)";
                    using (var cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add(new SqlParameter("lastName", person.LastName));
                        cmd.Parameters.Add(new SqlParameter("firstName", person.FirstName));
                        cmd.Parameters.Add(new SqlParameter("hireDate", person.HireDate));
                        cmd.Parameters.Add(new SqlParameter("enrollmentDate", person.EnrollmentDate));
                        cmd.Parameters.Add(new SqlParameter("discriminator", person.Discriminator));

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inserting a User ({ex.Message})", ex);
            }
        }
        public IEnumerable<Person> GetFiltered(string conditions, string order, int pageSize, int pageIndex)
        {
            try
            {
                return getFiltered(conditions, order, pageSize, pageIndex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting a User ({ex.Message})", ex);
            }
        }

        private IEnumerable<Person> getFiltered(string conditions, string order, int pageSize, int pageIndex)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                var sql = "SELECT P.PersonID, P.LastName, P.FirstName, P.HireDate, P.EnrollmentDate, P.Discriminator FROM dbo.PERSON P WITH(NOLOCK)";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@conditions", conditions));
                    cmd.Parameters.Add(new SqlParameter("pageSize", pageSize));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Person
                            {
                                PersonID = (int)reader[0],
                                LastName = (string)reader[1],
                                FirstName = (string)reader[2],
                                HireDate = reader[3] != DBNull.Value ? (DateTime)(reader[3]) : defaultDateTime,
                                EnrollmentDate = reader[4] != DBNull.Value ? (DateTime)(reader[4]) : defaultDateTime,
                                Discriminator = (string)reader[5]
                            };
                        }
                    }
                }
            }
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
        public void Delete(Person person)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
