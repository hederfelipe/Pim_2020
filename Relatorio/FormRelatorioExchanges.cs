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
    public partial class FormRelatorioExchanges : Form
    {
        public FormRelatorioExchanges()
        {
            InitializeComponent();
        }

        private void FormRelatorioExchanges_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pim_2020DataSet.Exchangers' table. You can move, or remove it, as needed.
            this.exchangersTableAdapter.Fill(this.pim_2020DataSet.Exchangers);

            this.reportViewer1.RefreshReport();
        }
    }
}
