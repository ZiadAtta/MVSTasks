using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace WebApplication1.Models
{
	public class Context : Microsoft.EntityFrameworkCore.DbContext
	{

		public Context(){}

		public virtual DbSet<Department> Departments { get; set; }
		public virtual DbSet<Instructor> Instructors{ get; set; }
		public virtual DbSet<Trainee> Trainees { get; set; }
		public virtual DbSet<Course> Courses { get; set; }
		public virtual DbSet<CrsResult> CrsResults { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnMVC;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
			}
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            // Sample Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Computer Science", ManagerName = "Alice Johnson" },
                new Department { Id = 2, Name = "Mathematics", ManagerName = "Bob Smith" },
                new Department { Id = 3, Name = "Physics", ManagerName = "Carol White" }
            );

            // Sample Instructors
            modelBuilder.Entity<Instructor>().HasData(
                new Instructor { Id = 1, Name = "Dr. John Doe", Imag = "image1.jpg", Salary = 80000, Address = "123 Main St", DeptId = 1, CourseId = 1 },
                new Instructor { Id = 2, Name = "Dr. Jane Smith", Imag = "image2.jpg", Salary = 85000, Address = "456 Elm St", DeptId = 2, CourseId = 2 },
                new Instructor { Id = 3, Name = "Dr. Jim Brown", Imag = "image3.jpg", Salary = 78000, Address = "789 Oak St", DeptId = 3, CourseId = 3 }
            );

            // Sample Courses
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Introduction to Programming", Degree = 3, MinDegree = 50, DeptId = 1 },
                new Course { Id = 2, Name = "Calculus I", Degree = 4, MinDegree = 60, DeptId = 2 },
                new Course { Id = 3, Name = "Classical Mechanics", Degree = 4, MinDegree = 65, DeptId = 3 }
            );

            // Sample Trainees
            modelBuilder.Entity<Trainee>().HasData(
                new Trainee { Id = 1, Name = "Michael Green", Imag = "trainee1.jpg", Address = "321 Pine St", Grade = 75, DeptId = 1 },
                new Trainee { Id = 2, Name = "Sarah Lee", Imag = "trainee2.jpg", Address = "654 Maple St", Grade = 80, DeptId = 2 },
                new Trainee { Id = 3, Name = "David Black", Imag = "trainee3.jpg", Address = "987 Birch St", Grade = 70, DeptId = 3 }
            );

            // Sample Course Results
            modelBuilder.Entity<CrsResult>().HasData(
                new CrsResult { Id = 1, Degree = 85, DeptId = 1, CrsId = 1, TraineeId = 1 },
                new CrsResult { Id = 2, Degree = 90, DeptId = 2, CrsId = 2, TraineeId = 2 },
                new CrsResult { Id = 3, Degree = 75, DeptId = 3, CrsId = 3, TraineeId = 3 }
            );
            base.OnModelCreating(modelBuilder);
		}
	}
}
