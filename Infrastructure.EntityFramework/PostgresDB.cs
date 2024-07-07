using Domain.Entities.Classes;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;


namespace Infrastructure.DataAcess
{
    public class PostgresDB : DbContext
    {
        public PostgresDB(DbContextOptions<PostgresDB> options) : base(options)
        {
        }


        public DbSet<User> User { get; set; }

        public DbSet<UserGroup> UserGroups { get; set; }

        public DbSet<Questionnaire> Questionnaire { get; set; }

        public PostgresDB()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=postgres;Username=postgres;Password=admin");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<User>().ToTable("user");
            modelBuilder.Entity<UserGroup>().ToTable("usergroup");

            modelBuilder.Entity<User>().Property(c => c.FirstName).HasMaxLength(256);
            modelBuilder.Entity<User>().Property(c => c.LastName).HasMaxLength(256);
            modelBuilder.Entity<User>().Property(c => c.Department).HasMaxLength(512);
            modelBuilder.Entity<User>().Property(c => c.Email).HasMaxLength(256);
            modelBuilder.Entity<Group>().Property(c => c.Name).HasMaxLength(512);
        }
    }
}