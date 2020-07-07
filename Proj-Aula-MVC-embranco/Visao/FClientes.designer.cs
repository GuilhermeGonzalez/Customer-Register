namespace Proj_Aula_BD.Visao
{
    partial class FClientes
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGeraRelatorio = new System.Windows.Forms.Button();
            this.cbrelatorio = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dgvCol_Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_dtNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_cidcod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPesquisar = new System.Windows.Forms.Button();
            this.tbPesqNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bExcluir = new System.Windows.Forms.Button();
            this.bAlterar = new System.Windows.Forms.Button();
            this.lOperacao = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bNovo = new System.Windows.Forms.Button();
            this.bSalvar = new System.Windows.Forms.Button();
            this.cbCidades = new System.Windows.Forms.ComboBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGeraRelatorio);
            this.tabPage3.Controls.Add(this.cbrelatorio);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(584, 317);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Relatórios";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGeraRelatorio
            // 
            this.btnGeraRelatorio.Location = new System.Drawing.Point(238, 6);
            this.btnGeraRelatorio.Name = "btnGeraRelatorio";
            this.btnGeraRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btnGeraRelatorio.TabIndex = 3;
            this.btnGeraRelatorio.Text = "Gerar Relatório";
            this.btnGeraRelatorio.UseVisualStyleBackColor = true;
            // 
            // cbrelatorio
            // 
            this.cbrelatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrelatorio.FormattingEnabled = true;
            this.cbrelatorio.Items.AddRange(new object[] {
            "Relatório de Todos os Clientes",
            "Relatório de Clientes Agrupados por Cidade"});
            this.cbrelatorio.Location = new System.Drawing.Point(111, 8);
            this.cbrelatorio.Name = "cbrelatorio";
            this.cbrelatorio.Size = new System.Drawing.Size(121, 21);
            this.cbrelatorio.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Escolha o relatório:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvClientes);
            this.tabPage2.Controls.Add(this.bPesquisar);
            this.tabPage2.Controls.Add(this.tbPesqNome);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_Cod,
            this.dgvCol_Nome,
            this.dgvCol_dtNasc,
            this.dgvCol_CPF,
            this.dgvCol_Fone,
            this.dgvCol_email,
            this.dgvCol_cidcod,
            this.cod_cid});
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvClientes.Location = new System.Drawing.Point(3, 59);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(578, 255);
            this.dgvClientes.TabIndex = 61;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // dgvCol_Cod
            // 
            this.dgvCol_Cod.DataPropertyName = "codigo";
            this.dgvCol_Cod.HeaderText = "Código";
            this.dgvCol_Cod.MinimumWidth = 6;
            this.dgvCol_Cod.Name = "dgvCol_Cod";
            this.dgvCol_Cod.ReadOnly = true;
            this.dgvCol_Cod.Width = 70;
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
            // dgvCol_CPF
            // 
            this.dgvCol_CPF.DataPropertyName = "cpf";
            this.dgvCol_CPF.HeaderText = "CPF";
            this.dgvCol_CPF.MinimumWidth = 6;
            this.dgvCol_CPF.Name = "dgvCol_CPF";
            this.dgvCol_CPF.ReadOnly = true;
            this.dgvCol_CPF.Width = 90;
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
            // dgvCol_email
            // 
            this.dgvCol_email.DataPropertyName = "email";
            this.dgvCol_email.HeaderText = "email";
            this.dgvCol_email.MinimumWidth = 6;
            this.dgvCol_email.Name = "dgvCol_email";
            this.dgvCol_email.ReadOnly = true;
            this.dgvCol_email.Width = 125;
            // 
            // dgvCol_cidcod
            // 
            this.dgvCol_cidcod.DataPropertyName = "Cidade";
            this.dgvCol_cidcod.HeaderText = "Cidade";
            this.dgvCol_cidcod.MinimumWidth = 6;
            this.dgvCol_cidcod.Name = "dgvCol_cidcod";
            this.dgvCol_cidcod.ReadOnly = true;
            this.dgvCol_cidcod.Width = 70;
            // 
            // cod_cid
            // 
            this.cod_cid.DataPropertyName = "cod_cid";
            this.cod_cid.HeaderText = "CodigoCidade";
            this.cod_cid.MinimumWidth = 6;
            this.cod_cid.Name = "cod_cid";
            this.cod_cid.ReadOnly = true;
            this.cod_cid.Visible = false;
            this.cod_cid.Width = 125;
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
            this.tabPage1.Controls.Add(this.dtpNascimento);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.cbCidades);
            this.tabPage1.Controls.Add(this.tbemail);
            this.tabPage1.Controls.Add(this.tbCPF);
            this.tabPage1.Controls.Add(this.tbTelefone);
            this.tabPage1.Controls.Add(this.tbNome);
            this.tabPage1.Controls.Add(this.tbCodigo);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Enabled = false;
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(21, 74);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(108, 20);
            this.dtpNascimento.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bExcluir);
            this.panel1.Controls.Add(this.bAlterar);
            this.panel1.Controls.Add(this.lOperacao);
            this.panel1.Controls.Add(this.bCancelar);
            this.panel1.Controls.Add(this.bNovo);
            this.panel1.Controls.Add(this.bSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 41);
            this.panel1.TabIndex = 48;
            // 
            // bExcluir
            // 
            this.bExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExcluir.Image = global::Proj_Aula_BD.Properties.Resources.Ico_delete;
            this.bExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bExcluir.Location = new System.Drawing.Point(278, 11);
            this.bExcluir.Name = "bExcluir";
            this.bExcluir.Size = new System.Drawing.Size(89, 23);
            this.bExcluir.TabIndex = 61;
            this.bExcluir.Text = "Excluir";
            this.bExcluir.UseVisualStyleBackColor = true;
            this.bExcluir.Click += new System.EventHandler(this.BExcluir_Click);
            // 
            // bAlterar
            // 
            this.bAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAlterar.Image = global::Proj_Aula_BD.Properties.Resources.item_edit;
            this.bAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAlterar.Location = new System.Drawing.Point(183, 11);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(89, 23);
            this.bAlterar.TabIndex = 60;
            this.bAlterar.Text = "Alterar";
            this.bAlterar.UseVisualStyleBackColor = true;
            this.bAlterar.Click += new System.EventHandler(this.BAlterar_Click);
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
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Image = global::Proj_Aula_BD.Properties.Resources.i_voltar;
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelar.Location = new System.Drawing.Point(477, 11);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(96, 23);
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
            this.bNovo.Location = new System.Drawing.Point(95, 11);
            this.bNovo.Name = "bNovo";
            this.bNovo.Size = new System.Drawing.Size(82, 23);
            this.bNovo.TabIndex = 9;
            this.bNovo.Text = "Novo";
            this.bNovo.UseVisualStyleBackColor = true;
            this.bNovo.Click += new System.EventHandler(this.BNovo_Click_1);
            // 
            // bSalvar
            // 
            this.bSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalvar.Image = global::Proj_Aula_BD.Properties.Resources.i_check;
            this.bSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSalvar.Location = new System.Drawing.Point(389, 11);
            this.bSalvar.Name = "bSalvar";
            this.bSalvar.Size = new System.Drawing.Size(82, 23);
            this.bSalvar.TabIndex = 10;
            this.bSalvar.Text = "Confirmar";
            this.bSalvar.UseVisualStyleBackColor = true;
            this.bSalvar.Click += new System.EventHandler(this.bSalvar_Click);
            // 
            // cbCidades
            // 
            this.cbCidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidades.Enabled = false;
            this.cbCidades.FormattingEnabled = true;
            this.cbCidades.Location = new System.Drawing.Point(248, 113);
            this.cbCidades.Name = "cbCidades";
            this.cbCidades.Size = new System.Drawing.Size(289, 21);
            this.cbCidades.TabIndex = 47;
            // 
            // tbemail
            // 
            this.tbemail.Enabled = false;
            this.tbemail.Location = new System.Drawing.Point(21, 114);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(203, 20);
            this.tbemail.TabIndex = 46;
            // 
            // tbCPF
            // 
            this.tbCPF.Enabled = false;
            this.tbCPF.Location = new System.Drawing.Point(156, 74);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(138, 20);
            this.tbCPF.TabIndex = 44;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Enabled = false;
            this.tbTelefone.Location = new System.Drawing.Point(316, 74);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(221, 20);
            this.tbTelefone.TabIndex = 45;
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Location = new System.Drawing.Point(122, 37);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(415, 20);
            this.tbNome.TabIndex = 42;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(21, 37);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(86, 20);
            this.tbCodigo.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Dt. Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nome do Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Código";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 343);
            this.tabControl1.TabIndex = 34;
            // 
            // FClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 343);
            this.Controls.Add(this.tabControl1);
            this.Name = "FClientes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGeraRelatorio;
        private System.Windows.Forms.ComboBox cbrelatorio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_dtNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_cidcod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cid;
        private System.Windows.Forms.Button bPesquisar;
        private System.Windows.Forms.TextBox tbPesqNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bExcluir;
        private System.Windows.Forms.Button bAlterar;
        private System.Windows.Forms.Label lOperacao;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bNovo;
        private System.Windows.Forms.Button bSalvar;
        public System.Windows.Forms.ComboBox cbCidades;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbNome;
        public System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}