using System;
using System.Collections.Generic;

namespace Db40Spike.Domain
{
    public interface IRepository<Entity> where Entity : IEntity
    {
        Entity find_by(Guid id);
        IEnumerable<Entity> find_all();
        void save(Entity entity);
    }
}