using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurant.Models;
public class Customer : BaseEntity
{
    [MaxLength(100)]
    public string Name { get; set; }
    [MaxLength(100)]
    public string Surname { get; set; }
    [MaxLength(100)]
    public string? Email { get; set; }
    [MaxLength(13)]
    public string Phone { get; set; }
    [MaxLength(1000)]
    public string? Address { get; set; }
}
