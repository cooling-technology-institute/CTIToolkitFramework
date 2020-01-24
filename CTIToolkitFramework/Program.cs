﻿// Copyright Cooling Technology Institute 2019-2020

using System;
using System.Windows.Forms;

namespace CTIToolkit
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
            Application.Run(new ToolkitMain());
        }
    }
}