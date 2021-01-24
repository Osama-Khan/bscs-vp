using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITasks.Assignments.A11
{
    public partial class PointOfSale : Form
    {
        public PointOfSale()
        {
            InitializeComponent();
            addNewStockToolStripMenuItem.Click += (s, e) => openAddStock();
            showTotalStockToolStripMenuItem.Click += (s, e) => openViewStock();
        }

        void openAddStock()
        {
            var f = new AddRecord();
            f.Show();
            f.MdiParent = this;
        }

        void openViewStock()
        {
            var f = new ViewRecords();
            f.Show();
            f.MdiParent = this;
        }
    }
}
