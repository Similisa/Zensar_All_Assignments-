using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Assg_CodeFirst.Models;

namespace MVC_Assg_CodeFirst.Controllers
{
    public class StudentController : Controller
    {
        StudentDetailsEntities sd = new StudentDetailsEntities();

        StudentContext sc = new StudentContext();

        // GET: Student
        public ActionResult Index()
        {
            List<Student_details_Table> st = sd.Student_details_Table.ToList();
            return View(st);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Student_details_Table st)
        {
            sd.Student_details_Table.Add(st);
            sd.SaveChanges();
            return RedirectToAction("Index");
        }

       
        public ActionResult Details(int id)
        {
            Student_details_Table sc = sd.Student_details_Table.Find(id);
                return View(sc);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Student_details_Table sc = sd.Student_details_Table.Find(id);
            return View();
        }

        [HttpPost]

        public ActionResult Edit(Student_details_Table st)
        {
            Student_details_Table sc = sd.Student_details_Table.Find(st.StudentId);
            sc.Branch = st.Branch;
            sc.City = st.City;
            sc.StudentId = st.StudentId;
            sc.Percentage = st.Percentage;
            sd.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Search_View_By_StudentDetails(string option, string str)
        {
            if (option == "City")
            {
                return View(sc.Student_Details_Tables.Where(x => x.City == str).ToList());
            }
            else if (option == "Percentage")
            {
                return View(sc.Student_Details_Tables.Where(x => x.Percentage.ToString() == str).ToList());
            }
            else if (option == "Branch")
            {
                return View(sc.Student_Details_Tables.Where(x => x.Branch == str).ToList());
            }
            else
            {
                return View(sc.Student_Details_Tables.Where(x => x.StudentId.ToString() == str).ToList());
            }
        }


    }
}