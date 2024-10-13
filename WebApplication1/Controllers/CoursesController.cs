using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class CoursesController : Controller
    {
        private Context context = new Context();
        public IActionResult Index()
        {
            List<Course> Courses = context.Courses.ToList(); 
            return View("Index",Courses);
        }
    }
}
