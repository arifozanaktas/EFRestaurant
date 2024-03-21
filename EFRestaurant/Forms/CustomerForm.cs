using EFRestaurant.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFRestaurant.Forms;
public partial class CustomerForm : Form
{
    public CustomerForm()
    {
        InitializeComponent();
    }

    private void CustomerForm_Load(object sender, EventArgs e)
    {
        FillDgv();
    }

    private void FillDgv()
    {
        CustomerService customerService = new CustomerService();
        dgvCustomers.DataSource = customerService.GetAll();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        CustomerService customerService = new CustomerService();
        customerService.AddCustomer(txtName.Text, txtSurname.Text, txtPhone.Text, txtEmail.Text, txtAddress.Text);
        FillDgv();
        ClearTextBoxes();

    }

    private void ClearTextBoxes()
    {
        txtName.Clear();
        txtSurname.Clear();
        txtPhone.Clear();
        txtEmail.Clear();
        txtAddress.Clear();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {

        CustomerService customer = new CustomerService();
        customer.UpdateCustomer(selectedCustomerId, txtName.Text, txtSurname.Text, txtPhone.Text, txtEmail.Text, txtAddress.Text);
        FillDgv();
        ClearTextBoxes();

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        int selectedId = (int)dgvCustomers.CurrentRow.Cells[5].Value;
        CustomerService customerService = new CustomerService();
        customerService.DeleteCustomer(selectedId);
        FillDgv();
        ClearTextBoxes();
    }
    int selectedCustomerId;
    private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        selectedCustomerId = (int)dgvCustomers.CurrentRow.Cells[5].Value;
        CustomerService customerService = new CustomerService();
        var editCustomer = customerService.SelectCustomer(selectedCustomerId);
        txtName.Text = editCustomer.Name;
        txtSurname.Text = editCustomer.Surname;
        txtPhone.Text = editCustomer.Phone;
        txtEmail.Text = editCustomer.Email;
        txtAddress.Text = editCustomer.Address;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        CustomerService customerService = new CustomerService();
        dgvCustomers.DataSource = customerService.OrderByNameCustomer();
        ClearTextBoxes();
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
        CustomerService customerService = new CustomerService();
        dgvCustomers.DataSource = customerService.OrderBySurnameCustomer();
        ClearTextBoxes();
    }

    private void txtSearchName_TextChanged(object sender, EventArgs e)
    {
        string search = txtSearch.Text.Trim();
        CustomerService customerService = new();
        dgvCustomers.DataSource = customerService.SearchCustomer(search);
        ClearTextBoxes();

    }
}
