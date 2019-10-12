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
        IQueryable<InsurancePolicy> GetInsurancePolicyById(int id);
    }
}
