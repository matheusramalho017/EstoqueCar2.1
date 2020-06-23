using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EstoqueCar
{
    public partial class cadastro_produto : Form
    {
        public cadastro_produto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProduto_Enter(object sender, EventArgs e)
        {
            if (textBoxProduto.Text == "Nome do Produto")
            {
                textBoxProduto.Text = "";
            }
        }

        private void textBoxProduto_Leave(object sender, EventArgs e)
        {
            if (textBoxProduto.Text == "")
            {
                textBoxProduto.Text = "Nome do Produto";
            }
        }

        private void textBoxModelo_Enter(object sender, EventArgs e)
        {
            if (textBoxModelo.Text == "Modelo")
            {
                textBoxModelo.Text = "";
            }
        }

        private void textBoxModelo_Leave(object sender, EventArgs e)
        {
            if (textBoxModelo.Text == "")
            {
                textBoxModelo.Text = "Modelo";
            }
        }

        private void textBoxMarca_Enter(object sender, EventArgs e)
        {
            if (textBoxMarca.Text == "Marca")
            {
                textBoxMarca.Text = "";
            }
        }

        private void textBoxMarca_Leave(object sender, EventArgs e)
        {
            if (textBoxMarca.Text == "")
            {
                textBoxMarca.Text = "Marca";
            }
        }

        private void textBoxItem_Enter(object sender, EventArgs e)
        {
            if (textBoxItem.Text == "N° Item")
            {
                textBoxItem.Text = "";
            }
        }

        private void textBoxItem_Leave(object sender, EventArgs e)
        {
            if (textBoxItem.Text == "")
            {
                textBoxItem.Text = "N° Item";
            }
        }

        private void textBoxCod_Enter(object sender, EventArgs e)
        {
            if (textBoxCod.Text == "Código Item")
            {
                textBoxCod.Text = "";
            }
        }

        private void textBoxCod_Leave(object sender, EventArgs e)
        {
            if (textBoxCod.Text == "")
            {
                textBoxCod.Text = "Código Item";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxCatg_Enter(object sender, EventArgs e)
        {
            if (textBoxCatg.Text == "Categoria")
            {
                textBoxCatg.Text = "";
            }
        }

        private void textBoxCatg_Leave(object sender, EventArgs e)
        {
            if (textBoxCatg.Text == "")
            {
                textBoxCatg.Text = "Categoria";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ControleTotal.mdf;Integrated Security=True;Connect Timeout=30");

            string sql = "INSERT INTO CadastroProduto(id, nome, modelo, marca, categoria, numeroItem, codigoItem) VALUES (@id, @nome, @modelo, @marca, @categoria, @numeroItem, @codigoItem)";
            Random numeroID = new Random();
            numeroID.Next();

            try
            {
                SqlCommand c = new SqlCommand(sql, conexao);


                c.Parameters.Add(new SqlParameter("@id", numeroID.Next()));
                c.Parameters.Add(new SqlParameter("@nome", this.textBoxProduto.Text));
                c.Parameters.Add(new SqlParameter("@modelo", this.textBoxModelo.Text));
                c.Parameters.Add(new SqlParameter("@marca", this.textBoxMarca.Text));
                c.Parameters.Add(new SqlParameter("@categoria", this.textBoxCatg.Text));
                c.Parameters.Add(new SqlParameter("@numeroItem", this.textBoxItem.Text));
                c.Parameters.Add(new SqlParameter("@codigoItem", this.textBoxCod.Text));


                conexao.Open();

                c.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Produto cadastrado!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
        }
            private void comboBoxPrateleira_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        }
    }

