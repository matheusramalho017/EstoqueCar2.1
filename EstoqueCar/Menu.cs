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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastro_produto cadprod = new cadastro_produto();
            cadprod.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            consulta consul = new consulta();
            consul.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ControleDados iniciar = new ControleDados();
            iniciar.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
