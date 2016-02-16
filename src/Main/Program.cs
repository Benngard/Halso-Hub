using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        static void Main()
        {
            MessageBox.Show("" + args[0]);
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            ActivityMain ActivityMain = new ActivityMain();
            User user = new User("testUser");
            Presenter presenter = new Presenter(ActivityMain, user);
			Application.Run(ActivityMain);
		}
	}
}
