﻿using COMP123_S2019_LESSON13B_PART1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_LESSON13B_PART1
{
    static class Program
    {
        public static StartForm startform;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            startform = new StartForm();
            Application.Run(startform);
        }
    }
}
