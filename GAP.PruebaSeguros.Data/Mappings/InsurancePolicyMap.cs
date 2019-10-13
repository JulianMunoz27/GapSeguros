using GAP.PruebaSeguros.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Data.Mappings
{
    public class InsurancePolicyMap : EntityTypeConfiguration<InsurancePolicy>
    {
        public InsurancePolicyMap()
        {
            // Primary Key.
            HasKey(t => t.Id);

            // Properties.
            ToTable("InsurancePolicy");

            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.CoveringMonths).HasColumnName("CoveringMonths");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.RiskType).HasColumnName("RiskType");
            this.Property(t => t.CoveringTypes).HasColumnName("CoveringTypes");
            this.Property(t => t.CoveringPercentage).HasColumnName("CoveringPercentage");

        }
    }
}
