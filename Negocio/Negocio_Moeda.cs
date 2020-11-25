using Google.Protobuf.WellKnownTypes;
using Pim_2020.Modelo;
using Pim_2020.Utilidade;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_2020.Negocio
{
    public class Negocio_Moeda
    {

        public Utilidade_conexao conexao;
        SqlCommand comando = null;


        public Negocio_Moeda(Utilidade_conexao cx)
        {
            this.conexao = cx;
        }
        public List<Modelo_Moeda> GetCurrency()
        {

            SqlConnection cx = new SqlConnection("server = .\\SQLEXPRESS; Database = pim_2020; User Id = hederfelipe; Password = 816633");
            cx.Open();
            SqlCommand cmd = new SqlCommand();
            SqlConnection conectado = new SqlConnection();
            cmd.Connection = cx;
            cmd.CommandText = @"SELECT * FROM Moeda ";
            SqlDataReader dr = cmd.ExecuteReader();
            List<Modelo_Moeda> categorias = new List<Modelo_Moeda>();
            // quando acabar as linhas que retornou da consulta, sai do While
            while (dr.Read())
            {
                Modelo_Moeda cat = new Modelo_Moeda();
                cat.Nome1 = dr.GetString(dr.GetOrdinal("Nome"));
               
                categorias.Add(cat);
            }

            cmd.Connection.Close();
            cmd.Dispose();

            return categorias;

        }



        /// <summary>
        /// metodo para gravar as Moedas
        /// 
        /// </summary>
        /// <param name="mod_usuario"></param>
        public void SalvarMoeda(Modelo_Moeda modelo_Moeda)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO Moeda  ( Nome ,Tipo, Valor,Tempo,Taxa) " + "VALUES ( @Nome , @Tipo, @Valor,  @Tempo, @Taxa ) ; SELECT @@Identity";
                cmd.Parameters.AddWithValue("Nome", modelo_Moeda.Nome1);
                cmd.Parameters.AddWithValue("Tipo", modelo_Moeda.Tipo1);
                cmd.Parameters.AddWithValue("Valor", modelo_Moeda.Valor1);
                cmd.Parameters.AddWithValue("Taxa", modelo_Moeda.Taxa1);
                cmd.Parameters.AddWithValue("Tempo", modelo_Moeda.Tempo1);

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


        //metodo para editar Moeda

        public void EditarMoeda(Modelo_Moeda modelo_Moeda)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO Moeda  ( Nome ,Tipo, Valor,Tempo,Taxa) " + "VALUES ( @Nome , @Tipo, @Valor,  @Tempo,@Taxa ) ; SELECT @@Identity";
                cmd.Parameters.AddWithValue("Nome", modelo_Moeda.Nome1);
                cmd.Parameters.AddWithValue("Tipo", modelo_Moeda.Tipo1);
                cmd.Parameters.AddWithValue("Valor", modelo_Moeda.Valor1);
                cmd.Parameters.AddWithValue("Taxa", modelo_Moeda.Taxa1);
                cmd.Parameters.AddWithValue("Tempo", modelo_Moeda.Tempo1);

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
        public void ExcluirMoeda(string codigo)
        {

            try
            {
                conexao.AbrirConexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM Moeda WHERE Codigo = @Codigo";
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

        public DataTable ListarMoeda(string valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Moeda WHERE Nome like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //metodo para carregar clientes no grid
        public Modelo_Moeda CarregaMoeda(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                Modelo_Moeda moeda = new Modelo_Moeda();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM Moeda WHERE Codigo = @Codigo INNER JOIN Exangers on Codigo; ";
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    moeda.Codigo1 = Convert.ToInt32(registro["Codigo"]);
                    moeda.Nome1 = Convert.ToString(registro["Nome"]);
                    moeda.Tipo1 = Convert.ToString(registro["Tipo"]);
                    moeda.Valor1 = Convert.ToString(registro["Valor"]);
                    moeda.Taxa1 = Convert.ToString(registro["Taxa"]);
                    moeda.Tempo1 = Convert.ToDateTime(registro["Tempo"]);
                    


                }
                return moeda;
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

        public int VerficiarMoeda(string valor)
        {
            try
            {
                int r = 0;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM Moeda WHERE Nome = @Nome;";
                cmd.Parameters.AddWithValue("@Nome", valor);
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

