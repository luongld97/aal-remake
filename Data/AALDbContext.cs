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
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ExportInvoice> ExportInvoices { get; set; }
    public DbSet<ExportInvoiceDetail> ExportInvoiceDetails { get; set; }
    public DbSet<ImportInvoice> ImportInvoices { get; set; }
    public DbSet<ImportInvoiceDetail> ImportInvoiceDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<ExportBill> ExportBills { get; set; }
    public DbSet<ExportBillDetail> ExportBillDetails { get; set; }
    public DbSet<ImportBill> ImportBills { get; set; }
    public DbSet<ImportBillDetail> ImportBillDetails { get; set; }
    public DbSet<ProductRate> ProductRates { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Promotion> Promotions { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<WarehouseDetail> WarehouseDetails { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);
      optionsBuilder.UseMySql(
        _configuration.GetConnectionString("AALConnection"),
        b => b.MigrationsAssembly("AutoAncillariesLimited")
      );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      // Many-to-many User and Role
      modelBuilder.Entity<UserRole>().HasKey(
        ur => new {ur.UserId, ur.RoleId}
      );
      
      // Many-to-many Product and Promotion
      modelBuilder.Entity<ProductPromotion>().HasKey(
        ur => new {ur.ProductId, ur.PromotionId}
      );
    }
  }
}