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
            button3 = new Button();
            txtEmail = new TextBox();
            firstname = new Label();
            txtPhone = new TextBox();
            password_label = new Label();
            txtLastName = new TextBox();
            email_label = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dobDatePicker = new DateTimePicker();
            genderComboBox = new ComboBox();
            first_name_error = new Label();
            last_name_error = new Label();
            email_error = new Label();
            mobile_error = new Label();
            gender_error = new Label();
            user_name_error = new Label();
            dob_error = new Label();
            label5 = new Label();
            userName_error = new Label();
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
            button3.Click += button3_Click_1;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = SystemColors.ControlDarkDark;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.WhiteSmoke;
            txtEmail.Location = new Point(200, 308);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(398, 30);
            txtEmail.TabIndex = 58;
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
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.BackColor = SystemColors.ControlDarkDark;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.ForeColor = Color.WhiteSmoke;
            txtPhone.Location = new Point(200, 382);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(398, 30);
            txtPhone.TabIndex = 56;
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
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.None;
            txtLastName.BackColor = SystemColors.ControlDarkDark;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.ForeColor = Color.WhiteSmoke;
            txtLastName.Location = new Point(200, 232);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(398, 30);
            txtLastName.TabIndex = 54;
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
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.None;
            txtFirstName.BackColor = SystemColors.ControlDarkDark;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.ForeColor = Color.WhiteSmoke;
            txtFirstName.Location = new Point(200, 160);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(398, 30);
            txtFirstName.TabIndex = 52;
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
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.BackColor = SystemColors.ControlDarkDark;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.WhiteSmoke;
            txtUsername.Location = new Point(200, 607);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(398, 30);
            txtUsername.TabIndex = 69;
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
            // dobDatePicker
            // 
            dobDatePicker.AllowDrop = true;
            dobDatePicker.Anchor = AnchorStyles.None;
            dobDatePicker.CalendarFont = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dobDatePicker.CalendarMonthBackground = SystemColors.ControlDarkDark;
            dobDatePicker.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            dobDatePicker.CalendarTrailingForeColor = Color.Gray;
            dobDatePicker.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dobDatePicker.Format = DateTimePickerFormat.Short;
            dobDatePicker.Location = new Point(200, 457);
            dobDatePicker.Margin = new Padding(3, 2, 3, 2);
            dobDatePicker.MaxDate = new DateTime(2023, 10, 29, 21, 22, 36, 0);
            dobDatePicker.Name = "dobDatePicker";
            dobDatePicker.Size = new Size(399, 30);
            dobDatePicker.TabIndex = 72;
            dobDatePicker.Value = new DateTime(2023, 10, 29, 0, 0, 0, 0);
            // 
            // genderComboBox
            // 
            genderComboBox.Anchor = AnchorStyles.None;
            genderComboBox.BackColor = SystemColors.ControlDarkDark;
            genderComboBox.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Male", "Female", "Non-binary" });
            genderComboBox.Location = new Point(199, 533);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(399, 31);
            genderComboBox.TabIndex = 73;
            genderComboBox.Text = "Select a Gender";
            // 
            // first_name_error
            // 
            first_name_error.Anchor = AnchorStyles.None;
            first_name_error.AutoSize = true;
            first_name_error.BackColor = SystemColors.ControlDarkDark;
            first_name_error.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            first_name_error.ForeColor = Color.DarkRed;
            first_name_error.Location = new Point(202, 164);
            first_name_error.Name = "first_name_error";
            first_name_error.Size = new Size(0, 19);
            first_name_error.TabIndex = 74;
            // 
            // last_name_error
            // 
            last_name_error.AutoSize = true;
            last_name_error.BackColor = SystemColors.ControlDarkDark;
            last_name_error.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            last_name_error.ForeColor = Color.DarkRed;
            last_name_error.Location = new Point(201, 240);
            last_name_error.Name = "last_name_error";
            last_name_error.Size = new Size(0, 18);
            last_name_error.TabIndex = 75;
            // 
            // email_error
            // 
            email_error.Anchor = AnchorStyles.None;
            email_error.AutoSize = true;
            email_error.BackColor = SystemColors.ControlDarkDark;
            email_error.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            email_error.ForeColor = Color.DarkRed;
            email_error.Location = new Point(202, 313);
            email_error.Name = "email_error";
            email_error.Size = new Size(0, 18);
            email_error.TabIndex = 76;
            // 
            // mobile_error
            // 
            mobile_error.Anchor = AnchorStyles.None;
            mobile_error.AutoSize = true;
            mobile_error.BackColor = SystemColors.ControlDarkDark;
            mobile_error.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mobile_error.ForeColor = Color.DarkRed;
            mobile_error.Location = new Point(202, 387);
            mobile_error.Name = "mobile_error";
            mobile_error.Size = new Size(0, 18);
            mobile_error.TabIndex = 77;
            // 
            // gender_error
            // 
            gender_error.Anchor = AnchorStyles.None;
            gender_error.AutoSize = true;
            gender_error.BackColor = SystemColors.ControlDarkDark;
            gender_error.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            gender_error.ForeColor = Color.DarkRed;
            gender_error.Location = new Point(203, 540);
            gender_error.Name = "gender_error";
            gender_error.Size = new Size(0, 18);
            gender_error.TabIndex = 78;
            // 
            // user_name_error
            // 
            user_name_error.Anchor = AnchorStyles.None;
            user_name_error.AutoSize = true;
            user_name_error.BackColor = SystemColors.ControlDarkDark;
            user_name_error.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            user_name_error.ForeColor = Color.DarkRed;
            user_name_error.Location = new Point(203, 612);
            user_name_error.Name = "user_name_error";
            user_name_error.Size = new Size(0, 18);
            user_name_error.TabIndex = 79;
            // 
            // dob_error
            // 
            dob_error.Anchor = AnchorStyles.None;
            dob_error.AutoSize = true;
            dob_error.BackColor = SystemColors.Window;
            dob_error.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dob_error.ForeColor = Color.DarkRed;
            dob_error.Location = new Point(357, 466);
            dob_error.Name = "dob_error";
            dob_error.Size = new Size(0, 18);
            dob_error.TabIndex = 80;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(199, 287);
            label5.Name = "label5";
            label5.Size = new Size(45, 19);
            label5.TabIndex = 81;
            label5.Text = "Email";
            // 
            // userName_error
            // 
            userName_error.Anchor = AnchorStyles.None;
            userName_error.AutoSize = true;
            userName_error.BackColor = SystemColors.ControlDarkDark;
            userName_error.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            userName_error.ForeColor = Color.DarkRed;
            userName_error.Location = new Point(208, 612);
            userName_error.Name = "userName_error";
            userName_error.Size = new Size(0, 18);
            userName_error.TabIndex = 82;
            // 
            // AManageStaffForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(816, 772);
            Controls.Add(userName_error);
            Controls.Add(label5);
            Controls.Add(dob_error);
            Controls.Add(user_name_error);
            Controls.Add(gender_error);
            Controls.Add(mobile_error);
            Controls.Add(email_error);
            Controls.Add(last_name_error);
            Controls.Add(first_name_error);
            Controls.Add(genderComboBox);
            Controls.Add(dobDatePicker);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(firstname);
            Controls.Add(txtPhone);
            Controls.Add(password_label);
            Controls.Add(txtLastName);
            Controls.Add(email_label);
            Controls.Add(txtFirstName);
            Controls.Add(button3);
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
        private Button button3;
        private TextBox txtEmail;
        private Label firstname;
        private TextBox txtPhone;
        private Label password_label;
        private TextBox txtLastName;
        private Label email_label;
        private TextBox txtFirstName;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private Label label6;
        private Label label7;
        private DateTimePicker dobDatePicker;
        private ComboBox genderComboBox;
        private Label first_name_error;
        private Label last_name_error;
        private Label email_error;
        private Label mobile_error;
        private Label gender_error;
        private Label user_name_error;
        private Label dob_error;
        private Label label5;
        private Label userName_error;
    }
}