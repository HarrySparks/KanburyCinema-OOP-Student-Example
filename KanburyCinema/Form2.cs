using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanburyCinema
{
    public partial class Form2 : Form
    {
        bool usernamechange = false;
        bool passwordchange = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength >= 8)
            {
                label3.Text = "";
                usernamechange = true;
            }
            else
            {
                label3.Text = "# Username too short #";
                usernamechange = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.TextLength >= 8)
            {
                label4.Text = "";
                passwordchange = true;
            }
            else
            {
                label4.Text = "# Password too short #";
                passwordchange = false;
            }
        }

        private void openForm1()
        {
            new Form1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernamechange && passwordchange)
            {
                openForm1();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
