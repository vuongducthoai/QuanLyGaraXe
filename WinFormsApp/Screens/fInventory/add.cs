using DocumentFormat.OpenXml.Bibliography;
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
using WinFormsApp.Models;

namespace WinFormsApp.MainScene.fInventory
{
    public partial class add : Form
    {
        private Inventory _inventory;
        public add(Inventory inventory)
        {
            InitializeComponent();
            txt_price.Text = "0";
            _inventory = inventory;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tenPhuTung = txtTenPT.Text.Trim();
            string giaBan = txt_price.Text.Trim();

            if (string.IsNullOrEmpty(tenPhuTung))
            {
                MessageBox.Show("Tên phụ tùng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPT.Focus();
                return;
            }

            if (string.IsNullOrEmpty(giaBan))
            {
                MessageBox.Show("Đơn giá không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_price.Focus();
                return;
            }

            if (!decimal.TryParse(giaBan.Replace(" ", ""), out decimal donGia))
            {
                MessageBox.Show("Đơn giá phải là một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_price.Focus();
                return;
            }
  
            try
            {
                PhuTung phuTung = new PhuTung
                {
                    TenVTPT = tenPhuTung,
                    DonGia = donGia
                };
                if (PhuTungDAO.Instance.FindPhuTungByName(phuTung))
                {

                    MessageBox.Show("Tên phụ tùng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else
                {
                    PhuTungDAO.Instance.AddPhuTung(phuTung);
                    MessageBox.Show("Thêm phụ tùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _inventory.LoadPhuTung();
                }

                txtTenPT.Clear();
                txt_price.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
