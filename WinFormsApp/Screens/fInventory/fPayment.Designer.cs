namespace WinFormsApp.MainScene.fInventory
{
    partial class fPayment
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

        #endregion
        private void InitializeComponent()
        {
            btn_close = new Button();
            a = new Label();
            dgvNhapHang = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            vat_tu = new DataGridViewTextBoxColumn();
            gia_nhap = new DataGridViewTextBoxColumn();
            so_luong = new DataGridViewTextBoxColumn();
            tong_tien = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            cmbNCC = new ComboBox();
            txtEmail = new Label();
            txtDT = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            txt_author = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dtpNgayNhap = new DateTimePicker();
            button1 = new Button();
            label6 = new Label();
            panel3 = new Panel();
            textBox4 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label9 = new Label();
            txtTongTien = new Label();
            button2 = new Button();
            button3 = new Button();
            btnThanhToan = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhapHang).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.None;
            btn_close.AutoSize = true;
            btn_close.BackColor = SystemColors.GrayText;
            btn_close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.ForeColor = Color.White;
            btn_close.Location = new Point(1171, 714);
            btn_close.Margin = new Padding(3, 4, 3, 4);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(499, 59);
            btn_close.TabIndex = 0;
            btn_close.Text = "Đóng";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a.ForeColor = SystemColors.ButtonHighlight;
            a.Location = new Point(670, 13);
            a.Name = "a";
            a.Size = new Size(269, 54);
            a.TabIndex = 1;
            a.Text = "NHẬP HÀNG";
            // 
            // dgvNhapHang
            // 
            dgvNhapHang.AllowUserToAddRows = false;
            dgvNhapHang.Anchor = AnchorStyles.None;
            dgvNhapHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhapHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNhapHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhapHang.Columns.AddRange(new DataGridViewColumn[] { stt, vat_tu, gia_nhap, so_luong, tong_tien });
            dgvNhapHang.Location = new Point(14, 45);
            dgvNhapHang.Margin = new Padding(3, 4, 3, 4);
            dgvNhapHang.Name = "dgvNhapHang";
            dgvNhapHang.RowHeadersVisible = false;
            dgvNhapHang.RowHeadersWidth = 51;
            dgvNhapHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhapHang.Size = new Size(1075, 633);
            dgvNhapHang.TabIndex = 2;
            // 
            // stt
            // 
            stt.HeaderText = "STT";
            stt.MinimumWidth = 6;
            stt.Name = "stt";
            // 
            // vat_tu
            // 
            vat_tu.HeaderText = "Phụ tùng";
            vat_tu.MinimumWidth = 6;
            vat_tu.Name = "vat_tu";
            // 
            // gia_nhap
            // 
            gia_nhap.HeaderText = "Giá nhập";
            gia_nhap.MinimumWidth = 6;
            gia_nhap.Name = "gia_nhap";
            // 
            // so_luong
            // 
            so_luong.HeaderText = "Số lượng";
            so_luong.MinimumWidth = 6;
            so_luong.Name = "so_luong";
            // 
            // tong_tien
            // 
            tong_tien.HeaderText = "Tổng tiền";
            tong_tien.MinimumWidth = 6;
            tong_tien.Name = "tong_tien";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(cmbNCC);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtDT);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1137, 45);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 180);
            panel1.TabIndex = 4;
            // 
            // cmbNCC
            // 
            cmbNCC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbNCC.FormattingEnabled = true;
            cmbNCC.Location = new Point(285, 26);
            cmbNCC.Name = "cmbNCC";
            cmbNCC.Size = new Size(228, 36);
            cmbNCC.TabIndex = 22;
            cmbNCC.SelectedIndexChanged += cmbNCC_SelectedIndexChanged;
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(363, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 25);
            txtEmail.TabIndex = 21;
            txtEmail.Text = "mast@gmail.com";
            // 
            // txtDT
            // 
            txtDT.AutoSize = true;
            txtDT.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDT.Location = new Point(416, 76);
            txtDT.Name = "txtDT";
            txtDT.Size = new Size(105, 25);
            txtDT.TabIndex = 20;
            txtDT.Text = "1800 1539";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 125);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 18;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 76);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 17;
            label4.Text = "Điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 25);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 16;
            label3.Text = "Nhà cung cấp";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(718, 651);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(292, 27);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(718, 575);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 27);
            textBox2.TabIndex = 14;
            // 
            // txt_author
            // 
            txt_author.Location = new Point(285, 77);
            txt_author.Margin = new Padding(3, 4, 3, 4);
            txt_author.Name = "txt_author";
            txt_author.Size = new Size(228, 27);
            txt_author.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(14, 3);
            label2.Name = "label2";
            label2.Size = new Size(199, 25);
            label2.TabIndex = 11;
            label2.Text = "Thông tin nhập hàng";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.GrayText;
            panel2.Controls.Add(a);
            panel2.Location = new Point(14, -104);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1690, 89);
            panel2.TabIndex = 5;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Location = new Point(285, 21);
            dtpNgayNhap.Margin = new Padding(3, 4, 3, 4);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(228, 27);
            dtpNgayNhap.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1465, 632);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(201, 59);
            button1.TabIndex = 8;
            button1.Text = "In hóa đơn";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(1137, 3);
            label6.Name = "label6";
            label6.Size = new Size(223, 25);
            label6.TabIndex = 12;
            label6.Text = "Thông tin nhà cung cấp";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(dtpNgayNhap);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txt_author);
            panel3.Location = new Point(1137, 271);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(533, 180);
            panel3.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(285, 127);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(228, 27);
            textBox4.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(32, 125);
            label12.Name = "label12";
            label12.Size = new Size(103, 25);
            label12.TabIndex = 18;
            label12.Text = "Điện thoại";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(32, 76);
            label13.Name = "label13";
            label13.Size = new Size(119, 25);
            label13.TabIndex = 17;
            label13.Text = "Người nhập";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(32, 25);
            label14.Name = "label14";
            label14.Size = new Size(109, 25);
            label14.TabIndex = 16;
            label14.Text = "Ngày nhập";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(1334, 476);
            label9.Name = "label9";
            label9.Size = new Size(189, 50);
            label9.TabIndex = 20;
            label9.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Anchor = AnchorStyles.None;
            txtTongTien.AutoSize = true;
            txtTongTien.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            txtTongTien.ForeColor = SystemColors.HotTrack;
            txtTongTien.Location = new Point(1361, 540);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(148, 50);
            txtTongTien.TabIndex = 23;
            txtTongTien.Text = "200000";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(64, 714);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(167, 59);
            button2.TabIndex = 24;
            button2.Text = "Mua phụ tùng";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(556, 714);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(167, 59);
            button3.TabIndex = 25;
            button3.Text = "Xóa phụ tùng";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Anchor = AnchorStyles.None;
            btnThanhToan.AutoSize = true;
            btnThanhToan.BackColor = SystemColors.Highlight;
            btnThanhToan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(1171, 632);
            btnThanhToan.Margin = new Padding(3, 4, 3, 4);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(252, 59);
            btnThanhToan.TabIndex = 26;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.AutoSize = true;
            button5.BackColor = SystemColors.Highlight;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(306, 714);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(167, 59);
            button5.TabIndex = 27;
            button5.Text = "Sửa phụ tùng";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // fPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1718, 814);
            Controls.Add(button5);
            Controls.Add(btnThanhToan);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtTongTien);
            Controls.Add(label9);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dgvNhapHang);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(btn_close);
            Controls.Add(label2);
            Name = "fPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn nhập hàng";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhapHang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btn_close;
        private Label a;
        public DataGridView dgvNhapHang;
        private Panel panel1;
        private Panel panel2;
        private DateTimePicker dtpNgayNhap;
        private Button button1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txt_author;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label txtDT;
        private Label label6;
        private Label txtEmail;
        private Panel panel3;
        private TextBox textBox4;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label9;
        private Label txtTongTien;
        private Button button2;
        private Button button3;
        private Button btnThanhToan;
        private ComboBox cmbNCC;
        private Button button5;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn vat_tu;
        private DataGridViewTextBoxColumn gia_nhap;
        private DataGridViewTextBoxColumn so_luong;
        private DataGridViewTextBoxColumn tong_tien;
    }
}