﻿using GAP.PruebaSeguros.Domain.Models;
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
            if (insurance != null)
            {
                insurance.Name = insurancePolicy.Name;
                insurance.Description = insurancePolicy.Description;
                insurance.StartDate = insurancePolicy.StartDate;
                insurance.CoveringMonths = insurancePolicy.CoveringMonths;
                insurance.Price = insurancePolicy.Price;
                insurance.RiskType = insurancePolicy.RiskType;
                insurance.CoveringTypes = insurancePolicy.CoveringTypes;
                insurance.CoveringPercentage = insurancePolicy.CoveringPercentage;
                context.SaveChanges();
            }
        }

        public void DeleteInsurancePolicy(int id)
        {
            var insurance = context.InsurancePolicy.FirstOrDefault(i => i.Id == id);
            context.InsurancePolicy.Remove(insurance);
            context.SaveChanges();
        }
    }
}
