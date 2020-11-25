namespace Pim_2020.View
{
    partial class Form_Moeda
    {
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
        private void Initializ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Moeda));
            this.label1 = new System.Windows.Forms.Label();
            this.inptCurrency = new System.Windows.Forms.TextBox();
            this.btnAddCCY = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input currency code";
            // 
            // inptCurrency
            // 
            this.inptCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inptCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.inptCurrency.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.inptCurrency.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inptCurrency.Location = new System.Drawing.Point(19, 46);
            this.inptCurrency.Name = "inptCurrency";
            this.inptCurrency.Size = new System.Drawing.Size(52, 24);
            this.inptCurrency.TabIndex = 1;
            this.inptCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddCCY
            // 
            this.btnAddCCY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCCY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnAddCCY.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCCY.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddCCY.Location = new System.Drawing.Point(84, 42);
            this.btnAddCCY.Name = "btnAddCCY";
            this.btnAddCCY.Size = new System.Drawing.Size(60, 31);
            this.btnAddCCY.TabIndex = 2;
            this.btnAddCCY.Text = "Add";
            this.btnAddCCY.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(32, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISO 4217 Standard";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 82);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddCCY);
            this.Controls.Add(this.inptCurrency);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inptCurrency;
        private System.Windows.Forms.Button btnAddCCY;
        private System.Windows.Forms.Label label2;

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
            this.label1 = new System.Windows.Forms.Label();
            this.inptCurrency = new System.Windows.Forms.TextBox();
            this.btnAddCCY = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputValor = new System.Windows.Forms.TextBox();
            this.inputTipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputTaxa = new System.Windows.Forms.TextBox();
            this.taxa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.inpuData = new System.Windows.Forms.TextBox();
            this.btnDeleteCurrency = new System.Windows.Forms.Button();
            this.pim_2020DataSet = new Pim_2020.pim_2020DataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.moedaTableAdapter = new Pim_2020.pim_2020DataSet1TableAdapters.MoedaTableAdapter();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.exchangersTableAdapter = new Pim_2020.pim_2020DataSet1TableAdapters.ExchangersTableAdapter();
            this.moedaExchangersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.moedaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.moedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moedaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.moedaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.moedaExchangersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moedaExchangersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.moedaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pim_2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaExchangersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaExchangersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaExchangersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(355, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informação de entrada de moeda";
            // 
            // inptCurrency
            // 
            this.inptCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inptCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.inptCurrency.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.inptCurrency.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inptCurrency.Location = new System.Drawing.Point(23, 63);
            this.inptCurrency.Name = "inptCurrency";
            this.inptCurrency.Size = new System.Drawing.Size(176, 24);
            this.inptCurrency.TabIndex = 1;
            this.inptCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inptCurrency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inptCurrency_KeyPress);
            // 
            // btnAddCCY
            // 
            this.btnAddCCY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCCY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnAddCCY.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCCY.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddCCY.Location = new System.Drawing.Point(23, 213);
            this.btnAddCCY.Name = "btnAddCCY";
            this.btnAddCCY.Size = new System.Drawing.Size(74, 31);
            this.btnAddCCY.TabIndex = 5;
            this.btnAddCCY.Text = "Add";
            this.btnAddCCY.UseVisualStyleBackColor = false;
            this.btnAddCCY.Click += new System.EventHandler(this.btnAddCCY_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(463, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISO 4217 Standard";
            // 
            // inputValor
            // 
            this.inputValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.inputValor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.inputValor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inputValor.Location = new System.Drawing.Point(23, 123);
            this.inputValor.Name = "inputValor";
            this.inputValor.Size = new System.Drawing.Size(176, 24);
            this.inputValor.TabIndex = 3;
            this.inputValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputTipo
            // 
            this.inputTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.inputTipo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.inputTipo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inputTipo.Location = new System.Drawing.Point(23, 93);
            this.inputTipo.Name = "inputTipo";
            this.inputTipo.Size = new System.Drawing.Size(176, 24);
            this.inputTipo.TabIndex = 2;
            this.inputTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(205, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(205, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(205, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor";
            // 
            // inputTaxa
            // 
            this.inputTaxa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputTaxa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.inputTaxa.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.inputTaxa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inputTaxa.Location = new System.Drawing.Point(23, 153);
            this.inputTaxa.Name = "inputTaxa";
            this.inputTaxa.Size = new System.Drawing.Size(176, 24);
            this.inputTaxa.TabIndex = 4;
            this.inputTaxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // taxa
            // 
            this.taxa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.taxa.AutoSize = true;
            this.taxa.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.taxa.Location = new System.Drawing.Point(206, 164);
            this.taxa.Name = "taxa";
            this.taxa.Size = new System.Drawing.Size(30, 14);
            this.taxa.TabIndex = 12;
            this.taxa.Text = "Taxa";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(725, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(205, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data";
            // 
            // inpuData
            // 
            this.inpuData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inpuData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.inpuData.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.inpuData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inpuData.Location = new System.Drawing.Point(23, 183);
            this.inpuData.Name = "inpuData";
            this.inpuData.Size = new System.Drawing.Size(176, 24);
            this.inpuData.TabIndex = 15;
            this.inpuData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeleteCurrency
            // 
            this.btnDeleteCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteCurrency.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCurrency.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteCurrency.Location = new System.Drawing.Point(590, 228);
            this.btnDeleteCurrency.Name = "btnDeleteCurrency";
            this.btnDeleteCurrency.Size = new System.Drawing.Size(126, 35);
            this.btnDeleteCurrency.TabIndex = 28;
            this.btnDeleteCurrency.Text = "Deletar Moeda";
            this.btnDeleteCurrency.UseVisualStyleBackColor = false;
            this.btnDeleteCurrency.Click += new System.EventHandler(this.btnDeleteCurrency_Click);
            // 
            // pim_2020DataSet
            // 
            this.pim_2020DataSet.DataSetName = "pim_2020DataSet";
            this.pim_2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(722, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 36);
            this.button2.TabIndex = 31;
            this.button2.Text = "Emitir Relatório";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // moedaTableAdapter
            // 
            this.moedaTableAdapter.ClearBeforeFill = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.moedaBindingSource3;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(262, 233);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(322, 29);
            this.metroComboBox1.TabIndex = 33;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "Codigo";
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // tempoDataGridViewTextBoxColumn
            // 
            this.tempoDataGridViewTextBoxColumn.DataPropertyName = "Tempo";
            this.tempoDataGridViewTextBoxColumn.HeaderText = "Validade";
            this.tempoDataGridViewTextBoxColumn.Name = "tempoDataGridViewTextBoxColumn";
            // 
            // taxaDataGridViewTextBoxColumn
            // 
            this.taxaDataGridViewTextBoxColumn.DataPropertyName = "Taxa";
            this.taxaDataGridViewTextBoxColumn.HeaderText = "Taxa";
            this.taxaDataGridViewTextBoxColumn.Name = "taxaDataGridViewTextBoxColumn";
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
            this.Tipo,
            this.Valor,
            this.Tempo,
            this.dataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn1});
            this.metroGrid1.DataSource = this.moedaBindingSource4;
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
            this.metroGrid1.Location = new System.Drawing.Point(18, 269);
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
            this.metroGrid1.Size = new System.Drawing.Size(830, 254);
            this.metroGrid1.TabIndex = 34;
            // 
            // exchangersTableAdapter
            // 
            this.exchangersTableAdapter.ClearBeforeFill = true;
            // 
            // moedaExchangersBindingSource1
            // 
            this.moedaExchangersBindingSource1.DataMember = "Moeda_Exchangers";
            this.moedaExchangersBindingSource1.DataSource = this.moedaBindingSource1;
            // 
            // moedaBindingSource1
            // 
            this.moedaBindingSource1.DataMember = "Moeda";
            this.moedaBindingSource1.DataSource = this.pim_2020DataSet;
            // 
            // moedaBindingSource3
            // 
            this.moedaBindingSource3.DataMember = "Moeda";
            this.moedaBindingSource3.DataSource = this.pim_2020DataSet;
            // 
            // moedaExchangersBindingSource
            // 
            this.moedaExchangersBindingSource.DataMember = "Moeda_Exchangers";
            this.moedaExchangersBindingSource.DataSource = this.moedaBindingSource3;
            // 
            // moedaExchangersBindingSource2
            // 
            this.moedaExchangersBindingSource2.DataMember = "Moeda_Exchangers";
            this.moedaExchangersBindingSource2.DataSource = this.moedaBindingSource1;
            // 
            // moedaBindingSource4
            // 
            this.moedaBindingSource4.DataMember = "Moeda";
            this.moedaBindingSource4.DataSource = this.pim_2020DataSet;
            // 
            // codigoDataGridViewTextBoxColumn1
            // 
            this.codigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.Name = "codigoDataGridViewTextBoxColumn1";
            this.codigoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 150;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Width = 150;
            // 
            // Tempo
            // 
            this.Tempo.DataPropertyName = "Tempo";
            this.Tempo.HeaderText = "Tempo";
            this.Tempo.Name = "Tempo";
            this.Tempo.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Taxa";
            this.dataGridViewTextBoxColumn1.HeaderText = "Taxa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // Form_Moeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 535);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDeleteCurrency);
            this.Controls.Add(this.inpuData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.taxa);
            this.Controls.Add(this.inputTaxa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputTipo);
            this.Controls.Add(this.inputValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddCCY);
            this.Controls.Add(this.inptCurrency);
            this.Controls.Add(this.label1);
            this.Name = "Form_Moeda";
            this.Text = "Cadastro de Moeda";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form_Moeda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pim_2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaExchangersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaExchangersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaExchangersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moedaBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputTaxa;
        private System.Windows.Forms.Label taxa;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox inputData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpuData;
        public System.Windows.Forms.Button btnDeleteCurrency;
        public System.Windows.Forms.Button button2;
        private pim_2020DataSet1 pim_2020DataSet;
        private pim_2020DataSet1TableAdapters.MoedaTableAdapter moedaTableAdapter;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private pim_2020DataSet1TableAdapters.ExchangersTableAdapter exchangersTableAdapter;
        private System.Windows.Forms.BindingSource moedaBindingSource3;
        private System.Windows.Forms.BindingSource moedaExchangersBindingSource2;
        private System.Windows.Forms.BindingSource moedaBindingSource1;
        private System.Windows.Forms.BindingSource moedaExchangersBindingSource1;
        private System.Windows.Forms.BindingSource moedaBindingSource;
        private System.Windows.Forms.BindingSource moedaBindingSource2;
        private System.Windows.Forms.BindingSource moedaExchangersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource moedaBindingSource4;
    }
}