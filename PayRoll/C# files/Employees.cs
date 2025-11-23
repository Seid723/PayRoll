using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace PayRoll
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            ShowEmployee();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }
        private void ShowEmployee()
        {
            Con.Open();
            string Query = "Select * from EmployeeTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query,Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeeDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\PayRollDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True");
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpGenCb.SelectedIndex == -1 || EmpAddTb.Text == "" || EmpSalTb.Text == "" || EmpQualCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!", "Error");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTb1(EmpName,EmpGen,EmpDOB,EmpPhone,EmpAdd,EmpPos,JoinDate,EmpQual,EmpBasSal)values(@EN,@EG,@ED,@EP,@EA,@EPos,@JD,@EQ,@EBS)", Con);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EG", EmpGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmpPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                    cmd.Parameters.AddWithValue("@EPos", EmpPosCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@JD", JDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EQ", EmpQualCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EBS", EmpSalTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Saved", "Succesfull");
                    Con.Close();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EmpGenCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
