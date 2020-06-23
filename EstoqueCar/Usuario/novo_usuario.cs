using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace EstoqueCar
{
    public partial class novo_usuario : Form
    {
        public novo_usuario()
        {
            InitializeComponent();
        }

     
        private void textBoxUsuario_Enter(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "Usuário")
            {
                textBoxUsuario.Text = "";
            }
        }

        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                textBoxUsuario.Text = "Usuário";
            }
        }


        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Email")
            {
                textBoxEmail.Text = "";
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Email";
            }
        }
        private void textBoxSenha_Enter(object sender, EventArgs e)
        {
            if (textBoxSenha.Text == "Senha")
            {
                textBoxSenha.Text = "";
                textBoxSenha.PasswordChar = '*';
            }
        }

        char s;
        private void textBoxSenha_Leave(object sender, EventArgs e)
        {
            if (textBoxSenha.Text == "")
            {
                textBoxSenha.Text = "Senha";
                textBoxSenha.PasswordChar = s;
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void maskedTextBoxData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
                
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ControleTotal.mdf;Integrated Security=True;Connect Timeout=30");

            string sql = "INSERT INTO CadastroUsuario(id, usuario, email, dataNasc, senha) VALUES (@id, @usuario, @email, @dataNasc, @senha)";
            Random numeroID = new Random();
            numeroID.Next();

            try
            {
                SqlCommand c = new SqlCommand(sql, conexao);


                c.Parameters.Add(new SqlParameter("@id", numeroID.Next()));
                c.Parameters.Add(new SqlParameter("@usuario", this.textBoxUsuario.Text));
                c.Parameters.Add(new SqlParameter("@email", this.textBoxEmail.Text));
                c.Parameters.Add(new SqlParameter("@dataNasc", this.maskedTextBoxData.Text));
                c.Parameters.Add(new SqlParameter("@senha", this.textBoxSenha.Text));


                conexao.Open();

                c.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Usuário cadastrado!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
        }
    }
}