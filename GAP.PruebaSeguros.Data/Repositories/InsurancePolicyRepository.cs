using GAP.PruebaSeguros.Domain.Models;
using GAP.PruebaSeguros.Domain.Services.InsurancePolicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Data.Repositories
{
    public class InsurancePolicyRepository : GenericRepository<InsurancePolicy>, IInsurancePolicyRepository
    {
        public InsurancePolicyRepository(Context context)
            : base(context)
        {
        }

        private Context context = new Context();

        public IQueryable<InsurancePolicy> GetInsurancePolicyById(int id)
        {
            return context.InsurancePolicy.Where(r => r.Id == id);
        }
    }
}
