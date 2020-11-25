using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Pim_2020.Relatorio;
using Pim_2020.View;

namespace Pim_2020
{
    public partial class FormPrincipal : MetroForm
    {

        FormLogin Login = new FormLogin();
        private string data = "Data : " + DateTime.Now.ToShortDateString();
        private string hora = "Hora : " + DateTime.Now.ToShortTimeString();
        Timer t = new Timer();
        public FormPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// metodo data 
        /// </summary>
        public void Data()
        {
            labelDatad.Text = data;
        }




        public void AutorizacaoUsuario()
        {
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;

        }
        private void CarregaUsuarioLogado()
        {
            LabelConectado.Text = FormLogin.usuario_logado;
        }
        

        private void botonSair_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "\n\n Realmente desejar sair do sistema ?",
               "Abondonar o sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void time_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second; string time = "";
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            metroLabelHora.Text = "Hora : " + time;
        }

        private void FormPrincipal_Load_1(object sender, EventArgs e)
        {
            CarregaUsuarioLogado();
            if (FormLogin.usuario_logado == "administrador")
            {
                AutorizacaoUsuario();
            }
            t.Interval = 1000;
            t.Tick += new EventHandler(this.time_Tick);
            t.Start();
            CarregaUsuarioLogado();
            Data();
        }



        private void metroLabel2_Click(object sender, EventArgs e)
        {
            Dashboard f = new Dashboard();
            f.ShowDialog();
            f.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Vender f = new Form_Vender();
            f.ShowDialog();
            f.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Comprar f = new Form_Comprar();
            f.ShowDialog();
            f.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRelatorios f = new FormRelatorios();
            f.ShowDialog();
            f.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Funcionario f = new Form_Funcionario();
            f.ShowDialog();
            f.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Usuario f = new Form_Usuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_Moeda f = new Form_Moeda();
            f.ShowDialog();
            f.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form_Exchanges f = new Form_Exchanges();
            f.ShowDialog();
            f.Dispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("POWERPNT.EXE");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start("OUTLOOK.EXE");
        }

        private void botonWord_Click(object sender, EventArgs e)
        {
            Process.Start("winword.exe");
        }

        private void botonExcell_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");

        }

    }
}
