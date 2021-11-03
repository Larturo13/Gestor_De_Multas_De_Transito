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

namespace Gestor_De_Multas_De_Transito.Grafico.AjustarMultas
{
    public partial class CrearMulta : Form
    {
        public CrearMulta()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //string con el link de la apiweb que despues se envia al httprequest
            string url = "http://apimultas.azurewebsites.net/api/AccMul";
            Modelo.MultasInsert Multa = new Modelo.MultasInsert();
            //se envian los datos al objeto
            Multa.descripcion = txt_Descripcion.Text;
            Multa.valor = Convert.ToInt32(txt_valor.Text);

            Datos.MultaConexion IngresoM = new Datos.MultaConexion();
            //se llama al httrequest y devuelve una respuesta de la base de datos 
            string miRespuesta = IngresoM.IngresarDatos(Multa, url);

            MessageBox.Show(miRespuesta);
        }

        private void CrearMulta_Load(object sender, EventArgs e)
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
