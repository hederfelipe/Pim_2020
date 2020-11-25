using Pim_2020.Modelo;
using Pim_2020.Negocio;
using Pim_2020.Utilidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_2020.Validacao
{
    public class Validacao_Moeda
    {


        private Utilidade_conexao conexao;
        /// <summary>
        /// Objeto de conexão com banco de dados
        /// </summary>
        /// <param name="cx"></param>
        public Validacao_Moeda(Utilidade_conexao cx)
        {
            this.conexao = cx;
        }

       

        /// <summary>
        /// metodo de validação para salvar usuario
        /// </summary>
        /// <param name="usuario"></param>
        public void SalvarMoeda(Modelo_Moeda mod_Moeda)
        {
            if (mod_Moeda.Nome1.Trim().Length == 0)
            {
                MessageBox.Show("O nome do usuário é obrigatório", "Validação usuário", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (mod_Moeda.Valor1.Trim().Length == 0)
            {
                MessageBox.Show("O password é obrigatório", "Validação Password", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            Negocio_Moeda negocio_Moeda = new Negocio_Moeda(conexao);
            negocio_Moeda.SalvarMoeda(mod_Moeda);
        }
        /// <summary>
        /// metodo de validacao para classe ditar
        /// </summary>
        /// <param name="usuario"></param>

        public void EditarMoeda(Modelo_Moeda mod_moeda)
        {
            if (mod_moeda.Codigo1 <= 0)
            {
                MessageBox.Show("O código do acesso é obrigatório", "Validação", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (mod_moeda.Nome1.Trim().Length == 0)
            {
                MessageBox.Show("O nome do usuário é obrigatório", "Validação usuário", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (mod_moeda.Valor1.Trim().Length == 0)
            {
                MessageBox.Show("O password é obrigatório", "Validação Password", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            Negocio_Moeda negocio_Usuario = new Negocio_Moeda(conexao);
            negocio_Usuario.EditarMoeda(mod_moeda);
        }

        /// <summary>
        /// metodo de validacao para classe excluir usuario
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        public void ExcluirMoeda(string codigo)
        {
            Negocio_Moeda negocio_Moeda = new Negocio_Moeda(conexao);
            negocio_Moeda.ExcluirMoeda(codigo);
        }

        /// <summary>
        /// Metodo de validacao listar usuario
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        /// 

        public DataTable ListarMoeda(String valor)
        {
            Negocio_Moeda negocio_moeda = new Negocio_Moeda(conexao);
            return negocio_moeda.ListarMoeda(valor);
        }



    

        /// <summary>
        /// metodo de validação de carregar usuarios
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>ga
        public Modelo_Moeda CarregarMoeda(int codigo)
        {
            Negocio_Moeda negocio_Moeda = new Negocio_Moeda(conexao);
            return negocio_Moeda.CarregaMoeda(codigo);
        }

        public int VerificarMoeda(string valor)
        {
            Negocio_Moeda negocio_Moeda = new Negocio_Moeda(conexao);
            return negocio_Moeda.VerficiarMoeda(valor);
        }

    }
   
}
