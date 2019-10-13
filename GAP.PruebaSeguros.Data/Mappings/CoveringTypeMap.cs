using GAP.PruebaSeguros.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.PruebaSeguros.Data.Mappings
{
    public class CoveringTypeMap : EntityTypeConfiguration<CoveringType>
    {
        public CoveringTypeMap()
        {
            // Primary Key.
            HasKey(t => t.Id);

            // Properties.
            ToTable("CoveringType");

            this.Property(t => t.Type).HasColumnName("Type");
        }
    }
}
