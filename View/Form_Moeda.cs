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
using Pim_2020.Relatorio;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Pim_2020.View
{
    public partial class Form_Moeda : MetroForm
    {
        private Utilidade_conexao conexao = new Utilidade_conexao(Utilidade_DadosConexao.StringConexao);
        Utilidade_FormataCampos utilidade_formataCampos = new Utilidade_FormataCampos();


        private string usuario, operacao;

        private readonly Dashboard FormBitcoinList;
        public Form_Moeda( )
        {
           
            InitializeComponent();
           

        }

     
        private void inptCurrency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Moeda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pim_2020DataSet.Exchangers' table. You can move, or remove it, as needed.
            this.exchangersTableAdapter.Fill(this.pim_2020DataSet.Exchangers);


            // TODO: This line of code loads data into the 'pim_2020DataSet.Moeda' table. You can move, or remove it, as needed.
            this.moedaTableAdapter.Fill(this.pim_2020DataSet.Moeda);

           
        }

      

        private void inputData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                Utilidade_FormataCampos.Campos edit = Utilidade_FormataCampos.Campos.DATA;
                utilidade_formataCampos.Mascara(edit, inputData);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRelatorioMoeda f = new FormRelatorioMoeda();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnDeleteCurrency_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult resultado = MessageBox.Show(this, "\n\n Deseja realmente Excluir o registro selecionado?",
                "CONFIRMAR A EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (resultado.ToString() == "Yes")
                {
                    Validacao_Moeda valida_moeda = new Validacao_Moeda(conexao);
                    valida_moeda.ExcluirMoeda(Convert.ToString(metroComboBox1.Text));
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCCY_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                Modelo_Moeda mod_moeda = new Modelo_Moeda();
                mod_moeda.Nome1 = inptCurrency.Text;
                mod_moeda.Tipo1 = inputTipo.Text;
                mod_moeda.Valor1 = inputValor.Text;
                mod_moeda.Taxa1 = inputTaxa.Text;
                mod_moeda.Tempo1 = Convert.ToDateTime(inputData.Text);


                Validacao_Moeda validacao_moeda = new Validacao_Moeda(conexao);        
                validacao_moeda.SalvarMoeda(mod_moeda);


                MetroMessageBox.Show(this, "\n Moeda Cadastrado com sucesso ", "CADASTRO DE MOEDA",
                MessageBoxButtons.OK, MessageBoxIcon.Question);

                
              
             
            }
            catch (Exception eX)
            {
                MetroMessageBox.Show(this, "\n\n  Erro ao cadastrar uma Moeda! \n Detalhes: " + eX.Message,
                "ERRO AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
    }
}
