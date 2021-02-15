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

namespace Final.Q6
{
    /* Question Number 6: Analyze the following application where a drag drop functionality of a text file has been shown. User can drag and drop a file on textbox. Make sure the drop operation is performed only if the type of file is .txt, otherwise discard the operation. While on successful drop, the path and content of text file should be shown in the required fields. 
     */
    public partial class DragDrop : Form
    {
        public DragDrop()
        {
            InitializeComponent();
            txtContent.DragDrop += OnDrop;
            txtContent.DragEnter += OnEnter; ;
        }

        private void OnEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void OnDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files[0].Split('.').Last() == "txt")
            {
                txtPath.Text = files[0];
                FileStream f = new FileStream(files[0], FileMode.Open, FileAccess.Read);
                StreamReader r = new StreamReader(f);
                txtContent.Text = r.ReadToEnd();
            }
        }
    }
}
