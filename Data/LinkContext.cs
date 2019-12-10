using JohanniteLanding.Models;
using JohanniteLanding.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace JohanniteLanding.Data
{
    public class LinkContext : DbContext
    {
        public DbSet<Link> Links {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Link.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LinkConfiguration()).Seed();
        }
    }
}