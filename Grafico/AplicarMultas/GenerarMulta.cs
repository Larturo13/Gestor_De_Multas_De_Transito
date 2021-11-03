using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private async void GenerarMulta_Load(object sender, EventArgs e)
        {
            string url = ("http://apimultas.azurewebsites.net/api/AccMul");
            Datos.PersonasConexion tomar = new Datos.PersonasConexion();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.Multas> lst = JsonConvert.DeserializeObject<List<Modelo.Multas>>(respuesta);
            comboBox1.DataSource = lst;
            comboBox1.DisplayMember = "descripcion";
            comboBox1.ValueMember = "codigo";

        }

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
            string url = "https://apimultas.azurewebsites.net/api/AccMulgen";
            Modelo.GenMulta Multa = new Modelo.GenMulta();
            Multa.codigo_infraccion = Convert.ToInt32(comboBox1.SelectedValue);
            Multa.nroPlaca = txt_noPlaca.Text;
            Multa.dpi = Convert.ToInt32(txt_dpi.Text);
            Multa.fecha = dateTimePicker1.Value;
            Multa.hora = dateTimePicker2.Value;
            Multa.lugar = txt_lugar.Text;

            Datos.GenerarMulta IngresoM = new Datos.GenerarMulta();

            string miRespuesta = IngresoM.IngresarDatos(Multa, url);

            MessageBox.Show(miRespuesta);
        }

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
    }
}
