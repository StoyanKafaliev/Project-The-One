using MVC_WorkingWIthData.InputModels;
using MVC_WorkingWIthData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WorkingWIthData.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentsInput students)
        {
            if (ModelState.IsValid)
            {
                ApplicationDbContext context = new ApplicationDbContext();

                Students studnet = new Students()
                {
                    Addres = students.Addres,
                    FacNumber = students.FacNumber,
                    FirstName = students.FirstName,
                    LastName = students.LastName,
                    IsActive = true,
                    Grade = students.Grade,
                };

                context.Studnets.Add(studnet);

                context.SaveChanges();

                return RedirectToAction("Success");
            }
            else
            {
                return View(students);
            }
        }

        [HttpGet]
        public ActionResult Details()
        {
            if (true)
            {
                
            }
            else
            {

            }
            ApplicationDbContext context = new ApplicationDbContext();

            return View(context.Studnets.FirstOrDefault());
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}