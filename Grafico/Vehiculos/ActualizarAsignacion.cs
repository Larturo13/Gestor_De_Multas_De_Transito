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
    public partial class ActualizarAsignacion : Form
    {
        Datos.VehiculosConexion tomar = new Datos.VehiculosConexion();
        Datos.VehiculosConexion ingresoP = new Datos.VehiculosConexion();
        Modelo.AsignarVehiculo Personas = new Modelo.AsignarVehiculo();
        public ActualizarAsignacion()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //string con el link de la apiweb que despues se envia al httprequest
            string url = "http://apimultas.azurewebsites.net/api/AccPer";
            //se envian los datos al objeto
            Personas.dpi = Convert.ToInt32(txt_DPI.Text);
            Personas.nroPlaca = txt_nroPlaca.Text;
            Personas.dpi = Convert.ToInt32(txt_DPI.Text);
            //se llama al httrequest y devuelve una respuesta de la base de datos 
            string miRespuesta = ingresoP.ActualizarAsignacion(Personas, url);

            MessageBox.Show(miRespuesta);
        }

        private void txt_nroPlaca_Validating(object sender, CancelEventArgs e)
        {
            //se valida que exista el elemento en la base de datos
            if (txt_nroPlaca.Text == "" || txt_nroPlaca.Text == null)
            {
                MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string dpi = txt_nroPlaca.Text;
                string Url = ("http://apimultas.azurewebsites.net/api/AccAs/" + "/" + dpi + "");
                dynamic respuesta = tomar.Get(Url);

                if (string.IsNullOrEmpty(txt_nroPlaca.Text) || string.IsNullOrWhiteSpace(txt_nroPlaca.Text))
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
                    txt_DPI.Text = respuesta.dpi.ToString();
                    txt_nroPlaca.Enabled = false;

                }
            }
        }

        private void btn_Buscardenuevo_Click(object sender, EventArgs e)
        {
            txt_nroPlaca.Enabled = true;

            txt_DPI.Text = "";
        }
        //funcion que se encarga de llamar un get con una lista de los datos para mostrarlos en el dataviewgrid
        public async void CargarDatos()
        {
            string url = ("http://apimultas.azurewebsites.net/api/AccAs");

            Datos.VehiculosConexion tomar = new Datos.VehiculosConexion();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.AsignarVehiculo> lst = JsonConvert.DeserializeObject<List<Modelo.AsignarVehiculo>>(respuesta);

            dgv_Actualiza.DataSource = lst;
            dgv_Actualiza.Columns[0].HeaderText = "Placa";
            dgv_Actualiza.Columns[1].HeaderText = "DPI";
        }

        private void ActualizarAsignacion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        //funcion que se encarga de darle el aspecto de degradado
        private void cambiarfondo(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 170, 228), Color.FromArgb(0, 0, 128), 75f);

            graphics.FillRectangle(b, gradient_rectangle);

        }
        private void dgv_Actualiza_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //se valida que exista el elemento en la base de datos
            txt_nroPlaca.Text = dgv_Actualiza.CurrentCell.Value.ToString();
            if (txt_nroPlaca.Text == "" || txt_nroPlaca.Text == null)
            {
                MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string dpi = txt_nroPlaca.Text;
                string Url = ("http://apimultas.azurewebsites.net/api/AccAs/" + "/" + dpi + "");
                dynamic respuesta = tomar.Get(Url);

                if (string.IsNullOrEmpty(txt_nroPlaca.Text) || string.IsNullOrWhiteSpace(txt_nroPlaca.Text))
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
                    txt_DPI.Text = respuesta.dpi.ToString();
                    txt_nroPlaca.Enabled = false;

                }
            }
        }
    }
}
