﻿using System;
using System.Windows.Forms;

namespace Final
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Q5.Phonebook());
        }
    }
}
