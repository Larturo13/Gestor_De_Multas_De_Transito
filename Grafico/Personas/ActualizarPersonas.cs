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
using Gestor_De_Multas_De_Transito.Datos;
using Newtonsoft.Json;

namespace Gestor_De_Multas_De_Transito.Grafico.Personas
{
    public partial class ActualizarPersonas : Form
    {
        Datos.PersonasConexion tomar = new Datos.PersonasConexion();
        Datos.PersonasConexion ingresoP = new Datos.PersonasConexion();
        Modelo.Personas Personas = new Modelo.Personas();
        public ActualizarPersonas()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string url = "http://apimultas.azurewebsites.net/api/AccPer";
            Personas.dpi = Convert.ToInt32(txt_DPI.Text);
            Personas.direccion = txt_Direccion.Text;
            Personas.telefono = txt_Telefono.Text;

            string miRespuesta = ingresoP.ActualizarDatos(Personas, url);

            MessageBox.Show(miRespuesta);
        }


        private void txt_DPI_Validating(object sender, CancelEventArgs e)
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
                else
                {
                    string prueba = Convert.ToString(dpi);

                    btn_Buscardenuevo.Enabled = true;
                    btn_Guardar.Enabled = true;
                    //txt_NomApell.Text = respuesta.nombreApellido[1].ToString();
                    txt_NomApell.Text = respuesta.nombreApellido.ToString();
                    txt_Direccion.Text = respuesta.direccion.ToString();
                    txt_Telefono.Text = respuesta.telefono.ToString();

                    txt_DPI.Enabled = false;
                }
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

            ResizeRedraw = true;
            this.Paint += new PaintEventHandler(cambiarfondo);
            CargarDatos();
        }

        public async void CargarDatos()
        {
            string url = ("http://apimultas.azurewebsites.net/api/AccPer");

            Datos.PersonasConexion tomar = new Datos.PersonasConexion();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.PersonaActu> lst = JsonConvert.DeserializeObject<List<Modelo.PersonaActu>>(respuesta);

            dgv_Actualiza.DataSource = lst;
            dgv_Actualiza.Columns[0].HeaderText = "DPI";
            dgv_Actualiza.Columns[1].HeaderText = "Nombre Apellido";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Actualiza_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_DPI.Text = dgv_Actualiza.CurrentCell.Value.ToString();

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
        private void cambiarfondo(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 170, 228), Color.FromArgb(0, 0, 128), 75f);

            graphics.FillRectangle(b, gradient_rectangle);

        }
    }
}
