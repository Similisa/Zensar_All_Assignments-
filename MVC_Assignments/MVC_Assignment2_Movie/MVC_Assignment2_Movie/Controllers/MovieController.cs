using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Assignment2_Movie.Models;


namespace MVC_Assignment2_Movie.Controllers
{

    public class MovieController : Controller
    {
        MoviedatabaseEntities1 db = new MoviedatabaseEntities1();
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }   

        public ActionResult MovieScaffolded()
        {
            List<Movietable> mtb = db.Movietables.ToList();
            return View(mtb);
        }
        //create 

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movietable mtb)
        {
            db.Movietables.Add(mtb);
            db.SaveChanges();
            return RedirectToAction("MovieScaffolded");
        }

        public ActionResult Details(int id)
        {
            Movietable mtb = db.Movietables.Find(id);
            return View(mtb);
        }
        //Edit

        [HttpGet]

        public ActionResult Edit(int id)
        {
            Movietable mtb = db.Movietables.Find(id);
            return View(mtb);
        }

        [HttpPost]

        public ActionResult Edit(Movietable movietable)
        {
            Movietable m = db.Movietables.Find(movietable.movieid);
            m.moviename = movietable.moviename;
            m.dateofRelease = movietable.dateofRelease;
            db.SaveChanges();
            return RedirectToAction("MovieScaffolded");
        }

        //Delete

        public ActionResult Delete(int id)
        {
            Movietable mtb = db.Movietables.Find(id);
            db.Movietables.Remove(mtb);
            db.SaveChanges();
            return RedirectToAction("MovieScaffolded");
        }

        //Display the movie released in any given year 

        public ActionResult GetMoviesByYear(string search)
        {
            List<Movietable>movies=(from mtb in db.Movietables
                                    where mtb.dateofRelease.ToString().Contains(search)||search==null
                                    select mtb).ToList();
            return View(movies);
        }

    }
}