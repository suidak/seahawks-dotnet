using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class foundreportMap : EntityTypeConfiguration<foundreport>
    {
        public foundreportMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.status)
                .HasMaxLength(255);

            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("foundreport", "seahawks");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.careTaker_id).HasColumnName("careTaker_id");

            // Relationships
            this.HasRequired(t => t.report)
                .WithOptional(t => t.foundreport);
            this.HasOptional(t => t.user)
                .WithMany(t => t.foundreports)
                .HasForeignKey(d => d.careTaker_id);

        }
    }
}
