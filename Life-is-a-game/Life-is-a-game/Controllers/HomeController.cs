using Life_is_a_game.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace Life_is_a_game.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DataContext context = new DataContext();
            context.UserSkills.Where(x => x.value == 5);
            context.UserSkills.Count(x=>x.id>0);
            context.Skills.Count(c=>c.Id>0);

            return View();
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