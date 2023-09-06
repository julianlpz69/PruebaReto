using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder){
    
            builder.ToTable("rol");
    
            builder.Property(e => e.NombreRol)
                .HasMaxLength(30);
    
        }
    }
}  