using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUITasks.Tasks
{
    public partial class WK16 : Form
    {
        const string nameRegex = @"^[a-zA-Z]+$"; // Only letters
        const string passRegex = @"^(([A-z]*\d)([A-z]*))+$"; // Letters and at least one number

        public WK16()
        {
            InitializeComponent();
            btnValidate.Click += (s, e) => OnValidate();
        }

        void OnValidate()
        {
            string name = txtName.Text,
                pass = txtPassword.Text;
            if (Regex.IsMatch(name, nameRegex) && Regex.IsMatch(pass, passRegex))
            {
                MessageBox.Show("Valid pattern!");
            } 
            else
            {
                MessageBox.Show("Invalid pattern!");
            }
        }
    }
}
