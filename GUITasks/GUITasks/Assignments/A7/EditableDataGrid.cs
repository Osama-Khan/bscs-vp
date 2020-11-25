using System.Windows.Forms;

namespace GUITasks.Assignments.A7
{
    public partial class EditableDataGrid : Form
    {
        public EditableDataGrid()
        {
            InitializeComponent();
            btn_add.Click += (s, e) => OnAdd();
            dgv.CellClick += OnEdit;
        }

        private void OnAdd()
        {
            string reg = txt_reg.Text,
                name = txt_name.Text,
                phone = txt_phone.Text;
            var row = new object[] { reg, name, phone, "Edit" };
            dgv.Rows.Add(row);
        }

        private void OnEdit(object s, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                string reg = txt_reg.Text,
                    name = txt_name.Text,
                    phone = txt_phone.Text;
                var row = e.RowIndex;
                dgv.Rows[row].Cells[0].Value = reg;
                dgv.Rows[row].Cells[1].Value = name;
                dgv.Rows[row].Cells[2].Value = phone;
            }
        }
    }
}
