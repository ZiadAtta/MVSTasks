using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
	public class TraineeController : Controller
	{

		Context context = new Context();
		public IActionResult Index()
		{ 
		    TraineeCrsResult crsResult = new TraineeCrsResult();
			return View("Index",crsResult);
		} 
		
	}
}
