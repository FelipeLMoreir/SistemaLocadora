using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadora
{
    public class Carro : Veiculo
    {
        public int Porta {  get; set; }
        public Carro(string modelo, string placa, double precoDiaria, int portas) : 
            base(modelo, placa, precoDiaria)
        {
            Porta = portas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"[Carro] {Modelo} - {Porta} portas - Placa: {Placa} -" +
                $"R${PrecoDiaria:F2}/dia");
        }
    }
}
