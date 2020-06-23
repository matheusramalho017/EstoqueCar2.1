using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueCar
{
    public partial class ControleDados : Form
    {
        public ControleDados()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ControleDados_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controleProdutos.CadastroProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroProdutoTableAdapter.Fill(this.controleProdutos.CadastroProduto);

        }
    }
}
