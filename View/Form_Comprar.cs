using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Pim_2020.Cotacao;
using Pim_2020.Modelo;
using Pim_2020.Utilidade;
using Pim_2020.Validacao;

namespace Pim_2020.View
{
    public partial class Form_Comprar : MetroForm

    {
        private Utilidade_conexao conexao = new Utilidade_conexao(Utilidade_DadosConexao.StringConexao);
        private string usuario, operacao;
        public Form_Comprar()
        {
            InitializeComponent();
        }

        private void Form_Comprar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pim_2020DataSet.Conta_Carteira' table. You can move, or remove it, as needed.
            this.conta_CarteiraTableAdapter.Fill(this.pim_2020DataSet.Conta_Carteira);
            // TODO: This line of code loads data into the 'pim_2020DataSet.Moeda' table. You can move, or remove it, as needed.
            this.moedaTableAdapter.Fill(this.pim_2020DataSet.Moeda);
            cbMoedas.SelectedIndex = 0;

            this.moedaTableAdapter.Fill(this.pim_2020DataSet.Moeda);
           


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            double M = 0;
            double Q = 0;
            double I = 0;
            double T = 0;

            try
            {
                M = Convert.ToDouble(txtQuantidade.Text);
                Q = Convert.ToDouble(txtQuant.Text);
                

                // N = Convert.ToDouble(txtDiasAtraso.Text);
                if ( Q >= 1)
                {
                    T = Q * M;
                }
                
                metroTotal.Text = T.ToString();
                
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n\n  Os valores não foram inseridos corretamente \n Detalhes: " + ex.Message,
                "ERRO AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroTotal.Focus();
            }
            


        }



        private void cbFormaPagamento_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbFormaPagamento.SelectedIndex != -1)
            {

                //Podemos obter o linha seleccionada com a propriedade SeletedItem                 
                DataRowView drw = ((DataRowView)cbFormaPagamento.SelectedItem);
                txtQuantidade.Text = drw["Valor"].ToString();
                int posTraco = cbFormaPagamento.Text.IndexOf(" –");




            }
            else
            {
                txtQuantidade.Text = "";
              

            }
            // if (cbFormaPagamento.SelectedIndex > -1)
            //  {
            //     txtQuantidade.Text = "R$: " + (cbFormaPagamento.SelectedValue.ToString());

            //  }
        }

        private void cbMoedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                string codigoMoeda = "";

            // Pega posição do caracter ( -) que separa o código da descrição da moeda
            int posTraco = cbMoedas.Text.IndexOf(" –");

            // Caso a posição for maior que -1, atribui o valor a variável codigoMoeda
            if (posTraco > -1)
                codigoMoeda = cbMoedas.Text.Substring(0, posTraco);

            try
            {
                // Chama o webservice para retornar o valor
                FachadaWSSGSClient ws = new FachadaWSSGSClient();

                // Através do código da moeda, atribui a variável valorCotacao o resultado da busca
                var valorCotacao = ws.getUltimosValoresSerieVO(Convert.ToInt32(codigoMoeda), 1).valores[0].svalor;

                // Mostrar no txtValor o resultado
                txtValorPago.Text =  valorCotacao;
            }
            catch (Exception)
            {
                // Caso aconteça alguma excessão, mostra valor zerado
                txtValorPago.Text = "R$ 0.00";
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            double M = 0;
            double Q = 0;
            double T = 0;
            try
            {
                M = Convert.ToDouble(txtValorPago.Text);
                Q = Convert.ToDouble(txtQuantidade.Text);
               
                if (Q >= 1)
                {
                    T = Q / M;
                }

                metroTextBox1.Text = T.ToString();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n\n  Os valores não foram inseridos corretamente \n Detalhes: " + ex.Message,
                "ERRO AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroTotal.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "\n\n Realmente sair?",
              "Volte Sempre", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCompra_Click(object sender, EventArgs e)
        {        

            try
            {
              
                conexao.AbrirConexao();
                Modelo_Conta_Carteira mod_saldo = new Modelo_Conta_Carteira();
                mod_saldo.ValorCompra1 = Convert.ToDouble(metroTotal.Text);
               
               
                Validacao_Carteira validacao_usuario = new Validacao_Carteira(conexao);

                DialogResult resultado = MetroMessageBox.Show(this, "\n\n Deseja realmente efetuar a compra?",
                "CONFIRMAR A Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (resultado.ToString() == "Yes")    
                {

                    validacao_usuario.SalvarCarteira(mod_saldo);
                    MetroMessageBox.Show(this, "\n Compra efetuada com sucesso ", "SALDO ATUALIZADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                   
                }
              
              
            }
            catch (Exception eX)
            {
                MetroMessageBox.Show(this, "\n\n  Erro ao efetuar compra! \n Detalhes: " + eX.Message,
                "ERRO AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }

        }
    }
}
        

       

    

