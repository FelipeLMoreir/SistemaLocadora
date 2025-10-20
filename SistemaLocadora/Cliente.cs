using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadora
{
    public class Cliente : Pessoa
    {
        public Cliente(string nome, string cpf) : base(nome, cpf) 
        {

        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Cliente: {Nome} (CPF: {Cpf})");
        }
        public override string ToString()
        {
            return $"{Nome} - CPF: {Cpf}";
        }
    }
}
