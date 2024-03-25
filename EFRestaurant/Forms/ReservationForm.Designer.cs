namespace EFRestaurant.Forms;

partial class ReservationForm
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
        groupBox1 = new GroupBox();
        dgvReservation = new DataGridView();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnAdd = new Button();
        txtNote = new TextBox();
        dtpReservation = new DateTimePicker();
        label2 = new Label();
        label3 = new Label();
        label1 = new Label();
        cmbCustomer = new ComboBox();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvReservation).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(dgvReservation);
        groupBox1.Controls.Add(btnUpdate);
        groupBox1.Controls.Add(btnDelete);
        groupBox1.Controls.Add(btnAdd);
        groupBox1.Controls.Add(txtNote);
        groupBox1.Controls.Add(dtpReservation);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(cmbCustomer);
        groupBox1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
        groupBox1.Location = new Point(40, 43);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1436, 903);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Reservation Create";
        // 
        // dgvReservation
        // 
        dgvReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvReservation.Location = new Point(20, 540);
        dgvReservation.Name = "dgvReservation";
        dgvReservation.RowHeadersWidth = 82;
        dgvReservation.Size = new Size(1410, 357);
        dgvReservation.TabIndex = 5;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(471, 439);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(299, 75);
        btnUpdate.TabIndex = 4;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(796, 439);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(299, 75);
        btnDelete.TabIndex = 4;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(1131, 439);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(299, 75);
        btnAdd.TabIndex = 4;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // txtNote
        // 
        txtNote.Location = new Point(471, 347);
        txtNote.Name = "txtNote";
        txtNote.Size = new Size(959, 65);
        txtNote.TabIndex = 3;
        // 
        // dtpReservation
        // 
        dtpReservation.Location = new Point(471, 228);
        dtpReservation.Name = "dtpReservation";
        dtpReservation.Size = new Size(959, 65);
        dtpReservation.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(36, 228);
        label2.Name = "label2";
        label2.Size = new Size(369, 59);
        label2.TabIndex = 1;
        label2.Text = "Reservation Date";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(36, 353);
        label3.Name = "label3";
        label3.Size = new Size(141, 59);
        label3.TabIndex = 1;
        label3.Text = "Notes";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(36, 99);
        label1.Name = "label1";
        label1.Size = new Size(216, 59);
        label1.TabIndex = 1;
        label1.Text = "Customer";
        // 
        // cmbCustomer
        // 
        cmbCustomer.FormattingEnabled = true;
        cmbCustomer.Location = new Point(471, 96);
        cmbCustomer.Name = "cmbCustomer";
        cmbCustomer.Size = new Size(959, 67);
        cmbCustomer.TabIndex = 0;
        // 
        // ReservationForm
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1500, 968);
        Controls.Add(groupBox1);
        Name = "ReservationForm";
        Text = "ReservationForm";
        Load += ReservationForm_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvReservation).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Button btnUpdate;
    private Button btnDelete;
    private Button btnAdd;
    private TextBox txtNote;
    private DateTimePicker dtpReservation;
    private Label label2;
    private Label label3;
    private Label label1;
    private ComboBox cmbCustomer;
    private DataGridView dgvReservation;
}