using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_Dashboard
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 ui2 = new Form2();
            ui2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 ui453 = new Form4();
            ui453.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 ui404 = new Form5();
            ui404.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to leave?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Form1 ui1 = new Form1();
                ui1.Show();
                this.Close();
            }
            else
            {
                //Do something
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
