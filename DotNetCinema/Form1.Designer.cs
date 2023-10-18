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
            button1 = new Button();
            SuspendLayout();
            // 
            // header
            // 
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
            login_username.Location = new Point(359, 207);
            login_username.Name = "login_username";
            login_username.Size = new Size(373, 27);
            login_username.TabIndex = 1;
            login_username.Text = "Username";
            // 
            // login_password
            // 
            login_password.Location = new Point(359, 301);
            login_password.Name = "login_password";
            login_password.Size = new Size(373, 27);
            login_password.TabIndex = 2;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.BackColor = Color.Transparent;
            username_label.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            username_label.ForeColor = Color.White;
            username_label.Location = new Point(359, 172);
            username_label.Name = "username_label";
            username_label.Size = new Size(107, 28);
            username_label.TabIndex = 3;
            username_label.Text = "Username";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.BackColor = Color.Transparent;
            password_label.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            password_label.Location = new Point(359, 266);
            password_label.Name = "password_label";
            password_label.Size = new Size(101, 28);
            password_label.TabIndex = 4;
            password_label.Text = "Password";
            // 
            // login_btn
            // 
            login_btn.AutoEllipsis = true;
            login_btn.BackColor = Color.DarkRed;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            login_btn.ForeColor = SystemColors.Control;
            login_btn.Location = new Point(426, 368);
            login_btn.Margin = new Padding(0);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(249, 43);
            login_btn.TabIndex = 5;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.DarkRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(786, 152);
            button1.Name = "button1";
            button1.Size = new Size(249, 48);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1088, 695);
            Controls.Add(button1);
            Controls.Add(login_btn);
            Controls.Add(password_label);
            Controls.Add(username_label);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(header);
            ForeColor = SystemColors.ButtonFace;
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
        private Button button1;
    }
}