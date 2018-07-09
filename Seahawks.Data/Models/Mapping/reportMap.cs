using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;
namespace Seahawks.Data.Models.Mapping
{
    public class reportMap : EntityTypeConfiguration<report>
    {
        public reportMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.reportCategory)
                .HasMaxLength(255);

            this.Property(t => t.title)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("report", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.closed).HasColumnName("closed");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.localisation).HasColumnName("localisation");
            this.Property(t => t.reportCategory).HasColumnName("reportCategory");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.reporterUser_id).HasColumnName("reporterUser_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.isClosed).HasColumnName("isClosed");
            this.Property(t => t.localisation_id).HasColumnName("localisation_id");

            // Relationships
            this.HasOptional(t => t.reportlocalisation)
                .WithMany(t => t.reports)
                .HasForeignKey(d => d.localisation_id);
            this.HasOptional(t => t.user)
                .WithMany(t => t.reports)
                .HasForeignKey(d => d.reporterUser_id);

        }
    }
}
