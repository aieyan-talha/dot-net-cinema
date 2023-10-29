namespace DotNetCinema
{
    partial class AAddCompForm
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
            label5 = new Label();
            button1 = new Button();
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
            label2.Location = new Point(279, 192);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(250, 26);
            label2.TabIndex = 4;
            label2.Text = "Adding Successfully Done!";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(368, 231);
            label5.Name = "label5";
            label5.Size = new Size(80, 19);
            label5.TabIndex = 20;
            label5.Text = "Thank you!";
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
            button1.Location = new Point(337, 388);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(135, 28);
            button1.TabIndex = 27;
            button1.Text = "CLOSE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AAddCompForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(816, 452);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            Margin = new Padding(2);
            Name = "AAddCompForm";
            Text = "DOT NET CINEMA - Confirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private Button button1;
    }
}