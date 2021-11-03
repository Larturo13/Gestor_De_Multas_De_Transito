using Gestor_De_Multas_De_Transito.Datos;
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

namespace Gestor_De_Multas_De_Transito
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        //Funcion que se encarga de incrustar los formularios en un panel como formularios hijo
        private void AbrirFormHija(Object formhija)
        {
            if (this.PContainer.Controls.Count > 0)
                this.PContainer.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PContainer.Controls.Add(fh);
            this.PContainer.Tag = fh;
            fh.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void M_PCrear_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Grafico.Personas.IngresarPersonas());
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Grafico.Personas.ActualizarPersonas());
        }

        private void busquedaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Grafico.Personas.BuscarClientes());
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void agregarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Grafico.Vehiculos.VehiculosIng());
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Grafico.Personas.EliminarPersona());
        }

        private void eliminarVehiculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Grafico.Vehiculos.VehiculoEli());
        }

        private void ActualizarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Grafico.Vehiculos.VehiculosBusqueda());
        }

        private void asignarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Grafico.Vehiculos.AsignarVehiculos());
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Grafico.AjustarMultas.CrearMulta());
        }

        private void actualizarTipoDeMultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Grafico.AjustarMultas.ActualizarMulta());

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Grafico.AplicarMultas.GenerarMulta());
        }

        private void abonarAMultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Grafico.AplicarMultas.PagoMulta());
        }

        private void eliminarTipoDeMultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Grafico.AjustarMultas.EliminarMulta());
        }

        private void consultarMultasActivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Grafico.ConstultarMultas.ConsultarMultas());
        }

        private void consultarMultasHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Grafico.ConstultarMultas.ConsultarHistorialMultas());
        }
    }
}
