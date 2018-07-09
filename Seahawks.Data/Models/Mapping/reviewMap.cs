using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class reviewMap : EntityTypeConfiguration<review>
    {
        public reviewMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.content)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("review", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.content).HasColumnName("content");
            this.Property(t => t.correctAnswer).HasColumnName("correctAnswer");
            this.Property(t => t.reviewDate).HasColumnName("reviewDate");
            this.Property(t => t.report_id).HasColumnName("report_id");
            this.Property(t => t.reviewer_id).HasColumnName("reviewer_id");

            // Relationships
            this.HasOptional(t => t.lostreport)
                .WithMany(t => t.reviews)
                .HasForeignKey(d => d.report_id);
            this.HasOptional(t => t.user)
                .WithMany(t => t.reviews)
                .HasForeignKey(d => d.reviewer_id);

        }
    }
}
