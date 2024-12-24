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

namespace WinFormsApp.MainScene.fOption
{
    public partial class AddWage : Form
    {

        public AddWage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Wage.Instance = new Wage
                {
                    MaTienCong = txtWageID.Text,
                    NoiDung = txtWageType.Text,
                    TienCong = txtValue.Text
                };

                if (string.IsNullOrWhiteSpace(txtWageID.Text) ||
                    string.IsNullOrWhiteSpace(txtWageType.Text) ||
                    string.IsNullOrWhiteSpace(txtValue.Text))
                {
                    MessageBox.Show("Vui lòng không để trống.");
                    return;
                }

                OptionDAO.Instance.AddWage(Wage.Instance);
                MessageBox.Show("Thêm tiền công thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
