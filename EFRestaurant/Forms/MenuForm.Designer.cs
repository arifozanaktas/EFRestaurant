namespace EFRestaurant.Forms;

partial class MenuForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        groupBox2 = new GroupBox();
        btnEdit = new Button();
        btnDelete = new Button();
        dgvMenus = new DataGridView();
        label7 = new Label();
        txtSearch = new TextBox();
        groupBox1 = new GroupBox();
        btnAdd = new Button();
        label2 = new Label();
        txtTitle = new TextBox();
        label3 = new Label();
        txtDescription = new TextBox();
        txtPrice = new TextBox();
        label4 = new Label();
        label1 = new Label();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMenus).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btnEdit);
        groupBox2.Controls.Add(btnDelete);
        groupBox2.Controls.Add(dgvMenus);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(txtSearch);
        groupBox2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
        groupBox2.Location = new Point(560, 132);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(1316, 794);
        groupBox2.TabIndex = 8;
        groupBox2.TabStop = false;
        groupBox2.Text = "Menu List";
        // 
        // btnEdit
        // 
        btnEdit.BackColor = SystemColors.ActiveCaption;
        btnEdit.Location = new Point(984, 646);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(326, 46);
        btnEdit.TabIndex = 3;
        btnEdit.Text = "Edit Menu";
        btnEdit.UseVisualStyleBackColor = false;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.IndianRed;
        btnDelete.Location = new Point(984, 708);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(326, 46);
        btnDelete.TabIndex = 3;
        btnDelete.Text = "Delete Menu";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // dgvMenus
        // 
        dgvMenus.BackgroundColor = SystemColors.ActiveCaption;
        dgvMenus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvMenus.Location = new Point(14, 38);
        dgvMenus.Name = "dgvMenus";
        dgvMenus.RowHeadersWidth = 82;
        dgvMenus.Size = new Size(1296, 577);
        dgvMenus.TabIndex = 4;
        dgvMenus.CellClick += dgvMenus_CellClick;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(24, 656);
        label7.Name = "label7";
        label7.Size = new Size(189, 32);
        label7.TabIndex = 1;
        label7.Text = "Search By Title";
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(272, 656);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(200, 39);
        txtSearch.TabIndex = 2;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnAdd);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(txtTitle);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(txtDescription);
        groupBox1.Controls.Add(txtPrice);
        groupBox1.Controls.Add(label4);
        groupBox1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
        groupBox1.Location = new Point(89, 132);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(447, 794);
        groupBox1.TabIndex = 7;
        groupBox1.TabStop = false;
        groupBox1.Text = "New Menu";
        // 
        // btnAdd
        // 
        btnAdd.BackColor = SystemColors.ActiveCaption;
        btnAdd.Location = new Point(41, 673);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(352, 46);
        btnAdd.TabIndex = 3;
        btnAdd.Text = "Add New Menu";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(41, 89);
        label2.Name = "label2";
        label2.Size = new Size(66, 32);
        label2.TabIndex = 1;
        label2.Text = "Title";
        // 
        // txtTitle
        // 
        txtTitle.Location = new Point(193, 86);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(200, 39);
        txtTitle.TabIndex = 2;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(41, 211);
        label3.Name = "label3";
        label3.Size = new Size(146, 32);
        label3.TabIndex = 1;
        label3.Text = "Description";
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(193, 208);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(200, 39);
        txtDescription.TabIndex = 2;
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(193, 325);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(200, 39);
        txtPrice.TabIndex = 2;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(41, 328);
        label4.Name = "label4";
        label4.Size = new Size(71, 32);
        label4.TabIndex = 1;
        label4.Text = "Price";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
        label1.ForeColor = SystemColors.ControlText;
        label1.ImageAlign = ContentAlignment.TopCenter;
        label1.Location = new Point(736, 29);
        label1.Name = "label1";
        label1.Size = new Size(510, 71);
        label1.TabIndex = 6;
        label1.Text = "Menu Management";
        label1.TextAlign = ContentAlignment.TopCenter;
        // 
        // MenuForm
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(2016, 1116);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        Name = "MenuForm";
        Text = "MenuForm";
        Load += MenuForm_Load;
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMenus).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox groupBox2;
    private Button btnEdit;
    private Button btnDelete;
    private DataGridView dgvMenus;
    private Label label7;
    private TextBox txtSearch;
    private GroupBox groupBox1;
    private Button btnAdd;
    private Label label2;
    private TextBox txtTitle;
    private Label label3;
    private TextBox txtDescription;
    private TextBox txtPrice;
    private Label label4;
    private Label label1;
}