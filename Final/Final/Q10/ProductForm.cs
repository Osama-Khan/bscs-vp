using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

/* Question Number 10: Suppose you have a table named Product (ID, Name, Price) in database with following GUI. 
 * •	Insert button is used to save data in database
 * •	To update the data user first enter the ID and then click fetch button
 * •	Fetch button will fetch the required data in ID, Name and Price Fields and then update button will update the given data
 * •	Delete button will delete the product of given ID
 * •	Reset button will reset all fields
 */

namespace Final.Q10
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
        const string connString = @"Initial Catalog=VP;Data Source=DESKTOP-G02T2H3\SQLEXPRESS;user=sa;password=1234";

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
