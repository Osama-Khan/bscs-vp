using System;
using System.Windows.Forms;

/* Question 2
 * Create a c# application for the Admission Form in which user
 * will enter the name, percentage of marks, contact No. and gender.
 * Add button will add all the information in the dataGridView as 
 * shown in the figure below.
 */
namespace GUITasks.Assignments.A5
{
    public partial class AdmissionForm : Form
    {
        public AdmissionForm()
        {
            InitializeComponent();
            btn_add.Click += onAdd;
        }

        private void onAdd(object s, EventArgs e)
        {
            string[] data = {
                txt_name.Text,
                txt_percentage.Text,
                rad_gender_m.Checked? "male": "female",
                txt_contact.Text
            };
            dgv.Rows.Add(data);
        }
    }
}
