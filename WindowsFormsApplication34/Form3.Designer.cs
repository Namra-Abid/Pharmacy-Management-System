namespace WindowsFormsApplication34
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label gPAPPOINTMENTLabel;
            System.Windows.Forms.Label eMISNumberLabel;
            System.Windows.Forms.Label patientFullNameLabel;
            System.Windows.Forms.Label doctorNHSNumberLabel;
            System.Windows.Forms.Label patientIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.database7DataSet = new WindowsFormsApplication34.Database7DataSet();
            this.gPAPPOITNMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gPAPPOITNMENTTableAdapter = new WindowsFormsApplication34.Database7DataSetTableAdapters.GPAPPOITNMENTTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication34.Database7DataSetTableAdapters.TableAdapterManager();
            this.gPAPPOITNMENTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gPAPPOITNMENTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gPAPPOINTMENTTextBox = new System.Windows.Forms.TextBox();
            this.eMISNumberTextBox = new System.Windows.Forms.TextBox();
            this.patientFullNameTextBox = new System.Windows.Forms.TextBox();
            this.doctorNHSNumberTextBox = new System.Windows.Forms.TextBox();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gPAPPOITNMENTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            gPAPPOINTMENTLabel = new System.Windows.Forms.Label();
            eMISNumberLabel = new System.Windows.Forms.Label();
            patientFullNameLabel = new System.Windows.Forms.Label();
            doctorNHSNumberLabel = new System.Windows.Forms.Label();
            patientIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPAPPOITNMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPAPPOITNMENTBindingNavigator)).BeginInit();
            this.gPAPPOITNMENTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gPAPPOITNMENTDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gPAPPOINTMENTLabel
            // 
            gPAPPOINTMENTLabel.AutoSize = true;
            gPAPPOINTMENTLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gPAPPOINTMENTLabel.Location = new System.Drawing.Point(46, 51);
            gPAPPOINTMENTLabel.Name = "gPAPPOINTMENTLabel";
            gPAPPOINTMENTLabel.Size = new System.Drawing.Size(150, 17);
            gPAPPOINTMENTLabel.TabIndex = 1;
            gPAPPOINTMENTLabel.Text = "GPAPPOINTMENT:";
            // 
            // eMISNumberLabel
            // 
            eMISNumberLabel.AutoSize = true;
            eMISNumberLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMISNumberLabel.Location = new System.Drawing.Point(46, 84);
            eMISNumberLabel.Name = "eMISNumberLabel";
            eMISNumberLabel.Size = new System.Drawing.Size(153, 17);
            eMISNumberLabel.TabIndex = 3;
            eMISNumberLabel.Text = "GPAppointmentDay";
            eMISNumberLabel.Click += new System.EventHandler(this.eMISNumberLabel_Click);
            // 
            // patientFullNameLabel
            // 
            patientFullNameLabel.AutoSize = true;
            patientFullNameLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientFullNameLabel.Location = new System.Drawing.Point(46, 128);
            patientFullNameLabel.Name = "patientFullNameLabel";
            patientFullNameLabel.Size = new System.Drawing.Size(141, 17);
            patientFullNameLabel.TabIndex = 5;
            patientFullNameLabel.Text = "Patient Full Name:";
            // 
            // doctorNHSNumberLabel
            // 
            doctorNHSNumberLabel.AutoSize = true;
            doctorNHSNumberLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctorNHSNumberLabel.Location = new System.Drawing.Point(427, 55);
            doctorNHSNumberLabel.Name = "doctorNHSNumberLabel";
            doctorNHSNumberLabel.Size = new System.Drawing.Size(103, 17);
            doctorNHSNumberLabel.TabIndex = 7;
            doctorNHSNumberLabel.Text = "Doctor Name";
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientIDLabel.Location = new System.Drawing.Point(427, 81);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(113, 17);
            patientIDLabel.TabIndex = 9;
            patientIDLabel.Text = "PatientDisease";
            // 
            // database7DataSet
            // 
            this.database7DataSet.DataSetName = "Database7DataSet";
            this.database7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gPAPPOITNMENTBindingSource
            // 
            this.gPAPPOITNMENTBindingSource.DataMember = "GPAPPOITNMENT";
            this.gPAPPOITNMENTBindingSource.DataSource = this.database7DataSet;
            // 
            // gPAPPOITNMENTTableAdapter
            // 
            this.gPAPPOITNMENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GPAPPOITNMENTTableAdapter = this.gPAPPOITNMENTTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication34.Database7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gPAPPOITNMENTBindingNavigator
            // 
            this.gPAPPOITNMENTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gPAPPOITNMENTBindingNavigator.BindingSource = this.gPAPPOITNMENTBindingSource;
            this.gPAPPOITNMENTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gPAPPOITNMENTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gPAPPOITNMENTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gPAPPOITNMENTBindingNavigatorSaveItem});
            this.gPAPPOITNMENTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gPAPPOITNMENTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gPAPPOITNMENTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gPAPPOITNMENTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gPAPPOITNMENTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gPAPPOITNMENTBindingNavigator.Name = "gPAPPOITNMENTBindingNavigator";
            this.gPAPPOITNMENTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gPAPPOITNMENTBindingNavigator.Size = new System.Drawing.Size(968, 25);
            this.gPAPPOITNMENTBindingNavigator.TabIndex = 0;
            this.gPAPPOITNMENTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // gPAPPOITNMENTBindingNavigatorSaveItem
            // 
            this.gPAPPOITNMENTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gPAPPOITNMENTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gPAPPOITNMENTBindingNavigatorSaveItem.Image")));
            this.gPAPPOITNMENTBindingNavigatorSaveItem.Name = "gPAPPOITNMENTBindingNavigatorSaveItem";
            this.gPAPPOITNMENTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.gPAPPOITNMENTBindingNavigatorSaveItem.Text = "Save Data";
            this.gPAPPOITNMENTBindingNavigatorSaveItem.Click += new System.EventHandler(this.gPAPPOITNMENTBindingNavigatorSaveItem_Click);
            // 
            // gPAPPOINTMENTTextBox
            // 
            this.gPAPPOINTMENTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gPAPPOITNMENTBindingSource, "GPAPPOINTMENT", true));
            this.gPAPPOINTMENTTextBox.Location = new System.Drawing.Point(223, 51);
            this.gPAPPOINTMENTTextBox.Name = "gPAPPOINTMENTTextBox";
            this.gPAPPOINTMENTTextBox.Size = new System.Drawing.Size(100, 20);
            this.gPAPPOINTMENTTextBox.TabIndex = 2;
            // 
            // eMISNumberTextBox
            // 
            this.eMISNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gPAPPOITNMENTBindingSource, "EMISNumber", true));
            this.eMISNumberTextBox.Location = new System.Drawing.Point(223, 83);
            this.eMISNumberTextBox.Name = "eMISNumberTextBox";
            this.eMISNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMISNumberTextBox.TabIndex = 4;
            // 
            // patientFullNameTextBox
            // 
            this.patientFullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gPAPPOITNMENTBindingSource, "PatientFullName", true));
            this.patientFullNameTextBox.Location = new System.Drawing.Point(223, 128);
            this.patientFullNameTextBox.Name = "patientFullNameTextBox";
            this.patientFullNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientFullNameTextBox.TabIndex = 6;
            // 
            // doctorNHSNumberTextBox
            // 
            this.doctorNHSNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gPAPPOITNMENTBindingSource, "DoctorNHSNumber", true));
            this.doctorNHSNumberTextBox.Location = new System.Drawing.Point(575, 54);
            this.doctorNHSNumberTextBox.Name = "doctorNHSNumberTextBox";
            this.doctorNHSNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctorNHSNumberTextBox.TabIndex = 8;
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gPAPPOITNMENTBindingSource, "PatientID", true));
            this.patientIDTextBox.Location = new System.Drawing.Point(575, 80);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientIDTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(223, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(346, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(475, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(628, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 37);
            this.button4.TabIndex = 14;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(87, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 37);
            this.button5.TabIndex = 15;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gPAPPOITNMENTDataGridView
            // 
            this.gPAPPOITNMENTDataGridView.AutoGenerateColumns = false;
            this.gPAPPOITNMENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gPAPPOITNMENTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gPAPPOITNMENTDataGridView.DataSource = this.gPAPPOITNMENTBindingSource;
            this.gPAPPOITNMENTDataGridView.Location = new System.Drawing.Point(171, 254);
            this.gPAPPOITNMENTDataGridView.Name = "gPAPPOITNMENTDataGridView";
            this.gPAPPOITNMENTDataGridView.Size = new System.Drawing.Size(543, 173);
            this.gPAPPOITNMENTDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GPAPPOINTMENT";
            this.dataGridViewTextBoxColumn1.HeaderText = "GPAPPOINTMENT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EMISNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "EMISNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PatientFullName";
            this.dataGridViewTextBoxColumn3.HeaderText = "PatientFullName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DoctorNHSNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "DoctorNHSNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PatientID";
            this.dataGridViewTextBoxColumn5.HeaderText = "PatientID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(968, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 448);
            this.Controls.Add(this.gPAPPOITNMENTDataGridView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(gPAPPOINTMENTLabel);
            this.Controls.Add(this.gPAPPOINTMENTTextBox);
            this.Controls.Add(eMISNumberLabel);
            this.Controls.Add(this.eMISNumberTextBox);
            this.Controls.Add(patientFullNameLabel);
            this.Controls.Add(this.patientFullNameTextBox);
            this.Controls.Add(doctorNHSNumberLabel);
            this.Controls.Add(this.doctorNHSNumberTextBox);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(this.gPAPPOITNMENTBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "GP APPOINTMENT";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPAPPOITNMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPAPPOITNMENTBindingNavigator)).EndInit();
            this.gPAPPOITNMENTBindingNavigator.ResumeLayout(false);
            this.gPAPPOITNMENTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gPAPPOITNMENTDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database7DataSet database7DataSet;
        private System.Windows.Forms.BindingSource gPAPPOITNMENTBindingSource;
        private Database7DataSetTableAdapters.GPAPPOITNMENTTableAdapter gPAPPOITNMENTTableAdapter;
        private Database7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gPAPPOITNMENTBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gPAPPOITNMENTBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox gPAPPOINTMENTTextBox;
        private System.Windows.Forms.TextBox eMISNumberTextBox;
        private System.Windows.Forms.TextBox patientFullNameTextBox;
        private System.Windows.Forms.TextBox doctorNHSNumberTextBox;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView gPAPPOITNMENTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}