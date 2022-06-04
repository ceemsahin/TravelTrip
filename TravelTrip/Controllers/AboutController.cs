using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        Context c = new Context();

        public ActionResult Index()
        {

            var degeler = c.Hakkimizdas.ToList();

            return View(degeler);
        }
    }
}