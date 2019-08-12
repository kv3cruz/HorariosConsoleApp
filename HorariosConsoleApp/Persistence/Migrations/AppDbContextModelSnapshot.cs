﻿// <auto-generated />
using System;
using HorariosConsoleApp.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HorariosConsoleApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasKey("DiaId");

                    b.ToTable("Dias");

                    b.HasData(
                        new
                        {
                            DiaId = 1,
                            Abreviatura = "L",
                            Nombre = "Lunes"
                        },
                        new
                        {
                            DiaId = 2,
                            Abreviatura = "M",
                            Nombre = "Martes"
                        },
                        new
                        {
                            DiaId = 3,
                            Abreviatura = "X",
                            Nombre = "Miércoles"
                        },
                        new
                        {
                            DiaId = 4,
                            Abreviatura = "J",
                            Nombre = "Jueves"
                        },
                        new
                        {
                            DiaId = 5,
                            Abreviatura = "V",
                            Nombre = "Viernes"
                        },
                        new
                        {
                            DiaId = 6,
                            Abreviatura = "S",
                            Nombre = "Sábado"
                        },
                        new
                        {
                            DiaId = 7,
                            Abreviatura = "D",
                            Nombre = "Domingo"
                        });
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

                    b.HasData(
                        new
                        {
                            EmpleadoId = 1,
                            Apellido = "Perez",
                            Nombre = "Juan"
                        },
                        new
                        {
                            EmpleadoId = 2,
                            Apellido = "Mitnick",
                            Nombre = "Kevin"
                        },
                        new
                        {
                            EmpleadoId = 3,
                            Apellido = "Quezada",
                            Nombre = "Jose"
                        },
                        new
                        {
                            EmpleadoId = 4,
                            Apellido = "Rulfo",
                            Nombre = "Juan"
                        });
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

                    b.HasData(
                        new
                        {
                            EquipoId = 1,
                            Nombre = "Zebra"
                        },
                        new
                        {
                            EquipoId = 2,
                            Nombre = "Bravo"
                        },
                        new
                        {
                            EquipoId = 3,
                            Nombre = "Ranger"
                        });
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

                    b.Property<TimeSpan>("Horaspan");

                    b.HasKey("HoraId");

                    b.ToTable("Horas");

                    b.HasData(
                        new
                        {
                            HoraId = 1,
                            Horaspan = new TimeSpan(0, 0, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 2,
                            Horaspan = new TimeSpan(0, 1, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 3,
                            Horaspan = new TimeSpan(0, 2, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 4,
                            Horaspan = new TimeSpan(0, 3, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 5,
                            Horaspan = new TimeSpan(0, 4, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 6,
                            Horaspan = new TimeSpan(0, 5, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 7,
                            Horaspan = new TimeSpan(0, 6, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 8,
                            Horaspan = new TimeSpan(0, 7, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 9,
                            Horaspan = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 10,
                            Horaspan = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 11,
                            Horaspan = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 12,
                            Horaspan = new TimeSpan(0, 11, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 13,
                            Horaspan = new TimeSpan(0, 12, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 14,
                            Horaspan = new TimeSpan(0, 13, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 15,
                            Horaspan = new TimeSpan(0, 14, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 16,
                            Horaspan = new TimeSpan(0, 15, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 17,
                            Horaspan = new TimeSpan(0, 16, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 18,
                            Horaspan = new TimeSpan(0, 17, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 19,
                            Horaspan = new TimeSpan(0, 18, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 20,
                            Horaspan = new TimeSpan(0, 19, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 21,
                            Horaspan = new TimeSpan(0, 20, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 22,
                            Horaspan = new TimeSpan(0, 21, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 23,
                            Horaspan = new TimeSpan(0, 22, 0, 0, 0)
                        },
                        new
                        {
                            HoraId = 24,
                            Horaspan = new TimeSpan(0, 23, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.HoraDetalle", b =>
                {
                    b.Property<int>("HoraDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HoraId");

                    b.Property<int>("HorarioFraccionId");

                    b.Property<int>("TipoHoraId");

                    b.HasKey("HoraDetalleId");

                    b.HasIndex("HoraId");

                    b.HasIndex("HorarioFraccionId");

                    b.HasIndex("TipoHoraId");

                    b.ToTable("HoraDetalles");
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.Horario", b =>
                {
                    b.Property<int>("HorarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abreviatura");

                    b.Property<string>("Alias");

                    b.Property<string>("Descripcion");

                    b.HasKey("HorarioId");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.HorarioFraccion", b =>
                {
                    b.Property<int>("HorarioFraccionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiaId");

                    b.Property<int?>("HoraFinId");

                    b.Property<int?>("HoraInicioId");

                    b.Property<int?>("HorarioId");

                    b.HasKey("HorarioFraccionId");

                    b.HasIndex("DiaId");

                    b.HasIndex("HoraFinId");

                    b.HasIndex("HoraInicioId");

                    b.HasIndex("HorarioId");

                    b.ToTable("HorarioFraccion");
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.TipoHora", b =>
                {
                    b.Property<int>("TipoHoraId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.Property<decimal>("PorcentajeExtra");

                    b.HasKey("TipoHoraId");

                    b.ToTable("TipoHoras");

                    b.HasData(
                        new
                        {
                            TipoHoraId = 1,
                            Nombre = "Hora Extra Ordinaria Diurna",
                            PorcentajeExtra = 100m
                        },
                        new
                        {
                            TipoHoraId = 2,
                            Nombre = "Hora Extra  Nocturna",
                            PorcentajeExtra = 125m
                        },
                        new
                        {
                            TipoHoraId = 3,
                            Nombre = "Hora Ordinaria Nocturana",
                            PorcentajeExtra = 25m
                        },
                        new
                        {
                            TipoHoraId = 4,
                            Nombre = "Domingo Hora Ordinaria Diurna",
                            PorcentajeExtra = 300m
                        },
                        new
                        {
                            TipoHoraId = 5,
                            Nombre = "Hora Ordinaria Diura",
                            PorcentajeExtra = 0m
                        });
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.EmpleadoEquipo", b =>
                {
                    b.HasOne("HorariosConsoleApp.Entities.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HorariosConsoleApp.Entities.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.EquipoHorario", b =>
                {
                    b.HasOne("HorariosConsoleApp.Entities.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HorariosConsoleApp.Entities.Horario", "Horario")
                        .WithMany()
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.HoraDetalle", b =>
                {
                    b.HasOne("HorariosConsoleApp.Entities.Hora", "Hora")
                        .WithMany()
                        .HasForeignKey("HoraId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HorariosConsoleApp.Entities.HorarioFraccion", "HorarioFraccion")
                        .WithMany()
                        .HasForeignKey("HorarioFraccionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HorariosConsoleApp.Entities.TipoHora", "TipoHora")
                        .WithMany()
                        .HasForeignKey("TipoHoraId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("HorariosConsoleApp.Entities.HorarioFraccion", b =>
                {
                    b.HasOne("HorariosConsoleApp.Entities.Dia", "Dia")
                        .WithMany()
                        .HasForeignKey("DiaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HorariosConsoleApp.Entities.Hora", "HoraFin")
                        .WithMany()
                        .HasForeignKey("HoraFinId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HorariosConsoleApp.Entities.Hora", "HoraInicio")
                        .WithMany()
                        .HasForeignKey("HoraInicioId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HorariosConsoleApp.Entities.Horario")
                        .WithMany("HorarioFraccion")
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
