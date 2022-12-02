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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
                
        }

        private void pictureBox19_Click_1(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 ui458 = new Form3();
            ui458.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 ui154 = new Form2();
            ui154.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 ui1523 = new Form5();
            ui1523.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
