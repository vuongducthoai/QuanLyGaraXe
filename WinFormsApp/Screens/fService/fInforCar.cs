using DocumentFormat.OpenXml.Spreadsheet;
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
using WinFormsApp.Models;
using WinFormsApp.Screens.Service.AddService;
using WinFormsApp.Screens.Service.Payment;
using WinFormsApp.Screens.Service.UpdateInforCar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp.Screens.Service.InforCar
{
    public partial class fInforCar : Form
    {
        public fInforCar()
        {
            InitializeComponent();
        }

        private void fInforCar_Load(object sender, EventArgs e)
        {
            this.lbIdRepair.Text = RepairDAO.instance.LoadIdRepair();
        }

        private void UpdateTotalAmount()
        {
            double totalAmount = 0;
            try
            {
                foreach (DataGridViewRow row in dtgvServiceCar.Rows)
                {
                    if (row.Cells["cellTotalMoney"].Value != null)
                    {
                        totalAmount += Convert.ToDouble(row.Cells["cellTotalMoney"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            lbTotalAmout.Text = totalAmount.ToString("N2"); // Định dạng số tiền với 2 chữ số thập phân
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddService_Click(object sender, EventArgs e)
        {
            fAddService f = new fAddService();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string idWage = f.ServiceDetails["MaTienCong"].ToString();
                string idItem = f.ServiceDetails["MaVTPT"].ToString();
                string wage = f.ServiceDetails["NoiDung"].ToString();
                string wagePrice = f.ServiceDetails["TienCong"].ToString();
                string pricePerUnit = f.ServiceDetails["DonGia"].ToString();
                string item = f.ServiceDetails["TenVTPT"].ToString();
                string quantity = f.ServiceDetails["SoLuong"].ToString();
                string totalPrice = f.ServiceDetails["ThanhTien"].ToString();

                this.dtgvServiceCar.Rows.Add(wage, idItem, item, quantity, pricePerUnit, wagePrice, totalPrice);
                this.lbIdWage.Text = idWage;
                this.UpdateTotalAmount();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvServiceCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelService_Click(object sender, EventArgs e)
        {
            try
            {
                this.dtgvServiceCar.Rows.RemoveAt(this.dtgvServiceCar.CurrentRow.Index);
                this.UpdateTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa dòng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddRepair_Click(object sender, EventArgs e)
        {
            if (dtgvServiceCar.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin!");
            }
            else
            {
                try
                {
                    RepairDAO.instance.AddRepair(new PhieuSuaChua()
                    {
                        MaPSC = this.lbIdRepair.Text,
                        BienSo = lbPlateLicense.Text,
                        //NgaySuaChua = this.dtpDateFix.Value,
                        TongTien = Convert.ToDouble(lbTotalAmout.Text)
                    });

                    foreach (DataGridViewRow dataRow in dtgvServiceCar.Rows)
                    {
                        RepairDAO.instance.AddRepair_Detail(new CT_PSC()
                        {
                            MaPSC = this.lbIdRepair.Text,
                            NoiDung = dataRow.Cells["CellWage"].Value.ToString(),
                            MaVTPT = dataRow.Cells["cellIdItem"].Value.ToString(),
                            TenVTPT = dataRow.Cells["cellItem"].Value.ToString(),
                            SoLuong = Convert.ToInt32(dataRow.Cells["cellQuantity"].Value),
                            DonGia = Convert.ToDecimal(dataRow.Cells["cellPricePerUnit"].Value),
                            MaTienCong = this.lbIdWage.Text,
                            TienCong = Convert.ToDecimal(dataRow.Cells["cellWagePrice"].Value.ToString()),
                            ThanhTien = Convert.ToDecimal(dataRow.Cells["cellTotalMoney"].Value.ToString())
                        });
                        MessageBox.Show("Thêm phiếu sửa chữa thành công!");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
