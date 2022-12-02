

using System.Data.SqlClient;
using System.Windows.Forms;

namespace Latihan_Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //create connection
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-81AA6QEE\SQLEXPRESS02;Initial Catalog=latihan;Integrated Security=True");
            //create command
            SqlCommand cmd = new SqlCommand("select * from tb_login where username=@username and password=@password", con);
            //add parameter
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            //open connection
            con.Open();
            //create data reader and execute the command
            SqlDataReader dr = cmd.ExecuteReader();
            //read the data and store them in the list
            if (dr.Read())
            {
                MessageBox.Show("Login Berhasil");
                Form2 f1 = new Form2();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
            //close connection
            con.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}