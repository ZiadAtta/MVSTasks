using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Diagnostics;

using System.Collections.Generic;


namespace WebApplication1.Models
{
    public class TraineeCrsResult : Controller
    {
        public Context context = new Context();

        public List<Trainee> trainees = new List<Trainee>();
        //public List<CrsResult> crsResults = new List<CrsResult>();
        //public List<Course> courses = new List<Course>();


        public TraineeCrsResult()
        {
            trainees = context.Trainees.ToList();
            //crsResults = context.CrsResults.ToList();
            //courses = context.Courses.ToList();
        }
        public bool IsPass(int id)
        {
            CrsResult crsResult = context.CrsResults.FirstOrDefault(d => d.Id == id);
            Course crs = context.Courses.FirstOrDefault(d => d.Id == crsResult.Id);
            if (crs.MinDegree <= crsResult.CourseDegree) return true;
            return false;
        }
    }
}
