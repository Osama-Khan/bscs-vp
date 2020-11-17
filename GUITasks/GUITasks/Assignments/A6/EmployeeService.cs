using System.Windows.Forms;
/* Question 2:
 * Create a c# application from which user will enter the
 * employ number and the name of  the employee and select
 * the joining and the resigning date .and the calculate
 * service button will calculate the total service of the
 * employee.
 */
namespace GUITasks.Assignments.A6
{
    public partial class EmployeeService : Form
    {
        public EmployeeService()
        {
            InitializeComponent();
            btn_calculate.Click += (s,e) => Calculate();
        }

        private void Calculate()
        {
            long joinTicks = date_join.Value.Ticks,
                resignTicks = date_resign.Value.Ticks,
                serviceTicks = resignTicks - joinTicks;
            if (serviceTicks < 0)
            {
                MessageBox.Show("Join date must be before Resign.");
            } else
            {
                var days = ((serviceTicks / 10000000)/60/60/24);
                txt_service.Text = days + " days.";
            }
        }
    }
}
