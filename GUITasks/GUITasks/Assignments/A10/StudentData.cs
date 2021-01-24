using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITasks.Assignments.A10
{
    public partial class StudentData : Form
    {
        const char VarSep = '?';
        const char DataSep = ';';
        public StudentData()
        {
            InitializeComponent();
            btnSave.Click += (s, e) => onSave();
            btnShow.Click += (s, e) => onShow();
        }

        private void onSave()
        {
            string reg = txtReg.Text,
                name = txtName.Text,
                percText = txtPercentage.Text;
            float perc;
            bool percIsNum = float.TryParse(percText, out perc);
            if (percIsNum)
            {
                if (perc > 100 || perc < 0)
                {
                    MessageBox.Show("Percentage must be from 0 to 100!");
                    return;
                }
                FileStream fs = new FileStream("./data.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                var toWrite = string.Format("{0}{1}{2}{1}{3}{4}", reg, VarSep, name, percText, DataSep);
                sw.Write(toWrite);
                sw.Close();
            } 
            else
            {
                MessageBox.Show("Please enter percentage in number");
            }
        }

        private void onShow()
        {
            try
            {
                FileStream fs = new FileStream("./data.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                var rows = sr.ReadToEnd().Split(DataSep);
                dgv.Rows.Clear();
                foreach (var r in rows)
                {
                    if (r == "") break;
                    var data = r.Split(VarSep);
                    dgv.Rows.Add(new string[] { data[0], data[1], data[2] });
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {

            }
        }
    }
}
