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
            header = new Label();
            getData = new Button();
            dummyData = new ListBox();
            SuspendLayout();
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            header.Location = new Point(276, 178);
            header.Name = "header";
            header.Size = new Size(216, 38);
            header.TabIndex = 0;
            header.Text = "Dot Net Cinema";
            header.Click += header_Click;
            // 
            // getData
            // 
            getData.Location = new Point(276, 219);
            getData.Name = "getData";
            getData.Size = new Size(216, 29);
            getData.TabIndex = 1;
            getData.Text = "Get Data";
            getData.UseVisualStyleBackColor = true;
            getData.Click += getData_Click;
            // 
            // dummyData
            // 
            dummyData.FormattingEnabled = true;
            dummyData.ItemHeight = 20;
            dummyData.Location = new Point(310, 254);
            dummyData.Name = "dummyData";
            dummyData.Size = new Size(150, 104);
            dummyData.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dummyData);
            Controls.Add(getData);
            Controls.Add(header);
            Name = "Form1";
            Text = "Dot Net Cinema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label header;
        private Button getData;
        private ListBox dummyData;
    }
}