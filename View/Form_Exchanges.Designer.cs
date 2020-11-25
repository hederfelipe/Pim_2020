namespace Pim_2020.View
{
    partial class Form_Exchanges
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mlNome = new MetroFramework.Controls.MetroLabel();
            this.mlCodigo = new MetroFramework.Controls.MetroLabel();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonVoltar = new System.Windows.Forms.Button();
            this.BotonPesquisar = new System.Windows.Forms.Button();
            this.BotonGravar = new System.Windows.Forms.Button();
            this.BotonNovo = new System.Windows.Forms.Button();
            this.BotonExcluir = new System.Windows.Forms.Button();
            this.inputCode = new System.Windows.Forms.TextBox();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pim2020DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pim_2020DataSet = new Pim_2020.pim_2020DataSet1();
            this.exchangersTableAdapter = new Pim_2020.pim_2020DataSet1TableAdapters.ExchangersTableAdapter();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.exchangersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.codigoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.exchangersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pim2020DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pim_2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // mlNome
            // 
            this.mlNome.AutoSize = true;
            this.mlNome.Location = new System.Drawing.Point(471, 174);
            this.mlNome.Name = "mlNome";
            this.mlNome.Size = new System.Drawing.Size(46, 19);
            this.mlNome.Style = MetroFramework.MetroColorStyle.Blue;
            this.mlNome.TabIndex = 163;
            this.mlNome.Text = "Nome";
            this.mlNome.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mlCodigo
            // 
            this.mlCodigo.AutoSize = true;
            this.mlCodigo.Location = new System.Drawing.Point(141, 128);
            this.mlCodigo.Name = "mlCodigo";
            this.mlCodigo.Size = new System.Drawing.Size(53, 19);
            this.mlCodigo.Style = MetroFramework.MetroColorStyle.Blue;
            this.mlCodigo.TabIndex = 162;
            this.mlCodigo.Text = "Código";
            this.mlCodigo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.BotonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BotonCancelar.Location = new System.Drawing.Point(401, 78);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(91, 27);
            this.BotonCancelar.TabIndex = 176;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = false;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonVoltar
            // 
            this.BotonVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.BotonVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVoltar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BotonVoltar.Location = new System.Drawing.Point(524, 78);
            this.BotonVoltar.Name = "BotonVoltar";
            this.BotonVoltar.Size = new System.Drawing.Size(91, 27);
            this.BotonVoltar.TabIndex = 175;
            this.BotonVoltar.Text = "Sair";
            this.BotonVoltar.UseVisualStyleBackColor = false;
            this.BotonVoltar.Click += new System.EventHandler(this.BotonVoltar_Click);
            // 
            // BotonPesquisar
            // 
            this.BotonPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.BotonPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPesquisar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BotonPesquisar.Location = new System.Drawing.Point(280, 78);
            this.BotonPesquisar.Name = "BotonPesquisar";
            this.BotonPesquisar.Size = new System.Drawing.Size(91, 27);
            this.BotonPesquisar.TabIndex = 174;
            this.BotonPesquisar.Text = "Pesquisar";
            this.BotonPesquisar.UseVisualStyleBackColor = false;
            this.BotonPesquisar.Click += new System.EventHandler(this.BotonPesquisar_Click);
            // 
            // BotonGravar
            // 
            this.BotonGravar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.BotonGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonGravar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BotonGravar.Location = new System.Drawing.Point(154, 78);
            this.BotonGravar.Name = "BotonGravar";
            this.BotonGravar.Size = new System.Drawing.Size(91, 27);
            this.BotonGravar.TabIndex = 172;
            this.BotonGravar.Text = "Gravar";
            this.BotonGravar.UseVisualStyleBackColor = false;
            this.BotonGravar.Click += new System.EventHandler(this.BotonGravar_Click);
            // 
            // BotonNovo
            // 
            this.BotonNovo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.BotonNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonNovo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BotonNovo.Location = new System.Drawing.Point(23, 78);
            this.BotonNovo.Name = "BotonNovo";
            this.BotonNovo.Size = new System.Drawing.Size(91, 27);
            this.BotonNovo.TabIndex = 171;
            this.BotonNovo.Text = "Novo";
            this.BotonNovo.UseVisualStyleBackColor = false;
            this.BotonNovo.Click += new System.EventHandler(this.BotonNovo_Click);
            // 
            // BotonExcluir
            // 
            this.BotonExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonExcluir.BackColor = System.Drawing.Color.Crimson;
            this.BotonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonExcluir.ForeColor = System.Drawing.Color.Transparent;
            this.BotonExcluir.Location = new System.Drawing.Point(648, 78);
            this.BotonExcluir.Name = "BotonExcluir";
            this.BotonExcluir.Size = new System.Drawing.Size(89, 27);
            this.BotonExcluir.TabIndex = 170;
            this.BotonExcluir.Text = "Excluir";
            this.BotonExcluir.UseVisualStyleBackColor = false;
            this.BotonExcluir.Click += new System.EventHandler(this.BotonExcluir_Click);
            // 
            // inputCode
            // 
            this.inputCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.inputCode.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.inputCode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inputCode.Location = new System.Drawing.Point(23, 128);
            this.inputCode.Name = "inputCode";
            this.inputCode.Size = new System.Drawing.Size(112, 24);
            this.inputCode.TabIndex = 177;
            this.inputCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputNome
            // 
            this.inputNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.inputNome.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.inputNome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inputNome.Location = new System.Drawing.Point(23, 169);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(442, 24);
            this.inputNome.TabIndex = 178;
            this.inputNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputNome.Leave += new System.EventHandler(this.inputNome_Leave);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exchangersBindingSource
            // 
            this.exchangersBindingSource.DataMember = "Exchangers";
            this.exchangersBindingSource.DataSource = this.pim2020DataSetBindingSource;
            // 
            // pim2020DataSetBindingSource
            // 
            this.pim2020DataSetBindingSource.DataSource = this.pim_2020DataSet;
            this.pim2020DataSetBindingSource.Position = 0;
            // 
            // pim_2020DataSet
            // 
            this.pim_2020DataSet.DataSetName = "pim_2020DataSet";
            this.pim_2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exchangersTableAdapter
            // 
            this.exchangersTableAdapter.ClearBeforeFill = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.exchangersBindingSource1;
            this.metroComboBox1.DisplayMember = "Nome";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(606, 164);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(131, 29);
            this.metroComboBox1.TabIndex = 183;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "Codigo";
            // 
            // exchangersBindingSource1
            // 
            this.exchangersBindingSource1.DataMember = "Exchangers";
            this.exchangersBindingSource1.DataSource = this.pim2020DataSetBindingSource;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn1});
            this.metroGrid1.DataSource = this.exchangersBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(2, 230);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(767, 283);
            this.metroGrid1.TabIndex = 184;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // codigoDataGridViewTextBoxColumn1
            // 
            this.codigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.Name = "codigoDataGridViewTextBoxColumn1";
            this.codigoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn1.Width = 300;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.Width = 500;
            // 
            // exchangersBindingSource2
            // 
            this.exchangersBindingSource2.DataMember = "Exchangers";
            this.exchangersBindingSource2.DataSource = this.pim2020DataSetBindingSource;
            // 
            // Form_Exchanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 515);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.inputCode);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonVoltar);
            this.Controls.Add(this.BotonPesquisar);
            this.Controls.Add(this.BotonGravar);
            this.Controls.Add(this.BotonNovo);
            this.Controls.Add(this.BotonExcluir);
            this.Controls.Add(this.mlNome);
            this.Controls.Add(this.mlCodigo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Exchanges";
            this.Text = "Cadastro de Exchanges";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form_Exchanges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exchangersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pim2020DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pim_2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel mlNome;
        private MetroFramework.Controls.MetroLabel mlCodigo;
        public System.Windows.Forms.Button BotonCancelar;
        public System.Windows.Forms.Button BotonVoltar;
        public System.Windows.Forms.Button BotonPesquisar;
        public System.Windows.Forms.Button BotonGravar;
        public System.Windows.Forms.Button BotonNovo;
        public System.Windows.Forms.Button BotonExcluir;
        private System.Windows.Forms.TextBox inputCode;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.BindingSource pim2020DataSetBindingSource;
        private pim_2020DataSet1 pim_2020DataSet;
        private System.Windows.Forms.BindingSource exchangersBindingSource;
        private pim_2020DataSet1TableAdapters.ExchangersTableAdapter exchangersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.BindingSource exchangersBindingSource1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource exchangersBindingSource2;
    }
}