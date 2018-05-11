using GestionParqueo.BDEntity;
using GestionParqueo.BDManager;
using GestionParqueo.Forms.Configuraciones;
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
    public partial class AbcTarifasVehiculoForm : Form
    {
        private AgregarTipoVehiculo aTipoVehiculo;
        public AgregarTipoVehiculo ATipoVehiculo { get; set; }

        public AbcTarifasVehiculoForm()
        {
            InitializeComponent();
            RecargarTiposVehiculo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (aTipoVehiculo == null || aTipoVehiculo.IsDisposed)
            {
                aTipoVehiculo = new AgregarTipoVehiculo();
                aTipoVehiculo.TopLevel = false;
                aTipoVehiculo.Parent = this;
                aTipoVehiculo.Show();
            }
            aTipoVehiculo.StartPosition = FormStartPosition.CenterParent;
            aTipoVehiculo.BringToFront();
        }

        public void RecargarTiposVehiculo()
        {
            comboBox1.Items.AddRange(new TipoVehiculoManager().Select().Cast<TipoVehiculo>().ToArray());
        }
    }
}
