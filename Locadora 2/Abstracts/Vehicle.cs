using Locadora_2.Enumarators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_2.Abstracts
{
    public abstract class Vehicle
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Model { get; set; }
        public string Brand { get; set; }
        public string LicencePlate { get; set; }
        public Kind Kind { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; } = true;
        public double DailyCost { get; set; }

        protected Vehicle(string model, string brand, string licencePlate, 
            Kind kind, string color, int year, bool isAvailable, double dailyCost)
        {            
            Model = model;
            Brand = brand;
            LicencePlate = licencePlate;
            Kind = kind;
            Color = color;
            Year = year;
            IsAvailable = isAvailable;
            DailyCost = dailyCost;
        }
    }
}
