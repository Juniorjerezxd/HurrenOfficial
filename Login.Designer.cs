namespace Hurren2
{
    partial class Login
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
            btnIniciar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            btnRegistrar = new Button();
            cmbUsername = new ComboBox();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.DarkCyan;
            btnIniciar.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(270, 433);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(127, 33);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar sesion";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 282);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(202, 343);
            label2.Name = "label2";
            label2.Size = new Size(119, 26);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(342, 348);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DarkCyan;
            btnRegistrar.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(465, 433);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(127, 33);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // cmbUsername
            // 
            cmbUsername.FormattingEnabled = true;
            cmbUsername.Location = new Point(342, 287);
            cmbUsername.Name = "cmbUsername";
            cmbUsername.Size = new Size(210, 23);
            cmbUsername.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources._1bb76ce6_31aa_4474_b93d_75c6710ec900;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(904, 568);
            Controls.Add(cmbUsername);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIniciar);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Label label1;
        private Label label2;
        //private TextBox textBox1;
        private TextBox txtPassword;
        private Button btnRegistrar;
        private ComboBox cmbUsername;
    }
}
