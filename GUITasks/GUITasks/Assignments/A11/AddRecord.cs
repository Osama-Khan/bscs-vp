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
    public partial class AddRecord : Form
    {
        const string strCon = @"----";
        public AddRecord()
        {
            InitializeComponent();
            btnAddRecord.Click += (s, e) => onAdd();
        }

        void onAdd()
        {
            int id, qty; float price;
            bool valid = int.TryParse(txtNumber.Text, out id);
            valid = int.TryParse(txtQty.Text, out qty) && valid;
            valid = float.TryParse(txtPrice.Text, out price) && valid;
            if (!valid)
            {
                MessageBox.Show("Invalid values!");
                return;
            }

            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            var q = string.Format("insert into products values ({0}, {1}, {2})", id, qty, price);
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
