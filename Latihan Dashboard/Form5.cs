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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 ui21 = new Form2();
            ui21.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 ui24 = new Form3();
            ui24.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 ui28 = new Form4();
            ui28.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
