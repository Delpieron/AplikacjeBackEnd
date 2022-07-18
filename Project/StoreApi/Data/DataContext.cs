using Microsoft.EntityFrameworkCore;
using StoreApi.Enums;
using StoreApi.Model;
using StoreApi.Models;

namespace StoreApi
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> user { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<CarPart> CarParts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasKey(x => x.Id);
            modelBuilder.Entity<Permission>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().HasKey(x => x.id);
            modelBuilder.Entity<CarPart>().HasKey(x => x.Id);
            modelBuilder.Entity<Permission>().HasData(
                new Permission { Id = 1, Name = PermissionEnum.Admin });
            modelBuilder.Entity<Permission>().HasData(
                new Permission { Id = 2, Name = PermissionEnum.User });

            modelBuilder.Entity<User>().HasData(
                new User { id = 1, EmailAdress = "kw@poczta.pl", Name = "Krzysztof", LastName = "Wróblewski", Password = "haslo123", PermissionId = 1 });
            base.OnModelCreating(modelBuilder);
        }
    }
}
