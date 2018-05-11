using GestionParqueo.BDEntity;
using GestionParqueo.BDManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionParqueo.Forms.Configuraciones
{
    public partial class AgregarTipoVehiculo : Form
    {
        public AgregarTipoVehiculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TipoVehiculo nuevoTipo = new TipoVehiculo();
                nuevoTipo.FormatoPlaca = textBox1.Text;

                double espacio = 0;
                double factor = 0;

                if (double.TryParse(textBox2.Text, out espacio))
                    nuevoTipo.Espacio = espacio;
                else
                    throw new Exception("Valor de espacio no válido.");
                if (double.TryParse(textBox3.Text, out factor))
                    nuevoTipo.FactorTarifa = factor;
                else
                    throw new Exception("Valor para Factor de tarifa no es válido.");

                nuevoTipo.Descripcion = textBox4.Text;
                TipoVehiculoManager manager = new TipoVehiculoManager();
                nuevoTipo.Id = Convert.ToInt32(manager.Insert(nuevoTipo));
                Console.WriteLine("NuevoTipo ingresado = " + nuevoTipo.Id);
                ((AbcTarifasVehiculoForm)this.Parent).RecargarTiposVehiculo();
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al crear nuevo tipo." + ex.Message);
            }
        }

        private void AgregarTipoVehiculo_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((AbcTarifasVehiculoForm)this.Parent).ATipoVehiculo = null;
            this.Dispose();
        }
    }
}
