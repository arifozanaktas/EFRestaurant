using EFRestaurant.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFRestaurant.Forms;
public partial class MenuForm : Form
{
    public MenuForm()
    {
        InitializeComponent();
    }

    private void MenuForm_Load(object sender, EventArgs e)
    {
        FillDg();
    }

    private void FillDg()
    {
        MenuService menuService = new MenuService();
        dgvMenus.DataSource = menuService.GetAll();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        MenuService menuService = new MenuService();
        decimal price = Convert.ToDecimal(txtPrice.Text);
        menuService.AddMenu(txtTitle.Text, txtDescription.Text, price);
        FillDg();
        Cleartxt();
    }

    private void Cleartxt()
    {
        txtTitle.Clear();
        txtDescription.Clear();
        txtPrice.Clear();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        MenuService menuService = new MenuService();
        var selectedMenuId = (int)dgvMenus.CurrentRow.Cells[3].Value;
        menuService.DeleteMenu(selectedMenuId);
        FillDg();
        Cleartxt();
    }

    int selectedMenuId;
    private void dgvMenus_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        selectedMenuId = (int)dgvMenus.CurrentRow.Cells[3].Value;
        MenuService menuService = new();
        var selectedMenu = menuService.SelectMenu(selectedMenuId);
        txtTitle.Text = selectedMenu.Title;
        txtDescription.Text = selectedMenu.Description;
        txtPrice.Text = Convert.ToString(selectedMenu.Price);
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        MenuService menuService = new MenuService();
        menuService.UpdateMenu(selectedMenuId, txtTitle.Text, txtDescription.Text, Convert.ToDecimal(txtPrice.Text));
        FillDg();
        Cleartxt();
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        string search = txtSearch.Text.Trim();
        MenuService MenuService = new();
        dgvMenus.DataSource = MenuService.SearchMenu(search);
        Cleartxt();
    }
}
