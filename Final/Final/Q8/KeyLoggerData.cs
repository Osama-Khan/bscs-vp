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

namespace Final.Q8
{
    /*
     * Question Number 8: Read the keyLogger text file created in question number 7 and display the data in a textbox. 	Write code to read set data to text field only
     */
    public partial class KeyLoggerData : Form
    {
        public KeyLoggerData()
        {
            InitializeComponent();
            FileStream f = new FileStream("keyLoggerData.txt", FileMode.Open, FileAccess.Read);
            StreamReader r = new StreamReader(f);
            txtData.Text = r.ReadToEnd();
        }
    }
}
