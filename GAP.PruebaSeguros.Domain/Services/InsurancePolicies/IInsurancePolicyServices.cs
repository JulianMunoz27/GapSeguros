using GAP.PruebaSeguros.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Domain.Services.InsurancePolicies
{
    public interface IInsurancePolicyServices
    {
        /// <summary>
        /// Gets an InsurancePolicy by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IQueryable<InsurancePolicy> GetInsurancePolicy(int id);

        /// <summary>
        /// Creates an InsurancePolicy.
        /// </summary>
        /// <param name="insurancePolicy"></param>
        /// <returns></returns>
        InsurancePolicy CreateInsurancePolicy(InsurancePolicy insurancePolicy);

        /// <summary>
        /// Updates an InsurancePolicy.
        /// </summary>
        /// <param name="insurancePolicy"></param>
        void UpdateInsurancePolicy(InsurancePolicy insurancePolicy);

        /// <summary>
        /// Deletes an InsurancePolicy.
        /// </summary>
        /// <param name="id"></param>
        void DeleteInsurancePolicy(int id);
    }
}
