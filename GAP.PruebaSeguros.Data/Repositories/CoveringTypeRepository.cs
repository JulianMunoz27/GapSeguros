using GAP.PruebaSeguros.Domain.Models;
using GAP.PruebaSeguros.Domain.Services.CoveringTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Data.Repositories
{
    public class CoveringTypeRepository : GenericRepository<CoveringType>, ICoveringTypeRepository
    {
        public CoveringTypeRepository(Context context)
            : base(context)
        {
        }

        private Context context = new Context();

        public List<string> GetCoveringTypesByList(List<string> id)
        {
            var result = new List<string>();

            foreach (var item in id)
            {
                var CoveringTypeId = Convert.ToInt32(item);
                result.Add(context.CoveringType.FirstOrDefault(c => c.Id == CoveringTypeId).Type);
            }

            return result;
        }
    }
}
