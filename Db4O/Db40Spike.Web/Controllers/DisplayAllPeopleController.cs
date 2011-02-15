using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using Db40Spike.Domain;
using Db40Spike.Infrastructure;

namespace Db40Spike.Web.Controllers
{
    public class DisplayAllPeopleController : Controller
    {
        private readonly IRepository<Person> _person_repository;

        public DisplayAllPeopleController(IRepository<Person> person_repository)
        {
            _person_repository = person_repository;
        }

        public ActionResult Index()
        {                        
            var people = _person_repository.find_all();
            
            return View(people);
        }       
    }
}
