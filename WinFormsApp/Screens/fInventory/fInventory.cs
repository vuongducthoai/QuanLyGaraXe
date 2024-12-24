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
using WinFormsApp.MainScene.fInventory;

namespace WinFormsApp
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            LoadPhuTung();
        }


        public void LoadPhuTung()
        {

            string query = "SELECT p.TenVTPT as 'Phụ Tùng', c.GiaNhap as 'Gía Nhập', p.SoLuongTon as 'Số lượng', p.DonGia as 'Đơn giá'  FROM PHUTUNG as p LEFT JOIN CT_PNKVTPT as c ON p.MaVTPT = c.MaVTPT";
            DataProvider dataProvider = new DataProvider();
            dgvPhuTung.DataSource = dataProvider.ExecuteQuery(query);
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            fPayment fPayment = new fPayment();
            fPayment.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add add = new add(this);
            add.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            invoice invoice = new invoice();
            invoice.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            history history = new history();
            history.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fPayment payment = new fPayment();
            payment.Show();
        }

        private void timkiem()
        {
            try
            {
                string term = txtCode.Text.Trim();

                if (string.IsNullOrEmpty(term))
                {
                    LoadPhuTung();
                    return;
                }

                DataTable result = PhuTungDAO.Instance.GetPhuTungByName(term);

                if (result.Rows.Count > 0)
                {
                    dgvPhuTung.DataSource = result;
                }
                else
                {
                    LoadPhuTung();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timkiem();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }
    }
}
