﻿// <auto-generated />
using FeijooJ_Progreso1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FeijooJ_Progreso1.Migrations
{
    [DbContext(typeof(FeijooJ_Progreso1Context))]
    partial class FeijooJ_Progreso1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FeijooJ_Progreso1.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Edad")
                        .HasMaxLength(20)
                        .HasColumnType("float");

                    b.Property<string>("FechaEntrada")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FechaSalida")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FeijooJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("SeHospedoAntes")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("FeijooJ_Progreso1.Models.PlanRecompensa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FechaInicioP")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NoReservas")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("PlanRecompensa");
                });

            modelBuilder.Entity("FeijooJ_Progreso1.Models.Reserva", b =>
                {
                    b.Property<string>("FechaEntradaCliente")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FechaSalidaCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdentificacionCliente")
                        .HasColumnType("int");

                    b.Property<double>("ValorAPagar")
                        .HasMaxLength(20)
                        .HasColumnType("float");

                    b.HasKey("FechaEntradaCliente");

                    b.HasIndex("IdentificacionCliente");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("FeijooJ_Progreso1.Models.Reserva", b =>
                {
                    b.HasOne("FeijooJ_Progreso1.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdentificacionCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
