using BoatRegistrationAndRenting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatRegistrationAndRenting.DAO
{
    public class BookingDAO
    {
        //DueDate to unavailability of DB on machine using this collection to persist data

        Dictionary<long, BookingModel> bookingCollection = new Dictionary<long, BookingModel>();
        BoatDAO dao = new BoatDAO();

        public BookingModel Get(long id) {
            return bookingCollection[id];
        }
        public long Add(BookingModel booking)
        {
            
            BoatModel boat = dao.Get(booking.BoatId);
            if (boat == null)
            {
                throw new Exception("No such boat exists for booking");
            }
            else if (!boat.IsAvailable)
            {
                throw new Exception("Boat already booked");
            }

            long id = bookingCollection.Keys.Max() + 1;
            booking.BookingId= id;
            bookingCollection[id].StartTime = DateTime.Now;
            bookingCollection.Add(id, booking);
            return id;
        }

        public bool CompleteBooking(long id)
        {
            
            if (bookingCollection.ContainsKey(id)) {
                BookingModel booking = bookingCollection[id];
                booking.IsActive = false;
                booking.EndTime = DateTime.Now;
                dao.FreeBoat(booking.BoatId);
                return true;
            }
            else
                return false;
        }
    }
}
