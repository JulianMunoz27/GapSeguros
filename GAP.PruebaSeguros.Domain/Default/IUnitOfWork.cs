using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Domain.Default
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Commit all changes made in the container.
        /// </summary>
        void Commit();

        /// <summary>
        /// Commit all changes made in the container and refresh the changes.
        /// </summary>
        void CommitAndRefreshChanges();
    }
}
