using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class lostreviewMap : EntityTypeConfiguration<lostreview>
    {
        public lostreviewMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("lostreview", "seahawks");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.reportLost_id).HasColumnName("reportLost_id");

            // Relationships
            this.HasOptional(t => t.lostreport)
                .WithMany(t => t.lostreviews)
                .HasForeignKey(d => d.reportLost_id);
            this.HasRequired(t => t.review)
                .WithOptional(t => t.lostreview);

        }
    }
}
