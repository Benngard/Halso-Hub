using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Halso_Hub.Main;

/// <summary>
/// Main class starting program
/// </summary>
/// Author: Daniel Edsinger

namespace Halso_Hub
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            if (args.Length > 0)
            {
                MessageBox.Show("" + args[0]);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm MainForm = new MainForm();
            User user = new User("Mattias");
            Presenter presenter = new Presenter(MainForm, user);
            Application.Run(MainForm);
        }
    }
}
