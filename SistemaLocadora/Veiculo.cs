using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadora
{
    public abstract class Veiculo
    {
        private string modelo { get; set; }
        private string placa { get; set; }
        private double precoDiaria { get; set; }
        public string Modelo
        {
            get { return modelo;  }
            set { modelo = value; }
        }
        public string Placa
        {
            get { return placa;  }
            set { placa = value; }
        }
        public double PrecoDiaria
        {
            get { return precoDiaria;  }
            set { precoDiaria = value; }
        }

        public Veiculo(string modelo, string placa, double precoDiaria)
        {
            Modelo = modelo;
            Placa = placa;
            PrecoDiaria = precoDiaria;
        }
        public abstract void ExibirInformacoes();

        public override string ToString()
        {
            return $"{Modelo} - Placa: {Placa} - Diária: R${PrecoDiaria:F2}";
        }
    }
}
