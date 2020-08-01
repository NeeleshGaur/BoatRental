using BoatRegistrationAndRenting.DAO;
using BoatRegistrationAndRenting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatRegistrationAndRenting.Util
{
    public class Utility
    {
        static BoatDAO boatDAO = new BoatDAO();
        public static double CalculateFare(BookingModel booking) {
            BoatModel boat = boatDAO.Get(booking.BoatId);
            if (booking.IsActive) {
                return (DateTime.Now.Hour - booking.StartTime.Hour) * boat.HourlyRate;
            }
            return (booking.EndTime.Hour - booking.StartTime.Hour) * boat.HourlyRate;
        }
    }
}
