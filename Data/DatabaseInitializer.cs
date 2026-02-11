using Microsoft.EntityFrameworkCore;

namespace GoodsReceipt.Data;

public static class DatabaseInitializer
{
    public static void Initialize()
    {
        using var db = new AppDbContext();
        db.Database.EnsureCreated();
    }
}
