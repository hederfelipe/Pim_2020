using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_2020.Modelo
{
    public class Modelo_Moeda
    {
        public Modelo_Moeda( )
        {
            Codigo1 = 0;
            Nome1 = "";
            Taxa1 = "";
            Tipo1 = "";
            Valor1 = "";
            Tempo1 = DateTime.Now;
            
        }



        private int Codigo;
        private string Nome;
        private string Taxa;
        private string Tipo;
        private string Valor;
        private DateTime Tempo;

        public int Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nome1 { get => Nome; set => Nome = value; }
        public string Taxa1 { get => Taxa; set => Taxa = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Valor1 { get => Valor; set => Valor = value; }
        public DateTime Tempo1 { get => Tempo; set => Tempo = value; }
       
    }


}
