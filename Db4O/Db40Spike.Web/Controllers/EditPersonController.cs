using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Db40Spike.Domain;
using Db40Spike.Web.Models;

namespace Db40Spike.Web.Controllers
{
    public class EditPersonController : Controller
    {
        private readonly IRepository<Person> _person_repository;
        private readonly IUnitOfWorkFactory _unit_of_work_factory;

        public EditPersonController(IRepository<Person> person_repository,
                                    IUnitOfWorkFactory unit_of_work_factory)
        {
            _person_repository = person_repository;
            _unit_of_work_factory = unit_of_work_factory;
        }

        public ActionResult Edit(Guid id)
        {
            var person_to_edit = _person_repository.find_by(id);

            var edit_person_view_model = new EditPersonViewModel()
                                             {
                                                 first_name = person_to_edit.name.first_name,
                                                 last_name = person_to_edit.name.last_name
                                             };

            return View(edit_person_view_model);
        }

        [HttpPost]
        public ActionResult Edit(EditPersonViewModel person_that_has_changed)
        {
            if (ModelState.IsValid)
            {
                var person_to_edit = _person_repository.find_by(person_that_has_changed.id);

                var original_name = person_to_edit.name;

                var new_name = new Name(person_that_has_changed.first_name, person_that_has_changed.last_name);

                person_to_edit.change_name_to(new_name);

                using (_unit_of_work_factory.create())
                {
                    _person_repository.save(person_to_edit);
                }
                
                TempData.Add("Message", String.Format("Name changed from '{0}' to '{1}'", original_name, person_to_edit.name));

                return RedirectToAction("Index", "DisplayAllPeople");
            }
            else
                return View(person_that_has_changed);
        }
    }
}
