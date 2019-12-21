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
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC\Documents\Database7.accdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "OOP" && txtPassword.Text == "0000")
            {
                button6.Enabled = true;
                button5.Enabled = true;
                button1.Enabled = true;
                button5.Enabled = true;
                button4.Enabled = true;
                button3.Enabled = true;
                btnPharmacy_Office.Enabled = true;

                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter Correct Login Details", "Pharmacy Management System");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
            button6.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
            btnPharmacy_Office.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to Exit Pharmacy Management System  ", "pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
            btnPharmacy_Office.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Doctor = new Form2();
            Doctor.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 GP = new Form3();
            GP.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 patient = new Form4();
            patient.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 payment = new Form5();
            payment.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 pharmacy = new Form6();
            pharmacy.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit ", "pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
