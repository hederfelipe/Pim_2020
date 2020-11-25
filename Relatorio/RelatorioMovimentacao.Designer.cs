namespace Pim_2020.Relatorio
{
    partial class RelatorioMovimentacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pim_2020DataSet11 = new Pim_2020.pim_2020DataSet1();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.conta_CarteiraTableAdapter = new Pim_2020.pim_2020DataSet1TableAdapters.Conta_CarteiraTableAdapter();
            this.contaCarteiraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contaCarteiraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pim_2020DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.contaCarteiraBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pim_2020.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // pim_2020DataSet11
            // 
            this.pim_2020DataSet11.DataSetName = "pim_2020DataSet1";
            this.pim_2020DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Conta_Carteira";
            this.bindingSource1.DataSource = this.pim_2020DataSet11;
            // 
            // conta_CarteiraTableAdapter
            // 
            this.conta_CarteiraTableAdapter.ClearBeforeFill = true;
            // 
            // contaCarteiraBindingSource
            // 
            this.contaCarteiraBindingSource.DataMember = "Conta_Carteira";
            this.contaCarteiraBindingSource.DataSource = this.pim_2020DataSet11;
            // 
            // contaCarteiraBindingSource1
            // 
            this.contaCarteiraBindingSource1.DataMember = "Conta_Carteira";
            this.contaCarteiraBindingSource1.DataSource = this.pim_2020DataSet11;
            // 
            // RelatorioMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioMovimentacao";
            this.Text = "RelatorioMovimentacao";
            this.Load += new System.EventHandler(this.RelatorioMovimentacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pim_2020DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private pim_2020DataSet1 pim_2020DataSet11;
        private System.Windows.Forms.BindingSource bindingSource1;
        private pim_2020DataSet1TableAdapters.Conta_CarteiraTableAdapter conta_CarteiraTableAdapter;
        private System.Windows.Forms.BindingSource contaCarteiraBindingSource;
        private System.Windows.Forms.BindingSource contaCarteiraBindingSource1;
    }
}