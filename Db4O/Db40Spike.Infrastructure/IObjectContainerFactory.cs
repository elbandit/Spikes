using Db4objects.Db4o;

namespace Db40Spike.Infrastructure
{
    public interface IObjectContainerFactory
    {
        IObjectContainer create();
    }
}