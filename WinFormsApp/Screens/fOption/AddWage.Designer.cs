namespace WinFormsApp.MainScene.fOption
{
    partial class AddWage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWage));
            panel1 = new Panel();
            lblAddWage = new Label();
            lblWageType = new Label();
            lblValue = new Label();
            txtWageType = new TextBox();
            txtValue = new TextBox();
            btnAdd = new Button();
            btnClose = new Button();
            txtWageID = new TextBox();
            lblWageID = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblAddWage);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1205, 132);
            panel1.TabIndex = 0;
            // 
            // lblAddWage
            // 
            lblAddWage.AutoSize = true;
            lblAddWage.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddWage.ForeColor = Color.White;
            lblAddWage.Location = new Point(411, 35);
            lblAddWage.Name = "lblAddWage";
            lblAddWage.Size = new Size(391, 59);
            lblAddWage.TabIndex = 0;
            lblAddWage.Text = "THÊM TIỀN CÔNG";
            // 
            // lblWageType
            // 
            lblWageType.AutoSize = true;
            lblWageType.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageType.Location = new Point(217, 279);
            lblWageType.Name = "lblWageType";
            lblWageType.Size = new Size(253, 50);
            lblWageType.TabIndex = 1;
            lblWageType.Text = "Loại tiền công";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValue.Location = new Point(217, 380);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(120, 50);
            lblValue.TabIndex = 2;
            lblValue.Text = "Giá trị";
            // 
            // txtWageType
            // 
            txtWageType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWageType.Location = new Point(528, 276);
            txtWageType.Multiline = true;
            txtWageType.Name = "txtWageType";
            txtWageType.Size = new Size(406, 53);
            txtWageType.TabIndex = 3;
            // 
            // txtValue
            // 
            txtValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValue.Location = new Point(528, 380);
            txtValue.Multiline = true;
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(406, 53);
            txtValue.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(358, 531);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 58);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(655, 531);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 58);
            btnClose.TabIndex = 6;
            btnClose.Text = "Đóng";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtWageID
            // 
            txtWageID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWageID.Location = new Point(528, 178);
            txtWageID.Multiline = true;
            txtWageID.Name = "txtWageID";
            txtWageID.Size = new Size(406, 53);
            txtWageID.TabIndex = 8;
            // 
            // lblWageID
            // 
            lblWageID.AutoSize = true;
            lblWageID.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWageID.Location = new Point(217, 181);
            lblWageID.Name = "lblWageID";
            lblWageID.Size = new Size(74, 50);
            lblWageID.TabIndex = 7;
            lblWageID.Text = "Mã";
            // 
            // AddWage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1208, 690);
            Controls.Add(txtWageID);
            Controls.Add(lblWageID);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(txtValue);
            Controls.Add(txtWageType);
            Controls.Add(lblValue);
            Controls.Add(lblWageType);
            Controls.Add(panel1);
            Name = "AddWage";
            Text = "Thêm tiền công";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblAddWage;
        private Label lblWageType;
        private Label lblValue;
        private TextBox txtWageType;
        private TextBox txtValue;
        private Button btnAdd;
        private Button btnClose;
        private TextBox txtWageID;
        private Label lblWageID;
    }
}