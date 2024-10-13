using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
	public class Trainee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Imag {  get; set; }
		public string Address { get; set; }
		public int Grade { get; set; }
		[ForeignKey("Dept")]
		public int DeptId { get; set; }
		public Department Dept { get; set; }
	}
}
