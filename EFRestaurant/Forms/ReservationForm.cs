using EFRestaurant.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EFRestaurant.Forms;
public partial class ReservationForm : Form
{
    public ReservationForm()
    {
        InitializeComponent();
    }

    private void ReservationForm_Load(object sender, EventArgs e)
    {
        FillAll();

    }

    private void FillAll()
    {
        RestaurantContext context = new RestaurantContext();
        List<Customer> customers = context.Customers.ToList();
        cmbCustomer.DisplayMember = "Name" + " " + "Surname";
        cmbCustomer.ValueMember = "Value";
        cmbCustomer.DataSource = customers;

        List<Reservation> reservations = context.Reservations.ToList();
        dgvReservation.DataSource = reservations;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        ReservationService service = new ReservationService();
        var selectedCustomer = cmbCustomer.SelectedIndex;
        RestaurantContext context = new RestaurantContext();
        Customer customer = context.Customers.FirstOrDefault(x => x.Id == selectedCustomer);
        service.AddReservation(selectedCustomer,customer, Convert.ToDateTime(dtpReservation.Text), txtNote.Text);
        FillAll();
    }
}
