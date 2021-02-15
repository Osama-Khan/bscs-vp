using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.Q1
{
    /*
     * Question Number 1: An example GUI of SignUp page is given below. You are required to implement the design and then write code for SignUp button by considering a database table “signup_tbl” to store the required fields. Note: You have to complete the design of given window form and then submit the screenshots of application. Also provide the code of SignUp button.
     */
    public partial class SignUpPage : Form
    {
        const string strCon = @"----";
        public SignUpPage()
        {
            InitializeComponent();
            btnSignup.Click += OnSignup;
        }

        private void OnSignup(object sender, EventArgs args)
        {
            string fName = txtFirstName.Text,
                lName = txtLastName.Text,
                email = txtEmail.Text,
                dob = dtpDob.Value.ToString(),
                password = txtPassword.Text,
                gender = radGenderMale.Checked ? "Male" : radGenderFemale.Checked ? "Female" : "Other";
            var q = string.Format("insert into signup_tbl values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                fName, lName, email, password, dob, gender);

            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();

            if (new SqlCommand(q, conn).ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data submitted successfully!");
            } 
            else
            {
                MessageBox.Show("Data could not be submitted!");
            }
        }
    }
}
