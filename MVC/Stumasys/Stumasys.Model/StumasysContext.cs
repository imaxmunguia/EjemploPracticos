namespace Stumasys.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StumasysContext : DbContext
    {
        public StumasysContext()
            : base("name=StumasysContext")
        {
        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Person> Person { get; set; }

        public virtual DbSet<Attachment> Attachment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Persons)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("StudentGrade").MapLeftKey("CourseID").MapRightKey("PersonID"));

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Attachments)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.PersonID);

        }
    }
}
