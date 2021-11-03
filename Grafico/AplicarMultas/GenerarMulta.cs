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

namespace Gestor_De_Multas_De_Transito.Grafico.AplicarMultas
{
    public partial class GenerarMulta : Form
    {
        Datos.MultaConexion tomar = new Datos.MultaConexion();
        Datos.MultaConexion ingresoP = new Datos.MultaConexion();
        Modelo.Personas Personas = new Modelo.Personas();
        public GenerarMulta()
        {
            InitializeComponent();
        }
        //funcion que se encarga de cargar una lista de objetos a una combobox
        private async void GenerarMulta_Load(object sender, EventArgs e)
        {
            string url = ("http://apimultas.azurewebsites.net/api/AccMul");
            Datos.PersonasConexion tomar = new Datos.PersonasConexion();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.Multas> lst = JsonConvert.DeserializeObject<List<Modelo.Multas>>(respuesta);
            comboBox1.DataSource = lst;
            comboBox1.DisplayMember = "descripcion";
            comboBox1.ValueMember = "codigo";

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
        //se valida que exista el elemento en la base de datos
        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.Text == "" || comboBox1.Text == null)
            {
                MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int cod = Convert.ToInt32(comboBox1.SelectedValue);
                string Url = ("http://apimultas.azurewebsites.net/api/AccMul" + "/" + cod + "");
                dynamic respuesta = tomar.Get(Url);

                if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (respuesta == null)
                {
                    MessageBox.Show("No existe registro", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //txt_NomApell.Text = respuesta.nombreApellido[1].ToString();
                    txt_valor.Text = respuesta.valor.ToString();
                }
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //string con el link de la apiweb que despues se envia al httprequest
            string url = "https://apimultas.azurewebsites.net/api/AccMulgen";
            Modelo.GenMulta Multa = new Modelo.GenMulta();
            //se envian los datos al objeto
            Multa.codigo_infraccion = Convert.ToInt32(comboBox1.SelectedValue);
            Multa.nroPlaca = txt_noPlaca.Text;
            Multa.dpi = Convert.ToInt32(txt_dpi.Text);
            Multa.fecha = dateTimePicker1.Value;
            Multa.hora = dateTimePicker2.Value;
            Multa.lugar = txt_lugar.Text;

            Datos.GenerarMulta IngresoM = new Datos.GenerarMulta();
            //se llama al httrequest y devuelve una respuesta de la base de datos 
            string miRespuesta = IngresoM.IngresarDatos(Multa, url);

            MessageBox.Show(miRespuesta);
        }
        //se valida que exista el elemento en la base de datos

        private void txt_noPlaca_Validating_1(object sender, CancelEventArgs e)
        {

            if (txt_noPlaca.Text == "" || txt_noPlaca.Text == null)
            {
                MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string nop = txt_noPlaca.Text;
                string Url = ("http://apimultas.azurewebsites.net/api/AccVeh" + "/" + nop + "");
                dynamic respuesta = tomar.Get(Url);

                if (string.IsNullOrEmpty(txt_noPlaca.Text) || string.IsNullOrWhiteSpace(txt_noPlaca.Text))
                {
                    MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (respuesta == null)
                {
                    MessageBox.Show("No existe registro", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //se valida que exista el elemento en la base de datos

        private void txt_dpi_Validating(object sender, CancelEventArgs e)
        {
            if (txt_dpi.Text == "" || txt_dpi.Text == null)
            {
                MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string nop = txt_dpi.Text;
                string Url = ("http://apimultas.azurewebsites.net/api/AccPer" + "/" + nop + "");
                dynamic respuesta = tomar.Get(Url);

                if (string.IsNullOrEmpty(txt_dpi.Text) || string.IsNullOrWhiteSpace(txt_dpi.Text))
                {
                    MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (respuesta == null)
                {
                    MessageBox.Show("No existe registro", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}