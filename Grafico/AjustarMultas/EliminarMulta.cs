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

namespace Gestor_De_Multas_De_Transito.Grafico.AjustarMultas
{
    public partial class EliminarMulta : Form
    {
        Datos.MultaConexion tomar = new Datos.MultaConexion();
        Datos.MultaConexion ingresoM = new Datos.MultaConexion();
        Modelo.MultasEli Multas = new Modelo.MultasEli();
        public EliminarMulta()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //se valida que exista el elemento en la base de datos
            if (txt_Codigo.Text == "" || txt_Codigo.Text == null)
            {
                MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int codigo = Convert.ToInt32(txt_Codigo.Text);
                string Url = ("http://apimultas.azurewebsites.net/api/AccMul/" + "/" + codigo + "");
                dynamic respuesta = tomar.Get(Url);

                if (string.IsNullOrEmpty(txt_Codigo.Text) || string.IsNullOrWhiteSpace(txt_Codigo.Text))
                {
                    MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (respuesta == null)
                {
                    MessageBox.Show("No existe registro", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            string url = "http://apimultas.azurewebsites.net/api/AccMul";
            Multas.codigo = Convert.ToInt32(txt_Codigo.Text);
            int codigo1 = Convert.ToInt32(txt_Codigo.Text);
            //Se tira una msgbox para volver a preguntar si esta seguro de eliminar el elemento
            DialogResult verifica = MessageBox.Show("Esta seguro que quiere eliminar esta multa con Codigo: " + codigo1, "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;
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
            string url = ("http://apimultas.azurewebsites.net/api/AccMul");

            Datos.PersonasConexion tomar = new Datos.PersonasConexion();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.Multas> lst = JsonConvert.DeserializeObject<List<Modelo.Multas>>(respuesta);

            dgv_Elimina.DataSource = lst;
            dgv_Elimina.Columns[0].HeaderText = "Codigo";
            dgv_Elimina.Columns[1].HeaderText = "Descripcion";
            dgv_Elimina.Columns[2].HeaderText = "Valor";
        }

        private void dgv_Elimina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Codigo.Text = dgv_Elimina.CurrentCell.Value.ToString();
        }

        private void EliminarMulta_Load(object sender, EventArgs e)
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
    }
}
