using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class donationMap : EntityTypeConfiguration<donation>
    {
        public donationMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("donation", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.amount).HasColumnName("amount");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.donationDate).HasColumnName("donationDate");
            this.Property(t => t.tips).HasColumnName("tips");
            this.Property(t => t.donator_id).HasColumnName("donator_id");
            this.Property(t => t.organisation_id).HasColumnName("organisation_id");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.donations)
                .HasForeignKey(d => d.organisation_id);
            this.HasOptional(t => t.user1)
                .WithMany(t => t.donations1)
                .HasForeignKey(d => d.donator_id);

        }
    }
}
