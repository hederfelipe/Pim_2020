using DocumentFormat.OpenXml.Drawing.Charts;
using Pim_2020.Modelo;
using Pim_2020.Utilidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_2020.Negocio
{
    public class Negocio_Carteira
    {

        public Utilidade_conexao conexao;
        SqlCommand comando = null;


        public Negocio_Carteira(Utilidade_conexao cx)
        {
            this.conexao = cx;
        }
        public void SalvarCarteira(Modelo_Conta_Carteira modelo_Carteira)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO Conta_Carteira (ValorCompra,ValorVenda) VALUES (@ValorCompra,@ValorVenda);" +
                    " SELECT @@Identity"; 
              
                cmd.Parameters.AddWithValue("ValorCompra", modelo_Carteira.ValorCompra1);
                cmd.Parameters.AddWithValue("ValorVenda", modelo_Carteira.ValorVenda1);
                cmd.Parameters.AddWithValue("Lucro", modelo_Carteira.Lucro1);



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

        public  void AtualizarCarteira(Modelo_Conta_Carteira modelo_Usuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE Conta_Carteira SET ValorVenda = @ValorVenda Codigo = @Codigo  WHERE Codigo = @Codigo";
                cmd.Parameters.AddWithValue("Codigo", modelo_Usuario.Codigo1);
                cmd.Parameters.AddWithValue("ValorVenda", modelo_Usuario.ValorVenda1);
               
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
    }
}
