using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Domain.Models
{
    public class InsurancePolicy
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Invalid Name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Invalid Description.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Invalid StartDate.")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Invalid Covering Months.")]
        public int CoveringMonths { get; set; }
        [Required(ErrorMessage = "Invalid Price.")]
        public string price { get; set; }
        [Required(ErrorMessage = "Invalid Risk Type")]
        public string RiskType { get; set; }
        [Required(ErrorMessage = "Invalid Covering Types")]
        public string CoveringTypes { get; set; }
        [Required(ErrorMessage = "Invalid Covering Percentage")]
        public int CoveringPercentage { get; set; }
    }
}
