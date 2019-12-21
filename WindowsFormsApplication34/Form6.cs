using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication34
{
    public partial class Form6 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC\Documents\Database7.accdb");
        public Form6()
        {
            InitializeComponent();
        }

        private void pharmacyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pharmacyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database7DataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database7DataSet.Pharmacy' table. You can move, or remove it, as needed.
            this.pharmacyTableAdapter.Fill(this.database7DataSet.Pharmacy);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a;
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Pharmacy values('" + referenceNoTextBox.Text + "','" + nameofTabletTextBox.Text + "','" + noOfTabletTextBox.Text + "','" + dOSE_mg_TextBox.Text + "','" + expDateTextBox.Text + "','" + possibleSideEffectsTextBox.Text + "','" + dailyDoseTextBox.Text + "','" + patientIDTextBox.Text + "')";
                a = cmd.ExecuteNonQuery();
                if (a > 0)
                    MessageBox.Show("Record Inserted successfully");
                conn.Close();
            }
            catch { MessageBox.Show("PLEASE ENTER DATA FEILDS CANNOT BE LEFT EMPTY");
            Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to Exit Pharmacy Report ", "pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit ", "pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            referenceNoTextBox.Clear();
            nameofTabletTextBox.Clear();
            noOfTabletTextBox.Clear();
            dOSE_mg_TextBox.Clear();
            expDateTextBox.Clear();
            possibleSideEffectsTextBox.Clear();
            dailyDoseTextBox.Clear();
            patientIDTextBox.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format("select * from Pharmacy");
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            pharmacyDataGridView.DataSource = ds;
            // doctorDataGridView.DataSource = ds;
            conn.Close();
        }
    }
}
