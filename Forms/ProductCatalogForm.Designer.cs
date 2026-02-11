namespace GoodsReceipt.Forms;

partial class ProductCatalogForm
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        headerBar = new Panel();
        lblTitle = new Label();
        contentPanel = new Panel();
        bottomPanel = new Panel();
        btnClose = new Button();
        cardGrid = new Panel();
        dgvProducts = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colName = new DataGridViewTextBoxColumn();
        colProdPrice = new DataGridViewTextBoxColumn();
        colEditProd = new DataGridViewButtonColumn();
        colDeleteProd = new DataGridViewButtonColumn();
        spacer = new Panel();
        cardAdd = new Panel();
        lblName = new Label();
        txtProductName = new TextBox();
        lblPrice = new Label();
        txtProductPrice = new TextBox();
        btnAdd = new Button();
        headerBar.SuspendLayout();
        contentPanel.SuspendLayout();
        bottomPanel.SuspendLayout();
        cardGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
        cardAdd.SuspendLayout();
        SuspendLayout();
        // 
        // headerBar
        // 
        headerBar.BackColor = Color.FromArgb(0, 95, 115);
        headerBar.Controls.Add(lblTitle);
        headerBar.Dock = DockStyle.Top;
        headerBar.Location = new Point(0, 0);
        headerBar.Name = "headerBar";
        headerBar.Size = new Size(640, 50);
        headerBar.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(440, 10);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(180, 28);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "📦 إدارة المنتجات";
        // 
        // contentPanel
        // 
        contentPanel.BackColor = Color.FromArgb(245, 246, 250);
        contentPanel.Controls.Add(bottomPanel);
        contentPanel.Controls.Add(cardGrid);
        contentPanel.Controls.Add(spacer);
        contentPanel.Controls.Add(cardAdd);
        contentPanel.Dock = DockStyle.Fill;
        contentPanel.Location = new Point(0, 50);
        contentPanel.Name = "contentPanel";
        contentPanel.Padding = new Padding(20, 16, 20, 20);
        contentPanel.Size = new Size(640, 450);
        contentPanel.TabIndex = 1;
        // 
        // bottomPanel
        // 
        bottomPanel.BackColor = Color.FromArgb(245, 246, 250);
        bottomPanel.Controls.Add(btnClose);
        bottomPanel.Dock = DockStyle.Bottom;
        bottomPanel.Location = new Point(20, 395);
        bottomPanel.Name = "bottomPanel";
        bottomPanel.Size = new Size(600, 55);
        bottomPanel.TabIndex = 3;
        // 
        // btnClose
        // 
        btnClose.BackColor = Color.White;
        btnClose.Cursor = Cursors.Hand;
        btnClose.FlatAppearance.BorderColor = Color.FromArgb(127, 140, 141);
        btnClose.FlatAppearance.BorderSize = 1;
        btnClose.FlatStyle = FlatStyle.Flat;
        btnClose.Font = new Font("Segoe UI", 10F);
        btnClose.ForeColor = Color.FromArgb(44, 62, 80);
        btnClose.Location = new Point(0, 8);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(100, 38);
        btnClose.TabIndex = 0;
        btnClose.Text = "إغلاق";
        btnClose.UseVisualStyleBackColor = false;
        btnClose.Click += btnClose_Click;
        // 
        // cardGrid
        // 
        cardGrid.BackColor = Color.White;
        cardGrid.Controls.Add(dgvProducts);
        cardGrid.Dock = DockStyle.Fill;
        cardGrid.Location = new Point(20, 84);
        cardGrid.Name = "cardGrid";
        cardGrid.Padding = new Padding(1);
        cardGrid.Size = new Size(600, 311);
        cardGrid.TabIndex = 2;
        // 
        // dgvProducts
        // 
        dgvProducts.AllowUserToAddRows = false;
        dgvProducts.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 248, 250);
        dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProducts.BackgroundColor = Color.White;
        dgvProducts.BorderStyle = BorderStyle.None;
        dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 95, 115);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvProducts.ColumnHeadersHeight = 42;
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colProdPrice, colEditProd, colDeleteProd });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle3.BackColor = SystemColors.Window;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(44, 62, 80);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 230, 240);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(44, 62, 80);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
        dgvProducts.Dock = DockStyle.Fill;
        dgvProducts.EnableHeadersVisualStyles = false;
        dgvProducts.Font = new Font("Segoe UI", 11F);
        dgvProducts.GridColor = Color.FromArgb(220, 224, 232);
        dgvProducts.Location = new Point(1, 1);
        dgvProducts.MultiSelect = false;
        dgvProducts.Name = "dgvProducts";
        dgvProducts.ReadOnly = true;
        dgvProducts.RightToLeft = RightToLeft.Yes;
        dgvProducts.RowHeadersVisible = false;
        dgvProducts.RowTemplate.Height = 38;
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvProducts.Size = new Size(598, 309);
        dgvProducts.TabIndex = 0;
        dgvProducts.CellClick += dgvProducts_CellClick;
        // 
        // colId
        // 
        colId.HeaderText = "#";
        colId.Name = "colId";
        colId.ReadOnly = true;
        colId.Visible = false;
        // 
        // colName
        // 
        colName.FillWeight = 50F;
        colName.HeaderText = "اسم المنتج";
        colName.Name = "colName";
        colName.ReadOnly = true;
        // 
        // colProdPrice
        // 
        colProdPrice.FillWeight = 25F;
        colProdPrice.HeaderText = "السعر الافتراضي (د.ع)";
        colProdPrice.Name = "colPrice";
        colProdPrice.ReadOnly = true;
        // 
        // colEditProd
        // 
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
        colEditProd.DefaultCellStyle = dataGridViewCellStyle4;
        colEditProd.FillWeight = 12F;
        colEditProd.HeaderText = "";
        colEditProd.Name = "colEdit";
        colEditProd.ReadOnly = true;
        colEditProd.Text = "✏ تعديل";
        colEditProd.UseColumnTextForButtonValue = true;
        // 
        // colDeleteProd
        // 
        colDeleteProd.DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.FromArgb(192, 57, 43) };
        colDeleteProd.FillWeight = 12F;
        colDeleteProd.HeaderText = "";
        colDeleteProd.Name = "colDelete";
        colDeleteProd.ReadOnly = true;
        colDeleteProd.Text = "❌ حذف";
        colDeleteProd.UseColumnTextForButtonValue = true;
        // 
        // spacer
        // 
        spacer.BackColor = Color.FromArgb(245, 246, 250);
        spacer.Dock = DockStyle.Top;
        spacer.Location = new Point(20, 76);
        spacer.Name = "spacer";
        spacer.Size = new Size(600, 8);
        spacer.TabIndex = 4;
        // 
        // cardAdd
        // 
        cardAdd.BackColor = Color.White;
        cardAdd.Controls.Add(lblName);
        cardAdd.Controls.Add(txtProductName);
        cardAdd.Controls.Add(lblPrice);
        cardAdd.Controls.Add(txtProductPrice);
        cardAdd.Controls.Add(btnAdd);
        cardAdd.Dock = DockStyle.Top;
        cardAdd.Location = new Point(20, 16);
        cardAdd.Name = "cardAdd";
        cardAdd.Padding = new Padding(16, 10, 16, 10);
        cardAdd.Size = new Size(600, 60);
        cardAdd.TabIndex = 0;
        // 
        // lblName
        // 
        lblName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblName.AutoSize = true;
        lblName.Font = new Font("Segoe UI", 10F);
        lblName.ForeColor = Color.FromArgb(44, 62, 80);
        lblName.Location = new Point(500, 18);
        lblName.Name = "lblName";
        lblName.Size = new Size(76, 19);
        lblName.TabIndex = 0;
        lblName.Text = "اسم المنتج:";
        // 
        // txtProductName
        // 
        txtProductName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        txtProductName.BorderStyle = BorderStyle.FixedSingle;
        txtProductName.Font = new Font("Segoe UI", 10F);
        txtProductName.Location = new Point(310, 14);
        txtProductName.Name = "txtProductName";
        txtProductName.RightToLeft = RightToLeft.Yes;
        txtProductName.Size = new Size(180, 25);
        txtProductName.TabIndex = 1;
        // 
        // lblPrice
        // 
        lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblPrice.AutoSize = true;
        lblPrice.Font = new Font("Segoe UI", 10F);
        lblPrice.ForeColor = Color.FromArgb(44, 62, 80);
        lblPrice.Location = new Point(260, 18);
        lblPrice.Name = "lblPrice";
        lblPrice.Size = new Size(47, 19);
        lblPrice.TabIndex = 2;
        lblPrice.Text = "السعر:";
        // 
        // txtProductPrice
        // 
        txtProductPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        txtProductPrice.BorderStyle = BorderStyle.FixedSingle;
        txtProductPrice.Font = new Font("Segoe UI", 10F);
        txtProductPrice.Location = new Point(154, 14);
        txtProductPrice.Name = "txtProductPrice";
        txtProductPrice.Size = new Size(100, 25);
        txtProductPrice.TabIndex = 3;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.FromArgb(0, 95, 115);
        btnAdd.Cursor = Cursors.Hand;
        btnAdd.FlatAppearance.BorderSize = 0;
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnAdd.ForeColor = Color.White;
        btnAdd.Location = new Point(16, 12);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(100, 35);
        btnAdd.TabIndex = 4;
        btnAdd.Text = "➕ إضافة";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // ProductCatalogForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 246, 250);
        ClientSize = new Size(640, 500);
        Controls.Add(contentPanel);
        Controls.Add(headerBar);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(550, 400);
        Name = "ProductCatalogForm";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        StartPosition = FormStartPosition.CenterParent;
        Text = "إدارة المنتجات";
        headerBar.ResumeLayout(false);
        headerBar.PerformLayout();
        contentPanel.ResumeLayout(false);
        bottomPanel.ResumeLayout(false);
        cardGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
        cardAdd.ResumeLayout(false);
        cardAdd.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    // Panels
    private Panel headerBar;
    private Panel contentPanel;
    private Panel cardAdd;
    private Panel cardGrid;
    private Panel bottomPanel;
    private Panel spacer;

    // Labels
    private Label lblTitle;
    private Label lblName;
    private Label lblPrice;

    // Inputs
    private TextBox txtProductName;
    private TextBox txtProductPrice;
    private Button btnAdd;
    private Button btnClose;

    // DataGridView
    private DataGridView dgvProducts;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colName;
    private DataGridViewTextBoxColumn colProdPrice;
    private DataGridViewButtonColumn colEditProd;
    private DataGridViewButtonColumn colDeleteProd;
}
