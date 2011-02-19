using Db40Spike.Infrastructure;
using Machine.Specifications;
using NUnit.Framework;
using Rhino.Mocks;

namespace Db40Spike.Specs.Infrastructure_Specs
{
    [Subject(typeof(Db4OSession), "Db4OSession")]
    public class when_creating_a_DB4OSession : base_spec
    {
        private static IDb4OSession SUT;
        private static IObjectContainerFactory object_container_factory;

        Establish context = () =>
        {
            object_container_factory = stub_an<IObjectContainerFactory>();
        };

        Because of = () => SUT = new Db4OSession(object_container_factory);

        It should_ask_the_object_factory_to_create_a_new_ObjectContainer = () =>
        {
            object_container_factory.AssertWasCalled(x => x.create());
        };
    }
}
