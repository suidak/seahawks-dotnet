using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class fundonationMap : EntityTypeConfiguration<fundonation>
    {
        public fundonationMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("fundonation", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.amount).HasColumnName("amount");
            this.Property(t => t.donationDate).HasColumnName("donationDate");
            this.Property(t => t.donator_id).HasColumnName("donator_id");
            this.Property(t => t.fundraiser_id).HasColumnName("fundraiser_id");

            // Relationships
            this.HasOptional(t => t.fundraiser)
                .WithMany(t => t.fundonations)
                .HasForeignKey(d => d.fundraiser_id);
            this.HasOptional(t => t.user)
                .WithMany(t => t.fundonations)
                .HasForeignKey(d => d.donator_id);

        }
    }
}
