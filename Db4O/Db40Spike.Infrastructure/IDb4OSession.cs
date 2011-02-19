using System;
using Db4objects.Db4o;

namespace Db40Spike.Infrastructure
{
    public interface IDb4OSession : IDisposable
    {        
        IObjectContainer object_container_in_session { get;}        
    }
}