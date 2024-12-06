using System.Collections.Generic;
using System.Reflection.Emit;
using tshirt_factory.src.Models;
using Microsoft.EntityFrameworkCore;

namespace tshirt_factory.src.Context
{
    public class TShirtContext : DbContext
    {
        public DbSet<CustomTShirt> CustomTShirts { get; set; }

        public TShirtContext(DbContextOptions<TShirtContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CustomTShirt>().ToTable("CustomTShirts");
        }
    
    }
}
