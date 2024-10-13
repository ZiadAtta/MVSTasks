using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
	public class Course
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Degree {  get; set; }
		public int MinDegree {  get; set; }
		[ForeignKey ("Dept")]
		public int DeptId { get; set; }
		public Department Dept { get; set; }

	}
}
