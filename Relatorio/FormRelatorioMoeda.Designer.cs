namespace Pim_2020.Relatorio
{
    partial class FormRelatorioMoeda
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pim_2020DataSet = new Pim_2020.pim_2020DataSet1();
            this.moedaTableAdapter = new Pim_2020.pim_2020DataSet1TableAdapters.MoedaTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MoedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pim_2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoedaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Moeda";
            this.bindingSource1.DataSource = this.pim_2020DataSet;
            // 
            // pim_2020DataSet
            // 
            this.pim_2020DataSet.DataSetName = "pim_2020DataSet";
            this.pim_2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moedaTableAdapter
            // 
            this.moedaTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MoedaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pim_2020.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(908, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // MoedaBindingSource
            // 
            this.MoedaBindingSource.DataMember = "Moeda";
            this.MoedaBindingSource.DataSource = this.pim_2020DataSet;
            // 
            // FormRelatorioMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelatorioMoeda";
            this.Text = "FormRelatorioMoeda";
            this.Load += new System.EventHandler(this.FormRelatorioMoeda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pim_2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoedaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private pim_2020DataSet1 pim_2020DataSet;
        private pim_2020DataSet1TableAdapters.MoedaTableAdapter moedaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MoedaBindingSource;
    }
}