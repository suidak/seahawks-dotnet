using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class adoptionofferMap : EntityTypeConfiguration<adoptionoffer>
    {
        public adoptionofferMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("adoptionoffer", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.offerDate).HasColumnName("offerDate");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.animal_id).HasColumnName("animal_id");

            // Relationships
            this.HasOptional(t => t.animal)
                .WithMany(t => t.adoptionoffers)
                .HasForeignKey(d => d.animal_id);

        }
    }
}
