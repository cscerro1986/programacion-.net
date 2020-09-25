using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_Nro_28;

namespace Ejercicio_Nro_28_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string texto = string.Empty;
        private Dictionary<string, int> dic = new Dictionary<string, int>();

        private void button1_Click(object sender, EventArgs e)
        {
            texto = RTBpalabras.Text;
            List<string> listaDePalabras = DiccionarioDePalabras.DeStringAListaDePalabras(texto);

            List<string> listaDepurada = DiccionarioDePalabras.BorrarPuntos(listaDePalabras);

            foreach (string item in listaDepurada)
            {
                DiccionarioDePalabras.AgregarOSumarPalabra(dic, item);
            }
            int cantidad = 0;

            List<KeyValuePair<string, int>> lista = dic.ToList();
            
            MessageBox.Show(cantidad.ToString());
            
        }
    }


}
