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

namespace GUITasks.Assignments.A11
{
    public partial class ViewRecords : Form
    {
        const string strCon = @"----";
        public ViewRecords()
        {
            InitializeComponent();
            loadRecords();
        }

        void loadRecords()
        {
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            var q = "select * from product";
            SqlCommand cmd = new SqlCommand(q, con);
            var reader = cmd.ExecuteReader();
            dgv.Rows.Clear();
            while (reader.Read())
            {
                dgv.Rows.Add(new string[] { 
                    reader.GetInt32(1).ToString(),
                    reader.GetFloat(2).ToString(),
                    reader.GetInt32(3).ToString()
                });
            }
            con.Close();
        }
    }
}
