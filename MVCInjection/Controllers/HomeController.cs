using MVCInjection.Abstract;
using MVCInjection.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCInjection.Controllers
{
    public class HomeController : Controller
    {
        private static IRepository _repository;

        //DependencyInjection

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            //RepositoryExel repositoryExel = new RepositoryExel();
            var city = _repository.GetCityById(1);
            return View(city);
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