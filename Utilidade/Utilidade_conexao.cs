using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pim_2020.Utilidade
{
    public class Utilidade_conexao

    {
        private string _stringConexao;

        private SqlConnection  _conexao;


        public Utilidade_conexao(string dadosConexao)
        {
            this._conexao = new SqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;

        }


        public string StringConexao
        {
            get => this._stringConexao;
            set => this._stringConexao = value;
        }

        public SqlConnection Conexao
        {
            get => this._conexao;
            set => this._conexao = value;

        }

        public void AbrirConexao()
        {
            this.Conexao.Open();
        }
        public void FecharConexao()
        {
            this.Conexao.Close();
        }
    }
}
