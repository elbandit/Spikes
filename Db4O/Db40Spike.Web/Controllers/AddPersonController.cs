using System;
using System.Web.Mvc;
using Db40Spike.Domain;
using Db40Spike.Web.Models;

namespace Db40Spike.Web.Controllers
{
    public class AddPersonController : Controller
    {
        private readonly IRepository<Person> _person_repository;
        private readonly IUnitOfWorkFactory _unit_of_work_factory;

        public AddPersonController(IRepository<Person> person_repository,
                                 IUnitOfWorkFactory unit_of_work_factory)
        {
            _person_repository = person_repository;
            _unit_of_work_factory = unit_of_work_factory;
        }

        public ActionResult Create()
        {
            var create_person = new CreatePersonViewModel();
            
            return View(create_person);
        }

        [HttpPost]
        public ActionResult Create(CreatePersonViewModel create_person)
        {
            if (ModelState.IsValid)
            {
                var name = new Name(create_person.first_name, create_person.last_name);
                var person_to_add = new Person(name);

                using (_unit_of_work_factory.create())
                {                
                    _person_repository.save(person_to_add);
                }

                TempData.Add("Message", String.Format("New person added '{0}'", person_to_add.name));

                return RedirectToAction("Index", "DisplayAllPeople");
            }
            else
                return View(create_person);                                        
        }
    }
}