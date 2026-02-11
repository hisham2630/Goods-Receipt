using GoodsReceipt.Models;
using GoodsReceipt.Services;

namespace GoodsReceipt.Forms;

public partial class ProductCatalogForm : Form
{
    private readonly ProductService _productService = new();
    private int? _editingProductId = null;
    private static readonly Color _clrCardBorder = Color.FromArgb(220, 224, 232);

    public ProductCatalogForm()
    {
        InitializeComponent();
        WireLayoutHandlers();
        LoadProducts();
    }

    private void WireLayoutHandlers()
    {
        // Header – keep title right-aligned
        headerBar.Resize += (s, e) =>
        {
            lblTitle.Location = new Point(headerBar.Width - lblTitle.Width - 20, 10);
        };

        // Card borders
        cardAdd.Paint += (s, e) =>
        {
            using var pen = new Pen(_clrCardBorder, 1);
            e.Graphics.DrawRectangle(pen, 0, 0, cardAdd.Width - 1, cardAdd.Height - 1);
        };
        cardGrid.Paint += (s, e) =>
        {
            using var pen = new Pen(_clrCardBorder, 1);
            e.Graphics.DrawRectangle(pen, 0, 0, cardGrid.Width - 1, cardGrid.Height - 1);
        };

        // Add card – reposition elements on resize
        cardAdd.Resize += (s, e) =>
        {
            int rX = cardAdd.Width;
            lblName.Location = new Point(rX - 100, 18);
            txtProductName.Location = new Point(rX - 290, 14);
            lblPrice.Location = new Point(rX - 340, 18);
            txtProductPrice.Location = new Point(rX - 446, 14);
        };
    }

    private void LoadProducts()
    {
        dgvProducts.Rows.Clear();
        var products = _productService.GetAll();
        foreach (var p in products)
        {
            dgvProducts.Rows.Add(p.Id, p.Name, $"{p.DefaultPrice:N0} د.ع");
        }
    }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        var name = txtProductName.Text.Trim();
        if (string.IsNullOrEmpty(name))
        {
            MessageBox.Show("الرجاء إدخال اسم المنتج", "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!decimal.TryParse(txtProductPrice.Text, out decimal price) || price <= 0)
        {
            MessageBox.Show("الرجاء إدخال سعر صحيح", "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (_editingProductId.HasValue)
        {
            // Update existing product
            _productService.Update(new Product
            {
                Id = _editingProductId.Value,
                Name = name,
                DefaultPrice = price
            });
            CancelEdit();
        }
        else
        {
            // Add new product
            _productService.Add(new Product
            {
                Name = name,
                DefaultPrice = price
            });
        }

        txtProductName.Clear();
        txtProductPrice.Clear();
        txtProductName.Focus();
        LoadProducts();
    }

    private void dgvProducts_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var clickedCol = dgvProducts.Columns[e.ColumnIndex]?.Name;

        if (clickedCol == "colDelete")
        {
            var productId = (int)dgvProducts.Rows[e.RowIndex].Cells["colId"].Value;
            var productName = dgvProducts.Rows[e.RowIndex].Cells["colName"].Value?.ToString();

            var result = MessageBox.Show($"هل تريد حذف المنتج '{productName}'؟", "تأكيد الحذف",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _productService.Delete(productId);
                if (_editingProductId == productId) CancelEdit();
                LoadProducts();
            }
        }
        else if (clickedCol == "colEdit")
        {
            var productId = (int)dgvProducts.Rows[e.RowIndex].Cells["colId"].Value;
            var productName = dgvProducts.Rows[e.RowIndex].Cells["colName"].Value?.ToString() ?? "";
            var priceText = dgvProducts.Rows[e.RowIndex].Cells["colPrice"].Value?.ToString() ?? "0";

            // Extract numeric price (remove "د.ع" and formatting)
            var priceClean = priceText.Replace("د.ع", "").Replace(",", "").Trim();

            _editingProductId = productId;
            txtProductName.Text = productName;
            txtProductPrice.Text = priceClean;
            btnAdd.Text = "💾 حفظ التعديل";
            btnAdd.BackColor = Color.FromArgb(39, 174, 96); // Green for save
            txtProductName.Focus();
        }
    }

    private void CancelEdit()
    {
        _editingProductId = null;
        btnAdd.Text = "➕ إضافة";
        btnAdd.BackColor = Color.FromArgb(0, 95, 115); // Back to primary
        txtProductName.Clear();
        txtProductPrice.Clear();
    }

    private void btnClose_Click(object? sender, EventArgs e)
    {
        this.Close();
    }
}
