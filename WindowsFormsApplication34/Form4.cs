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
    public partial class Form4 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC\Documents\Database7.accdb");
        public Form4()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database7DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database7DataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.database7DataSet.Patient);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a;
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Patient values('" + firstNameTextBox.Text + "','" + surnameTextBox.Text + "','" + dateOfBirthTextBox.Text + "','" + addressTextBox.Text + "','" + mobileNoTextBox.Text + "','" + cityTextBox.Text + "')";
                a = cmd.ExecuteNonQuery();
                if (a > 0)
                    MessageBox.Show("Record Inserted successfully");
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("PLEASE ENTER DATA FEILDS CANNOT BE LEFT EMPTY");
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to Exit Patient Report ", "pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Clear();
            surnameTextBox.Clear();
            dateOfBirthTextBox.Clear();
            addressTextBox.Clear();
            mobileNoTextBox.Clear();
            cityTextBox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit ", "pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format("select * from Patient");
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            patientDataGridView.DataSource = ds;
            // doctorDataGridView.DataSource = ds;
            conn.Close();
        }
    }
}
