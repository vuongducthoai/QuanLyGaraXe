using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.DAO;
using WinFormsApp.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace WinFormsApp
{
    public partial class fThemNhanVien : Form
    {
        public fThemNhanVien()
        {
            InitializeComponent();
            NHANVIENDAO.Instane.LoadComboBoxData(cbbChucVu);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        NhanVien nv = new NhanVien();
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenDangNhap.Text) || String.IsNullOrEmpty(txtHoVaTen.Text)
                || String.IsNullOrEmpty(txtDiaChi.Text) || String.IsNullOrEmpty(txtSDT.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(cbbChucVu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                // Kiểm tra tên đăng nhập có bị trùng không
                if (NHANVIENDAO.Instane.KiemTraTenDangNhapTrung(txtTenDangNhap.Text))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.");
                    return; // Dừng lại nếu tên đăng nhập bị trùng
                }

                nv.TenDangNhap = txtTenDangNhap.Text;
                nv.MatKhau = "1";
                nv.TenNV = txtHoVaTen.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.DienThoai = txtSDT.Text;
                nv.Email = txtEmail.Text;
                nv.ChucVu = cbbChucVu.Text;

                if (NHANVIENDAO.Instane.Them(nv))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!");
                    this.Close();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblNhacLaiMK_Click(object sender, EventArgs e)
        {

        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtHoVaTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHovaten_Click(object sender, EventArgs e)
        {

        }
    }
}
