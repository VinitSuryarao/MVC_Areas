using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area.Areas.Broker.Controllers
{
    public class ClientHomeController : Controller
    {
        // GET: Broker/ClientHome
        public ActionResult Index()
        {
            return View();
        }
    }
}