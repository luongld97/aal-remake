using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model.Models;

namespace Data
{
  public class AALDbContext : DbContext
  {
    private readonly IConfiguration _configuration;

    public AALDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
    {
      _configuration = configuration;
    }

    // DbSet
    
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);
      optionsBuilder.UseMySql(_configuration.GetConnectionString("AALConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      
      // Many-to-many User and Role
      modelBuilder.Entity<UserRole>().HasKey(
        ur => new {ur.UserId, ur.RoleId}
      );
    }
  }
}