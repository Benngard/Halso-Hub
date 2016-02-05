using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Ola Andersson
/// </summary>
namespace Halso_Hub
{
    /// <summary>
    /// Used for starting another executable program.
    /// </summary>
    public class FakeMain
    {
        public string User { get; private set; }

        public FakeMain(string user)
        {
            User = user;
        }

        /// <summary>
        /// Method for starting an executable program.
        /// </summary>
        /// <param name="user"></param>string representing a user in the database
        public void executeProgram(string user)
        {
            System.Diagnostics.Process.Start("firefox.exe");
        }
    }
}