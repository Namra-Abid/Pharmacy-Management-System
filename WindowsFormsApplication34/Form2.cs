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
    public partial class Form2 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC\Documents\Database7.accdb");
        public Form2()
        {
            InitializeComponent();
        }

        private void doctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database7DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database7DataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.database7DataSet.Doctor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a;
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Doctor values('" + doctorRefNoTextBox.Text + "','" + firstNameTextBox.Text + "','" + surnameTextBox.Text + "','" + medicalCentreNameTextBox.Text + "','" + addressOfCentreTextBox.Text + "','" + textBox1.Text + "')";
                a = cmd.ExecuteNonQuery();
                if (a > 0)
                    MessageBox.Show("Record Inserted successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PLEASE ENTER DATA FEILDS CANNOT BE LEFT EMPTY");
                Application.Exit();
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to Exit Doctor's Report ", "pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doctorRefNoTextBox.Clear();
            firstNameTextBox.Clear();
            surnameTextBox.Clear();
            medicalCentreNameTextBox.Clear();
            addressOfCentreTextBox.Clear();
            textBox1.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format("select * from Doctor");
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);

            doctorDataGridView.DataSource = ds;
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit ", "pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
