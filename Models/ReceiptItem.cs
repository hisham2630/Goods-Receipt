using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsReceipt.Models;

public class ReceiptItem
{
    [Key]
    public int Id { get; set; }

    public int ReceiptId { get; set; }

    [ForeignKey(nameof(ReceiptId))]
    public Receipt? Receipt { get; set; }

    [Required]
    [MaxLength(200)]
    public string ProductName { get; set; } = string.Empty;

    public int Quantity { get; set; } = 1;

    public decimal UnitPrice { get; set; }

    public decimal Subtotal => Quantity * UnitPrice;
}
