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
using Pim_2020.Modelo;
using Pim_2020.Negocio;
using Pim_2020.Utilidade;
using Pim_2020.Validacao;
using Pim_2020.Relatorio;
using System.Windows.Forms.DataVisualization.Charting;
using DocumentFormat.OpenXml.Presentation;

namespace Pim_2020.View
{
    public partial class Dashboard : MetroForm
    {
        Utilidade_conexao conexao = new Utilidade_conexao(Utilidade_DadosConexao.StringConexao);
        public int codigo = 0;
        private Modelo_Moeda modelo_Moeda;



        public Dashboard()
        {

            InitializeComponent();

        }

        private void metroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(metroGrid1.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validacao_Moeda valida = new Validacao_Moeda(conexao);
                metroGrid1.DataSource = valida.ListarMoeda(metroLabel1.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void CarregarMoedas(int codigo)
        {
            Validacao_Moeda valida_moeda = new Validacao_Moeda(conexao);
            metroGrid1.DataSource = valida_moeda.CarregarMoeda(codigo);
        }


        private void btnAddCurrency_Click_1(object sender, EventArgs e)
        {
            Form_Moeda f = new Form_Moeda();
            f.ShowDialog();
            f.Dispose();
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pim_2020DataSet1.Moeda' table. You can move, or remove it, as needed.
            this.moedaTableAdapter.Fill(this.pim_2020DataSet1.Moeda);
            SqlConnection conn = new SqlConnection("server = .\\SQLEXPRESS; Database = pim_2020; User Id = hederfelipe; Password = 816633");
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from Moeda", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            metroGrid1.DataSource = dt;

            btnShowTable_Click_1(sender, e);

            metroGrid1.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            metroGrid1.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            metroGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            metroGrid1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;


            metroGrid1.Columns["Codigo"].HeaderText = "Codigo";
            metroGrid1.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            metroGrid1.Columns["Nome"].HeaderText = "Nome";

            metroGrid1.Columns["Tipo"].HeaderText = "Tipo";

            metroGrid1.Columns["Valor"].HeaderText = "Valor";

            metroGrid1.Columns["Tempo"].HeaderText = "Tempo";

            metroGrid1.Columns["Taxa"].HeaderText = "Taxa";

            metroGrid1.Columns["fk_Whatlist_Codigo"].Visible = false;
            metroGrid1.Columns["fk_Exchangers_Codigo"].Visible = false;




            //metodo para desabilitas/ocultar outras colunas


            graHistorico.Series[0] = new System.Windows.Forms.DataVisualization.Charting.Series();
            graHistorico.Series[0].XValueMember = metroGrid1.Columns["Nome"].DataPropertyName;
            graHistorico.Series[0].YValueMembers = metroGrid1.Columns["Taxa"].DataPropertyName;
            graHistorico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            graHistorico.Series[0].BorderWidth = 4;
            graHistorico.Series[0].Color = Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2);
            graHistorico.Series[0].Name = "Taxas";
            graHistorico.DataSource = metroGrid1.DataSource;

            graHistorico.Series[1] = new System.Windows.Forms.DataVisualization.Charting.Series();
            graHistorico.Series[1].XValueMember = metroGrid1.Columns["Nome"].DataPropertyName;
            graHistorico.Series[1].YValueMembers = metroGrid1.Columns["Valor"].DataPropertyName;
            graHistorico.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            graHistorico.Series[1].BorderWidth = 4;
            graHistorico.Series[1].Name = "Valor";
            graHistorico.DataSource = metroGrid1.DataSource;

        }
    

        

        private void btnShowTable_Click_1(object sender, EventArgs e)
        {
            try
            {
                Validacao_Moeda valida = new Validacao_Moeda(conexao);
                metroGrid1.DataSource = valida.ListarMoeda(metroLabel1.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       

        private void comboBoxCurrency_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validacao_Moeda valida = new Validacao_Moeda(conexao);
                metroGrid1.DataSource = valida.ListarMoeda(metroLabel1.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Comprar f = new Form_Comprar();
            f.ShowDialog();
            f.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Vender f = new Form_Vender();
            f.ShowDialog();
            f.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
