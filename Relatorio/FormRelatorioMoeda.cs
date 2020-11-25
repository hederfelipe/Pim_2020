using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_2020.Relatorio
{
    public partial class FormRelatorioMoeda : Form
    {
        public FormRelatorioMoeda()
        {
            InitializeComponent();
        }

        private void FormRelatorioMoeda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pim_2020DataSet.Moeda' table. You can move, or remove it, as needed.
            this.moedaTableAdapter.Fill(this.pim_2020DataSet.Moeda);
            this.reportViewer1.RefreshReport();
        }
    }
}
