using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatRegistrationAndRenting.Models
{
    public class BoatModel
    {
        //Unique Id for boat bound to DB sequence
        long boatId;
        string boatName;
        double hourlyRate;
        bool isAvailable = true;

        public BoatModel(string boatName, double hourlyRate) {
            this.boatName = boatName;
            this.hourlyRate = hourlyRate;
        }

        public string BoatName { get => boatName; set => boatName = value; }
        public long BoatId { get => boatId; set => boatId = value; }
        public double HourlyRate { get => hourlyRate; set => hourlyRate = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }
    }
}
