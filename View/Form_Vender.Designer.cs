namespace Pim_2020.View
{
    partial class Form_Vender
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.contaCarteiraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pim_2020DataSet11 = new Pim_2020.pim_2020DataSet1();
            this.btnCompra = new System.Windows.Forms.Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtQuant = new MetroFramework.Controls.MetroTextBox();
            this.metroTotal = new MetroFramework.Controls.MetroTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.mlValorPago = new MetroFramework.Controls.MetroLabel();
            this.cbMoedas = new MetroFramework.Controls.MetroComboBox();
            this.cbFormaPagamento = new MetroFramework.Controls.MetroComboBox();
            this.contaCarteiraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtValorPago = new MetroFramework.Controls.MetroTextBox();
            this.txtQuantidade = new MetroFramework.Controls.MetroTextBox();
            this.conta_CarteiraTableAdapter = new Pim_2020.pim_2020DataSet1TableAdapters.Conta_CarteiraTableAdapter();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroListView2 = new MetroFramework.Controls.MetroListView();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaCarteiraBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.contaCarteiraBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.exchangersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exchangersTableAdapter = new Pim_2020.pim_2020DataSet1TableAdapters.ExchangersTableAdapter();
            this.contaCarteiraBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contaCarteiraBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVendaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pim_2020DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(843, 41);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 19);
            this.metroLabel6.TabIndex = 127;
            this.metroLabel6.Text = "Saldo Atual";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // contaCarteiraBindingSource1
            // 
            this.contaCarteiraBindingSource1.DataMember = "Conta_Carteira";
            this.contaCarteiraBindingSource1.DataSource = this.pim_2020DataSet11;
            // 
            // pim_2020DataSet11
            // 
            this.pim_2020DataSet11.DataSetName = "pim_2020DataSet1";
            this.pim_2020DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCompra
            // 
            this.btnCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.Color.Transparent;
            this.btnCompra.Location = new System.Drawing.Point(4, 366);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(308, 35);
            this.btnCompra.TabIndex = 125;
            this.btnCompra.Text = "Realizar Venda";
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click_1);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(36, 145);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 19);
            this.metroLabel3.TabIndex = 122;
            this.metroLabel3.Text = "Valor  da moeda ";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "Total"};
            this.metroTextBox1.Location = new System.Drawing.Point(457, 194);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(174, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.TabIndex = 120;
            this.metroTextBox1.Text = "Total";
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(547, 240);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(84, 25);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 119;
            this.metroButton2.Text = "Converter";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 198);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(134, 19);
            this.metroLabel2.TabIndex = 118;
            this.metroLabel2.Text = "Quantidade desejada";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtQuant
            // 
            // 
            // 
            // 
            this.txtQuant.CustomButton.Image = null;
            this.txtQuant.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtQuant.CustomButton.Name = "";
            this.txtQuant.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuant.CustomButton.TabIndex = 1;
            this.txtQuant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuant.CustomButton.UseSelectable = true;
            this.txtQuant.CustomButton.Visible = false;
            this.txtQuant.Lines = new string[0];
            this.txtQuant.Location = new System.Drawing.Point(153, 194);
            this.txtQuant.MaxLength = 32767;
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.PasswordChar = '\0';
            this.txtQuant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuant.SelectedText = "";
            this.txtQuant.SelectionLength = 0;
            this.txtQuant.SelectionStart = 0;
            this.txtQuant.ShortcutsEnabled = true;
            this.txtQuant.Size = new System.Drawing.Size(149, 23);
            this.txtQuant.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuant.TabIndex = 117;
            this.txtQuant.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtQuant.UseSelectable = true;
            this.txtQuant.UseStyleColors = true;
            this.txtQuant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTotal
            // 
            // 
            // 
            // 
            this.metroTotal.CustomButton.Image = null;
            this.metroTotal.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.metroTotal.CustomButton.Name = "";
            this.metroTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTotal.CustomButton.TabIndex = 1;
            this.metroTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTotal.CustomButton.UseSelectable = true;
            this.metroTotal.CustomButton.Visible = false;
            this.metroTotal.Lines = new string[] {
        "Total"};
            this.metroTotal.Location = new System.Drawing.Point(151, 240);
            this.metroTotal.MaxLength = 32767;
            this.metroTotal.Name = "metroTotal";
            this.metroTotal.PasswordChar = '\0';
            this.metroTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTotal.SelectedText = "";
            this.metroTotal.SelectionLength = 0;
            this.metroTotal.SelectionStart = 0;
            this.metroTotal.ShortcutsEnabled = true;
            this.metroTotal.Size = new System.Drawing.Size(151, 23);
            this.metroTotal.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTotal.TabIndex = 116;
            this.metroTotal.Text = "Total";
            this.metroTotal.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTotal.UseSelectable = true;
            this.metroTotal.UseStyleColors = true;
            this.metroTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(760, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 32);
            this.button2.TabIndex = 115;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(230, 288);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(72, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 114;
            this.metroButton1.Text = "Calcular";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // mlValorPago
            // 
            this.mlValorPago.AutoSize = true;
            this.mlValorPago.Location = new System.Drawing.Point(340, 145);
            this.mlValorPago.Name = "mlValorPago";
            this.mlValorPago.Size = new System.Drawing.Size(111, 19);
            this.mlValorPago.TabIndex = 113;
            this.mlValorPago.Text = "Valor  da moeda ";
            this.mlValorPago.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbMoedas
            // 
            this.cbMoedas.FormattingEnabled = true;
            this.cbMoedas.ItemHeight = 23;
            this.cbMoedas.Items.AddRange(new object[] {
            "1 – Dólar (venda)",
            "10813 – Dólar (compra)",
            "21619 – Euro (venda)",
            "21620 – Euro (compra)",
            "21621 – Iene (venda)",
            "21622 – Iene (compra)",
            "21623 – Libra esterlina (venda)",
            "21624 – Libra esterlina (compra)",
            "21625 – Franco Suíço (venda)",
            "21626 – Franco Suíço (compra)",
            "21627 – Coroa Dinamarquesa (venda)",
            "21628 – Coroa Dinamarquesa (compra)",
            "21629 – Coroa Norueguesa (venda)",
            "21630 – Coroa Norueguesa (compra)",
            "21631 – Coroa Sueca (venda)",
            "21632 – Coroa Sueca (compra)",
            "21633 – Dólar Australiano (venda)",
            "21634 – Dólar Australiano (compra)",
            "21635 – Dólar Canadense (venda)",
            "21636 – Dólar Canadense (compra)"});
            this.cbMoedas.Location = new System.Drawing.Point(457, 77);
            this.cbMoedas.Name = "cbMoedas";
            this.cbMoedas.Size = new System.Drawing.Size(174, 29);
            this.cbMoedas.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbMoedas.TabIndex = 111;
            this.cbMoedas.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbMoedas.UseSelectable = true;
            this.cbMoedas.UseStyleColors = true;
            this.cbMoedas.SelectedIndexChanged += new System.EventHandler(this.cbMoedas_SelectedIndexChanged_1);
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.DataSource = this.contaCarteiraBindingSource;
            this.cbFormaPagamento.DisplayMember = "ValorCompra";
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.ItemHeight = 23;
            this.cbFormaPagamento.Location = new System.Drawing.Point(151, 77);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(151, 29);
            this.cbFormaPagamento.TabIndex = 110;
            this.cbFormaPagamento.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbFormaPagamento.UseSelectable = true;
            this.cbFormaPagamento.ValueMember = "Codigo";
            this.cbFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cbFormaPagamento_SelectedIndexChanged);
            // 
            // contaCarteiraBindingSource
            // 
            this.contaCarteiraBindingSource.DataMember = "Conta_Carteira";
            this.contaCarteiraBindingSource.DataSource = this.pim_2020DataSet11;
            // 
            // txtValorPago
            // 
            // 
            // 
            // 
            this.txtValorPago.CustomButton.Image = null;
            this.txtValorPago.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtValorPago.CustomButton.Name = "";
            this.txtValorPago.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValorPago.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorPago.CustomButton.TabIndex = 1;
            this.txtValorPago.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorPago.CustomButton.UseSelectable = true;
            this.txtValorPago.CustomButton.Visible = false;
            this.txtValorPago.Lines = new string[0];
            this.txtValorPago.Location = new System.Drawing.Point(457, 141);
            this.txtValorPago.MaxLength = 32767;
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.PasswordChar = '\0';
            this.txtValorPago.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorPago.SelectedText = "";
            this.txtValorPago.SelectionLength = 0;
            this.txtValorPago.SelectionStart = 0;
            this.txtValorPago.ShortcutsEnabled = true;
            this.txtValorPago.Size = new System.Drawing.Size(174, 23);
            this.txtValorPago.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorPago.TabIndex = 109;
            this.txtValorPago.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtValorPago.UseSelectable = true;
            this.txtValorPago.UseStyleColors = true;
            this.txtValorPago.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorPago.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtQuantidade
            // 
            // 
            // 
            // 
            this.txtQuantidade.CustomButton.Image = null;
            this.txtQuantidade.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtQuantidade.CustomButton.Name = "";
            this.txtQuantidade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantidade.CustomButton.TabIndex = 1;
            this.txtQuantidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantidade.CustomButton.UseSelectable = true;
            this.txtQuantidade.CustomButton.Visible = false;
            this.txtQuantidade.Lines = new string[0];
            this.txtQuantidade.Location = new System.Drawing.Point(153, 141);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.SelectionLength = 0;
            this.txtQuantidade.SelectionStart = 0;
            this.txtQuantidade.ShortcutsEnabled = true;
            this.txtQuantidade.Size = new System.Drawing.Size(149, 23);
            this.txtQuantidade.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantidade.TabIndex = 108;
            this.txtQuantidade.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtQuantidade.UseSelectable = true;
            this.txtQuantidade.UseStyleColors = true;
            this.txtQuantidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // conta_CarteiraTableAdapter
            // 
            this.conta_CarteiraTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(86, 87);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 19);
            this.metroLabel7.TabIndex = 128;
            this.metroLabel7.Text = " Moeda ";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(340, 87);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(112, 19);
            this.metroLabel8.TabIndex = 129;
            this.metroLabel8.Text = " Moeda Desejada";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(340, 198);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 19);
            this.metroLabel1.TabIndex = 130;
            this.metroLabel1.Text = "Valor  Convertido";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroListView2
            // 
            this.metroListView2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroListView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView2.FullRowSelect = true;
            this.metroListView2.Location = new System.Drawing.Point(4, 63);
            this.metroListView2.Name = "metroListView2";
            this.metroListView2.OwnerDraw = true;
            this.metroListView2.Size = new System.Drawing.Size(308, 297);
            this.metroListView2.TabIndex = 131;
            this.metroListView2.UseCompatibleStateImageBehavior = false;
            this.metroListView2.UseSelectable = true;
            // 
            // metroListView1
            // 
            this.metroListView1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(323, 63);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(318, 297);
            this.metroListView1.TabIndex = 132;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Codigo";
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // valorCompraDataGridViewTextBoxColumn
            // 
            this.valorCompraDataGridViewTextBoxColumn.DataPropertyName = "ValorCompra";
            this.valorCompraDataGridViewTextBoxColumn.HeaderText = "Compras realizadas";
            this.valorCompraDataGridViewTextBoxColumn.Name = "valorCompraDataGridViewTextBoxColumn";
            // 
            // valorVendaDataGridViewTextBoxColumn
            // 
            this.valorVendaDataGridViewTextBoxColumn.DataPropertyName = "ValorVenda";
            this.valorVendaDataGridViewTextBoxColumn.HeaderText = "Vendas realizadas";
            this.valorVendaDataGridViewTextBoxColumn.Name = "valorVendaDataGridViewTextBoxColumn";
            // 
            // contaCarteiraBindingSource5
            // 
            this.contaCarteiraBindingSource5.DataMember = "Conta_Carteira";
            this.contaCarteiraBindingSource5.DataSource = this.pim_2020DataSet11;
            // 
            // contaCarteiraBindingSource4
            // 
            this.contaCarteiraBindingSource4.DataMember = "Conta_Carteira";
            this.contaCarteiraBindingSource4.DataSource = this.pim_2020DataSet11;
            // 
            // exchangersBindingSource
            // 
            this.exchangersBindingSource.DataMember = "Exchangers";
            this.exchangersBindingSource.DataSource = this.pim_2020DataSet11;
            // 
            // exchangersTableAdapter
            // 
            this.exchangersTableAdapter.ClearBeforeFill = true;
            // 
            // contaCarteiraBindingSource2
            // 
            this.contaCarteiraBindingSource2.DataMember = "Conta_Carteira";
            this.contaCarteiraBindingSource2.DataSource = this.pim_2020DataSet11;
            // 
            // contaCarteiraBindingSource3
            // 
            this.contaCarteiraBindingSource3.DataMember = "Conta_Carteira";
            this.contaCarteiraBindingSource3.DataSource = this.pim_2020DataSet11;
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
            this.codigoDataGridViewTextBoxColumn,
            this.valorVendaDataGridViewTextBoxColumn1});
            this.metroGrid1.DataSource = this.contaCarteiraBindingSource3;
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
            this.metroGrid1.Location = new System.Drawing.Point(653, 67);
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
            this.metroGrid1.Size = new System.Drawing.Size(266, 293);
            this.metroGrid1.TabIndex = 133;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorVendaDataGridViewTextBoxColumn1
            // 
            this.valorVendaDataGridViewTextBoxColumn1.DataPropertyName = "ValorVenda";
            this.valorVendaDataGridViewTextBoxColumn1.HeaderText = "ValorVenda";
            this.valorVendaDataGridViewTextBoxColumn1.Name = "valorVendaDataGridViewTextBoxColumn1";
            this.valorVendaDataGridViewTextBoxColumn1.Width = 150;
            // 
            // Form_Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 424);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.metroTotal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.mlValorPago);
            this.Controls.Add(this.cbMoedas);
            this.Controls.Add(this.cbFormaPagamento);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.metroListView2);
            this.Controls.Add(this.metroListView1);
            this.Name = "Form_Vender";
            this.Text = "Vendas";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form_Vender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pim_2020DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCarteiraBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel6;
        public System.Windows.Forms.Button btnCompra;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtQuant;
        private MetroFramework.Controls.MetroTextBox metroTotal;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel mlValorPago;
        private MetroFramework.Controls.MetroComboBox cbMoedas;
        private MetroFramework.Controls.MetroComboBox cbFormaPagamento;
        private MetroFramework.Controls.MetroTextBox txtValorPago;
        private MetroFramework.Controls.MetroTextBox txtQuantidade;
        private System.Windows.Forms.BindingSource contaCarteiraBindingSource;
        private pim_2020DataSet1TableAdapters.Conta_CarteiraTableAdapter conta_CarteiraTableAdapter;
        private pim_2020DataSet1 pim_2020DataSet11;
        private System.Windows.Forms.BindingSource contaCarteiraBindingSource1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroListView metroListView2;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.BindingSource exchangersBindingSource;
        private pim_2020DataSet1TableAdapters.ExchangersTableAdapter exchangersTableAdapter;
        private System.Windows.Forms.BindingSource contaCarteiraBindingSource4;
        private System.Windows.Forms.BindingSource contaCarteiraBindingSource2;
        private System.Windows.Forms.BindingSource contaCarteiraBindingSource3;
        private System.Windows.Forms.BindingSource contaCarteiraBindingSource5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVendaDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVendaDataGridViewTextBoxColumn1;
    }
}