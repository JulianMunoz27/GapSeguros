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

        public IQueryable<InsurancePolicy> GetInsurancePolicy(int id)
        {
            return context.InsurancePolicy.Where(r => r.Id == id);
        }

        public InsurancePolicy CreateInsurancePolicy(InsurancePolicy insurancePolicy)
        {
            context.InsurancePolicy.Add(insurancePolicy);
            context.SaveChanges();
            return insurancePolicy;
        }

        public void UpdateInsurancePolicy(InsurancePolicy insurancePolicy)
        {
            var insurance = context.InsurancePolicy.FirstOrDefault(i => i.Id == insurancePolicy.Id);
            if(insurance != null)
            {
                insurance = insurancePolicy;
                context.SaveChanges();
            }
        }

        public void DeleteInsurancePolicy(int id)
        {
            var insurance = context.InsurancePolicy.FirstOrDefault(i => i.Id == id);
            if (insurance != null)
            {
                context.InsurancePolicy.Remove(insurance);
                context.SaveChanges();
            }            
        }
    }
}
