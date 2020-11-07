using System.Windows.Forms;

/*
 * Question 1
 * You are required to create application in which User will enter the
 * temperature and convert it into the Fahrenheit or the Celsius.
 */
namespace GUITasks.Assignments.A4
{
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
            btn_convert.Click += (e, s) => Convert();
        }

        public void Convert()
        {
            float input;
            if (float.TryParse(txt_input.Text, out input))
            {
                if (rad_celsius.Checked)
                {
                    var temp = (input - 32) * 5f/9f;
                    txt_output.Text = temp.ToString();
                }
                else
                {
                    var temp = (input * 9f / 5f) + 32;
                    txt_output.Text = temp.ToString();
                }
            }
            else
            {
                MessageBox.Show("Invalid input given, please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
