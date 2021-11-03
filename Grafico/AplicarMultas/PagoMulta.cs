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

namespace Gestor_De_Multas_De_Transito.Grafico.AplicarMultas
{
    public partial class PagoMulta : Form
    {
        Datos.GenerarMulta tomar = new Datos.GenerarMulta();
        Datos.GenerarMulta ingresoM = new Datos.GenerarMulta();
        Modelo.GenMultaPag Multas = new Modelo.GenMultaPag();
        public PagoMulta()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //se valida que exista el elemento en la base de datos
            if (txt_noMulta.Text == "" || txt_noMulta.Text == null)
            {
                MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int codigo = Convert.ToInt32(txt_noMulta.Text);
                string Url = ("http://apimultas.azurewebsites.net/api/AccVisMul" + "/" + codigo + "");
                dynamic respuesta = tomar.Get(Url);

                if (string.IsNullOrEmpty(txt_noMulta.Text) || string.IsNullOrWhiteSpace(txt_noMulta.Text))
                {
                    MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (respuesta == null)
                {
                    MessageBox.Show("No existe registro", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            string url = "https://apimultas.azurewebsites.net/api/AccMulGen";
            Multas.nro_multa = Convert.ToInt32(txt_noMulta.Text);
            int codigo1 = Convert.ToInt32(txt_noMulta.Text);
            //Se tira una msgbox para volver a preguntar si esta seguro de eliminar el elemento
            DialogResult verifica = MessageBox.Show("Esta seguro que quiere pagar esta multa con codigo: " + codigo1, "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;
            if (verifica == DialogResult.Yes)
            {
                string miRespuesta = ingresoM.EliminarDatos(Multas, url);

                MessageBox.Show(miRespuesta);
            }

            CargarDatos();
        }
        //funcion que se encarga de llamar un get con una lista de los datos para mostrarlos en el dataviewgrid
        public async void CargarDatos()
        {

            string url = ("http://apimultas.azurewebsites.net/api/AccVisMul");

            Datos.GenerarMulta tomar = new Datos.GenerarMulta();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.GenMultaCons> lst = JsonConvert.DeserializeObject<List<Modelo.GenMultaCons>>(respuesta);

            dgv_Elimina.DataSource = lst;
            dgv_Elimina.Columns[0].HeaderText = "No. Multa";
            dgv_Elimina.Columns[1].HeaderText = "Placa";
            dgv_Elimina.Columns[2].HeaderText = "DPI";
            dgv_Elimina.Columns[3].HeaderText = "Descripcion";
            dgv_Elimina.Columns[4].HeaderText = "Valor";
            dgv_Elimina.Columns[5].HeaderText = "Hora";
            dgv_Elimina.Columns[6].HeaderText = "Fecha";
            dgv_Elimina.Columns[7].HeaderText = "Lugar";
        }

        private void PagoMulta_Load(object sender, EventArgs e)
        {
            CargarDatos();
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

        private void dgv_Elimina_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_noMulta.Text = dgv_Elimina.CurrentCell.Value.ToString();
        }
    }
}
