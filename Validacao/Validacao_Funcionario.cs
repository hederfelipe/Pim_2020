using Pim_2020.Modelo;
using Pim_2020.Utilidade;
using Pim_2020.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Data;

namespace Pim_2020.Validacao
{
    public class Validacao_Funcionario
    {
        private Utilidade_conexao conexao;
        /// <summary>
        /// Objeto de conexão com banco de dados
        /// </summary>
        /// <param name="cx"></param>
        public Validacao_Funcionario(Utilidade_conexao cx)
        {
            this.conexao = cx;
        }
        /// <summary>
        /// metodo de validação para salvar usuario
        /// </summary>
        /// <param name="usuario"></param>
        public void SalvarFuncionario(Modelo_Funcionario mod_funcionario)
        {
            if (mod_funcionario.Nome1.Trim().Length == 0)
            {
                System.Windows.Forms.MessageBox.Show("O nome do cliente é obrigatório", "Validação usuário", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (mod_funcionario.Cpf1.Trim().Length == 0)
            {
                MessageBox.Show("O CPF do cliente é obrigatório", "Validação CPF", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
             Negocio_Funcionario negocio_funcionario = new Negocio_Funcionario(conexao);
            negocio_funcionario.SalvarFuncionario(mod_funcionario);
        }
        /// <summary>
        /// metodo de validacao para classe ditar
        /// </summary>
        /// <param name="usuario"></param>
       
        public void EditarFuncionario(Modelo_Funcionario mod_funcionario)
        {
            if (mod_funcionario.Codigo1 <= 0)
            {
                MessageBox.Show("O código do acesso é obrigatório", "Validação", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (mod_funcionario.Nome1.Trim().Length == 0)
            {
                MessageBox.Show("O nome do usuário é obrigatório", "Validação cliente", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }

            Negocio_Funcionario negocio_Funcionario = new Negocio_Funcionario(conexao);
            negocio_Funcionario.EditarFuncionario(mod_funcionario);
        }
       
       /// <summary>
       /// metodo de validacao para classe excluir usuario
       /// 
       /// </summary>
       /// <param name="codigo"></param>
       public void ExcluirFuncionario(int Codigo)
       {
           Negocio_Funcionario negocio_funcionario = new Negocio_Funcionario(conexao);
            negocio_funcionario.Excluir_Funcionario(Codigo);
       }

        /// <summary>
        /// Metodo de validacao listar usuario
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        /// 
        
       public DataTable ListarFuncionario(String valor)
       {
           Negocio_Funcionario negocio_Cliente = new Negocio_Funcionario(conexao);
           return negocio_Cliente.ListarFuncionario(valor);
       }




       /// <summary>
       /// metodo de validação de carregar usuarios
       /// </summary>
       /// <param name="codigo"></param>
       /// <returns></returns>
       public Modelo_Funcionario CarregarFuncionario(int codigo)
       {
           Negocio_Funcionario negocio_Cliente = new Negocio_Funcionario(conexao);
           return negocio_Cliente.CarregarFuncionario(codigo);
       }

       public int VerificarFuncionario(string valor)
       {
           Negocio_Funcionario negocio_Funcionario = new Negocio_Funcionario(conexao);
           return negocio_Funcionario.VerficiarFuncionario(valor);
       }
       
    }
}
