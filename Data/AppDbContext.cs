using Microsoft.EntityFrameworkCore;
using GoodsReceipt.Models;

namespace GoodsReceipt.Data;

public class AppDbContext : DbContext
{
    public DbSet<Receipt> Receipts { get; set; } = null!;
    public DbSet<ReceiptItem> ReceiptItems { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<AppSettings> Settings { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "goods_receipt.db");
        options.UseSqlite($"Data Source={dbPath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Receipt>(entity =>
        {
            entity.HasIndex(r => r.ReceiptNumber).IsUnique();
            entity.HasMany(r => r.Items)
                  .WithOne(i => i.Receipt)
                  .HasForeignKey(i => i.ReceiptId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<ReceiptItem>(entity =>
        {
            entity.Ignore(i => i.Subtotal);
        });

        modelBuilder.Entity<AppSettings>().HasData(new AppSettings
        {
            Id = 1,
            CompanyName = "اسم الشركة",
            OfficeAddress = "العنوان",
            PhoneNumber = "07XX XXX XXXX",
            DefaultCopies = 2,
            LastReceiptNumber = 0
        });
    }
}
