using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using First_MVC_Application.Models;

namespace First_MVC_Application.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetStudentName()
        {
            var student = new Student()
            {
                Id = 1,
                StudentName = "Ali Youssef"
            };
            return View(student);
        }
    }
}