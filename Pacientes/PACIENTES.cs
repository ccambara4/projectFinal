using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacientes
{
    public partial class PACIENTES : Form
    {
        public PACIENTES()
        {
            InitializeComponent();
        }

        private void pACIENTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pACIENTESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyectoProgra4DataSet);

        }

        private void PACIENTES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoProgra4DataSet.DOCTORES' Puede moverla o quitarla según sea necesario.
            this.dOCTORESTableAdapter.Fill(this.proyectoProgra4DataSet.DOCTORES);
            // TODO: esta línea de código carga datos en la tabla 'proyectoProgra4DataSet.PACIENTES' Puede moverla o quitarla según sea necesario.
            this.pACIENTESTableAdapter.Fill(this.proyectoProgra4DataSet.PACIENTES);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
