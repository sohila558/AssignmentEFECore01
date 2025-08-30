using AsignmentEFECore01.Configration;
using AsignmentEFECore01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignmentEFECore01.Context
{
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>().HasKey(S => new { S.Stud_Id, S.Cors_Id });

            modelBuilder.Entity<Stud_Course>()
                        .Property(S => S.Grade)
                        .IsRequired();

            modelBuilder.ApplyConfiguration(new Department_Configration());
            modelBuilder.ApplyConfiguration(new Course_Ins_Configration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .\\SQLEXPRESS; Database = EFITI; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_ins> Course_Ins { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }


    }
}
