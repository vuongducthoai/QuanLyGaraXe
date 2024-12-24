namespace WinFormsApp.MainScene.fOption
{
    partial class UpdatePassword: Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePassword));
            panel1 = new Panel();
            lblUpdatePassword = new Label();
            btnClose = new Button();
            btnUpdate = new Button();
            txtNewPassword = new TextBox();
            txtCurrentPassword = new TextBox();
            lblNewPassword = new Label();
            lblCurrentPassword = new Label();
            lblConfirmNewPassword = new Label();
            txtConfirmNewPassword = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblUpdatePassword);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 131);
            panel1.TabIndex = 14;
            // 
            // lblUpdatePassword
            // 
            lblUpdatePassword.AutoSize = true;
            lblUpdatePassword.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdatePassword.ForeColor = Color.White;
            lblUpdatePassword.Location = new Point(411, 37);
            lblUpdatePassword.Name = "lblUpdatePassword";
            lblUpdatePassword.Size = new Size(346, 59);
            lblUpdatePassword.TabIndex = 0;
            lblUpdatePassword.Text = "ĐỔI MẬT KHẨU";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(700, 561);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 58);
            btnClose.TabIndex = 20;
            btnClose.Text = "Đóng";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdate.Location = new Point(355, 561);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(194, 58);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(546, 299);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(426, 54);
            txtNewPassword.TabIndex = 18;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentPassword.Location = new Point(546, 192);
            txtCurrentPassword.Multiline = true;
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(426, 54);
            txtCurrentPassword.TabIndex = 17;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPassword.Location = new Point(210, 299);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(249, 50);
            lblNewPassword.TabIndex = 16;
            lblNewPassword.Text = "Mật khẩu mới";
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentPassword.Location = new Point(210, 196);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(224, 50);
            lblCurrentPassword.TabIndex = 15;
            lblCurrentPassword.Text = "Mật khẩu cũ";
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmNewPassword.Location = new Point(210, 406);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new Size(172, 50);
            lblConfirmNewPassword.TabIndex = 21;
            lblConfirmNewPassword.Text = "Xác nhận";
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmNewPassword.Location = new Point(546, 407);
            txtConfirmNewPassword.Multiline = true;
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(426, 54);
            txtConfirmNewPassword.TabIndex = 22;
            // 
            // UpdatePassword
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1207, 694);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(lblConfirmNewPassword);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lblCurrentPassword);
            Name = "UpdatePassword";
            Text = "Đổi mật khẩu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblUpdatePassword;
        private Button btnClose;
        private Button btnUpdate;
        private TextBox txtNewPassword;
        private TextBox txtCurrentPassword;
        private Label lblNewPassword;
        private Label lblCurrentPassword;
        private Label lblConfirmNewPassword;
        private TextBox txtConfirmNewPassword;
    }
}