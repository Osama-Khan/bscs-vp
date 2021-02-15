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

namespace Final.Q4
{
    /*
     *Question Number 4: Air Sial is a new airline company and wants to expand their services by allowing travel agents and website owners to use their booking services. The application has the following database schema.
     * •	Customer (cust_id, name, passportNo, email, password)
     * •	Flight ( flight_id, from, destination, seating_capacity )
     * •	Booking (bk_id, flight_no, fare_rate, meals, cust_id, seat_no)
     * •	Schedule (flight_id, origon, dest, depart_dateTime, land_dateTime)
     *You are required to design a system for travel agents where they can search available flights by providing start and destination of flight along with date interval. The system should be able to display available flights with their schedule.
     */
    public partial class AirSialBooking : Form
    {
        const string strCon = @"---";
        public AirSialBooking()
        {
            InitializeComponent();
            btnFetch.Click += Fetch;
        }

        void Fetch(object sender, EventArgs args)
        {
            string origin = txtOrigin.Text != "" ? txtOrigin.Text : "%";
            string dest = txtDestination.Text != "" ? txtDestination.Text : "%";
            var conn = new SqlConnection(strCon);
            var q = string.Format(
                "select flight_id, from, destination, seating_capacity from flight" +
                "join schedule on schedule.origin like '{0}' and schedule.dest like '{1}'" +
                "and schedule.depart between '{2}' and '{3}'",
                origin, dest, dtpStart.Value.ToString(), dtpEnd.Value.ToString());
            conn.Open();
            var reader = new SqlCommand(q, conn).ExecuteReader();
            dgv.Rows.Clear();
            while (reader.Read())
            {
                var row = new string[] {
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4)
                };
                dgv.Rows.Add(row);
            }
        }
    }
}
