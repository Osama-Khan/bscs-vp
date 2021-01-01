using System.Windows.Forms;
using System.IO;

namespace GUITasks.Tasks
{
    public partial class WK11 : Form
    {
        public WK11()
        {
            InitializeComponent();
            btn_save.Click += OnSave;
            btn_show.Click += OnShow;
        }

        private void OnSave(object o, System.EventArgs e)
        {
            int id, salary;
            string name = txt_name.Text;
            bool parseSuccess = int.TryParse(txt_id.Text, out id);
            parseSuccess = int.TryParse(txt_salary.Text, out salary) && parseSuccess;
            if (parseSuccess)
            {
                FileStream f = new FileStream(@"E:\data.txt", FileMode.Append, FileAccess.Write);
                StreamWriter w = new StreamWriter(f);
                w.WriteLine(id + "," + name + "," + salary);
                w.Close();
            }
        }

        private void OnShow(object o, System.EventArgs e)
        {
            FileStream f = new FileStream(@"E:\data.txt", FileMode.Open, FileAccess.Read);
            StreamReader r = new StreamReader(f);
            string[] rows = r.ReadToEnd().Split('\n');
            f.Close();
            dgv.Rows.Clear();
            foreach(var row in rows)
            {
                if (row == "")
                    break;
                var data = row.Split(',');
                dgv.Rows.Add(data);
            }
        }
    }
}
