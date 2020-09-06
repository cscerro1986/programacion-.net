using Billetes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Nro_23_Forms
{
    public partial class Form1 : Form
    {

        Euro auxEuro;
        Dolar auxDolar;
        Pesos auxPesos;



        public Form1()
        {
            InitializeComponent();
            txtCotizacionDolar.Text = (Dolar.GetCotizacion()).ToString();
            txtCotizacionEuro.Text = (Euro.GetCotizacion().ToString());
            txtCotizacionPeso.Text = (Pesos.GetCotizacion().ToString());
            


            
        }


        private void btnLockCotizaciones_Click(object sender, EventArgs e)
        {
            if(txtCotizacionDolar.Enabled==true)
            {
                btnBlockCotizacion.Image = imageList1.Images[0];
                txtCotizacionDolar.Enabled = false;
                txtCotizacionEuro.Enabled = false;
                txtCotizacionPeso.Enabled = false;
            }
            else
            {
                btnBlockCotizacion.Image = imageList1.Images[1];
                txtCotizacionDolar.Enabled = true;
                txtCotizacionEuro.Enabled = true;
                txtCotizacionPeso.Enabled = true;
            }


        }


        #region COTIZADORES
        private void TxtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            double aux;
            if(double.TryParse(txtCotizacionDolar.Text,out aux))
            {
                Dolar.SetCotizacion(aux);

            }
            else
            {
                txtCotizacionDolar.Focus();
            }

        }
        private void TxtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtCotizacionEuro.Text, out aux))
            {
                Euro.SetCotizacion(aux);


            }
            else
            {
                txtCotizacionEuro.Focus();
            }

        }

        private void TxtCotizacionPesos_Leave(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtCotizacionPeso.Text, out aux))
            {
                Pesos.SetCotizacion(aux);


            }
            else
            {
                txtCotizacionPeso.Focus();
            }
        }

        #endregion COTIZADORES


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }       

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtEuro.Text,out aux))
            {
                Euro euro1 = new Euro(aux);
                txtEuroAEuro.Text = (euro1.GetCantidad()).ToString("#,##0.##");
                txtEuroADolar.Text = ((Dolar)(euro1)).GetCantidad().ToString("#,##0.##");
                txtEuroAPeso.Text = ((Pesos)(euro1)).GetCantidad().ToString("#,##0.##");
            }

        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtDolar.Text, out aux))
            {
                Dolar dolar1 = new Dolar(aux);
                txtDolarADolar.Text = (dolar1.GetCantidad()).ToString("0.##");
                txtDolarAEuro.Text = ((Euro)(dolar1)).GetCantidad().ToString("0.##");
                txtDolarAPeso.Text = ((Pesos)(dolar1)).GetCantidad().ToString("0.##");
            }


        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtPeso.Text, out aux))
            {
                Pesos peso1 = new Pesos(aux);
                txtPesoAPeso.Text = (peso1.GetCantidad()).ToString("N", new CultureInfo("is-IS"));
                txtPesoADolar.Text = ((Dolar)(peso1)).GetCantidad().ToString("N", new CultureInfo("is-IS"));
                txtPesoAEuro.Text = ((Euro)(peso1)).GetCantidad().ToString("N", new CultureInfo("is-IS"));
            }



        }
    }
}
