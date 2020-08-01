using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoatRegistrationAndRenting.DAO;
using BoatRegistrationAndRenting.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoatRegistrationAndRenting.Controllers
{
    public class BookingController : Controller
    {
        BookingDAO bookingDAO;
        public BookingController(BookingDAO bookingDao) {
            this.bookingDAO = bookingDao;
        }

        // GET: BookingController/Details/5
        public BookingModel Details(int id)
        {

            return bookingDAO.Get(id);
        }

        
        // POST: BookingController/Create
        [HttpPost]
       public string Create(long boatId, long customerId)
        {
            try
            {
                BookingModel booking = new BookingModel();
                booking.BoatId = boatId;
                booking.CustomerId = customerId;
                booking.StartTime = DateTime.Now;
                return "Booking done with id : " + bookingDAO.Add(booking);

            }
            catch
            {
                return "Booking could not be done";
            }
        }

        
        // POST: BookingController/Edit/5
        [HttpPost]
        [ActionName("Complete")]
        public ActionResult Edit(int id)
        {
            try
            {
                bookingDAO.CompleteBooking(id);
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
