namespace Proj_Aula_BD.Visao
{
    partial class FTitular
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTitular = new System.Windows.Forms.DataGridView();
            this.dgvCol_CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_dtNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_cidcod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_plano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPesquisar = new System.Windows.Forms.Button();
            this.tbPesqNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpVini = new System.Windows.Forms.DateTimePicker();
            this.dtpVfim = new System.Windows.Forms.DateTimePicker();
            this.dtpData_Nasc = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bPesquisaTitular = new System.Windows.Forms.Button();
            this.bExcluir = new System.Windows.Forms.Button();
            this.bLimpaTela = new System.Windows.Forms.Button();
            this.lOperacao = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bNovo = new System.Windows.Forms.Button();
            this.bSalvar = new System.Windows.Forms.Button();
            this.cbModalidade = new System.Windows.Forms.ComboBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.visualizadorRel = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cbRelatorio = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitular)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTitular);
            this.tabPage2.Controls.Add(this.bPesquisar);
            this.tabPage2.Controls.Add(this.tbPesqNome);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(898, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTitular
            // 
            this.dgvTitular.AllowUserToAddRows = false;
            this.dgvTitular.AllowUserToDeleteRows = false;
            this.dgvTitular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_CPF,
            this.dgvCol_Nome,
            this.dgvCol_dtNasc,
            this.estadoCivil,
            this.dgvCol_email,
            this.dgvCol_Fone,
            this.celular,
            this.cidade,
            this.endereco,
            this.uf,
            this.sexo,
            this.dgvCol_cidcod,
            this.cod_plano});
            this.dgvTitular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTitular.Location = new System.Drawing.Point(3, 55);
            this.dgvTitular.Name = "dgvTitular";
            this.dgvTitular.ReadOnly = true;
            this.dgvTitular.RowHeadersWidth = 51;
            this.dgvTitular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTitular.Size = new System.Drawing.Size(892, 226);
            this.dgvTitular.TabIndex = 61;
            this.dgvTitular.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // dgvCol_CPF
            // 
            this.dgvCol_CPF.DataPropertyName = "cpf";
            this.dgvCol_CPF.HeaderText = "CPF";
            this.dgvCol_CPF.MinimumWidth = 6;
            this.dgvCol_CPF.Name = "dgvCol_CPF";
            this.dgvCol_CPF.ReadOnly = true;
            this.dgvCol_CPF.Width = 90;
            // 
            // dgvCol_Nome
            // 
            this.dgvCol_Nome.DataPropertyName = "nome";
            this.dgvCol_Nome.HeaderText = "Nome do Cliente";
            this.dgvCol_Nome.MinimumWidth = 6;
            this.dgvCol_Nome.Name = "dgvCol_Nome";
            this.dgvCol_Nome.ReadOnly = true;
            this.dgvCol_Nome.Width = 200;
            // 
            // dgvCol_dtNasc
            // 
            this.dgvCol_dtNasc.DataPropertyName = "dataNasc";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvCol_dtNasc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCol_dtNasc.HeaderText = "Nascimento";
            this.dgvCol_dtNasc.MinimumWidth = 6;
            this.dgvCol_dtNasc.Name = "dgvCol_dtNasc";
            this.dgvCol_dtNasc.ReadOnly = true;
            this.dgvCol_dtNasc.Width = 80;
            // 
            // estadoCivil
            // 
            this.estadoCivil.DataPropertyName = "estadoCivil";
            this.estadoCivil.HeaderText = "Estado Civil";
            this.estadoCivil.Name = "estadoCivil";
            this.estadoCivil.ReadOnly = true;
            // 
            // dgvCol_email
            // 
            this.dgvCol_email.DataPropertyName = "email";
            this.dgvCol_email.HeaderText = "Email";
            this.dgvCol_email.MinimumWidth = 6;
            this.dgvCol_email.Name = "dgvCol_email";
            this.dgvCol_email.ReadOnly = true;
            this.dgvCol_email.Width = 125;
            // 
            // dgvCol_Fone
            // 
            this.dgvCol_Fone.DataPropertyName = "telefone";
            this.dgvCol_Fone.HeaderText = "Telefone";
            this.dgvCol_Fone.MinimumWidth = 6;
            this.dgvCol_Fone.Name = "dgvCol_Fone";
            this.dgvCol_Fone.ReadOnly = true;
            this.dgvCol_Fone.Width = 90;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "Endereco";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            // 
            // uf
            // 
            this.uf.DataPropertyName = "uf";
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // dgvCol_cidcod
            // 
            this.dgvCol_cidcod.DataPropertyName = "planoSaude";
            this.dgvCol_cidcod.HeaderText = "Modalidade";
            this.dgvCol_cidcod.MinimumWidth = 6;
            this.dgvCol_cidcod.Name = "dgvCol_cidcod";
            this.dgvCol_cidcod.ReadOnly = true;
            this.dgvCol_cidcod.Width = 70;
            // 
            // cod_plano
            // 
            this.cod_plano.DataPropertyName = "cod_p";
            this.cod_plano.HeaderText = "CodigoPlano";
            this.cod_plano.MinimumWidth = 6;
            this.cod_plano.Name = "cod_plano";
            this.cod_plano.ReadOnly = true;
            this.cod_plano.Visible = false;
            this.cod_plano.Width = 125;
            // 
            // bPesquisar
            // 
            this.bPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPesquisar.Image = global::Proj_Aula_BD.Properties.Resources.i_check;
            this.bPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPesquisar.Location = new System.Drawing.Point(243, 26);
            this.bPesquisar.Name = "bPesquisar";
            this.bPesquisar.Size = new System.Drawing.Size(89, 23);
            this.bPesquisar.TabIndex = 60;
            this.bPesquisar.Text = "Pesquisar";
            this.bPesquisar.UseVisualStyleBackColor = true;
            this.bPesquisar.Click += new System.EventHandler(this.bPesquisar_Click);
            // 
            // tbPesqNome
            // 
            this.tbPesqNome.Location = new System.Drawing.Point(17, 29);
            this.tbPesqNome.Name = "tbPesqNome";
            this.tbPesqNome.Size = new System.Drawing.Size(216, 20);
            this.tbPesqNome.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Nome do Cliente";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpVini);
            this.tabPage1.Controls.Add(this.dtpVfim);
            this.tabPage1.Controls.Add(this.dtpData_Nasc);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbEstadoCivil);
            this.tabPage1.Controls.Add(this.cbSexo);
            this.tabPage1.Controls.Add(this.cbUF);
            this.tabPage1.Controls.Add(this.tbCidade);
            this.tabPage1.Controls.Add(this.tbEndereco);
            this.tabPage1.Controls.Add(this.tbCelular);
            this.tabPage1.Controls.Add(this.tbTelefone);
            this.tabPage1.Controls.Add(this.tbEmail);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.cbModalidade);
            this.tabPage1.Controls.Add(this.tbCPF);
            this.tabPage1.Controls.Add(this.tbNome);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(898, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpVini
            // 
            this.dtpVini.Enabled = false;
            this.dtpVini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVini.Location = new System.Drawing.Point(694, 162);
            this.dtpVini.Name = "dtpVini";
            this.dtpVini.Size = new System.Drawing.Size(93, 20);
            this.dtpVini.TabIndex = 73;
            // 
            // dtpVfim
            // 
            this.dtpVfim.Enabled = false;
            this.dtpVfim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVfim.Location = new System.Drawing.Point(793, 162);
            this.dtpVfim.Name = "dtpVfim";
            this.dtpVfim.Size = new System.Drawing.Size(95, 20);
            this.dtpVfim.TabIndex = 72;
            // 
            // dtpData_Nasc
            // 
            this.dtpData_Nasc.Enabled = false;
            this.dtpData_Nasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData_Nasc.Location = new System.Drawing.Point(502, 54);
            this.dtpData_Nasc.Name = "dtpData_Nasc";
            this.dtpData_Nasc.Size = new System.Drawing.Size(105, 20);
            this.dtpData_Nasc.TabIndex = 71;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 15);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(143, 18);
            this.label20.TabIndex = 69;
            this.label20.Text = "Dados do Cliente:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(499, 124);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(187, 18);
            this.label19.TabIndex = 68;
            this.label19.Text = "PLANO CONTRATADO:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(690, 144);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 13);
            this.label18.TabIndex = 67;
            this.label18.Text = "VIGENCIA INICIAL";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(792, 144);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(90, 13);
            this.label32.TabIndex = 66;
            this.label32.Text = "VIGENCIA FINAL";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(611, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 65;
            this.label16.Text = "ESTADO CIVIL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(730, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 64;
            this.label15.Text = "UF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(497, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 63;
            this.label14.Text = "CIDADE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(730, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 63;
            this.label13.Text = "SEXO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "ENDEREÇO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "Celular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "Informações para contato:";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCivil.Enabled = false;
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Viuvo",
            "Divorciado"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(614, 54);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(108, 21);
            this.cbEstadoCivil.TabIndex = 59;
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Enabled = false;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Nao declarar"});
            this.cbSexo.Location = new System.Drawing.Point(733, 54);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(145, 21);
            this.cbSexo.TabIndex = 58;
            // 
            // cbUF
            // 
            this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUF.Enabled = false;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "RO",
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.cbUF.Location = new System.Drawing.Point(733, 93);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(145, 21);
            this.cbUF.TabIndex = 57;
            // 
            // tbCidade
            // 
            this.tbCidade.Enabled = false;
            this.tbCidade.Location = new System.Drawing.Point(500, 95);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(222, 20);
            this.tbCidade.TabIndex = 56;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Enabled = false;
            this.tbEndereco.Location = new System.Drawing.Point(8, 95);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(462, 20);
            this.tbEndereco.TabIndex = 55;
            // 
            // tbCelular
            // 
            this.tbCelular.Enabled = false;
            this.tbCelular.Location = new System.Drawing.Point(353, 161);
            this.tbCelular.Margin = new System.Windows.Forms.Padding(2);
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(116, 20);
            this.tbCelular.TabIndex = 51;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Enabled = false;
            this.tbTelefone.Location = new System.Drawing.Point(233, 161);
            this.tbTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(116, 20);
            this.tbTelefone.TabIndex = 50;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(8, 161);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(216, 20);
            this.tbEmail.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bPesquisaTitular);
            this.panel1.Controls.Add(this.bExcluir);
            this.panel1.Controls.Add(this.bLimpaTela);
            this.panel1.Controls.Add(this.lOperacao);
            this.panel1.Controls.Add(this.bCancelar);
            this.panel1.Controls.Add(this.bNovo);
            this.panel1.Controls.Add(this.bSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 84);
            this.panel1.TabIndex = 48;
            // 
            // bPesquisaTitular
            // 
            this.bPesquisaTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPesquisaTitular.Image = global::Proj_Aula_BD.Properties.Resources.Ico_Mais;
            this.bPesquisaTitular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPesquisaTitular.Location = new System.Drawing.Point(281, 3);
            this.bPesquisaTitular.Name = "bPesquisaTitular";
            this.bPesquisaTitular.Size = new System.Drawing.Size(89, 77);
            this.bPesquisaTitular.TabIndex = 62;
            this.bPesquisaTitular.Text = "Pesquisa";
            this.bPesquisaTitular.UseVisualStyleBackColor = true;
            this.bPesquisaTitular.Click += new System.EventHandler(this.bPesquisaTitular_Click);
            // 
            // bExcluir
            // 
            this.bExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExcluir.Image = global::Proj_Aula_BD.Properties.Resources.Ico_delete;
            this.bExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bExcluir.Location = new System.Drawing.Point(91, 3);
            this.bExcluir.Name = "bExcluir";
            this.bExcluir.Size = new System.Drawing.Size(89, 77);
            this.bExcluir.TabIndex = 61;
            this.bExcluir.Text = "Excluir";
            this.bExcluir.UseVisualStyleBackColor = true;
            this.bExcluir.Click += new System.EventHandler(this.BExcluir_Click);
            // 
            // bLimpaTela
            // 
            this.bLimpaTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLimpaTela.Image = global::Proj_Aula_BD.Properties.Resources.item_edit;
            this.bLimpaTela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLimpaTela.Location = new System.Drawing.Point(186, 3);
            this.bLimpaTela.Name = "bLimpaTela";
            this.bLimpaTela.Size = new System.Drawing.Size(89, 77);
            this.bLimpaTela.TabIndex = 60;
            this.bLimpaTela.Text = "Alterar";
            this.bLimpaTela.UseVisualStyleBackColor = true;
            this.bLimpaTela.Click += new System.EventHandler(this.BAlterar_Click);
            // 
            // lOperacao
            // 
            this.lOperacao.AutoSize = true;
            this.lOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOperacao.Location = new System.Drawing.Point(18, 14);
            this.lOperacao.Name = "lOperacao";
            this.lOperacao.Size = new System.Drawing.Size(0, 17);
            this.lOperacao.TabIndex = 21;
            // 
            // bCancelar
            // 
            this.bCancelar.Enabled = false;
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Image = global::Proj_Aula_BD.Properties.Resources.i_voltar;
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelar.Location = new System.Drawing.Point(806, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(88, 77);
            this.bCancelar.TabIndex = 11;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bNovo
            // 
            this.bNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNovo.Image = global::Proj_Aula_BD.Properties.Resources.h_add;
            this.bNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNovo.Location = new System.Drawing.Point(3, 3);
            this.bNovo.Name = "bNovo";
            this.bNovo.Size = new System.Drawing.Size(82, 77);
            this.bNovo.TabIndex = 9;
            this.bNovo.Text = "Novo";
            this.bNovo.UseVisualStyleBackColor = true;
            this.bNovo.Click += new System.EventHandler(this.BNovo_Click_1);
            // 
            // bSalvar
            // 
            this.bSalvar.Enabled = false;
            this.bSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalvar.Image = global::Proj_Aula_BD.Properties.Resources.i_check;
            this.bSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSalvar.Location = new System.Drawing.Point(718, 4);
            this.bSalvar.Name = "bSalvar";
            this.bSalvar.Size = new System.Drawing.Size(82, 77);
            this.bSalvar.TabIndex = 10;
            this.bSalvar.Text = "Confirmar";
            this.bSalvar.UseVisualStyleBackColor = true;
            this.bSalvar.Click += new System.EventHandler(this.bSalvar_Click);
            // 
            // cbModalidade
            // 
            this.cbModalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModalidade.Enabled = false;
            this.cbModalidade.FormattingEnabled = true;
            this.cbModalidade.Location = new System.Drawing.Point(502, 161);
            this.cbModalidade.Name = "cbModalidade";
            this.cbModalidade.Size = new System.Drawing.Size(186, 21);
            this.cbModalidade.TabIndex = 47;
            this.cbModalidade.SelectionChangeCommitted += new System.EventHandler(this.cbModalidade_SelectionChangeCommitted);
            // 
            // tbCPF
            // 
            this.tbCPF.Enabled = false;
            this.tbCPF.Location = new System.Drawing.Point(8, 52);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(138, 20);
            this.tbCPF.TabIndex = 44;
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Location = new System.Drawing.Point(159, 54);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(311, 20);
            this.tbNome.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "MODALIDADE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Telefone Fixo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "DATA NASC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "NOME";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 63);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 310);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.visualizadorRel);
            this.tabPage3.Controls.Add(this.btnRelatorio);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.cbRelatorio);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(898, 284);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Relatório";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // visualizadorRel
            // 
            this.visualizadorRel.Location = new System.Drawing.Point(8, 50);
            this.visualizadorRel.Name = "visualizadorRel";
            this.visualizadorRel.ServerReport.BearerToken = null;
            this.visualizadorRel.Size = new System.Drawing.Size(880, 228);
            this.visualizadorRel.TabIndex = 3;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(354, 19);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btnRelatorio.TabIndex = 2;
            this.btnRelatorio.Text = "Gerar";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Escolha o Relatório:";
            // 
            // cbRelatorio
            // 
            this.cbRelatorio.FormattingEnabled = true;
            this.cbRelatorio.Items.AddRange(new object[] {
            "Relatório de clientes simples",
            "Relatório de clientes agrupados por plano de saúde"});
            this.cbRelatorio.Location = new System.Drawing.Point(128, 21);
            this.cbRelatorio.Name = "cbRelatorio";
            this.cbRelatorio.Size = new System.Drawing.Size(220, 21);
            this.cbRelatorio.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(179, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(548, 37);
            this.label9.TabIndex = 35;
            this.label9.Text = "H CARE - SEU PLANO DE SAÚDE";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(344, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Gerenciamento de Clientes";
            // 
            // FTitular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 375);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Name = "FTitular";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FTitular_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitular)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView dgvTitular;
        private System.Windows.Forms.Button bPesquisar;
        private System.Windows.Forms.TextBox tbPesqNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bExcluir;
        private System.Windows.Forms.Button bLimpaTela;
        private System.Windows.Forms.Label lOperacao;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bNovo;
        private System.Windows.Forms.Button bSalvar;
        public System.Windows.Forms.ComboBox cbModalidade;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button bPesquisaTitular;
        public System.Windows.Forms.ComboBox cbEstadoCivil;
        public System.Windows.Forms.ComboBox cbSexo;
        public System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpData_Nasc;
        public System.Windows.Forms.TextBox tbCPF;
        public System.Windows.Forms.DateTimePicker dtpVini;
        public System.Windows.Forms.DateTimePicker dtpVfim;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_dtNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_cidcod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_plano;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbRelatorio;
        public Microsoft.Reporting.WinForms.ReportViewer visualizadorRel;
    }
}