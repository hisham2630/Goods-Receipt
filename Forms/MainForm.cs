using System.Drawing.Printing;
using GoodsReceipt.Models;
using GoodsReceipt.Services;

namespace GoodsReceipt.Forms;

public partial class MainForm : Form
{
    private readonly SettingsService _settingsService = new();
    private readonly ProductService _productService = new();
    private readonly ReceiptService _receiptService = new();
    private readonly PrintEngine _printEngine = new();
    private AppSettings _appSettings = null!;
    private List<ReceiptItem> _currentItems = new();
    // Border color used by Paint handlers (matches Designer palette)
    private static readonly Color _clrCardBorder = Color.FromArgb(220, 224, 232);

    public MainForm()
    {
        InitializeComponent();
        LoadSettings();
        LoadPrinters();
        LoadProducts();
        WirePaintHandlers();
    }

    private void WirePaintHandlers()
    {
        // Card borders
        cardInfo.Paint += (s, e) =>
        {
            using var pen = new Pen(_clrCardBorder, 1);
            e.Graphics.DrawRectangle(pen, 0, 0, cardInfo.Width - 1, cardInfo.Height - 1);
        };
        cardAddItem.Paint += (s, e) =>
        {
            using var pen = new Pen(_clrCardBorder, 1);
            e.Graphics.DrawRectangle(pen, 0, 0, cardAddItem.Width - 1, cardAddItem.Height - 1);
        };
        cardGrid.Paint += (s, e) =>
        {
            using var pen = new Pen(_clrCardBorder, 1);
            e.Graphics.DrawRectangle(pen, 0, 0, cardGrid.Width - 1, cardGrid.Height - 1);
        };

        // Bottom bar top border line
        bottomBar.Paint += (s, e) =>
        {
            using var pen = new Pen(_clrCardBorder, 2);
            e.Graphics.DrawLine(pen, 0, 0, bottomBar.Width, 0);
        };
    }


    private void LoadSettings()
    {
        _appSettings = _settingsService.Load();
        nudCopies.Value = Math.Clamp(_appSettings.DefaultCopies, 1, 5);
    }

    private void LoadPrinters()
    {
        cmbPrinters.Items.Clear();
        foreach (string printer in PrinterSettings.InstalledPrinters)
        {
            cmbPrinters.Items.Add(printer);
        }

        if (!string.IsNullOrEmpty(_appSettings.LastPrinterName) &&
            cmbPrinters.Items.Contains(_appSettings.LastPrinterName))
        {
            cmbPrinters.SelectedItem = _appSettings.LastPrinterName;
        }
        else if (cmbPrinters.Items.Count > 0)
        {
            cmbPrinters.SelectedIndex = 0;
        }
    }

    private void LoadProducts()
    {
        var products = _productService.GetAll();
        cmbProducts.Items.Clear();
        cmbProducts.Items.Add("-- اختر من القائمة --");
        foreach (var p in products)
        {
            cmbProducts.Items.Add(p);
        }
        cmbProducts.SelectedIndex = 0;
        cmbProducts.DisplayMember = "Name";
    }

    private void cmbProducts_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (cmbProducts.SelectedItem is Product product)
        {
            txtItemName.Text = product.Name;
            txtUnitPrice.Text = product.DefaultPrice.ToString("0");
        }
    }

    private void btnAddItem_Click(object? sender, EventArgs e)
    {
        var name = txtItemName.Text.Trim();
        if (string.IsNullOrEmpty(name))
        {
            MessageBox.Show("الرجاء إدخال اسم المادة", "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price <= 0)
        {
            MessageBox.Show("الرجاء إدخال سعر صحيح", "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var item = new ReceiptItem
        {
            ProductName = name,
            Quantity = (int)nudQuantity.Value,
            UnitPrice = price
        };

        _currentItems.Add(item);
        RefreshGrid();
        ClearItemInputs();
    }

    private void dgvItems_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var colName = dgvItems.Columns[e.ColumnIndex]?.Name;

        if (colName == "colDelete")
        {
            var result = MessageBox.Show("هل تريد حذف هذا العنصر؟", "تأكيد الحذف",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _currentItems.RemoveAt(e.RowIndex);
                RefreshGrid();
            }
        }
        else if (colName == "colQtyPlus")
        {
            _currentItems[e.RowIndex].Quantity++;
            RefreshGrid();
        }
        else if (colName == "colQtyMinus")
        {
            if (_currentItems[e.RowIndex].Quantity > 1)
            {
                _currentItems[e.RowIndex].Quantity--;
                RefreshGrid();
            }
        }
    }

    private void RefreshGrid()
    {
        dgvItems.Rows.Clear();
        decimal total = 0;

        foreach (var item in _currentItems)
        {
            decimal subtotal = item.Quantity * item.UnitPrice;
            total += subtotal;
            dgvItems.Rows.Add(
                item.ProductName,
                "+",
                item.Quantity.ToString(),
                "-",
                $"{item.UnitPrice:N0} د.ع",
                $"{subtotal:N0} د.ع"
            );
        }

        lblTotalAmount.Text = $"{total:N0} د.ع";

        // Auto-scroll to last row
        if (dgvItems.Rows.Count > 0)
        {
            dgvItems.FirstDisplayedScrollingRowIndex = dgvItems.Rows.Count - 1;
        }
    }

    private void ClearItemInputs()
    {
        txtItemName.Clear();
        txtUnitPrice.Clear();
        nudQuantity.Value = 1;
        cmbProducts.SelectedIndex = 0;
        txtItemName.Focus();
    }

    private void btnPreview_Click(object? sender, EventArgs e)
    {
        if (_currentItems.Count == 0)
        {
            MessageBox.Show("الرجاء إضافة عنصر واحد على الأقل", "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (cmbPrinters.SelectedItem == null)
        {
            MessageBox.Show("الرجاء اختيار طابعة", "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var receipt = BuildReceipt("PREVIEW");

        try
        {
            _printEngine.Preview(receipt, _appSettings, cmbPrinters.SelectedItem.ToString()!);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطأ في المعاينة: {ex.Message}", "خطأ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnPrint_Click(object? sender, EventArgs e)
    {
        if (_currentItems.Count == 0)
        {
            MessageBox.Show("الرجاء إضافة عنصر واحد على الأقل", "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (cmbPrinters.SelectedItem == null)
        {
            MessageBox.Show("الرجاء اختيار طابعة", "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        bool alreadySaved = lblReceiptNumber.Text.StartsWith("REC-");
        string receiptNumber;

        if (alreadySaved)
        {
            // Already saved — just reprint
            receiptNumber = lblReceiptNumber.Text;
        }
        else
        {
            // New receipt — generate number and save
            receiptNumber = _settingsService.GenerateNextReceiptNumber();
            // Reload settings so in-memory LastReceiptNumber is in sync
            _appSettings = _settingsService.Load();
        }

        var receipt = BuildReceipt(receiptNumber);

        if (!alreadySaved)
        {
            try
            {
                _receiptService.Save(receipt);
            }
            catch (Exception ex)
            {
                var innerMsg = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show($"خطأ في حفظ الوصل:\n{innerMsg}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        try
        {
            int copies = (int)nudCopies.Value;
            _printEngine.Print(receipt, _appSettings, cmbPrinters.SelectedItem.ToString()!, copies);

            _appSettings.LastPrinterName = cmbPrinters.SelectedItem.ToString()!;
            _appSettings.DefaultCopies = copies;
            _settingsService.Save(_appSettings);

            lblReceiptNumber.Text = receiptNumber;

            var msg = alreadySaved
                ? $"تمت إعادة طباعة الوصل رقم {receiptNumber}"
                : $"تم حفظ وطباعة الوصل رقم {receiptNumber} بنجاح";
            MessageBox.Show(msg, "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            lblReceiptNumber.Text = receiptNumber;
            MessageBox.Show($"تم الحفظ لكن حدث خطأ في الطباعة:\n{ex.Message}", "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnNewReceipt_Click(object? sender, EventArgs e)
    {
        if (_currentItems.Count > 0)
        {
            var result = MessageBox.Show("هل تريد مسح الوصل الحالي والبدء بوصل جديد؟",
                "وصل جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;
        }

        _currentItems.Clear();
        dgvItems.Rows.Clear();
        txtCustomerName.Clear();
        txtEmployeeInfo.Clear();
        lblTotalAmount.Text = "0 د.ع";
        lblReceiptNumber.Text = "سيتم التعيين تلقائياً";
        ClearItemInputs();
    }

    private Receipt BuildReceipt(string receiptNumber)
    {
        decimal total = _currentItems.Sum(i => i.Quantity * i.UnitPrice);

        return new Receipt
        {
            ReceiptNumber = receiptNumber,
            CustomerInfo = string.IsNullOrWhiteSpace(txtCustomerName.Text) ? null : txtCustomerName.Text.Trim(),
            EmployeeInfo = string.IsNullOrWhiteSpace(txtEmployeeInfo.Text) ? null : txtEmployeeInfo.Text.Trim(),
            CreatedAt = DateTime.Now,
            Total = total,
            Items = _currentItems.Select(i => new ReceiptItem
            {
                ProductName = i.ProductName,
                Quantity = i.Quantity,
                UnitPrice = i.UnitPrice
            }).ToList()
        };
    }

    private void btnSettings_Click(object? sender, EventArgs e)
    {
        using var form = new SettingsForm();
        if (form.ShowDialog() == DialogResult.OK)
        {
            LoadSettings();
        }
    }

    private void btnProducts_Click(object? sender, EventArgs e)
    {
        using var form = new ProductCatalogForm();
        form.ShowDialog();
        LoadProducts();
    }

    private void btnHistory_Click(object? sender, EventArgs e)
    {
        using var form = new ReceiptHistoryForm();
        form.ShowDialog();
    }

    private void cmbPrinters_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
