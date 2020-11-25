using Pim_2020.Modelo;
using Pim_2020.Utilidade;
using Pim_2020.Validacao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_2020.Negocio
{
    public class Negocio_Usuario
    {
        public Utilidade_conexao conexao;
        SqlCommand comando = null;


        public Negocio_Usuario(Utilidade_conexao cx)
        {
            this.conexao = cx;
        }
        /// <summary>
        /// metodo para gravar os clientes no BD
        /// </summary>
        /// <param name="mod_usuario"></param>
        public void SalvarUsuario(Modelo_Usuario modelo_Usuario)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO Usuario  ( , Nome ,Cpf, Email, Sexo , Telefone , DataNascimento, Rua, Cidade, Estado ,CEP,Bairro,Complemento,Password) " +
                "VALUES ( @Nome , @Cpf, @Email,  @Sexo  ,  @Telefone ,  @DataNascimento,  @Rua,  @Cidade,  @Estado , @CEP, @Bairro,@Complemento,@Password) ; SELECT @@Identity";
                cmd.Parameters.AddWithValue("Nome", modelo_Usuario.Nome1);
                cmd.Parameters.AddWithValue("Cpf", modelo_Usuario.Cpf1);
                cmd.Parameters.AddWithValue("Email", modelo_Usuario.Email1);
                cmd.Parameters.AddWithValue("Telefone", modelo_Usuario.Telefone1);
                cmd.Parameters.AddWithValue("DataNascimento", modelo_Usuario.DataNascimento1);
                cmd.Parameters.AddWithValue("Sexo", modelo_Usuario.Sexo1);
                cmd.Parameters.AddWithValue("Rua", modelo_Usuario.Rua1);
                cmd.Parameters.AddWithValue("Cidade", modelo_Usuario.Cidade1);
                cmd.Parameters.AddWithValue("Estado", modelo_Usuario.Estado1);
                cmd.Parameters.AddWithValue("CEP", modelo_Usuario.CEP1);
                cmd.Parameters.AddWithValue("Bairro", modelo_Usuario.Bairro1);
                cmd.Parameters.AddWithValue("Complemento", modelo_Usuario.Complemento1);
                cmd.Parameters.AddWithValue("Password", modelo_Usuario.Password1);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", " Gravar" + ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }


        //metodo para editar o cliente 

        public void EditarUsuario(Modelo_Usuario modelo_Usuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;               
                cmd.CommandText = "UPDATE Usuario SET Nome = @Nome ,Cpf = @Cpf, Email = @Email, Sexo = @Sexo ,  Telefone = @Telefone ,DataNascimento = @DataNascimento, Rua = @Rua, Cidade = @Cidade, Estado = @Estado, CEP = @CEP ,Bairro = @Bairro,Complemento = @Complemento,Password = @Password WHERE Codigo = @Codigo";
                cmd.Parameters.AddWithValue("Codigo", modelo_Usuario.Codigo1);
                cmd.Parameters.AddWithValue("Nome", modelo_Usuario.Nome1);
                cmd.Parameters.AddWithValue("Cpf", modelo_Usuario.Cpf1);
                cmd.Parameters.AddWithValue("Email", modelo_Usuario.Email1);
                cmd.Parameters.AddWithValue("Sexo", modelo_Usuario.Sexo1);
                cmd.Parameters.AddWithValue("Telefone", modelo_Usuario.Telefone1);
                cmd.Parameters.AddWithValue("DataNascimento", modelo_Usuario.DataNascimento1);
                cmd.Parameters.AddWithValue("Rua", modelo_Usuario.Rua1);
                cmd.Parameters.AddWithValue("Cidade", modelo_Usuario.Cidade1);
                cmd.Parameters.AddWithValue("Estado", modelo_Usuario.Estado1);
                cmd.Parameters.AddWithValue("CEP", modelo_Usuario.CEP1);
                cmd.Parameters.AddWithValue("Bairro", modelo_Usuario.Bairro1);
                cmd.Parameters.AddWithValue("Complemento", modelo_Usuario.Complemento1);
                cmd.Parameters.AddWithValue("Password", modelo_Usuario.Password1);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Editar" + ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        //metodo para excluir usuario
        public void Excluir_Usuario(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM Usuario WHERE Codigo = @Codigo";
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Excluir" + ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        //metodo para listar cliente

        public DataTable ListarUsuario(string valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Usuario WHERE Nome like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //metodo para carregar clientes no grid
        public Modelo_Usuario CarregarUsuario(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                Modelo_Usuario usuario = new Modelo_Usuario();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM Usuario WHERE Codigo = @Codigo;";
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    usuario.Codigo1 = Convert.ToInt32(registro["Codigo"]);
                    usuario.Nome1 = Convert.ToString(registro["Nome"]);
                    usuario.Cpf1 = Convert.ToString(registro["Cpf"]);
                    usuario.Email1 = Convert.ToString(registro["Email"]);
                    usuario.Sexo1 = Convert.ToString(registro["Sexo"]);
                    usuario.Telefone1 = Convert.ToString(registro["Telefone"]);
                    usuario.DataNascimento1 = Convert.ToDateTime(registro["DataNascimento"]);
                    usuario.Rua1 = Convert.ToString(registro["Rua"]);
                    usuario.Cidade1 = Convert.ToString(registro["Cidade"]);
                    usuario.Estado1 = Convert.ToString(registro["Estado"]);
                    usuario.CEP1 = Convert.ToString(registro["Cep"]);
                    usuario.Bairro1 = Convert.ToString(registro["Bairro"]);
                    usuario.Complemento1 = Convert.ToString(registro["Complemento"]);
                    usuario.Password1 = Convert.ToString(registro["Password"]);

                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        // metodo para verificar o cliente

        public int VerficiarUsuario(string valor)
        {
            try
            {
                int r = 0;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM Usuario WHERE Cpf = @Cpf;";
                cmd.Parameters.AddWithValue("@Cpf", valor);
                conexao.AbrirConexao();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["Codigo"]);
                }
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

    }
}
