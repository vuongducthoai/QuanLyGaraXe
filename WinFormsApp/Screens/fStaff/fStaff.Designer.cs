
namespace WinFormsApp
{
    partial class fStaff
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
            lblNhanVien = new Label();
            panel2 = new Panel();
            btnDatMatKhau = new Button();
            btnHuy = new Button();
            btnXacNhan = new Button();
            lblChucVu = new Label();
            lblEmail = new Label();
            lblDiaChi = new Label();
            lblSoDienThoai = new Label();
            lblHoVaTen = new Label();
            lblTenDangNhap = new Label();
            cbbChucVu = new ComboBox();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtHovaTen = new TextBox();
            panel3 = new Panel();
            txtTenDangNhap = new TextBox();
            lblThongTinChiTiet = new Label();
            btnXoa = new Button();
            button1 = new Button();
            btnInDanhSach = new Button();
            btnSuaThongTin = new Button();
            btnThem = new Button();
            dgvNhanVien = new DataGridView();
            btnThoat = new Button();
            txtTiemKiem = new TextBox();
            btnTiemKIem = new Button();
            lblDanhSachNhanVien = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(lblNhanVien);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1565, 76);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lblNhanVien
            // 
            lblNhanVien.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhanVien.ForeColor = SystemColors.Window;
            lblNhanVien.ImageAlign = ContentAlignment.BottomCenter;
            lblNhanVien.Location = new Point(11, 9);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(223, 57);
            lblNhanVien.TabIndex = 0;
            lblNhanVien.Text = "Nhân viên";
            lblNhanVien.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnDatMatKhau);
            panel2.Controls.Add(btnHuy);
            panel2.Controls.Add(btnXacNhan);
            panel2.Controls.Add(lblChucVu);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblDiaChi);
            panel2.Controls.Add(lblSoDienThoai);
            panel2.Controls.Add(lblHoVaTen);
            panel2.Controls.Add(lblTenDangNhap);
            panel2.Controls.Add(cbbChucVu);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(txtHovaTen);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(txtTenDangNhap);
            panel2.Controls.Add(lblThongTinChiTiet);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnInDanhSach);
            panel2.Controls.Add(btnSuaThongTin);
            panel2.Location = new Point(634, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(921, 708);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btnDatMatKhau
            // 
            btnDatMatKhau.BackColor = SystemColors.HotTrack;
            btnDatMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDatMatKhau.Location = new Point(158, 609);
            btnDatMatKhau.Name = "btnDatMatKhau";
            btnDatMatKhau.Size = new Size(271, 72);
            btnDatMatKhau.TabIndex = 21;
            btnDatMatKhau.Text = "Đặt Lại Mật Khẩu";
            btnDatMatKhau.UseVisualStyleBackColor = false;
            btnDatMatKhau.Click += btnDatMatKhau_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Red;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuy.Location = new Point(435, 631);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(208, 72);
            btnHuy.TabIndex = 20;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = SystemColors.HotTrack;
            btnXacNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXacNhan.Location = new Point(210, 631);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(208, 72);
            btnXacNhan.TabIndex = 19;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // lblChucVu
            // 
            lblChucVu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChucVu.Location = new Point(83, 537);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(164, 38);
            lblChucVu.TabIndex = 18;
            lblChucVu.Text = "Chức vụ :";
            lblChucVu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(83, 452);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(164, 38);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email :";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(83, 367);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(164, 38);
            lblDiaChi.TabIndex = 16;
            lblDiaChi.Text = "Địa chỉ :";
            lblDiaChi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoDienThoai.Location = new Point(83, 282);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(164, 38);
            lblSoDienThoai.TabIndex = 15;
            lblSoDienThoai.Text = "Số điện thoại :";
            lblSoDienThoai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoVaTen.Location = new Point(83, 197);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(164, 38);
            lblHoVaTen.TabIndex = 14;
            lblHoVaTen.Text = "Họ và tên :";
            lblHoVaTen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(83, 112);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(164, 38);
            lblTenDangNhap.TabIndex = 13;
            lblTenDangNhap.Text = "Tên đăng nhập :";
            lblTenDangNhap.TextAlign = ContentAlignment.MiddleRight;
            lblTenDangNhap.Click += lblTenDangNhap_Click;
            // 
            // cbbChucVu
            // 
            cbbChucVu.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbChucVu.BackColor = SystemColors.Window;
            cbbChucVu.FormattingEnabled = true;
            cbbChucVu.Location = new Point(268, 541);
            cbbChucVu.Name = "cbbChucVu";
            cbbChucVu.Size = new Size(600, 33);
            cbbChucVu.TabIndex = 12;
            cbbChucVu.Text = "Chức vụ";
            cbbChucVu.SelectedIndexChanged += cbbChucVu_SelectedIndexChanged;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.BackColor = SystemColors.WindowText;
            panel8.Location = new Point(268, 580);
            panel8.Name = "panel8";
            panel8.Size = new Size(600, 2);
            panel8.TabIndex = 8;
            panel8.Paint += panel8_Paint;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = SystemColors.WindowText;
            panel7.Location = new Point(268, 482);
            panel7.Name = "panel7";
            panel7.Size = new Size(600, 2);
            panel7.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = SystemColors.WindowText;
            panel6.Location = new Point(268, 403);
            panel6.Name = "panel6";
            panel6.Size = new Size(600, 2);
            panel6.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = SystemColors.WindowText;
            panel5.Location = new Point(268, 326);
            panel5.Name = "panel5";
            panel5.Size = new Size(600, 2);
            panel5.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = SystemColors.WindowText;
            panel4.Location = new Point(268, 230);
            panel4.Name = "panel4";
            panel4.Size = new Size(600, 2);
            panel4.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.AutoCompleteMode = AutoCompleteMode.Append;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(268, 452);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(676, 24);
            txtEmail.TabIndex = 11;
            txtEmail.Text = "Email";
            txtEmail.TextChanged += textBox4_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.None;
            txtDiaChi.AutoCompleteMode = AutoCompleteMode.Append;
            txtDiaChi.BorderStyle = BorderStyle.None;
            txtDiaChi.Location = new Point(268, 375);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(676, 24);
            txtDiaChi.TabIndex = 10;
            txtDiaChi.Text = "Địa chỉ";
            txtDiaChi.TextChanged += textBox3_TextChanged;
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.None;
            txtSDT.AutoCompleteMode = AutoCompleteMode.Append;
            txtSDT.BorderStyle = BorderStyle.None;
            txtSDT.Location = new Point(268, 296);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(676, 24);
            txtSDT.TabIndex = 9;
            txtSDT.Text = "Số điện thoại";
            txtSDT.TextChanged += textBox2_TextChanged;
            // 
            // txtHovaTen
            // 
            txtHovaTen.Anchor = AnchorStyles.None;
            txtHovaTen.AutoCompleteMode = AutoCompleteMode.Append;
            txtHovaTen.BorderStyle = BorderStyle.None;
            txtHovaTen.Location = new Point(268, 200);
            txtHovaTen.Name = "txtHovaTen";
            txtHovaTen.Size = new Size(676, 24);
            txtHovaTen.TabIndex = 8;
            txtHovaTen.Text = "Họ và tên";
            txtHovaTen.TextChanged += textBox1_TextChanged_3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = SystemColors.WindowText;
            panel3.Location = new Point(268, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 2);
            panel3.TabIndex = 7;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Anchor = AnchorStyles.None;
            txtTenDangNhap.AutoCompleteMode = AutoCompleteMode.Append;
            txtTenDangNhap.BorderStyle = BorderStyle.None;
            txtTenDangNhap.Location = new Point(268, 120);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(676, 24);
            txtTenDangNhap.TabIndex = 7;
            txtTenDangNhap.Text = "Tên đăng nhập";
            txtTenDangNhap.TextChanged += txtTenDangNhap_TextChanged;
            // 
            // lblThongTinChiTiet
            // 
            lblThongTinChiTiet.BackColor = SystemColors.ActiveCaption;
            lblThongTinChiTiet.Dock = DockStyle.Top;
            lblThongTinChiTiet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTinChiTiet.Location = new Point(0, 0);
            lblThongTinChiTiet.Name = "lblThongTinChiTiet";
            lblThongTinChiTiet.Size = new Size(919, 54);
            lblThongTinChiTiet.TabIndex = 6;
            lblThongTinChiTiet.Text = "Thông tin chi tiết";
            lblThongTinChiTiet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(676, 610);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(211, 71);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa Nhân Viên";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoaNhanVien_Click;
            // 
            // button1
            // 
            button1.Location = new Point(343, 23);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(11, 13);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnInDanhSach
            // 
            btnInDanhSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInDanhSach.Location = new Point(1160, 3);
            btnInDanhSach.Name = "btnInDanhSach";
            btnInDanhSach.Size = new Size(211, 77);
            btnInDanhSach.TabIndex = 3;
            btnInDanhSach.Text = "In Danh Sách";
            btnInDanhSach.UseVisualStyleBackColor = true;
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.BackColor = SystemColors.ScrollBar;
            btnSuaThongTin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSuaThongTin.Location = new Point(452, 610);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new Size(208, 72);
            btnSuaThongTin.TabIndex = 2;
            btnSuaThongTin.Text = "Sữa thông tin";
            btnSuaThongTin.UseVisualStyleBackColor = false;
            btnSuaThongTin.Click += btnSuaNV_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.Highlight;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThem.Location = new Point(1235, 82);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(287, 61);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm Nhân Viên";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = SystemColors.ButtonHighlight;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(12, 203);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.Size = new Size(617, 650);
            dgvNhanVien.TabIndex = 3;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            dgvNhanVien.SelectionChanged += dgvNhanVien_SelectionChanged;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Location = new Point(1432, 863);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(111, 33);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTiemKiem
            // 
            txtTiemKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTiemKiem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTiemKiem.Location = new Point(11, 90);
            txtTiemKiem.Name = "txtTiemKiem";
            txtTiemKiem.Size = new Size(661, 45);
            txtTiemKiem.TabIndex = 5;
            txtTiemKiem.TextAlign = HorizontalAlignment.Center;
            txtTiemKiem.TextChanged += textBox1_TextChanged;
            // 
            // btnTiemKIem
            // 
            btnTiemKIem.Location = new Point(678, 90);
            btnTiemKIem.Name = "btnTiemKIem";
            btnTiemKIem.Size = new Size(139, 47);
            btnTiemKIem.TabIndex = 6;
            btnTiemKIem.Text = "Tìm kiếm";
            btnTiemKIem.UseVisualStyleBackColor = true;
            btnTiemKIem.Click += btnTiemKIem_Click;
            // 
            // lblDanhSachNhanVien
            // 
            lblDanhSachNhanVien.BackColor = SystemColors.ActiveCaption;
            lblDanhSachNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachNhanVien.Location = new Point(11, 149);
            lblDanhSachNhanVien.Name = "lblDanhSachNhanVien";
            lblDanhSachNhanVien.Size = new Size(618, 55);
            lblDanhSachNhanVien.TabIndex = 7;
            lblDanhSachNhanVien.Text = "Danh sách nhân viên";
            lblDanhSachNhanVien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1565, 898);
            Controls.Add(lblDanhSachNhanVien);
            Controls.Add(dgvNhanVien);
            Controls.Add(btnTiemKIem);
            Controls.Add(txtTiemKiem);
            Controls.Add(btnThem);
            Controls.Add(btnThoat);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fStaff";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Staff";
            Load += fStaff_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button btnThem;
        private DataGridView dgvNhanVien;
        private Button btnThoat;
        private Button btnSuaThongTin;
        private Button btnInDanhSach;
        private TextBox txtTiemKiem;
        private Button btnTiemKIem;
        private Button button1;
        private Button btnXoa;
        private TextBox txtTenDangNhap;
        private Label lblNhanVien;
        private Label lblThongTinChiTiet;
        public Panel panel3;
        private TextBox txtSDT;
        private TextBox txtHovaTen;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        public Panel panel8;
        public Panel panel7;
        public Panel panel6;
        public Panel panel5;
        public Panel panel4;
        private ComboBox cbbChucVu;
        private Label lblTenDangNhap;
        private Label lblChucVu;
        private Label lblEmail;
        private Label lblDiaChi;
        private Label lblSoDienThoai;
        private Label lblHoVaTen;
        private Button btnXacNhan;
        private Button btnHuy;
        private Button btnDatMatKhau;
        private Label lblDanhSachNhanVien;
    }
}