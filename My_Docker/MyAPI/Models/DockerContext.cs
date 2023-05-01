using System;
using Microsoft.EntityFrameworkCore;

namespace MyAPI.Models
{
    public class DockerContext : DbContext
    {
        public DbSet<Students> Students { get; set;}

        
        public DockerContext(DbContextOptions<DockerContext> options):base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Students>().HasData(
                new Students
                {
                    Id = Guid.NewGuid(),
                    Name = "Bob"
                },
                new Students
                {
                    Id = Guid.NewGuid(),
                    Name = "Tony"
                }
            );
        }
    }
}