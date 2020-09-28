using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_Nro_37;

namespace Ejercicio_Nro_40_Form
{
    public partial class FormMenu : Form
    {


        Centralita centralMenu;
        
        public FormMenu()
        {
            InitializeComponent();
            centralMenu = new Centralita("Santiago Central Telefonica");
        }


        
        private void GenerarLlamada_Click(object sender, EventArgs e)
        {
            FmrLlamador formLlamado = new FmrLlamador(centralMenu);
            formLlamado.ShowDialog();
        }

        private void FacturacionTotal_Click(object sender, EventArgs e)
        {
            FmrMostrar formMostrar = new FmrMostrar(centralMenu);
            formMostrar.TipoLlamadaAMostrar = Llamada.TipoLlamada.Todas;
            formMostrar.Show();

        }

        private void FacturacionLocal_Click(object sender, EventArgs e)
        {
            FmrMostrar formMostrar = new FmrMostrar(centralMenu);
            formMostrar.TipoLlamadaAMostrar = Llamada.TipoLlamada.Local;
            formMostrar.Show();

        }

        private void FacturacionProvincial_Click(object sender, EventArgs e)
        {
            FmrMostrar formMostrar = new FmrMostrar(centralMenu);
            formMostrar.TipoLlamadaAMostrar = Llamada.TipoLlamada.Provincial;
            formMostrar.Show();

        }

        private void Salir_Click(object sender, EventArgs e)
        {

        }



    }
}
