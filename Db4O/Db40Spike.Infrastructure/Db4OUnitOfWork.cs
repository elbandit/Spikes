using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Db40Spike.Domain;

namespace Db40Spike.Infrastructure
{
    public class Db4OUnitOfWork : IUnitOfWork
    {
        private IDb4OSession _db4o_session;

        public Db4OUnitOfWork(IDb4OSession db4OSession)
        {
            _db4o_session = db4OSession;
        }

        public void Dispose()
        {
            _db4o_session.object_container_in_session.Commit();
        }
    }
}
