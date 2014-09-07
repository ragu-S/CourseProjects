using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mf_intro.Models;

namespace mf_intro.Controllers
{
    public class HomeController : Controller
    {
        private Manager man = new Manager();
        public ActionResult Index()
        {
            // create and display one Person
            Session["p"] = man.getPerson();        // get Person from the manager object
            return View((Person)Session["p"]);
        }

        public ActionResult Details()
        {
            return View((Person)Session["p"]);
        }

        public ActionResult List()
        {
            // create and display more than one Person (list of Person)
            if (Session["people"] == null) Session["people"] = man.getPeople();   

            return View((IEnumerable<Person>)Session["people"]);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            if (Session["people"] == null) 
                Session["people"] = man.getPeople();   
            
            List<Person> p = (List<Person>)Session["people"];
            Person ps = new Person(form[0], form[1], form[2]);
            p.Add(ps);
            Session["people"] = p;
            return RedirectToAction("List");
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}