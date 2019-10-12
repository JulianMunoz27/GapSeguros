using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Domain.Models
{
    public class CoveringType
    {
        public int Id { get; set; }
        public int InsuranceId { get; set; }
        public string Type { get; set; }
        public int Percentage { get; set; }
    }
}
