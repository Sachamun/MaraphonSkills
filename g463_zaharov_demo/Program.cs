﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace g463_zaharov_demo
{
    static class Program
    {
        public static DateTime start = new DateTime(2019, 11, 24, 06, 00, 00);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
