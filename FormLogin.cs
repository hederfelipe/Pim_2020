using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Pim_2020.Modelo;
using Pim_2020.Utilidade;
using Pim_2020.View;

namespace Pim_2020
{
    public partial class FormLogin : MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        /// </summary>
        Utilidade_conexao conexao = new Utilidade_conexao(Utilidade_DadosConexao.StringConexao);

        
        Modelo_Funcionario modelo = new Modelo_Funcionario();
        public static string usuario_logado;
        public static string adm_logado;

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            metroLabel8.Text = Application.ProductVersion;
        }

        

        public void LogarSistema()
        {

           
            SqlConnection cx = new SqlConnection("server = .\\SQLEXPRESS; Database = pim_2020; User Id = hederfelipe; Password = 816633");
            cx.Open();
            SqlCommand cmd = new SqlCommand();
            SqlConnection conectado = new SqlConnection();
            cmd.Connection = cx;
            cmd.CommandText = "SELECT Funcionario.Nome, Funcionario.Password, Usuario.Nome,Usuario.Password FROM Funcionario, Usuario WHERE Funcionario.Codigo = Usuario.Codigo";
            // cmd.Parameters.Add("@Nome", SqlDbType.Text).Value = txtUsuario.Text;   conversão de text para varchar
            //cmd.Parameters.Add("@Password", SqlDbType.Text).Value = txtPassword.Text;
            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtUsuario.Text;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtPassword.Text;
            SqlDataReader ler = null;
            ler = cmd.ExecuteReader();
            if (ler.Read())
            {
                usuario_logado = txtUsuario.Text;
                FormPrincipal f = new FormPrincipal();
                f.Show();
                this.Hide();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\n Usuário ou senha inválido, por favor tente novamente! " +
                "\n\n Ou entre em contato com o administrador do sistema.", "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaCampos(); txtUsuario.Focus();
            }
            cx.Close();
        }


      

        public void LimpaCampos()
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }


        private void txtSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void txtEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroMessageBox.Show(this, "\n\n O campo usuário e senha são obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaCampos();
                txtUsuario.Focus();
                return;
            }
            else
            {
                LogarSistema();
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

      

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start("https://obliviate-pim.netlify.app/");
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Form_Usuario f = new Form_Usuario();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
