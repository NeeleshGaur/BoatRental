using BoatRegistrationAndRenting.Models;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatRegistrationAndRenting.DAO
{
    public class BoatDAO
    {
        //DueDate to unavailability of DB on machine using this collection to persist data

        Dictionary<long, BoatModel> boatCollection = new Dictionary<long, BoatModel>();

        public BoatModel Get(long id) {
            if (boatCollection.ContainsKey(id))
            {
                return boatCollection[id];
            }
            else {
                return null;
            }
        }

        public long AddBoat(BoatModel boat)
        {
            foreach (KeyValuePair<long, BoatModel> pair in boatCollection)
            {
                if (pair.Value.BoatName == boat.BoatName)
                {
                    throw new Exception("Boat already exists. Kindly choose different name");
                }

            }
            long id = boatCollection.Keys.Max() + 1;
            boat.BoatId = id;
            boatCollection.Add(id, boat);
            return id;
        }

        public void FreeBoat(long id) {
            boatCollection[id].IsAvailable = true;
        }
        public bool DeleteBoat(string boatName)
        {
            foreach (KeyValuePair<long, BoatModel> pair in boatCollection)
            {
                if (pair.Value.BoatName == boatName)
                {
                    boatCollection.Remove(pair.Key);
                    return true;
                }

            }
            return false;
        }
    }
}
