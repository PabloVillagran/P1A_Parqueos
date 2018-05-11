using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionParqueo
{
    public partial class MainForm : Form
    {
        private new Form ActiveForm;

        private void cambiarVentana(Form form)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Hide();
                ActiveForm.Dispose();
            }
            ActiveForm = form;
            ActiveForm.MdiParent = this;
            ActiveForm.WindowState = FormWindowState.Maximized;
            ActiveForm.Show();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void ingresoDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarVentana(new IngresoForm());
        }

        private void partidaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarVentana(new PartidaForm());
        }

        private void cobrosMensualesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cambiarVentana(new CobrosMensualesForm());
        }

        private void ubicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarVentana(new AbcUbicacionForm());
        }

        private void estacionamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarVentana(new AbcEstacionamientosForm());
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarVentana(new BuscarClienteForm());
        }

        private void calcularTarifaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarVentana(new CalcularTarifaForm());
        }

        private void cobrosMensualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarVentana(new CobrosMensualesForm());
        }

        private void movimientosEnCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarVentana(new MovimientoCajaForm());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GestionParqueo, Programación 1 Sección A. Versión 18.5");
        }

        private void tarifasGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarVentana(new AbcTarifasGeneralForm());
        }

        private void porTiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarVentana(new AbcTarifasTiempoForm());
        }

        private void porTipoDeVehiculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cambiarVentana(new AbcTarifasVehiculoForm());
        }
    }
}
