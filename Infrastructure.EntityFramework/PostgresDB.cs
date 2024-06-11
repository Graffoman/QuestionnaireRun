using Domain.Entities.Classes;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.DataAcess
{
    public class PostgresDB : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Questionnaire> Questionnaire { get; set; }

        public PostgresDB()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=Test;Username=postgres;Password=postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<User>().Property(u => u.UserId).HasMaxLength(100);
            modelBuilder.Entity<User>().Property(u => u.Email).HasMaxLength(100);
            modelBuilder.Entity<User>().Property(u => u.FirstName).HasMaxLength(100);
            modelBuilder.Entity<User>().Property(u => u.LastName).HasMaxLength(100);
        }
    }
}