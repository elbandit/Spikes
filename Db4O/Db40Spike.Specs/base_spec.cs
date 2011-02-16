using Rhino.Mocks;

namespace Db40Spike.Specs.Infrastructure_Specs
{
    public abstract class base_spec
    {
        public static TDepenedencyToStub stub_an<TDepenedencyToStub>() where TDepenedencyToStub : class
        {
            return MockRepository.GenerateStub<TDepenedencyToStub>();
        }
    }
}