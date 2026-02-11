namespace GoodsReceipt.Forms;

partial class ReceiptHistoryForm
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
        headerBar = new Panel();
        lblTitle = new Label();
        contentPanel = new Panel();
        bottomPanel = new Panel();
        btnClose = new Button();
        cardGrid = new Panel();
        dgvReceipts = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colReceiptNum = new DataGridViewLinkColumn();
        colCustomer = new DataGridViewTextBoxColumn();
        colEmployee = new DataGridViewTextBoxColumn();
        colDate = new DataGridViewTextBoxColumn();
        colTotal = new DataGridViewTextBoxColumn();
        colReprint = new DataGridViewButtonColumn();
        spacer = new Panel();
        cardSearch = new Panel();
        lblSearch = new Label();
        txtSearch = new TextBox();
        headerBar.SuspendLayout();
        contentPanel.SuspendLayout();
        bottomPanel.SuspendLayout();
        cardGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvReceipts).BeginInit();
        cardSearch.SuspendLayout();
        SuspendLayout();
        // 
        // headerBar
        // 
        headerBar.BackColor = Color.FromArgb(0, 95, 115);
        headerBar.Controls.Add(lblTitle);
        headerBar.Dock = DockStyle.Top;
        headerBar.Location = new Point(0, 0);
        headerBar.Name = "headerBar";
        headerBar.Size = new Size(800, 50);
        headerBar.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(600, 10);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(180, 28);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "📋 سجل الوصولات";
        // 
        // contentPanel
        // 
        contentPanel.BackColor = Color.FromArgb(245, 246, 250);
        contentPanel.Controls.Add(bottomPanel);
        contentPanel.Controls.Add(cardGrid);
        contentPanel.Controls.Add(spacer);
        contentPanel.Controls.Add(cardSearch);
        contentPanel.Dock = DockStyle.Fill;
        contentPanel.Location = new Point(0, 50);
        contentPanel.Name = "contentPanel";
        contentPanel.Padding = new Padding(20, 16, 20, 20);
        contentPanel.Size = new Size(800, 500);
        contentPanel.TabIndex = 1;
        // 
        // bottomPanel
        // 
        bottomPanel.BackColor = Color.FromArgb(245, 246, 250);
        bottomPanel.Controls.Add(btnClose);
        bottomPanel.Dock = DockStyle.Bottom;
        bottomPanel.Location = new Point(20, 445);
        bottomPanel.Name = "bottomPanel";
        bottomPanel.Size = new Size(760, 55);
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
        cardGrid.Controls.Add(dgvReceipts);
        cardGrid.Dock = DockStyle.Fill;
        cardGrid.Location = new Point(20, 79);
        cardGrid.Name = "cardGrid";
        cardGrid.Padding = new Padding(1);
        cardGrid.Size = new Size(760, 366);
        cardGrid.TabIndex = 2;
        // 
        // dgvReceipts
        // 
        dgvReceipts.AllowUserToAddRows = false;
        dgvReceipts.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 248, 250);
        dgvReceipts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvReceipts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvReceipts.BackgroundColor = Color.White;
        dgvReceipts.BorderStyle = BorderStyle.None;
        dgvReceipts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 95, 115);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvReceipts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvReceipts.ColumnHeadersHeight = 40;
        dgvReceipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvReceipts.Columns.AddRange(new DataGridViewColumn[] { colId, colReceiptNum, colCustomer, colEmployee, colDate, colTotal, colReprint });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle3.BackColor = SystemColors.Window;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(44, 62, 80);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 230, 240);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(44, 62, 80);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvReceipts.DefaultCellStyle = dataGridViewCellStyle3;
        dgvReceipts.Dock = DockStyle.Fill;
        dgvReceipts.EnableHeadersVisualStyles = false;
        dgvReceipts.Font = new Font("Segoe UI", 10F);
        dgvReceipts.GridColor = Color.FromArgb(220, 224, 232);
        dgvReceipts.Location = new Point(1, 1);
        dgvReceipts.MultiSelect = false;
        dgvReceipts.Name = "dgvReceipts";
        dgvReceipts.ReadOnly = true;
        dgvReceipts.RightToLeft = RightToLeft.Yes;
        dgvReceipts.RowHeadersVisible = false;
        dgvReceipts.RowTemplate.Height = 36;
        dgvReceipts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvReceipts.Size = new Size(758, 364);
        dgvReceipts.TabIndex = 0;
        dgvReceipts.CellClick += dgvReceipts_CellClick;
        // 
        // colId
        // 
        colId.HeaderText = "#";
        colId.Name = "colId";
        colId.ReadOnly = true;
        colId.Visible = false;
        // 
        // colReceiptNum
        // 
        colReceiptNum.ActiveLinkColor = Color.FromArgb(0, 130, 155);
        colReceiptNum.FillWeight = 18F;
        colReceiptNum.HeaderText = "رقم الوصل";
        colReceiptNum.LinkColor = Color.FromArgb(0, 95, 115);
        colReceiptNum.Name = "colReceiptNum";
        colReceiptNum.ReadOnly = true;
        colReceiptNum.TrackVisitedState = false;
        colReceiptNum.UseColumnTextForLinkValue = false;
        colReceiptNum.VisitedLinkColor = Color.FromArgb(0, 95, 115);
        // 
        // colCustomer
        // 
        colCustomer.FillWeight = 18F;
        colCustomer.HeaderText = "الزبون";
        colCustomer.Name = "colCustomer";
        colCustomer.ReadOnly = true;
        // 
        // colEmployee
        // 
        colEmployee.FillWeight = 22F;
        colEmployee.HeaderText = "معلومات الموظف";
        colEmployee.Name = "colEmployee";
        colEmployee.ReadOnly = true;
        // 
        // colDate
        // 
        colDate.FillWeight = 21F;
        colDate.HeaderText = "التاريخ";
        colDate.Name = "colDate";
        colDate.ReadOnly = true;
        // 
        // colTotal
        // 
        colTotal.FillWeight = 18F;
        colTotal.HeaderText = "المجموع (د.ع)";
        colTotal.Name = "colTotal";
        colTotal.ReadOnly = true;
        // 
        // colReprint
        // 
        colReprint.FillWeight = 17F;
        colReprint.HeaderText = "";
        colReprint.Name = "colReprint";
        colReprint.ReadOnly = true;
        colReprint.Text = "🖨 إعادة طباعة";
        colReprint.UseColumnTextForButtonValue = true;
        // 
        // spacer
        // 
        spacer.BackColor = Color.FromArgb(245, 246, 250);
        spacer.Dock = DockStyle.Top;
        spacer.Location = new Point(20, 71);
        spacer.Name = "spacer";
        spacer.Size = new Size(760, 8);
        spacer.TabIndex = 4;
        // 
        // cardSearch
        // 
        cardSearch.BackColor = Color.White;
        cardSearch.Controls.Add(lblSearch);
        cardSearch.Controls.Add(txtSearch);
        cardSearch.Dock = DockStyle.Top;
        cardSearch.Location = new Point(20, 16);
        cardSearch.Name = "cardSearch";
        cardSearch.Padding = new Padding(16, 10, 16, 10);
        cardSearch.Size = new Size(760, 55);
        cardSearch.TabIndex = 0;
        // 
        // lblSearch
        // 
        lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblSearch.AutoSize = true;
        lblSearch.Font = new Font("Segoe UI", 10F);
        lblSearch.ForeColor = Color.FromArgb(44, 62, 80);
        lblSearch.Location = new Point(680, 16);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(56, 19);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "🔍 بحث:";
        // 
        // txtSearch
        // 
        txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtSearch.BorderStyle = BorderStyle.FixedSingle;
        txtSearch.Font = new Font("Segoe UI", 11F);
        txtSearch.Location = new Point(16, 12);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "رقم الوصل أو اسم الزبون...";
        txtSearch.RightToLeft = RightToLeft.Yes;
        txtSearch.Size = new Size(650, 27);
        txtSearch.TabIndex = 1;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // ReceiptHistoryForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 246, 250);
        ClientSize = new Size(800, 550);
        Controls.Add(contentPanel);
        Controls.Add(headerBar);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(650, 400);
        Name = "ReceiptHistoryForm";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        StartPosition = FormStartPosition.CenterParent;
        Text = "سجل الوصولات";
        headerBar.ResumeLayout(false);
        headerBar.PerformLayout();
        contentPanel.ResumeLayout(false);
        bottomPanel.ResumeLayout(false);
        cardGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvReceipts).EndInit();
        cardSearch.ResumeLayout(false);
        cardSearch.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    // Panels
    private Panel headerBar;
    private Panel contentPanel;
    private Panel cardSearch;
    private Panel cardGrid;
    private Panel bottomPanel;
    private Panel spacer;

    // Labels
    private Label lblTitle;
    private Label lblSearch;

    // Inputs
    private TextBox txtSearch;
    private Button btnClose;

    // DataGridView
    private DataGridView dgvReceipts;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewLinkColumn colReceiptNum;
    private DataGridViewTextBoxColumn colCustomer;
    private DataGridViewTextBoxColumn colEmployee;
    private DataGridViewTextBoxColumn colDate;
    private DataGridViewTextBoxColumn colTotal;
    private DataGridViewButtonColumn colReprint;
}
