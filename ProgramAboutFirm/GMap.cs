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
    public partial class GMap : Form
    {
        public GMap()
        {
            InitializeComponent();
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            string street = txt_street.Text;
            string coubtry = txt_country.Text;
            string city = txt_city.Text;
            string zip = txt_zip.Text;

            try
            {
                StringBuilder quaryaddress = new StringBuilder();
                quaryaddress.Append("http://maps.google.com/maps?q=");
                if (street != string.Empty)
                {
                    quaryaddress.Append(street + "," + "+");
                }
                if (city != string.Empty)
                {
                    quaryaddress.Append(city + "," + "+");
                }
                if (coubtry != string.Empty)
                {
                    quaryaddress.Append(coubtry + "," + "+");
                }
                if (zip != string.Empty)
                {
                    quaryaddress.Append(zip + "," + "+");
                }
                webBrowser1.Navigate(quaryaddress.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Error");
            }
           

        }
       
    }
}
