using System;
using System.Data.Entity;
using StudentDatabaseApp.Models;

namespace StudentDatabaseApp.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=StudentDatabase")
        {
            // This will create the database if it doesn't exist
            Database.SetInitializer(new CreateDatabaseIfNotExists<StudentContext>());
        }

        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure the Student entity
            modelBuilder.Entity<Student>()
                .Property(s => s.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Student>()
                .Property(s => s.LastName)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Student>()
                .Property(s => s.Email)
                .HasMaxLength(100);

            base.OnModelCreating(modelBuilder);
        }
    }
} 