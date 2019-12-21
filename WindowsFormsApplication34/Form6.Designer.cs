namespace WindowsFormsApplication34
{
    partial class Form6
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
            System.Windows.Forms.Label referenceNoLabel;
            System.Windows.Forms.Label nameofTabletLabel;
            System.Windows.Forms.Label noOfTabletLabel;
            System.Windows.Forms.Label dOSE_mg_Label;
            System.Windows.Forms.Label expDateLabel;
            System.Windows.Forms.Label possibleSideEffectsLabel;
            System.Windows.Forms.Label dailyDoseLabel;
            System.Windows.Forms.Label patientIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.database7DataSet = new WindowsFormsApplication34.Database7DataSet();
            this.pharmacyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyTableAdapter = new WindowsFormsApplication34.Database7DataSetTableAdapters.PharmacyTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication34.Database7DataSetTableAdapters.TableAdapterManager();
            this.pharmacyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pharmacyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.referenceNoTextBox = new System.Windows.Forms.TextBox();
            this.nameofTabletTextBox = new System.Windows.Forms.TextBox();
            this.noOfTabletTextBox = new System.Windows.Forms.TextBox();
            this.dOSE_mg_TextBox = new System.Windows.Forms.TextBox();
            this.expDateTextBox = new System.Windows.Forms.TextBox();
            this.possibleSideEffectsTextBox = new System.Windows.Forms.TextBox();
            this.dailyDoseTextBox = new System.Windows.Forms.TextBox();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pharmacyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            referenceNoLabel = new System.Windows.Forms.Label();
            nameofTabletLabel = new System.Windows.Forms.Label();
            noOfTabletLabel = new System.Windows.Forms.Label();
            dOSE_mg_Label = new System.Windows.Forms.Label();
            expDateLabel = new System.Windows.Forms.Label();
            possibleSideEffectsLabel = new System.Windows.Forms.Label();
            dailyDoseLabel = new System.Windows.Forms.Label();
            patientIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingNavigator)).BeginInit();
            this.pharmacyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // referenceNoLabel
            // 
            referenceNoLabel.AutoSize = true;
            referenceNoLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            referenceNoLabel.Location = new System.Drawing.Point(63, 47);
            referenceNoLabel.Name = "referenceNoLabel";
            referenceNoLabel.Size = new System.Drawing.Size(90, 15);
            referenceNoLabel.TabIndex = 1;
            referenceNoLabel.Text = "Reference No:";
            // 
            // nameofTabletLabel
            // 
            nameofTabletLabel.AutoSize = true;
            nameofTabletLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameofTabletLabel.Location = new System.Drawing.Point(63, 73);
            nameofTabletLabel.Name = "nameofTabletLabel";
            nameofTabletLabel.Size = new System.Drawing.Size(97, 15);
            nameofTabletLabel.TabIndex = 3;
            nameofTabletLabel.Text = "Nameof Tablet:";
            // 
            // noOfTabletLabel
            // 
            noOfTabletLabel.AutoSize = true;
            noOfTabletLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noOfTabletLabel.Location = new System.Drawing.Point(63, 99);
            noOfTabletLabel.Name = "noOfTabletLabel";
            noOfTabletLabel.Size = new System.Drawing.Size(130, 15);
            noOfTabletLabel.TabIndex = 5;
            noOfTabletLabel.Text = "NoOfTabletsInWords";
            // 
            // dOSE_mg_Label
            // 
            dOSE_mg_Label.AutoSize = true;
            dOSE_mg_Label.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dOSE_mg_Label.Location = new System.Drawing.Point(63, 125);
            dOSE_mg_Label.Name = "dOSE_mg_Label";
            dOSE_mg_Label.Size = new System.Drawing.Size(70, 15);
            dOSE_mg_Label.TabIndex = 7;
            dOSE_mg_Label.Text = "DOSE(mg):";
            // 
            // expDateLabel
            // 
            expDateLabel.AutoSize = true;
            expDateLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expDateLabel.Location = new System.Drawing.Point(496, 39);
            expDateLabel.Name = "expDateLabel";
            expDateLabel.Size = new System.Drawing.Size(77, 16);
            expDateLabel.TabIndex = 9;
            expDateLabel.Text = "ExpMonth";
            // 
            // possibleSideEffectsLabel
            // 
            possibleSideEffectsLabel.AutoSize = true;
            possibleSideEffectsLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            possibleSideEffectsLabel.Location = new System.Drawing.Point(496, 65);
            possibleSideEffectsLabel.Name = "possibleSideEffectsLabel";
            possibleSideEffectsLabel.Size = new System.Drawing.Size(138, 16);
            possibleSideEffectsLabel.TabIndex = 11;
            possibleSideEffectsLabel.Text = "Possible Side Effects:";
            // 
            // dailyDoseLabel
            // 
            dailyDoseLabel.AutoSize = true;
            dailyDoseLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dailyDoseLabel.Location = new System.Drawing.Point(496, 91);
            dailyDoseLabel.Name = "dailyDoseLabel";
            dailyDoseLabel.Size = new System.Drawing.Size(79, 16);
            dailyDoseLabel.TabIndex = 13;
            dailyDoseLabel.Text = "DailyDose:";
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientIDLabel.Location = new System.Drawing.Point(496, 117);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(104, 16);
            patientIDLabel.TabIndex = 15;
            patientIDLabel.Text = "patientDisease";
            // 
            // database7DataSet
            // 
            this.database7DataSet.DataSetName = "Database7DataSet";
            this.database7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacyBindingSource
            // 
            this.pharmacyBindingSource.DataMember = "Pharmacy";
            this.pharmacyBindingSource.DataSource = this.database7DataSet;
            // 
            // pharmacyTableAdapter
            // 
            this.pharmacyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GPAPPOITNMENTTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = this.pharmacyTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication34.Database7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pharmacyBindingNavigator
            // 
            this.pharmacyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pharmacyBindingNavigator.BindingSource = this.pharmacyBindingSource;
            this.pharmacyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pharmacyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pharmacyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pharmacyBindingNavigatorSaveItem});
            this.pharmacyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pharmacyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pharmacyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pharmacyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pharmacyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pharmacyBindingNavigator.Name = "pharmacyBindingNavigator";
            this.pharmacyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pharmacyBindingNavigator.Size = new System.Drawing.Size(983, 25);
            this.pharmacyBindingNavigator.TabIndex = 0;
            this.pharmacyBindingNavigator.Text = "bindingNavigator1";
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
            // pharmacyBindingNavigatorSaveItem
            // 
            this.pharmacyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pharmacyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pharmacyBindingNavigatorSaveItem.Image")));
            this.pharmacyBindingNavigatorSaveItem.Name = "pharmacyBindingNavigatorSaveItem";
            this.pharmacyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pharmacyBindingNavigatorSaveItem.Text = "Save Data";
            this.pharmacyBindingNavigatorSaveItem.Click += new System.EventHandler(this.pharmacyBindingNavigatorSaveItem_Click);
            // 
            // referenceNoTextBox
            // 
            this.referenceNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "ReferenceNo", true));
            this.referenceNoTextBox.Location = new System.Drawing.Point(271, 44);
            this.referenceNoTextBox.Name = "referenceNoTextBox";
            this.referenceNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.referenceNoTextBox.TabIndex = 2;
            // 
            // nameofTabletTextBox
            // 
            this.nameofTabletTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "NameofTablet", true));
            this.nameofTabletTextBox.Location = new System.Drawing.Point(271, 70);
            this.nameofTabletTextBox.Name = "nameofTabletTextBox";
            this.nameofTabletTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameofTabletTextBox.TabIndex = 4;
            // 
            // noOfTabletTextBox
            // 
            this.noOfTabletTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "NoOfTablet", true));
            this.noOfTabletTextBox.Location = new System.Drawing.Point(271, 96);
            this.noOfTabletTextBox.Name = "noOfTabletTextBox";
            this.noOfTabletTextBox.Size = new System.Drawing.Size(100, 20);
            this.noOfTabletTextBox.TabIndex = 6;
            // 
            // dOSE_mg_TextBox
            // 
            this.dOSE_mg_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "DOSE(mg)", true));
            this.dOSE_mg_TextBox.Location = new System.Drawing.Point(271, 122);
            this.dOSE_mg_TextBox.Name = "dOSE_mg_TextBox";
            this.dOSE_mg_TextBox.Size = new System.Drawing.Size(100, 20);
            this.dOSE_mg_TextBox.TabIndex = 8;
            // 
            // expDateTextBox
            // 
            this.expDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "ExpDate", true));
            this.expDateTextBox.Location = new System.Drawing.Point(721, 37);
            this.expDateTextBox.Name = "expDateTextBox";
            this.expDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.expDateTextBox.TabIndex = 10;
            // 
            // possibleSideEffectsTextBox
            // 
            this.possibleSideEffectsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "PossibleSideEffects", true));
            this.possibleSideEffectsTextBox.Location = new System.Drawing.Point(721, 63);
            this.possibleSideEffectsTextBox.Name = "possibleSideEffectsTextBox";
            this.possibleSideEffectsTextBox.Size = new System.Drawing.Size(100, 20);
            this.possibleSideEffectsTextBox.TabIndex = 12;
            // 
            // dailyDoseTextBox
            // 
            this.dailyDoseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "DailyDose", true));
            this.dailyDoseTextBox.Location = new System.Drawing.Point(721, 89);
            this.dailyDoseTextBox.Name = "dailyDoseTextBox";
            this.dailyDoseTextBox.Size = new System.Drawing.Size(100, 20);
            this.dailyDoseTextBox.TabIndex = 14;
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "patientID", true));
            this.patientIDTextBox.Location = new System.Drawing.Point(721, 115);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientIDTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(208, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 49);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(390, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 49);
            this.button2.TabIndex = 18;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(772, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 49);
            this.button3.TabIndex = 19;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(575, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 49);
            this.button4.TabIndex = 20;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(55, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 49);
            this.button5.TabIndex = 21;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pharmacyDataGridView
            // 
            this.pharmacyDataGridView.AutoGenerateColumns = false;
            this.pharmacyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pharmacyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.pharmacyDataGridView.DataSource = this.pharmacyBindingSource;
            this.pharmacyDataGridView.Location = new System.Drawing.Point(14, 247);
            this.pharmacyDataGridView.Name = "pharmacyDataGridView";
            this.pharmacyDataGridView.Size = new System.Drawing.Size(649, 187);
            this.pharmacyDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ReferenceNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "ReferenceNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NameofTablet";
            this.dataGridViewTextBoxColumn2.HeaderText = "NameofTablet";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NoOfTablet";
            this.dataGridViewTextBoxColumn3.HeaderText = "NoOfTablet";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DOSE(mg)";
            this.dataGridViewTextBoxColumn4.HeaderText = "DOSE(mg)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ExpDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "ExpDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PossibleSideEffects";
            this.dataGridViewTextBoxColumn6.HeaderText = "PossibleSideEffects";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DailyDose";
            this.dataGridViewTextBoxColumn7.HeaderText = "DailyDose";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "patientID";
            this.dataGridViewTextBoxColumn8.HeaderText = "patientID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(983, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 446);
            this.Controls.Add(this.pharmacyDataGridView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(referenceNoLabel);
            this.Controls.Add(this.referenceNoTextBox);
            this.Controls.Add(nameofTabletLabel);
            this.Controls.Add(this.nameofTabletTextBox);
            this.Controls.Add(noOfTabletLabel);
            this.Controls.Add(this.noOfTabletTextBox);
            this.Controls.Add(dOSE_mg_Label);
            this.Controls.Add(this.dOSE_mg_TextBox);
            this.Controls.Add(expDateLabel);
            this.Controls.Add(this.expDateTextBox);
            this.Controls.Add(possibleSideEffectsLabel);
            this.Controls.Add(this.possibleSideEffectsTextBox);
            this.Controls.Add(dailyDoseLabel);
            this.Controls.Add(this.dailyDoseTextBox);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(this.pharmacyBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Pharmacy";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingNavigator)).EndInit();
            this.pharmacyBindingNavigator.ResumeLayout(false);
            this.pharmacyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database7DataSet database7DataSet;
        private System.Windows.Forms.BindingSource pharmacyBindingSource;
        private Database7DataSetTableAdapters.PharmacyTableAdapter pharmacyTableAdapter;
        private Database7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pharmacyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pharmacyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox referenceNoTextBox;
        private System.Windows.Forms.TextBox nameofTabletTextBox;
        private System.Windows.Forms.TextBox noOfTabletTextBox;
        private System.Windows.Forms.TextBox dOSE_mg_TextBox;
        private System.Windows.Forms.TextBox expDateTextBox;
        private System.Windows.Forms.TextBox possibleSideEffectsTextBox;
        private System.Windows.Forms.TextBox dailyDoseTextBox;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView pharmacyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}