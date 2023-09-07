using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void dOCTORESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dOCTORESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyectoProgra4DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoProgra4DataSet.HOSPITAL' Puede moverla o quitarla según sea necesario.
            this.hOSPITALTableAdapter.Fill(this.proyectoProgra4DataSet.HOSPITAL);
            // TODO: esta línea de código carga datos en la tabla 'proyectoProgra4DataSet.DOCTORES' Puede moverla o quitarla según sea necesario.
            this.dOCTORESTableAdapter.Fill(this.proyectoProgra4DataSet.DOCTORES);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
