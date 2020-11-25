using Intersoft.Crosslight;
using Pim_2020.Modelo;
using Pim_2020.Utilidade;
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
    public class Negocio_Exchanges
    {
        public Utilidade_conexao conexao;
        SqlCommand comando = null;


        public Negocio_Exchanges(Utilidade_conexao cx)
        {
            this.conexao = cx;
        }
        /// <summary>
        /// metodo para gravar os clientes no BD
        /// </summary>
        /// <param name="mod_usuario"></param>
        public void SalvarExchanges(Modelo_Exchanges modelo_exchanges)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO Exchangers  ( Nome ) " +
                "VALUES ( @Nome) ; SELECT @@Identity";
                cmd.Parameters.AddWithValue("Nome", modelo_exchanges.Nome1);
               
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

        public void EditarExchanges(Modelo_Exchanges modelo_exchanges)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE Exchangers SET Nome = @Nome,Codigo = @Codigo   WHERE Codigo = @Codigo";
                cmd.Parameters.AddWithValue("Nome", modelo_exchanges.Nome1);
                cmd.Parameters.AddWithValue("Codigo", modelo_exchanges.Codigo1);
                
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
        public void ExcluirExchanges(string codigo)
        {
            try
            {
                conexao.AbrirConexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM Exchangers WHERE Nome = @Nome";
                cmd.Parameters.AddWithValue("@Nome", codigo);
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

        public DataTable ListarExchangers(string valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Exchangers WHERE Nome like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //metodo para carregar clientes no grid
        public Modelo_Exchanges CarregarExchanges(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                Modelo_Exchanges usuario = new Modelo_Exchanges();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM Exchangers WHERE Codigo = @Codigo;";
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    usuario.Codigo1 = Convert.ToInt32(registro["Codigo"]);
                    usuario.Nome1 = Convert.ToString(registro["Nome"]);
               

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
                cmd.CommandText = "SELECT * FROM Exchangers WHERE Codigo = @Codigo;";
                cmd.Parameters.AddWithValue("@Codigo", valor);
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
