﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorPecasPC.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarPecas telaCadastrar = new TelaCadastrarPecas();
            telaCadastrar.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisarPecas telaPesquisar = new TelaPesquisarPecas();
            telaPesquisar.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterarPecas telaAlterarPecas = new TelaAlterarPecas();
            telaAlterarPecas.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeletarPecas telaDeletarPecas = new TelaDeletarPecas();
            telaDeletarPecas.Show();
        }
    }
}
