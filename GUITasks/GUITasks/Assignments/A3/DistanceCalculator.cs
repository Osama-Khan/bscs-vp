using System;
using System.Windows.Forms;

/*
 * Question 1:
 * Create an applicationto calculate the average speed. User will enter the distance
 * covered in km and the total time.
 */
namespace GUITasks
{
    public partial class DistanceCalculator : Form
    {
        public DistanceCalculator()
        {
            InitializeComponent();
            btn_calc.Click += Calculate;
            btn_clear.Click += Clear;
            btn_exit.Click += Exit;
        }

        public void Calculate(object s, EventArgs e)
        {
            float d, t;
            try
            {
                d = float.Parse(txt_dist.Text);
                t = float.Parse(txt_time.Text);
            } catch (FormatException)
            {
                // Invalid input
                return;
            }
            txt_spd.Text = (d / t).ToString();
        }

        public void Clear(object s, EventArgs e)
        {
            txt_dist.Text = "";
            txt_time.Text = "";
            txt_spd.Text = "";
        }

        public void Exit(object s, EventArgs e)
        {
            this.Close();
        }
    }
}
