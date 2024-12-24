using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Model
{
    internal class Car
    {
        public static Car Instance = new Car();

        public string Bienso { get; set; }
        public string Hieuxe { get; set; }
        public string TenChuXe { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgayTiepNhan { get; set; }
        public string TienNo { get; set; }
        public string Email { get; set; }
    }

}
