using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;

namespace PLEXEDC.WEB.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BasicHttpBinding b = new BasicHttpBinding();
            EndpointAddress a = new EndpointAddress("http://192.168.10.5/eai_anon_enu/start.swe?SWEExtSource=AnonWebService&amp;SweExtCmd=Execute");
            var f = new ChannelFactory<Imy
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