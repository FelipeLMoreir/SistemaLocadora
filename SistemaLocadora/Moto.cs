using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadora
{
    abstract class Moto : Veiculo
    {
        public int Cilindradas { get; set;}
        public Moto(string modelo, string placa, double precoDiaria, int cilindradas) :
            base(modelo, placa, precoDiaria)
        {
            Cilindradas = cilindradas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"[Carro] {Modelo} - {Cilindradas} cilindradas - Placa: {Placa} -" +
                $"R${PrecoDiaria:F2}/dia");
        }
    }
}
