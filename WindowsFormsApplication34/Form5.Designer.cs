namespace WindowsFormsApplication34
{
    partial class Form5
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
            System.Windows.Forms.Label invoiceNoLabel;
            System.Windows.Forms.Label methodofpaymentLabel;
            System.Windows.Forms.Label debitCardNoLabel;
            System.Windows.Forms.Label cashPaidLabel;
            System.Windows.Forms.Label patientIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.database7DataSet = new WindowsFormsApplication34.Database7DataSet();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new WindowsFormsApplication34.Database7DataSetTableAdapters.PaymentTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication34.Database7DataSetTableAdapters.TableAdapterManager();
            this.paymentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.paymentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.invoiceNoTextBox = new System.Windows.Forms.TextBox();
            this.methodofpaymentTextBox = new System.Windows.Forms.TextBox();
            this.debitCardNoTextBox = new System.Windows.Forms.TextBox();
            this.cashPaidTextBox = new System.Windows.Forms.TextBox();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.paymentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            invoiceNoLabel = new System.Windows.Forms.Label();
            methodofpaymentLabel = new System.Windows.Forms.Label();
            debitCardNoLabel = new System.Windows.Forms.Label();
            cashPaidLabel = new System.Windows.Forms.Label();
            patientIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingNavigator)).BeginInit();
            this.paymentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceNoLabel
            // 
            invoiceNoLabel.AutoSize = true;
            invoiceNoLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            invoiceNoLabel.Location = new System.Drawing.Point(76, 54);
            invoiceNoLabel.Name = "invoiceNoLabel";
            invoiceNoLabel.Size = new System.Drawing.Size(102, 20);
            invoiceNoLabel.TabIndex = 1;
            invoiceNoLabel.Text = "Invoice No:";
            // 
            // methodofpaymentLabel
            // 
            methodofpaymentLabel.AutoSize = true;
            methodofpaymentLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            methodofpaymentLabel.Location = new System.Drawing.Point(76, 85);
            methodofpaymentLabel.Name = "methodofpaymentLabel";
            methodofpaymentLabel.Size = new System.Drawing.Size(160, 20);
            methodofpaymentLabel.TabIndex = 3;
            methodofpaymentLabel.Text = "Methodofpayment:";
            // 
            // debitCardNoLabel
            // 
            debitCardNoLabel.AutoSize = true;
            debitCardNoLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            debitCardNoLabel.Location = new System.Drawing.Point(76, 124);
            debitCardNoLabel.Name = "debitCardNoLabel";
            debitCardNoLabel.Size = new System.Drawing.Size(130, 20);
            debitCardNoLabel.TabIndex = 5;
            debitCardNoLabel.Text = "Debit Card No:";
            // 
            // cashPaidLabel
            // 
            cashPaidLabel.AutoSize = true;
            cashPaidLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cashPaidLabel.Location = new System.Drawing.Point(632, 59);
            cashPaidLabel.Name = "cashPaidLabel";
            cashPaidLabel.Size = new System.Drawing.Size(152, 20);
            cashPaidLabel.TabIndex = 7;
            cashPaidLabel.Text = "CashPaidInWords";
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientIDLabel.Location = new System.Drawing.Point(632, 112);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(130, 20);
            patientIDLabel.TabIndex = 9;
            patientIDLabel.Text = "PatientDisease";
            // 
            // database7DataSet
            // 
            this.database7DataSet.DataSetName = "Database7DataSet";
            this.database7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.database7DataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GPAPPOITNMENTTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = this.paymentTableAdapter;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication34.Database7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paymentBindingNavigator
            // 
            this.paymentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paymentBindingNavigator.BindingSource = this.paymentBindingSource;
            this.paymentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.paymentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paymentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.paymentBindingNavigatorSaveItem});
            this.paymentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.paymentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paymentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paymentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paymentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paymentBindingNavigator.Name = "paymentBindingNavigator";
            this.paymentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.paymentBindingNavigator.Size = new System.Drawing.Size(970, 25);
            this.paymentBindingNavigator.TabIndex = 0;
            this.paymentBindingNavigator.Text = "bindingNavigator1";
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
            // paymentBindingNavigatorSaveItem
            // 
            this.paymentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paymentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentBindingNavigatorSaveItem.Image")));
            this.paymentBindingNavigatorSaveItem.Name = "paymentBindingNavigatorSaveItem";
            this.paymentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.paymentBindingNavigatorSaveItem.Text = "Save Data";
            this.paymentBindingNavigatorSaveItem.Click += new System.EventHandler(this.paymentBindingNavigatorSaveItem_Click);
            // 
            // invoiceNoTextBox
            // 
            this.invoiceNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "InvoiceNo", true));
            this.invoiceNoTextBox.Location = new System.Drawing.Point(260, 50);
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceNoTextBox.TabIndex = 2;
            // 
            // methodofpaymentTextBox
            // 
            this.methodofpaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Methodofpayment", true));
            this.methodofpaymentTextBox.Location = new System.Drawing.Point(260, 84);
            this.methodofpaymentTextBox.Name = "methodofpaymentTextBox";
            this.methodofpaymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.methodofpaymentTextBox.TabIndex = 4;
            // 
            // debitCardNoTextBox
            // 
            this.debitCardNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "DebitCardNo", true));
            this.debitCardNoTextBox.Location = new System.Drawing.Point(260, 120);
            this.debitCardNoTextBox.Name = "debitCardNoTextBox";
            this.debitCardNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.debitCardNoTextBox.TabIndex = 6;
            // 
            // cashPaidTextBox
            // 
            this.cashPaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "CashPaid", true));
            this.cashPaidTextBox.Location = new System.Drawing.Point(814, 55);
            this.cashPaidTextBox.Name = "cashPaidTextBox";
            this.cashPaidTextBox.Size = new System.Drawing.Size(100, 20);
            this.cashPaidTextBox.TabIndex = 8;
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "PatientID", true));
            this.patientIDTextBox.Location = new System.Drawing.Point(814, 108);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientIDTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(53, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(53, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(799, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(799, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 48);
            this.button4.TabIndex = 14;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(53, 241);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 41);
            this.button5.TabIndex = 15;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // paymentDataGridView
            // 
            this.paymentDataGridView.AutoGenerateColumns = false;
            this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.paymentDataGridView.DataSource = this.paymentBindingSource;
            this.paymentDataGridView.Location = new System.Drawing.Point(223, 241);
            this.paymentDataGridView.Name = "paymentDataGridView";
            this.paymentDataGridView.Size = new System.Drawing.Size(539, 192);
            this.paymentDataGridView.TabIndex = 16;
            this.paymentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "InvoiceNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Methodofpayment";
            this.dataGridViewTextBoxColumn2.HeaderText = "Methodofpayment";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DebitCardNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "DebitCardNo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CashPaid";
            this.dataGridViewTextBoxColumn4.HeaderText = "CashPaid";
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
            this.pictureBox1.Size = new System.Drawing.Size(970, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.paymentDataGridView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(invoiceNoLabel);
            this.Controls.Add(this.invoiceNoTextBox);
            this.Controls.Add(methodofpaymentLabel);
            this.Controls.Add(this.methodofpaymentTextBox);
            this.Controls.Add(debitCardNoLabel);
            this.Controls.Add(this.debitCardNoTextBox);
            this.Controls.Add(cashPaidLabel);
            this.Controls.Add(this.cashPaidTextBox);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(this.paymentBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "PAYMENT";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingNavigator)).EndInit();
            this.paymentBindingNavigator.ResumeLayout(false);
            this.paymentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database7DataSet database7DataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private Database7DataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private Database7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paymentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton paymentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox invoiceNoTextBox;
        private System.Windows.Forms.TextBox methodofpaymentTextBox;
        private System.Windows.Forms.TextBox debitCardNoTextBox;
        private System.Windows.Forms.TextBox cashPaidTextBox;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView paymentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}