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

namespace Gestor_De_Multas_De_Transito.Grafico.Vehiculos
{
    public partial class VehiculosIng : Form
    {
        public VehiculosIng()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //string con el link de la apiweb que despues se envia al httprequest
            string url = "http://apimultas.azurewebsites.net/api/AccVeh";
            //se envian los datos al objeto
            Modelo.Vehiculos Vehiculos = new Modelo.Vehiculos();
            Vehiculos.nroPlaca = txt_nroPlaca.Text;
            Vehiculos.tipo = txt_tipo.Text;
            Vehiculos.marca = txt_marca.Text;
            Vehiculos.modelo = txt_modelo.Text;
            Vehiculos.anio = Convert.ToInt32(txt_anio.Text);

            Datos.VehiculosConexion IngresoV = new Datos.VehiculosConexion();
            //se llama al httrequest y devuelve una respuesta de la base de datos 
            string miRespuesta = IngresoV.IngresarDatos(Vehiculos, url);

            MessageBox.Show(miRespuesta);
        }

        private void VehiculosIng_Load(object sender, EventArgs e)
        {
                ResizeRedraw = true;
                this.Paint += new PaintEventHandler(cambiarfondo);
        }
        //funcion que se encarga de darle el aspecto de degradado
        private void cambiarfondo(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 170, 228), Color.FromArgb(0, 0, 128), 75f);

            graphics.FillRectangle(b, gradient_rectangle);

        }
    }
}
