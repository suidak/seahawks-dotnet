using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class reportlocalisationMap : EntityTypeConfiguration<reportlocalisation>
    {
        public reportlocalisationMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.city)
                .HasMaxLength(255);

            this.Property(t => t.country)
                .HasMaxLength(255);

            this.Property(t => t.street)
                .HasMaxLength(255);

            this.Property(t => t.zip)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("reportlocalisation", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.street).HasColumnName("street");
            this.Property(t => t.x).HasColumnName("x");
            this.Property(t => t.y).HasColumnName("y");
            this.Property(t => t.zip).HasColumnName("zip");
        }
    }
}
