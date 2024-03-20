﻿namespace EFRestaurant.Forms;

partial class CustomerForm
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
        label1 = new Label();
        label2 = new Label();
        txtName = new TextBox();
        label3 = new Label();
        txtSurname = new TextBox();
        label4 = new Label();
        txtEmail = new TextBox();
        label5 = new Label();
        txtPhone = new TextBox();
        label6 = new Label();
        txtAddress = new TextBox();
        groupBox1 = new GroupBox();
        btnAdd = new Button();
        dgvCustomers = new DataGridView();
        groupBox2 = new GroupBox();
        btnEdit = new Button();
        btnDelete = new Button();
        label8 = new Label();
        label7 = new Label();
        txtSearchSurname = new TextBox();
        txtSearchName = new TextBox();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
        label1.ForeColor = SystemColors.ControlText;
        label1.ImageAlign = ContentAlignment.TopCenter;
        label1.Location = new Point(535, 37);
        label1.Name = "label1";
        label1.Size = new Size(608, 71);
        label1.TabIndex = 0;
        label1.Text = "Customer Management";
        label1.TextAlign = ContentAlignment.TopCenter;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(67, 89);
        label2.Name = "label2";
        label2.Size = new Size(85, 32);
        label2.TabIndex = 1;
        label2.Text = "Name";
        // 
        // txtName
        // 
        txtName.Location = new Point(193, 86);
        txtName.Name = "txtName";
        txtName.Size = new Size(200, 39);
        txtName.TabIndex = 2;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(67, 211);
        label3.Name = "label3";
        label3.Size = new Size(119, 32);
        label3.TabIndex = 1;
        label3.Text = "Surname";
        // 
        // txtSurname
        // 
        txtSurname.Location = new Point(193, 208);
        txtSurname.Name = "txtSurname";
        txtSurname.Size = new Size(200, 39);
        txtSurname.TabIndex = 2;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(67, 328);
        label4.Name = "label4";
        label4.Size = new Size(79, 32);
        label4.TabIndex = 1;
        label4.Text = "Email";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(193, 325);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(200, 39);
        txtEmail.TabIndex = 2;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(67, 449);
        label5.Name = "label5";
        label5.Size = new Size(87, 32);
        label5.TabIndex = 1;
        label5.Text = "Phone";
        // 
        // txtPhone
        // 
        txtPhone.Location = new Point(193, 446);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(200, 39);
        txtPhone.TabIndex = 2;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(67, 579);
        label6.Name = "label6";
        label6.Size = new Size(107, 32);
        label6.TabIndex = 1;
        label6.Text = "Address";
        // 
        // txtAddress
        // 
        txtAddress.Location = new Point(193, 576);
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(200, 39);
        txtAddress.TabIndex = 2;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnAdd);
        groupBox1.Controls.Add(txtAddress);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(txtName);
        groupBox1.Controls.Add(txtPhone);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(txtSurname);
        groupBox1.Controls.Add(txtEmail);
        groupBox1.Controls.Add(label4);
        groupBox1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
        groupBox1.Location = new Point(25, 138);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(447, 794);
        groupBox1.TabIndex = 3;
        groupBox1.TabStop = false;
        groupBox1.Text = "New Customer";
        // 
        // btnAdd
        // 
        btnAdd.BackColor = SystemColors.ActiveCaption;
        btnAdd.Location = new Point(67, 708);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(326, 46);
        btnAdd.TabIndex = 3;
        btnAdd.Text = "Add New Customer";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // dgvCustomers
        // 
        dgvCustomers.BackgroundColor = SystemColors.ActiveCaption;
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCustomers.Location = new Point(14, 38);
        dgvCustomers.Name = "dgvCustomers";
        dgvCustomers.RowHeadersWidth = 82;
        dgvCustomers.Size = new Size(1296, 577);
        dgvCustomers.TabIndex = 4;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btnEdit);
        groupBox2.Controls.Add(btnDelete);
        groupBox2.Controls.Add(dgvCustomers);
        groupBox2.Controls.Add(label8);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(txtSearchSurname);
        groupBox2.Controls.Add(txtSearchName);
        groupBox2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
        groupBox2.Location = new Point(496, 138);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(1316, 794);
        groupBox2.TabIndex = 5;
        groupBox2.TabStop = false;
        groupBox2.Text = "Customer List";
        // 
        // btnEdit
        // 
        btnEdit.BackColor = SystemColors.ActiveCaption;
        btnEdit.Location = new Point(984, 646);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(326, 46);
        btnEdit.TabIndex = 3;
        btnEdit.Text = "Edit Customer";
        btnEdit.UseVisualStyleBackColor = false;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.IndianRed;
        btnDelete.Location = new Point(984, 708);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(326, 46);
        btnDelete.TabIndex = 3;
        btnDelete.Text = "Delete Customer";
        btnDelete.UseVisualStyleBackColor = false;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(24, 715);
        label8.Name = "label8";
        label8.Size = new Size(242, 32);
        label8.TabIndex = 1;
        label8.Text = "Search By Surname";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(24, 656);
        label7.Name = "label7";
        label7.Size = new Size(208, 32);
        label7.TabIndex = 1;
        label7.Text = "Search By Name";
        // 
        // txtSearchSurname
        // 
        txtSearchSurname.Location = new Point(272, 715);
        txtSearchSurname.Name = "txtSearchSurname";
        txtSearchSurname.Size = new Size(200, 39);
        txtSearchSurname.TabIndex = 2;
        // 
        // txtSearchName
        // 
        txtSearchName.Location = new Point(272, 656);
        txtSearchName.Name = "txtSearchName";
        txtSearchName.Size = new Size(200, 39);
        txtSearchName.TabIndex = 2;
        // 
        // CustomerForm
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1824, 944);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        Name = "CustomerForm";
        Text = "CustomerForm";
        Load += CustomerForm_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox txtName;
    private Label label3;
    private TextBox txtSurname;
    private Label label4;
    private TextBox txtEmail;
    private Label label5;
    private TextBox txtPhone;
    private Label label6;
    private TextBox txtAddress;
    private GroupBox groupBox1;
    private Button btnAdd;
    private DataGridView dgvCustomers;
    private GroupBox groupBox2;
    private Button btnEdit;
    private Button btnDelete;
    private Label label8;
    private Label label7;
    private TextBox txtSearchSurname;
    private TextBox txtSearchName;
}