using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadora
{
    public class Locacao
    {
        public Cliente Cliente { get; set; }
        public Veiculo Veiculo { get; set; }
        public int Dias {  get; set; }
        public Locacao(Cliente cliente, Veiculo veiculo, int dias)
        {
            Cliente = cliente;
            Veiculo = veiculo;
            Dias = dias;
        }
        public double CalcularValorTotal()
        {
            return Veiculo.PrecoDiaria * Dias;
        }
        public void ExibirDetalhes()
        {
            Console.WriteLine($"Cliente: {Cliente.Nome}");

            Console.WriteLine($"Veículo: {Veiculo.Modelo} - Placa: {Veiculo.Placa}");
            Console.WriteLine($"Dias: {Dias}");
            Console.WriteLine($"Valor total: R${CalcularValorTotal():F2}");
        }
    }
}
