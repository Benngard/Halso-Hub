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
    public partial class FakeMain : Form
    {
        public string User { get; private set; }

        public FakeMain(string user)
        {
            User = user;
            InitializeComponent();
            this.button1.Text = "CLICK ME";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            executeProgram("" + user);
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