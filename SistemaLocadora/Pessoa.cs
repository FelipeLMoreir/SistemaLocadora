using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadora
{
    abstract class Pessoa
    {
        private string nome;
        private string cpf;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
        public abstract void ExibirInformacoes();
    }
}
