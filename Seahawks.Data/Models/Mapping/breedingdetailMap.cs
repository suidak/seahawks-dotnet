using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;
namespace Seahawks.Data.Models.Mapping
{
    public class breedingdetailMap : EntityTypeConfiguration<breedingdetail>
    {
        public breedingdetailMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.statut)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("breedingdetails", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.babiesNumber).HasColumnName("babiesNumber");
            this.Property(t => t.dateAction).HasColumnName("dateAction");
            this.Property(t => t.dateBreeding).HasColumnName("dateBreeding");
            this.Property(t => t.dateConfirmed).HasColumnName("dateConfirmed");
            this.Property(t => t.statut).HasColumnName("statut");
            this.Property(t => t.addressBreeding_id).HasColumnName("addressBreeding_id");
            this.Property(t => t.breedingRequest_id).HasColumnName("breedingRequest_id");

            // Relationships
            this.HasOptional(t => t.address)
                .WithMany(t => t.breedingdetails)
                .HasForeignKey(d => d.addressBreeding_id);
            this.HasOptional(t => t.breedingrequest)
                .WithMany(t => t.breedingdetails)
                .HasForeignKey(d => d.breedingRequest_id);

        }
    }
}
