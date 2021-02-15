using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.Q9
{
    /*
     * Question Number 9: Use the concept of regular expression and update the code of SignUp button (of Question 1) by considering the following rules:
     * •	First name and Surname fields should not contain numeric data. Only alphabets with spaces are allowed.
     * •	Length of password should be greater than 5 and only numbers and letters are allowed. 
     */
    public partial class SignUpPage : Form
    {
        const string strCon = @"----";
        const string nameRegex = @"^[a-zA-Z ]+$";
        const string passRegex = @"^([A-Za-z0-9]){6,}$";

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
            if (Regex.IsMatch(fName, nameRegex) && Regex.IsMatch(lName, nameRegex) && Regex.IsMatch(password, passRegex))
            {
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
            } else
            {
                MessageBox.Show("Invalid Data!");
            }
        }
    }
}
