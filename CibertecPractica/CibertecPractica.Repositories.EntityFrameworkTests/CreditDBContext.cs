using CibertecPractica.Models;
using Microsoft.EntityFrameworkCore;

namespace CibertecPractica.Repositories.EntityFrameworkTests
{
    public class CreditDBContext : DbContext
    {
        public DbSet<Corporation> Corporation { get; set; }
        public DbSet<Member> Member { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Credit; Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Corporation>().ToTable("corporation");
            modelBuilder.Entity<Member>().ToTable("member");

        }

    }
}
