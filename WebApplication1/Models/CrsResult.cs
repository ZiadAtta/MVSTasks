using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
	public class CrsResult
	{
	  public int Id { get; set; }

	  public int CourseDegree { get; set; }
	  public int Degree { get; set; }
	  [ForeignKey("Dept")]
	  public int DeptId { get; set; }
	  public Department Dept { get; set; }

      [ForeignKey("Crs")]
	  public int CrsId { get; set; }
	  public Course Crs { get; set; }
		[ForeignKey("Trainee")]  
	  public int TraineeId {  get; set; }
	  public Trainee Trainee { get; set; }
	}
}
