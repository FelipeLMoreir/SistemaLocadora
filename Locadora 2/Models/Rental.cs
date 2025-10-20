﻿using Locadora_2.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_2.Models
{
    public class Rental
    {
        private Guid Id { get; set; } = Guid.NewGuid();
        private Person Customer { get; set; }
        private Vehicle Vehicle { get; set; }

        private DateTime RentalDate { get; set; } = DateTime.Now;
        private DateTime? ReturnDate { get; set; } = null;
        private double? TotalPrice { get; set; } = null;

        public Rental(Person customer, Vehicle vehicle)
        {
            this.Customer = customer;
            this.Vehicle = vehicle;
        }
    }
}
