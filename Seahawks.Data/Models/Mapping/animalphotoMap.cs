using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class animalphotoMap : EntityTypeConfiguration<animalphoto>
    {
        public animalphotoMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.photo)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("animalphoto", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.photo).HasColumnName("photo");
            this.Property(t => t.animal_id).HasColumnName("animal_id");

            // Relationships
            this.HasOptional(t => t.animal)
                .WithMany(t => t.animalphotoes)
                .HasForeignKey(d => d.animal_id);

        }
    }
}
