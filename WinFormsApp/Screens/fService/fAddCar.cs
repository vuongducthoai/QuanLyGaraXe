using WinFormsApp.DAO;
using WinFormsApp.Model;
using WinFormsApp.Screens.Service;

namespace WinFormsApp.Screens.Service.AddCar
{
    public partial class fAddCar : Form
    {
        public fAddCar()
        {
            InitializeComponent();
            this.GetCarBrandAutoComplete();
        }

        private void fAddCar_Load(object sender, EventArgs e)
        {
            General.Instance.TxtMakeTextDisappear(txbNameCarOwner, "Tên chủ xe");
            General.Instance.TxtMakeTextDisappear(txbLicensePlate, "Biển số xe");
            General.Instance.TxtMakeTextDisappear(txbAddress, "Địa chỉ");
            General.Instance.TxtMakeTextDisappear(txbPhoneNumber, "Số điện thoại");
            General.Instance.TxtMakeTextDisappear(txbEmail, "Email");
        }

        private void GetCarBrandAutoComplete()
        {
            string queryCarBrand = "SELECT DISTINCT HieuXe FROM dbo.XE";
            string columnCarBrand = "HieuXe";
            cbbTypeOfCar.AutoCompleteCustomSource = ServiceDAO.instance.LoadAutoCompleteData(queryCarBrand, columnCarBrand);
            cbbTypeOfCar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbTypeOfCar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Car.Instance = new Car
                {
                    TenChuXe = txbNameCarOwner.Text,
                    Hieuxe = cbbTypeOfCar.Text,
                    Bienso = txbLicensePlate.Text,
                    DiaChi = txbAddress.Text,
                    DienThoai = txbPhoneNumber.Text,
                    Email = txbEmail.Text,
                    NgayTiepNhan = dtpDateReceived.Value < new DateTime(1753, 1, 1) ? DateTime.Now : dtpDateReceived.Value,
                    TienNo = "0"
                };

                // Kiểm tra thông tin nhập liệu
                if (string.IsNullOrWhiteSpace(txbNameCarOwner.Text) ||
                    string.IsNullOrWhiteSpace(txbLicensePlate.Text) ||
                    string.IsNullOrWhiteSpace(txbAddress.Text) ||
                    string.IsNullOrWhiteSpace(txbPhoneNumber.Text) ||
                    string.IsNullOrWhiteSpace(txbEmail.Text))
                {
                    MessageBox.Show("Please fill out all the required fields.");
                    return;
                }

                // Thêm vào cơ sở dữ liệu
                ServiceDAO.instance.AddCar(Car.Instance);
                MessageBox.Show("Thêm xe thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiệu xe không tồn tại");
            }
        }


        private void cbbTypeOfCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
