using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Db40Spike.Domain;

namespace Db40Spike.Infrastructure
{
    public class Db4OUnitOfWorkFactory : IUnitOfWorkFactory
    {
        private readonly IDb4OSession _db4o_session;

        public Db4OUnitOfWorkFactory(IDb4OSession db4o_session)
        {
            _db4o_session = db4o_session;
        }

        public IUnitOfWork create()
        {
            return new Db4OUnitOfWork(_db4o_session);
        }
    }
}
