using Locadora_2.Abstracts;
using Locadora_2.Enumarators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_2.Models
{
    internal class Motorcycle : Vehicle
    {
        private int EngineCapacity { get; set; }
        private int NumberOfPassengers { get; set; }
        public Motorcycle(string model, string brand, string licencePlate, 
            Kind kind, string color, int year, bool isAvailable, 
            double dailyCost, int engine, int passangers) 
            : base(model, brand, licencePlate, kind, color, year, isAvailable, dailyCost)
        {
            this.EngineCapacity = engine;
            this.NumberOfPassengers = passangers;
        }
    }
}
