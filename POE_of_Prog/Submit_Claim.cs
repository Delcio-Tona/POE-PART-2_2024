using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POE_of_Prog
{
    public partial class Submit_Claim : Form
    {
        public Submit_Claim()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            string hourlyworked = Hourlyworked.Text;
            string course = Course.Text;
            string nu_session = Nu_session.Text;
            string rate = Rate.Text;
            string lecturer_ID = Lecturer_ID.Text;
            string claim_type = Claim_type.Text;
            string total_Claim = Total_Claim.Text;
            string suportive_document = textBox1.Text;
            if (hourlyworked == "")
            {
                MessageBox.Show("insert the  hourlyworked field!");
            }
            if (course == "")
            {
                MessageBox.Show("insert the  course field!");
            }

            if (nu_session == "")
            {
                MessageBox.Show("insert the  nu_session field!");
            }

            if (rate == "")
            {
                MessageBox.Show("insert the  rate field!");
            }

            if (lecturer_ID == "")
            {
                MessageBox.Show("insert the  lecturer_ID field!");
            }

            if (claim_type == "")
            {
                MessageBox.Show("insert the  claim_type field!");
            }

            if (total_Claim == "")
            {
                MessageBox.Show("insert the  total_Claim field!");
            }
            if (suportive_document.Length >= 500)
            {
                MessageBox.Show("long");
            }



            if (!String.IsNullOrEmpty(hourlyworked) && !String.IsNullOrEmpty(course) && !String.IsNullOrEmpty(nu_session) && !String.IsNullOrEmpty(rate) && !String.IsNullOrEmpty(lecturer_ID) && !String.IsNullOrEmpty(claim_type) && !String.IsNullOrEmpty(total_Claim) && !String.IsNullOrEmpty(suportive_document))
            {
                MessageBox.Show("Well done!");
                string connectionstring = "Data Source=labG9AEB3\\SQLEXPRESS;Initial Catalog=Contract_Monthly_Claim;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "Insert into Claim(Course,Session_NUmber,Hourly_Rate,Claim_Type,Supportive_Document,Lecturer_ID)Values('" + course + "','" + nu_session + "','" + rate + "','" + claim_type + "','" + suportive_document + "','" + lecturer_ID + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Claim was successfully sent!");
                Lecturer_DashBoard lecturer_DashBoard = new Lecturer_DashBoard();
                lecturer_DashBoard.Show();
            }
            else
            {
                MessageBox.Show("Error occur");
            }
        }

        private void Submit_Claim_Load(object sender, EventArgs e)
        {

        }

        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "PDF Files|*.pdf|Word Files|*.doc;*.docx|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
                //Empty.Image= new Bitmap(openFileDialog.FileName);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Hourlyworked.Text = "";
            Course.Text = "";
            Nu_session.Text = "";
            Rate.Text = "";
            Lecturer_ID.Text = "";
            Claim_type.Text = "";
            Total_Claim.Text = "";
            textBox1.Text = "";

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Lecturer_DashBoard lecturer_DashBoard = new Lecturer_DashBoard();
            lecturer_DashBoard.Show();
        }

        private void Rate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
