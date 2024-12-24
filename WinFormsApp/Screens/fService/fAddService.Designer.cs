namespace WinFormsApp.Screens.Service.AddService
{
    partial class fAddService
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
            panel1 = new Panel();
            label1 = new Label();
            txtQuantity = new TextBox();
            txtWagePrice = new TextBox();
            panel2 = new Panel();
            panel10 = new Panel();
            label9 = new Label();
            txbIdWage = new TextBox();
            panel9 = new Panel();
            label8 = new Label();
            txbIdItem = new TextBox();
            panel5 = new Panel();
            label3 = new Label();
            txtPricePerUnit = new TextBox();
            panel6 = new Panel();
            label4 = new Label();
            panel7 = new Panel();
            label5 = new Label();
            txtTotalMoney = new TextBox();
            panel8 = new Panel();
            label7 = new Label();
            cbbWage = new ComboBox();
            label6 = new Label();
            cbbItem = new ComboBox();
            panel4 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            btnClose = new Button();
            btnConfirm = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 79);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 8);
            label1.Name = "label1";
            label1.Size = new Size(428, 62);
            label1.TabIndex = 0;
            label1.Text = "Thông tin sửa chữa";
            label1.Click += label1_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.White;
            txtQuantity.ForeColor = SystemColors.ActiveBorder;
            txtQuantity.Location = new Point(10, 25);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(156, 27);
            txtQuantity.TabIndex = 2;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtWagePrice
            // 
            txtWagePrice.BorderStyle = BorderStyle.None;
            txtWagePrice.Enabled = false;
            txtWagePrice.ForeColor = SystemColors.AppWorkspace;
            txtWagePrice.Location = new Point(3, 32);
            txtWagePrice.Name = "txtWagePrice";
            txtWagePrice.Size = new Size(156, 20);
            txtWagePrice.TabIndex = 4;
            txtWagePrice.TabStop = false;
            txtWagePrice.TextChanged += txtWagePrice_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel8);
            panel2.Location = new Point(4, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(686, 190);
            panel2.TabIndex = 5;
            // 
            // panel10
            // 
            panel10.Controls.Add(label9);
            panel10.Controls.Add(txbIdWage);
            panel10.Location = new Point(8, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(172, 55);
            panel10.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 3);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 5;
            label9.Text = "Mã tiền công";
            // 
            // txbIdWage
            // 
            txbIdWage.BorderStyle = BorderStyle.None;
            txbIdWage.Enabled = false;
            txbIdWage.ForeColor = SystemColors.AppWorkspace;
            txbIdWage.Location = new Point(3, 32);
            txbIdWage.Name = "txbIdWage";
            txbIdWage.Size = new Size(156, 20);
            txbIdWage.TabIndex = 4;
            txbIdWage.TabStop = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(label8);
            panel9.Controls.Add(txbIdItem);
            panel9.Location = new Point(8, 65);
            panel9.Name = "panel9";
            panel9.Size = new Size(172, 55);
            panel9.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 5;
            label8.Text = "Mã vật tư";
            // 
            // txbIdItem
            // 
            txbIdItem.BorderStyle = BorderStyle.None;
            txbIdItem.Enabled = false;
            txbIdItem.ForeColor = SystemColors.AppWorkspace;
            txbIdItem.Location = new Point(3, 32);
            txbIdItem.Name = "txbIdItem";
            txbIdItem.Size = new Size(156, 20);
            txbIdItem.TabIndex = 4;
            txbIdItem.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtPricePerUnit);
            panel5.Location = new Point(502, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(169, 53);
            panel5.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 6;
            label3.Text = "Đơn giá";
            // 
            // txtPricePerUnit
            // 
            txtPricePerUnit.BorderStyle = BorderStyle.None;
            txtPricePerUnit.Enabled = false;
            txtPricePerUnit.ForeColor = SystemColors.AppWorkspace;
            txtPricePerUnit.Location = new Point(3, 28);
            txtPricePerUnit.Name = "txtPricePerUnit";
            txtPricePerUnit.Size = new Size(156, 20);
            txtPricePerUnit.TabIndex = 6;
            txtPricePerUnit.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(label4);
            panel6.Controls.Add(txtQuantity);
            panel6.Location = new Point(152, 126);
            panel6.Name = "panel6";
            panel6.Size = new Size(179, 55);
            panel6.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 2);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 10;
            label4.Text = "Số lượng";
            // 
            // panel7
            // 
            panel7.Controls.Add(label5);
            panel7.Controls.Add(txtTotalMoney);
            panel7.Location = new Point(352, 125);
            panel7.Name = "panel7";
            panel7.Size = new Size(178, 53);
            panel7.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-2, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 6;
            label5.Text = "Thành tiền";
            // 
            // txtTotalMoney
            // 
            txtTotalMoney.Enabled = false;
            txtTotalMoney.ForeColor = SystemColors.ActiveBorder;
            txtTotalMoney.Location = new Point(3, 23);
            txtTotalMoney.Name = "txtTotalMoney";
            txtTotalMoney.Size = new Size(170, 27);
            txtTotalMoney.TabIndex = 2;
            txtTotalMoney.TabStop = false;
            txtTotalMoney.TextChanged += textBox5_TextChanged;
            // 
            // panel8
            // 
            panel8.Controls.Add(label7);
            panel8.Controls.Add(cbbWage);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(cbbItem);
            panel8.Location = new Point(208, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(271, 119);
            panel8.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 4);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 1;
            label7.Text = "Nội dung sửa chữa";
            // 
            // cbbWage
            // 
            cbbWage.FormattingEnabled = true;
            cbbWage.Location = new Point(10, 30);
            cbbWage.Name = "cbbWage";
            cbbWage.Size = new Size(244, 28);
            cbbWage.TabIndex = 0;
            cbbWage.Leave += cbbWage_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 61);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 0;
            label6.Text = "Vật tư";
            // 
            // cbbItem
            // 
            cbbItem.FormattingEnabled = true;
            cbbItem.Location = new Point(10, 84);
            cbbItem.Name = "cbbItem";
            cbbItem.Size = new Size(244, 28);
            cbbItem.TabIndex = 1;
            cbbItem.Leave += cbbItem_Leave;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtWagePrice);
            panel4.Location = new Point(506, 97);
            panel4.Name = "panel4";
            panel4.Size = new Size(169, 55);
            panel4.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 4);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "Tiền công";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(btnConfirm);
            panel3.Location = new Point(156, 293);
            panel3.Name = "panel3";
            panel3.Size = new Size(378, 76);
            panel3.TabIndex = 6;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ButtonShadow;
            btnClose.Location = new Point(235, 19);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(122, 46);
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Azure;
            btnConfirm.Location = new Point(18, 19);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(122, 46);
            btnConfirm.TabIndex = 0;
            btnConfirm.TabStop = false;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // fAddService
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(702, 381);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MinimumSize = new Size(720, 381);
            Name = "fAddService";
            StartPosition = FormStartPosition.CenterParent;
            Text = "fAddService";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtQuantity;
        private TextBox txtWagePrice;
        private Panel panel2;
        private ComboBox cbbItem;
        private TextBox txtTotalMoney;
        private ComboBox cbbWage;
        private Panel panel3;
        private Button btnClose;
        private Button btnConfirm;
        private TextBox txtPricePerUnit;
        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private Label label3;
        private Panel panel6;
        private Label label4;
        private Panel panel7;
        private Label label5;
        private Panel panel8;
        private Label label7;
        private Label label6;
        private Panel panel9;
        private Label label8;
        private TextBox txbIdItem;
        private Panel panel10;
        private Label label9;
        private TextBox txbIdWage;
    }
}