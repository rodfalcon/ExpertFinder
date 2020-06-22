using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistance
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Value> Values { get; set;}
        public DbSet<Activity> Acitivities { get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>().HasData(
                new Value{Id = 1, Name = "Rodrigo"},
                new Value{Id = 2, Name = "Aoife"},
                new Value{Id = 3, Name = "Ernie and Jah"}
            );
        }
    }
}
