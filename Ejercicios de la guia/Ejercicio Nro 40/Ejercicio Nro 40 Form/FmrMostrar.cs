using Ejercicio_Nro_37;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Nro_40_Form
{
    public partial class FmrMostrar : Form
    {
        Centralita centralitaMostrar;

        private Llamada.TipoLlamada tipoLlamadaAMostrar;

        public FmrMostrar(Centralita c)
        {
            centralitaMostrar = c;

            InitializeComponent();
        }
        
        public Llamada.TipoLlamada TipoLlamadaAMostrar
        {
            set
            {
                this.tipoLlamadaAMostrar = value;
            }
            get
            {
                return this.tipoLlamadaAMostrar;
            }
            
        }


        private void FormMostrar_Load(object sender, EventArgs e)
        {
            switch (this.TipoLlamadaAMostrar)
            {
                case Llamada.TipoLlamada.Todas:
                    richTextBox1.Text = centralitaMostrar.ToString();
                    break;

                case Llamada.TipoLlamada.Local:
                    richTextBox1.Text = MostrarLocal(centralitaMostrar);
                    break;

                case Llamada.TipoLlamada.Provincial:
                    richTextBox1.Text = MostrarProvincial(centralitaMostrar);
                    break;
            }
        }



        public string MostrarLocal(Centralita auxCentralita)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*******************************\n");
            sb.AppendLine("Ganacias por llamadas locales: " + (auxCentralita.GananciasPorLocal).ToString());
            sb.AppendLine("\n*******************************");
            foreach (Llamada item in auxCentralita.Llamadas)
            {
                if (item is Local)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }

        public string MostrarProvincial(Centralita auxCentralita)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*******************************\n");
            sb.AppendLine("Ganacias por llamadas provinciales: " + (auxCentralita.GananciasPorProvincial).ToString());
            sb.AppendLine("\n*******************************");
            foreach (Llamada item in auxCentralita.Llamadas)
            {
                if (item is Provincial)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
