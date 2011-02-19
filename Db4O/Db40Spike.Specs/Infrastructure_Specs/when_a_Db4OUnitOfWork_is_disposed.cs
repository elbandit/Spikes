using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Db40Spike.Domain;
using Db40Spike.Infrastructure;
using Db4objects.Db4o;
using Machine.Specifications;
using Rhino.Mocks;

namespace Db40Spike.Specs.Infrastructure_Specs
{
    public class when_a_Db4OUnitOfWork_is_disposed : base_spec
    {
        private static IUnitOfWork SUT;
        private static IDb4OSession db4o_session;
        private static IObjectContainer object_container;

        Establish context = () =>
        {
            db4o_session = stub_an<IDb4OSession>();
            object_container = stub_an<IObjectContainer>();

            db4o_session.Stub(x => x.object_container_in_session).Return(object_container);
        };

        private Because of = () =>
        {
            using (SUT = new Db4OUnitOfWork(db4o_session))
            {  }
        };

        It should_call_commit_on_the_object_container = () =>
        {
            object_container.AssertWasCalled(x => x.Commit());
        };
    }
}
