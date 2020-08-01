using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatRegistrationAndRenting.Models
{
    public class CustomerModel
    {
        //Unique Id for customer bound to DB sequence
        long customerId;
        string customerName;
        string phoneNumber;

        public long CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
