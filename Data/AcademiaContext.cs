using AcademiaMarcial.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademiaMarcial.Data
{
    public class AcademiaContext : DbContext
    {
        public AcademiaContext(DbContextOptions<AcademiaContext> options) : base(options)
        {
        }

        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .HasOne(a => a.Disciplina)
                .WithMany(d => d.Alumnos)
                .HasForeignKey(a => a.DisciplinaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}