using BoatRegistrationAndRenting.Models;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatRegistrationAndRenting.DAO
{
    public class CustomerDAO
    {
        //DueDate to unavailability of DB on machine using this collection to persist data

        Dictionary<long, CustomerModel> customerCollection = new Dictionary<long, CustomerModel>();

        public CustomerModel Get(long id)
        {
            if (customerCollection.ContainsKey(id))
            {
                return customerCollection[id];
            }
            else
            {
                return null;
            }
        }
        public long Add(CustomerModel cust)
        {
            foreach (KeyValuePair<long, CustomerModel> pair in customerCollection)
            {
                if (pair.Value.CustomerName == cust.CustomerName)
                {
                    throw new Exception("Customer already exists. Kindly choose different name");
                }

            }
            long id = customerCollection.Keys.Max() + 1;
            cust.CustomerId = id;
            customerCollection.Add(id, cust);
            return id;
        }

        
    }
}
