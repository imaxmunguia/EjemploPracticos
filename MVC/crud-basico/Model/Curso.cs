namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Curso")]
    public partial class Curso
    {
        public Curso()
        {
            Alumno = new List<Alumno>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public ICollection<Alumno> Alumno { get; set; }

public List<Curso> Todo() 
{
    var cursos = new List<Curso>();
    try
    {
        using (var context = new TestContext())
        {
            cursos = context.Curso.ToList();
        }
    }
    catch (Exception e)
    {
        throw new Exception(e.Message);
    }

    return cursos;
}
    }
}
