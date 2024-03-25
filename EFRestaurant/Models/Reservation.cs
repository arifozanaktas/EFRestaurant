using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurant.Models;
public class Reservation : BaseEntity
{
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public DateTime ReservationDate { get; set; }
    public string? Note { get; set; }

    
}
