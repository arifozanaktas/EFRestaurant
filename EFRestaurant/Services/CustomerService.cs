using EFRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EFRestaurant.Services;
public class CustomerService
{
    public List<Customer> GetAll()
    {
        RestaurantContext context = new RestaurantContext();
        List<Customer> customers = context.Customers.OrderBy(x=>x.Id).ToList();
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
    public Customer SelectCustomer(int id)
    {
        RestaurantContext context = new RestaurantContext();
        Customer customer = context.Customers.FirstOrDefault(x=>x.Id==id);
        return customer;

    }
    public Customer DeleteCustomer(int id)
    {
        RestaurantContext db = new RestaurantContext();
        Customer customer = db.Customers.FirstOrDefault(y=>y.Id==id);
        db.Customers.Remove(customer);
        db.SaveChanges();
        return customer;
    }
    public Customer UpdateCustomer(int id,string name, string surname, string phone, string email, string address)
    {
        RestaurantContext ctx = new RestaurantContext();
        Customer customer = new Customer();
        customer.Id = id;
        customer.Name = name;
        customer.Surname = surname;
        customer.Phone = phone;
        customer.Email = email;
        customer.Address = address;

        ctx.Update(customer);
        ctx.SaveChanges();
        return customer;
    }
    public List<Customer> OrderByNameCustomer()
    {
        RestaurantContext db = new RestaurantContext();
        List<Customer> customer = db.Customers.OrderBy(y => y.Name).ToList();
        return customer;
    }
    public List<Customer> OrderBySurnameCustomer()
    {
        RestaurantContext db = new RestaurantContext();
        List<Customer> customer = db.Customers.OrderBy(y => y.Surname).ToList();
        return customer;
    }
    public List<Customer> SearchCustomer(string search) 
    {
        
        RestaurantContext restaurantContext = new RestaurantContext();
        List<Customer> customers = restaurantContext.Customers.Where(x => x.Name.StartsWith(search)).ToList();
        return customers;
    }
}
