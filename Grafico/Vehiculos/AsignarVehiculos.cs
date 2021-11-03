﻿using Newtonsoft.Json;
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
    public partial class AsignarVehiculos : Form
    {
        
        public AsignarVehiculos()
        {
            InitializeComponent();
        }
        
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //string con el link de la apiweb que despues se envia al httprequest
            string url = "http://apimultas.azurewebsites.net/api/AccAs";
            //se envian los datos al objeto
            Modelo.AsignarVehiculo Vehiculos = new Modelo.AsignarVehiculo();
            Vehiculos.nroPlaca = txt_nroPlaca.Text;
            Vehiculos.dpi = Convert.ToInt32(txt_DPI.Text);

            Datos.VehiculosConexion IngresoV = new Datos.VehiculosConexion();
            //se llama al httrequest y devuelve una respuesta de la base de datos 
            string miRespuesta = IngresoV.AsignarDatos(Vehiculos, url);

            MessageBox.Show(miRespuesta);
        }

        //funcion que se encarga de cambiar el dataviewgrid
        private void txt_nroPlaca_Enter(object sender, EventArgs e)
        {

            dgv_Asigna1.Visible = true;
            CargarDatosVeh();
            dgv_Asigna2.Visible = false;
        }
        //funcion que se encarga de llamar un get con una lista de los datos para mostrarlos en el dataviewgrid
        public async void CargarDatosVeh()
        {
            string url = ("http://apimultas.azurewebsites.net/api/AccVeh");

            Datos.VehiculosConexion tomar = new Datos.VehiculosConexion();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.Vehiculos> lst = JsonConvert.DeserializeObject<List<Modelo.Vehiculos>>(respuesta);

            dgv_Asigna1.DataSource = lst;
            dgv_Asigna1.Columns[0].HeaderText = "No. Placa";
            dgv_Asigna1.Columns[1].HeaderText = "Tipo";
            dgv_Asigna1.Columns[2].HeaderText = "Marca";
            dgv_Asigna1.Columns[3].HeaderText = "Modelo";
            dgv_Asigna1.Columns[4].HeaderText = "Año";

        }
        //funcion que se encarga de llamar un get con una lista de los datos para mostrarlos en el dataviewgrid
        public async void CargarDatosPer()
        {
            string url = "http://apimultas.azurewebsites.net/api/AccPer";
            Datos.PersonasConexion tomar = new Datos.PersonasConexion();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.Personas> lst = JsonConvert.DeserializeObject<List<Modelo.Personas>>(respuesta);
            dgv_Asigna2.DataSource = lst;

            dgv_Asigna2.Columns[0].HeaderText = "DPI";
            dgv_Asigna2.Columns[1].HeaderText = "Nombre Apellido";
            dgv_Asigna2.Columns[2].HeaderText = "Fecha Nacimiento";
            dgv_Asigna2.Columns[3].HeaderText = "Direccion";
            dgv_Asigna2.Columns[4].HeaderText = "Telefono";

        }
        //funcion que se encarga de cambiar el dataviewgrid
        private void txt_DPI_Enter(object sender, EventArgs e)
        {
            dgv_Asigna2.Visible = true;
            CargarDatosPer();
            dgv_Asigna1.Visible = false;
        }
        //funcion que se encarga de rellenar los datos cuando se da doble click en una celda
        private void dgv_Asigna_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_nroPlaca.Text = dgv_Asigna1.CurrentCell.Value.ToString();
        }
        //funcion que se encarga de rellenar los datos cuando se da doble click en una celda
        private void dgv_Asigna2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_DPI.Text = dgv_Asigna2.CurrentCell.Value.ToString();
        }
        //En el load llama a la funcion que se encarga de darle el aspecto de degradado
        private void AsignarVehiculos_Load(object sender, EventArgs e)
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