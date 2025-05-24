namespace PhoenixLauncher
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            label1 = new Label();
            TxtUsername = new TextBox();
            label2 = new Label();
            TxtVersion = new TextBox();
            BtnPlay = new Button();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(37, 100);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = Color.DarkGray;
            TxtUsername.Location = new Point(37, 122);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(123, 23);
            TxtUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(260, 100);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 2;
            label2.Text = "Version";
            // 
            // TxtVersion
            // 
            TxtVersion.BackColor = Color.DarkGray;
            TxtVersion.Location = new Point(260, 122);
            TxtVersion.Name = "TxtVersion";
            TxtVersion.Size = new Size(123, 23);
            TxtVersion.TabIndex = 3;
            // 
            // BtnPlay
            // 
            BtnPlay.BackColor = SystemColors.ControlDark;
            BtnPlay.FlatStyle = FlatStyle.Flat;
            BtnPlay.Location = new Point(173, 205);
            BtnPlay.Name = "BtnPlay";
            BtnPlay.Size = new Size(75, 24);
            BtnPlay.TabIndex = 4;
            BtnPlay.Text = "Play";
            BtnPlay.UseVisualStyleBackColor = false;
            BtnPlay.Click += BtnPlay_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(37, 25);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 5;
            label3.Text = "Welcome";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(37, 297);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(346, 23);
            progressBar1.TabIndex = 6;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(428, 345);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(BtnPlay);
            Controls.Add(TxtVersion);
            Controls.Add(label2);
            Controls.Add(TxtUsername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phoenix";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtUsername;
        private Label label2;
        private TextBox TxtVersion;
        private Button BtnPlay;
        private Label label3;
        private ProgressBar progressBar1;
    }
}
