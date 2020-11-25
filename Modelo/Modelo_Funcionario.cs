using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_2020.Modelo
{
   public  class Modelo_Funcionario
    {


        private int Codigo;
        private string Nome;
        private string Cpf;
        private string Email;
        private string Sexo;
        private string Cargo;
        private int nr_Filhos;
        private string Telefone;
        private string Salario;
        private DateTime DataNascimento;
        private string Rua;
        private string Cidade;
        private string Estado;
        private string CEP;
        private string Bairro;
        private string Complemento;
        private string Password;

        public Modelo_Funcionario()
        {
            Codigo = 0;
            Nome = "";
            Cpf = "";
            Email = "";
            Sexo = "";
            Cargo = "";
            this.nr_Filhos = 0;
            Telefone = "";
            Salario = "";
            DataNascimento = DateTime.Now;
            Rua = "";
            Cidade = "";
            Estado = "";
            CEP = "";
            Bairro = "";
            Complemento = "";
            Password = "";
        }

        public int Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nome1 { get => Nome; set => Nome = value; }
        public string Cpf1 { get => Cpf; set => Cpf = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public string Cargo1 { get => Cargo; set => Cargo = value; }
        public int Nr_Filhos { get => nr_Filhos; set => nr_Filhos = value; }
        public string Telefone1 { get => Telefone; set => Telefone = value; }
        public string Salario1 { get => Salario; set => Salario = value; }
        public DateTime DataNascimento1 { get => DataNascimento; set => DataNascimento = value; }
        public string Rua1 { get => Rua; set => Rua = value; }
        public string Cidade1 { get => Cidade; set => Cidade = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public string CEP1 { get => CEP; set => CEP = value; }
        public string Bairro1 { get => Bairro; set => Bairro = value; }
        public string Complemento1 { get => Complemento; set => Complemento = value; }
        public string Password1 { get => Password; set => Password = value; }
    }
}

