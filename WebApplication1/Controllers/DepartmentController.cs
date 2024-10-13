using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Transactions;
namespace WebApplication1.Controllers
{
	public class DepartmentController : Controller
	{
		Context context = new Context();
		public IActionResult Index()
		{
			List<Department> depts = context.Departments.ToList();

			return View("Index",depts);
		}

		public IActionResult Details(int id)
		{
			Department dept = context.Departments.FirstOrDefault(dp => dp.Id == id);

			return View("Details", dept);
		}

		#region AddDepartmentToTheBook
		public IActionResult AddNewDepartment()
		{

			return View("AddNewDepartment");
		}


		public IActionResult SaveNewDepartment(string name, string manager)
		{
			Department newDepartment;
			if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(manager))
			{
				newDepartment = new Department()
				{
					Name = name,
					ManagerName = manager
				};

				context.Add(newDepartment);
				context.SaveChanges();
				return RedirectToAction("SaveNewDepartment");
			}
			return View("SaveNewDepartment");
		}
		#endregion

		#region Update Department
		public IActionResult GetDepartment(int? id)
		{
			if (id != null)
			{
				Department department = context.Departments.FirstOrDefault(d => d.Id == id);
				return View("GetDepartment", department);
			}
			return View("GetDepartment");
		}

		public IActionResult UpdateDepartment(int id, string name, string manager)
		{
			if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(manager))
			{
				Department updateDepartment = context.Departments.FirstOrDefault(d => d.Id == id);

				if (updateDepartment != null)
				{
					updateDepartment.Name = name;
					updateDepartment.ManagerName = manager;
					context.SaveChanges();
				}
			}
			return RedirectToAction("Index");
		}
		#endregion


		public IActionResult DeleteDepartment(string name)
		{
			if(!string.IsNullOrEmpty(name))
			{
				Department department = context.Departments.FirstOrDefault(dept => dept.Name == name);
				if (department != null)
				{
					context.Remove(department);
					context.SaveChanges();
				}

				return RedirectToAction("Index");
			}

			return RedirectToAction("Index");
		}

    }
}
