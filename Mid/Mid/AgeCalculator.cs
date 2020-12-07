using System.Windows.Forms;
using System;


/* Question Number 3: You are required to code for GUI 
 * given below to calculate age in years, months and 
 * days based on given date of birth.
 */
namespace Mid
{
    public partial class AgeCalculator : Form
    {
        public AgeCalculator()
        {
            InitializeComponent();
            btn_calculate.Click += OnCalculate;
        }

        void OnCalculate(object sender, System.EventArgs args)
        {
            var dob = date_dob.Value;
            var cur = DateTime.Now;
            var years = cur.Year - dob.Year;
            var months = cur.Month - dob.Month;
            var days = cur.Day - dob.Day;
            if (months < 0) { 
                years--;
                months += 12;
            }
            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(dob.Year, dob.Month);
            }


            lbl_days.Text = days + "";
            lbl_months.Text = months + "";
            lbl_years.Text = years + "";
        }           
    }
}
