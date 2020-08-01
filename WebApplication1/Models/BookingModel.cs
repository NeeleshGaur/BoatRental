using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatRegistrationAndRenting.Models
{
    public class BookingModel
    {
        //Unique Id for booking bound to DB sequence
        long bookingId;
        long boatId;
        long customerId;
        DateTime startTime;
        DateTime endTime;
        bool isActive = true;

        public long BookingId { get => bookingId; set => bookingId = value; }
        public long BoatId { get => boatId; set => boatId = value; }
        public long CustomerId { get => customerId; set => customerId = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
    }
}
