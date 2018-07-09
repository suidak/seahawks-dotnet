using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class fosteringrequestMap : EntityTypeConfiguration<fosteringrequest>
    {
        public fosteringrequestMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("fosteringrequest", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.accepted).HasColumnName("accepted");
            this.Property(t => t.offer_id).HasColumnName("offer_id");

            // Relationships
            this.HasOptional(t => t.fosteringoffer)
                .WithMany(t => t.fosteringrequests)
                .HasForeignKey(d => d.offer_id);

        }
    }
}
