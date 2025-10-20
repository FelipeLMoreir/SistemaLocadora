using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadora
{
    abstract class Caminhao : Veiculo
    {
        public double CapacidadeCarga {  get; set; }
        public Caminhao(string modelo, string placa, double precoDiaria,
            double CapcCarga) :
            base(modelo, placa, precoDiaria)
        {
            CapacidadeCarga = CapcCarga;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"[Carro] {Modelo} - {CapacidadeCarga} toneladas" +
                $" - Placa: {Placa} -" +
                $"R${PrecoDiaria:F2}/dia");
        }
    }
}
