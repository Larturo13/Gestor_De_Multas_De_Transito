using Newtonsoft.Json;
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
    public partial class VehiculosBusqueda : Form
    {
        Datos.VehiculosConexion tomar = new Datos.VehiculosConexion();
        public VehiculosBusqueda()
        {
            InitializeComponent();
        }
        //funcion que se encarga de llamar un get con una lista de los datos para mostrarlos en el dataviewgrid
        private async void btn_Buscar_Click(object sender, EventArgs e)
        {
            string url = ("http://apimultas.azurewebsites.net/api/AccVeh");

            Datos.VehiculosConexion tomar = new Datos.VehiculosConexion();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.Vehiculos> lst = JsonConvert.DeserializeObject<List<Modelo.Vehiculos>>(respuesta);

            dgv_Buscar.DataSource = lst;
            dgv_Buscar.Columns[0].HeaderText = "No. Placa";
            dgv_Buscar.Columns[1].HeaderText = "Tipo";
            dgv_Buscar.Columns[2].HeaderText = "Marca";
            dgv_Buscar.Columns[3].HeaderText = "Modelo";
            dgv_Buscar.Columns[4].HeaderText = "Año";
        }
        //funcion que se encarga de darle el aspecto de degradado
        private void cambiarfondo(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 170, 228), Color.FromArgb(0, 0, 128), 75f);

            graphics.FillRectangle(b, gradient_rectangle);

        }

        private void VehiculosBusqueda_Load(object sender, EventArgs e)
        {
            ResizeRedraw = true;
            this.Paint += new PaintEventHandler(cambiarfondo);
        }
    }
}
