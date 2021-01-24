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
    public partial class FileSearch : Form
    {
        const char VarSep = '?';
        const char DataSep = ';';
        public FileSearch()
        {
            InitializeComponent();
            btnSearch.Click += (s, e) => onSearch();
        }

        private void onSearch()
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
                    if (data[1].ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        dgv.Rows.Add(new string[] { data[0], data[1], data[2] });
                    }
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {

            }
        }
    }
}
