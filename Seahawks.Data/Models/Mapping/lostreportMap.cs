using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;
namespace Seahawks.Data.Models.Mapping
{
    public class lostreportMap : EntityTypeConfiguration<lostreport>
    {
        public lostreportMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("lostreport", "seahawks");
            this.Property(t => t.animal).HasColumnName("animal");
            this.Property(t => t.reward).HasColumnName("reward");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.animal_id).HasColumnName("animal_id");

            // Relationships
            this.HasOptional(t => t.animal1)
                .WithMany(t => t.lostreports)
                .HasForeignKey(d => d.animal_id);
            this.HasRequired(t => t.report)
                .WithOptional(t => t.lostreport);

        }
    }
}
