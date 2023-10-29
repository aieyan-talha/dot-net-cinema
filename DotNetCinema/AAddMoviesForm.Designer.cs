namespace DotNetCinema
{
    partial class AAddMoviesForm
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
            username_error = new Label();
            password_error = new Label();
            email_address_error = new Label();
            username_label = new Label();
            genre = new TextBox();
            mobile = new Label();
            description = new TextBox();
            lastname = new Label();
            firstname = new Label();
            image_link = new TextBox();
            password_label = new Label();
            length = new TextBox();
            email_label = new Label();
            movie_name = new TextBox();
            label3 = new Label();
            label4 = new Label();
            end_date = new DateTimePicker();
            start_date = new DateTimePicker();
            priority = new NumericUpDown();
            movie_name_error = new Label();
            length_error = new Label();
            genre_error = new Label();
            image_link_error = new Label();
            priority_error = new Label();
            start_date_error = new Label();
            description_error = new Label();
            ((System.ComponentModel.ISupportInitialize)priority).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(11, 41);
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
            label2.Location = new Point(331, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 26);
            label2.TabIndex = 4;
            label2.Text = "Add Movies";
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
            button1.Location = new Point(50, 779);
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
            button3.Location = new Point(662, 779);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(111, 28);
            button3.TabIndex = 36;
            button3.Text = "ADD";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // username_error
            // 
            username_error.AutoSize = true;
            username_error.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            username_error.ForeColor = Color.Red;
            username_error.Location = new Point(205, 361);
            username_error.Name = "username_error";
            username_error.Size = new Size(0, 17);
            username_error.TabIndex = 51;
            // 
            // password_error
            // 
            password_error.AutoSize = true;
            password_error.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            password_error.ForeColor = Color.Red;
            password_error.Location = new Point(205, 284);
            password_error.Name = "password_error";
            password_error.Size = new Size(0, 17);
            password_error.TabIndex = 50;
            // 
            // email_address_error
            // 
            email_address_error.AutoSize = true;
            email_address_error.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            email_address_error.ForeColor = Color.Red;
            email_address_error.Location = new Point(205, 213);
            email_address_error.Name = "email_address_error";
            email_address_error.Size = new Size(0, 17);
            email_address_error.TabIndex = 49;
            // 
            // username_label
            // 
            username_label.Anchor = AnchorStyles.None;
            username_label.AutoSize = true;
            username_label.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username_label.ForeColor = Color.WhiteSmoke;
            username_label.Location = new Point(205, 311);
            username_label.Name = "username_label";
            username_label.Size = new Size(48, 19);
            username_label.TabIndex = 48;
            username_label.Text = "Genre";
            // 
            // genre
            // 
            genre.Anchor = AnchorStyles.None;
            genre.BackColor = SystemColors.ControlDarkDark;
            genre.BorderStyle = BorderStyle.FixedSingle;
            genre.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            genre.ForeColor = Color.WhiteSmoke;
            genre.Location = new Point(205, 331);
            genre.Margin = new Padding(3, 2, 3, 2);
            genre.Name = "genre";
            genre.Size = new Size(398, 30);
            genre.TabIndex = 47;
            // 
            // mobile
            // 
            mobile.Anchor = AnchorStyles.None;
            mobile.AutoSize = true;
            mobile.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mobile.ForeColor = Color.WhiteSmoke;
            mobile.Location = new Point(205, 521);
            mobile.Name = "mobile";
            mobile.Size = new Size(74, 19);
            mobile.TabIndex = 46;
            mobile.Text = "Start Date";
            // 
            // description
            // 
            description.Anchor = AnchorStyles.None;
            description.BackColor = SystemColors.ControlDarkDark;
            description.BorderStyle = BorderStyle.FixedSingle;
            description.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            description.ForeColor = Color.WhiteSmoke;
            description.Location = new Point(205, 679);
            description.Margin = new Padding(3, 2, 3, 2);
            description.Name = "description";
            description.Size = new Size(398, 30);
            description.TabIndex = 45;
            // 
            // lastname
            // 
            lastname.Anchor = AnchorStyles.None;
            lastname.AutoSize = true;
            lastname.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastname.ForeColor = Color.WhiteSmoke;
            lastname.Location = new Point(205, 453);
            lastname.Name = "lastname";
            lastname.Size = new Size(55, 19);
            lastname.TabIndex = 44;
            lastname.Text = "Priority";
            // 
            // firstname
            // 
            firstname.Anchor = AnchorStyles.None;
            firstname.AutoSize = true;
            firstname.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstname.ForeColor = Color.WhiteSmoke;
            firstname.Location = new Point(205, 385);
            firstname.Name = "firstname";
            firstname.Size = new Size(79, 19);
            firstname.TabIndex = 42;
            firstname.Text = "Image Link";
            // 
            // image_link
            // 
            image_link.Anchor = AnchorStyles.None;
            image_link.BackColor = SystemColors.ControlDarkDark;
            image_link.BorderStyle = BorderStyle.FixedSingle;
            image_link.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            image_link.ForeColor = Color.WhiteSmoke;
            image_link.Location = new Point(205, 405);
            image_link.Margin = new Padding(3, 2, 3, 2);
            image_link.Name = "image_link";
            image_link.Size = new Size(398, 30);
            image_link.TabIndex = 41;
            // 
            // password_label
            // 
            password_label.Anchor = AnchorStyles.None;
            password_label.AutoSize = true;
            password_label.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password_label.ForeColor = Color.WhiteSmoke;
            password_label.Location = new Point(205, 235);
            password_label.Name = "password_label";
            password_label.Size = new Size(53, 19);
            password_label.TabIndex = 40;
            password_label.Text = "Length";
            // 
            // length
            // 
            length.Anchor = AnchorStyles.None;
            length.BackColor = SystemColors.ControlDarkDark;
            length.BorderStyle = BorderStyle.FixedSingle;
            length.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            length.ForeColor = Color.WhiteSmoke;
            length.Location = new Point(205, 255);
            length.Margin = new Padding(3, 2, 3, 2);
            length.Name = "length";
            length.Size = new Size(398, 30);
            length.TabIndex = 39;
            // 
            // email_label
            // 
            email_label.Anchor = AnchorStyles.None;
            email_label.AutoSize = true;
            email_label.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email_label.ForeColor = Color.WhiteSmoke;
            email_label.Location = new Point(205, 163);
            email_label.Name = "email_label";
            email_label.Size = new Size(91, 19);
            email_label.TabIndex = 38;
            email_label.Text = "Movie Name";
            // 
            // movie_name
            // 
            movie_name.Anchor = AnchorStyles.None;
            movie_name.BackColor = SystemColors.ControlDarkDark;
            movie_name.BorderStyle = BorderStyle.FixedSingle;
            movie_name.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            movie_name.ForeColor = Color.WhiteSmoke;
            movie_name.Location = new Point(205, 183);
            movie_name.Margin = new Padding(3, 2, 3, 2);
            movie_name.Name = "movie_name";
            movie_name.Size = new Size(398, 30);
            movie_name.TabIndex = 37;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(204, 658);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 55;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(204, 590);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 53;
            label4.Text = "End Date";
            // 
            // end_date
            // 
            end_date.AllowDrop = true;
            end_date.Anchor = AnchorStyles.None;
            end_date.CalendarFont = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            end_date.CalendarMonthBackground = SystemColors.ControlDarkDark;
            end_date.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            end_date.CalendarTrailingForeColor = Color.Gray;
            end_date.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            end_date.Format = DateTimePickerFormat.Short;
            end_date.Location = new Point(204, 612);
            end_date.Margin = new Padding(3, 2, 3, 2);
            end_date.Name = "end_date";
            end_date.Size = new Size(399, 30);
            end_date.TabIndex = 56;
            // 
            // start_date
            // 
            start_date.AllowDrop = true;
            start_date.Anchor = AnchorStyles.None;
            start_date.CalendarFont = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            start_date.CalendarMonthBackground = SystemColors.ControlDarkDark;
            start_date.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            start_date.CalendarTrailingForeColor = Color.Gray;
            start_date.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            start_date.Format = DateTimePickerFormat.Short;
            start_date.Location = new Point(204, 542);
            start_date.Margin = new Padding(3, 2, 3, 2);
            start_date.Name = "start_date";
            start_date.Size = new Size(399, 30);
            start_date.TabIndex = 57;
            // 
            // priority
            // 
            priority.Anchor = AnchorStyles.None;
            priority.Location = new Point(205, 484);
            priority.Name = "priority";
            priority.Size = new Size(398, 20);
            priority.TabIndex = 58;
            // 
            // movie_name_error
            // 
            movie_name_error.Anchor = AnchorStyles.None;
            movie_name_error.AutoSize = true;
            movie_name_error.BackColor = SystemColors.ControlDarkDark;
            movie_name_error.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            movie_name_error.ForeColor = Color.DarkRed;
            movie_name_error.Location = new Point(208, 189);
            movie_name_error.Name = "movie_name_error";
            movie_name_error.Size = new Size(0, 15);
            movie_name_error.TabIndex = 59;
            // 
            // length_error
            // 
            length_error.Anchor = AnchorStyles.None;
            length_error.AutoSize = true;
            length_error.BackColor = SystemColors.ControlDarkDark;
            length_error.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            length_error.ForeColor = Color.DarkRed;
            length_error.Location = new Point(208, 261);
            length_error.Name = "length_error";
            length_error.Size = new Size(0, 15);
            length_error.TabIndex = 60;
            // 
            // genre_error
            // 
            genre_error.Anchor = AnchorStyles.None;
            genre_error.AutoSize = true;
            genre_error.BackColor = SystemColors.ControlDarkDark;
            genre_error.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            genre_error.ForeColor = Color.DarkRed;
            genre_error.Location = new Point(212, 337);
            genre_error.Name = "genre_error";
            genre_error.Size = new Size(0, 15);
            genre_error.TabIndex = 61;
            // 
            // image_link_error
            // 
            image_link_error.Anchor = AnchorStyles.None;
            image_link_error.AutoSize = true;
            image_link_error.BackColor = SystemColors.ControlDarkDark;
            image_link_error.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            image_link_error.ForeColor = Color.DarkRed;
            image_link_error.Location = new Point(211, 411);
            image_link_error.Name = "image_link_error";
            image_link_error.Size = new Size(0, 15);
            image_link_error.TabIndex = 62;
            // 
            // priority_error
            // 
            priority_error.Anchor = AnchorStyles.None;
            priority_error.AutoSize = true;
            priority_error.BackColor = SystemColors.Window;
            priority_error.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            priority_error.ForeColor = Color.DarkRed;
            priority_error.Location = new Point(287, 486);
            priority_error.Name = "priority_error";
            priority_error.Size = new Size(0, 15);
            priority_error.TabIndex = 63;
            // 
            // start_date_error
            // 
            start_date_error.Anchor = AnchorStyles.None;
            start_date_error.AutoSize = true;
            start_date_error.BackColor = SystemColors.Window;
            start_date_error.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            start_date_error.ForeColor = Color.DarkRed;
            start_date_error.Location = new Point(318, 551);
            start_date_error.Name = "start_date_error";
            start_date_error.Size = new Size(0, 15);
            start_date_error.TabIndex = 64;
            // 
            // description_error
            // 
            description_error.Anchor = AnchorStyles.None;
            description_error.AutoSize = true;
            description_error.BackColor = SystemColors.ControlDarkDark;
            description_error.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            description_error.ForeColor = Color.DarkRed;
            description_error.Location = new Point(211, 687);
            description_error.Name = "description_error";
            description_error.Size = new Size(0, 15);
            description_error.TabIndex = 66;
            // 
            // AAddMoviesForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(816, 854);
            Controls.Add(description_error);
            Controls.Add(start_date_error);
            Controls.Add(priority_error);
            Controls.Add(image_link_error);
            Controls.Add(genre_error);
            Controls.Add(length_error);
            Controls.Add(movie_name_error);
            Controls.Add(priority);
            Controls.Add(start_date);
            Controls.Add(end_date);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(username_error);
            Controls.Add(password_error);
            Controls.Add(email_address_error);
            Controls.Add(username_label);
            Controls.Add(genre);
            Controls.Add(mobile);
            Controls.Add(description);
            Controls.Add(lastname);
            Controls.Add(firstname);
            Controls.Add(image_link);
            Controls.Add(password_label);
            Controls.Add(length);
            Controls.Add(email_label);
            Controls.Add(movie_name);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            Margin = new Padding(2);
            Name = "AAddMoviesForm";
            Text = "DOT NET CINEMA Admin - Add Movies";
            ((System.ComponentModel.ISupportInitialize)priority).EndInit();
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
        private Label mobile;
        private TextBox register_mobile;
        private Label lastname;
        private Label firstname;
        private TextBox register_firstname;
        private Label password_label;
        private TextBox register_password;
        private Label email_label;
        private TextBox register_email;
        private Label label3;
        private Label label4;
        private DateTimePicker register_dob;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private TextBox genre;
        private TextBox description;
        private TextBox image_link;
        private TextBox length;
        private TextBox movie_name;
        private DateTimePicker end_date;
        private DateTimePicker start_date;
        private NumericUpDown priority;
        private Label movie_name_error;
        private Label length_error;
        private Label genre_error;
        private Label image_link_error;
        private Label priority_error;
        private Label start_date_error;
        private Label end_date_error;
        private Label description_error;
    }
}