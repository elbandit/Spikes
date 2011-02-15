using System;
using Db4objects.Db4o;

namespace Db40Spike.Infrastructure
{
    public class Db4OSession : IDb4OSession, IDisposable
    {        
        public Db4OSession(IObjectContainerFactory objectContainerFactory)
        {
            object_container_in_session = objectContainerFactory.create();
        }

        public IObjectContainer object_container_in_session { get; private set; }

        public void Dispose()
        {
            object_container_in_session.Close();
            object_container_in_session.Dispose();
        }
    }
}