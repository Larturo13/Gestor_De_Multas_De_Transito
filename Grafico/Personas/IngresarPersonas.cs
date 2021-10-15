using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_De_Multas_De_Transito.Grafico
{
    public partial class IngresarPersonas : Form
    {
        public IngresarPersonas()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Modelo.Personas Personas = new Modelo.Personas();
            Personas.dpi = Convert.ToInt32(txt_DPI.Text);
            Personas.nombreApellido = txt_NomApell.Text;
            Personas.fechaNacimiento = Dtp_FechaNac.Value;
            Personas.direccion = txt_Direccion.Text;
            Personas.telfono = txt_Telefono.Text;

            Datos.EnvioPersonas.IngresoPersonas ingresoP = new Datos.EnvioPersonas.IngresoPersonas();

            string miRespuesta = ingresoP.IngresarDatos(Personas);

            MessageBox.Show(miRespuesta);
        }

    }
}
