using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ejercicio_Nro_21;

namespace Ejercicio_Nro_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void btnFarenheit(object sender, EventArgs e)
        {
            double aux;
            
            if(double.TryParse(txtFahrenheit.Text,out aux))
            {
                Fahrenheit fahernheir1 = new Fahrenheit(aux);
                txtFaF.Text = (fahernheir1.GetTemperatura()).ToString();
                txtFaC.Text = (((Celsius)fahernheir1).GetTemperatura()).ToString();
                txtFaK.Text = (((Kelvin)fahernheir1).GetTemperatura().ToString());
            }

        }

        private void btnCelcius_Click(object sender, EventArgs e)
        {
            double aux;

            if (double.TryParse(txtCelcius.Text, out aux))
            {
                Celsius celcius1 = new Celsius(aux);
                txtCaC.Text = (celcius1.GetTemperatura()).ToString();
                txtCaF.Text = (((Fahrenheit)celcius1).GetTemperatura()).ToString();
                txtCaK.Text = (((Kelvin)celcius1).GetTemperatura().ToString());
            }

        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            double aux;

            if (double.TryParse(txtKelvin.Text, out aux))
            {
                Kelvin kelvin1 = new Kelvin(aux);
                txtKaK.Text = (kelvin1.GetTemperatura()).ToString();
                txtKaF.Text = (((Fahrenheit)kelvin1).GetTemperatura()).ToString();
                txtKaC.Text = (((Celsius)kelvin1).GetTemperatura().ToString());
            }

        }
    }
}
