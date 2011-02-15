using System;
using System.Collections;
using Db40Spike.Domain;
using Db4objects.Db4o;

namespace Db40Spike.Infrastructure
{
    public interface IDb4OSession
    {        
        IObjectContainer object_container_in_session { get;}        
    }
}