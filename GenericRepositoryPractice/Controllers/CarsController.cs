using GenericRepositoryPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace GenericRepositoryPractice.Controllers
{
    public class CarsController : Controller
    {
        private IGenericRepository<Car> _repository;

        public CarsController() : this(new CarsRepository())
        { }

        public CarsController(IGenericRepository<Car> repository)
        {
            _repository = repository;
        }
        
        //
        // GET: /Cars/

        [HttpGet]
        public ActionResult Index()
        {
            var result = _repository.GetAll();
            return View(result);
        }

        [HttpGet]
        public ActionResult GetById(int id)
        {
            Expression<Func<Car, bool>> predicate = c=> c.Id == id;         
            var result = _repository.GetBy(predicate);
            return View(result);
          
        }

    }
}
