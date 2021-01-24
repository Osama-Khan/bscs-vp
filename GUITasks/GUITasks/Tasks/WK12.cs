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
    public partial class WK12 : Form
    {
        public WK12()
        {
            InitializeComponent();
            strip_btn_back.Click += (s, e) => OnButtonBack();
            strip_btn_fore.Click += (s, e) => OnButtonFore();
            strip_btn_font.Click += (s, e) => OnButtonFont();
        }

        void OnButtonBack()
        {
            DialogResult dr = dialog_color.ShowDialog();
            if (dr == DialogResult.OK)
            {
                BackColor = dialog_color.Color;
            }
        }

        void OnButtonFore()
        {
            DialogResult dr = dialog_color.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ForeColor = dialog_color.Color;
            }
        }

        void OnButtonFont()
        {
            DialogResult dr = dialog_font.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Font = dialog_font.Font;
            }
        }
    }
}
