using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Domain.Default
{
    public interface IContext : IUnitOfWork, IDisposable
    {
    }
}
