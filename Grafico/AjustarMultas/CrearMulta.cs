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
    public partial class CrearMulta : Form
    {
        public CrearMulta()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string url = "http://apimultas.azurewebsites.net/api/AccMul";
            Modelo.MultasInsert Multa = new Modelo.MultasInsert();
            Multa.descripcion = txt_Descripcion.Text;
            Multa.valor = Convert.ToInt32(txt_valor.Text);

            Datos.MultaConexion IngresoM = new Datos.MultaConexion();

            string miRespuesta = IngresoM.IngresarDatos(Multa, url);

            MessageBox.Show(miRespuesta);
        }
    }
}
