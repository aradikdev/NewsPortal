using Microsoft.EntityFrameworkCore;
using NewsPortal.Models;

namespace NewsPortal.Data
{
    public class NewsPortalDbContext : DbContext
    {
        public NewsPortalDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users{ get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Category> Categories { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role { Id = 1, Name = "admin" });
            modelBuilder.Entity<Role>().HasData(new Role { Id = 2, Name = "user" });
            modelBuilder.Entity<User>().HasData(new User { Id = 1, Email = "admin@admin.admin", Password = "admin@admin.admin", RoleId = 1 });
        }

    }
}
