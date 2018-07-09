using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class adoptionrequestMap : EntityTypeConfiguration<adoptionrequest>
    {
        public adoptionrequestMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("adoptionrequest", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.accepted).HasColumnName("accepted");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.adopter_id).HasColumnName("adopter_id");
            this.Property(t => t.offer_id).HasColumnName("offer_id");
            this.Property(t => t.status).HasColumnName("status");

            // Relationships
            this.HasOptional(t => t.adoptionoffer)
                .WithMany(t => t.adoptionrequests)
                .HasForeignKey(d => d.offer_id);
            this.HasOptional(t => t.user)
                .WithMany(t => t.adoptionrequests)
                .HasForeignKey(d => d.adopter_id);

        }
    }
}
