using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace GUITasks.Tasks
{
    public partial class Wk10 : Form
    {
        DataSet ds = new DataSet();

        public Wk10()
        {
            InitializeComponent();
            btn_show_data.Click += (s, e) => onClickShowData();
        }

        private void onClickShowData()
        {
            var strCon = @"----";
            var conn = new SqlConnection(strCon);
            conn.Open();
            var q = "select * from student";
            var cmd = new SqlCommand(q, conn);

            var adapter = new SqlDataAdapter(cmd);
            ds.Reset();
            adapter.Fill(ds, "std");
            dgv.DataSource = ds.Tables[0];
        }
    }
}
