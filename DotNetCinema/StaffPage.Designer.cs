namespace DotNetCinema
{
    partial class StaffPage
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
            comboBox1 = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            button3 = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(21, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 0;
            label1.Text = "DOT NET CINEMA";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.BackColor = Color.Black;
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = SystemColors.ButtonFace;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "List of Movies", "Search Movies", "List of Tickets of a Movie" });
            comboBox1.Location = new Point(227, 221);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(363, 27);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Select Your Task";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(341, 149);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 26);
            label2.TabIndex = 4;
            label2.Text = "Select Task";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(264, 184);
            label5.Name = "label5";
            label5.Size = new Size(270, 15);
            label5.TabIndex = 20;
            label5.Text = "Welcome, Staff. Select a required task from the list.";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(44, 44, 44);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Corbel", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(725, 18);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(70, 28);
            button3.TabIndex = 19;
            button3.Text = "Sign Out";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Corbel", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(635, 24);
            label9.Name = "label9";
            label9.Size = new Size(61, 18);
            label9.TabIndex = 21;
            label9.Text = "Hi, Staff!";
            label9.Click += label9_Click;
            // 
            // StaffPage
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(816, 452);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            Margin = new Padding(2);
            Name = "StaffPage";
            Text = "Dot Net Cinema - Staff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label6;
        private Button button2;
        private Label label4;
        private Label label5;
        private Button button3;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox2;
        private Label label9;
    }
}