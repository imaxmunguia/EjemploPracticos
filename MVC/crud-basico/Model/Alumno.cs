namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.Entity;
    using System.Data.SqlClient;

    [Table("Alumno")]
    public partial class Alumno
    {
        public Alumno()
        {
            Cursos = new List<Curso>();
        }

        public int id { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar un apellido")]
        [StringLength(100)]
        public string Apellido { get; set; }

        public ICollection<Curso> Cursos { get; set; }
        public ICollection<Adjunto> Adjuntos { get; set; }

        public List<Alumno> Listar() 
        {
            var alumnos = new List<Alumno>();
            try
            {
                using (var context = new TestContext()) 
                {
                    alumnos = context.Alumno.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return alumnos;
        }

        public Alumno Obtener(int id) 
        {
            var alumno = new Alumno();
            try
            {
                using (var context = new TestContext())
                {
                    alumno = context.Alumno
                                    .Include("Cursos")
                                    .Where(x => x.id == id)
                                    .Single();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return alumno;
        }

        public void Guardar()
        {
            try
            {
                using (var context = new TestContext())
                {
                    if (this.id == 0)
                    {
                        context.Entry(this).State = EntityState.Added;
                    }
                    else 
                    {
                        context.Database.ExecuteSqlCommand(
                            "DELETE FROM AlumnoCurso WHERE Alumno_id = @id",
                            new SqlParameter("id", this.id)
                        );

                        var cursoBK = this.Cursos;

                        this.Cursos = null;
                        context.Entry(this).State = EntityState.Modified;
                        this.Cursos = cursoBK;
                    }

                    foreach (var c in this.Cursos)
                        context.Entry(c).State = EntityState.Unchanged;

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Adjuntar(Adjunto adjunto)
        {
            try
            {
                using (var context = new TestContext())
                {
                    context.Entry(this).State = EntityState.Unchanged;

                    context.Entry(adjunto).State = EntityState.Added;

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using (var context = new TestContext())
                {
                    context.Entry(new Alumno { id = id }).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Adjunto> ListarAdjuntos(int Alumno_id)
        {
            var adjuntos = new List<Adjunto>();

            try
            {
                using (var context = new TestContext())
                {
                    adjuntos = context.Adjunto
                                      .Where(x => x.Alumno_id == Alumno_id)
                                      .ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return adjuntos;
        }
    }
}
