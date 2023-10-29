namespace DotNetCinema
{
    partial class AManageStaffForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label9 = new Label();
            button2 = new Button();
            button3 = new Button();
            username_error = new Label();
            password_error = new Label();
            email_address_error = new Label();
            username_label = new Label();
            register_username = new TextBox();
            firstname = new Label();
            register_firstname = new TextBox();
            password_label = new Label();
            register_password = new TextBox();
            email_label = new Label();
            register_email = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(20, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 0;
            label1.Text = "DOT NET CINEMA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(311, 96);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 26);
            label2.TabIndex = 4;
            label2.Text = "Add Staff Account";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(44, 44, 44);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Corbel", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(50, 702);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(105, 28);
            button1.TabIndex = 27;
            button1.Text = "CLOSE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Corbel", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(639, 51);
            label9.Name = "label9";
            label9.Size = new Size(72, 18);
            label9.TabIndex = 33;
            label9.Text = "Hi, Admin!";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(44, 44, 44);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Corbel", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(729, 45);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(70, 28);
            button2.TabIndex = 32;
            button2.Text = "Sign Out";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(44, 44, 44);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.DarkRed;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Corbel", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(659, 702);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(100, 28);
            button3.TabIndex = 36;
            button3.Text = "ADD";
            button3.UseVisualStyleBackColor = false;
            // 
            // username_error
            // 
            username_error.AutoSize = true;
            username_error.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            username_error.ForeColor = Color.Red;
            username_error.Location = new Point(200, 178);
            username_error.Name = "username_error";
            username_error.Size = new Size(0, 17);
            username_error.TabIndex = 62;
            // 
            // password_error
            // 
            password_error.AutoSize = true;
            password_error.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            password_error.ForeColor = Color.Red;
            password_error.Location = new Point(200, 101);
            password_error.Name = "password_error";
            password_error.Size = new Size(0, 17);
            password_error.TabIndex = 61;
            // 
            // email_address_error
            // 
            email_address_error.AutoSize = true;
            email_address_error.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            email_address_error.ForeColor = Color.Red;
            email_address_error.Location = new Point(200, 30);
            email_address_error.Name = "email_address_error";
            email_address_error.Size = new Size(0, 17);
            email_address_error.TabIndex = 60;
            // 
            // username_label
            // 
            username_label.Anchor = AnchorStyles.None;
            username_label.AutoSize = true;
            username_label.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username_label.ForeColor = Color.WhiteSmoke;
            username_label.Location = new Point(200, 288);
            username_label.Name = "username_label";
            username_label.Size = new Size(45, 19);
            username_label.TabIndex = 59;
            username_label.Text = "Email";
            // 
            // register_username
            // 
            register_username.Anchor = AnchorStyles.None;
            register_username.BackColor = SystemColors.ControlDarkDark;
            register_username.BorderStyle = BorderStyle.FixedSingle;
            register_username.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_username.ForeColor = Color.WhiteSmoke;
            register_username.Location = new Point(200, 308);
            register_username.Margin = new Padding(3, 2, 3, 2);
            register_username.Name = "register_username";
            register_username.PlaceholderText = "Username";
            register_username.Size = new Size(398, 30);
            register_username.TabIndex = 58;
            // 
            // firstname
            // 
            firstname.Anchor = AnchorStyles.None;
            firstname.AutoSize = true;
            firstname.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstname.ForeColor = Color.WhiteSmoke;
            firstname.Location = new Point(200, 362);
            firstname.Name = "firstname";
            firstname.Size = new Size(54, 19);
            firstname.TabIndex = 57;
            firstname.Text = "Mobile";
            // 
            // register_firstname
            // 
            register_firstname.Anchor = AnchorStyles.None;
            register_firstname.BackColor = SystemColors.ControlDarkDark;
            register_firstname.BorderStyle = BorderStyle.FixedSingle;
            register_firstname.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_firstname.ForeColor = Color.WhiteSmoke;
            register_firstname.Location = new Point(200, 382);
            register_firstname.Margin = new Padding(3, 2, 3, 2);
            register_firstname.Name = "register_firstname";
            register_firstname.PlaceholderText = "First name";
            register_firstname.Size = new Size(398, 30);
            register_firstname.TabIndex = 56;
            // 
            // password_label
            // 
            password_label.Anchor = AnchorStyles.None;
            password_label.AutoSize = true;
            password_label.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password_label.ForeColor = Color.WhiteSmoke;
            password_label.Location = new Point(200, 212);
            password_label.Name = "password_label";
            password_label.Size = new Size(78, 19);
            password_label.TabIndex = 55;
            password_label.Text = "Last Name";
            // 
            // register_password
            // 
            register_password.Anchor = AnchorStyles.None;
            register_password.BackColor = SystemColors.ControlDarkDark;
            register_password.BorderStyle = BorderStyle.FixedSingle;
            register_password.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_password.ForeColor = Color.WhiteSmoke;
            register_password.Location = new Point(200, 232);
            register_password.Margin = new Padding(3, 2, 3, 2);
            register_password.Name = "register_password";
            register_password.PlaceholderText = "Password";
            register_password.Size = new Size(398, 30);
            register_password.TabIndex = 54;
            register_password.UseSystemPasswordChar = true;
            // 
            // email_label
            // 
            email_label.Anchor = AnchorStyles.None;
            email_label.AutoSize = true;
            email_label.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email_label.ForeColor = Color.WhiteSmoke;
            email_label.Location = new Point(200, 140);
            email_label.Name = "email_label";
            email_label.Size = new Size(79, 19);
            email_label.TabIndex = 53;
            email_label.Text = "First Name";
            // 
            // register_email
            // 
            register_email.Anchor = AnchorStyles.None;
            register_email.BackColor = SystemColors.ControlDarkDark;
            register_email.BorderStyle = BorderStyle.FixedSingle;
            register_email.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_email.ForeColor = Color.WhiteSmoke;
            register_email.Location = new Point(200, 160);
            register_email.Margin = new Padding(3, 2, 3, 2);
            register_email.Name = "register_email";
            register_email.PlaceholderText = "Email address";
            register_email.Size = new Size(398, 30);
            register_email.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(200, 506);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 71;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(200, 587);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 70;
            label4.Text = "User Name";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.ControlDarkDark;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.WhiteSmoke;
            textBox1.Location = new Point(200, 607);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(398, 30);
            textBox1.TabIndex = 69;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(200, 511);
            label6.Name = "label6";
            label6.Size = new Size(56, 19);
            label6.TabIndex = 66;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(200, 436);
            label7.Name = "label7";
            label7.Size = new Size(92, 19);
            label7.TabIndex = 64;
            label7.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AllowDrop = true;
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.CalendarFont = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CalendarMonthBackground = SystemColors.ControlDarkDark;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            dateTimePicker1.CalendarTrailingForeColor = Color.Gray;
            dateTimePicker1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(200, 457);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(399, 30);
            dateTimePicker1.TabIndex = 72;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ControlDarkDark;
            comboBox1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female", "Non-binary" });
            comboBox1.Location = new Point(199, 533);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(399, 31);
            comboBox1.TabIndex = 73;
            // 
            // AManageStaffForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(816, 772);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(username_error);
            Controls.Add(password_error);
            Controls.Add(email_address_error);
            Controls.Add(username_label);
            Controls.Add(register_username);
            Controls.Add(firstname);
            Controls.Add(register_firstname);
            Controls.Add(password_label);
            Controls.Add(register_password);
            Controls.Add(email_label);
            Controls.Add(register_email);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            Margin = new Padding(2);
            Name = "AManageStaffForm";
            Text = "DOT NET CINEMA Admin - Manage Staff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label9;
        private Button button2;
        private Button button3;
        private Label username_error;
        private Label password_error;
        private Label email_address_error;
        private Label username_label;
        private TextBox register_username;
        private Label firstname;
        private TextBox register_firstname;
        private Label password_label;
        private TextBox register_password;
        private Label email_label;
        private TextBox register_email;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
    }
}