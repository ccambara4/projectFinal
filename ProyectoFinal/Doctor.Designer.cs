
namespace ProyectoFinal
{
    partial class Doctor
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
            System.Windows.Forms.Label iD_DoctorLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label especialidadLabel;
            System.Windows.Forms.Label iD_HospitalLabel;
            System.Windows.Forms.Label entradaLabel;
            System.Windows.Forms.Label salidaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.proyectoProgra4DataSet = new ProyectoFinal.ProyectoProgra4DataSet();
            this.dOCTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOCTORESTableAdapter = new ProyectoFinal.ProyectoProgra4DataSetTableAdapters.DOCTORESTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.ProyectoProgra4DataSetTableAdapters.TableAdapterManager();
            this.hOSPITALTableAdapter = new ProyectoFinal.ProyectoProgra4DataSetTableAdapters.HOSPITALTableAdapter();
            this.dOCTORESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dOCTORESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dOCTORESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOSPITALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOSPITALDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_DoctorTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.especialidadTextBox = new System.Windows.Forms.TextBox();
            this.iD_HospitalTextBox = new System.Windows.Forms.TextBox();
            this.entradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            iD_DoctorLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            especialidadLabel = new System.Windows.Forms.Label();
            iD_HospitalLabel = new System.Windows.Forms.Label();
            entradaLabel = new System.Windows.Forms.Label();
            salidaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoProgra4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORESBindingNavigator)).BeginInit();
            this.dOCTORESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORESDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_DoctorLabel
            // 
            iD_DoctorLabel.AutoSize = true;
            iD_DoctorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_DoctorLabel.Location = new System.Drawing.Point(34, 98);
            iD_DoctorLabel.Name = "iD_DoctorLabel";
            iD_DoctorLabel.Size = new System.Drawing.Size(92, 20);
            iD_DoctorLabel.TabIndex = 3;
            iD_DoctorLabel.Text = "ID Doctor:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(34, 124);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(76, 20);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(34, 150);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(78, 20);
            apellidoLabel.TabIndex = 7;
            apellidoLabel.Text = "Apellido:";
            // 
            // especialidadLabel
            // 
            especialidadLabel.AutoSize = true;
            especialidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            especialidadLabel.Location = new System.Drawing.Point(34, 176);
            especialidadLabel.Name = "especialidadLabel";
            especialidadLabel.Size = new System.Drawing.Size(116, 20);
            especialidadLabel.TabIndex = 9;
            especialidadLabel.Text = "Especialidad:";
            // 
            // iD_HospitalLabel
            // 
            iD_HospitalLabel.AutoSize = true;
            iD_HospitalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_HospitalLabel.Location = new System.Drawing.Point(34, 202);
            iD_HospitalLabel.Name = "iD_HospitalLabel";
            iD_HospitalLabel.Size = new System.Drawing.Size(104, 20);
            iD_HospitalLabel.TabIndex = 11;
            iD_HospitalLabel.Text = "ID Hospital:";
            // 
            // entradaLabel
            // 
            entradaLabel.AutoSize = true;
            entradaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            entradaLabel.Location = new System.Drawing.Point(34, 229);
            entradaLabel.Name = "entradaLabel";
            entradaLabel.Size = new System.Drawing.Size(78, 20);
            entradaLabel.TabIndex = 13;
            entradaLabel.Text = "Entrada:";
            // 
            // salidaLabel
            // 
            salidaLabel.AutoSize = true;
            salidaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salidaLabel.Location = new System.Drawing.Point(34, 255);
            salidaLabel.Name = "salidaLabel";
            salidaLabel.Size = new System.Drawing.Size(64, 20);
            salidaLabel.TabIndex = 15;
            salidaLabel.Text = "Salida:";
            // 
            // proyectoProgra4DataSet
            // 
            this.proyectoProgra4DataSet.DataSetName = "ProyectoProgra4DataSet";
            this.proyectoProgra4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCTORESBindingSource
            // 
            this.dOCTORESBindingSource.DataMember = "DOCTORES";
            this.dOCTORESBindingSource.DataSource = this.proyectoProgra4DataSet;
            // 
            // dOCTORESTableAdapter
            // 
            this.dOCTORESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DOCTORESTableAdapter = this.dOCTORESTableAdapter;
            this.tableAdapterManager.HOSPITALTableAdapter = this.hOSPITALTableAdapter;
            this.tableAdapterManager.PACIENTESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.ProyectoProgra4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOSPITALTableAdapter
            // 
            this.hOSPITALTableAdapter.ClearBeforeFill = true;
            // 
            // dOCTORESBindingNavigator
            // 
            this.dOCTORESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dOCTORESBindingNavigator.BindingSource = this.dOCTORESBindingSource;
            this.dOCTORESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dOCTORESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dOCTORESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dOCTORESBindingNavigatorSaveItem});
            this.dOCTORESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dOCTORESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dOCTORESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dOCTORESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dOCTORESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dOCTORESBindingNavigator.Name = "dOCTORESBindingNavigator";
            this.dOCTORESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dOCTORESBindingNavigator.Size = new System.Drawing.Size(1176, 25);
            this.dOCTORESBindingNavigator.TabIndex = 0;
            this.dOCTORESBindingNavigator.Text = "bindingNavigator1";
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
            // dOCTORESBindingNavigatorSaveItem
            // 
            this.dOCTORESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dOCTORESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dOCTORESBindingNavigatorSaveItem.Image")));
            this.dOCTORESBindingNavigatorSaveItem.Name = "dOCTORESBindingNavigatorSaveItem";
            this.dOCTORESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dOCTORESBindingNavigatorSaveItem.Text = "Guardar datos";
            this.dOCTORESBindingNavigatorSaveItem.Click += new System.EventHandler(this.dOCTORESBindingNavigatorSaveItem_Click);
            // 
            // dOCTORESDataGridView
            // 
            this.dOCTORESDataGridView.AutoGenerateColumns = false;
            this.dOCTORESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dOCTORESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dOCTORESDataGridView.DataSource = this.dOCTORESBindingSource;
            this.dOCTORESDataGridView.Location = new System.Drawing.Point(38, 367);
            this.dOCTORESDataGridView.Name = "dOCTORESDataGridView";
            this.dOCTORESDataGridView.Size = new System.Drawing.Size(743, 220);
            this.dOCTORESDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Doctor";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Doctor";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Especialidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Especialidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_Hospital";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID_Hospital";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Entrada";
            this.dataGridViewTextBoxColumn6.HeaderText = "Entrada";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Salida";
            this.dataGridViewTextBoxColumn7.HeaderText = "Salida";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // hOSPITALBindingSource
            // 
            this.hOSPITALBindingSource.DataMember = "HOSPITAL";
            this.hOSPITALBindingSource.DataSource = this.proyectoProgra4DataSet;
            // 
            // hOSPITALDataGridView
            // 
            this.hOSPITALDataGridView.AutoGenerateColumns = false;
            this.hOSPITALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hOSPITALDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.hOSPITALDataGridView.DataSource = this.hOSPITALBindingSource;
            this.hOSPITALDataGridView.Location = new System.Drawing.Point(584, 95);
            this.hOSPITALDataGridView.Name = "hOSPITALDataGridView";
            this.hOSPITALDataGridView.Size = new System.Drawing.Size(341, 220);
            this.hOSPITALDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID_Hospital";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID_Hospital";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn9.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn10.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // iD_DoctorTextBox
            // 
            this.iD_DoctorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORESBindingSource, "ID_Doctor", true));
            this.iD_DoctorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_DoctorTextBox.Location = new System.Drawing.Point(152, 95);
            this.iD_DoctorTextBox.Name = "iD_DoctorTextBox";
            this.iD_DoctorTextBox.Size = new System.Drawing.Size(295, 26);
            this.iD_DoctorTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORESBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(152, 121);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(295, 26);
            this.nombreTextBox.TabIndex = 6;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORESBindingSource, "Apellido", true));
            this.apellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextBox.Location = new System.Drawing.Point(152, 147);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(295, 26);
            this.apellidoTextBox.TabIndex = 8;
            // 
            // especialidadTextBox
            // 
            this.especialidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORESBindingSource, "Especialidad", true));
            this.especialidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especialidadTextBox.Location = new System.Drawing.Point(152, 173);
            this.especialidadTextBox.Name = "especialidadTextBox";
            this.especialidadTextBox.Size = new System.Drawing.Size(295, 26);
            this.especialidadTextBox.TabIndex = 10;
            // 
            // iD_HospitalTextBox
            // 
            this.iD_HospitalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORESBindingSource, "ID_Hospital", true));
            this.iD_HospitalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_HospitalTextBox.Location = new System.Drawing.Point(152, 199);
            this.iD_HospitalTextBox.Name = "iD_HospitalTextBox";
            this.iD_HospitalTextBox.Size = new System.Drawing.Size(295, 26);
            this.iD_HospitalTextBox.TabIndex = 12;
            // 
            // entradaDateTimePicker
            // 
            this.entradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dOCTORESBindingSource, "Entrada", true));
            this.entradaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaDateTimePicker.Location = new System.Drawing.Point(152, 225);
            this.entradaDateTimePicker.Name = "entradaDateTimePicker";
            this.entradaDateTimePicker.Size = new System.Drawing.Size(295, 26);
            this.entradaDateTimePicker.TabIndex = 14;
            // 
            // salidaDateTimePicker
            // 
            this.salidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dOCTORESBindingSource, "Salida", true));
            this.salidaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidaDateTimePicker.Location = new System.Drawing.Point(152, 251);
            this.salidaDateTimePicker.Name = "salidaDateTimePicker";
            this.salidaDateTimePicker.Size = new System.Drawing.Size(295, 26);
            this.salidaDateTimePicker.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(918, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 72);
            this.button1.TabIndex = 17;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1176, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_DoctorLabel);
            this.Controls.Add(this.iD_DoctorTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(especialidadLabel);
            this.Controls.Add(this.especialidadTextBox);
            this.Controls.Add(iD_HospitalLabel);
            this.Controls.Add(this.iD_HospitalTextBox);
            this.Controls.Add(entradaLabel);
            this.Controls.Add(this.entradaDateTimePicker);
            this.Controls.Add(salidaLabel);
            this.Controls.Add(this.salidaDateTimePicker);
            this.Controls.Add(this.hOSPITALDataGridView);
            this.Controls.Add(this.dOCTORESDataGridView);
            this.Controls.Add(this.dOCTORESBindingNavigator);
            this.Name = "Doctor";
            this.Text = "Doctores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoProgra4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORESBindingNavigator)).EndInit();
            this.dOCTORESBindingNavigator.ResumeLayout(false);
            this.dOCTORESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORESDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProyectoProgra4DataSet proyectoProgra4DataSet;
        private System.Windows.Forms.BindingSource dOCTORESBindingSource;
        private ProyectoProgra4DataSetTableAdapters.DOCTORESTableAdapter dOCTORESTableAdapter;
        private ProyectoProgra4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dOCTORESBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dOCTORESBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dOCTORESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private ProyectoProgra4DataSetTableAdapters.HOSPITALTableAdapter hOSPITALTableAdapter;
        private System.Windows.Forms.BindingSource hOSPITALBindingSource;
        private System.Windows.Forms.DataGridView hOSPITALDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox iD_DoctorTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox especialidadTextBox;
        private System.Windows.Forms.TextBox iD_HospitalTextBox;
        private System.Windows.Forms.DateTimePicker entradaDateTimePicker;
        private System.Windows.Forms.DateTimePicker salidaDateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}

