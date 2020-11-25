using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pim_2020.Modelo;
using Pim_2020.Utilidade;
using Pim_2020.Negocio;
using System.Data;

namespace Pim_2020.Validacao
{


    public class Validacao_Usuario
    {
        private Utilidade_conexao conexao;
        /// <summary>
        /// Objeto de conexão com banco de dados
        /// </summary>
        /// <param name="cx"></param>
        public Validacao_Usuario(Utilidade_conexao cx)
        {
            this.conexao = cx;
        }
        /// <summary>
        /// metodo de validação para salvar usuario
        /// </summary>
        /// <param name="usuario"></param>
        public void SalvarUsuario(Modelo_Usuario mod_usuario)
        {
            if (mod_usuario.Nome1.Trim().Length == 0)
            {
                MessageBox.Show("O nome do usuário é obrigatório", "Validação usuário", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (mod_usuario.Password1.Trim().Length == 0)
            {
                MessageBox.Show("O password é obrigatório", "Validação Password", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            Negocio_Usuario negocio_Usuario = new Negocio_Usuario(conexao);
            negocio_Usuario.SalvarUsuario(mod_usuario);
        }
        /// <summary>
        /// metodo de validacao para classe ditar
        /// </summary>
        /// <param name="usuario"></param>

        public void EditarUsuario(Modelo_Usuario mod_usuario)
        {
            if (mod_usuario.Codigo1 <= 0)
            {
                MessageBox.Show("O código do acesso é obrigatório", "Validação", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (mod_usuario.Nome1.Trim().Length == 0)
            {
                MessageBox.Show("O nome do usuário é obrigatório", "Validação usuário", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (mod_usuario.Password1.Trim().Length == 0)
            {
                MessageBox.Show("O password é obrigatório", "Validação Password", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            Negocio_Usuario negocio_Usuario = new Negocio_Usuario(conexao);
            negocio_Usuario.EditarUsuario(mod_usuario);
        }

        /// <summary>
        /// metodo de validacao para classe excluir usuario
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        public void ExcluirUsuario(int codigo)
        {
            Negocio_Usuario negocio_Usuario = new Negocio_Usuario(conexao);
            negocio_Usuario.Excluir_Usuario(codigo);
        }

        /// <summary>
        /// Metodo de validacao listar usuario
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        /// 

        public DataTable ListarUsuario(String valor)
        {
            Negocio_Usuario negocio_usuario = new Negocio_Usuario(conexao);
            return negocio_usuario.ListarUsuario(valor);
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
        public Modelo_Usuario CarregarUsuario(int codigo)
        {
            Negocio_Usuario negocio_Usuario = new Negocio_Usuario(conexao);
            return negocio_Usuario.CarregarUsuario(codigo);
        }

        public int VerificarUsuario(string valor)
        {
            Negocio_Usuario negocio_Usuario = new Negocio_Usuario(conexao);
            return negocio_Usuario.VerficiarUsuario(valor);
        }

    }
}
    



