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
    public partial class VehiculoEli : Form
    {
        Datos.VehiculosConexion tomar = new Datos.VehiculosConexion();
        Datos.VehiculosConexion ingresoV = new Datos.VehiculosConexion();
        Modelo.VehiculosEli Vehiculos = new Modelo.VehiculosEli();
        public VehiculoEli()
        {
            InitializeComponent();
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            //se valida que exista el elemento en la base de datos
            if (txt_nroPlaca.Text == "" || txt_nroPlaca.Text == null)
            {
                MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string nop = txt_nroPlaca.Text;
                string Url = ("http://apimultas.azurewebsites.net/api/AccVeh/" + "/" + nop + "");
                dynamic respuesta = tomar.Get(Url);

                if (string.IsNullOrEmpty(txt_nroPlaca.Text) || string.IsNullOrWhiteSpace(txt_nroPlaca.Text))
                {
                    MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (respuesta == null)
                {
                    MessageBox.Show("No existe registro", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            string url = "http://apimultas.azurewebsites.net/api/AccVeh";
            Vehiculos.nroPlaca = txt_nroPlaca.Text;
            string nop1 = txt_nroPlaca.Text;
            //Se tira una msgbox para volver a preguntar si esta seguro de eliminar el elemento
            DialogResult verifica = MessageBox.Show("Esta seguro que quiere eliminar este vehiculo con Placa: " + nop1, "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;
            if (verifica == DialogResult.Yes)
            {
                string miRespuesta = ingresoV.EliminarDatos(Vehiculos, url);

                MessageBox.Show(miRespuesta);
            }
            CargarDatos();
        }
        //funcion que se encarga de llamar un get con una lista de los datos para mostrarlos en el dataviewgrid
        public async void CargarDatos()
        {
            string url = ("http://apimultas.azurewebsites.net/api/AccVeh");

            Datos.VehiculosConexion tomar = new Datos.VehiculosConexion();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.Vehiculos> lst = JsonConvert.DeserializeObject<List<Modelo.Vehiculos>>(respuesta);

            dgv_Elimina.DataSource = lst;
            dgv_Elimina.Columns[0].HeaderText = "No. Placa";
            dgv_Elimina.Columns[1].HeaderText = "Tipo";
            dgv_Elimina.Columns[2].HeaderText = "Marca";
            dgv_Elimina.Columns[3].HeaderText = "Modelo";
            dgv_Elimina.Columns[4].HeaderText = "Año";
        }
        //funcion que se encarga de darle el aspecto de degradado
        private void cambiarfondo(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 170, 228), Color.FromArgb(0, 0, 128), 75f);

            graphics.FillRectangle(b, gradient_rectangle);

        }
        private void VehiculoEli_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ResizeRedraw = true;
            this.Paint += new PaintEventHandler(cambiarfondo);
        }

        private void dgv_Elimina_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_nroPlaca.Text = dgv_Elimina.CurrentCell.Value.ToString();
        }
    }
}
