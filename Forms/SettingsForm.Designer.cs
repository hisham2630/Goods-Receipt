namespace GoodsReceipt.Forms;

partial class SettingsForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        headerBar = new Panel();
        lblTitle = new Label();
        contentPanel = new Panel();
        card = new Panel();
        lblCompany = new Label();
        txtCompanyName = new TextBox();
        lblAddress = new Label();
        txtAddress = new TextBox();
        lblPhone = new Label();
        txtPhone = new TextBox();
        btnSave = new Button();
        btnCancel = new Button();
        headerBar.SuspendLayout();
        contentPanel.SuspendLayout();
        card.SuspendLayout();
        SuspendLayout();
        // 
        // headerBar
        // 
        headerBar.BackColor = Color.FromArgb(0, 95, 115);
        headerBar.Controls.Add(lblTitle);
        headerBar.Dock = DockStyle.Top;
        headerBar.Location = new Point(0, 0);
        headerBar.Name = "headerBar";
        headerBar.Size = new Size(520, 50);
        headerBar.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(320, 10);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(180, 28);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "⚙ إعدادات الشركة";
        // 
        // contentPanel
        // 
        contentPanel.BackColor = Color.FromArgb(245, 246, 250);
        contentPanel.Controls.Add(card);
        contentPanel.Dock = DockStyle.Fill;
        contentPanel.Location = new Point(0, 50);
        contentPanel.Name = "contentPanel";
        contentPanel.Padding = new Padding(30, 20, 30, 20);
        contentPanel.Size = new Size(520, 350);
        contentPanel.TabIndex = 1;
        // 
        // card
        // 
        card.BackColor = Color.White;
        card.Controls.Add(lblCompany);
        card.Controls.Add(txtCompanyName);
        card.Controls.Add(lblAddress);
        card.Controls.Add(txtAddress);
        card.Controls.Add(lblPhone);
        card.Controls.Add(txtPhone);
        card.Controls.Add(btnSave);
        card.Controls.Add(btnCancel);
        card.Dock = DockStyle.Fill;
        card.Location = new Point(30, 20);
        card.Name = "card";
        card.Padding = new Padding(30, 24, 30, 24);
        card.Size = new Size(460, 310);
        card.TabIndex = 0;
        // 
        // lblCompany
        // 
        lblCompany.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblCompany.AutoSize = true;
        lblCompany.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblCompany.ForeColor = Color.FromArgb(44, 62, 80);
        lblCompany.Location = new Point(350, 10);
        lblCompany.Name = "lblCompany";
        lblCompany.Size = new Size(80, 19);
        lblCompany.TabIndex = 0;
        lblCompany.Text = "اسم الشركة";
        // 
        // txtCompanyName
        // 
        txtCompanyName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtCompanyName.BorderStyle = BorderStyle.FixedSingle;
        txtCompanyName.Font = new Font("Segoe UI", 12F);
        txtCompanyName.Location = new Point(30, 34);
        txtCompanyName.Name = "txtCompanyName";
        txtCompanyName.RightToLeft = RightToLeft.Yes;
        txtCompanyName.Size = new Size(400, 29);
        txtCompanyName.TabIndex = 1;
        // 
        // lblAddress
        // 
        lblAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblAddress.AutoSize = true;
        lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblAddress.ForeColor = Color.FromArgb(44, 62, 80);
        lblAddress.Location = new Point(340, 80);
        lblAddress.Name = "lblAddress";
        lblAddress.Size = new Size(90, 19);
        lblAddress.TabIndex = 2;
        lblAddress.Text = "عنوان المكتب";
        // 
        // txtAddress
        // 
        txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtAddress.BorderStyle = BorderStyle.FixedSingle;
        txtAddress.Font = new Font("Segoe UI", 12F);
        txtAddress.Location = new Point(30, 104);
        txtAddress.Name = "txtAddress";
        txtAddress.RightToLeft = RightToLeft.Yes;
        txtAddress.Size = new Size(400, 29);
        txtAddress.TabIndex = 3;
        // 
        // lblPhone
        // 
        lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblPhone.AutoSize = true;
        lblPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblPhone.ForeColor = Color.FromArgb(44, 62, 80);
        lblPhone.Location = new Point(350, 150);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new Size(80, 19);
        lblPhone.TabIndex = 4;
        lblPhone.Text = "رقم الهاتف";
        // 
        // txtPhone
        // 
        txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtPhone.BorderStyle = BorderStyle.FixedSingle;
        txtPhone.Font = new Font("Segoe UI", 12F);
        txtPhone.Location = new Point(30, 174);
        txtPhone.Name = "txtPhone";
        txtPhone.RightToLeft = RightToLeft.Yes;
        txtPhone.Size = new Size(400, 29);
        txtPhone.TabIndex = 5;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.FromArgb(39, 174, 96);
        btnSave.Cursor = Cursors.Hand;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(30, 230);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(160, 42);
        btnSave.TabIndex = 6;
        btnSave.Text = "💾 حفظ الإعدادات";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // btnCancel
        // 
        btnCancel.BackColor = Color.White;
        btnCancel.Cursor = Cursors.Hand;
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(127, 140, 141);
        btnCancel.FlatAppearance.BorderSize = 1;
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Font = new Font("Segoe UI", 11F);
        btnCancel.ForeColor = Color.FromArgb(44, 62, 80);
        btnCancel.Location = new Point(200, 230);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(100, 42);
        btnCancel.TabIndex = 7;
        btnCancel.Text = "إلغاء";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Click += btnCancel_Click;
        // 
        // SettingsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 246, 250);
        ClientSize = new Size(520, 400);
        Controls.Add(contentPanel);
        Controls.Add(headerBar);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "SettingsForm";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        StartPosition = FormStartPosition.CenterParent;
        Text = "الإعدادات";
        headerBar.ResumeLayout(false);
        headerBar.PerformLayout();
        contentPanel.ResumeLayout(false);
        card.ResumeLayout(false);
        card.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    // Panels
    private Panel headerBar;
    private Panel contentPanel;
    private Panel card;

    // Labels
    private Label lblTitle;
    private Label lblCompany;
    private Label lblAddress;
    private Label lblPhone;

    // Inputs
    private TextBox txtCompanyName;
    private TextBox txtAddress;
    private TextBox txtPhone;
    private Button btnSave;
    private Button btnCancel;
}
