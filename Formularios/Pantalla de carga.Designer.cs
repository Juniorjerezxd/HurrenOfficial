namespace Hurren2
{
    partial class LoadingScreen
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
            progressBar = new ProgressBar();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(207, 255);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(377, 23);
            progressBar.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(337, 307);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(117, 26);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "lblMessage";
            // 
            // LoadingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources._1bb76ce6_31aa_4474_b93d_75c6710ec900;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(progressBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingScreen";
            Text = "LoadingScreen";
            Load += LoadingScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar;
        private Label lblMessage;
    }
}