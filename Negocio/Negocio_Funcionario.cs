using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pim_2020.Utilidade;
using Pim_2020.Modelo;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Pim_2020.Negocio
{
    public class Negocio_Funcionario
    {

        /// <summary>
        /// variavel global da classe
        /// </summary>
        public Utilidade_conexao conexao;
        SqlCommand comando = null;


        public Negocio_Funcionario(Utilidade_conexao cx)
        {
            this.conexao = cx;
        }

        /// <summary>
        /// metodo para gravar os clientes no BD
        /// </summary>
        /// <param name="mod_usuario"></param>
        public void SalvarFuncionario(Modelo_Funcionario modelo_Funcionario)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO Funcionario ( Nome ,Cpf, Email, Sexo , Cargo , nr_Filhos, Telefone , Salario, DataNascimento, Rua, Cidade, Estado ,CEP,Bairro,Complemento,Password) " +
                "VALUES ( @Nome , @Cpf, @Email,  @Sexo , @Cargo ,  @nr_Filhos,  @Telefone ,  @Salario,  @DataNascimento,  @Rua,  @Cidade,  @Estado , @CEP, @Bairro,@Complemento,@Password) ; SELECT @@Identity";
                cmd.Parameters.AddWithValue("Nome", modelo_Funcionario.Nome1);
                cmd.Parameters.AddWithValue("Cpf", modelo_Funcionario.Cpf1);
                cmd.Parameters.AddWithValue("Email", modelo_Funcionario.Email1);
                cmd.Parameters.AddWithValue("Sexo", modelo_Funcionario.Sexo1);
                cmd.Parameters.AddWithValue("nr_Filhos", modelo_Funcionario.Nr_Filhos);
                cmd.Parameters.AddWithValue("Cargo", modelo_Funcionario.Cargo1);
                cmd.Parameters.AddWithValue("Telefone", modelo_Funcionario.Telefone1);
                cmd.Parameters.AddWithValue("Salario", modelo_Funcionario.Salario1);
                cmd.Parameters.AddWithValue("DataNascimento", modelo_Funcionario.DataNascimento1);
                cmd.Parameters.AddWithValue("Rua", modelo_Funcionario.Rua1);
                cmd.Parameters.AddWithValue("Cidade", modelo_Funcionario.Cidade1);
                cmd.Parameters.AddWithValue("Estado", modelo_Funcionario.Estado1);
                cmd.Parameters.AddWithValue("CEP", modelo_Funcionario.CEP1);
                cmd.Parameters.AddWithValue("Bairro", modelo_Funcionario.Bairro1);
                cmd.Parameters.AddWithValue("Complemento", modelo_Funcionario.Complemento1);
                cmd.Parameters.AddWithValue("Password", modelo_Funcionario.Password1);
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

        public void EditarFuncionario(Modelo_Funcionario modelo_Funcionario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE Funcionario SET Nome = @Nome  ,Cpf = @Cpf, Email = @Email," +
                "Sexo = @Sexo , nr_Filhos = @nr_Filhos , Cargo = @Cargo, Telefone = @Telefone  ," +
                "Salario = @Salario,DataNascimento = @DataNascimento, Rua = @Rua, Cidade = @Cidade, Estado = @Estado, CEP = @CEP ,Bairro = @Bairro,Complemento = @Complemento,Password = @Password WHERE Codigo = @Codigo";
                cmd.Parameters.AddWithValue("Nome", modelo_Funcionario.Nome1);
                cmd.Parameters.AddWithValue("Codigo", modelo_Funcionario.Codigo1);
                cmd.Parameters.AddWithValue("Cpf", modelo_Funcionario.Cpf1);
                cmd.Parameters.AddWithValue("Email", modelo_Funcionario.Email1);
                cmd.Parameters.AddWithValue("Sexo", modelo_Funcionario.Sexo1);
                cmd.Parameters.AddWithValue("nr_Filhos", modelo_Funcionario.Nr_Filhos);
                cmd.Parameters.AddWithValue("Cargo", modelo_Funcionario.Cargo1);
                cmd.Parameters.AddWithValue("Telefone", modelo_Funcionario.Telefone1);
                cmd.Parameters.AddWithValue("Salario", modelo_Funcionario.Salario1);
                cmd.Parameters.AddWithValue("DataNascimento", modelo_Funcionario.DataNascimento1);
                cmd.Parameters.AddWithValue("Rua", modelo_Funcionario.Rua1);
                cmd.Parameters.AddWithValue("Cidade", modelo_Funcionario.Cidade1);
                cmd.Parameters.AddWithValue("Estado", modelo_Funcionario.Estado1);
                cmd.Parameters.AddWithValue("CEP", modelo_Funcionario.CEP1);
                cmd.Parameters.AddWithValue("Bairro", modelo_Funcionario.Bairro1);
                cmd.Parameters.AddWithValue("Complemento", modelo_Funcionario.Complemento1);
                cmd.Parameters.AddWithValue("Password", modelo_Funcionario.Password1);
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
        public void Excluir_Funcionario(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM Funcionario WHERE Codigo = @Codigo";
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
       
      public DataTable ListarFuncionario(string valor)
      {
          try
          {
              DataTable tabela = new DataTable();
              SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Funcionario WHERE Nome like '%" + valor + "%'", conexao.StringConexao);
              da.Fill(tabela);
              return tabela;
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }

      //metodo para carregar clientes no grid
      public Modelo_Funcionario CarregarFuncionario(int codigo)
      {
          try
          {
              conexao.AbrirConexao();
              Modelo_Funcionario funcionario = new Modelo_Funcionario();
              SqlCommand cmd = new SqlCommand();
              cmd.Connection = conexao.Conexao;
              cmd.CommandText = "SELECT * FROM Funcionario WHERE Codigo = @Codigo;";
              cmd.Parameters.AddWithValue("@Codigo", codigo);
              SqlDataReader registro = cmd.ExecuteReader();
              if (registro.HasRows)
              {
                  registro.Read();
                    funcionario.Codigo1 = Convert.ToInt32(registro["Codigo"]);
                    funcionario.Nome1 = Convert.ToString(registro["Nome"]);
                    funcionario.Cpf1 = Convert.ToString(registro["Cpf"]);
                    funcionario.Email1 = Convert.ToString(registro["Email"]);
                    funcionario.Sexo1 = Convert.ToString(registro["Sexo"]);
                    funcionario.Cargo1 = Convert.ToString(registro["Cargo"]);
                    funcionario.Nr_Filhos = Convert.ToInt32(registro["nr_Filhos"]);
                    funcionario.Telefone1 = Convert.ToString(registro["Telefone"]);
                    funcionario.Salario1 = Convert.ToString(registro["Salario"]);
                    funcionario.DataNascimento1 = Convert.ToDateTime(registro["DataNascimento"]);
                    funcionario.Rua1 = Convert.ToString(registro["Rua"]);
                    funcionario.Cidade1 = Convert.ToString(registro["Cidade"]);
                    funcionario.Estado1 = Convert.ToString(registro["Estado"]);
                    funcionario.CEP1 = Convert.ToString(registro["Cep"]);
                    funcionario.Bairro1 = Convert.ToString(registro["Bairro"]);
                    funcionario.Complemento1 = Convert.ToString(registro["Complemento"]);
                    funcionario.Password1 = Convert.ToString(registro["Password"]);

                }
              return funcionario;
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

        public int VerficiarFuncionario(string valor)
        {
            try
            {
                int r = 0;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM Funcionario WHERE Cpf = @Cpf;";
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
    





