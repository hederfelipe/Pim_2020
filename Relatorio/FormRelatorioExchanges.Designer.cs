namespace Pim_2020.Relatorio
{
    partial class FormRelatorioExchanges
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
            this.pim_2020DataSet = new Pim_2020.pim_2020DataSet1();
            this.exchangersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exchangersTableAdapter = new Pim_2020.pim_2020DataSet1TableAdapters.ExchangersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pim_2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.exchangersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pim_2020.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // pim_2020DataSet
            // 
            this.pim_2020DataSet.DataSetName = "pim_2020DataSet";
            this.pim_2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exchangersBindingSource
            // 
            this.exchangersBindingSource.DataMember = "Exchangers";
            this.exchangersBindingSource.DataSource = this.pim_2020DataSet;
            // 
            // exchangersTableAdapter
            // 
            this.exchangersTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorioExchanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelatorioExchanges";
            this.Text = "FormRelatorioExchanges";
            this.Load += new System.EventHandler(this.FormRelatorioExchanges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pim_2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private pim_2020DataSet1 pim_2020DataSet;
        private System.Windows.Forms.BindingSource exchangersBindingSource;
        private pim_2020DataSet1TableAdapters.ExchangersTableAdapter exchangersTableAdapter;
    }
}