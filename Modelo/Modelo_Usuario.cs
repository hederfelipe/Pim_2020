using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_2020.Modelo
{
    public class Modelo_Usuario  
    {

        private int Codigo;
        private string Cpf;
        private string Nome;
        private DateTime DataNascimento;
        private string Sexo;
        private string Telefone;
        private string Email;
        private string Rua;
        private string Cidade;
        private string Estado;
        private string CEP;
        private string Bairro;
        private string Complemento;
        private string Password;
        public Modelo_Usuario()
        {
            Codigo1 = 0;
            Cpf1 = "";
            Nome1 = "";
            DataNascimento1 = DateTime.Now;
            Sexo1 = "";
            Telefone1 = "";
            Email1 = "";
            Rua1 = "";
            CEP1 = "";
            Bairro1 = "";
            Cidade1 = "";
            Estado1 = "";
            Complemento1 = "";
            Password1 = "";
        }



       

        public int Codigo1 { get => Codigo; set => Codigo = value; }
        public string Cpf1 { get => Cpf; set => Cpf = value; }
        public string Nome1 { get => Nome; set => Nome = value; }
        public DateTime DataNascimento1 { get => DataNascimento; set => DataNascimento = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public string Telefone1 { get => Telefone; set => Telefone = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Rua1 { get => Rua; set => Rua = value; }
        public string Cidade1 { get => Cidade; set => Cidade = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public string CEP1 { get => CEP; set => CEP = value; }
        public string Bairro1 { get => Bairro; set => Bairro = value; }
        public string Complemento1 { get => Complemento; set => Complemento = value; }
        public string Password1 { get => Password; set => Password = value; }
    }
}
