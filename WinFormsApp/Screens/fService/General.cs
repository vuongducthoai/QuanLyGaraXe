using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Microsoft.Data.SqlClient;
using WinFormsApp.DAO;

namespace WinFormsApp.Screens.Service
{
    internal class General
    {
        public static General Instance => new General();
        public void CbbMakeTextDisappear(ComboBox cbb, string sph)
        {
            cbb.Text = sph;
            cbb.ForeColor = Color.Gray;

            cbb.Enter += (sender, e) =>
            {
                if (cbb.Text == sph)
                {
                    cbb.Text = "";
                    cbb.ForeColor = Color.Black;
                }
            };

            cbb.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(cbb.Text))
                {
                    cbb.Text = sph;
                    cbb.ForeColor = Color.Gray;
                }
            };
        }
        public void TxtMakeTextDisappear(TextBox txtBox, string sph)
        {
            txtBox.Text = sph;
            txtBox.ForeColor = Color.Gray;

            txtBox.Enter += (sender, e) =>
            {
                if (txtBox.Text == sph)
                {
                    txtBox.Text = "";
                    txtBox.ForeColor = Color.Black;
                }
            };

            txtBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBox.Text))
                {
                    txtBox.Text = sph;
                    txtBox.ForeColor = Color.Gray;
                }
            };
        }
    }
}
