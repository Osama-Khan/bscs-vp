using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITasks.Tasks
{
    public partial class WK13 : Form
    {
        public WK13()
        {
            InitializeComponent();
            btnGet.Click += OnButtonGetClick;
            btnAdd.Click += OnButtonAddClick;
        }

        private void OnButtonGetClick(Object sender, EventArgs e) 
        {
            tree.Nodes.Add("101");
            tree.Nodes[0].Nodes.Add("Ali");
            tree.Nodes.Add("102");
            tree.Nodes[1].Nodes.Add("Hashim");
            tree.Nodes.Add("103");
            tree.Nodes[2].Nodes.Add("Junaid");
            tree.Nodes.Add("104");
            tree.Nodes[3].Nodes.Add("Zain");
        }

        private void OnButtonAddClick(Object sender, EventArgs e)
        {
            var selected = tree.SelectedNode;
            if (selected.Parent != null) { 
                var c1 = selected.Parent.Text;
                var c2 = selected.Text;
                dgv.Rows.Add(new string[] { c1, c2 });
            }
            else
            {
                var c1 = selected.Text;
                var c2 = selected.Nodes[0].Text;
                dgv.Rows.Add(new string[] { c1, c2 });
            }
        }
    }
}
