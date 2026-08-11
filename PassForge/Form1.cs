using PassForge.Service;
using PassForge.forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PassForge
{
    public partial class Form1 : Form
    {
        Check check = new Check();
        info_form form3 = new info_form();
        home_details form2 = new home_details();

        bool isActive = false;
        bool ismenuActive = true;

        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = check_button;
        }



        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e) { }

        private void label17_Click(object sender, EventArgs e) { }

        public void Form1_Load(object sender, EventArgs e)
        {
            menu_panel.Visible = false;
            LoadForm2();
            main_pane.Visible = false;
            back_button.Visible = false;
        }

        public void check_button_Click(object sender, EventArgs e)
        {
            main_pane.Visible = true;


            string password = textBox.Text;

            check.checkPass(password);

            Display_statas();
            int pass_Length = password.Length;

            pass_length.Text = pass_Length.ToString();
        }
        public void Display_statas()
        {
            int Score = 0;
            int checkProsess = 0;


            //---------------------- LowerCase States ------------------------
            if (check.hasLoWer)
            {
                Lowercase_checkBox.Checked = true;
                Lowercase_statas.Text = "Yes";
                Lowercase_statas.ForeColor = Color.Green;
                Score = Score + 15;
            }
            else
            {
                Lowercase_checkBox.Checked = true;
                Lowercase_statas.Text = "No";
                Lowercase_statas.ForeColor = Color.Red;
            }
            //---------------------- UpperCase States ------------------------
            if (check.hasUpper)
            {
                Uppercase_checkBox.Checked = true;
                Uppercase_statas.Text = "Yes";
                Uppercase_statas.ForeColor = Color.Green;
                Score = Score + 15;
            }
            else
            {
                Uppercase_checkBox.Checked = true;
                Uppercase_statas.Text = "No";
                Uppercase_statas.ForeColor = Color.Red;
            }
            //-------------------------- Number States ------------------------
            if (check.hasNumber)
            {
                Numbers_checkBox.Checked = true;
                Numbers_statas.Text = "Yes";
                Numbers_statas.ForeColor = Color.Green;
                Score = Score + 15;
            }
            else
            {
                Numbers_checkBox.Checked = true;
                Numbers_statas.Text = "No";
                Numbers_statas.ForeColor = Color.Red;
            }
            //---------------------- Special States ------------------------
            if (check.hasSymbol)
            {
                Special_checkBox.Checked = true;
                Special_statas.Text = "Yes";
                Special_statas.ForeColor = Color.Green;
                Score = Score + 15;
            }
            else
            {
                Special_checkBox.Checked = true;
                Special_statas.Text = "No";
                Special_statas.ForeColor = Color.Red;
            }
            //---------------------- Common States ------------------------
            if (check.isCommon)
            {
                Common_checkBox.Checked = true;
                Common_statas.Text = "Yes";
                Common_statas.ForeColor = Color.Red;
                Score = Score - 10;
            }
            else
            {
                Common_checkBox.Checked = true;
                Common_statas.Text = "No";
                Common_statas.ForeColor = Color.Green;
                Score = Score + 20;
            }
            //---------------------- Length States ------------------------
            if (check.length)
            {
                Length_checkBox.Checked = true;
                Length_statas.Text = "Excellent";
                Length_statas.ForeColor = Color.Green;
                Score = Score + 20;
            }
            else if (check.length2)
            {
                Length_checkBox.Checked = true;
                Length_statas.Text = "Good";
                Length_statas.ForeColor = Color.Orange;
                Score = Score + 10;
            }

            else
            {
                Length_checkBox.Checked = true;
                Length_statas.Text = "Poor";
                Length_statas.ForeColor = Color.Red;
                Score = 5;
            }
            //---------------------- isEmpty States ------------------------
            if (check.isEmpty || check.hasSpace)
            {
                Score = 0;
                errorProvider1.SetError(textBox, "Enter Your PassWord.");
            }
            else { errorProvider1.SetError(textBox, ""); }




            //---------------------- CircleProgressBar States ------------------------
            if (Score <= 30)
            {
                CircleProgressBar.ProgressColor = Color.Red;
                CircleProgressBar.Value = Score;
                Strength_states.Text = Score + "/100";
                Strength_states.ForeColor = Color.Red;
            }
            else if (Score <= 50)
            {
                CircleProgressBar.ProgressColor = Color.Orange;
                CircleProgressBar.Value = Score;
                Strength_states.Text = Score + "/100";
                Strength_states.ForeColor = Color.Orange;
            }
            else if (Score <= 70)
            {
                CircleProgressBar.ProgressColor = Color.Gold;
                CircleProgressBar.Value = Score;
                Strength_states.Text = Score + "/100";
                Strength_states.ForeColor = Color.Gold;
            }
            else
            {
                CircleProgressBar.ProgressColor = Color.LimeGreen;
                CircleProgressBar.Value = Score;
                Strength_states.Text = Score + "/100";
                Strength_states.ForeColor = Color.Green;
            }

            //---------------------- guna2ProgressBar1 States ------------------------

            /*if (checkProsess <= 30)
            {

                guna2ProgressBar1.Value = checkProsess;
            }
            else if (Score <= 50)
            {

                guna2ProgressBar1.Value = checkProsess;
            }
            else if (Score <= 70)
            {

                guna2ProgressBar1.Value = checkProsess;
            }
            else
            {

                guna2ProgressBar1.Value = checkProsess;
            }*/



            //---------------------- Recommendations States ------------------------

            lstRecommendations.Items.Clear();
            lstRecommendations.ForeColor = Color.White;
            if (!check.length2)
            {
                lstRecommendations.Items.Add("• Use at least 8 characters.");
            }

            if (!check.hasUpper)
            {
                lstRecommendations.Items.Add("• Add at least one uppercase letter (A-Z).");
            }

            if (!check.hasLoWer)
            {
                lstRecommendations.Items.Add("• Add at least one lowercase letter (a-z).");
            }

            if (!check.hasNumber)
            {
                lstRecommendations.Items.Add("• Add at least one number (0-9).");
            }
            if (!check.hasSymbol)
            {
                lstRecommendations.Items.Add("• Add at least one special character (!@#$%).");
            }
            if (check.isCommon)
            {
                lstRecommendations.Items.Add("• have to common words.");
            }
            if (check.length2 && check.hasUpper && check.hasLoWer && check.hasNumber && check.hasSymbol)
            {
                lstRecommendations.Items.Add("✓ Your password meets the basic security requirements.");
                lstRecommendations.ForeColor = Color.LightGreen;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click_1(object sender, EventArgs e)
        {
            see_button();
        }
        public void see_button()
        {
            isActive = !isActive;

            if (isActive)
            {
                textBox.UseSystemPasswordChar = true;

            }
            else
            {
                textBox.UseSystemPasswordChar = false;

            }
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            ismenuActive = !ismenuActive;
            if (ismenuActive)
            {
                menu_panel.Visible = true;
            }
            else
            {
                menu_panel.Visible = false;
            }
        }

        private void LoadForm2()
        {
            //panel1.Controls.Clear();

            

            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;

            main_panel2.Controls.Add(form2);

            form2.Show();
        }



        private void LoadForm3()
        {
            //main_panel2.Controls.Clear();
            main_panel2.Visible = true;
            main_panel2.Size = new Size(526, 207);
            this.BackColor = Color.Indigo;
            textBox.Visible = false;
            check_button.Visible = false;
            pictureBox1.Visible = false;
            main_pane.Visible = false;
            lstRecommendations.Visible = false;
            Recommendations_label.Text = "";
            back_button.Visible = true;

            

            form3.TopLevel = false;
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.Dock = DockStyle.Fill;
            main_panel2.Controls.Remove(form2);
            main_panel2.Controls.Add(form3);

            form3.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm3();



        }

        private void back_button_Click(object sender, EventArgs e)
        {
            main_panel2.Size = new Size(516, 207);
            this.BackColor = Color.FromArgb(247, 249, 236);
            textBox.Visible = true;
            check_button.Visible = true;
            pictureBox1.Visible = true;
            main_pane.Visible = true;
            //main_panel2.Controls.Clear();
            //main_panel2.Visible = false;
            lstRecommendations.Visible = true;
            Recommendations_label.Text = "Recommendations:";
            back_button.Visible = false;
        }
    }
}
