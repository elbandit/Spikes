using Db40Spike.Domain;
using Db4objects.Db4o;
using System.Linq;
using Db4objects.Db4o.Linq;
using System;
using System.Collections.Generic;

namespace Db40Spike.Infrastructure {

    public class Db4ORepository<Entity> : IRepository<Entity> where Entity : IEntity
    {
        private readonly IDb4OSession _db4o_session;        

        public Db4ORepository(IDb4OSession db4o_session)
        {
            _db4o_session = db4o_session;            
        }

        public Entity find_by(Guid id)
        {
            return (from Entity entity in _db4o_session.object_container_in_session
                    select entity).SingleOrDefault(g => g.id == id);
        }

        public IEnumerable<Entity> find_all()
        {
            return (from Entity entity in _db4o_session.object_container_in_session
                    select entity).ToList();            
        }

        public void save(Entity entity)
        {
            _db4o_session.object_container_in_session.Store(entity);                 
        }        
    }
}