﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace My_Controls
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_My_Controls());
        }
    }
}
