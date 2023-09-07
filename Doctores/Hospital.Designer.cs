
namespace Doctores
{
    partial class Hospital
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_HospitalLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospital));
            this.proyectoProgra4DataSet = new Doctores.ProyectoProgra4DataSet();
            this.hOSPITALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOSPITALTableAdapter = new Doctores.ProyectoProgra4DataSetTableAdapters.HOSPITALTableAdapter();
            this.tableAdapterManager = new Doctores.ProyectoProgra4DataSetTableAdapters.TableAdapterManager();
            this.hOSPITALBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hOSPITALBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hOSPITALDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_HospitalTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            iD_HospitalLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoProgra4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALBindingNavigator)).BeginInit();
            this.hOSPITALBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_HospitalLabel
            // 
            iD_HospitalLabel.AutoSize = true;
            iD_HospitalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_HospitalLabel.Location = new System.Drawing.Point(47, 132);
            iD_HospitalLabel.Name = "iD_HospitalLabel";
            iD_HospitalLabel.Size = new System.Drawing.Size(104, 20);
            iD_HospitalLabel.TabIndex = 2;
            iD_HospitalLabel.Text = "ID Hospital:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(47, 158);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(76, 20);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(47, 184);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(89, 20);
            direccionLabel.TabIndex = 6;
            direccionLabel.Text = "Direccion:";
            // 
            // proyectoProgra4DataSet
            // 
            this.proyectoProgra4DataSet.DataSetName = "ProyectoProgra4DataSet";
            this.proyectoProgra4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOSPITALBindingSource
            // 
            this.hOSPITALBindingSource.DataMember = "HOSPITAL";
            this.hOSPITALBindingSource.DataSource = this.proyectoProgra4DataSet;
            // 
            // hOSPITALTableAdapter
            // 
            this.hOSPITALTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DOCTORESTableAdapter = null;
            this.tableAdapterManager.HOSPITALTableAdapter = this.hOSPITALTableAdapter;
            this.tableAdapterManager.PACIENTESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Doctores.ProyectoProgra4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOSPITALBindingNavigator
            // 
            this.hOSPITALBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hOSPITALBindingNavigator.BindingSource = this.hOSPITALBindingSource;
            this.hOSPITALBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hOSPITALBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hOSPITALBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hOSPITALBindingNavigatorSaveItem});
            this.hOSPITALBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hOSPITALBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hOSPITALBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hOSPITALBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hOSPITALBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hOSPITALBindingNavigator.Name = "hOSPITALBindingNavigator";
            this.hOSPITALBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hOSPITALBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.hOSPITALBindingNavigator.TabIndex = 0;
            this.hOSPITALBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // hOSPITALBindingNavigatorSaveItem
            // 
            this.hOSPITALBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hOSPITALBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hOSPITALBindingNavigatorSaveItem.Image")));
            this.hOSPITALBindingNavigatorSaveItem.Name = "hOSPITALBindingNavigatorSaveItem";
            this.hOSPITALBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hOSPITALBindingNavigatorSaveItem.Text = "Guardar datos";
            this.hOSPITALBindingNavigatorSaveItem.Click += new System.EventHandler(this.hOSPITALBindingNavigatorSaveItem_Click);
            // 
            // hOSPITALDataGridView
            // 
            this.hOSPITALDataGridView.AutoGenerateColumns = false;
            this.hOSPITALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hOSPITALDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.hOSPITALDataGridView.DataSource = this.hOSPITALBindingSource;
            this.hOSPITALDataGridView.Location = new System.Drawing.Point(38, 283);
            this.hOSPITALDataGridView.Name = "hOSPITALDataGridView";
            this.hOSPITALDataGridView.Size = new System.Drawing.Size(343, 220);
            this.hOSPITALDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Hospital";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Hospital";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // iD_HospitalTextBox
            // 
            this.iD_HospitalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOSPITALBindingSource, "ID_Hospital", true));
            this.iD_HospitalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_HospitalTextBox.Location = new System.Drawing.Point(157, 129);
            this.iD_HospitalTextBox.Name = "iD_HospitalTextBox";
            this.iD_HospitalTextBox.Size = new System.Drawing.Size(152, 26);
            this.iD_HospitalTextBox.TabIndex = 3;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOSPITALBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(157, 155);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(152, 26);
            this.nombreTextBox.TabIndex = 5;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOSPITALBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(157, 181);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(152, 26);
            this.direccionTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(563, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 85);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_HospitalLabel);
            this.Controls.Add(this.iD_HospitalTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.hOSPITALDataGridView);
            this.Controls.Add(this.hOSPITALBindingNavigator);
            this.Name = "Hospital";
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoProgra4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALBindingNavigator)).EndInit();
            this.hOSPITALBindingNavigator.ResumeLayout(false);
            this.hOSPITALBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProyectoProgra4DataSet proyectoProgra4DataSet;
        private System.Windows.Forms.BindingSource hOSPITALBindingSource;
        private ProyectoProgra4DataSetTableAdapters.HOSPITALTableAdapter hOSPITALTableAdapter;
        private ProyectoProgra4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hOSPITALBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hOSPITALBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hOSPITALDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox iD_HospitalTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.Button button1;
    }
}

