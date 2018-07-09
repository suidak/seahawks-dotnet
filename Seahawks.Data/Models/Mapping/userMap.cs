using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Seahawks.Domain.Entities;

namespace Seahawks.Data.Models.Mapping
{
    public class userMap : EntityTypeConfiguration<user>
    {
        public userMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.DTYPE)
                .IsRequired()
                .HasMaxLength(31);

            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.login)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.photo)
                .HasMaxLength(255);

            this.Property(t => t.status)
                .HasMaxLength(32);

            this.Property(t => t.token)
                .HasMaxLength(255);

            this.Property(t => t.firstName)
                .HasMaxLength(255);

            this.Property(t => t.lastName)
                .HasMaxLength(255);

            this.Property(t => t.orgName)
                .HasMaxLength(255);

            this.Property(t => t.phoneNumber)
                .HasMaxLength(255);

            this.Property(t => t.role)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("user", "seahawks");
            this.Property(t => t.DTYPE).HasColumnName("DTYPE");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.lastLogin).HasColumnName("lastLogin");
            this.Property(t => t.login).HasColumnName("login");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.photo).HasColumnName("photo");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.token).HasColumnName("token");
            this.Property(t => t.firstName).HasColumnName("firstName");
            this.Property(t => t.lastName).HasColumnName("lastName");
            this.Property(t => t.foundDate).HasColumnName("foundDate");
            this.Property(t => t.orgName).HasColumnName("orgName");
            this.Property(t => t.address_id).HasColumnName("address_id");
            this.Property(t => t.phoneNumber).HasColumnName("phoneNumber");
            this.Property(t => t.role).HasColumnName("role");
            this.Property(t => t.vet).HasColumnName("vet");

            // Relationships
            this.HasOptional(t => t.address)
                .WithMany(t => t.users)
                .HasForeignKey(d => d.address_id);

        }
    }
}
