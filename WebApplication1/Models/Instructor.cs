using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
	public class Instructor
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Imag {  get; set; }
		public double Salary { get; set; }
		public string Address {  get; set; }
		[ForeignKey ("Dept")]
		public int DeptId {  get; set; }
		public Department Dept { get; set; }
		[ForeignKey ("Crs")]
		public int CourseId {  get; set; }
		public Course Crs { get; set; }

	}
}
