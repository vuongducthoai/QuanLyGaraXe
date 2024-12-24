using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp.DAO;
using WinFormsApp.MainScene.fInventory;
using WinFormsApp.Models;

namespace WinFormsApp.Screens.fInventory
{
    public partial class MuaPhuTung : Form
    {
        private string _action;
        private fPayment _payment;

        public MuaPhuTung(string action, fPayment payment)
        {
            InitializeComponent();
            _action = action;
            _payment = payment;

            if (action.Equals("Add"))
            {
                btnAdd.Text = "Thêm";
                cbb_inventory.Enabled = true;
            }
            else
            {
                btnAdd.Text = "Sửa";
                cbb_inventory.Enabled = false;
            }
        }

        private void MuaPhuTung_Load(object sender, EventArgs e)
        {
            if (_action.Equals("Add"))
            {
                List<PhuTung> phuTungList = PhuTungDAO.Instance.GetAllPhuTung();
                cbb_inventory.DataSource = phuTungList;
                cbb_inventory.DisplayMember = "TenVTPT";
                cbb_inventory.ValueMember = "MaVTPT";

              
                cbb_inventory.SelectedIndex = 0;
            } else if (_action.Equals("Update")){
                if(_payment.dgvNhapHang.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = _payment.dgvNhapHang.SelectedRows[0];
                    cbb_inventory.Text = selectedRow.Cells[1].Value?.ToString();
                    txt_price.Text = selectedRow.Cells[2].Value?.ToString();      
                    txt_quantity.Text = selectedRow.Cells[3].Value?.ToString();   
                    txt_total.Text = selectedRow.Cells[4].Value?.ToString();
                    ValidateAndCalculateTotal();
                } else
                {
                    MessageBox.Show("Vui lòng chọn vật tư để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_action.Equals("Add"))
            {
                string selectedMaVTPT = cbb_inventory.SelectedValue?.ToString();
                string selectedTenVTPT = cbb_inventory.Text;
                int giaNhap = int.TryParse(txt_price.Text, out int parsedGiaNhap) ? parsedGiaNhap : 0;
                int soLuong = int.TryParse(txt_quantity.Text, out int parsedSoLuong) ? parsedSoLuong : 0;
                decimal total = giaNhap * soLuong;

                _payment.dgvNhapHang.Rows.Add(
                    _payment.dgvNhapHang.Rows.Count + 1,
                    selectedTenVTPT,
                    giaNhap.ToString("N0"),
                    soLuong,
                    total.ToString("N0")
                );

                MessageBox.Show("Đã thêm phụ tùng vào danh sách!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _payment.UpdateTongTien();
                this.Close();
            } else if (_action.Equals("Update")){
                if (_payment.dgvNhapHang.SelectedRows.Count > 0)
                {
                    ValidateAndCalculateTotal();
                    DataGridViewRow selectedRow = _payment.dgvNhapHang.SelectedRows[0];

                    selectedRow.Cells[1].Value = cbb_inventory.Text; 
                    selectedRow.Cells[2].Value = txt_price.Text;     
                    selectedRow.Cells[3].Value = txt_quantity.Text;  
                    selectedRow.Cells[4].Value = txt_total.Text;   

                    MessageBox.Show("Dữ liệu đã được cập nhật!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _payment.UpdateTongTien();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_action.Equals("Add"))
            {
                cbb_inventory.SelectedIndex = 0;
                txt_price.Text = "";
                txt_quantity.Text = "";
                txt_total.Text = "";
            } else if (_action.Equals("Update"))
            {
                this.Close();
            }
        }

        private void cbb_inventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_inventory.SelectedValue != null)
            {
                string selectedMaVTPT = cbb_inventory.SelectedValue.ToString();
            }
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            ValidateAndCalculateTotal();
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            ValidateAndCalculateTotal();
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidateAndCalculateTotal()
        {
            if (!int.TryParse(txt_price.Text, out int giaNhap) || giaNhap < 0)
            {
                txt_price.SelectionStart = txt_price.Text.Length;
                return;
            }

            if (!int.TryParse(txt_quantity.Text, out int soLuong) || soLuong < 0)
            {
                txt_quantity.SelectionStart = txt_quantity.Text.Length;
                return;
            }

            txt_total.Text = (giaNhap * soLuong).ToString("N0");
        }
    }
}
