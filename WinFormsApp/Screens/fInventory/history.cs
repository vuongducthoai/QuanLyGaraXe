using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.DAO;
using WinFormsApp.Screens.fInventory;

namespace WinFormsApp.MainScene.fInventory
{
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            string query = "SELECT  c.MaNKVTPT AS 'ID', NgayNhap AS 'Ngay nhập hàng',   SUM(SoLuong * GiaNhap) AS 'Tổng tiền thanh toán', TenNCC as 'Đơn vị cung cap' FROM   PHIEUNHAPKHOVTPT AS p  INNER JOIN CT_PNKVTPT AS c ON  p.MaNKVTPT = c.MaNKVTPT INNER JOIN NHACUNGCAP as n ON p.MaNCC = n.MaNCC GROUP BY c.MaNKVTPT, NgayNhap, TenNCC";
            DataProvider dataProvider = new DataProvider();
            dgvHistory.DataSource = dataProvider.ExecuteQuery(query);
        }



        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHistory.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvHistory.SelectedRows[0];

                    if (selectedRow.Cells[0].Value != null && selectedRow.Cells[1].Value != null)
                    {
                        string selectedId = selectedRow.Cells[0].Value.ToString();

                        if (DateTime.TryParse(selectedRow.Cells[1].Value.ToString(), out DateTime ngayNhap))
                        {
                            ct_history ct_History = new ct_history(selectedId, ngayNhap);
                            ct_History.Show();
                        }
                        else
                        {
                            MessageBox.Show("Giá trị ngày không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu trong hàng được chọn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radiobtncode.Checked == true)
                {
                    string term = txt_code.Text.Trim();
                    if (string.IsNullOrEmpty(term))
                    {
                        History_Load(sender, e);
                        return;
                    }

                    dgvHistory.DataSource = PhieuNhapKhoVTPTDAO.Instance.getPhieuNhapListByTerm(term);
                }
                else if (radiobtnNgayLap.Checked == true)
                {
                    DateTime startDate = dtpStartDate.Value.Date;
                    DateTime endDate = dtpEndDate.Value.Date;

                    if (startDate > endDate)
                    {
                        MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        History_Load(sender, e);
                        return;
                    }

                    dgvHistory.DataSource = PhieuNhapKhoVTPTDAO.Instance.getPhieuNhapListByDateRange(startDate, endDate);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phương thức tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
