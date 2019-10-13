using GAP.PruebaSeguros.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Domain.Services.CoveringTypes
{
    public interface ICoveringTypeServices
    {
        /// <summary>
        /// Get CoveringTypes by list of id's.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<string> GetCoveringTypesByList(List<string> id);
    }
}
