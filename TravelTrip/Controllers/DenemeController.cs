using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class DenemeController : Controller
    {
        Context c = new Context();
        // GET: Deneme
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            
            return View(degerler);
        }


       
        public ActionResult About()
        {



            return View();
        }

        public PartialViewResult Partial1()
        {

            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }


        public PartialViewResult Partial2()
        {

            var degerler = c.Blogs.Where(x => x.ID==1).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial3()
        {

            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(10).ToList();
            return PartialView(degerler);
        }



        public PartialViewResult Partial4()
        {

            var degerler = c.Blogs.Take(3).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial5()
        {

            var degerler = c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            return PartialView(degerler);
        }
    }
}