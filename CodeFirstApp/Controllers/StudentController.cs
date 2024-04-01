using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApp.Models;

namespace CodeFirstApp.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext db = new StudentContext();
        // GET: Student
        public ActionResult Index()
        {
            var dataStudents = db.Students.ToList();
            var dataBooks = db.Books.ToList();

            var viewModel = new MyViewModel
            {
                Students = dataStudents,
                Books = dataBooks
            };

            return View(viewModel);



        }
    }
}