﻿// <auto-generated />
using HtmlHelpersCore2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HtmlHelpersCore2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190329205547_modelTweaks")]
    partial class modelTweaks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HtmlHelpersCore2.Models.User", b =>
                {
                    b.Property<int>("Cedula")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<int>("Edad");

                    b.Property<string>("Email");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("Telefono");

                    b.Property<string>("UserEstadoCivil");

                    b.Property<int>("UserGenero");

                    b.Property<bool>("isDormir");

                    b.Property<bool>("isMusica");

                    b.Property<bool>("isNetflix");

                    b.Property<bool>("isProgramar");

                    b.HasKey("Cedula");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
