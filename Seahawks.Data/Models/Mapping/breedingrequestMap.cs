using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;
namespace Seahawks.Data.Models.Mapping
{
    public class breedingrequestMap : EntityTypeConfiguration<breedingrequest>
    {
        public breedingrequestMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.status)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("breedingrequest", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.accepted).HasColumnName("accepted");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.member_id).HasColumnName("member_id");
            this.Property(t => t.offer_id).HasColumnName("offer_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.animal_id).HasColumnName("animal_id");

            // Relationships
            this.HasOptional(t => t.animal)
                .WithMany(t => t.breedingrequests)
                .HasForeignKey(d => d.animal_id);
            this.HasOptional(t => t.breedingoffer)
                .WithMany(t => t.breedingrequests)
                .HasForeignKey(d => d.offer_id);
            this.HasOptional(t => t.user)
                .WithMany(t => t.breedingrequests)
                .HasForeignKey(d => d.member_id);

        }
    }
}
