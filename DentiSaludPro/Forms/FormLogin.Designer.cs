namespace DentiSaludPro
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            btnMinimize = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 211, 216);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 24);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(389, 0);
            btnMinimize.Margin = new Padding(0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 24);
            btnMinimize.TabIndex = 4;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(414, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 24);
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 100);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 35F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(437, 100);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 203);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(187, 23);
            txtPassword.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 127);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 185);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(170, 249);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(91, 30);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(437, 346);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            ShowInTaskbar = false;
            Text = "DentiSaludPro";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox btnClose;
        private PictureBox btnMinimize;
        private Panel panel2;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Button btnLogin;
    }
}
