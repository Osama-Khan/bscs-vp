using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace GUITasks.Assignments.A9
{
    public partial class ProductSearch : Form
    {
        const string strCon = @"----";
        DataSet ds = new DataSet();

        public ProductSearch()
        {
            InitializeComponent();
            btn_search.Click += (s, e) => OnSearch();
            btn_update.Click += (s, e) => OnUpdate();
        }

        private void OnSearch()
        {
            var name = txt_search.Text;
            int id;
            bool hasId = int.TryParse(name, out id);

            var conn = new SqlConnection(strCon);
            var q = string.Format(
                "select * from product where name like '%{0}%'", 
                name);
            if (hasId)
            {
                q += " or id = " + id;
            }

            conn.Open();
            var cmd = new SqlCommand(q, conn);
            var adapter = new SqlDataAdapter(cmd);
            ds.Reset();
            adapter.Fill(ds, "Table");
            dgv.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void OnUpdate()
        {
            var conn = new SqlConnection(strCon);
            var q = "select * from product";
            var cmd = new SqlCommand(q, conn);
            var adapter = new SqlDataAdapter(cmd);
            new SqlCommandBuilder(adapter);
            adapter.Update(ds);
            ds.Tables[0].AcceptChanges();
        }
    }
}
