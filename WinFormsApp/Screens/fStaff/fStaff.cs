using System.Data;
using WinFormsApp.DAO;
using ClosedXML.Excel;
using WinFormsApp.Models;

namespace WinFormsApp
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
            LoadStaff();
            btnXacNhan.Hide();
            btnHuy.Hide();
        }
        void LoadStaff()
        {
            dgvNhanVien.DataSource = NHANVIENDAO.Instane.HienThi();
            dgvNhanVien.Columns["Email"].Visible = false;
            dgvNhanVien.Columns["MatKhau"].Visible = false;
            dgvNhanVien.Columns["TenDangNhap"].Visible = false;
            dgvNhanVien.Columns["DienThoai"].Visible = false;
            dgvNhanVien.Columns["DiaChi"].Visible = false;
            dgvNhanVien.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";
            dgvNhanVien.Columns["TenNV"].ReadOnly = true;
            dgvNhanVien.Columns["ChucVu"].ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtHovaTen.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTenDangNhap.ReadOnly = true;
            txtDiaChi.BackColor = SystemColors.Window;
            txtEmail.BackColor = SystemColors.Window;
            txtHovaTen.BackColor = SystemColors.Window;
            txtSDT.BackColor = SystemColors.Window;
            txtTenDangNhap.BackColor = SystemColors.Window;
            cbbChucVu.Enabled = false;
            txtDiaChi.Clear();
            txtHovaTen.Clear();
            txtEmail.Clear();
            txtTenDangNhap.Clear();
            txtSDT.Clear();
            txtTiemKiem.Clear();
        }
        private void fStaff_Load(object sender, EventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemNhanVien fThemNhanVien = new fThemNhanVien();
            fThemNhanVien.ShowDialog();
            LoadStaff();
        }

        /*private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count == 0)
                MessageBox.Show("Không có thông tin để xuất!");
            else
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                workbook.Worksheets.Add(dgvNhanVien.DataSource as DataTable, "NhanVien");

                                workbook.SaveAs(saveFileDialog.FileName);


                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xuất file không thành công!");
                        }
                    }
                }
            }
        }*/

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];

                // Hiển thị thông tin đầy đủ vào các TextBox
                txtTenDangNhap.Text = selectedRow.Cells["TenDangNhap"].Value?.ToString();
                txtHovaTen.Text = selectedRow.Cells["TenNV"].Value?.ToString();
                txtSDT.Text = selectedRow.Cells["DienThoai"].Value?.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value?.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
                cbbChucVu.Text = selectedRow.Cells["ChucVu"].Value?.ToString();

            }
        }
        //Sữa
        private void btnSuaNV_Click(object sender, EventArgs e)
        {

            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                NhanVien nv = new NhanVien();
                DataGridViewRow row = dgvNhanVien.SelectedRows[0];
                nv.TenDangNhap = row.Cells["TenDangNhap"].Value.ToString();
                txtDiaChi.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtHovaTen.ReadOnly = false;
                txtSDT.ReadOnly = false;
                cbbChucVu.Enabled = true;
                NHANVIENDAO.Instane.LoadComboBoxData(cbbChucVu);
                btnSuaThongTin.Hide();
                btnXoa.Hide();
                btnDatMatKhau.Hide();
                btnXacNhan.Show();
                btnHuy.Show();
                lblThongTinChiTiet.Text = "Sữa thông tin ";
                lblThongTinChiTiet.BackColor = System.Drawing.Color.Red;
                dgvNhanVien.Enabled = false;

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.TenDangNhap = txtTenDangNhap.Text;
            nv.TenNV = txtHovaTen.Text;
            nv.DienThoai = txtSDT.Text;
            nv.Email = txtEmail.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.ChucVu = cbbChucVu.Text;
            if (String.IsNullOrEmpty(txtTenDangNhap.Text) || String.IsNullOrEmpty(txtHovaTen.Text)
                || String.IsNullOrEmpty(txtDiaChi.Text) || String.IsNullOrEmpty(txtSDT.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(cbbChucVu.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                if (NHANVIENDAO.Instane.Sua(nv))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo");

                }
                LoadStaff();
                btnXacNhan.Hide();
                btnHuy.Hide();
                btnSuaThongTin.Show();
                btnDatMatKhau.Show();
                btnXoa.Show();
                btnDatMatKhau.Show();
                lblThongTinChiTiet.Text = "Thông tin chi tiết";
                lblThongTinChiTiet.BackColor = SystemColors.ActiveCaption;
                dgvNhanVien.Enabled = true;
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnXoa.Show();
            btnSuaThongTin.Show();
            btnHuy.Hide();
            btnXacNhan.Hide();
            DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];

            // Hiển thị thông tin đầy đủ vào các TextBox
            txtTenDangNhap.Text = selectedRow.Cells["TenDangNhap"].Value?.ToString();
            txtHovaTen.Text = selectedRow.Cells["TenNV"].Value?.ToString();
            txtSDT.Text = selectedRow.Cells["DienThoai"].Value?.ToString();
            txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value?.ToString();
            txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
            cbbChucVu.Text = selectedRow.Cells["ChucVu"].Value?.ToString();
            lblThongTinChiTiet.Text = "Thông tin chi tiết";
            lblThongTinChiTiet.BackColor = SystemColors.ActiveCaption;
            dgvNhanVien.Enabled = true ;

        }
        // Tiem Kiem
        private void btnTiemKIem_Click(object sender, EventArgs e)
        {
            string TuKhoa = txtTiemKiem.Text;
            dgvNhanVien.DataSource = NHANVIENDAO.Instane.TiemKiem(TuKhoa);
            dgvNhanVien.Columns["Email"].Visible = false;
            dgvNhanVien.Columns["MatKhau"].Visible = false;
            dgvNhanVien.Columns["TenDangNhap"].Visible = false;
            dgvNhanVien.Columns["DienThoai"].Visible = false;
            dgvNhanVien.Columns["DiaChi"].Visible = false;
            dgvNhanVien.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";
        }
        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {

                string tenDangNhap = dgvNhanVien.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa nhân viên có Tên Đăng Nhập là '{tenDangNhap}' không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        NHANVIENDAO.Instane.Xoa(tenDangNhap);

                        LoadStaff();
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        
        // Đặt lại mật khẩu
        private void btnDatMatKhau_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            if (dgvNhanVien.SelectedRows.Count > 0)
            {

                nhanVien.TenDangNhap = dgvNhanVien.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn đặt lại mật khẩu nhân viên có Tên Đăng Nhập là '{nhanVien.TenDangNhap}' thành 1 không?",
                    "Xác nhận ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        NHANVIENDAO.Instane.DatLaiMatKhau(nhanVien);
                        LoadStaff();
                        MessageBox.Show("đặt lại mật khẩu thành 1 thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi đặt lại mật khẩu : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên đặt lại mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();

        }
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void dgvNhanVien_SelectionChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtChucVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
