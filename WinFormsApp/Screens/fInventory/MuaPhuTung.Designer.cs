namespace WinFormsApp.Screens.fInventory
{
    partial class MuaPhuTung
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
            panel3 = new Panel();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txt_total = new TextBox();
            txt_quantity = new TextBox();
            txt_price = new TextBox();
            cbb_inventory = new ComboBox();
            label2 = new Label();
            btnAdd = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_total);
            panel1.Controls.Add(txt_quantity);
            panel1.Controls.Add(txt_price);
            panel1.Controls.Add(cbb_inventory);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(0, -70);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 743);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = SystemColors.GrayText;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 72);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(528, 65);
            panel3.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(102, 15);
            label1.Name = "label1";
            label1.Size = new Size(326, 37);
            label1.TabIndex = 1;
            label1.Text = "BẢNG NHẬP PHỤ TÙNG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(63, 474);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 18;
            label5.Text = "Tổng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 386);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 17;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 296);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 16;
            label3.Text = "Giá nhập";
            // 
            // txt_total
            // 
            txt_total.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_total.Location = new Point(187, 472);
            txt_total.Margin = new Padding(3, 4, 3, 4);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(292, 34);
            txt_total.TabIndex = 15;
            // 
            // txt_quantity
            // 
            txt_quantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_quantity.Location = new Point(187, 384);
            txt_quantity.Margin = new Padding(3, 4, 3, 4);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(292, 34);
            txt_quantity.TabIndex = 14;
            txt_quantity.TextChanged += txt_quantity_TextChanged;
            // 
            // txt_price
            // 
            txt_price.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_price.Location = new Point(187, 297);
            txt_price.Margin = new Padding(3, 4, 3, 4);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(292, 34);
            txt_price.TabIndex = 13;
            txt_price.TextChanged += txt_price_TextChanged;
            txt_price.KeyPress += txt_price_KeyPress;
            // 
            // cbb_inventory
            // 
            cbb_inventory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbb_inventory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbb_inventory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbb_inventory.FormattingEnabled = true;
            cbb_inventory.Location = new Point(187, 213);
            cbb_inventory.Margin = new Padding(3, 4, 3, 4);
            cbb_inventory.Name = "cbb_inventory";
            cbb_inventory.Size = new Size(292, 36);
            cbb_inventory.TabIndex = 12;
            cbb_inventory.SelectedIndexChanged += cbb_inventory_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 212);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 11;
            label2.Text = "Tên phụ tùng";
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(63, 606);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 59);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(308, 606);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(123, 59);
            button3.TabIndex = 9;
            button3.Text = "Đóng";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MuaPhuTung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 674);
            Controls.Add(panel1);
            Name = "MuaPhuTung";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MuaPhuTung";
            Load += MuaPhuTung_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txt_total;
        private TextBox txt_quantity;
        private TextBox txt_price;
        private ComboBox cbb_inventory;
        private Label label2;
        private Button btnAdd;
        private Button button3;
        private Panel panel3;
        private Label label1;
    }
}