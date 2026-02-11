namespace GoodsReceipt.Forms;

partial class MainForm
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
        DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        rootPanel = new Panel();
        contentPanel = new Panel();
        bottomBar = new Panel();
        lblTotalLabel = new Label();
        lblTotalAmount = new Label();
        lblPrinter = new Label();
        cmbPrinters = new ComboBox();
        lblCopies = new Label();
        nudCopies = new NumericUpDown();
        btnNewReceipt = new Button();
        btnPreview = new Button();
        btnPrint = new Button();
        spacer3 = new Panel();
        cardGrid = new Panel();
        dgvItems = new DataGridView();
        colProduct = new DataGridViewTextBoxColumn();
        colQtyPlus = new DataGridViewButtonColumn();
        colQty = new DataGridViewTextBoxColumn();
        colQtyMinus = new DataGridViewButtonColumn();
        colPrice = new DataGridViewTextBoxColumn();
        colSubtotal = new DataGridViewTextBoxColumn();
        colDelete = new DataGridViewButtonColumn();
        spacer2 = new Panel();
        cardAddItem = new Panel();
        lblCatalog = new Label();
        cmbProducts = new ComboBox();
        lblItemNameLabel = new Label();
        txtItemName = new TextBox();
        lblQty = new Label();
        nudQuantity = new NumericUpDown();
        lblPrice = new Label();
        txtUnitPrice = new TextBox();
        btnAddItem = new Button();
        spacer1 = new Panel();
        cardInfo = new Panel();
        lblCustomer = new Label();
        txtCustomerName = new TextBox();
        lblEmployee = new Label();
        txtEmployeeInfo = new TextBox();
        lblReceiptLabel = new Label();
        lblReceiptNumber = new Label();
        headerBar = new Panel();
        lblTitle = new Label();
        btnMenuSettings = new Button();
        btnMenuProducts = new Button();
        btnMenuHistory = new Button();
        rootPanel.SuspendLayout();
        contentPanel.SuspendLayout();
        bottomBar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudCopies).BeginInit();
        cardGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
        cardAddItem.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
        cardInfo.SuspendLayout();
        headerBar.SuspendLayout();
        SuspendLayout();
        // 
        // rootPanel
        // 
        rootPanel.BackColor = Color.FromArgb(245, 246, 250);
        rootPanel.Controls.Add(contentPanel);
        rootPanel.Controls.Add(headerBar);
        rootPanel.Dock = DockStyle.Fill;
        rootPanel.Location = new Point(0, 0);
        rootPanel.Name = "rootPanel";
        rootPanel.Size = new Size(1019, 842);
        rootPanel.TabIndex = 0;
        // 
        // contentPanel
        // 
        contentPanel.BackColor = Color.FromArgb(245, 246, 250);
        contentPanel.Controls.Add(bottomBar);
        contentPanel.Controls.Add(spacer3);
        contentPanel.Controls.Add(cardGrid);
        contentPanel.Controls.Add(spacer2);
        contentPanel.Controls.Add(cardAddItem);
        contentPanel.Controls.Add(spacer1);
        contentPanel.Controls.Add(cardInfo);
        contentPanel.Dock = DockStyle.Fill;
        contentPanel.Location = new Point(0, 60);
        contentPanel.Name = "contentPanel";
        contentPanel.Padding = new Padding(20, 10, 20, 10);
        contentPanel.Size = new Size(1019, 782);
        contentPanel.TabIndex = 1;
        // 
        // bottomBar
        // 
        bottomBar.BackColor = Color.White;
        bottomBar.Controls.Add(lblTotalLabel);
        bottomBar.Controls.Add(lblTotalAmount);
        bottomBar.Controls.Add(lblPrinter);
        bottomBar.Controls.Add(cmbPrinters);
        bottomBar.Controls.Add(lblCopies);
        bottomBar.Controls.Add(nudCopies);
        bottomBar.Controls.Add(btnNewReceipt);
        bottomBar.Controls.Add(btnPreview);
        bottomBar.Controls.Add(btnPrint);
        bottomBar.Dock = DockStyle.Bottom;
        bottomBar.Location = new Point(20, 644);
        bottomBar.Name = "bottomBar";
        bottomBar.Padding = new Padding(20, 8, 20, 8);
        bottomBar.Size = new Size(979, 120);
        bottomBar.TabIndex = 3;
        // 
        // lblTotalLabel
        // 
        lblTotalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblTotalLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTotalLabel.ForeColor = Color.FromArgb(44, 62, 80);
        lblTotalLabel.Location = new Point(759, 8);
        lblTotalLabel.Name = "lblTotalLabel";
        lblTotalLabel.Size = new Size(200, 36);
        lblTotalLabel.TabIndex = 0;
        lblTotalLabel.Text = "المجموع الكلي:";
        lblTotalLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblTotalAmount
        // 
        lblTotalAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblTotalAmount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTotalAmount.ForeColor = Color.FromArgb(39, 174, 96);
        lblTotalAmount.Location = new Point(549, 8);
        lblTotalAmount.Name = "lblTotalAmount";
        lblTotalAmount.Size = new Size(200, 36);
        lblTotalAmount.TabIndex = 1;
        lblTotalAmount.Text = "0 د.ع";
        lblTotalAmount.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblPrinter
        // 
        lblPrinter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblPrinter.AutoSize = true;
        lblPrinter.Font = new Font("Segoe UI", 10F);
        lblPrinter.ForeColor = Color.FromArgb(44, 62, 80);
        lblPrinter.Location = new Point(899, 70);
        lblPrinter.Name = "lblPrinter";
        lblPrinter.Size = new Size(57, 19);
        lblPrinter.TabIndex = 2;
        lblPrinter.Text = "الطابعة:";
        // 
        // cmbPrinters
        // 
        cmbPrinters.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPrinters.Font = new Font("Segoe UI", 10F);
        cmbPrinters.Location = new Point(580, 66);
        cmbPrinters.Name = "cmbPrinters";
        cmbPrinters.Size = new Size(220, 25);
        cmbPrinters.TabIndex = 3;
        cmbPrinters.SelectedIndexChanged += cmbPrinters_SelectedIndexChanged;
        // 
        // lblCopies
        // 
        lblCopies.AutoSize = true;
        lblCopies.Font = new Font("Segoe UI", 10F);
        lblCopies.ForeColor = Color.FromArgb(44, 62, 80);
        lblCopies.Location = new Point(528, 69);
        lblCopies.Name = "lblCopies";
        lblCopies.Size = new Size(37, 19);
        lblCopies.TabIndex = 4;
        lblCopies.Text = "نسخ:";
        // 
        // nudCopies
        // 
        nudCopies.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        nudCopies.Font = new Font("Segoe UI", 10F);
        nudCopies.Location = new Point(472, 67);
        nudCopies.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
        nudCopies.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudCopies.Name = "nudCopies";
        nudCopies.Size = new Size(50, 25);
        nudCopies.TabIndex = 5;
        nudCopies.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // btnNewReceipt
        // 
        btnNewReceipt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnNewReceipt.BackColor = Color.FromArgb(230, 126, 34);
        btnNewReceipt.Cursor = Cursors.Hand;
        btnNewReceipt.FlatAppearance.BorderSize = 0;
        btnNewReceipt.FlatStyle = FlatStyle.Flat;
        btnNewReceipt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnNewReceipt.ForeColor = Color.White;
        btnNewReceipt.Location = new Point(20, 62);
        btnNewReceipt.Name = "btnNewReceipt";
        btnNewReceipt.Size = new Size(130, 42);
        btnNewReceipt.TabIndex = 6;
        btnNewReceipt.Text = "📄 وصل جديد";
        btnNewReceipt.UseVisualStyleBackColor = false;
        btnNewReceipt.Click += btnNewReceipt_Click;
        // 
        // btnPreview
        // 
        btnPreview.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnPreview.BackColor = Color.White;
        btnPreview.Cursor = Cursors.Hand;
        btnPreview.FlatAppearance.BorderColor = Color.FromArgb(0, 95, 115);
        btnPreview.FlatStyle = FlatStyle.Flat;
        btnPreview.Font = new Font("Segoe UI", 11F);
        btnPreview.ForeColor = Color.FromArgb(0, 95, 115);
        btnPreview.Location = new Point(158, 62);
        btnPreview.Name = "btnPreview";
        btnPreview.Size = new Size(110, 42);
        btnPreview.TabIndex = 7;
        btnPreview.Text = "👁 معاينة";
        btnPreview.UseVisualStyleBackColor = false;
        btnPreview.Click += btnPreview_Click;
        // 
        // btnPrint
        // 
        btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnPrint.BackColor = Color.FromArgb(39, 174, 96);
        btnPrint.Cursor = Cursors.Hand;
        btnPrint.FlatAppearance.BorderSize = 0;
        btnPrint.FlatStyle = FlatStyle.Flat;
        btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnPrint.ForeColor = Color.White;
        btnPrint.Location = new Point(276, 62);
        btnPrint.Name = "btnPrint";
        btnPrint.Size = new Size(160, 42);
        btnPrint.TabIndex = 8;
        btnPrint.Text = "🖨 طباعة وحفظ";
        btnPrint.UseVisualStyleBackColor = false;
        btnPrint.Click += btnPrint_Click;
        // 
        // spacer3
        // 
        spacer3.BackColor = Color.FromArgb(245, 246, 250);
        spacer3.Dock = DockStyle.Bottom;
        spacer3.Location = new Point(20, 764);
        spacer3.Name = "spacer3";
        spacer3.Size = new Size(979, 8);
        spacer3.TabIndex = 4;
        // 
        // cardGrid
        // 
        cardGrid.AutoScroll = true;
        cardGrid.BackColor = Color.White;
        cardGrid.Controls.Add(dgvItems);
        cardGrid.Dock = DockStyle.Fill;
        cardGrid.Location = new Point(20, 363);
        cardGrid.Name = "cardGrid";
        cardGrid.Padding = new Padding(1);
        cardGrid.Size = new Size(979, 409);
        cardGrid.TabIndex = 2;
        // 
        // dgvItems
        // 
        dgvItems.AllowUserToAddRows = false;
        dgvItems.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 248, 250);
        dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvItems.BackgroundColor = Color.White;
        dgvItems.BorderStyle = BorderStyle.None;
        dgvItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 95, 115);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.Padding = new Padding(4);
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvItems.ColumnHeadersHeight = 42;
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvItems.Columns.AddRange(new DataGridViewColumn[] { colProduct, colQtyPlus, colQty, colQtyMinus, colPrice, colSubtotal, colDelete });
        dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle6.BackColor = SystemColors.Window;
        dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F);
        dataGridViewCellStyle6.ForeColor = Color.FromArgb(44, 62, 80);
        dataGridViewCellStyle6.Padding = new Padding(4);
        dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(200, 230, 240);
        dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(44, 62, 80);
        dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
        dgvItems.DefaultCellStyle = dataGridViewCellStyle6;
        dgvItems.Dock = DockStyle.Fill;
        dgvItems.EnableHeadersVisualStyles = false;
        dgvItems.Font = new Font("Segoe UI", 11F);
        dgvItems.GridColor = Color.FromArgb(220, 224, 232);
        dgvItems.Location = new Point(1, 1);
        dgvItems.MultiSelect = false;
        dgvItems.Name = "dgvItems";
        dgvItems.ReadOnly = true;
        dgvItems.RightToLeft = RightToLeft.Yes;
        dgvItems.RowHeadersVisible = false;
        dgvItems.RowTemplate.Height = 38;
        dgvItems.ScrollBars = ScrollBars.None;
        dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvItems.Size = new Size(977, 407);
        dgvItems.TabIndex = 0;
        dgvItems.CellClick += dgvItems_CellClick;
        // 
        // colProduct
        // 
        colProduct.FillWeight = 34F;
        colProduct.HeaderText = "المادة";
        colProduct.Name = "colProduct";
        colProduct.ReadOnly = true;
        // 
        // colQtyPlus
        // 
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(39, 174, 96);
        colQtyPlus.DefaultCellStyle = dataGridViewCellStyle3;
        colQtyPlus.FillWeight = 5F;
        colQtyPlus.HeaderText = "";
        colQtyPlus.Name = "colQtyPlus";
        colQtyPlus.ReadOnly = true;
        colQtyPlus.Text = "+";
        colQtyPlus.UseColumnTextForButtonValue = true;
        // 
        // colQty
        // 
        colQty.FillWeight = 10F;
        colQty.HeaderText = "الكمية";
        colQty.Name = "colQty";
        colQty.ReadOnly = true;
        // 
        // colQtyMinus
        // 
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        dataGridViewCellStyle4.ForeColor = Color.FromArgb(192, 57, 43);
        colQtyMinus.DefaultCellStyle = dataGridViewCellStyle4;
        colQtyMinus.FillWeight = 5F;
        colQtyMinus.HeaderText = "";
        colQtyMinus.Name = "colQtyMinus";
        colQtyMinus.ReadOnly = true;
        colQtyMinus.Text = "-";
        colQtyMinus.UseColumnTextForButtonValue = true;
        // 
        // colPrice
        // 
        colPrice.FillWeight = 18F;
        colPrice.HeaderText = "سعر الوحدة";
        colPrice.Name = "colPrice";
        colPrice.ReadOnly = true;
        // 
        // colSubtotal
        // 
        colSubtotal.FillWeight = 18F;
        colSubtotal.HeaderText = "المجموع";
        colSubtotal.Name = "colSubtotal";
        colSubtotal.ReadOnly = true;
        // 
        // colDelete
        // 
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle5.ForeColor = Color.FromArgb(192, 57, 43);
        colDelete.DefaultCellStyle = dataGridViewCellStyle5;
        colDelete.FillWeight = 6F;
        colDelete.HeaderText = "";
        colDelete.Name = "colDelete";
        colDelete.ReadOnly = true;
        colDelete.Text = "❌";
        colDelete.UseColumnTextForButtonValue = true;
        // 
        // spacer2
        // 
        spacer2.BackColor = Color.FromArgb(245, 246, 250);
        spacer2.Dock = DockStyle.Top;
        spacer2.Location = new Point(20, 355);
        spacer2.Name = "spacer2";
        spacer2.Size = new Size(979, 8);
        spacer2.TabIndex = 5;
        // 
        // cardAddItem
        // 
        cardAddItem.BackColor = Color.White;
        cardAddItem.Controls.Add(lblCatalog);
        cardAddItem.Controls.Add(cmbProducts);
        cardAddItem.Controls.Add(lblItemNameLabel);
        cardAddItem.Controls.Add(txtItemName);
        cardAddItem.Controls.Add(lblQty);
        cardAddItem.Controls.Add(nudQuantity);
        cardAddItem.Controls.Add(lblPrice);
        cardAddItem.Controls.Add(txtUnitPrice);
        cardAddItem.Controls.Add(btnAddItem);
        cardAddItem.Dock = DockStyle.Top;
        cardAddItem.Location = new Point(20, 295);
        cardAddItem.Margin = new Padding(0, 0, 0, 8);
        cardAddItem.Name = "cardAddItem";
        cardAddItem.Padding = new Padding(12, 10, 12, 10);
        cardAddItem.Size = new Size(979, 60);
        cardAddItem.TabIndex = 1;
        // 
        // lblCatalog
        // 
        lblCatalog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblCatalog.AutoSize = true;
        lblCatalog.Font = new Font("Segoe UI", 10F);
        lblCatalog.ForeColor = Color.FromArgb(44, 62, 80);
        lblCatalog.Location = new Point(879, 18);
        lblCatalog.Name = "lblCatalog";
        lblCatalog.Size = new Size(73, 19);
        lblCatalog.TabIndex = 0;
        lblCatalog.Text = "من القائمة:";
        // 
        // cmbProducts
        // 
        cmbProducts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        cmbProducts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        cmbProducts.AutoCompleteSource = AutoCompleteSource.ListItems;
        cmbProducts.Font = new Font("Segoe UI", 10F);
        cmbProducts.Location = new Point(709, 14);
        cmbProducts.Name = "cmbProducts";
        cmbProducts.RightToLeft = RightToLeft.Yes;
        cmbProducts.Size = new Size(160, 25);
        cmbProducts.TabIndex = 1;
        cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
        // 
        // lblItemNameLabel
        // 
        lblItemNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblItemNameLabel.AutoSize = true;
        lblItemNameLabel.Font = new Font("Segoe UI", 10F);
        lblItemNameLabel.ForeColor = Color.FromArgb(44, 62, 80);
        lblItemNameLabel.Location = new Point(659, 18);
        lblItemNameLabel.Name = "lblItemNameLabel";
        lblItemNameLabel.Size = new Size(47, 19);
        lblItemNameLabel.TabIndex = 2;
        lblItemNameLabel.Text = "المادة:";
        // 
        // txtItemName
        // 
        txtItemName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        txtItemName.BorderStyle = BorderStyle.FixedSingle;
        txtItemName.Font = new Font("Segoe UI", 10F);
        txtItemName.Location = new Point(511, 14);
        txtItemName.Name = "txtItemName";
        txtItemName.RightToLeft = RightToLeft.Yes;
        txtItemName.Size = new Size(140, 25);
        txtItemName.TabIndex = 3;
        // 
        // lblQty
        // 
        lblQty.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblQty.AutoSize = true;
        lblQty.Font = new Font("Segoe UI", 10F);
        lblQty.ForeColor = Color.FromArgb(44, 62, 80);
        lblQty.Location = new Point(455, 18);
        lblQty.Name = "lblQty";
        lblQty.Size = new Size(48, 19);
        lblQty.TabIndex = 4;
        lblQty.Text = "الكمية:";
        // 
        // nudQuantity
        // 
        nudQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        nudQuantity.Font = new Font("Segoe UI", 10F);
        nudQuantity.Location = new Point(397, 14);
        nudQuantity.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
        nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudQuantity.Name = "nudQuantity";
        nudQuantity.Size = new Size(55, 25);
        nudQuantity.TabIndex = 5;
        nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblPrice
        // 
        lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblPrice.AutoSize = true;
        lblPrice.Font = new Font("Segoe UI", 10F);
        lblPrice.ForeColor = Color.FromArgb(44, 62, 80);
        lblPrice.Location = new Point(343, 18);
        lblPrice.Name = "lblPrice";
        lblPrice.Size = new Size(47, 19);
        lblPrice.TabIndex = 6;
        lblPrice.Text = "السعر:";
        // 
        // txtUnitPrice
        // 
        txtUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        txtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
        txtUnitPrice.Font = new Font("Segoe UI", 10F);
        txtUnitPrice.Location = new Point(249, 14);
        txtUnitPrice.Name = "txtUnitPrice";
        txtUnitPrice.Size = new Size(90, 25);
        txtUnitPrice.TabIndex = 7;
        // 
        // btnAddItem
        // 
        btnAddItem.BackColor = Color.FromArgb(0, 95, 115);
        btnAddItem.Cursor = Cursors.Hand;
        btnAddItem.FlatAppearance.BorderSize = 0;
        btnAddItem.FlatStyle = FlatStyle.Flat;
        btnAddItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnAddItem.ForeColor = Color.White;
        btnAddItem.Location = new Point(12, 12);
        btnAddItem.Name = "btnAddItem";
        btnAddItem.Size = new Size(100, 35);
        btnAddItem.TabIndex = 8;
        btnAddItem.Text = "➕ إضافة";
        btnAddItem.UseVisualStyleBackColor = false;
        btnAddItem.Click += btnAddItem_Click;
        // 
        // spacer1
        // 
        spacer1.BackColor = Color.FromArgb(245, 246, 250);
        spacer1.Dock = DockStyle.Top;
        spacer1.Location = new Point(20, 287);
        spacer1.Name = "spacer1";
        spacer1.Size = new Size(979, 8);
        spacer1.TabIndex = 6;
        // 
        // cardInfo
        // 
        cardInfo.BackColor = Color.White;
        cardInfo.Controls.Add(lblCustomer);
        cardInfo.Controls.Add(txtCustomerName);
        cardInfo.Controls.Add(lblEmployee);
        cardInfo.Controls.Add(txtEmployeeInfo);
        cardInfo.Controls.Add(lblReceiptLabel);
        cardInfo.Controls.Add(lblReceiptNumber);
        cardInfo.Dock = DockStyle.Top;
        cardInfo.Location = new Point(20, 10);
        cardInfo.Margin = new Padding(0, 0, 0, 12);
        cardInfo.Name = "cardInfo";
        cardInfo.Padding = new Padding(20, 16, 20, 16);
        cardInfo.Size = new Size(979, 277);
        cardInfo.TabIndex = 0;
        // 
        // lblCustomer
        // 
        lblCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblCustomer.AutoSize = true;
        lblCustomer.Font = new Font("Segoe UI", 11F);
        lblCustomer.ForeColor = Color.FromArgb(44, 62, 80);
        lblCustomer.Location = new Point(779, 18);
        lblCustomer.Name = "lblCustomer";
        lblCustomer.Size = new Size(112, 20);
        lblCustomer.TabIndex = 0;
        lblCustomer.Text = "معلومات الزبون:";
        // 
        // txtCustomerName
        // 
        txtCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
        txtCustomerName.Font = new Font("Segoe UI", 10F);
        txtCustomerName.Location = new Point(20, 14);
        txtCustomerName.Multiline = true;
        txtCustomerName.Name = "txtCustomerName";
        txtCustomerName.RightToLeft = RightToLeft.Yes;
        txtCustomerName.ScrollBars = ScrollBars.Vertical;
        txtCustomerName.Size = new Size(739, 100);
        txtCustomerName.TabIndex = 1;
        // 
        // lblEmployee
        // 
        lblEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblEmployee.AutoSize = true;
        lblEmployee.Font = new Font("Segoe UI", 11F);
        lblEmployee.ForeColor = Color.FromArgb(44, 62, 80);
        lblEmployee.Location = new Point(779, 128);
        lblEmployee.Name = "lblEmployee";
        lblEmployee.Size = new Size(128, 20);
        lblEmployee.TabIndex = 2;
        lblEmployee.Text = "معلومات الموظف:";
        // 
        // txtEmployeeInfo
        // 
        txtEmployeeInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtEmployeeInfo.BorderStyle = BorderStyle.FixedSingle;
        txtEmployeeInfo.Font = new Font("Segoe UI", 10F);
        txtEmployeeInfo.Location = new Point(20, 124);
        txtEmployeeInfo.Multiline = true;
        txtEmployeeInfo.Name = "txtEmployeeInfo";
        txtEmployeeInfo.RightToLeft = RightToLeft.Yes;
        txtEmployeeInfo.ScrollBars = ScrollBars.Vertical;
        txtEmployeeInfo.Size = new Size(739, 100);
        txtEmployeeInfo.TabIndex = 3;
        // 
        // lblReceiptLabel
        // 
        lblReceiptLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblReceiptLabel.AutoSize = true;
        lblReceiptLabel.Font = new Font("Segoe UI", 11F);
        lblReceiptLabel.ForeColor = Color.FromArgb(44, 62, 80);
        lblReceiptLabel.Location = new Point(779, 240);
        lblReceiptLabel.Name = "lblReceiptLabel";
        lblReceiptLabel.Size = new Size(80, 20);
        lblReceiptLabel.TabIndex = 4;
        lblReceiptLabel.Text = "رقم الوصل:";
        // 
        // lblReceiptNumber
        // 
        lblReceiptNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblReceiptNumber.AutoSize = true;
        lblReceiptNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblReceiptNumber.ForeColor = Color.FromArgb(0, 95, 115);
        lblReceiptNumber.Location = new Point(559, 238);
        lblReceiptNumber.Name = "lblReceiptNumber";
        lblReceiptNumber.Size = new Size(130, 21);
        lblReceiptNumber.TabIndex = 5;
        lblReceiptNumber.Text = "سيتم التعيين تلقائياً";
        // 
        // headerBar
        // 
        headerBar.BackColor = Color.FromArgb(0, 95, 115);
        headerBar.Controls.Add(lblTitle);
        headerBar.Controls.Add(btnMenuSettings);
        headerBar.Controls.Add(btnMenuProducts);
        headerBar.Controls.Add(btnMenuHistory);
        headerBar.Dock = DockStyle.Top;
        headerBar.Location = new Point(0, 0);
        headerBar.Name = "headerBar";
        headerBar.Padding = new Padding(16, 0, 16, 0);
        headerBar.Size = new Size(1019, 60);
        headerBar.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(783, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(216, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "وصل استلام البضائع";
        // 
        // btnMenuSettings
        // 
        btnMenuSettings.BackColor = Color.Transparent;
        btnMenuSettings.Cursor = Cursors.Hand;
        btnMenuSettings.FlatAppearance.BorderSize = 0;
        btnMenuSettings.FlatStyle = FlatStyle.Flat;
        btnMenuSettings.Font = new Font("Segoe UI", 10F);
        btnMenuSettings.ForeColor = Color.White;
        btnMenuSettings.Location = new Point(16, 12);
        btnMenuSettings.Name = "btnMenuSettings";
        btnMenuSettings.Size = new Size(110, 36);
        btnMenuSettings.TabIndex = 1;
        btnMenuSettings.Text = "⚙ الإعدادات";
        btnMenuSettings.UseVisualStyleBackColor = false;
        btnMenuSettings.Click += btnSettings_Click;
        // 
        // btnMenuProducts
        // 
        btnMenuProducts.BackColor = Color.Transparent;
        btnMenuProducts.Cursor = Cursors.Hand;
        btnMenuProducts.FlatAppearance.BorderSize = 0;
        btnMenuProducts.FlatStyle = FlatStyle.Flat;
        btnMenuProducts.Font = new Font("Segoe UI", 10F);
        btnMenuProducts.ForeColor = Color.White;
        btnMenuProducts.Location = new Point(130, 12);
        btnMenuProducts.Name = "btnMenuProducts";
        btnMenuProducts.Size = new Size(110, 36);
        btnMenuProducts.TabIndex = 2;
        btnMenuProducts.Text = "📦 المنتجات";
        btnMenuProducts.UseVisualStyleBackColor = false;
        btnMenuProducts.Click += btnProducts_Click;
        // 
        // btnMenuHistory
        // 
        btnMenuHistory.BackColor = Color.Transparent;
        btnMenuHistory.Cursor = Cursors.Hand;
        btnMenuHistory.FlatAppearance.BorderSize = 0;
        btnMenuHistory.FlatStyle = FlatStyle.Flat;
        btnMenuHistory.Font = new Font("Segoe UI", 10F);
        btnMenuHistory.ForeColor = Color.White;
        btnMenuHistory.Location = new Point(244, 12);
        btnMenuHistory.Name = "btnMenuHistory";
        btnMenuHistory.Size = new Size(100, 36);
        btnMenuHistory.TabIndex = 3;
        btnMenuHistory.Text = "📋 السجل";
        btnMenuHistory.UseVisualStyleBackColor = false;
        btnMenuHistory.Click += btnHistory_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 246, 250);
        ClientSize = new Size(1019, 842);
        Controls.Add(rootPanel);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(900, 550);
        Name = "MainForm";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "وصل استلام البضائع";
        rootPanel.ResumeLayout(false);
        contentPanel.ResumeLayout(false);
        bottomBar.ResumeLayout(false);
        bottomBar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudCopies).EndInit();
        cardGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
        cardAddItem.ResumeLayout(false);
        cardAddItem.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
        cardInfo.ResumeLayout(false);
        cardInfo.PerformLayout();
        headerBar.ResumeLayout(false);
        headerBar.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    // UI fields - Panels
    private Panel cardInfo;
    private Panel cardAddItem;
    private Panel cardGrid;
    private Panel bottomBar;

    // UI fields - Labels
    private Label lblTitle;
    private Label lblCustomer;
    private Label lblEmployee;
    private Label lblReceiptLabel;
    private Label lblCatalog;
    private Label lblItemNameLabel;
    private Label lblQty;
    private Label lblPrice;
    private Label lblPrinter;
    private Label lblCopies;
    private Label lblReceiptNumber;
    private Label lblTotalAmount;

    // UI fields - Inputs
    private TextBox txtCustomerName;
    private TextBox txtEmployeeInfo;
    private ComboBox cmbProducts;
    private TextBox txtItemName;
    private NumericUpDown nudQuantity;
    private TextBox txtUnitPrice;
    private Button btnAddItem;
    private DataGridView dgvItems;
    private ComboBox cmbPrinters;
    private NumericUpDown nudCopies;
    private Button btnPreview;
    private Button btnPrint;
    private Button btnNewReceipt;
    private Panel rootPanel;
    private Panel headerBar;
    private Button btnMenuSettings;
    private Button btnMenuProducts;
    private Button btnMenuHistory;
    private Panel contentPanel;
    private Label lblTotalLabel;
    private Panel spacer3;
    private DataGridViewTextBoxColumn colProduct;
    private DataGridViewButtonColumn colQtyPlus;
    private DataGridViewTextBoxColumn colQty;
    private DataGridViewButtonColumn colQtyMinus;
    private DataGridViewTextBoxColumn colPrice;
    private DataGridViewTextBoxColumn colSubtotal;
    private DataGridViewButtonColumn colDelete;
    private Panel spacer2;
    private Panel spacer1;
}
