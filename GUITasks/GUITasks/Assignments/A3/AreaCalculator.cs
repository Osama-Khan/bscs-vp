using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
 * Question 2:
 * Create an application to calculate the area. User will enter the 
 * height and calculate button will calculate the area.
 */
namespace GUITasks.Assignments.A3
{
    public partial class AreaCalculator : Form
    {
        public AreaCalculator()
        {
            InitializeComponent();
            btn_calc.Click += Calculate;
            btn_clear.Click += Clear;
            btn_exit.Click += Exit;
        }

        public void Calculate(object s, EventArgs e)
        {
            int w, h;
            try
            {
                w = int.Parse(txt_w.Text);
                h = int.Parse(txt_h.Text);
            }
            catch (FormatException _)
            {
                // Invalid input
                return;
            }
            txt_area.Text = (w * h).ToString();
        }

        public void Clear(object s, EventArgs e)
        {
            txt_w.Text = "";
            txt_h.Text = "";
            txt_area.Text = "";
        }

        public void Exit(object s, EventArgs e)
        {
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.C))
                btn_calc.PerformClick();

            else if (keyData == (Keys.Alt | Keys.R))
                btn_clear.PerformClick();

            else if (keyData == (Keys.Alt | Keys.X))
                btn_exit.PerformClick();

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
