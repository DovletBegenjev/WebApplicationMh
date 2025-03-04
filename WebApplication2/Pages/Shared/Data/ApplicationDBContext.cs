using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication2.Pages.Shared.Models;
namespace Production.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<FormData> FormDataEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FormData>().ToTable("Production");
        }
    }
}