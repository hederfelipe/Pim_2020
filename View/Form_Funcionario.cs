using Pim_2020.Utilidade;
using Pim_2020.Validacao;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Pim_2020.Modelo;
using MetroFramework;

namespace Pim_2020.View
{
    public partial class Form_Funcionario : MetroForm
    {

         private Utilidade_conexao conexao = new Utilidade_conexao(Utilidade_DadosConexao.StringConexao);
         Utilidade_FormataCampos utilidade_formataCampos = new Utilidade_FormataCampos();
         Utilidade_validaCep valida_cep = new Utilidade_validaCep();
         Utilidade_ValidaCpf valida_cpf = new Utilidade_ValidaCpf();
         public int codigo = 0;


        string usuario, operacao;
        public Form_Funcionario()
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
        /// metodo para habilitar campos
        /// </summary>
        public void HabilitaCampos()
        {

            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtSexo.Enabled = true;
            txtEmail.Enabled = true;
            txtCargo.Enabled = true;
            txtTelefone.Enabled = true;
            txtSalarios.Enabled = true;
            txtNumeroFilhos.Enabled = true;
            txtData.Enabled = true;
            txtComplemento.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            txtEstado.Enabled = true;
            txtCEP.Enabled = true;
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
            txtSexo.Enabled = false;
            txtEmail.Enabled = false;
            txtCargo.Enabled = false;
            txtTelefone.Enabled = false;
            txtSalarios.Enabled = false;
            txtNumeroFilhos.Enabled = false;
            txtData.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
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
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtCPF.Text = "";
            txtSexo.Text = "";
            txtEmail.Text = "";
            txtCargo.Text = "";
            txtTelefone.Text = "";
            txtSalarios.Text = "";
            txtNumeroFilhos.Text = "";
            txtData.Text = "";
            txtComplemento.Text = "";
            txtCidade.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtCEP.Text = "";
            txtComplemento.Text = "";
            txtSenha.Text = "";

        }
        
        private void Form_Funcionario_Load(object sender, EventArgs e)
        {
            this.labelCpfInvalido.Visible = false;
            this.DesabilitaCampos();
            this.AlteraBotao(1);

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.LimpaCampos();
            this.txtNome.Focus();
            this.AlteraBotao(1);
        }

        private void BotonNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.txtNome.Focus();
            this.AlteraBotao(2);
            this.HabilitaCampos();


        }

        private void BotonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlteraBotao(2);
            this.txtNome.Focus();
        }

      

        private void BotonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MetroMessageBox.Show(this, "\n\n Deseja realmente Excluir o registro selecionado?",
                "CONFIRMAR A EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (resultado.ToString() == "Yes")
                {
                    Validacao_Funcionario valida_funcionario = new Validacao_Funcionario(conexao);
                    valida_funcionario.ExcluirFuncionario(Convert.ToInt32(txtCodigo.Text));
                    MetroMessageBox.Show(this, "\n\n  Cliente excluido com sucesso ",
                    "ESCLUSÃO DE CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlteraBotao(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n Não foi possivel excluir o cliente do banco de dados \n Detalhes: " + ex.Message,
                "ERRO AO EXCLUIR USUÁRIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtCodigo.Focus();
                this.AlteraBotao(3);
            }
        }

        private void BotonPesquisar_Click(object sender, EventArgs e)
        {
            FormRelatorioFuncionario relatorio = new FormRelatorioFuncionario();
            relatorio.ShowDialog();
            if (relatorio.codigo != 0)
            {
                Validacao_Funcionario valida = new Validacao_Funcionario(conexao);
                Modelo_Funcionario cliente = valida.CarregarFuncionario(relatorio.codigo);
                txtCodigo.Text = cliente.Codigo1.ToString();
                txtNome.Text = cliente.Nome1.ToString();
                txtCPF.Text = cliente.Cpf1;
                txtSexo.Text = cliente.Sexo1;
                txtEmail.Text = cliente.Email1;
                txtCargo.Text = cliente.Cargo1;
                txtNumeroFilhos.Text = cliente.Nr_Filhos.ToString();
                txtTelefone.Text = cliente.Telefone1.ToString();
                txtSalarios.Text = cliente.Salario1.ToString();
                txtData.Text = cliente.DataNascimento1.ToShortDateString();
                txtComplemento.Text = cliente.Rua1;
                txtCidade.Text = cliente.Cidade1;
                txtEstado.Text = cliente.Estado1;
                txtCEP.Text = cliente.CEP1;
                txtBairro.Text = cliente.Bairro1;
                txtComplemento.Text = cliente.Bairro1;
                txtSenha.Text = cliente.Password1.ToString();
                AlteraBotao(3);
            }
            else
            {
                LimpaCampos();
                txtData.Focus();
                AlteraBotao(1);
            }
            relatorio.Dispose();
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

        public void VerificarCPF(string usuario)
        {
            string cpfFormat = txtCPF.Text;
            {
                int r = 0;
                Validacao_Funcionario valida_cliente = new Validacao_Funcionario(conexao);
                r = valida_cliente. VerificarFuncionario(txtCPF.Text);
                if (r > 0)
                {
                    MetroMessageBox.Show(this, "\n\n Já existe o CPF  " + cpfFormat + "  do cliente cadastrado no sistema.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF.Text = "";
                    txtCPF.Focus();
                }
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            VerificarCPF(usuario);
            if (labelCpfInvalido.Visible == false)
            {
                if(valida_cpf.ValidaCPF(txtCPF.Text) == false)
                {
                    labelCpfInvalido.Visible = true;   
                }
                if (txtCPF.Text == "")
                {
                    labelCpfInvalido.Visible = false;
                }
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

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (valida_cep.verificaCEP(txtCEP.Text) == true)
            {
                txtBairro.Text = Utilidade_validaCep.Bairro;
                txtEstado.Text = Utilidade_validaCep.Estado;
                txtCidade.Text = Utilidade_validaCep.Cidade;
                txtLogadouro.Text = Utilidade_validaCep.Logadouro;
              
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




        //metodo para gravar 
        private void BotonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                Modelo_Funcionario mod_funcionario = new Modelo_Funcionario();
                mod_funcionario.Nome1 = txtNome.Text;
                mod_funcionario.Cpf1 = txtCPF.Text;
                mod_funcionario.Telefone1 = txtTelefone.Text;
                mod_funcionario.DataNascimento1 = Convert.ToDateTime(txtData.Text); ;
                mod_funcionario.Nr_Filhos = Convert.ToInt32(txtNumeroFilhos.Text);
                mod_funcionario.Sexo1 = txtSexo.Text;
                mod_funcionario.Cargo1 = txtCargo.Text;
                mod_funcionario.Salario1 =  txtSalarios.Text;
                mod_funcionario.Email1 = txtEmail.Text;
                mod_funcionario.Password1 = txtSenha.Text;
                mod_funcionario.CEP1 = txtCEP.Text;
                mod_funcionario.Rua1 = txtComplemento.Text;
                mod_funcionario.Bairro1 = txtBairro.Text;
                mod_funcionario.Estado1 = txtEstado.Text;
                mod_funcionario.Cidade1 = txtCidade.Text;
                mod_funcionario.Complemento1 = txtComplemento.Text;
                Validacao_Funcionario validacao_funcionario = new Validacao_Funcionario(conexao);
                if (operacao == "cadastrar")
                {

                    validacao_funcionario.SalvarFuncionario(mod_funcionario);
                    MetroMessageBox.Show(this, "\n Cliente Cadastrado com sucesso ", "CADASTRO DE USUÁRIO",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                    this.Close();
                }
                else
                {
                    mod_funcionario.Codigo1 = Convert.ToInt32(txtCodigo.Text);
                    validacao_funcionario.EditarFuncionario(mod_funcionario);
                    MetroMessageBox.Show(this, "\n\n  Cliente Editado com sucesso! ", " USUÁRIO EDITADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                this.LimpaCampos();
                this.AlteraBotao(1);
                this.DesabilitaCampos();
            }
            catch (Exception eX)
            {
                MetroMessageBox.Show(this, "\n\n  Erro ao cadastrar um Funcionario! \n Detalhes: " + eX.Message,
                "ERRO AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }


        }
    }
}
