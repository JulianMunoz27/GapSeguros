using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAP.PruebaSeguros.Domain.Models;

namespace GAP.PruebaSeguros.Domain.Services.InsurancePolicies
{
    public class InsurancePolicyServices : IInsurancePolicyServices
    {
        /// <summary>
        /// Repository interface.
        /// </summary>
        private IInsurancePolicyRepository repository;

        /// <summary>
        /// Service constructor.
        /// </summary>
        /// <param name="repository"></param>
        public InsurancePolicyServices(IInsurancePolicyRepository repository)
        {
            this.repository = repository;
        }

        public IQueryable<InsurancePolicy> GetInsurancePolicyById(int id)
        {
            try
            {
                return repository.GetInsurancePolicyById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
