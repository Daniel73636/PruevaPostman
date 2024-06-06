using evaluacion.Models;
using Microsoft.EntityFrameworkCore;

namespace evaluacion.Data
{
    public class PruevaDbContext : DbContext
    {
        public PruevaDbContext(DbContextOptions<PruevaDbContext> options) : base(options){}
        public DbSet<Curso> courses { get; set; }
        public DbSet<Estudiante> students {get; set;}
        public DbSet<Matricula> enrollments { get; set; }
        public DbSet<Profesor> teachers { get; set; }
    }
}