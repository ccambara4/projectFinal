using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctores
{
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
        }

        private void hOSPITALBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOSPITALBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyectoProgra4DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoProgra4DataSet.HOSPITAL' Puede moverla o quitarla según sea necesario.
            this.hOSPITALTableAdapter.Fill(this.proyectoProgra4DataSet.HOSPITAL);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
