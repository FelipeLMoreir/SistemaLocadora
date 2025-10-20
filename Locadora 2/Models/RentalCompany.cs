using Locadora_2.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_2.Models
{
    public class RentalCompany
    {
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public List<Person> Customers { get; set; } = new List<Person>();
        public List<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
