using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_2020.Modelo
{
    public class Modelo_Conta_Carteira
    {
        public Modelo_Conta_Carteira()
        {
            Codigo1 = 0;
            ValorVenda1 = 0;
            ValorCompra1 = 0;
            Lucro1 = 0;
        }

        private int Codigo;
        private double ValorVenda;
        private double ValorCompra;
        private double Lucro;

        public int Codigo1 { get => Codigo; set => Codigo = value; }
        public double ValorVenda1 { get => ValorVenda; set => ValorVenda = value; }
        public double ValorCompra1 { get => ValorCompra; set => ValorCompra = value; }
        public double Lucro1 { get => Lucro; set => Lucro = value; }
    }
}
