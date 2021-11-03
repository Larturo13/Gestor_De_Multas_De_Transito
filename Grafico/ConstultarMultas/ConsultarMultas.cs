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

namespace Gestor_De_Multas_De_Transito.Grafico.ConstultarMultas
{
    public partial class ConsultarMultas : Form
    {
        public ConsultarMultas()
        {
            InitializeComponent();
        }

        private async void btn_Buscar_Click(object sender, EventArgs e)
        {
            string url = ("http://apimultas.azurewebsites.net/api/AccVisMul");

            Datos.MultaConexion tomar = new Datos.MultaConexion();
            string respuesta = await tomar.GetHttp(url);
            List<Modelo.GenMultaCons> lst = JsonConvert.DeserializeObject<List<Modelo.GenMultaCons>>(respuesta);

            dgv_Buscar.DataSource = lst;
            dgv_Buscar.Columns[0].HeaderText = "No. Multa";
            dgv_Buscar.Columns[1].HeaderText = "Placa";
            dgv_Buscar.Columns[2].HeaderText = "DPI";
            dgv_Buscar.Columns[3].HeaderText = "Descripcion";
            dgv_Buscar.Columns[4].HeaderText = "Valor";
            dgv_Buscar.Columns[5].HeaderText = "Hora";
            dgv_Buscar.Columns[6].HeaderText = "Fecha";
            dgv_Buscar.Columns[7].HeaderText = "Lugar";
        }
    }
}
