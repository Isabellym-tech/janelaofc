using System.ComponentModel;
using System.Net.Mail;

namespace janelaofc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            string gmail = txtGmail.Text;

            if (nome != string.Empty && gmail != string.Empty && senha != string.Empty)
                listBox.Items.Add($" Nome: {txtNome.Text},  Email: {txtGmail.Text} Senha:  {txtSenha.Text}. ");
            else
                MessageBox.Show("Digite campo nome, senha, gmail validos");

            txtNome.Clear();
            txtNome.Focus();
            txtGmail.Clear();
            txtGmail.Focus();
            txtSenha.Clear();
            txtSenha.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }
    }
}
