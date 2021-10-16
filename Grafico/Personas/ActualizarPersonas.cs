using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestor_De_Multas_De_Transito.Datos.EnvioPersonas;

namespace Gestor_De_Multas_De_Transito.Grafico.Personas
{
    public partial class ActualizarPersonas : Form
    {
        IngresoPersonas tomar = new IngresoPersonas();
        IngresoPersonas ingresoP = new IngresoPersonas();
        Modelo.Personas Personas = new Modelo.Personas();
        public ActualizarPersonas()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Personas.dpi = Convert.ToInt32(txt_DPI.Text);
            Personas.direccion = txt_Direccion.Text;
            Personas.telefono = txt_Telefono.Text;

            string miRespuesta = ingresoP.ActualizarDatos(Personas);

            MessageBox.Show(miRespuesta);
        }


        private void txt_DPI_Validating(object sender, CancelEventArgs e)
        {
            int dpi = Convert.ToInt32(txt_DPI.Text);

            string prueba = Convert.ToString(dpi);
            string Url = ("http://apimultas.azurewebsites.net/api/AccPer/" + "/" + dpi + "");
            dynamic respuesta = tomar.Get(Url);


            if (txt_DPI.Text == "")
            {
                MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(txt_DPI.Text) || string.IsNullOrWhiteSpace(txt_DPI.Text))
            {
                MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (respuesta == null)
            {
                MessageBox.Show("No existe registro", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btn_Buscardenuevo.Enabled = true;
                btn_Guardar.Enabled = true;
                //txt_NomApell.Text = respuesta.nombreApellido[1].ToString();
                txt_NomApell.Text = respuesta.nombreApellido.ToString();
                txt_Direccion.Text = respuesta.direccion.ToString();
                txt_Telefono.Text = respuesta.telefono.ToString();

                txt_DPI.Enabled = false;
            }
        }

        private void btn_Buscardenuevo_Click(object sender, EventArgs e)
        {
            txt_DPI.Enabled = true;

            txt_DPI.Text = "";
            txt_Direccion.Text = "";
            txt_NomApell.Text = "";
            txt_Telefono.Text = "";
        }

        private void ActualizarPersonas_Load(object sender, EventArgs e)
        {
            btn_Buscardenuevo.Enabled = false;
            btn_Guardar.Enabled = false;
        }
    }
}
