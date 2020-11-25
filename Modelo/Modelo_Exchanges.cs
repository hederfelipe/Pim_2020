using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_2020.Modelo
{
    public class Modelo_Exchanges
    {
        public Modelo_Exchanges()
        {
            Codigo1 = 0;
            Nome1 = "";
        }

        private int Codigo;
        private string Nome;

        public int Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nome1 { get => Nome; set => Nome = value; }
    }
}
