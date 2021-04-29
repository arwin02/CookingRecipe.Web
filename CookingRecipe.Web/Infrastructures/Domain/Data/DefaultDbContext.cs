using CookingRecipe.Web.Infrastructures.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CookingRecipe.Web.Infrastructures.Domain.Data
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Cooking> Cookings { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Instruction> Instructions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<UserRole>().ToTable("UserRole");
            modelBuilder.Entity<Cooking>().ToTable("Cooking");
            modelBuilder.Entity<Ingredient>().ToTable("Ingredient");
            modelBuilder.Entity<Instruction>().ToTable("Instruction");

        }
    }
}

