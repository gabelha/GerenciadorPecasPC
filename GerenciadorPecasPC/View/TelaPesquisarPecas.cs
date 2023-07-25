using GerenciadorPecasPC.Controler;
using GerenciadorPecasPC.Model;
using System;
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
    public partial class TelaPesquisarPecas : Form
    {
        public TelaPesquisarPecas()
        {
            InitializeComponent();
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(textBoxCodigo.Text);

            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.BuscaPecasCod();

            textBoxCodigo.Text = Pecas.Codigo.ToString();
            textBoxPecas.Text = Pecas.Peca;
            textBoxMarca.Text = Pecas.Marca;
            textBoxCapacidade.Text = Pecas.Capacidade;
        }
    }
}
