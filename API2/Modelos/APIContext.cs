using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API2;

namespace API2
{
    public partial class APIContext:DbContext
    {
        public APIContext(DbContextOptions<APIContext> options)
        : base(options)
        {
        }
        public virtual DbSet<Cientifico> Cientificos { get; set; }
        public virtual DbSet<Poryecto> Proyectos { get; set; }
        public virtual DbSet<Asignado> Asignados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cientifico>(entity =>
            {
                entity.ToTable("Cientificos");
                entity.HasKey(e => e.Dni);
                entity.Property(e => e.Dni).HasColumnName("DNI");

                entity.Property(e => e.NomApels)
                .HasColumnName("NomApels")
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Poryecto>(entity =>
            {
                entity.ToTable("Proyecto");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                .HasColumnName("Id")
                .HasMaxLength(4);

                entity.Property(e => e.Nombre)
                .HasColumnName("Nombre")
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

                entity.Property(e => e.Horas)
                .HasColumnName("Horas")
                .IsRequired()
                .IsUnicode(false);
            }
            );

            modelBuilder.Entity<Asignado>(entity =>
            {
                entity.ToTable("Asignado");
                entity.HasKey(e => e.Proyecto);
                entity.HasKey(j => j.Cientifico);
                entity.Property(e => e.Proyecto)
                .HasColumnName("Proyecto");
                entity.Property(e => e.Cientifico)
                .HasColumnName("Cientifico");

                entity.HasOne(d => d.Cienti)
                .WithMany(e => e.Asignados)
                .HasForeignKey(d => d.Cientifico)
                .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Proyec)
                .WithMany(e => e.Asignados)
                .HasForeignKey(d => d.Proyecto)
                .OnDelete(DeleteBehavior.ClientSetNull);
            }
            )
            ;
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
