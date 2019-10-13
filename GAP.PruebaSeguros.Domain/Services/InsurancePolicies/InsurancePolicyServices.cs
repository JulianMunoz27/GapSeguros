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

        public InsurancePolicy CreateInsurancePolicy(InsurancePolicy insurancePolicy)
        {
            try
            {
                return repository.CreateInsurancePolicy(insurancePolicy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteInsurancePolicy(int id)
        {
            try
            {
                repository.DeleteInsurancePolicy(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<InsurancePolicy> GetInsurancePolicy(int id)
        {
            try
            {
                return repository.GetInsurancePolicy(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateInsurancePolicy(InsurancePolicy insurancePolicy)
        {
            try
            {
                repository.UpdateInsurancePolicy(insurancePolicy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
