using GAP.PruebaSeguros.Domain.Models;
using GAP.PruebaSeguros.Domain.Services.RiskTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Data.Repositories
{
    public class RiskTypeRepository : GenericRepository<RiskType>, IRiskTypeRepository
    {
        public RiskTypeRepository(Context context)
           : base(context)
        {
        }

        private Context context = new Context();

        public IQueryable<RiskType> GetRiskType(int id)
        {
            return context.RiskType.Where(r => r.Id == id);
        }
    }
}
