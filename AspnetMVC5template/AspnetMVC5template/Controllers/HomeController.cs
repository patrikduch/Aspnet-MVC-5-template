using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspnetMvc5.Core.Interfaces.Facades;

namespace AspnetMVC5template.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonFacade _personFacade;

        public HomeController(IPersonFacade personFacade)
        {
            _personFacade = personFacade;
        }

        public ActionResult Index()
        {
            var persons = _personFacade.GetAllPersons();

            return View(persons);
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