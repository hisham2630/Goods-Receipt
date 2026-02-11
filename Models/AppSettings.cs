using System.ComponentModel.DataAnnotations;

namespace GoodsReceipt.Models;

public class AppSettings
{
    [Key]
    public int Id { get; set; }

    [MaxLength(200)]
    public string CompanyName { get; set; } = "اسم الشركة";

    [MaxLength(500)]
    public string OfficeAddress { get; set; } = "العنوان";

    [MaxLength(50)]
    public string PhoneNumber { get; set; } = "07XX XXX XXXX";

    [MaxLength(200)]
    public string LastPrinterName { get; set; } = string.Empty;

    public int DefaultCopies { get; set; } = 2;

    public int LastReceiptNumber { get; set; } = 0;
}
