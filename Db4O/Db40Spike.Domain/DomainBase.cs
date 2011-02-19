using System;

namespace Db40Spike.Domain
{
    public class DomainBase : IEntity
    {
        public Guid id { get; protected set; }

        public bool Equals(DomainBase other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.id.Equals(id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (DomainBase)) return false;
            return Equals((DomainBase) obj);
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}
