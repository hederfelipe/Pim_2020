using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Pim_2020.Utilidade;
using Pim_2020.Validacao;
using Pim_2020.Relatorio;

namespace Pim_2020.View
{
    public partial class Form_Relatorio_Usuario : MetroForm
    {
        public Form_Relatorio_Usuario()
        {
            InitializeComponent();
        }


        public int codigo = 0;
        Utilidade_conexao conexao = new Utilidade_conexao(Utilidade_DadosConexao.StringConexao);
       



        private void BotonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// metodo que executa o formulario load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



        public void CarregaUsuario(int codigo)
        {
            Validacao_Usuario valida_usuario = new Validacao_Usuario(conexao);
            metroGrid1.DataSource = valida_usuario.CarregarUsuario(codigo);
        }




        private void BotonPesquisarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Validacao_Usuario valida = new Validacao_Usuario(conexao);
                metroGrid1.DataSource = valida.ListarUsuario(gridTextForma.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       /* private void BotonGerar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmdGerarArquivo.SelectedIndex) == -1)
            {
                MessageBox.Show(this, "\n\n Selecione um fomrmato de documento", "GERAR DOCUMENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (Convert.ToString(cmdGerarArquivo.SelectedItem) == "")
            {
                MessageBox.Show(this, "\n\n Por favor selecione uma opção ", "GERAR DOCUMENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (Convert.ToString(cmdGerarArquivo.SelectedItem) == "Gerar PDF")
            {

              
            }


            else if (Convert.ToString(cmdGerarArquivo.SelectedItem) == "Gerar Word")
            {
                MessageBox.Show(this, "\n\n Documento Word gerado com sucesso", "GERAR DOCUMENTOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            else if (Convert.ToString(cmdGerarArquivo.SelectedItem) == "Gerar Excell")
            {
                MessageBox.Show(this, "\n\n Documento Excell gerado com suceso", "GERAR DOCUMENTOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
       */


        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(metroGrid1.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }


        private void Form_Relatorio_Usuario_Load(object sender, EventArgs e)
        {
            /*
            cmdGerarArquivo.Items.Insert(0, "");
            cmdGerarArquivo.Items.Insert(1, "Gerar PDF");
            cmdGerarArquivo.Items.Insert(2, "Gerar Excel");
            cmdGerarArquivo.Items.Insert(3, "Gerar Word");
            */

            // Mudar cor do Grid
            metroGrid1.RowsDefaultCellStyle.BackColor = Color.GhostWhite;
            metroGrid1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkTurquoise;
            metroGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            metroGrid1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            CarregaUsuario(codigo);

            //Fomatar datagrid
            BotonPesquisarCliente_Click(sender, e);

            metroGrid1.Columns["Codigo"].HeaderText = "Codigo";


            metroGrid1.Columns["Nome"].HeaderText = "Nome";


            metroGrid1.Columns["Cpf"].HeaderText = "CPF";


            metroGrid1.Columns["Email"].HeaderText = "Email";


            metroGrid1.Columns["Telefone"].HeaderText = "Telefone";



            metroGrid1.Columns["DataNascimento"].HeaderText = " Nascimento";


            metroGrid1.Columns["Sexo"].HeaderText = "Sexo";



            //metodo para desabilitas/ocultar outras colunas


            metroGrid1.Columns["Rua"].Visible = false;
            metroGrid1.Columns["CEP"].Visible = false;
            metroGrid1.Columns["Bairro"].Visible = false;
            metroGrid1.Columns["Estado"].Visible = false;
            metroGrid1.Columns["Complemento"].Visible = false;
        }
        

        private void gridTextForma_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validacao_Usuario valida = new Validacao_Usuario(conexao);
                metroGrid1.DataSource = valida.ListarUsuario(gridTextForma.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cmdGerarArquivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormRelatorioUsuario f = new FormRelatorioUsuario();
            f.ShowDialog();
            f.Dispose();
            MessageBox.Show(this, "\n\n Documento PDF gerado com sucesso", "GERAR DOCUMENTOS", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

    }
}
