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

namespace Gestor_De_Multas_De_Transito.Grafico.ConstultarMultas
{
    public partial class ConsultarMultas : Form
    {
        public ConsultarMultas()
        {
            InitializeComponent();
        }
        //funcion que se encarga de llamar un get con una lista de los datos para mostrarlos en el dataviewgrid
        private async void btn_Buscar_Click(object sender, EventArgs e)
        {
            string url = ("http://apimultas.azurewebsites.net/api/AccVisMul");

            Datos.MultaConexion tomar = new Datos.MultaConexion();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.GenMultaCons> lst = JsonConvert.DeserializeObject<List<Modelo.GenMultaCons>>(respuesta);

            dgv_Buscar.DataSource = lst;
            dgv_Buscar.Columns[0].HeaderText = "No. Multa";
            dgv_Buscar.Columns[1].HeaderText = "Placa";
            dgv_Buscar.Columns[2].HeaderText = "DPI";
            dgv_Buscar.Columns[3].HeaderText = "Descripcion";
            dgv_Buscar.Columns[4].HeaderText = "Valor";
            dgv_Buscar.Columns[5].HeaderText = "Hora";
            dgv_Buscar.Columns[6].HeaderText = "Fecha";
            dgv_Buscar.Columns[7].HeaderText = "Lugar";
        }

        private void dgv_Buscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultarMultas_Load(object sender, EventArgs e)
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
