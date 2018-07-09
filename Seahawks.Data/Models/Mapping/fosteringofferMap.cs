using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class fosteringofferMap : EntityTypeConfiguration<fosteringoffer>
    {
        public fosteringofferMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("fosteringoffer", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.endDate).HasColumnName("endDate");
            this.Property(t => t.startDate).HasColumnName("startDate");
            this.Property(t => t.animal_id).HasColumnName("animal_id");

            // Relationships
            this.HasOptional(t => t.animal)
                .WithMany(t => t.fosteringoffers)
                .HasForeignKey(d => d.animal_id);

        }
    }
}
