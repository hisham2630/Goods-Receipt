using System.ComponentModel.DataAnnotations;

namespace GoodsReceipt.Models;

public class Receipt
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string ReceiptNumber { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? CustomerInfo { get; set; }

    [MaxLength(500)]
    public string? EmployeeInfo { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public decimal Total { get; set; }

    public List<ReceiptItem> Items { get; set; } = new();
}
