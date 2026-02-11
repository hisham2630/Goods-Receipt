using GoodsReceipt.Services;

namespace GoodsReceipt.Forms;

public partial class SettingsForm : Form
{
    private readonly SettingsService _settingsService = new();
    private static readonly Color _clrCardBorder = Color.FromArgb(220, 224, 232);

    public SettingsForm()
    {
        InitializeComponent();
        WireLayoutHandlers();
        LoadCurrentSettings();
    }

    private void WireLayoutHandlers()
    {
        // Header – keep title right-aligned
        headerBar.Resize += (s, e) =>
        {
            lblTitle.Location = new Point(headerBar.Width - lblTitle.Width - 20, 10);
        };

        // Card border
        card.Paint += (s, e) =>
        {
            using var pen = new Pen(_clrCardBorder, 1);
            e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
        };

        // Card – reposition labels and resize textboxes on resize
        card.Resize += (s, e) =>
        {
            int rX = card.Width;
            lblCompany.Location = new Point(rX - lblCompany.Width - 30, 10);
            txtCompanyName.Size = new Size(rX - 60, 30);
            lblAddress.Location = new Point(rX - lblAddress.Width - 30, 80);
            txtAddress.Size = new Size(rX - 60, 30);
            lblPhone.Location = new Point(rX - lblPhone.Width - 30, 150);
            txtPhone.Size = new Size(rX - 60, 30);
        };
    }

    private void LoadCurrentSettings()
    {
        var settings = _settingsService.Load();
        txtCompanyName.Text = settings.CompanyName;
        txtAddress.Text = settings.OfficeAddress;
        txtPhone.Text = settings.PhoneNumber;
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
        {
            MessageBox.Show("الرجاء إدخال اسم الشركة", "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var settings = _settingsService.Load();
        settings.CompanyName = txtCompanyName.Text.Trim();
        settings.OfficeAddress = txtAddress.Text.Trim();
        settings.PhoneNumber = txtPhone.Text.Trim();
        _settingsService.Save(settings);

        MessageBox.Show("تم حفظ الإعدادات بنجاح", "تم",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void btnCancel_Click(object? sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
