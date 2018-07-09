using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;
namespace Seahawks.Data.Models.Mapping
{
    public class requestownershipMap : EntityTypeConfiguration<requestownership>
    {
        public requestownershipMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.image)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("requestownership", "seahawks");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.closed).HasColumnName("closed");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.image).HasColumnName("image");
            this.Property(t => t.knowOwner).HasColumnName("knowOwner");
            this.Property(t => t.mine).HasColumnName("mine");
            this.Property(t => t.member_id).HasColumnName("member_id");
            this.Property(t => t.report_id).HasColumnName("report_id");

            // Relationships
            this.HasOptional(t => t.foundreport)
                .WithMany(t => t.requestownerships)
                .HasForeignKey(d => d.report_id);
            this.HasOptional(t => t.user)
                .WithMany(t => t.requestownerships)
                .HasForeignKey(d => d.member_id);

        }
    }
}
