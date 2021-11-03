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

namespace Gestor_De_Multas_De_Transito.Grafico.AjustarMultas
{
    public partial class ActualizarMulta : Form
    {

        Datos.MultaConexion tomar = new Datos.MultaConexion();
        Datos.MultaConexion ingresoP = new Datos.MultaConexion();
        Modelo.MultasActu Multas = new Modelo.MultasActu();
        public ActualizarMulta()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click_1(object sender, EventArgs e)
        {
            string url = "http://apimultas.azurewebsites.net/api/AccMul";
            Multas.codigo = Convert.ToInt32(txt_Codigo.Text);
            Multas.valor = Convert.ToInt32(txt_valor.Text);

            string miRespuesta = ingresoP.ActualizarDatos(Multas, url);

            MessageBox.Show(miRespuesta);
        }

        private void txt_Codigo_Validating(object sender, CancelEventArgs e)
        {
            if (txt_Codigo.Text == "" || txt_Codigo.Text == null)
            {
                MessageBox.Show("No debe dejar vacio este campo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int dpi = Convert.ToInt32(txt_Codigo.Text);
                string Url = ("http://apimultas.azurewebsites.net/api/AccMul" + "/" + dpi + "");
                dynamic respuesta = tomar.Get(Url);

                if (string.IsNullOrEmpty(txt_Codigo.Text) || string.IsNullOrWhiteSpace(txt_Codigo.Text))
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
                    txt_valor.Text = respuesta.nombreApellido.ToString();

                    txt_Codigo.Enabled = false;
                }
            }
        }

        private void btn_Buscardenuevo_Click(object sender, EventArgs e)
        {
            txt_Codigo.Enabled = true;

            txt_valor.Text = "";
        }

        public async void CargarDatos()
        {
            string url = ("http://apimultas.azurewebsites.net/api/AccMul");

            Datos.PersonasConexion tomar = new Datos.PersonasConexion();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.PersonaActu> lst = JsonConvert.DeserializeObject<List<Modelo.PersonaActu>>(respuesta);

            dgv_Actualiza.DataSource = lst;
            dgv_Actualiza.Columns[0].HeaderText = "Codigo";
            dgv_Actualiza.Columns[1].HeaderText = "Descipcion";
            dgv_Actualiza.Columns[2].HeaderText = "Valor";
        }

        private void dgv_Actualiza_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualizarMulta_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
