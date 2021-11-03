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
    public partial class EliminarAsignacion : Form
    {
        Datos.VehiculosConexion tomar = new Datos.VehiculosConexion();
        Datos.VehiculosConexion ingresoM = new Datos.VehiculosConexion();
        Modelo.AsignarVehiculo Multas = new Modelo.AsignarVehiculo();
        public EliminarAsignacion()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //se valida que exista el elemento en la base de datos
            if (txt_Placa.Text == "" || txt_Placa.Text == null)
            {
                MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string codigo = txt_Placa.Text;
                string Url = ("http://apimultas.azurewebsites.net/api/AccAs/" + "/" + codigo + "");
                dynamic respuesta = tomar.Get(Url);

                if (string.IsNullOrEmpty(txt_Placa.Text) || string.IsNullOrWhiteSpace(txt_Placa.Text))
                {
                    MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (respuesta == null)
                {
                    MessageBox.Show("No existe registro", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            string url = "http://apimultas.azurewebsites.net/api/AccAs";
            Multas.nroPlaca = txt_Placa.Text;
            Multas.dpi = Convert.ToInt32(txt_dpi.Text);
            string codigo1 = txt_Placa.Text;
            //Se tira una msgbox para volver a preguntar si esta seguro de eliminar el elemento
            DialogResult verifica = MessageBox.Show("Esta seguro que quiere eliminar la asignacion de este vehiculo con Placa: " + codigo1, "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;
            if (verifica == DialogResult.Yes)
            {
                string miRespuesta = ingresoM.EliminarAsignacion(Multas, url);

                MessageBox.Show(miRespuesta);
            }

            CargarDatos();
        }
        //funcion que se encarga de llamar un get con una lista de los datos para mostrarlos en el dataviewgrid
        public async void CargarDatos()
        {
            string url = ("http://apimultas.azurewebsites.net/api/AccAs");

            Datos.PersonasConexion tomar = new Datos.PersonasConexion();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.AsignarVehiculo> lst = JsonConvert.DeserializeObject<List<Modelo.AsignarVehiculo>>(respuesta);

            dgv_Elimina.DataSource = lst;
            dgv_Elimina.Columns[0].HeaderText = "Placa";
            dgv_Elimina.Columns[1].HeaderText = "DPI";
        }

        private void EliminarAsignacion_Load(object sender, EventArgs e)
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
