using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestor_De_Multas_De_Transito.Datos;
using Newtonsoft.Json;

namespace Gestor_De_Multas_De_Transito.Grafico.Personas
{
    public partial class BuscarClientes : Form
    {
        public BuscarClientes()
        {
            InitializeComponent();
        }

        private void BuscarClientes_Load(object sender, EventArgs e)
        {
            ResizeRedraw = true;
            this.Paint += new PaintEventHandler(cambiarfondo);
        }

        private async void btn_Buscar_Click(object sender, EventArgs e)
        {

            string url = "http://apimultas.azurewebsites.net/api/AccPer";
            ConexionApi tomar = new ConexionApi();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.Personas> lst = JsonConvert.DeserializeObject<List<Modelo.Personas>>(respuesta);
            dgv_Buscar.DataSource = lst;

            dgv_Buscar.Columns[0].HeaderText = "DPI";
            dgv_Buscar.Columns[1].HeaderText = "Nombre Apellido";
            dgv_Buscar.Columns[2].HeaderText = "Fecha Nacimiento";
            dgv_Buscar.Columns[3].HeaderText = "Direccion";
            dgv_Buscar.Columns[4].HeaderText = "Telefono";
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
