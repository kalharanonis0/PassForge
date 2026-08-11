namespace PassForge
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            menu_button = new PictureBox();
            pictureBox2 = new PictureBox();
            lPASSWORD_SECURITY_ANALYZER_Label = new Label();
            Length_checkBox = new CheckBox();
            textBox = new TextBox();
            check_button = new Button();
            label1 = new Label();
            Length_statas = new Label();
            Lowercase_statas = new Label();
            label4 = new Label();
            Lowercase_checkBox = new CheckBox();
            Uppercase_statas = new Label();
            label6 = new Label();
            Uppercase_checkBox = new CheckBox();
            Numbers_statas = new Label();
            label8 = new Label();
            Numbers_checkBox = new CheckBox();
            Common_statas = new Label();
            label12 = new Label();
            Common_checkBox = new CheckBox();
            Special_statas = new Label();
            label14 = new Label();
            Special_checkBox = new CheckBox();
            panel2 = new Panel();
            lstRecommendations = new ListBox();
            guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            Recommendations_label = new Label();
            CircleProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            Strength_states = new Label();
            label17 = new Label();
            label19 = new Label();
            label20 = new Label();
            Estimated_statas = new Label();
            label22 = new Label();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            label3 = new Label();
            pass_length = new Label();
            pictureBox1 = new PictureBox();
            menu_panel = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            main_pane = new Panel();
            main_panel2 = new Panel();
            back_button = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menu_panel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            main_pane.SuspendLayout();
            main_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)back_button).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(menu_button);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lPASSWORD_SECURITY_ANALYZER_Label);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(247, 249, 236);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 35);
            panel1.TabIndex = 0;
            // 
            // menu_button
            // 
            menu_button.Cursor = Cursors.Hand;
            menu_button.Image = (Image)resources.GetObject("menu_button.Image");
            menu_button.Location = new Point(738, 5);
            menu_button.Name = "menu_button";
            menu_button.Size = new Size(29, 27);
            menu_button.SizeMode = PictureBoxSizeMode.Zoom;
            menu_button.TabIndex = 3;
            menu_button.TabStop = false;
            menu_button.Click += menu_button_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(757, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 35);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lPASSWORD_SECURITY_ANALYZER_Label
            // 
            lPASSWORD_SECURITY_ANALYZER_Label.AutoSize = true;
            lPASSWORD_SECURITY_ANALYZER_Label.BackColor = Color.Transparent;
            lPASSWORD_SECURITY_ANALYZER_Label.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lPASSWORD_SECURITY_ANALYZER_Label.ForeColor = Color.FromArgb(247, 249, 236);
            lPASSWORD_SECURITY_ANALYZER_Label.Location = new Point(12, 9);
            lPASSWORD_SECURITY_ANALYZER_Label.Name = "lPASSWORD_SECURITY_ANALYZER_Label";
            lPASSWORD_SECURITY_ANALYZER_Label.Size = new Size(299, 18);
            lPASSWORD_SECURITY_ANALYZER_Label.TabIndex = 1;
            lPASSWORD_SECURITY_ANALYZER_Label.Text = "PASSWORD SECURITY ANALYZER ";
            // 
            // Length_checkBox
            // 
            Length_checkBox.AutoSize = true;
            Length_checkBox.Enabled = false;
            Length_checkBox.ForeColor = Color.FromArgb(94, 64, 116);
            Length_checkBox.Location = new Point(24, 22);
            Length_checkBox.Name = "Length_checkBox";
            Length_checkBox.Size = new Size(63, 19);
            Length_checkBox.TabIndex = 1;
            Length_checkBox.Text = "Length";
            Length_checkBox.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            textBox.BackColor = Color.FromArgb(247, 249, 236);
            textBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox.ForeColor = Color.FromArgb(94, 64, 116);
            textBox.Location = new Point(139, 62);
            textBox.Name = "textBox";
            textBox.Size = new Size(367, 29);
            textBox.TabIndex = 2;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // check_button
            // 
            check_button.BackColor = Color.FromArgb(247, 249, 236);
            check_button.Cursor = Cursors.Hand;
            check_button.FlatAppearance.BorderColor = Color.Indigo;
            check_button.FlatAppearance.BorderSize = 2;
            check_button.FlatStyle = FlatStyle.Flat;
            check_button.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            check_button.ForeColor = Color.Indigo;
            check_button.Location = new Point(525, 62);
            check_button.Name = "check_button";
            check_button.Size = new Size(75, 29);
            check_button.TabIndex = 3;
            check_button.Text = "Check";
            check_button.UseVisualStyleBackColor = false;
            check_button.Click += check_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 22);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 4;
            label1.Text = ":";
            // 
            // Length_statas
            // 
            Length_statas.AutoSize = true;
            Length_statas.Location = new Point(144, 22);
            Length_statas.Name = "Length_statas";
            Length_statas.Size = new Size(12, 15);
            Length_statas.TabIndex = 5;
            Length_statas.Text = "-";
            // 
            // Lowercase_statas
            // 
            Lowercase_statas.AutoSize = true;
            Lowercase_statas.Location = new Point(144, 70);
            Lowercase_statas.Name = "Lowercase_statas";
            Lowercase_statas.Size = new Size(12, 15);
            Lowercase_statas.TabIndex = 8;
            Lowercase_statas.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 70);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 7;
            label4.Text = ":";
            // 
            // Lowercase_checkBox
            // 
            Lowercase_checkBox.AutoSize = true;
            Lowercase_checkBox.Enabled = false;
            Lowercase_checkBox.ForeColor = Color.FromArgb(94, 64, 116);
            Lowercase_checkBox.Location = new Point(24, 70);
            Lowercase_checkBox.Name = "Lowercase_checkBox";
            Lowercase_checkBox.Size = new Size(81, 19);
            Lowercase_checkBox.TabIndex = 6;
            Lowercase_checkBox.Text = "Lowercase";
            Lowercase_checkBox.UseVisualStyleBackColor = true;
            // 
            // Uppercase_statas
            // 
            Uppercase_statas.AutoSize = true;
            Uppercase_statas.Location = new Point(144, 95);
            Uppercase_statas.Name = "Uppercase_statas";
            Uppercase_statas.Size = new Size(12, 15);
            Uppercase_statas.TabIndex = 11;
            Uppercase_statas.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 95);
            label6.Name = "label6";
            label6.Size = new Size(10, 15);
            label6.TabIndex = 10;
            label6.Text = ":";
            // 
            // Uppercase_checkBox
            // 
            Uppercase_checkBox.AutoSize = true;
            Uppercase_checkBox.Enabled = false;
            Uppercase_checkBox.ForeColor = Color.FromArgb(94, 64, 116);
            Uppercase_checkBox.Location = new Point(24, 95);
            Uppercase_checkBox.Name = "Uppercase_checkBox";
            Uppercase_checkBox.Size = new Size(81, 19);
            Uppercase_checkBox.TabIndex = 9;
            Uppercase_checkBox.Text = "Uppercase";
            Uppercase_checkBox.UseVisualStyleBackColor = true;
            // 
            // Numbers_statas
            // 
            Numbers_statas.AutoSize = true;
            Numbers_statas.Location = new Point(144, 120);
            Numbers_statas.Name = "Numbers_statas";
            Numbers_statas.Size = new Size(12, 15);
            Numbers_statas.TabIndex = 14;
            Numbers_statas.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(112, 120);
            label8.Name = "label8";
            label8.Size = new Size(10, 15);
            label8.TabIndex = 13;
            label8.Text = ":";
            // 
            // Numbers_checkBox
            // 
            Numbers_checkBox.AutoSize = true;
            Numbers_checkBox.Enabled = false;
            Numbers_checkBox.ForeColor = Color.FromArgb(94, 64, 116);
            Numbers_checkBox.Location = new Point(24, 120);
            Numbers_checkBox.Name = "Numbers_checkBox";
            Numbers_checkBox.Size = new Size(75, 19);
            Numbers_checkBox.TabIndex = 12;
            Numbers_checkBox.Text = "Numbers";
            Numbers_checkBox.UseVisualStyleBackColor = true;
            // 
            // Common_statas
            // 
            Common_statas.AutoSize = true;
            Common_statas.Location = new Point(144, 170);
            Common_statas.Name = "Common_statas";
            Common_statas.Size = new Size(12, 15);
            Common_statas.TabIndex = 20;
            Common_statas.Text = "-";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(112, 170);
            label12.Name = "label12";
            label12.Size = new Size(10, 15);
            label12.TabIndex = 19;
            label12.Text = ":";
            // 
            // Common_checkBox
            // 
            Common_checkBox.AutoSize = true;
            Common_checkBox.Enabled = false;
            Common_checkBox.ForeColor = Color.FromArgb(94, 64, 116);
            Common_checkBox.Location = new Point(24, 170);
            Common_checkBox.Name = "Common_checkBox";
            Common_checkBox.Size = new Size(80, 19);
            Common_checkBox.TabIndex = 18;
            Common_checkBox.Text = "Common ";
            Common_checkBox.UseVisualStyleBackColor = true;
            // 
            // Special_statas
            // 
            Special_statas.AutoSize = true;
            Special_statas.Location = new Point(144, 145);
            Special_statas.Name = "Special_statas";
            Special_statas.Size = new Size(12, 15);
            Special_statas.TabIndex = 17;
            Special_statas.Text = "-";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(112, 145);
            label14.Name = "label14";
            label14.Size = new Size(10, 15);
            label14.TabIndex = 16;
            label14.Text = ":";
            // 
            // Special_checkBox
            // 
            Special_checkBox.AutoSize = true;
            Special_checkBox.Enabled = false;
            Special_checkBox.ForeColor = Color.FromArgb(94, 64, 116);
            Special_checkBox.Location = new Point(24, 145);
            Special_checkBox.Name = "Special_checkBox";
            Special_checkBox.Size = new Size(63, 19);
            Special_checkBox.TabIndex = 15;
            Special_checkBox.Text = "Special";
            Special_checkBox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Controls.Add(lstRecommendations);
            panel2.Controls.Add(guna2ProgressBar1);
            panel2.Controls.Add(Recommendations_label);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 315);
            panel2.Name = "panel2";
            panel2.Size = new Size(772, 135);
            panel2.TabIndex = 24;
            // 
            // lstRecommendations
            // 
            lstRecommendations.BackColor = Color.Indigo;
            lstRecommendations.BorderStyle = BorderStyle.None;
            lstRecommendations.ForeColor = Color.White;
            lstRecommendations.FormattingEnabled = true;
            lstRecommendations.Location = new Point(51, 37);
            lstRecommendations.Name = "lstRecommendations";
            lstRecommendations.Size = new Size(665, 90);
            lstRecommendations.TabIndex = 26;
            // 
            // guna2ProgressBar1
            // 
            guna2ProgressBar1.CustomizableEdges = customizableEdges1;
            guna2ProgressBar1.Location = new Point(0, 0);
            guna2ProgressBar1.Name = "guna2ProgressBar1";
            guna2ProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ProgressBar1.Size = new Size(779, 10);
            guna2ProgressBar1.TabIndex = 25;
            guna2ProgressBar1.Text = "ProgressBar";
            guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Recommendations_label
            // 
            Recommendations_label.AutoSize = true;
            Recommendations_label.BackColor = Color.Transparent;
            Recommendations_label.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Recommendations_label.ForeColor = Color.FromArgb(247, 249, 236);
            Recommendations_label.Location = new Point(12, 16);
            Recommendations_label.Name = "Recommendations_label";
            Recommendations_label.Size = new Size(146, 18);
            Recommendations_label.TabIndex = 2;
            Recommendations_label.Text = "Recommendations:";
            // 
            // CircleProgressBar
            // 
            CircleProgressBar.BackColor = Color.FromArgb(247, 249, 236);
            CircleProgressBar.FillColor = Color.FromArgb(200, 213, 218, 223);
            CircleProgressBar.Font = new Font("Segoe UI", 12F);
            CircleProgressBar.ForeColor = Color.FromArgb(94, 64, 116);
            CircleProgressBar.Location = new Point(327, 22);
            CircleProgressBar.Minimum = 0;
            CircleProgressBar.Name = "CircleProgressBar";
            CircleProgressBar.ProgressColor2 = Color.Purple;
            CircleProgressBar.ShadowDecoration.CustomizableEdges = customizableEdges3;
            CircleProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            CircleProgressBar.Size = new Size(169, 169);
            CircleProgressBar.TabIndex = 26;
            CircleProgressBar.Text = "guna2CircleProgressBar1";
            CircleProgressBar.ValueChanged += guna2CircleProgressBar1_ValueChanged;
            // 
            // Strength_states
            // 
            Strength_states.AutoSize = true;
            Strength_states.Location = new Point(283, 23);
            Strength_states.Name = "Strength_states";
            Strength_states.Size = new Size(12, 15);
            Strength_states.TabIndex = 28;
            Strength_states.Text = "-";
            Strength_states.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.FromArgb(94, 64, 116);
            label17.Location = new Point(209, 22);
            label17.Name = "label17";
            label17.Size = new Size(52, 15);
            label17.TabIndex = 27;
            label17.Text = "Strength";
            label17.Click += label17_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(267, 22);
            label19.Name = "label19";
            label19.Size = new Size(10, 15);
            label19.TabIndex = 29;
            label19.Text = ":";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(267, 47);
            label20.Name = "label20";
            label20.Size = new Size(10, 15);
            label20.TabIndex = 32;
            label20.Text = ":";
            // 
            // Estimated_statas
            // 
            Estimated_statas.AutoSize = true;
            Estimated_statas.Location = new Point(283, 47);
            Estimated_statas.Name = "Estimated_statas";
            Estimated_statas.Size = new Size(12, 15);
            Estimated_statas.TabIndex = 31;
            Estimated_statas.Text = "-";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.FromArgb(94, 64, 116);
            label22.Location = new Point(209, 47);
            label22.Name = "label22";
            label22.Size = new Size(59, 15);
            label22.TabIndex = 30;
            label22.Text = "Estimated";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = Color.DarkSeaGreen;
            label2.Location = new Point(41, 47);
            label2.Name = "label2";
            label2.Size = new Size(54, 13);
            label2.TabIndex = 33;
            label2.Text = "Caracters";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 44);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 34;
            label3.Text = ":";
            // 
            // pass_length
            // 
            pass_length.AutoSize = true;
            pass_length.Font = new Font("Segoe UI", 8F);
            pass_length.Location = new Point(144, 47);
            pass_length.Name = "pass_length";
            pass_length.Size = new Size(11, 13);
            pass_length.TabIndex = 35;
            pass_length.Text = "-";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(479, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // menu_panel
            // 
            menu_panel.BackColor = Color.Indigo;
            menu_panel.Controls.Add(panel4);
            menu_panel.Controls.Add(panel3);
            menu_panel.Dock = DockStyle.Right;
            menu_panel.Location = new Point(648, 35);
            menu_panel.Name = "menu_panel";
            menu_panel.Size = new Size(124, 280);
            menu_panel.TabIndex = 37;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(247, 249, 236);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 253);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(pictureBox3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(124, 27);
            panel3.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(10, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(10, 0);
            button1.Name = "button1";
            button1.Size = new Size(114, 27);
            button1.TabIndex = 1;
            button1.Text = "Info";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(247, 249, 236);
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // main_pane
            // 
            main_pane.BackColor = Color.Transparent;
            main_pane.Controls.Add(label2);
            main_pane.Controls.Add(Length_checkBox);
            main_pane.Controls.Add(label1);
            main_pane.Controls.Add(Strength_states);
            main_pane.Controls.Add(Length_statas);
            main_pane.Controls.Add(pass_length);
            main_pane.Controls.Add(Lowercase_checkBox);
            main_pane.Controls.Add(label3);
            main_pane.Controls.Add(label4);
            main_pane.Controls.Add(Lowercase_statas);
            main_pane.Controls.Add(label20);
            main_pane.Controls.Add(Uppercase_checkBox);
            main_pane.Controls.Add(Estimated_statas);
            main_pane.Controls.Add(label6);
            main_pane.Controls.Add(label22);
            main_pane.Controls.Add(Uppercase_statas);
            main_pane.Controls.Add(label19);
            main_pane.Controls.Add(Numbers_checkBox);
            main_pane.Controls.Add(label17);
            main_pane.Controls.Add(label8);
            main_pane.Controls.Add(CircleProgressBar);
            main_pane.Controls.Add(Numbers_statas);
            main_pane.Controls.Add(Special_checkBox);
            main_pane.Controls.Add(Common_statas);
            main_pane.Controls.Add(label14);
            main_pane.Controls.Add(label12);
            main_pane.Controls.Add(Special_statas);
            main_pane.Controls.Add(Common_checkBox);
            main_pane.Dock = DockStyle.Fill;
            main_pane.Location = new Point(0, 0);
            main_pane.Name = "main_pane";
            main_pane.Size = new Size(516, 207);
            main_pane.TabIndex = 38;
            // 
            // main_panel2
            // 
            main_panel2.BackColor = Color.Transparent;
            main_panel2.Controls.Add(main_pane);
            main_panel2.Location = new Point(114, 97);
            main_panel2.Name = "main_panel2";
            main_panel2.Size = new Size(516, 207);
            main_panel2.TabIndex = 39;
            main_panel2.Paint += panel4_Paint;
            // 
            // back_button
            // 
            back_button.Cursor = Cursors.Hand;
            back_button.Image = (Image)resources.GetObject("back_button.Image");
            back_button.Location = new Point(12, 41);
            back_button.Name = "back_button";
            back_button.Size = new Size(29, 27);
            back_button.SizeMode = PictureBoxSizeMode.Zoom;
            back_button.TabIndex = 4;
            back_button.TabStop = false;
            back_button.Click += back_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 236);
            ClientSize = new Size(772, 450);
            Controls.Add(back_button);
            Controls.Add(main_panel2);
            Controls.Add(menu_panel);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(check_button);
            Controls.Add(textBox);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "PassForge";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menu_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menu_panel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            main_pane.ResumeLayout(false);
            main_pane.PerformLayout();
            main_panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)back_button).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lPASSWORD_SECURITY_ANALYZER_Label;
        private CheckBox Length_checkBox;
        private TextBox textBox;
        private Button check_button;
        private Label label1;
        private Label Length_statas;
        private Label Lowercase_statas;
        private Label label4;
        private CheckBox Lowercase_checkBox;
        private Label Uppercase_statas;
        private Label label6;
        private CheckBox Uppercase_checkBox;
        private Label Numbers_statas;
        private Label label8;
        private CheckBox Numbers_checkBox;
        private Label Common_statas;
        private Label label12;
        private CheckBox Common_checkBox;
        private Label Special_statas;
        private Label label14;
        private CheckBox Special_checkBox;
        private Panel panel2;
        private Label Recommendations_label;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CircleProgressBar;
        private Label label17;
        private Label Strength_states;
        private Label label19;
        private Label label20;
        private Label Estimated_statas;
        private Label label22;
        private ErrorProvider errorProvider1;
        private Label pass_length;
        private Label label3;
        private Label label2;
        private ListBox lstRecommendations;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox menu_button;
        private Panel menu_panel;
        private Panel panel3;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel main_pane;
        private Panel main_panel2;
        private Panel panel4;
        private PictureBox back_button;
    }
}
