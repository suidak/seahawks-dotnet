using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class animalMap : EntityTypeConfiguration<animal>
    {
        public animalMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.breed)
                .HasMaxLength(255);

            this.Property(t => t.sex)
                .HasMaxLength(255);

            this.Property(t => t.specie)
                .HasMaxLength(255);

            this.Property(t => t.status)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("animal", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.age).HasColumnName("age");
            this.Property(t => t.breed).HasColumnName("breed");
            this.Property(t => t.castrated).HasColumnName("castrated");
            this.Property(t => t.fostered).HasColumnName("fostered");
            this.Property(t => t.height).HasColumnName("height");
            this.Property(t => t.lost).HasColumnName("lost");
            this.Property(t => t.sex).HasColumnName("sex");
            this.Property(t => t.specie).HasColumnName("specie");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.weight).HasColumnName("weight");
            this.Property(t => t.owner_id).HasColumnName("owner_id");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.animals)
                .HasForeignKey(d => d.owner_id);

        }
    }
}
