using WinFormsApp.DAO;
using WinFormsApp.Models;

namespace WinFormsApp.Screens.fReport;

public partial class fBaoCaoTon : Form
{
    public fBaoCaoTon()
    {
        InitializeComponent();
        LoadInitialSetup();
    }

    private void LoadInitialSetup()
    {
        numericMonth.Value = DateTime.Now.Month;
        numericYear.Value = DateTime.Now.Year;
        
        // Cấu hình DataGridView
        ConfigureDataGridView();
        
        // Clear data
        tableBCTK.DataSource = null;
    }

    private void ConfigureDataGridView()
    {
        tableBCTK.Columns.Clear();
        tableBCTK.AutoGenerateColumns = false;

        DataGridViewTextBoxColumn colMaVTPT = new DataGridViewTextBoxColumn();
        colMaVTPT.DataPropertyName = "MaVTPT";
        colMaVTPT.HeaderText = "Mã VTPT";
        colMaVTPT.Name = "MaVTPT";
        colMaVTPT.Width = 220;
        tableBCTK.Columns.Add(colMaVTPT);

        DataGridViewTextBoxColumn colTenVTPT = new DataGridViewTextBoxColumn();
        colTenVTPT.DataPropertyName = "TenVTPT";
        colTenVTPT.HeaderText = "Tên VTPT";
        colTenVTPT.Name = "TenVTPT";
        colTenVTPT.Width = 220;
        tableBCTK.Columns.Add(colTenVTPT);

        DataGridViewTextBoxColumn colTonDau = new DataGridViewTextBoxColumn();
        colTonDau.DataPropertyName = "TonDau";
        colTonDau.HeaderText = "Tồn Đầu";
        colTonDau.Name = "TonDau";
        colTonDau.Width = 217;
        tableBCTK.Columns.Add(colTonDau);

        DataGridViewTextBoxColumn colNhap = new DataGridViewTextBoxColumn();
        colNhap.DataPropertyName = "SoLuongNhap";
        colNhap.HeaderText = "Số Lượng Nhập";
        colNhap.Name = "SoLuongNhap";
        colNhap.Width = 217;
        tableBCTK.Columns.Add(colNhap);

        DataGridViewTextBoxColumn colSuDung = new DataGridViewTextBoxColumn();
        colSuDung.DataPropertyName = "SoLuongSuDung";
        colSuDung.HeaderText = "Số Lượng Sử Dụng";
        colSuDung.Name = "SoLuongSuDung";
        colSuDung.Width = 217;
        tableBCTK.Columns.Add(colSuDung);

        DataGridViewTextBoxColumn colTonCuoi = new DataGridViewTextBoxColumn();
        colTonCuoi.DataPropertyName = "TonCuoi";
        colTonCuoi.HeaderText = "Tồn Cuối";
        colTonCuoi.Name = "TonCuoi";
        colTonCuoi.Width = 217;
        tableBCTK.Columns.Add(colTonCuoi);
    }

    private void LoadBaoCaoData()
    {
        try
        {
            int thang = (int)numericMonth.Value;
            int nam = (int)numericYear.Value;
            
            var data = BaoCaoDAO.Instance.GetBaoCaoTon(thang, nam);
            if (data == null || data.Count == 0)
            {
                MessageBox.Show($"Không có dữ liệu báo cáo tồn kho cho tháng {thang}/{nam}", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tableBCTK.DataSource = null;
                return;
            }

            tableBCTK.DataSource = new BindingSource(data, null);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Có lỗi xảy ra khi tải dữ liệu: {ex.Message}", 
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnShowBCTK_Click(object sender, EventArgs e)
    {
        LoadBaoCaoData();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void label3_Click(object sender, EventArgs e) { }
    private void groupBox1_Enter(object sender, EventArgs e) { }
}