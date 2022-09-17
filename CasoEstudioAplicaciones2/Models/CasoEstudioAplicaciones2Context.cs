using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CasoEstudioAplicaciones2.Models
{
    public partial class CasoEstudioAplicaciones2Context : DbContext
    {
        public CasoEstudioAplicaciones2Context()
        {
        }

        public CasoEstudioAplicaciones2Context(DbContextOptions<CasoEstudioAplicaciones2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("server=LAPTOP-KIU4OBU4\\SQLEXPRESS; database=CasoEstudioAplicaciones2; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NombreAlumno)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Nota1).HasColumnName("Nota1");

                entity.Property(e => e.Nota2).HasColumnName("Nota2");

                entity.Property(e => e.Nota3).HasColumnName("Nota3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
