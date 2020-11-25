using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_2020.Validacao
{
     public  class Valida_Usuario
    {
        private Utilidade_Conexao conexao;
        /// <summary>
        /// Objeto de conexão com banco de dados
        /// </summary>
        /// <param name="cx"></param>
        public validacao_Usuario(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }
        /// <summary>
        /// metodo de validação para salvar usuario
        /// </summary>
        /// <param name="usuario"></param>
        public void SalvarUsuario(modelo_Usuario mod_usuario)
        {
            if (mod_usuario.User_usuario.Trim().Length == 0)
            {
                MessageBox.Show("O nome do usuário é obrigatório", "Validação usuário", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (mod_usuario.User_password.Trim().Length == 0)
            {
                MessageBox.Show("O password é obrigatório", "Validação Password", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            negocio_Usuario negocio_Usuario = new negocio_Usuario(conexao);
            negocio_Usuario.SalvarUsuario(mod_usuario);
        }
        /// <summary>
        /// metodo de validacao para classe ditar
        /// </summary>
        /// <param name="usuario"></param>

        public void EditarUsuario(modelo_Usuario mod_usuario)
        {
            if (mod_usuario.User_id <= 0)
            {
                MessageBox.Show("O código do acesso é obrigatório", "Validação", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (mod_usuario.User_usuario.Trim().Length == 0)
            {
                MessageBox.Show("O nome do usuário é obrigatório", "Validação usuário", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (mod_usuario.User_password.Trim().Length == 0)
            {
                MessageBox.Show("O password é obrigatório", "Validação Password", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            negocio_Usuario negocio_Usuario = new negocio_Usuario(conexao);
            negocio_Usuario.EditarUsuario(mod_usuario);
        }

        /// <summary>
        /// metodo de validacao para classe excluir usuario
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        public void ExcluirUsuario(int codigo)
        {
            negocio_Usuario negocio_Usuario = new negocio_Usuario(conexao);
            negocio_Usuario.ExcluirUsuario(codigo);
        }

        /// <summary>
        /// Metodo de validacao listar usuario
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        /// 

        public DataTable ListarUsuario(String valor)
        {
            negocio_Usuario negocio_usuario = new negocio_Usuario(conexao);
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
        /// <returns></returns>
        public modelo_Usuario CarregarUsuario(int codigo)
        {
            negocio_Usuario negocio_Usuario = new negocio_Usuario(conexao);
            return negocio_Usuario.CarregarUsuario(codigo);
        }

        public int VerificarUsuario(string valor)
        {
            negocio_Usuario negocio_Usuario = new negocio_Usuario(conexao);
            return negocio_Usuario.VerficiarUsuario(valor);
        }

    }
}
