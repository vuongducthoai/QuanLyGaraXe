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
using WinFormsApp.Models;

namespace WinFormsApp.Screens.fInventory
{
    public partial class ct_history : Form
    {
        private string maPN;
        private DateTime ngayNhap;
        public ct_history(string maPN, DateTime ngayNhap)
        {
            InitializeComponent();
            this.maPN = maPN;
            this.ngayNhap = ngayNhap;
        }

        private void ct_history_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaPN.ReadOnly = true;
                datetimepiker.Enabled = false;

                txtMaPN.Text = maPN;

                if (ngayNhap < datetimepiker.MinDate || ngayNhap > datetimepiker.MaxDate)
                {
                    datetimepiker.Value = DateTime.Now; 
                }
                else
                {
                    datetimepiker.Value = ngayNhap;
                }

                List<CT_PNKVTPT> cT_PNKVTPTs = PhieuNhapKhoVTPTDAO.Instance.getPNKVTPTList(maPN);
                dgvCTPN.Rows.Clear();

                foreach (var item in cT_PNKVTPTs)
                {
                    dgvCTPN.Rows.Add(
                        item.phuTung.MaVTPT,
                        item.phuTung.TenVTPT,
                        item.SoLuong,
                        item.GiaNhap
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải lịch sử: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
