using ClosedXML.Excel;
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
using Microsoft.Data.SqlClient;

namespace WinFormsApp.Screens.Service.AddService
{
    public partial class fAddService : Form
    {
        public Dictionary<string, object> ServiceDetails { get; private set; } // Lưu trữ thông tin dịch vụ

        public fAddService()
        {
            InitializeComponent();
            GetAutoCompleteData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetAutoCompleteData()
        {
            this.AutoCompleteItems();
            this.AutoCompleteWage();
        }

        private void AutoCompleteItems()
        {
            string queryItems = "SELECT TenVTPT FROM PHUTUNG";
            string columnItems = "TenVTPT";
            cbbItem.AutoCompleteCustomSource = ServiceDAO.instance.LoadAutoCompleteData(queryItems, columnItems);
            cbbItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbItem.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void AutoCompleteWage()
        {
            string queryWages = "SELECT NoiDung FROM TIENCONG";
            string columnWage = "NoiDung";
            cbbWage.AutoCompleteCustomSource = ServiceDAO.instance.LoadAutoCompleteData(queryWages, columnWage);
            cbbWage.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbWage.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void cbbWage_Leave(object sender, EventArgs e)
        {
            string selectedWage = cbbWage.Text;
            string query1 = "SELECT TienCong FROM TIENCONG WHERE NoiDung = @NoiDung";
            string query2 = "SELECT MaTienCong FROM TIENCONG WHERE NoiDung = @NoiDung";

            object result = ServiceDAO.instance.LoadDataByName(query1, "@NoiDung", selectedWage);
            object result2 = ServiceDAO.instance.LoadDataByName(query2, "@NoiDung", selectedWage);
            if (result != null)
            {
                txtWagePrice.Text = result.ToString(); // Điền Tiền công vào TextBox
                txbIdWage.Text = result2.ToString();
            }
        }

        private void cbbItem_Leave(object sender, EventArgs e)
        {
            string selectedItem = cbbItem.Text;
            string query1 = "SELECT DonGia FROM PHUTUNG WHERE TenVTPT = @TenVTPT";
            string query2 = "SELECT MaVTPT FROM PHUTUNG WHERE TenVTPT = @TenVTPT";

            object result = ServiceDAO.instance.LoadDataByName(query1, "@TenVTPT", selectedItem);
            object result2 = ServiceDAO.instance.LoadDataByName(query2, "@TenVTPT", selectedItem);
            if (result != null)
            {
                txtPricePerUnit.Text = result.ToString(); // Điền Đơn giá vào TextBox
                txbIdItem.Text = result2.ToString();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Kiểm tra các giá trị đã được điền đầy đủ chưa
            if (string.IsNullOrEmpty(cbbWage.Text) || string.IsNullOrEmpty(cbbItem.Text) ||
                string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtPricePerUnit.Text) ||
                string.IsNullOrEmpty(txtWagePrice.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ các TextBox và ComboBox
            ServiceDetails = new Dictionary<string, object>
            {
                {"MaVTPT", txbIdItem.Text},
                {"MaTienCong", txbIdWage.Text},
                {"NoiDung", cbbWage.Text},
                {"TenVTPT", cbbItem.Text},
                {"SoLuong", int.Parse(txtQuantity.Text)},
                {"DonGia", decimal.Parse(txtPricePerUnit.Text)},
                {"TienCong", decimal.Parse(txtWagePrice.Text)},
                {"ThanhTien", int.Parse(txtQuantity.Text) * decimal.Parse(txtPricePerUnit.Text) + decimal.Parse(txtWagePrice.Text)}
            };

            this.DialogResult = DialogResult.OK; // Trả kết quả OK về form chính
            this.Close();
        }

        private void UpdateTxtTotalMoney()
        {
            if (int.TryParse(txtQuantity.Text, out int quantity) &&
                decimal.TryParse(txtPricePerUnit.Text, out decimal pricePerUnit) &&
                decimal.TryParse(txtWagePrice.Text, out decimal wagePrice))
            {
                decimal thanhTien = (quantity * pricePerUnit) + wagePrice;
                txtTotalMoney.Text = thanhTien.ToString();
            }
            else
            {
                txtTotalMoney.Text = "0";
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            UpdateTxtTotalMoney();
        }

        private void txtWagePrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
