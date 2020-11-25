using Pim_2020.Modelo;
using Pim_2020.Negocio;
using Pim_2020.Utilidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_2020.Validacao
{
    public class Validacao_Carteira
    {


        private Utilidade_conexao conexao;
        /// <summary>
        /// Objeto de conexão com banco de dados
        /// </summary>
        /// <param name="cx"></param>
        public Validacao_Carteira(Utilidade_conexao cx)
        {
            this.conexao = cx;
        }


        public void SalvarCarteira(Modelo_Conta_Carteira mod_carteira)
        {

            if (mod_carteira.ValorCompra1.ToString().Length == 0)
            {
                MessageBox.Show("O Valor é obrigatório", "Validação ", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (mod_carteira.ValorVenda1.ToString().Length == 0)
            {
                MessageBox.Show("O Valor é obrigatório", "Validação ", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            Negocio_Carteira negocio_Moeda = new Negocio_Carteira(conexao);
            negocio_Moeda.SalvarCarteira(mod_carteira);
        }


        public void EditarCarteira(Modelo_Conta_Carteira mod_carteira)
        {
            if (mod_carteira.Codigo1 <= 0)
            {
                MessageBox.Show("O código do acesso é obrigatório", "Validação", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
         
            if (mod_carteira.ValorVenda1.ToString().Length == 0)
            {
                MessageBox.Show("O Valor é obrigatório", "Validação Saldo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }

            Negocio_Carteira negocio_Usuario = new Negocio_Carteira(conexao);
            negocio_Usuario.SalvarCarteira(mod_carteira);
        }
    }
}
    

