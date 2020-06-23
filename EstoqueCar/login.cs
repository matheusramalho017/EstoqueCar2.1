using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient; //namespace que contem as classes de BD SQL

namespace EstoqueCar
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            recup_senha formRec = new recup_senha();
            formRec.ShowDialog();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBoxSenha.Text == "Senha")
            {
                textBoxSenha.Text = "";
                textBoxSenha.PasswordChar = '*';

            }
        }

        char c;
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBoxSenha.Text == "")
            {
                textBoxSenha.Text = "Senha";
                textBoxSenha.PasswordChar = c;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBoxUsuario.Text == "Usuário")
            {
                textBoxUsuario.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBoxUsuario.Text == "")
            {
                textBoxUsuario.Text = "Usuário";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            novo_usuario novou = new novo_usuario();
            novou.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conecta = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ControleTotal.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection objconectar = new SqlConnection(conecta);
            objconectar.Open();

            string comPesquisa = "select count(*) from CadastroUsuario where usuario='" + textBoxUsuario.Text + "' and senha='" + textBoxSenha.Text + "' ";
           
            SqlCommand objcomando = new SqlCommand(comPesquisa, objconectar);
     

            int retorno = (int)objcomando.ExecuteScalar();
            if (retorno == 1)


                if (retorno == 1)
                {
                MessageBox.Show("Usuário Logado");
                Menu open = new Menu();
                open.ShowDialog();
            }
            else
                {
                    MessageBox.Show("Usuário não cadastrado");
                }
            objconectar.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
