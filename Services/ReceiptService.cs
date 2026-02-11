using GoodsReceipt.Data;
using GoodsReceipt.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodsReceipt.Services;

public class ReceiptService
{
    public Receipt Save(Receipt receipt)
    {
        using var db = new AppDbContext();
        db.Receipts.Add(receipt);
        db.SaveChanges();
        return receipt;
    }

    public List<Receipt> GetAll()
    {
        using var db = new AppDbContext();
        return db.Receipts
            .OrderByDescending(r => r.CreatedAt)
            .ToList();
    }

    public Receipt? GetById(int id)
    {
        using var db = new AppDbContext();
        return db.Receipts
            .Include(r => r.Items)
            .FirstOrDefault(r => r.Id == id);
    }

    public List<Receipt> Search(string query)
    {
        using var db = new AppDbContext();
        return db.Receipts
            .Where(r => r.ReceiptNumber.Contains(query) ||
                        (r.CustomerInfo != null && r.CustomerInfo.Contains(query)))
            .OrderByDescending(r => r.CreatedAt)
            .ToList();
    }
}
