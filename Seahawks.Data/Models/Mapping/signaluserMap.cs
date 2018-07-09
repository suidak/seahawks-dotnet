using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class signaluserMap : EntityTypeConfiguration<signaluser>
    {
        public signaluserMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.motive)
                .HasMaxLength(255);

            this.Property(t => t.otherContent)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("signaluser", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.motive).HasColumnName("motive");
            this.Property(t => t.otherContent).HasColumnName("otherContent");
            this.Property(t => t.signalDate).HasColumnName("signalDate");
            this.Property(t => t.doer_id).HasColumnName("doer_id");
            this.Property(t => t.signaled_id).HasColumnName("signaled_id");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.signalusers)
                .HasForeignKey(d => d.signaled_id);
            this.HasOptional(t => t.user1)
                .WithMany(t => t.signalusers1)
                .HasForeignKey(d => d.doer_id);

        }
    }
}
