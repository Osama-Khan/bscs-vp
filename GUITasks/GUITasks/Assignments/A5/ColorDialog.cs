using System.Drawing;
using System.Windows.Forms;

/* Question 1
 * Create an application in which user will select the color through radio
 * button change the Back ground and the text color of the form by clicking
 * on the apply button as shown figure below and the exit button will close
 * the application.
 */
namespace GUITasks.Assignments.A5
{
    public partial class ColorDialog : Form
    {
        public ColorDialog()
        {
            InitializeComponent();
            btn_apply.Click += (s, e) => onApplyClick();
            btn_exit.Click += (s, e) => Close();
        }

        private void onApplyClick()
        {
            BackColor = rad_back_blue.Checked ? Color.Blue :
                rad_back_green.Checked ? Color.Green :
                rad_back_red.Checked ? Color.Red :
                Color.Gray;
            ForeColor = rad_fore_black.Checked ? Color.Black : Color.White;
        }
    }
}
