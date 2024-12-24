namespace WinFormsApp.Screens.Login
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            panel1 = new Panel();
            txbUserName = new TextBox();
            panel2 = new Panel();
            txbPassword = new TextBox();
            label1 = new Label();
            bnLogIn = new Button();
            bnExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(txbUserName);
            panel1.Location = new Point(99, 127);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 37);
            panel1.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.AcceptsTab = true;
            txbUserName.Anchor = AnchorStyles.None;
            txbUserName.Location = new Point(10, 8);
            txbUserName.Margin = new Padding(3, 2, 3, 2);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(169, 23);
            txbUserName.TabIndex = 0;
            txbUserName.Text = "UserName";
            txbUserName.TextChanged += txbUserName_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(txbPassword);
            panel2.Location = new Point(99, 190);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 37);
            panel2.TabIndex = 1;
            // 
            // txbPassword
            // 
            txbPassword.AcceptsTab = true;
            txbPassword.Anchor = AnchorStyles.None;
            txbPassword.Location = new Point(10, 8);
            txbPassword.Margin = new Padding(3, 2, 3, 2);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(169, 23);
            txbPassword.TabIndex = 1;
            txbPassword.Text = "Password";
            txbPassword.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 48);
            label1.Name = "label1";
            label1.Size = new Size(250, 57);
            label1.TabIndex = 2;
            label1.Text = "GARA OTO";
            label1.Click += label1_Click;
            // 
            // bnLogIn
            // 
            bnLogIn.Anchor = AnchorStyles.None;
            bnLogIn.AutoSize = true;
            bnLogIn.BackColor = SystemColors.HotTrack;
            bnLogIn.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnLogIn.ForeColor = SystemColors.ButtonFace;
            bnLogIn.Location = new Point(142, 250);
            bnLogIn.Margin = new Padding(3, 2, 3, 2);
            bnLogIn.Name = "bnLogIn";
            bnLogIn.Size = new Size(111, 38);
            bnLogIn.TabIndex = 3;
            bnLogIn.Text = "Log In";
            bnLogIn.UseVisualStyleBackColor = false;
            bnLogIn.Click += bnLogin_Click;
            // 
            // bnExit
            // 
            bnExit.Anchor = AnchorStyles.None;
            bnExit.AutoSize = true;
            bnExit.BackColor = Color.LightCoral;
            bnExit.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnExit.ForeColor = SystemColors.ButtonFace;
            bnExit.Location = new Point(142, 300);
            bnExit.Margin = new Padding(3, 2, 3, 2);
            bnExit.Name = "bnExit";
            bnExit.Size = new Size(111, 38);
            bnExit.TabIndex = 4;
            bnExit.Text = "Exit";
            bnExit.UseVisualStyleBackColor = false;
            bnExit.Click += bnExit_Click;
            // 
            // fLogin
            // 
            AcceptButton = bnLogIn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bnExit;
            ClientSize = new Size(368, 390);
            Controls.Add(bnExit);
            Controls.Add(bnLogIn);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(384, 429);
            MinimumSize = new Size(384, 429);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += fLogin_FormClosing;
            Load += fLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txbUserName;
        private Panel panel2;
        private TextBox txbPassword;
        private Label label1;
        private Button bnLogIn;
        private Button bnExit;
    }
}