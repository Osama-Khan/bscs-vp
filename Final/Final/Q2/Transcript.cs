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

namespace Final.Q2
{
    /*Question Number 2: Analyze the following windows application and write code to display the transcript of selected student (registration number) by considering the following tables. 
     *  •	student (regNo, Name, Dob, Program, CGPA, image_path)
     *  •	course(crs_code, crs_title, credit_hours, grade)
     *User can select registration number from combobox and the system should display the transcript of selected student in a gridView.
     */

    public partial class Transcript : Form
    {
        const string strCon = @"----";
        DataSet ds = new DataSet();
        List<Student> students;

        public Transcript()
        {
            InitializeComponent();
            LoadData();
            cmbStudent.SelectedValueChanged += OnComboChange;
            // cmbStudent.Items.Add("2018-ARID-0139");
            // pict.Image = Image.FromFile(@"C:\Users\Osama\OneDrive\Desktop\Screenshot 2021-02-10 055424.png");
            // lblReg.Text = "2018-ARID-0139";
            // lblName.Text = "Osama Khan";
            // lblDob.Text = "29/11/1997";
            // lblProgram.Text = "BSCS";
            // lblCgpa.Text = "" + 3.76;
        }

        void LoadData()
        {
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            var query = "select * from student";
            SqlCommand cmd = new SqlCommand(query, con);
            var reader = cmd.ExecuteReader();
            students = new List<Student>();
            while (reader.Read())
            {
                var s = new Student();
                s.regNo = reader.GetString(1);
                s.name = reader.GetString(2);
                s.dob = reader.GetString(3);
                s.program = reader.GetString(4);
                s.cgpa = reader.GetFloat(5);
                s.image = reader.GetString(6);
                students.Add(new Student());
                cmbStudent.Items.Add(s.regNo);
            }
            con.Close();
        }

        Student GetStudentByReg(string reg)
        {
            foreach (var s in students)
            {
                if (s.regNo == reg)
                {
                    return s;
                }
            }
            return null;
        }

        void OnComboChange(object sender, EventArgs args)
        {
            var regSelected = cmbStudent.SelectedItem.ToString();
            var s = GetStudentByReg(regSelected);
            if (s != null)
            {
                UpdateStudentData(s);
                UpdateCourseData(regSelected);
            } 
            else
            {
                MessageBox.Show("Error with combobox!");
            }
        }

        void UpdateStudentData(Student s)
        {
            lblReg.Text = s.regNo;
            lblName.Text= s.name;
            lblDob.Text = s.dob;
            lblProgram.Text = s.program;
            lblCgpa.Text = "" + s.cgpa;
            pict.Image = Image.FromFile(s.image);
        }

        void UpdateCourseData(string reg)
        {
            var conn = new SqlConnection(strCon);
            var q = string.Format(
                "select * from course where regNo like '{0}'",
                reg);
            conn.Open();
            var cmd = new SqlCommand(q, conn);
            var adapter = new SqlDataAdapter(cmd);
            ds.Reset();
            adapter.Fill(ds, "Table");
            ds.Tables[0].Columns.RemoveAt(0); // Remove RegNo column
            dgv.DataSource = ds.Tables[0];
            conn.Close();
        }
    }

    class Student
    {
        public string regNo;
        public string name;
        public string dob;
        public string program;
        public float cgpa;
        public string image;
    }
}
