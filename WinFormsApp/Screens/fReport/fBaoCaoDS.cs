using WinFormsApp.Models;
using System;
using WinFormsApp.DAO;

namespace WinFormsApp.Screens.fReport
{
    public partial class fBaoCaoDS : Form
    {
        public fBaoCaoDS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Implement the event handler if needed
        }

        private void fBaoCaoDS_Load(object sender, EventArgs e)
        {
            numericMonth.Value = DateTime.Now.Month;
            numericYear.Value = DateTime.Now.Year;
            
            // Cấu hình DataGridView
            ConfigureDataGridView();
            
            // Clear data
            tableBCDS.DataSource = null;
            tb_TongDTHU.Clear();
        }

        private void ConfigureDataGridView()
        {
            tableBCDS.Columns.Clear();
            
            tableBCDS.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colHieuXe = new DataGridViewTextBoxColumn();
            colHieuXe.DataPropertyName = "HieuXe";
            colHieuXe.HeaderText = "Hiệu Xe";
            colHieuXe.Name = "HieuXe";
            colHieuXe.Width = 329;
            tableBCDS.Columns.Add(colHieuXe);

            DataGridViewTextBoxColumn colSoLuotSua = new DataGridViewTextBoxColumn();
            colSoLuotSua.DataPropertyName = "SoLuotSua";
            colSoLuotSua.HeaderText = "Số Lượt Sửa";
            colSoLuotSua.Name = "SoLuotSua";
            colSoLuotSua.Width = 329;
            tableBCDS.Columns.Add(colSoLuotSua);

            DataGridViewTextBoxColumn colThanhTien = new DataGridViewTextBoxColumn();
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành Tiền";
            colThanhTien.Name = "ThanhTien";
            colThanhTien.Width = 330;
            colThanhTien.DefaultCellStyle.Format = "N0";
            tableBCDS.Columns.Add(colThanhTien);

            DataGridViewTextBoxColumn colTiLe = new DataGridViewTextBoxColumn();
            colTiLe.DataPropertyName = "TiLe";
            colTiLe.HeaderText = "Tỉ Lệ";
            colTiLe.Name = "TiLe";
            colTiLe.Width = 330;
            colTiLe.DefaultCellStyle.Format = "N2";
            tableBCDS.Columns.Add(colTiLe);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Implement the event handler if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Implement the event handler if needed
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Implement the event handler if needed
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Implement the event handler if needed
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Implement the event handler if needed
        }

        private void numericYear_ValueChanged(object sender, EventArgs e)
        {
            // Implement the event handler if needed
        }

        private void numericMonth_ValueChanged(object sender, EventArgs e)
        {
            // Implement the event handler if needed
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadBaoCaoData()
        {
            try
            {
                int thang = (int)numericMonth.Value;
                int nam = (int)numericYear.Value;

                var data = BaoCaoDAO.Instance.GetBaoCaoDoanhSo(thang, nam);
                
                if (data.Count == 0)
                {
                    MessageBox.Show($"Không có dữ liệu báo cáo cho tháng {thang}/{nam}", 
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tableBCDS.DataSource = null;
                    tb_TongDTHU.Text = "0 VNĐ";
                    return;
                }

                tableBCDS.DataSource = new BindingSource(data, null);

                decimal tongDoanhThu = BaoCaoDAO.Instance.GetTongDoanhThu(thang, nam);
                tb_TongDTHU.Text = tongDoanhThu.ToString("N0") + " VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi tải dữ liệu: {ex.Message}", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowBCDS_Click(object sender, EventArgs e)
        {
            LoadBaoCaoData();
        }
    }
}