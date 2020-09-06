using Ejercicio_Nro_22;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Nro_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void btnBinarioADecimal_Click(object sender, EventArgs e)
        {
            NumeroBinario nb = new NumeroBinario(txtBinario.Text);
            txtDeBinarioADecimal.Text = (((NumeroDecimal)nb).GetNumero()).ToString();
        }

        private void btnDecimalABinario_Click(object sender, EventArgs e)
        {
            double numeroDecimal;
            if (double.TryParse(txtDecimal.Text, out numeroDecimal));
            {
                NumeroDecimal nd = new NumeroDecimal(numeroDecimal);
                txtDeDecimalABinario.Text = ((NumeroBinario)nd).GetNumero();
            }
        }

        private void txtBinario_Leave(object sender, EventArgs e)
        {
            NumeroBinario nb = new NumeroBinario(txtBinario.Text);


            if (((NumeroDecimal)nb).GetNumero()==-1)
            {
                txtBinario.Focus();
            }
        }
    }
}
