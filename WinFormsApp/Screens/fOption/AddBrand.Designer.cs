namespace WinFormsApp.MainScene.fOption
{
    partial class AddBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBrand));
            panel1 = new Panel();
            lblAddBrand = new Label();
            btnClose = new Button();
            btnAdd = new Button();
            txtBrandName = new TextBox();
            lblBrandName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblAddBrand);
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1205, 132);
            panel1.TabIndex = 7;
            // 
            // lblAddBrand
            // 
            lblAddBrand.AutoSize = true;
            lblAddBrand.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddBrand.ForeColor = Color.White;
            lblAddBrand.Location = new Point(421, 37);
            lblAddBrand.Name = "lblAddBrand";
            lblAddBrand.Size = new Size(350, 59);
            lblAddBrand.TabIndex = 0;
            lblAddBrand.Text = "THÊM HÃNG XE";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(663, 476);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 58);
            btnClose.TabIndex = 13;
            btnClose.Text = "Đóng";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(366, 476);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 58);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtBrandName
            // 
            txtBrandName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrandName.Location = new Point(370, 305);
            txtBrandName.Multiline = true;
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(455, 53);
            txtBrandName.TabIndex = 10;
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandName.Location = new Point(370, 204);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(216, 50);
            lblBrandName.TabIndex = 8;
            lblBrandName.Text = "Tên hãng xe";
            // 
            // AddBrand
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1203, 660);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(txtBrandName);
            Controls.Add(lblBrandName);
            Name = "AddBrand";
            Text = "Thêm hãng xe";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblAddBrand;
        private Button btnClose;
        private Button btnAdd;
        private TextBox txtBrandName;
        private Label lblBrandName;
    }
}