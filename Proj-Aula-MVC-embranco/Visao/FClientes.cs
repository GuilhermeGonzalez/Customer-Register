using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Proj_Aula_BD.Controle;


namespace Proj_Aula_BD.Visao
{
    public partial class FClientes : Form, IObservada
    {
        private List<IObservador> listaObservadores = new List<IObservador>();
        
        String acao = "N";
        

        public FClientes()
        {
            InitializeComponent();
        }

        private void habilitar(String acao)
        {
            
            tbCodigo.Enabled = "IA".IndexOf(acao) >= 0;
            tbNome.Enabled = "IA".IndexOf(acao) >= 0;
            tbCPF.Enabled = "IA".IndexOf(acao) >= 0;
            tbemail.Enabled = "IA".IndexOf(acao) >= 0;
            tbTelefone.Enabled = "IA".IndexOf(acao) >= 0;
            dtpNascimento.Enabled = "IA".IndexOf(acao) >= 0;
            cbCidades.Enabled = "IA".IndexOf(acao) >= 0;
            bNovo.Enabled = !("IAE".IndexOf(acao) >= 0);
            bAlterar.Enabled = !("IAE".IndexOf(acao) >= 0);
            bExcluir.Enabled = !("IAE".IndexOf(acao) >= 0);
            bSalvar.Enabled = "IAE".IndexOf(acao) >= 0;
            bCancelar.Enabled = "IAE".IndexOf(acao) >= 0;
        }


        private void BNovo_Click_1(object sender, EventArgs e)
        {
            acao = "I"; habilitar(acao);
            lOperacao.Text = "NOVO";
        }

        

        private void BAlterar_Click(object sender, EventArgs e)
        {
            acao = "A"; habilitar(acao);
            lOperacao.Text = "ALTERAR";
        }

        private void BExcluir_Click(object sender, EventArgs e)
        {
            acao = "E"; habilitar(acao);
            lOperacao.Text = "EXCLUIR";
        }

        private void bSalvar_Click(object sender, EventArgs e)
        {
            habilitar(acao); lOperacao.Text = "";
            notificarObservadores();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            acao = "N"; habilitar(acao);
            lOperacao.Text = "";
        }

        public void adicionarObservadores(IObservador observador)
        {
            listaObservadores.Add(observador);
        }

        public void notificarObservadores()
        {
            foreach(IObservador observador in listaObservadores)
            {
                if(acao == "P")
                {
                    observador.notificar(acao, tbPesqNome.Text);
                }
                else
                {
                    observador.notificar(acao, tbCodigo.Text,
                                               tbNome.Text,
                                               dtpNascimento.Value,
                                               tbTelefone.Text,
                                               tbCPF.Text,
                                               tbemail.Text,
                                               cbCidades.SelectedValue);
                }
            }
            acao = "N";
            tbCodigo.Text = "";
            tbNome.Text = "";
            tbTelefone.Text = "";
            tbCPF.Text = "";
            tbemail.Text = "";
            cbCidades.SelectedItem = "";
            habilitar(acao);
        }

        private void bPesquisar_Click(object sender, EventArgs e)
        {
            acao = "P";
            notificarObservadores();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvClientes.SelectedRows[0].IsNewRow)
            {
                DataGridViewRow linha = dgvClientes.SelectedRows[0];
                tbCodigo.Text = linha.Cells[0].Value.ToString();
                tbNome.Text = linha.Cells[1].Value.ToString();
                dtpNascimento.Value = (DateTime)linha.Cells[2].Value;
                tbCPF.Text = linha.Cells[3].Value.ToString();
                tbTelefone.Text = linha.Cells[4].Value.ToString();
                tbemail.Text = linha.Cells[5].Value.ToString();
                cbCidades.SelectedValue = linha.Cells[7].Value;
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
        }
    }
}
