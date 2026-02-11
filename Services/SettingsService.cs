using GoodsReceipt.Data;
using GoodsReceipt.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodsReceipt.Services;

public class SettingsService
{
    public AppSettings Load()
    {
        using var db = new AppDbContext();
        return db.Settings.FirstOrDefault() ?? new AppSettings { Id = 1 };
    }

    public void Save(AppSettings settings)
    {
        using var db = new AppDbContext();
        var existing = db.Settings.FirstOrDefault();
        if (existing == null)
        {
            db.Settings.Add(settings);
        }
        else
        {
            existing.CompanyName = settings.CompanyName;
            existing.OfficeAddress = settings.OfficeAddress;
            existing.PhoneNumber = settings.PhoneNumber;
            existing.LastPrinterName = settings.LastPrinterName;
            existing.DefaultCopies = settings.DefaultCopies;
            existing.LastReceiptNumber = settings.LastReceiptNumber;
        }
        db.SaveChanges();
    }

    public string GenerateNextReceiptNumber()
    {
        using var db = new AppDbContext();
        var settings = db.Settings.FirstOrDefault();
        if (settings == null) return "REC-0001";

        settings.LastReceiptNumber++;
        db.SaveChanges();
        return $"REC-{settings.LastReceiptNumber:D4}";
    }
}
