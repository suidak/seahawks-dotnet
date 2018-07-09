using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class breedingofferMap : EntityTypeConfiguration<breedingoffer>
    {
        public breedingofferMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.titre)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("breedingoffer", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.closed).HasColumnName("closed");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.located).HasColumnName("located");
            this.Property(t => t.titre).HasColumnName("titre");
            this.Property(t => t.animal_id).HasColumnName("animal_id");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.idAnimal).HasColumnName("idAnimal");

            // Relationships
            this.HasOptional(t => t.animal)
                .WithMany(t => t.breedingoffers)
                .HasForeignKey(d => d.animal_id);

        }
    }
}
