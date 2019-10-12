using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Domain.Models
{
    public class InsurancePolicy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int CoveringMonths { get; set; }
        public string price { get; set; }
        public string RiskType { get; set; }

        public virtual CoveringType coveringTypes { get; set; }
    }
}
