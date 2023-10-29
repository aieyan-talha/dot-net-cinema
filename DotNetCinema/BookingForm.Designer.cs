namespace DotNetCinema
{
    partial class BookingForm
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
            label3 = new Label();
            label5 = new Label();
            button3 = new Button();
            movie_name = new Label();
            label4 = new Label();
            label6 = new Label();
            label9 = new Label();
            available_dates = new ComboBox();
            available_times = new ComboBox();
            nPeople = new ComboBox();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(329, 77);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 26);
            label2.TabIndex = 4;
            label2.Text = "Session Times";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(223, 168);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 23);
            label3.TabIndex = 8;
            label3.Text = "Selected Movie: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(252, 110);
            label5.Name = "label5";
            label5.Size = new Size(274, 18);
            label5.TabIndex = 20;
            label5.Text = "Select available session time to buy tickets.";
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
            button3.Location = new Point(615, 383);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(140, 28);
            button3.TabIndex = 19;
            button3.Text = "TO PROCEED";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // movie_name
            // 
            movie_name.Anchor = AnchorStyles.None;
            movie_name.AutoSize = true;
            movie_name.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            movie_name.Location = new Point(369, 171);
            movie_name.Margin = new Padding(2, 0, 2, 0);
            movie_name.Name = "movie_name";
            movie_name.Size = new Size(116, 19);
            movie_name.TabIndex = 17;
            movie_name.Text = "NAME of movie";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(223, 211);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 21;
            label4.Text = "Select Date: ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(223, 261);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 23);
            label6.TabIndex = 22;
            label6.Text = "Select Time:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkRed;
            label9.Location = new Point(223, 311);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(123, 23);
            label9.TabIndex = 23;
            label9.Text = "Select People:";
            // 
            // available_dates
            // 
            available_dates.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            available_dates.FormattingEnabled = true;
            available_dates.Location = new Point(369, 211);
            available_dates.Name = "available_dates";
            available_dates.Size = new Size(188, 23);
            available_dates.TabIndex = 24;
            available_dates.SelectedIndexChanged += available_dates_SelectedIndexChanged;
            // 
            // available_times
            // 
            available_times.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            available_times.FormattingEnabled = true;
            available_times.Location = new Point(369, 261);
            available_times.Name = "available_times";
            available_times.Size = new Size(188, 23);
            available_times.TabIndex = 25;
            available_times.SelectedIndexChanged += available_times_SelectedIndexChanged;
            // 
            // nPeople
            // 
            nPeople.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nPeople.FormattingEnabled = true;
            nPeople.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            nPeople.Location = new Point(369, 311);
            nPeople.Name = "nPeople";
            nPeople.Size = new Size(40, 23);
            nPeople.TabIndex = 26;
            nPeople.Text = "0";
            nPeople.SelectedIndexChanged += nPeople_SelectedIndexChanged;
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
            button1.Location = new Point(71, 383);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(135, 28);
            button1.TabIndex = 27;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(816, 452);
            Controls.Add(button1);
            Controls.Add(nPeople);
            Controls.Add(available_times);
            Controls.Add(available_dates);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(movie_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            Margin = new Padding(2);
            Name = "BookingForm";
            Text = "Buy Tickets";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button button3;
        private Label movie_name;
        private Label label4;
        private Label label6;
        private Label label9;
        private ComboBox available_dates;
        private ComboBox available_times;
        private ComboBox nPeople;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}