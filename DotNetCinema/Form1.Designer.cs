namespace DotNetCinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            header = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            username_label = new Label();
            password_label = new Label();
            login_btn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            invalid_login_label = new Label();
            register_btn = new Button();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // header
            // 
            header.Anchor = AnchorStyles.None;
            header.AutoSize = true;
            header.BackColor = Color.Transparent;
            header.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point);
            header.ForeColor = Color.DarkRed;
            header.Location = new Point(299, 41);
            header.Name = "header";
            header.Size = new Size(502, 68);
            header.TabIndex = 0;
            header.Text = "DOT NET CINEMA";
            header.Click += header_Click;
            // 
            // login_username
            // 
            login_username.Anchor = AnchorStyles.None;
            login_username.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            login_username.Location = new Point(359, 207);
            login_username.Name = "login_username";
            login_username.PlaceholderText = "Username";
            login_username.Size = new Size(370, 36);
            login_username.TabIndex = 1;
            // 
            // login_password
            // 
            login_password.Anchor = AnchorStyles.None;
            login_password.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            login_password.Location = new Point(359, 301);
            login_password.Name = "login_password";
            login_password.PlaceholderText = "Password";
            login_password.Size = new Size(373, 36);
            login_password.TabIndex = 2;
            login_password.UseSystemPasswordChar = true;
            // 
            // username_label
            // 
            username_label.Anchor = AnchorStyles.None;
            username_label.AutoSize = true;
            username_label.BackColor = Color.Transparent;
            username_label.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            username_label.ForeColor = Color.White;
            username_label.Location = new Point(359, 176);
            username_label.Name = "username_label";
            username_label.Size = new Size(107, 28);
            username_label.TabIndex = 3;
            username_label.Text = "Username";
            // 
            // password_label
            // 
            password_label.Anchor = AnchorStyles.None;
            password_label.AutoSize = true;
            password_label.BackColor = Color.Transparent;
            password_label.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            password_label.Location = new Point(359, 270);
            password_label.Name = "password_label";
            password_label.Size = new Size(101, 28);
            password_label.TabIndex = 4;
            password_label.Text = "Password";
            // 
            // login_btn
            // 
            login_btn.Anchor = AnchorStyles.None;
            login_btn.AutoEllipsis = true;
            login_btn.BackColor = Color.DarkRed;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            login_btn.ForeColor = SystemColors.Control;
            login_btn.Location = new Point(414, 391);
            login_btn.Margin = new Padding(0);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(249, 43);
            login_btn.TabIndex = 5;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // invalid_login_label
            // 
            invalid_login_label.Anchor = AnchorStyles.None;
            invalid_login_label.AutoSize = true;
            invalid_login_label.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            invalid_login_label.ForeColor = Color.Red;
            invalid_login_label.Location = new Point(359, 340);
            invalid_login_label.Name = "invalid_login_label";
            invalid_login_label.Size = new Size(0, 21);
            invalid_login_label.TabIndex = 6;
            // 
            // register_btn
            // 
            register_btn.Anchor = AnchorStyles.None;
            register_btn.AutoEllipsis = true;
            register_btn.BackColor = Color.Black;
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            register_btn.ForeColor = SystemColors.Control;
            register_btn.Location = new Point(414, 482);
            register_btn.Margin = new Padding(0);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(249, 43);
            register_btn.TabIndex = 7;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1088, 695);
            Controls.Add(register_btn);
            Controls.Add(invalid_login_label);
            Controls.Add(login_btn);
            Controls.Add(password_label);
            Controls.Add(username_label);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(header);
            ForeColor = SystemColors.ButtonFace;
            MaximizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Dot Net Cinema";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label header;
        private TextBox login_username;
        private TextBox login_password;
        private Label username_label;
        private Label password_label;
        private Button login_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label invalid_login_label;
        private Button register_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}