using EFRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurant.Services;
public class ReservationService
{
    
    public Reservation AddReservation(int customerId,Customer customer,DateTime date, string note)
    {
        RestaurantContext context = new RestaurantContext();
        Reservation reservation = new Reservation();
        Customer customer1 = context.Customers.FirstOrDefault(x=>x.Id == customerId);
        reservation.Customer= customer1;
        reservation.ReservationDate = date;
        reservation.Note = note;    
        context.Reservations.Add(reservation);
        context.SaveChanges();
        return reservation;
    }
}
