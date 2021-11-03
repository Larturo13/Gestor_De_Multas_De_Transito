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

namespace Gestor_De_Multas_De_Transito.Grafico.Personas
{
    public partial class EliminarPersona : Form
    {
        Datos.PersonasConexion tomar = new Datos.PersonasConexion();
        Datos.PersonasConexion ingresoP = new Datos.PersonasConexion();
        Modelo.PersonaEli Personas = new Modelo.PersonaEli();
        public EliminarPersona()
        {
            InitializeComponent();
        }

        //se valida que exista el elemento en la base de datos
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_DPI.Text == "" || txt_DPI.Text == null)
            {
                MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int dpi = Convert.ToInt32(txt_DPI.Text);
                string Url = ("http://apimultas.azurewebsites.net/api/AccPer/" + "/" + dpi + "");
                dynamic respuesta = tomar.Get(Url);

                if (string.IsNullOrEmpty(txt_DPI.Text) || string.IsNullOrWhiteSpace(txt_DPI.Text))
                {
                    MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (respuesta == null)
                {
                    MessageBox.Show("No existe registro", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            string url = "http://apimultas.azurewebsites.net/api/AccPer";
            Personas.dpi = Convert.ToInt32(txt_DPI.Text);
            int dpi1 = Convert.ToInt32(txt_DPI.Text);
            //Se tira una msgbox para volver a preguntar si esta seguro de eliminar el elemento
            DialogResult verifica = MessageBox.Show("Esta seguro que quiere eliminar esta persona con DPI: "+dpi1, "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);;
            if (verifica == DialogResult.Yes)
            {
                string miRespuesta = ingresoP.EliminarDatos(Personas, url);

                MessageBox.Show(miRespuesta);
            }

            CargarDatos();
        }

        private void EliminarPersona_Load(object sender, EventArgs e)
        {
            ResizeRedraw = true;
            this.Paint += new PaintEventHandler(cambiarfondo);
            CargarDatos();
        }

        //funcion que se encarga de llamar un get con una lista de los datos para mostrarlos en el dataviewgrid
        public async void CargarDatos()
        {
            string url = ("http://apimultas.azurewebsites.net/api/AccPer");

            Datos.PersonasConexion tomar = new Datos.PersonasConexion();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.PersonaActu> lst = JsonConvert.DeserializeObject<List<Modelo.PersonaActu>>(respuesta);

            dgv_Elimina.DataSource = lst;
            dgv_Elimina.Columns[0].HeaderText = "DPI";
            dgv_Elimina.Columns[1].HeaderText = "Nombre Apellido";
        }
        //funcion que se encarga de darle el aspecto de degradado
        private void cambiarfondo(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 170, 228), Color.FromArgb(0, 0, 128), 75f);

            graphics.FillRectangle(b, gradient_rectangle);

        }

        private void dgv_Elimina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_DPI.Text = dgv_Elimina.CurrentCell.Value.ToString();
        }
    }
}
