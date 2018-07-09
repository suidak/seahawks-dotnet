using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class foundreviewMap : EntityTypeConfiguration<foundreview>
    {
        public foundreviewMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("foundreview", "seahawks");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.existingLostReportMatch_id).HasColumnName("existingLostReportMatch_id");
            this.Property(t => t.foundReport_id).HasColumnName("foundReport_id");

            // Relationships
            this.HasOptional(t => t.foundreport)
                .WithMany(t => t.foundreviews)
                .HasForeignKey(d => d.foundReport_id);
            this.HasOptional(t => t.lostreport)
                .WithMany(t => t.foundreviews)
                .HasForeignKey(d => d.existingLostReportMatch_id);
            this.HasRequired(t => t.review)
                .WithOptional(t => t.foundreview);

        }
    }
}
