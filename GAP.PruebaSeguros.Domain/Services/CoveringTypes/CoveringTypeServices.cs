using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAP.PruebaSeguros.Domain.Models;

namespace GAP.PruebaSeguros.Domain.Services.CoveringTypes
{
    public class CoveringTypeServices : ICoveringTypeServices
    {
        /// <summary>
        /// Repository interface.
        /// </summary>
        private ICoveringTypeRepository repository;

        /// <summary>
        /// Service constructor.
        /// </summary>
        /// <param name="repository"></param>
        public CoveringTypeServices(ICoveringTypeRepository repository)
        {
            this.repository = repository;
        }

        public List<string> GetCoveringTypesByList(List<string> id)
        {
            try
            {
                return repository.GetCoveringTypesByList(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
