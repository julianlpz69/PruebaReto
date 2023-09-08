using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder){
    
            builder.ToTable("user");
    
            builder.Property(e => e.UserName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();


            builder.Property(e => e.UserEmail)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();



            builder.Property(e => e.UserPassword)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

                
            builder.HasMany(p => p.Rols)
            .WithMany(r => r.Users)
            .UsingEntity<UserRol>(

                j => j.HasOne(pt => pt.Rol)
                .WithMany(t => t.UsersRols)
                .HasForeignKey(ut => ut.IdRol),

                j => j.HasOne(et => et.User)
                .WithMany(et => et.UsersRols) 
                .HasForeignKey(h => h.IdUser),

                j => 
                {   
                    j.ToTable("userRols");
                    j.HasKey(t => new { t.IdUser, t.IdRol });
                }
            );
    
        }
    }
}