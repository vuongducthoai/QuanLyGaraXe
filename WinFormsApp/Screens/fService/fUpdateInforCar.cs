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
using WinFormsApp.Model;

namespace WinFormsApp.Screens.Service.UpdateInforCar
{
    public partial class fUpdateInforCar : Form
    {
        public fUpdateInforCar()
        {
            InitializeComponent();
        }

        private void fChangeInforCar_Load(object sender, EventArgs e)
        {
            this.GetCarBrandAutoComplete();
        }

        private void GetCarBrandAutoComplete()
        {
            string queryCarBrand = "SELECT DISTINCT HieuXe FROM dbo.XE";
            string columnCarBrand = "HieuXe";
            cbbCarBrand.AutoCompleteCustomSource = ServiceDAO.instance.LoadAutoCompleteData(queryCarBrand, columnCarBrand);
            cbbCarBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCarBrand.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbLicensePlate.Text) || String.IsNullOrEmpty(cbbCarBrand.Text)
                    || String.IsNullOrEmpty(txbCustomerName.Text) || String.IsNullOrEmpty(txbEmail.Text)
                    || String.IsNullOrEmpty(txbAddress.Text) || String.IsNullOrEmpty(txbPhoneNumber.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                ServiceDAO.instance.UpdateInforCar(new Car()
                {
                    Bienso = txbLicensePlate.Text,
                    Hieuxe = cbbCarBrand.Text,
                    TenChuXe = txbCustomerName.Text,
                    DiaChi = txbAddress.Text,
                    DienThoai = txbPhoneNumber.Text,
                    Email = txbEmail.Text,
                    NgayTiepNhan = DateTime.Now,
                    TienNo = txbDebt.Text
                });

                MessageBox.Show("Cập nhật thông tin thành công!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
