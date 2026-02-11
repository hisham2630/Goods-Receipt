using GoodsReceipt.Data;
using GoodsReceipt.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodsReceipt.Services;

public class ProductService
{
    public List<Product> GetAll()
    {
        using var db = new AppDbContext();
        return db.Products.Where(p => p.IsActive).OrderBy(p => p.Name).ToList();
    }

    public void Add(Product product)
    {
        using var db = new AppDbContext();
        db.Products.Add(product);
        db.SaveChanges();
    }

    public void Update(Product product)
    {
        using var db = new AppDbContext();
        var existing = db.Products.Find(product.Id);
        if (existing == null) return;

        existing.Name = product.Name;
        existing.DefaultPrice = product.DefaultPrice;
        db.SaveChanges();
    }

    public void Delete(int id)
    {
        using var db = new AppDbContext();
        var product = db.Products.Find(id);
        if (product == null) return;

        product.IsActive = false;
        db.SaveChanges();
    }
}
