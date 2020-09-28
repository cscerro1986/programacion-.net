using Ejercicio_Nro_37;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Nro_40_Form
{
    public partial class FmrLlamador : Form
    {
        Centralita centralLlamador;
        int bandera = 0;

        public FmrLlamador(Centralita c)
        {
            
            InitializeComponent();
            this.centralLlamador = c;
            comboBox1.DataSource = Enum.GetValues(typeof(Provincial.Franja));

        }
        
        
        public Centralita CentralitaMenu
        {
            get
            {
                return centralLlamador;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bandera == 0)
                txtNumeroDestino.Text = "";

            txtNumeroDestino.Text += "1";
            bandera = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bandera == 0)
                txtNumeroDestino.Text = "";

            txtNumeroDestino.Text += "2";
            bandera = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bandera == 0)
                txtNumeroDestino.Text = "";

            txtNumeroDestino.Text += "3";
            bandera = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bandera == 0)
                txtNumeroDestino.Text = "";

            txtNumeroDestino.Text += "4";
            bandera = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bandera == 0)
                txtNumeroDestino.Text = "";

            txtNumeroDestino.Text += "5";
            bandera = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bandera == 0)
                txtNumeroDestino.Text = "";

            txtNumeroDestino.Text += "6";
            bandera = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (bandera == 0)
                txtNumeroDestino.Text = "";

            txtNumeroDestino.Text += "7";
            bandera = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bandera == 0)
                txtNumeroDestino.Text = "";

            txtNumeroDestino.Text += "8";
            bandera = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (bandera == 0)
                txtNumeroDestino.Text = "";

            txtNumeroDestino.Text += "9";
            bandera = 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (bandera == 0)
                txtNumeroDestino.Text = "";

            txtNumeroDestino.Text += "*";
            bandera = 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (bandera == 0)
                txtNumeroDestino.Text = "";

            txtNumeroDestino.Text += "0";
            bandera = 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (bandera == 0)
                txtNumeroDestino.Text = "";

            txtNumeroDestino.Text += "#";
            if(txtNumeroDestino.Text[0]=='#')
            {
                comboBox1.Enabled = true;
            }
            bandera = 1;
        }

        private void txtNumeroDestino_Enter(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Random rmDuracion = new Random();
            Random rmCosto = new Random();

            float duracion = (float)(rmDuracion.NextDouble() * (50 - 1) + 1);
            float costo = (float)(rmCosto.NextDouble() * (5.6 - 0.5) + 0.5);
            if (txtNumeroDestino.Text[0]=='#')
            {
                Provincial.Franja franjaAux;
                Enum.TryParse<Provincial.Franja>(comboBox1.SelectedValue.ToString(), out franjaAux);

                Provincial pAux = new Provincial(txtNroOrigen.Text, franjaAux , duracion, txtNumeroDestino.Text);
                centralLlamador.Llamadas.Add(pAux);
            }
            else
            {
                Local lAux = new Local(txtNroOrigen.Text, duracion, txtNumeroDestino.Text, costo);
                centralLlamador.Llamadas.Add(lAux);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text = "Numero de Destino";
            comboBox1.Enabled = false;
            bandera = 0;
        }
    }
}
