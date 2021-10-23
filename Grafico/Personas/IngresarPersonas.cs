using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_De_Multas_De_Transito.Grafico.Personas
{
    public partial class IngresarPersonas : Form
    {
        public IngresarPersonas()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string url = "http://apimultas.azurewebsites.net/api/AccPer";
            Modelo.Personas Personas = new Modelo.Personas();
            Personas.dpi = Convert.ToInt32(txt_DPI.Text);
            Personas.nombreApellido = txt_NomApell.Text;
            Personas.fechaNacimiento = Dtp_FechaNac.Value;
            Personas.direccion = txt_Direccion.Text;
            Personas.telefono = txt_Telefono.Text;

            Datos.ConexionApi ingresoP = new Datos.ConexionApi();

            string miRespuesta = ingresoP.IngresarDatos(Personas, url);

            MessageBox.Show(miRespuesta);
        }

        private void IngresarPersonas_Load(object sender, EventArgs e)
        {
            ResizeRedraw = true;
            this.Paint += new PaintEventHandler(cambiarfondo);
        }
        private void cambiarfondo(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 170, 228), Color.FromArgb(0, 0, 128), 75f);

            graphics.FillRectangle(b, gradient_rectangle);

        }
    }
}
