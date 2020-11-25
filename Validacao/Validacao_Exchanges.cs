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
    public class Validacao_Exchanges
    {
      
            private Utilidade_conexao conexao;
            /// <summary>
            /// Objeto de conexão com banco de dados
            /// </summary>
            /// <param name="cx"></param>
            public Validacao_Exchanges(Utilidade_conexao cx)
            {
                this.conexao = cx;
            }
            /// <summary>
            /// metodo de validação para salvar usuario
            /// </summary>
            /// <param name="usuario"></param>
            public void Salvarexchanges(Modelo_Exchanges mod_exchanges)
            {
                if (mod_exchanges.Nome1.Trim().Length == 0)
                {
                    MessageBox.Show("O nome do usuário é obrigatório", "Validação usuário", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }


                Negocio_Exchanges negocio_Usuario = new Negocio_Exchanges(conexao);
                negocio_Usuario.SalvarExchanges(mod_exchanges);
            }
            /// <summary>
            /// metodo de validacao para classe ditar
            /// </summary>
            /// <param name="usuario"></param>

            public void EditarExchanges(Modelo_Exchanges mod_exchanges)
            {
                if (mod_exchanges.Codigo1 <= 0)
                {
                    MessageBox.Show("O código do acesso é obrigatório", "Validação", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                if (mod_exchanges.Nome1.Trim().Length == 0)
                {
                    MessageBox.Show("O nome do usuário é obrigatório", "Validação usuário", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }

                Negocio_Exchanges n = new Negocio_Exchanges(conexao);
                n.EditarExchanges(mod_exchanges);
            }

            /// <summary>
            /// metodo de validacao para classe excluir usuario
            /// 
            /// </summary>
            /// <param name="codigo"></param>
            public void ExcluirExchanges(string codigo)
            {
                Negocio_Exchanges negocio_Usuario = new Negocio_Exchanges(conexao);
                negocio_Usuario.ExcluirExchanges(codigo);
            }

            /// <summary>
            /// Metodo de validacao listar usuario
            /// </summary>
            /// <param name="valor"></param>
            /// <returns></returns>
            /// 

            public DataTable ListarExchanges(String valor)
            {
                Negocio_Exchanges n = new Negocio_Exchanges(conexao);
                return n.ListarExchangers(valor);
            }



            /*public DataTable ListarUsuario()
             {
                 negocio_Usuario negocio_Usuario = new negocio_Usuario(conexao);
                 try
                 {
                     DataTable dt = new DataTable();
                     dt = negocio_Usuario.ListarUsuario();
                     return dt;
                 }
                 catch (Exception erro)
                 {
                     throw erro;
                 }
             }*/

            /// <summary>
            /// metodo de validação de carregar usuarios
            /// </summary>
            /// <param name="codigo"></param>
            /// <returns></returns>ga
            public Modelo_Exchanges CarregarExchanges(int codigo)
            {
            Negocio_Exchanges negocio_Usuario = new Negocio_Exchanges(conexao);
            return negocio_Usuario.CarregarExchanges(codigo);
            }

        public int VerificarExchanges(string valor)
        {
            Negocio_Exchanges n = new Negocio_Exchanges(conexao);
            return n.VerficiarUsuario(valor);
        }
            

        
    }
}
