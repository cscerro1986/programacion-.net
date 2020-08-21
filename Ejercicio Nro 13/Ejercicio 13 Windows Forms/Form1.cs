using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_Nro_13;

namespace Ejercicio_13_Windows_Forms
{
    public partial class Form1 : Form
    {
        int numeroDecimal;
        string numeroBinal;
        string numeroAux;


        public Form1()
        {
            InitializeComponent();

            

        }

        private void button2_ConvertirADecimal(object sender, EventArgs e)
        {
            
            numeroAux = textBox2BinarioADecimal.Text;
            numeroDecimal = Conversor.BinarioDecimal(numeroAux);
            textBox1DecimalABinario.Text = numeroDecimal.ToString();


        }

        private void button1_ConvertirABinario(object sender, EventArgs e)
        {

            numeroAux = textBox1DecimalABinario.Text;
            numeroBinal = Conversor.DecimalBinario(int.Parse(numeroAux));
            textBox2BinarioADecimal.Text = numeroBinal;

        }
    }
}
