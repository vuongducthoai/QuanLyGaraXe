using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Screens.Service;
using WinFormsApp.Screens.Service.InforCar;
using WinFormsApp.DAO;

namespace WinFormsApp.Screens.Service.Payment
{
    public partial class fPayment : Form
    {
        public fPayment(DataGridView table)
        {
            InitializeComponent();
            CopyDataFromDataGridView(table);
        }

        private void fPaying_Load(object sender, EventArgs e)
        {
            //Sum total amount
            this.lbTotalAmout.Text = CalculateTotalAmount().ToString();
            this.SetInforCustomer();

            General.Instance.TxtMakeTextDisappear(txtIdRepair, "A225@gmail.com");
            this.txtIdRepair.Text = RepairDAO.instance.LoadIdRepair();
        }

        private void SetInforCustomer()
        {
            fInforCar f = new fInforCar();
            this.lbNameCustomer.Text = f.lbCustomerName.Text;
            this.lbPhoneNumber.Text = f.lbPhone.Text;
            this.lbPlateLicense.Text = f.lbPlateLicense.Text;
        }

        private double CalculateTotalAmount()
        {
            double totalAmount = 0;
            try
            {
                foreach (DataGridViewRow row in dtgvPayment.Rows)
                {
                    totalAmount += Convert.ToDouble(row.Cells["cellTotalMoney"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            return totalAmount;
        }

        private void CopyDataFromDataGridView(DataGridView source)
        {
            // Xóa dữ liệu cũ (nếu có) trong dtgvPayment
            dtgvPayment.Rows.Clear();
            dtgvPayment.Columns.Clear();

            // Sao chép cột
            foreach (DataGridViewColumn col in source.Columns)
            {
                DataGridViewColumn newCol = (DataGridViewColumn)col.Clone();
                newCol.Name = col.Name; // Giữ nguyên Name của cột
                dtgvPayment.Columns.Add(newCol);
            }


            // Sao chép dòng
            foreach (DataGridViewRow row in source.Rows)
            {
                if (!row.IsNewRow) // Bỏ qua dòng trống cuối cùng
                {
                    DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        newRow.Cells[i].Value = row.Cells[i].Value;
                    }
                    dtgvPayment.Rows.Add(newRow);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPaying_Click(object sender, EventArgs e)
        {
            //// Lấy mã phiếu sửa chữa (giả sử mã được sinh tự động hoặc nhập từ giao diện)
            //string maPSC = txtMaPSC.Text;

            //// Lấy tiền thu và tiền nợ còn lại
            //decimal Received = string.IsNullOrEmpty(txtAmoutPaying.Text) ? 0 : Convert.ToDecimal(txtAmoutPaying.Text);
            //decimal TheRest = string.IsNullOrEmpty(lbTheRestAmout.Text) ? 0 : Convert.ToDecimal(lbTheRestAmout.Text);

            //// Kiểm tra ràng buộc
            //if (Received > TheRest)
            //{
            //    MessageBox.Show("Tiền thu không được lớn hơn tiền nợ còn lại.");
            //    return;
            //}

            //// Lấy dữ liệu từ DataGridView
            //DataTable paymentDetails = (DataTable)dtgvPayment.DataSource;

            //// Gọi hàm trong ServiceDAO
            //bool isInserted = ServiceDAO.Instance.InsertPaymentDetails(paymentDetails, maPSC);

            //if (isInserted)
            //{
            //    MessageBox.Show("Thanh toán thành công!");
            //    // Thực hiện các bước khác nếu cần, như làm mới giao diện
            //}
            //else
            //{
            //    MessageBox.Show("Thanh toán thất bại!");
            //}
        }
    }
}
