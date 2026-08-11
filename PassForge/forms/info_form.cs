using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PassForge.forms
{
    public partial class info_form : Form
    {
        public info_form()
        {
            InitializeComponent();
        }

        private void info_form_Load(object sender, EventArgs e)
        {
            label1.Text = "PassForge is an advanced password security analyzer designed \nto help users understand and improve the strength of their passwords.\n\n" +
                          "The application analyzes important security factors such as password length,\n" +
                          "uppercase and lowercase characters, numbers, special characters, and common\n" +
                          "password patterns. Based on these checks, PassForge generates a security score \nand " +
                          "provides personalized recommendations to help users create stronger and \nmore secure passwords." +
                          "\n\n" +
                          "Key Features\n\n" +
                          "▶ Password strength analysis\n" +
                          "▶ Security score and visual strength indicator\n" +
                          "▶ Character complexity analysis\n" +
                          "▶ Number and special character detection\n" +
                          "▶ Common password detection\n" +
                          "▶ Personalized security recommendations\n" +
                          "▶ Local password analysis for improved privacy\n" +
                          "\n" +
                          "PassForge — Build stronger passwords. Stay more secure.\n";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
