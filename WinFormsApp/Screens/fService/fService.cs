using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.DAO;
using WinFormsApp.Screens.Service.InforCar;
using WinFormsApp.Screens.Service.AddCar;
using WinFormsApp.Screens.Service.ListPayment;
using WinFormsApp.Screens.Service.UpdateInforCar;
using WinFormsApp.Screens.Service.ListRepair;
using WinFormsApp.Screens.Service.Payment;


namespace WinFormsApp.Screens.Service
{
    public partial class fService : Form
    {
        public fService()
        {
            InitializeComponent();
            this.LoadCarData();
            this.LoadAutoCompleteData();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            General.Instance.CbbMakeTextDisappear(cbbLicensePlate, "Biển số");
            General.Instance.CbbMakeTextDisappear(cbbCarBrand, "Hiệu xe");
            General.Instance.CbbMakeTextDisappear(cbbTenChuXe, "Chủ xe");
            General.Instance.CbbMakeTextDisappear(cbbPhoneNumber, "Số điện thoại");
        }


        private void LoadCarData()
        {
            string query = "SELECT * FROM dbo.XE";
            ServiceDAO.instance.LoadData(query, dtgvService);
        }
        //load auto complete data
        private void LoadAutoCompleteData()
        {
            this.GetLicensePlateAutoComplete();
            this.GetPhoneNumberAutoComplete();
            this.GetCustomerNameAutoComplete();
            this.GetCarBrandAutoComplete();
        }

        private void GetLicensePlateAutoComplete()
        {
            string queryLicensePlate = "SELECT DISTINCT BienSo FROM dbo.XE";
            string columnLicensePlate = "BienSo";
            cbbLicensePlate.AutoCompleteCustomSource = ServiceDAO.instance.LoadAutoCompleteData(queryLicensePlate, columnLicensePlate);
            cbbLicensePlate.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbLicensePlate.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void GetPhoneNumberAutoComplete()
        {
            string queryPhoneNumber = "SELECT DISTINCT DienThoai FROM dbo.XE";
            string columnPhoneNumber = "DienThoai";
            cbbPhoneNumber.AutoCompleteCustomSource = ServiceDAO.instance.LoadAutoCompleteData(queryPhoneNumber, columnPhoneNumber);
            cbbPhoneNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbPhoneNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void GetCustomerNameAutoComplete()
        {
            string queryCustomerName = "SELECT DISTINCT TenChuXe FROM dbo.XE";
            string columnCustomerName = "TenChuXe";
            cbbTenChuXe.AutoCompleteCustomSource = ServiceDAO.instance.LoadAutoCompleteData(queryCustomerName, columnCustomerName);
            cbbTenChuXe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbTenChuXe.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void GetCarBrandAutoComplete()
        {
            string queryCarBrand = "SELECT DISTINCT HieuXe FROM dbo.XE";
            string columnCarBrand = "HieuXe";
            cbbCarBrand.AutoCompleteCustomSource = ServiceDAO.instance.LoadAutoCompleteData(queryCarBrand, columnCarBrand);
            cbbCarBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCarBrand.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbbLicensePlate_Click(object sender, EventArgs e)
        {
            if (cbbLicensePlate.Text == "Biển Số")
            {
                cbbLicensePlate.Text = "";
            }
        }

        private void cbbHieuXe_Click(object sender, EventArgs e)
        {
            if (cbbCarBrand.Text == "Hiệu xe")
            {
                cbbCarBrand.Text = "";
            }
        }

        private void cbbTienNo_Click(object sender, EventArgs e)
        {
            if (cbbPhoneNumber.Text == "Tiền nợ")
            {
                cbbPhoneNumber.Text = "";
            }
        }

        private void cbbChuXe_Click(object sender, EventArgs e)
        {
            if (cbbTenChuXe.Text == "Chủ xe")
            {
                cbbTenChuXe.Text = "";
            }
        }

        private void cbbHieuXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            fAddCar f = new fAddCar();
            f.ShowDialog();
            this.LoadCarData();
            this.Show();
        }

        private void dgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvService_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbbLicensePlate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            fInforCar f = new fInforCar();
            if (dtgvService.SelectedRows.Count > 0)
            {
                string customerName = dtgvService.SelectedRows[0].Cells["TenChuXe"].Value.ToString();
                string licensePlate = dtgvService.SelectedRows[0].Cells["BienSo"].Value.ToString();
                string carBrand = dtgvService.SelectedRows[0].Cells["HieuXe"].Value.ToString();
                string phoneNumber = dtgvService.SelectedRows[0].Cells["DienThoai"].Value.ToString();
                string address = dtgvService.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                string date = dtgvService.SelectedRows[0].Cells["NgayTiepNhan"].Value.ToString();
                string debt = dtgvService.SelectedRows[0].Cells["TienNo"].Value.ToString();

                // Truyền thông tin sang fInforCar
                f.lbCustomerName.Text = customerName;
                f.lbPlateLicense.Text = licensePlate;
                f.lbCarBrand.Text = carBrand;
                f.lbPhone.Text = phoneNumber;
                f.lbAddress.Text = address;
                f.dtpDateReceived.Text = date;
                f.lbDebt.Text = debt;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row before viewing details.");
            }
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            string plateLicense = (string)dtgvService.SelectedRows[0].Cells["BienSo"].Value;
            ServiceDAO.instance.DelCar(plateLicense);
            this.LoadCarData();
        }

        private void bnFind_Click(object sender, EventArgs e)
        {
            string plateLicense = cbbLicensePlate.Text.Trim();
            string carBrand = cbbCarBrand.Text.Trim();
            string customerName = cbbTenChuXe.Text.Trim();
            string phoneNumber = cbbPhoneNumber.Text.Trim();
            string date = dtpDateService.Value.ToString("yyyy-MM-dd");

            // Tạo dictionary chứa các điều kiện tìm kiếm
            Dictionary<string, string> conditions = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(plateLicense) && plateLicense != "Biển số")
            {
                conditions.Add("BienSo", plateLicense);
            }
            if (!string.IsNullOrEmpty(carBrand) && carBrand != "Hiệu xe")
            {
                conditions.Add("HieuXe", carBrand);
            }
            if (!string.IsNullOrEmpty(customerName) && customerName != "Chủ xe")
            {
                conditions.Add("TenChuXe", customerName);
            }
            if (!string.IsNullOrEmpty(phoneNumber) && phoneNumber != "Số điện thoại")
            {
                conditions.Add("DienThoai", phoneNumber);
            }
            if (!string.IsNullOrEmpty(date))
            {
                conditions.Add("NgayTiepNhan", date);
            }

            // Gọi hàm FindCar từ ServiceDAO
            DataTable result = ServiceDAO.instance.FindCar(conditions);

            // Kiểm tra kết quả và hiển thị
            if (result != null && result.Rows.Count > 0)
            {
                dtgvService.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy xe với thông tin này.");
                this.LoadCarData();
            }
        }


        private void cbbChuXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadCarData();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            //fPaying fPaying = new fPaying(table);
            //fPaying.ShowDialog();
        }

        private void ChangeInfor_Click(object sender, EventArgs e)
        {
            if (dtgvService.SelectedRows.Count == 0) return;
            fUpdateInforCar f = new fUpdateInforCar();
            if (dtgvService.SelectedRows.Count > 0)
            {
                string customerName = dtgvService.SelectedRows[0].Cells["TenChuXe"].Value.ToString();
                string licensePlate = dtgvService.SelectedRows[0].Cells["BienSo"].Value.ToString();
                string carBrand = dtgvService.SelectedRows[0].Cells["HieuXe"].Value.ToString();
                string phoneNumber = dtgvService.SelectedRows[0].Cells["DienThoai"].Value.ToString();
                string address = dtgvService.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                string date = dtgvService.SelectedRows[0].Cells["NgayTiepNhan"].Value.ToString();
                string debt = dtgvService.SelectedRows[0].Cells["TienNo"].Value.ToString();
                string email = dtgvService.SelectedRows[0].Cells["Email"].Value.ToString();

                // Truyền thông tin sang fInforCar
                f.txbCustomerName.Text = customerName;
                f.txbLicensePlate.Text = licensePlate;
                f.cbbCarBrand.Text = carBrand;
                f.txbPhoneNumber.Text = phoneNumber;
                f.txbAddress.Text = address;
                f.dtpDateReceived.Text = date;
                f.txbDebt.Text = debt;
                f.txbEmail.Text = email;
                f.ShowDialog();
            }
        }

        private void ListRepair_Click(object sender, EventArgs e)
        {
            fListRepair f = new fListRepair();
            f.ShowDialog();
        }

        private void ListPayment_Click(object sender, EventArgs e)
        {
            fListPayment f = new fListPayment();
            f.ShowDialog();
        }
    }
}
