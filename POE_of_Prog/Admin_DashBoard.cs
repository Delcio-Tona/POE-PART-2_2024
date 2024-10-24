using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POE_of_Prog
{
    public partial class Admin_DashBoard : Form
    {
        public Admin_DashBoard()
        {
            InitializeComponent();
        }

        private void VerifyClaim_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "select Lecturer.First_Name,Lecturer.Lecturer_ID,Claim.Claim_ID,Claim.Course,Claim.Hourly_Rate,Claim.Session_NUmber,Claim.Claim_Type from Claim inner join Lecturer on Claim.Lecturer_ID=Lecturer.Lecturer_ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string nul1l = "Pending";
            string adminId = ADmin.Text;
            string claim = Claim.Text;
            string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query1 = "insert into Approval(Admin_ID,Claim_ID,Decision) values('" + adminId + "','" + claim + "','" + nul1l + "')";
            //query1 = "update Approval set Decision='Pending' where Decision is null";
            //string query = "select* from Approval";
            SqlCommand cmd = new SqlCommand(query1, conn);
            MessageBox.Show("Status has been succesfully saved");
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView2.DataSource = dt;
        }

        private void Status_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "select* from Approval";
            SqlCommand cmd = new SqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView2.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string approval = Approval_ID.Text;
            if (!String.IsNullOrEmpty(approval))
            {
                string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                string query = "update Approval set Decision='Approved' where Approval_ID= '" + approval + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView2.DataSource = dt;
                MessageBox.Show("Approval_ID " + approval + " has been succesfully Approved");
            }
            else
            {
                MessageBox.Show("Fill up the Appraval ID field");
            }
        }

        private void reject_Click(object sender, EventArgs e)
        {
            string approval = Approval_ID.Text;
            if (!String.IsNullOrEmpty(approval))
            {
                string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                string query = "update Approval set Decision='Rejected' where Approval_ID= '" + approval + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView2.DataSource = dt;
                MessageBox.Show("Approval_ID " + approval + " has been Rejected");
            }
            else
            {
                MessageBox.Show("Fill up the Appraval ID field");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
