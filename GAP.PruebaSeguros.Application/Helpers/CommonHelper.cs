using GAP.PruebaSeguros.Application.BusinessLogic;
using GAP.PruebaSeguros.CrossCutting;
using GAP.PruebaSeguros.Domain.Models;
using GAP.PruebaSeguros.Domain.Services.CoveringTypes;
using GAP.PruebaSeguros.Domain.Services.RiskTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Application.Helpers
{
    public class CommonHelper
    {
        private CommonTerms terms;

        public CommonHelper()
        {
            terms = new CommonTerms();
        }

        public InsurancePolicy CompleteInsurance(InsurancePolicy insurancePolicy)
        {
            try
            {
                var coveringTypeIds = insurancePolicy.CoveringTypes.Split(',').ToList();
                var coveringTypes = IoCFactory.Resolve<ICoveringTypeServices>().GetCoveringTypesByList(coveringTypeIds);
                insurancePolicy.CoveringTypes = string.Join(", ", coveringTypes);

                var riskType = IoCFactory.Resolve<IRiskTypeServices>().GetRiskType(Convert.ToInt32(insurancePolicy.RiskType)).FirstOrDefault();
                insurancePolicy.RiskType = riskType.Type;

                return insurancePolicy;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ValidInsurancePolicy(InsurancePolicy insurancePolicy)
        {
            var result = insurancePolicy.RiskType == terms.HighRisk && insurancePolicy.CoveringPercentage > 50;
            return !result;
        }
    }
}
