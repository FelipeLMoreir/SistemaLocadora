using Locadora_2.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_2.Models
{
    public class CustomerPF : Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CNH { get; set; }
        public string CPF { get; set; }

        public CustomerPF(
            string name, 
            DateOnly bithDate, 
            Contact contact, 
            Address address, 
            string cnh, 
            string cpf
            ) 
            : base(name, bithDate, contact, address)
        {
            this.CNH = cnh;
            this.CPF = cpf;
        }

        public override string ToString()
        {
            return $"{this.Id}\n{base.ToString()}\nCNH: {this.CNH}\nCPF: {this.CPF}";
        }
    }
}
