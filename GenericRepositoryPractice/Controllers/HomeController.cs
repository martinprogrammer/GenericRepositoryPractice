using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GenericRepositoryPractice.Models;

namespace GenericRepositoryPractice.Controllers
{
    public class HomeController : Controller
    {
        private IGenericRepository<Car> _repository;

        public HomeController() : this(new CarsRepository())
        { }

        public HomeController(IGenericRepository<Car> repository)
        {
            _repository = repository;
        }
        public ActionResult Index()
        {
            var result = _repository.GetAll();

            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
