using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PassForge.forms
{
    public partial class home_details : Form
    {
        public home_details()
        {
            InitializeComponent();
        }

        private void home_details_Load(object sender, EventArgs e)
        {
            description.Text = "PassForge is an advanced password security analyzer designed \nto evaluate password strength and identify potential security \nweaknesses. It analyzes password length, character complexity, \ncommon patterns, and other security factors to provide a clear " +
                "\nstrength score and personalized recommendations. \n\n\nCreate stronger, more secure passwords with PassForge.";
        }
    }
}
