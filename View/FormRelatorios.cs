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
using Pim_2020.Relatorio;

namespace Pim_2020.View
{
    public partial class FormRelatorios : MetroForm
    {
        public FormRelatorios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Relatorio_Usuario f = new Form_Relatorio_Usuario();
            f.ShowDialog();
            f.Dispose();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRelatorioFuncionario r = new FormRelatorioFuncionario();
            r.ShowDialog();
            r.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RelatorioMovimentacao f = new RelatorioMovimentacao();
            f.ShowDialog();
            f.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormRelatorioMoeda f = new FormRelatorioMoeda();
            f.ShowDialog();
            f.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormRelatorioExchanges f = new FormRelatorioExchanges();
            f.ShowDialog();
            f.Dispose();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            RelatorioMovimentacao f = new RelatorioMovimentacao();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
