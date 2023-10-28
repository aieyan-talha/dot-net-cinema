namespace DotNetCinema
{
    partial class RegisterForm
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
            register_header_label = new Label();
            register_sub_header = new Label();
            register_sub_header_2 = new Label();
            register_email = new TextBox();
            email_label = new Label();
            password_label = new Label();
            register_password = new TextBox();
            firstname = new Label();
            register_firstname = new TextBox();
            lastname = new Label();
            register_lastname = new TextBox();
            mobile = new Label();
            register_mobile = new TextBox();
            register_dob = new DateTimePicker();
            gender_label = new Label();
            dob_label = new Label();
            register_gender = new ComboBox();
            register_btn = new Button();
            username_label = new Label();
            register_username = new TextBox();
            email_address_error = new Label();
            password_error = new Label();
            username_error = new Label();
            dob_error = new Label();
            SuspendLayout();
            // 
            // register_header_label
            // 
            register_header_label.Anchor = AnchorStyles.None;
            register_header_label.AutoSize = true;
            register_header_label.Font = new Font("Bauhaus 93", 36F, FontStyle.Regular, GraphicsUnit.Point);
            register_header_label.ForeColor = Color.DarkRed;
            register_header_label.Location = new Point(253, 34);
            register_header_label.Name = "register_header_label";
            register_header_label.Size = new Size(488, 68);
            register_header_label.TabIndex = 0;
            register_header_label.Text = "DOT NET CINEMA";
            // 
            // register_sub_header
            // 
            register_sub_header.Anchor = AnchorStyles.None;
            register_sub_header.AutoSize = true;
            register_sub_header.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            register_sub_header.ForeColor = Color.WhiteSmoke;
            register_sub_header.Location = new Point(270, 140);
            register_sub_header.Name = "register_sub_header";
            register_sub_header.Size = new Size(455, 35);
            register_sub_header.TabIndex = 1;
            register_sub_header.Text = "Become a member of Dot Net Cinema";
            // 
            // register_sub_header_2
            // 
            register_sub_header_2.Anchor = AnchorStyles.None;
            register_sub_header_2.AutoSize = true;
            register_sub_header_2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_sub_header_2.ForeColor = Color.WhiteSmoke;
            register_sub_header_2.Location = new Point(427, 195);
            register_sub_header_2.Name = "register_sub_header_2";
            register_sub_header_2.Size = new Size(141, 28);
            register_sub_header_2.TabIndex = 2;
            register_sub_header_2.Text = "Sign up below";
            // 
            // register_email
            // 
            register_email.Anchor = AnchorStyles.None;
            register_email.BackColor = SystemColors.ControlDarkDark;
            register_email.BorderStyle = BorderStyle.FixedSingle;
            register_email.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_email.ForeColor = Color.WhiteSmoke;
            register_email.Location = new Point(270, 294);
            register_email.Name = "register_email";
            register_email.PlaceholderText = "Email address";
            register_email.Size = new Size(455, 36);
            register_email.TabIndex = 3;
            // 
            // email_label
            // 
            email_label.Anchor = AnchorStyles.None;
            email_label.AutoSize = true;
            email_label.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email_label.ForeColor = Color.WhiteSmoke;
            email_label.Location = new Point(270, 267);
            email_label.Name = "email_label";
            email_label.Size = new Size(126, 24);
            email_label.TabIndex = 4;
            email_label.Text = "Email address";
            // 
            // password_label
            // 
            password_label.Anchor = AnchorStyles.None;
            password_label.AutoSize = true;
            password_label.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password_label.ForeColor = Color.WhiteSmoke;
            password_label.Location = new Point(270, 362);
            password_label.Name = "password_label";
            password_label.Size = new Size(89, 24);
            password_label.TabIndex = 6;
            password_label.Text = "Password";
            // 
            // register_password
            // 
            register_password.Anchor = AnchorStyles.None;
            register_password.BackColor = SystemColors.ControlDarkDark;
            register_password.BorderStyle = BorderStyle.FixedSingle;
            register_password.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_password.ForeColor = Color.WhiteSmoke;
            register_password.Location = new Point(270, 389);
            register_password.Name = "register_password";
            register_password.PlaceholderText = "Password";
            register_password.Size = new Size(455, 36);
            register_password.TabIndex = 5;
            register_password.UseSystemPasswordChar = true;
            // 
            // firstname
            // 
            firstname.Anchor = AnchorStyles.None;
            firstname.AutoSize = true;
            firstname.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstname.ForeColor = Color.WhiteSmoke;
            firstname.Location = new Point(270, 562);
            firstname.Name = "firstname";
            firstname.Size = new Size(98, 24);
            firstname.TabIndex = 8;
            firstname.Text = "First name";
            // 
            // register_firstname
            // 
            register_firstname.Anchor = AnchorStyles.None;
            register_firstname.BackColor = SystemColors.ControlDarkDark;
            register_firstname.BorderStyle = BorderStyle.FixedSingle;
            register_firstname.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_firstname.ForeColor = Color.WhiteSmoke;
            register_firstname.Location = new Point(270, 589);
            register_firstname.Name = "register_firstname";
            register_firstname.PlaceholderText = "First name";
            register_firstname.Size = new Size(455, 36);
            register_firstname.TabIndex = 7;
            // 
            // lastname
            // 
            lastname.Anchor = AnchorStyles.None;
            lastname.AutoSize = true;
            lastname.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastname.ForeColor = Color.WhiteSmoke;
            lastname.Location = new Point(270, 654);
            lastname.Name = "lastname";
            lastname.Size = new Size(95, 24);
            lastname.TabIndex = 10;
            lastname.Text = "Last name";
            // 
            // register_lastname
            // 
            register_lastname.Anchor = AnchorStyles.None;
            register_lastname.BackColor = SystemColors.ControlDarkDark;
            register_lastname.BorderStyle = BorderStyle.FixedSingle;
            register_lastname.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_lastname.ForeColor = Color.WhiteSmoke;
            register_lastname.Location = new Point(270, 681);
            register_lastname.Name = "register_lastname";
            register_lastname.PlaceholderText = "Last name";
            register_lastname.Size = new Size(455, 36);
            register_lastname.TabIndex = 9;
            // 
            // mobile
            // 
            mobile.Anchor = AnchorStyles.None;
            mobile.AutoSize = true;
            mobile.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mobile.ForeColor = Color.WhiteSmoke;
            mobile.Location = new Point(270, 744);
            mobile.Name = "mobile";
            mobile.Size = new Size(69, 24);
            mobile.TabIndex = 12;
            mobile.Text = "Mobile";
            // 
            // register_mobile
            // 
            register_mobile.Anchor = AnchorStyles.None;
            register_mobile.BackColor = SystemColors.ControlDarkDark;
            register_mobile.BorderStyle = BorderStyle.FixedSingle;
            register_mobile.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_mobile.ForeColor = Color.WhiteSmoke;
            register_mobile.Location = new Point(270, 771);
            register_mobile.Name = "register_mobile";
            register_mobile.PlaceholderText = "Mobile";
            register_mobile.Size = new Size(455, 36);
            register_mobile.TabIndex = 11;
            // 
            // register_dob
            // 
            register_dob.AllowDrop = true;
            register_dob.Anchor = AnchorStyles.None;
            register_dob.CalendarFont = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            register_dob.CalendarMonthBackground = SystemColors.ControlDarkDark;
            register_dob.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            register_dob.CalendarTrailingForeColor = Color.Gray;
            register_dob.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_dob.Format = DateTimePickerFormat.Short;
            register_dob.Location = new Point(270, 968);
            register_dob.Name = "register_dob";
            register_dob.Size = new Size(455, 36);
            register_dob.TabIndex = 13;
            // 
            // gender_label
            // 
            gender_label.Anchor = AnchorStyles.None;
            gender_label.AutoSize = true;
            gender_label.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gender_label.ForeColor = Color.WhiteSmoke;
            gender_label.Location = new Point(270, 841);
            gender_label.Name = "gender_label";
            gender_label.Size = new Size(72, 24);
            gender_label.TabIndex = 15;
            gender_label.Text = "Gender";
            // 
            // dob_label
            // 
            dob_label.Anchor = AnchorStyles.None;
            dob_label.AutoSize = true;
            dob_label.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dob_label.ForeColor = Color.WhiteSmoke;
            dob_label.Location = new Point(270, 941);
            dob_label.Name = "dob_label";
            dob_label.Size = new Size(117, 24);
            dob_label.TabIndex = 16;
            dob_label.Text = "Date of Birth";
            // 
            // register_gender
            // 
            register_gender.Anchor = AnchorStyles.None;
            register_gender.BackColor = SystemColors.ControlDarkDark;
            register_gender.FlatStyle = FlatStyle.Flat;
            register_gender.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_gender.ForeColor = Color.WhiteSmoke;
            register_gender.FormattingEnabled = true;
            register_gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            register_gender.Location = new Point(270, 868);
            register_gender.Name = "register_gender";
            register_gender.Size = new Size(455, 36);
            register_gender.TabIndex = 17;
            // 
            // register_btn
            // 
            register_btn.Anchor = AnchorStyles.None;
            register_btn.BackColor = Color.DarkRed;
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_btn.ForeColor = Color.White;
            register_btn.Location = new Point(270, 1068);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(455, 51);
            register_btn.TabIndex = 18;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // username_label
            // 
            username_label.Anchor = AnchorStyles.None;
            username_label.AutoSize = true;
            username_label.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username_label.ForeColor = Color.WhiteSmoke;
            username_label.Location = new Point(270, 464);
            username_label.Name = "username_label";
            username_label.Size = new Size(95, 24);
            username_label.TabIndex = 20;
            username_label.Text = "Username";
            // 
            // register_username
            // 
            register_username.Anchor = AnchorStyles.None;
            register_username.BackColor = SystemColors.ControlDarkDark;
            register_username.BorderStyle = BorderStyle.FixedSingle;
            register_username.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_username.ForeColor = Color.WhiteSmoke;
            register_username.Location = new Point(270, 491);
            register_username.Name = "register_username";
            register_username.PlaceholderText = "Username";
            register_username.Size = new Size(455, 36);
            register_username.TabIndex = 19;
            // 
            // email_address_error
            // 
            email_address_error.AutoSize = true;
            email_address_error.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            email_address_error.ForeColor = Color.Red;
            email_address_error.Location = new Point(270, 333);
            email_address_error.Name = "email_address_error";
            email_address_error.Size = new Size(0, 21);
            email_address_error.TabIndex = 21;
            // 
            // password_error
            // 
            password_error.AutoSize = true;
            password_error.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            password_error.ForeColor = Color.Red;
            password_error.Location = new Point(270, 428);
            password_error.Name = "password_error";
            password_error.Size = new Size(0, 21);
            password_error.TabIndex = 22;
            // 
            // username_error
            // 
            username_error.AutoSize = true;
            username_error.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            username_error.ForeColor = Color.Red;
            username_error.Location = new Point(270, 530);
            username_error.Name = "username_error";
            username_error.Size = new Size(0, 21);
            username_error.TabIndex = 23;
            // 
            // dob_error
            // 
            dob_error.AutoSize = true;
            dob_error.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            dob_error.ForeColor = Color.Red;
            dob_error.Location = new Point(270, 1007);
            dob_error.Name = "dob_error";
            dob_error.Size = new Size(0, 21);
            dob_error.TabIndex = 24;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(994, 1193);
            Controls.Add(dob_error);
            Controls.Add(username_error);
            Controls.Add(password_error);
            Controls.Add(email_address_error);
            Controls.Add(username_label);
            Controls.Add(register_username);
            Controls.Add(register_btn);
            Controls.Add(register_gender);
            Controls.Add(dob_label);
            Controls.Add(gender_label);
            Controls.Add(register_dob);
            Controls.Add(mobile);
            Controls.Add(register_mobile);
            Controls.Add(lastname);
            Controls.Add(register_lastname);
            Controls.Add(firstname);
            Controls.Add(register_firstname);
            Controls.Add(password_label);
            Controls.Add(register_password);
            Controls.Add(email_label);
            Controls.Add(register_email);
            Controls.Add(register_sub_header_2);
            Controls.Add(register_sub_header);
            Controls.Add(register_header_label);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label register_header_label;
        private Label register_sub_header;
        private Label register_sub_header_2;
        private TextBox register_email;
        private Label email_label;
        private Label password_label;
        private TextBox register_password;
        private Label firstname;
        private TextBox register_firstname;
        private Label lastname;
        private TextBox register_lastname;
        private Label mobile;
        private TextBox register_mobile;
        private DateTimePicker register_dob;
        private Label gender_label;
        private Label dob_label;
        private ComboBox register_gender;
        private Button register_btn;
        private Label username_label;
        private TextBox register_username;
        private Label email_address_error;
        private Label password_error;
        private Label username_error;
        private Label dob_error;
    }
}