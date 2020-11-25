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
    public partial class Form_Usuario : MetroForm
    {
       

        private Utilidade_conexao conexao = new Utilidade_conexao(Utilidade_DadosConexao.StringConexao);
        Utilidade_FormataCampos utilidade_formataCampos = new Utilidade_FormataCampos();
        Utilidade_validaCep valida_cep = new Utilidade_validaCep();
        Utilidade_ValidaCpf valida_cpf = new Utilidade_ValidaCpf();
        private string usuario, operacao;
        string Gender;
        

        public Form_Usuario()
        {
            InitializeComponent();
        }
        public void AlteraBotao(int op)
        {
            BotonCancelar.Enabled = false;
            BotonNovo.Enabled = false;
            BotonVoltar.Enabled = false;
            BotonGravar.Enabled = false;
            BotonEditar.Enabled = false;
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
                BotonEditar.Enabled = true;
                BotonCancelar.Enabled = true;
            }
        }
        /// <summary>
        /// metodo para verificar o usuario cadastrado
        /// </summary>
        /// <param name="usuario"></param>
        public void verificaUsuario(string usuario)
        {
            int r = 0;
            Validacao_Usuario valida = new Validacao_Usuario(conexao);
            r = valida.VerificarUsuario(txtNome.Text);
            if (r > 0)
            {
                MetroMessageBox.Show(this, "\n\n Ja existe Usuário cadastrado no sistema ", "VERIFICAÇÃO DE USUÁRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaCampos();
                txtNome.Focus();
            }
        }

        /// <summary>
        /// função habilita campos do formulario
        /// </summary>
        public void HabilitaCampos()
        {


            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtEmail.Enabled = true;
            txtSexo.Enabled = true;
            txtTelefone.Enabled = true;
            txtData.Enabled = true;
            txtComplemento.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            txtEstado.Enabled = true;
            txtCEP.Enabled = true;
            txtRua.Enabled = true;
            txtComplemento.Enabled = true;
            txtSenha.Enabled = true;
            this.txtNome.Focus();
        }
        /// <summary>
        /// função desabilita campos do formulario
        /// </summary>
        public void DesabilitaCampos()
        {
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtEmail.Enabled = false;
            txtSexo.Enabled = false;
            txtTelefone.Enabled = false;
            txtData.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtRua.Enabled = false;
            txtCEP.Enabled = false;
            txtComplemento.Enabled = false;
            txtSenha.Enabled = false;

            this.txtNome.Focus();
        }

        /// <summary>
        /// função para limpar os campos
        /// </summary>
        public void LimpaCampos()
        {
            txtCode.Text = "";
            txtNome.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtSexo.Text = "";
            txtTelefone.Text = "";
            txtData.Text = "";
            txtComplemento.Text = "";
            txtCidade.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtCEP.Text = "";
            txtComplemento.Text = "";
            txtSenha.Text = "";
        }

        private void Form_Usuario_Load(object sender, EventArgs e)
        {
            this.labelCpfInvalido.Visible = false;
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
            this.txtNome.Focus();
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
            this.txtNome.Focus();
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
            this.txtNome.Focus();
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
                Modelo_Usuario mod_usuario = new Modelo_Usuario();
                mod_usuario.Nome1 = txtNome.Text;
                mod_usuario.Cpf1 = txtCPF.Text;
                mod_usuario.Email1 = txtEmail.Text;
                mod_usuario.Telefone1 = txtTelefone.Text;
                mod_usuario.DataNascimento1 = Convert.ToDateTime(txtData.Text);
                mod_usuario.Sexo1 = txtSexo.Text;
                mod_usuario.CEP1 = txtCEP.Text;
                mod_usuario.Rua1 = txtRua.Text;
                mod_usuario.Cidade1 = txtCidade.Text;
                mod_usuario.Estado1 = txtEstado.Text;
                mod_usuario.Bairro1 = txtBairro.Text;
                mod_usuario.Complemento1 = txtComplemento.Text;
                mod_usuario.Password1 = txtSenha.Text;
                Validacao_Usuario validacao_usuario = new Validacao_Usuario(conexao);
                if (operacao == "cadastrar")
                {

                    validacao_usuario.SalvarUsuario(mod_usuario);
                    MetroMessageBox.Show(this, "\n Cliente Cadastrado com sucesso ", "CADASTRO DE USUÁRIO",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
                else 
                {
                    mod_usuario.Codigo1 = Convert.ToInt32(txtCode.Text);
                    validacao_usuario.EditarUsuario(mod_usuario);
                    MetroMessageBox.Show(this, "\n\n  Cliente Editado com sucesso! ", " USUÁRIO EDITADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                this.LimpaCampos();
                this.AlteraBotao(1);
                this.DesabilitaCampos();
            }
            catch (Exception eX)
            {
                MetroMessageBox.Show(this, "\n\n  Erro ao cadastrar um cliente! \n Detalhes: " + eX.Message,
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
                    Validacao_Usuario valida_usuario = new Validacao_Usuario(conexao);
                    valida_usuario.ExcluirUsuario(Convert.ToInt32(txtCode.Text));
                    MetroMessageBox.Show(this, "\n\n  Usuário excluido com sucesso ",
                    "ESCLUSÃO DE USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlteraBotao(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n Não foi possivel excluir usuário do banco de dados \n Detalhes: " + ex.Message,
                "ERRO AO EXCLUIR CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNome.Focus();
                this.AlteraBotao(3);
            }
        }



        private void BotonPesquisar_Click(object sender, EventArgs e)
        {
            Form_Relatorio_Usuario relatorio = new Form_Relatorio_Usuario();
            relatorio.ShowDialog();
            if (relatorio.codigo != 0)
            {
                Validacao_Usuario valida = new Validacao_Usuario(conexao);
                Modelo_Usuario usuario = valida.CarregarUsuario(relatorio.codigo);
                txtCode.Text = usuario.Codigo1.ToString();
                txtNome.Text = usuario.Nome1.ToString();
                txtCPF.Text = usuario.Cpf1;
                txtEmail.Text = usuario.Email1;
                txtSexo.Text = usuario.Sexo1;
                txtTelefone.Text = usuario.Telefone1.ToString();
                txtData.Text = usuario.DataNascimento1.ToShortDateString();
                txtComplemento.Text = usuario.Complemento1;
                txtCidade.Text = usuario.Cidade1;
                txtEstado.Text = usuario.Estado1;
                txtCEP.Text = usuario.CEP1;
                txtBairro.Text = usuario.Bairro1;
                txtRua.Text = usuario.Rua1;
             
                txtSenha.Text = usuario.Password1.ToString();
                AlteraBotao(3);
            }
            else
            {
                LimpaCampos();
                txtNome.Focus();
                AlteraBotao(1);
            }
            relatorio.Dispose();

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

       

        /// <summary>
        /// evento para verificar usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            verificaUsuario(usuario);
        }


        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                Utilidade_FormataCampos.Campos edit = Utilidade_FormataCampos.Campos.CPF;
                utilidade_formataCampos.Mascara(edit, txtCPF);
            }
        }



        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                Utilidade_FormataCampos.Campos edit = Utilidade_FormataCampos.Campos.DATA;
                utilidade_formataCampos.Mascara(edit, txtData);
            }
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                Utilidade_FormataCampos.Campos edit = Utilidade_FormataCampos.Campos.CEP;
                utilidade_formataCampos.Mascara(edit, txtCEP);
            }
        }



        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                Utilidade_FormataCampos.Campos edit = Utilidade_FormataCampos.Campos.TELEFONE;
                utilidade_formataCampos.Mascara(edit, txtTelefone);
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            string cpfFormat = txtCPF.Text;
            {
                int r = 0;
                Validacao_Usuario valida_cliente = new Validacao_Usuario(conexao);
                r = valida_cliente.VerificarUsuario(txtCPF.Text);
                if (r > 0)
                {
                    MetroMessageBox.Show(this, "\n\n Já existe o CPF  " + cpfFormat + "  do cliente cadastrado no sistema.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF.Text = "";
                    txtCPF.Focus();
                }
            }
        }

    

       

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (valida_cep.verificaCEP(txtCEP.Text) == true)
            {
                txtBairro.Text = Utilidade_validaCep.Bairro;
                txtEstado.Text = Utilidade_validaCep.Estado;
                txtCidade.Text = Utilidade_validaCep.Cidade;
                txtRua.Text = Utilidade_validaCep.Logadouro;

            }
        }
    }
}
