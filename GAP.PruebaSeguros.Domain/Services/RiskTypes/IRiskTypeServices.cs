using GAP.PruebaSeguros.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Domain.Services.RiskTypes
{
    public interface IRiskTypeServices
    {
        /// <summary>
        /// Get RiskType by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IQueryable<RiskType> GetRiskType(int id);
    }
}
