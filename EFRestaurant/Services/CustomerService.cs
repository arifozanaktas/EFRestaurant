using EFRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurant.Services;
public class CustomerService
{
    public List<Customer> GetAll()
    {
        RestaurantContext context = new RestaurantContext();
        List<Customer> customers = context.Customers.ToList();
        return customers;
    }
    public Customer AddCustomer(string name,string surname,string phone,string email,string address)
    {
        RestaurantContext ctx = new RestaurantContext();
        Customer customer = new Customer();
        customer.Name = name;
        customer.Surname = surname;
        customer.Phone = phone;
        customer.Email = email;
        customer.Address = address;
        ctx.Add(customer);
        ctx.SaveChanges();
        return customer;
    }
}
