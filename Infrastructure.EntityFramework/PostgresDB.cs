using Domain.Entities.Classes;
using Microsoft.EntityFrameworkCore;

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
            optionsBuilder.UseNpgsql("Host=84.201.158.212;Port=5432;Database=questionnaire;Username=admin;Password=admin");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<User>()
            //    .HasKey(x => x.Id);

            modelBuilder.Entity<User>().ToTable("user");
            modelBuilder.Entity<UserGroup>().ToTable("usergroup");

            modelBuilder.Entity<User>().Property(c => c.FirstName).HasMaxLength(256);
            modelBuilder.Entity<User>().Property(c => c.LastName).HasMaxLength(256);
            modelBuilder.Entity<User>().Property(c => c.Department).HasMaxLength(512);
            modelBuilder.Entity<User>().Property(c => c.Email).HasMaxLength(256);
            modelBuilder.Entity<UserGroup>().Property(c => c.Name).HasMaxLength(512);

            modelBuilder.Entity<User>().Property(u => u.Id).ValueGeneratedOnAdd();

            // Добавлено: Убедитесь, что у сущности Capture есть конструктор без параметров или что все параметры конструктора могут быть связаны с свойствами сущности.
            modelBuilder.Entity<Capture>().HasKey(c => c.Id);
            modelBuilder.Entity<Capture>().Property(c => c.Text).HasMaxLength(256);
        }
    }
}