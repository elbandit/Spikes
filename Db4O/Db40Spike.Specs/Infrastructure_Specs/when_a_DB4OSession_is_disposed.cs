using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Db40Spike.Infrastructure;
using Db4objects.Db4o;
using Machine.Specifications;
using Rhino.Mocks;

namespace Db40Spike.Specs.Infrastructure_Specs
{
    public class when_a_DB4OSession_is_disposed : base_spec
    {
        private static IDb4OSession SUT;
        private static IObjectContainerFactory object_container_factory;
        private static IObjectContainer object_container;

        Establish context = () =>
        {
            object_container_factory = stub_an<IObjectContainerFactory>();
            object_container = stub_an<IObjectContainer>();

            object_container_factory.Stub(x => x.create()).Return(object_container);            
        };

        private Because of = () =>         
        { 
            using (SUT = new Db4OSession(object_container_factory))
            {
            }       
        };
      

        It should_close_the_object_container = () =>
        {
            object_container.AssertWasCalled(x => x.Close());
        };

        It should_call_dispose_on_the_object_container = () =>
        {
            object_container.AssertWasCalled(x => x.Dispose());
        };
    }
    
}
