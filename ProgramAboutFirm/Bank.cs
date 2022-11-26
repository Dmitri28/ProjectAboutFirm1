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
    public partial class Bank : Form
    {
      
        public Bank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
            
                
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double a, b;
            a = double.Parse(textBox3.Text);
            b = double.Parse(textBox4.Text);
            double result = a / b;
            textBox5.Text = (" "+result);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GMap map = new GMap();
            map.Show();
            this.Hide();

        }

        internal string textBox1_TextChanged(string text)
        {
            throw new NotImplementedException();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show(textBox1.Text);
                
            }
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Bank_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double d, g;
            d = double.Parse(textBox6.Text);
            g = double.Parse(textBox7.Text);
            double resultat = d - g;
            textBox8.Text = (" " + resultat);
        }
    }
}
