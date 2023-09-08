﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia.Data.Configurations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(PruebaRetoDBContetx))]
    partial class PruebaRetoDBContetxModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreRol")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.UserRol", b =>
                {
                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.HasKey("IdUser", "IdRol");

                    b.HasIndex("IdRol");

                    b.ToTable("userRols", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.UserRol", b =>
                {
                    b.HasOne("Dominio.Entities.Rol", "Rol")
                        .WithMany("UsersRols")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.User", "User")
                        .WithMany("UsersRols")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Dominio.Entities.Rol", b =>
                {
                    b.Navigation("UsersRols");
                });

            modelBuilder.Entity("Dominio.Entities.User", b =>
                {
                    b.Navigation("UsersRols");
                });
#pragma warning restore 612, 618
        }
    }
}
