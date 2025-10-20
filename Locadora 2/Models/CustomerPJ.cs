using Locadora_2.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_2.Models
{
    public class CustomerPJ : Person
    {
        private Guid Id { get; set; } = Guid.NewGuid();
        private string CNPJ { get; set; }
        public CustomerPJ(string name, DateOnly bithDate, Contact contact, 
            Address address, string cnpj) : base(name, bithDate, contact, address)
        {
            this.CNPJ = cnpj;
        }
        public override string ToString()
        {
            return $"{this.Id}\n{base.ToString()}\nCNPJ: {this.CNPJ}";
        }
    }
}
