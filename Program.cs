﻿using SlimDX.Windows;
using System;
using System.Windows.Forms;

namespace C0reExternalBase_v2
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new RenderForm();
            
        }
    }
}
