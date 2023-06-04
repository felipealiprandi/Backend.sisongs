using Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace Sisongs.Infrastructure.Data
{
    public class SisongsDbContext : DbContext
    {
        public SisongsDbContext(DbContextOptions<SisongsDbContext> options) : base(options)
        {
        }

        public DbSet<Ong> Ongs { get; set; }
        public DbSet<Projeto> Projetos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ong>(entity =>
            {
                entity.ToTable("ongs", "ongs");
                entity.HasKey(e => e.id);
            });

            modelBuilder.Entity<Projeto>(entity =>
            {
                entity.ToTable("projetos", "ongs");
                entity.HasKey(e => e.id);
            });
        }
    }
}