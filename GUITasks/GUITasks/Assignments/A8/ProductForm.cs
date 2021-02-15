using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

/* Question:
 * User enter ID and click on Fetch button, it will get record
 * from Database against the given ID and display Name and Price 
 * and disable ID text box and also disable Insert button. So 
 * user can update or delete the fetched record. On reset it will 
 * bring the form and fields on normal state. You have to 
 * implement all button functionality.
 * Table: Student(id int, name text, price float)
 */

namespace GUITasks.Assignments.A8
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            btn_reset.Click += (s, e) => Reset();
            btn_insert.Click += (s, e) => OnInsert();
            btn_fetch.Click += (s, e) => OnFetch();
            btn_update.Click += (s, e) => OnUpdate();
            btn_delete.Click += (s, e) => OnDelete();
        }

        void Reset()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_price.Text = "";
            txt_id.ReadOnly = false;
            txt_name.ReadOnly = false;
            txt_price.ReadOnly = false;

            btn_insert.Enabled = true;
        }

        void OnInsert()
        {
            var query = string.Format(
                "insert into product values ({0}, '{1}', {2})",
                txt_id.Text,
                txt_name.Text,
                txt_price.Text
                );
            DBManager.NonQuery(query);
            Reset();
        }

        void OnFetch()
        {
            var query = "select * from product where id = " + txt_id.Text;
            var recs = DBManager.Reader(query);
            if (recs.Count > 0)
            {
                txt_name.Text = recs[0];
                txt_price.Text = recs[1];
                txt_id.ReadOnly = true;
                btn_insert.Enabled = false;
            }

        }

        void OnUpdate()
        {
            var query = string.Format(
                "update product set name = '{1}', price = {2} where id = {0}",
                txt_id.Text,
                txt_name.Text,
                txt_price.Text
                );
            DBManager.NonQuery(query);
            Reset();
        }

        void OnDelete()
        {
            var query = "delete from product where id = " + txt_id.Text;
            DBManager.NonQuery(query);
            Reset();
        }
    }

    class DBManager
    {
        const string connString = @"----";

        public static int NonQuery(string query)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            var rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;
        }

        public static List<string> Reader(string query)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            var reader = cmd.ExecuteReader();
            var records = new List<string>(2);
            if (reader.Read())
            {
                records.Add(reader.GetString(1));
                records.Add(reader.GetDouble(2).ToString());
            }
            con.Close();
            return records;
        }
    }
}
