using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Db40Spike.Domain
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork create(); 
    }
}
