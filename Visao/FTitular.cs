using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Proj_Aula_BD.Controle;

namespace Proj_Aula_BD.Visao
{
    public partial class FTitular : Form, IObservada
    {
        private List<IObservador> listaObservadores = new List<IObservador>();
        
        string acao = "N";
        bool chave = false;


        public FTitular()
        {
            InitializeComponent();
        }

        private void habilitar(string acao)
        {
            
            tbCPF.Enabled = "IA".IndexOf(acao) >= 0;
            tbNome.Enabled = "IA".IndexOf(acao) >= 0;
            dtpData_Nasc.Enabled = "IA".IndexOf(acao) >= 0;
            cbEstadoCivil.Enabled = "IA".IndexOf(acao) >= 0;
            tbEmail.Enabled = "IA".IndexOf(acao) >= 0;
            tbTelefone.Enabled = "IA".IndexOf(acao) >= 0;
            tbCelular.Enabled = "IA".IndexOf(acao) >= 0;
            tbCidade.Enabled = "IA".IndexOf(acao) >= 0;
            tbEndereco.Enabled = "IA".IndexOf(acao) >= 0;
            cbUF.Enabled = "IA".IndexOf(acao) >= 0;
            cbSexo.Enabled = "IA".IndexOf(acao) >= 0;
            cbModalidade.Enabled = "IA".IndexOf(acao) >= 0;


            bNovo.Enabled = !("IAE".IndexOf(acao) >= 0);
            bLimpaTela.Enabled = !("IAE".IndexOf(acao) >= 0);
            bExcluir.Enabled = !("IAE".IndexOf(acao) >= 0);
            bPesquisaTitular.Enabled = !("IAE".IndexOf(acao) >= 0);
            bSalvar.Enabled = "IAE".IndexOf(acao) >= 0;
            bCancelar.Enabled = "IAE".IndexOf(acao) >= 0;
            
        }


        private void BNovo_Click_1(object sender, EventArgs e)
        {
            acao = "I"; habilitar(acao);
        }

        

        private void BAlterar_Click(object sender, EventArgs e)
        {
            acao = "A"; habilitar(acao);
        }

        private void BExcluir_Click(object sender, EventArgs e)
        {
            acao = "E"; habilitar(acao);
        }

        private void bSalvar_Click(object sender, EventArgs e)
        {
            chave = false;
            habilitar(acao);
            if(acao == "E")
            {
                DialogResult result = MessageBox.Show("Voce deseja realmente excluir?", "Exclusao", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                     notificarObservadores(); zerarInfoTela();
                }
            }
            else
            {
                notificarObservadores();
            }
            zerarInfoTela();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            acao = "N"; habilitar(acao);
        }

        public void adicionarObservadores(IObservador observador)
        {
            listaObservadores.Add(observador);
        }

        public void notificarObservadores()
        {
            foreach (IObservador observador in listaObservadores)
            {
                if (acao == "P")
                {
                    observador.notificar(acao, tbPesqNome.Text);
                }
                else
                {
                    // Estava SelectedItem nas comboBox
                    observador.notificar(acao, tbCPF.Text,
                                               tbNome.Text,
                                               dtpData_Nasc.Value,
                                               cbEstadoCivil.SelectedItem,
                                               tbEmail.Text,
                                               tbTelefone.Text,
                                               tbCelular.Text,
                                               tbCidade.Text,
                                               tbEndereco.Text,
                                               cbUF.SelectedItem,
                                               cbSexo.SelectedItem,
                                               cbModalidade.SelectedItem,chave);
                }

            }
            
        }   

        private void bPesquisar_Click(object sender, EventArgs e)
        {
            chave = false;
            acao = "P"; habilitar(acao);
            notificarObservadores();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvTitular.SelectedRows[0].IsNewRow)
            {
                
                DataGridViewRow linha = dgvTitular.SelectedRows[0];
                tbCPF.Text = linha.Cells[0].Value.ToString();
                tbNome.Text = linha.Cells[1].Value.ToString();
                dtpData_Nasc.Value = (DateTime)linha.Cells[2].Value;
                cbEstadoCivil.SelectedItem = linha.Cells[3].Value;
                tbEmail.Text = linha.Cells[4].Value.ToString();
                tbTelefone.Text = linha.Cells[5].Value.ToString();
                tbCelular.Text = linha.Cells[6].Value.ToString();
                tbCidade.Text = linha.Cells[7].Value.ToString();
                tbEndereco.Text = linha.Cells[8].Value.ToString();
                cbUF.SelectedItem = linha.Cells[9].Value.ToString();
                cbSexo.SelectedItem = linha.Cells[10].Value.ToString();
                cbModalidade.SelectedValue = linha.Cells[12].Value;
                tabControl1.SelectedTab = tabControl1.TabPages[0];
                
            }
        }
        

        

        private void bPesquisaTitular_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void zerarInfoTela()
        {
            acao = "N";
            tbCPF.Text = " ";
            tbNome.Text = " ";
            dtpData_Nasc.Text = DateTime.Today.ToString();
            dtpVini.Text = DateTime.Today.ToString();
            dtpVfim.Text = DateTime.Today.ToString();
            tbTelefone.Text = " ";
            tbCelular.Text = " ";
            tbEndereco.Text = " ";
            tbEmail.Text = " ";
            tbCidade.Text = " ";
            cbEstadoCivil.SelectedIndex = -1;
            cbSexo.SelectedIndex = -1;
            cbUF.SelectedIndex = -1;
            cbModalidade.SelectedIndex = -1;
            habilitar(acao);
        }

        private void cbModalidade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chave = true;
            notificarObservadores();
            //trocaVigencia(cbModalidade.SelectedValue);
        }

        private void FTitular_Load(object sender, EventArgs e)
        {

            this.visualizadorRel.RefreshReport();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            if (cbRelatorio.SelectedIndex == 0) //PRIMEIRA OÇÃO = RELATÓRIO DE CLIÊNTES
            {
                acao = "RTC";
                notificarObservadores();
            }
            else if (cbRelatorio.SelectedIndex == 1) //SEGUNDA OPÇÃO = RELATÓRIO DE CLIENTES AGRUPADOS POR CIDADE
            {
                acao = "RCA";
                notificarObservadores();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
