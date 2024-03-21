using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurant.Models;
public class Menu : BaseEntity
{
    [MaxLength(100)]
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}
