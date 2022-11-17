using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        // Context sınıfından bir nesne türetiriz.
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler=c.Hakkimizdas.ToList(); //listeye dökme
            return View(degerler);
        }
    }
}