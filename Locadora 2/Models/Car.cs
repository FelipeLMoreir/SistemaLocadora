using Locadora_2.Abstracts;
using Locadora_2.Enumarators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_2.Models
{
    public class Car : Vehicle
    {
        private bool ManualGearBox { get; set; }
        private int NumberOfPassangers { get; set; }
        public Car(string model, string brand, string licencePlate, Kind kind, 
            string color, int year, bool isAvailable, double dailyCost, 
            bool gearBox, int passengers) : 
            base(model, brand, licencePlate, kind, color, year, isAvailable, dailyCost)
        {
            this.ManualGearBox = gearBox;
            this.NumberOfPassangers = passengers;
        }
    }
}
