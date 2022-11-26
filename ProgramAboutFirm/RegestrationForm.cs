using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramAboutFirm
{
    public partial class RegestrationForm : Form
    {
        public String log = "Dima";
        public String password = "1234";
        bool vis = true;
        public RegestrationForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (vis)
            {
                textBox1.UseSystemPasswordChar = false;
                vis = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
                vis = true;
            }
        }

      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "admin" & textBox6.Text=="admin"& textBox4.Text=="admin@gmail.com")
            {


                AutorizationForm autorizationForm = new AutorizationForm();
                autorizationForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sorry but you didn't enter login and password right");
            }
            

        }

     
        private void button5_Click(object sender, EventArgs e)
        {
           
            textBox6.UseSystemPasswordChar = false;

            if (vis)
            {
                textBox6.UseSystemPasswordChar = false;
                vis = false;
            }
            else
            {
                textBox6.UseSystemPasswordChar = true;
                vis = true;
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.UseSystemPasswordChar = false;

            if (vis)
            {
                textBox6.UseSystemPasswordChar = false;
                vis = false;
            }
            else
            {
                textBox6.UseSystemPasswordChar = true;
                vis = true;
            }
        }

        private void RegestrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
