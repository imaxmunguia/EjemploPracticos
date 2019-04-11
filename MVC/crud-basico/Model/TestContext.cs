namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class TestContext : DbContext
    {
        public TestContext()
            : base("name=TestContext")
        {
        }

        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Adjunto> Adjunto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Cursos)
                .WithMany(e => e.Alumno)
                .Map(m => m.ToTable("AlumnoCurso"));

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Adjuntos)
                .WithRequired(e => e.Alumno)
                .HasForeignKey(e => e.Alumno_id);
        }
    }
}
