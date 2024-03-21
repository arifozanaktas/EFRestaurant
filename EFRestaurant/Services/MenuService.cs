using EFRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EFRestaurant.Services;
public class MenuService
{
    public List<Models.Menu> GetAll()
    {
        RestaurantContext context = new RestaurantContext();
        List<Models.Menu> menu = context.Menus.OrderBy(x=>x.Id).ToList();
        return menu;
    }
    public Models.Menu AddMenu(string title,string description,decimal price)
    {
        RestaurantContext restaurantContext = new RestaurantContext();
        Models.Menu menu = new Models.Menu();
        menu.Title = title;
        menu.Description = description;
        menu.Price = price;
        restaurantContext.Menus.Add(menu);
        restaurantContext.SaveChanges();
        return menu;
    }
    public Models.Menu DeleteMenu(int id)
    {
        RestaurantContext restaurantContext= new RestaurantContext();
        Models.Menu menu = restaurantContext.Menus.FirstOrDefault(x => x.Id == id);
        restaurantContext.Menus.Remove(menu);
        restaurantContext.SaveChanges();
        return menu;

    }
    public Models.Menu SelectMenu(int id)
    {
        RestaurantContext restaurantContext = new();
        Models.Menu menu = restaurantContext.Menus.FirstOrDefault(x=>x.Id == id);
        return menu;
    }
    public Models.Menu UpdateMenu (int id,string title, string description,decimal price)
    {
        RestaurantContext context = new RestaurantContext();
        Models.Menu menu = new();
        menu.Id = id;
        menu.Title = title;
        menu.Description = description;
        menu.Price = price;
        context.Menus.Update(menu);
        context.SaveChanges();
        return menu;
    }
    public List<Models.Menu> SearchMenu(string search)
    {

        RestaurantContext restaurantContext = new RestaurantContext();
        List<Models.Menu> menus = restaurantContext.Menus.Where(x => x.Title.StartsWith(search)).ToList();
        return menus;
    }
}
