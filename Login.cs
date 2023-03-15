using MySql.Data.MySqlClient;
using System.Data;
using WindowsFormsApp3;

namespace SistemaFrotaV3
{
    public partial class Login : Form
    {
        public conexao con = new conexao();

        public string id_on;

        Thread f1;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = con.getconexao();
            conexao.Open();
            string sql = "select id_usuario, nome_usuario,senha_usuario from tb_usuario where cnpj = @nome_usuario";
            MySqlCommand comando_1 = new MySqlCommand(sql, conexao);
            comando_1.Parameters.Clear();
            comando_1.Parameters.AddWithValue("@nome_usuario", text_login.Text);

            // comando_1.Parameters.Add("@senha_funcionario", MySqlDbType.Int32).Value = txtsenha_adm.Text;
            comando_1.CommandType = CommandType.Text;
            MySqlDataReader dr;
            dr = comando_1.ExecuteReader();
            dr.Read();

            try
            {
                if (dr.GetString(2) == text_senha.Text)
                {
                    id_on = dr.GetString(0);
                    MessageBox.Show("Foi");
                    //// MessageBox.Show(id_on);
                    this.Close();
                    f1 = new Thread(AbrirJan);
                    f1.SetApartmentState(ApartmentState.STA);
                    f1.Start(id_on);


                }
                else
                {
                    MessageBox.Show("Usuário ou Senha incorreto");
                }
            }
            catch (Exception ex)//caso de erro
            {
                MessageBox.Show("erro sistema", ex.Message);
            }
            conexao.Close();
        }
        private void AbrirJan(object obj)
        {/*id_on*/
            Application.Run(new Form1());
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}