using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAP.PruebaSeguros.Domain.Models;

namespace GAP.PruebaSeguros.Domain.Services.RiskTypes
{
    public class RiskTypeServices : IRiskTypeServices
    {
        /// <summary>
        /// Repository interface.
        /// </summary>
        private IRiskTypeRepository repository;

        /// <summary>
        /// Service constructor.
        /// </summary>
        /// <param name="repository"></param>
        public RiskTypeServices(IRiskTypeRepository repository)
        {
            this.repository = repository;
        }

        public IQueryable<RiskType> GetRiskType(int id)
        {
            try
            {
                return repository.GetRiskType(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
