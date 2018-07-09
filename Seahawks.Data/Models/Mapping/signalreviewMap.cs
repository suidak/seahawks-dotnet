using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class signalreviewMap : EntityTypeConfiguration<signalreview>
    {
        public signalreviewMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.category)
                .HasMaxLength(255);

            this.Property(t => t.otherContent)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("signalreview", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.category).HasColumnName("category");
            this.Property(t => t.flagger).HasColumnName("flagger");
            this.Property(t => t.otherContent).HasColumnName("otherContent");
            this.Property(t => t.signalDate).HasColumnName("signalDate");
            this.Property(t => t.flagged_id).HasColumnName("flagged_id");
            this.Property(t => t.review_id).HasColumnName("review_id");

            // Relationships
            this.HasOptional(t => t.review)
                .WithMany(t => t.signalreviews)
                .HasForeignKey(d => d.review_id);
            this.HasOptional(t => t.user)
                .WithMany(t => t.signalreviews)
                .HasForeignKey(d => d.flagged_id);

        }
    }
}
