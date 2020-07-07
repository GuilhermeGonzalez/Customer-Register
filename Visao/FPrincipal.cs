using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proj_Aula_BD.Controle;

namespace Proj_Aula_BD.Visao
{
    public partial class FPrincipal : Form
    {

        public FPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControladoraCadastroTitular.obterInstancia().mostrarTelaCadastroTitular();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
