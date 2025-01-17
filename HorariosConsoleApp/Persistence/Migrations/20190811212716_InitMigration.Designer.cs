﻿// <auto-generated />
using System;
using HorariosConsoleApp.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HorariosConsoleApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190811212716_InitMigration")]
    partial class InitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HorariosConsoleApp.Entities.Dia", b =>
                {
                    b.Property<int>("DiaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abreviatura");

                    b.Property<string>("Nombre");

                    b.Property<decimal>("Remuneracion");

                    b.HasKey("DiaId");

                    b.ToTable("Dias");
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.Empleado", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<string>("Nombre");

                    b.HasKey("EmpleadoId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.EmpleadoEquipo", b =>
                {
                    b.Property<int>("EmpleadoEquipoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpleadoId");

                    b.Property<int>("EquipoId");

                    b.Property<DateTime>("Fecha");

                    b.HasKey("EmpleadoEquipoId");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("EquipoId");

                    b.ToTable("EmpleadosEquipos");
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.Equipo", b =>
                {
                    b.Property<int>("EquipoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("EquipoId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.EquipoHorario", b =>
                {
                    b.Property<int>("EquipoHorarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EquipoId");

                    b.Property<DateTime>("Fecha");

                    b.Property<int>("HorarioId");

                    b.HasKey("EquipoHorarioId");

                    b.HasIndex("EquipoId");

                    b.HasIndex("HorarioId");

                    b.ToTable("EquipoHorarios");
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.Hora", b =>
                {
                    b.Property<int>("HoraId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("HoraLSpan");

                    b.Property<int>("TipoHoraId");

                    b.HasKey("HoraId");

                    b.HasIndex("TipoHoraId");

                    b.ToTable("Horas");
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.Horario", b =>
                {
                    b.Property<int>("HorarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.HasKey("HorarioId");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.HorarioDetalle", b =>
                {
                    b.Property<int>("HorarioDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiaId");

                    b.Property<int?>("HoraFinId");

                    b.Property<int?>("HoraInicioId");

                    b.Property<int>("HorarioId");

                    b.HasKey("HorarioDetalleId");

                    b.HasIndex("DiaId");

                    b.HasIndex("HoraFinId");

                    b.HasIndex("HoraInicioId");

                    b.HasIndex("HorarioId");

                    b.ToTable("HorarioDetalles");
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.TipoHora", b =>
                {
                    b.Property<int>("TipoHoraId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.Property<decimal>("Remuneracion");

                    b.HasKey("TipoHoraId");

                    b.ToTable("TipoHoras");
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.EmpleadoEquipo", b =>
                {
                    b.HasOne("HorariosConsoleApp.Entities.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HorariosConsoleApp.Entities.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.EquipoHorario", b =>
                {
                    b.HasOne("HorariosConsoleApp.Entities.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HorariosConsoleApp.Entities.Horario", "Horario")
                        .WithMany()
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.Hora", b =>
                {
                    b.HasOne("HorariosConsoleApp.Entities.TipoHora", "TipoHora")
                        .WithMany()
                        .HasForeignKey("TipoHoraId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.HorarioDetalle", b =>
                {
                    b.HasOne("HorariosConsoleApp.Entities.Dia", "Dia")
                        .WithMany()
                        .HasForeignKey("DiaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HorariosConsoleApp.Entities.Hora", "HoraFin")
                        .WithMany()
                        .HasForeignKey("HoraFinId");

                    b.HasOne("HorariosConsoleApp.Entities.Hora", "HoraInicio")
                        .WithMany()
                        .HasForeignKey("HoraInicioId");

                    b.HasOne("HorariosConsoleApp.Entities.Horario", "Horario")
                        .WithMany()
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
