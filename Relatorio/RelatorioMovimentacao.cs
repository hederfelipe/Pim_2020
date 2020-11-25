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
    public partial class RelatorioMovimentacao : Form
    {
        public RelatorioMovimentacao()
        {
            InitializeComponent();
            this.Controls.Add(this.reportViewer1);
        }

        private void RelatorioMovimentacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pim_2020DataSet11.Conta_Carteira' table. You can move, or remove it, as needed.
            this.conta_CarteiraTableAdapter.Fill(this.pim_2020DataSet11.Conta_Carteira);
           
            this.reportViewer1.RefreshReport();
        }


    }
}
