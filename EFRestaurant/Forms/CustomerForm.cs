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
}
