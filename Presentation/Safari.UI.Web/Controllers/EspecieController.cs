using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vitruvio.UI.Process;

namespace Safari.UI.Web.Controllers
{
    public class EspecieController : Controller
    {
        // GET: Especie
        public ActionResult Index()
        {
            var ep = new EspecieProcess();
            var lista = ep.ToList();
            return View(lista);
        }
    }
}