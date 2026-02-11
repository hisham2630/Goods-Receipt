using System.Drawing.Printing;
using GoodsReceipt.Models;
using GoodsReceipt.Services;

namespace GoodsReceipt.Forms;

public partial class ReceiptHistoryForm : Form
{
    private readonly ReceiptService _receiptService = new();
    private readonly SettingsService _settingsService = new();
    private readonly PrintEngine _printEngine = new();
    private static readonly Color _clrCardBorder = Color.FromArgb(220, 224, 232);

    public ReceiptHistoryForm()
    {
        InitializeComponent();
        WireLayoutHandlers();
        LoadReceipts();
    }

    private void WireLayoutHandlers()
    {
        // Header – keep title right-aligned
        headerBar.Resize += (s, e) =>
        {
            lblTitle.Location = new Point(headerBar.Width - lblTitle.Width - 20, 10);
        };

        // Card borders
        cardSearch.Paint += (s, e) =>
        {
            using var pen = new Pen(_clrCardBorder, 1);
            e.Graphics.DrawRectangle(pen, 0, 0, cardSearch.Width - 1, cardSearch.Height - 1);
        };
        cardGrid.Paint += (s, e) =>
        {
            using var pen = new Pen(_clrCardBorder, 1);
            e.Graphics.DrawRectangle(pen, 0, 0, cardGrid.Width - 1, cardGrid.Height - 1);
        };

        // Search card – reposition elements on resize
        cardSearch.Resize += (s, e) =>
        {
            lblSearch.Location = new Point(cardSearch.Width - 80, 16);
            txtSearch.Size = new Size(cardSearch.Width - 120, 28);
        };
    }

    private void LoadReceipts()
    {
        dgvReceipts.Rows.Clear();
        var receipts = _receiptService.GetAll();
        foreach (var r in receipts)
        {
            dgvReceipts.Rows.Add(
                r.Id,
                r.ReceiptNumber,
                r.CustomerInfo ?? "---",
                r.EmployeeInfo ?? "---",
                $"\u202A{r.CreatedAt:yyyy-MM-dd  h:mm:ss tt}\u202C",
                $"{r.Total:N0} د.ع"
            );
        }
    }

    private void txtSearch_TextChanged(object? sender, EventArgs e)
    {
        var query = txtSearch.Text.Trim();
        dgvReceipts.Rows.Clear();

        var receipts = string.IsNullOrEmpty(query)
            ? _receiptService.GetAll()
            : _receiptService.Search(query);

        foreach (var r in receipts)
        {
            dgvReceipts.Rows.Add(
                r.Id,
                r.ReceiptNumber,
                r.CustomerInfo ?? "---",
                r.EmployeeInfo ?? "---",
                $"\u202A{r.CreatedAt:yyyy-MM-dd  h:mm:ss tt}\u202C",
                $"{r.Total:N0} د.ع"
            );
        }
    }

    private void dgvReceipts_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var receiptId = (int)dgvReceipts.Rows[e.RowIndex].Cells["colId"].Value;

        // Receipt number clicked → open preview
        if (e.ColumnIndex == dgvReceipts.Columns["colReceiptNum"]!.Index)
        {
            var receipt = _receiptService.GetById(receiptId);
            if (receipt == null)
            {
                MessageBox.Show("لم يتم العثور على الوصل", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var settings = _settingsService.Load();
            var printerName = settings.LastPrinterName;
            if (string.IsNullOrEmpty(printerName))
            {
                var ps = new PrinterSettings();
                printerName = ps.PrinterName;
            }

            try
            {
                _printEngine.Preview(receipt, settings, printerName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في المعاينة: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        // Reprint button clicked
        if (e.ColumnIndex != dgvReceipts.Columns["colReprint"]!.Index)
            return;

        var reprintReceipt = _receiptService.GetById(receiptId);
        if (reprintReceipt == null)
        {
            MessageBox.Show("لم يتم العثور على الوصل", "خطأ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var reprintSettings = _settingsService.Load();

        // Ask for printer
        var reprintPrinter = reprintSettings.LastPrinterName;
        if (string.IsNullOrEmpty(reprintPrinter))
        {
            var ps = new PrinterSettings();
            reprintPrinter = ps.PrinterName;
        }

        var result = MessageBox.Show(
            $"سيتم طباعة الوصل رقم {reprintReceipt.ReceiptNumber} على الطابعة:\n{reprintPrinter}\n\nمتابعة؟",
            "إعادة طباعة",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            try
            {
                _printEngine.Print(reprintReceipt, reprintSettings, reprintPrinter, reprintSettings.DefaultCopies);
                MessageBox.Show("تمت إعادة الطباعة بنجاح", "تم",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في الطباعة: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void btnClose_Click(object? sender, EventArgs e)
    {
        this.Close();
    }
}
