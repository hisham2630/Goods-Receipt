using System.Drawing;
using System.Drawing.Printing;
using GoodsReceipt.Models;

namespace GoodsReceipt.Services;

public enum PaperType
{
    Thermal58mm,
    Thermal80mm,
    A4
}

public class PrintEngine
{
    private Receipt _receipt = null!;
    private AppSettings _settings = null!;
    private PaperType _paperType;
    private Font _fontTitle = null!;
    private Font _fontNormal = null!;
    private Font _fontBold = null!;
    private Font _fontSmall = null!;

    public void Print(Receipt receipt, AppSettings settings, string printerName, int copies)
    {
        _receipt = receipt;
        _settings = settings;

        var printDoc = new PrintDocument();
        printDoc.PrinterSettings.PrinterName = printerName;
        printDoc.PrintPage += PrintPage;

        _paperType = DetectPaperType(printDoc.PrinterSettings);

        ApplyPaperSettings(printDoc);

        for (int i = 0; i < copies; i++)
        {
            printDoc.Print();
        }
    }

    public void Preview(Receipt receipt, AppSettings settings, string printerName)
    {
        _receipt = receipt;
        _settings = settings;

        var printDoc = new PrintDocument();
        printDoc.PrinterSettings.PrinterName = printerName;
        printDoc.PrintPage += PrintPage;

        _paperType = DetectPaperType(printDoc.PrinterSettings);
        ApplyPaperSettings(printDoc);

        var preview = new PrintPreviewDialog
        {
            Document = printDoc,
            Width = 800,
            Height = 600
        };

        if (_paperType is PaperType.Thermal58mm or PaperType.Thermal80mm)
        {
            preview.PrintPreviewControl.AutoZoom = false;
            preview.PrintPreviewControl.Zoom = 2.0;
        }

        preview.ShowDialog();
    }

    private PaperType DetectPaperType(PrinterSettings printerSettings)
    {
        var defaultPaper = printerSettings.DefaultPageSettings.PaperSize;
        float widthMm = defaultPaper.Width / 100f * 25.4f;

        if (widthMm <= 62) return PaperType.Thermal58mm;
        if (widthMm <= 85) return PaperType.Thermal80mm;
        return PaperType.A4;
    }

    private void ApplyPaperSettings(PrintDocument printDoc)
    {
        switch (_paperType)
        {
            case PaperType.Thermal58mm:
                printDoc.DefaultPageSettings.Margins = new Margins(5, 5, 5, 5);
                break;
            case PaperType.Thermal80mm:
                printDoc.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
                break;
            case PaperType.A4:
                printDoc.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);
                break;
        }
    }

    private void PrintPage(object sender, PrintPageEventArgs e)
    {
        var g = e.Graphics!;
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

        var bounds = e.MarginBounds;

        // =====================================================
        // RTL StringFormat guide:
        //   With DirectionRightToLeft flag:
        //     Near  = RIGHT side (start of RTL text)
        //     Far   = LEFT side  (end of RTL text)
        //     Center = center
        // =====================================================

        // Center-aligned (for title, footer)
        var sfCenter = new StringFormat(StringFormatFlags.DirectionRightToLeft)
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Near
        };

        // Right-aligned (for labels, receipt info — start side in RTL)
        var sfRight = new StringFormat(StringFormatFlags.DirectionRightToLeft)
        {
            Alignment = StringAlignment.Near,   // Near = RIGHT in RTL
            LineAlignment = StringAlignment.Near
        };

        // Left-aligned (for values on the opposite side)
        var sfLeft = new StringFormat(StringFormatFlags.DirectionRightToLeft)
        {
            Alignment = StringAlignment.Far,    // Far = LEFT in RTL
            LineAlignment = StringAlignment.Near
        };

        InitFonts();

        float y = bounds.Top;
        float x = bounds.Left;
        float width = bounds.Width;
        float right = x + width;

        bool isThermal = _paperType != PaperType.A4;

        // === HEADER: Company Name (centered) ===
        g.DrawString(_settings.CompanyName, _fontTitle, Brushes.Black,
            new RectangleF(x, y, width, _fontTitle.GetHeight(g) + 4), sfCenter);
        y += _fontTitle.GetHeight(g) + (isThermal ? 6 : 14);

        // === Separator ===
        y = DrawSeparator(g, x, y, width, isThermal);

        // === Receipt Info (right-aligned) ===
        string receiptInfo = $"رقم الوصل: {_receipt.ReceiptNumber}";
        g.DrawString(receiptInfo, _fontNormal, Brushes.Black,
            new RectangleF(x, y, width, 20), sfRight);
        y += _fontNormal.GetHeight(g) + 3;

        string dateValue = _receipt.CreatedAt.ToString("yyyy-MM-dd  h:mm:ss tt");
        string dateInfo = $"التاريخ: \u202A{dateValue}\u202C";
        g.DrawString(dateInfo, _fontNormal, Brushes.Black,
            new RectangleF(x, y, width, 20), sfRight);
        y += _fontNormal.GetHeight(g) + 3;

        if (!string.IsNullOrWhiteSpace(_receipt.CustomerInfo))
        {
            g.DrawString("الزبون:", _fontBold, Brushes.Black,
                new RectangleF(x, y, width, 20), sfRight);
            y += _fontBold.GetHeight(g) + 1;
            foreach (var line in _receipt.CustomerInfo.Split('\n', StringSplitOptions.RemoveEmptyEntries))
            {
                g.DrawString(line.Trim(), _fontNormal, Brushes.Black,
                    new RectangleF(x, y, width, 20), sfRight);
                y += _fontNormal.GetHeight(g) + 1;
            }
            y += 2;
        }

        if (!string.IsNullOrWhiteSpace(_receipt.EmployeeInfo))
        {
            g.DrawString("الموظف:", _fontBold, Brushes.Black,
                new RectangleF(x, y, width, 20), sfRight);
            y += _fontBold.GetHeight(g) + 1;
            foreach (var line in _receipt.EmployeeInfo.Split('\n', StringSplitOptions.RemoveEmptyEntries))
            {
                g.DrawString(line.Trim(), _fontNormal, Brushes.Black,
                    new RectangleF(x, y, width, 20), sfRight);
                y += _fontNormal.GetHeight(g) + 1;
            }
            y += 2;
        }

        y += 4;

        // === Separator ===
        y = DrawSeparator(g, x, y, width, isThermal);

        // === Table Header ===
        y = DrawTableHeader(g, x, y, width, isThermal);

        // === Separator ===
        y = DrawSeparator(g, x, y, width, isThermal);

        // === Items ===
        foreach (var item in _receipt.Items)
        {
            y = DrawItemRow(g, x, y, width, item, isThermal);
        }

        // === Separator ===
        y = DrawSeparator(g, x, y, width, isThermal);

        // === Total (label on RIGHT, value on LEFT) ===
        string totalLabel = "المجموع الكلي:";
        string totalValue = FormatCurrency(_receipt.Total);

        // Right half: label (right-aligned)
        g.DrawString(totalLabel, _fontBold, Brushes.Black,
            new RectangleF(x + width * 0.5f, y, width * 0.5f, 25), sfRight);
        // Left half: value (left-aligned, but near the center)
        g.DrawString(totalValue, _fontBold, Brushes.Black,
            new RectangleF(x, y, width * 0.5f, 25), sfRight);
        y += _fontBold.GetHeight(g) + (isThermal ? 8 : 18);

        // === Separator ===
        y = DrawSeparator(g, x, y, width, isThermal);

        // === Footer (centered) ===
        g.DrawString(_settings.OfficeAddress, _fontSmall, Brushes.Black,
            new RectangleF(x, y, width, 20), sfCenter);
        y += _fontSmall.GetHeight(g) + 2;

        g.DrawString(_settings.PhoneNumber, _fontSmall, Brushes.Black,
            new RectangleF(x, y, width, 20), sfCenter);
        y += _fontSmall.GetHeight(g) + 6;

        g.DrawString("شكراً لكم", _fontBold, Brushes.Black,
            new RectangleF(x, y, width, 25), sfCenter);

        e.HasMorePages = false;

        DisposeFonts();
    }

    private float DrawTableHeader(Graphics g, float x, float y, float width, bool isThermal)
    {
        var sfCenter = new StringFormat(StringFormatFlags.DirectionRightToLeft)
        { Alignment = StringAlignment.Center };

        // RTL column order (right → left): المادة | الكمية | السعر | المجموع
        // Drawing positions (left → right): المجموع | السعر | الكمية | المادة
        float col4 = width * 0.20f; // المجموع (Subtotal) — leftmost
        float col3 = width * 0.20f; // السعر (Price)
        float col2 = width * 0.15f; // الكمية (Qty)
        float col1 = width * 0.45f; // المادة (Product) — rightmost

        float cx = x;
        g.DrawString("المجموع", _fontBold, Brushes.Black, new RectangleF(cx, y, col4, 22), sfCenter);
        cx += col4;
        g.DrawString("السعر", _fontBold, Brushes.Black, new RectangleF(cx, y, col3, 22), sfCenter);
        cx += col3;
        g.DrawString("الكمية", _fontBold, Brushes.Black, new RectangleF(cx, y, col2, 22), sfCenter);
        cx += col2;
        g.DrawString("المادة", _fontBold, Brushes.Black, new RectangleF(cx, y, col1, 22), sfCenter);

        return y + _fontBold.GetHeight(g) + 2;
    }

    private float DrawItemRow(Graphics g, float x, float y, float width, ReceiptItem item, bool isThermal)
    {
        var sfCenter = new StringFormat(StringFormatFlags.DirectionRightToLeft)
        { Alignment = StringAlignment.Center };

        float col4 = width * 0.20f;
        float col3 = width * 0.20f;
        float col2 = width * 0.15f;
        float col1 = width * 0.45f;

        float cx = x;
        g.DrawString(FormatCurrency(item.Quantity * item.UnitPrice), _fontNormal, Brushes.Black,
            new RectangleF(cx, y, col4, 22), sfCenter);
        cx += col4;
        g.DrawString(FormatCurrency(item.UnitPrice), _fontNormal, Brushes.Black,
            new RectangleF(cx, y, col3, 22), sfCenter);
        cx += col3;
        g.DrawString(item.Quantity.ToString(), _fontNormal, Brushes.Black,
            new RectangleF(cx, y, col2, 22), sfCenter);
        cx += col2;
        g.DrawString(item.ProductName, _fontNormal, Brushes.Black,
            new RectangleF(cx, y, col1, 22), sfCenter);

        return y + _fontNormal.GetHeight(g) + (isThermal ? 3 : 5);
    }

    private float DrawSeparator(Graphics g, float x, float y, float width, bool isThermal)
    {
        if (isThermal)
        {
            string dashes = new string('-', (int)(width / 4));
            g.DrawString(dashes, _fontSmall, Brushes.Black, x, y);
        }
        else
        {
            using var pen = new Pen(Color.FromArgb(180, 180, 180), 0.5f);
            g.DrawLine(pen, x, y + 2, x + width, y + 2);
        }
        return y + (isThermal ? 8 : 10);
    }

    private string FormatCurrency(decimal amount)
    {
        return $"{amount:N0} د.ع";
    }

    private void InitFonts()
    {
        float scale = _paperType switch
        {
            PaperType.Thermal58mm => 0.7f,
            PaperType.Thermal80mm => 0.85f,
            _ => 1.0f
        };

        _fontTitle = new Font("Segoe UI", 16 * scale, FontStyle.Bold);
        _fontBold = new Font("Segoe UI", 11 * scale, FontStyle.Bold);
        _fontNormal = new Font("Segoe UI", 10 * scale, FontStyle.Regular);
        _fontSmall = new Font("Segoe UI", 8.5f * scale, FontStyle.Regular);
    }

    private void DisposeFonts()
    {
        _fontTitle?.Dispose();
        _fontBold?.Dispose();
        _fontNormal?.Dispose();
        _fontSmall?.Dispose();
    }
}
