using Locadora_2.Abstracts;
using Locadora_2.Enumarators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_2.Models
{
    public class Truck : Vehicle
    {
        private int LoadCapacity { get; set; }
        private int AxlesNumber { get; set; }

        public Truck(string model, string brand, string licencePlate, Kind kind, 
            string color, int year, bool isAvailable, 
            double dailyCost, int load, int axle) : 
            base(model, brand, licencePlate, kind, color, year, isAvailable, dailyCost)
        {
            this.LoadCapacity = load;
            this.AxlesNumber = axle;
        }
    }
}
