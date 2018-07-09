using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class fundraiserMap : EntityTypeConfiguration<fundraiser>
    {
        public fundraiserMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.title)
                .HasMaxLength(255);

            this.Property(t => t.location)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("fundraiser", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.collectedDonations).HasColumnName("collectedDonations");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.endDate).HasColumnName("endDate");
            this.Property(t => t.goal).HasColumnName("goal");
            this.Property(t => t.startDate).HasColumnName("startDate");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.launcher_id).HasColumnName("launcher_id");
            this.Property(t => t.location).HasColumnName("location");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.fundraisers)
                .HasForeignKey(d => d.launcher_id);

        }
    }
}
