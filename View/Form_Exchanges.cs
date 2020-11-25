using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Pim_2020.Modelo;
using Pim_2020.Utilidade;
using Pim_2020.Validacao;

namespace Pim_2020.View
{
    public partial class Form_Exchanges : MetroForm
    {
        private Utilidade_conexao conexao = new Utilidade_conexao(Utilidade_DadosConexao.StringConexao);
        private string usuario, operacao;
        public int codigo = 0;
        public Form_Exchanges()
        {
            InitializeComponent();
        }

        public void AlteraBotao(int op)
        {
            BotonCancelar.Enabled = false;
            BotonNovo.Enabled = false;
            BotonVoltar.Enabled = false;
            BotonGravar.Enabled = false;
            BotonExcluir.Enabled = false;
            BotonPesquisar.Enabled = false;


            if (op == 1)
            {
                BotonNovo.Enabled = true;
                BotonPesquisar.Enabled = true;
                BotonVoltar.Enabled = true;
            }
            if (op == 2)
            {
                BotonGravar.Enabled = true;
                BotonCancelar.Enabled = true;
            }
            if (op == 3)
            {
                BotonExcluir.Enabled = true;
                BotonCancelar.Enabled = true;
            }
        }
        /// <summary>
        /// metodo para verificar o usuario cadastrado
        /// </summary>
        /// <param name="usuario"></param>
        public void VerificarExchanges(string usuario)
        {
            int r = 0;
            Validacao_Exchanges valida = new Validacao_Exchanges(conexao);
            r = valida.VerificarExchanges(inputNome.Text);
            if (r > 0)
            {
                MetroMessageBox.Show(this, "\n\n Ja existe Usuário cadastrado no sistema ", "VERIFICAÇÃO DE USUÁRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaCampos();
                inputNome.Focus();
            }
        }

        /// <summary>
        /// função habilita campos do formulario
        /// </summary>
        public void HabilitaCampos()
        {


            inputNome.Enabled = true;

            this.inputNome.Focus();
        }
        /// <summary>
        /// função desabilita campos do formulario
        /// </summary>
        public void DesabilitaCampos()
        {
            inputNome.Enabled = false;


            this.inputNome.Focus();
        }

        /// <summary>
        /// função para limpar os campos
        /// </summary>
        public void LimpaCampos()
        {
            inputCode.Text = "";
            inputNome.Text = "";

        }

        private void Form_Usuario_Load(object sender, EventArgs e)
        {

            this.DesabilitaCampos();
            this.AlteraBotao(1);
        }

        /// <summary>
        /// Chama formulario de cadastro de usuario
        /// </summary> bota para voltar
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// metodo do botao gravar / cadastrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void BotonNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.inputNome.Focus();
            this.AlteraBotao(2);
            this.HabilitaCampos();
        }

        /// <summary>
        /// metodo botao editar cadastro do usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonEditar_Click(object sender, EventArgs e)
        {

            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlteraBotao(2);
            this.inputNome.Focus();
        }

        /// <summary>
        /// metodo para cancelar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.LimpaCampos();
            this.inputNome.Focus();
            this.AlteraBotao(1);
        }

        private void formCadastroUsuario_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlteraBotao(1);
        }

        /// <summary>
        /// Metodo para gravar usuario ao banco de dados
        /// </summary>
        private void BotonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                Modelo_Exchanges mod_usuario = new Modelo_Exchanges();
                mod_usuario.Nome1 = inputNome.Text;

                Validacao_Exchanges validacao_usuario = new Validacao_Exchanges(conexao);
                if (operacao == "cadastrar")
                {

                    validacao_usuario.Salvarexchanges(mod_usuario);
                    MetroMessageBox.Show(this, "\n Exchanges Cadastrado com sucesso ", "CADASTRO DE Exchanges",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
                else
                {
                    mod_usuario.Codigo1 = Convert.ToInt32(inputCode.Text);
                    validacao_usuario.EditarExchanges(mod_usuario);
                    MetroMessageBox.Show(this, "\n\n  Exchanges Editado com sucesso! ", " Exchanges EDITADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                this.LimpaCampos();
                this.AlteraBotao(1);
                this.DesabilitaCampos();
            }
            catch (Exception eX)
            {
                MetroMessageBox.Show(this, "\n\n  Erro ao cadastrar uma Exchanges! \n Detalhes: " + eX.Message,
                "ERRO AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }

        }



        private void BotonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show(this, "\n\n Deseja realmente Excluir o registro selecionado?",
               "CONFIRMAR A EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (resultado.ToString() == "Yes")
                {
                    Validacao_Exchanges valida_moeda = new Validacao_Exchanges(conexao);
                    valida_moeda.ExcluirExchanges(Convert.ToString(metroComboBox1.Text));
                    MetroMessageBox.Show(this, "\n\n  Usuário excluido com sucesso ",
                    "ESCLUSÃO DE USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n Não foi possivel excluir usuário do banco de dados \n Detalhes: " + ex.Message,
                "ERRO AO EXCLUIR CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void BotonPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                Validacao_Exchanges valida = new Validacao_Exchanges(conexao);
                metroGrid1.DataSource = valida.ListarExchanges(metroComboBox1.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        

        private void inputNome_Leave(object sender, EventArgs e)
        {
            VerificarExchanges(usuario);
        }

      


        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Exchanges_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pim_2020DataSet.Exchangers' table. You can move, or remove it, as needed.
            this.exchangersTableAdapter.Fill(this.pim_2020DataSet.Exchangers);

        }


    }

}
