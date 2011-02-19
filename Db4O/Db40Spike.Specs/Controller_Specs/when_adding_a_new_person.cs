using Db40Spike.Domain;
using Db40Spike.Infrastructure;
using Db40Spike.Web.Controllers;
using Machine.Specifications;
using Rhino.Mocks;

namespace Db40Spike.Specs.Infrastructure_Specs.Controller_Specs
{
    public class when_adding_a_new_person : base_spec
    {
        private static AddPersonController SUT;
        private static IUnitOfWorkFactory unit_of_work_factory;
        private static IRepository<Person> person_repository;

        Establish context = () =>
        {
            unit_of_work_factory = stub_an<IUnitOfWorkFactory>();
            SUT = new AddPersonController(person_repository, unit_of_work_factory);
        };

        Because of = () =>
        {
            SUT.Create();
        };

        It should_ask_for_a_new_unit_of_work = () =>
        {
            unit_of_work_factory.AssertWasCalled(x => x.create());
        };
    }
}