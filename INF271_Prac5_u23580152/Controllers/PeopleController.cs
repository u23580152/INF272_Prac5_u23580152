using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INF271_Prac5_u23580152.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public static List<Models.PersonModel> people = new List<Models.PersonModel>();
        public ActionResult ListPeople()
        {


            

            return View(people);
        }

        
        [HttpGet]

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.PersonModel pm)
        {
            people.Add(new Models.PersonModel { FirstName = pm.FirstName, LastName = pm.LastName, Email = pm.Email,  StuNumber = pm.StuNumber });
            return RedirectToAction("ListPeople");

        }
    }
}