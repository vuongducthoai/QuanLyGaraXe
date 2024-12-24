using WinFormsApp.Model;

namespace WinFormsApp.Models
{
    public class PhieuNhapKhoVTPT
    {
        public string maNKVTPT { get; set; }
        public DateTime ngayNhap { get; set; }

        public Supplier supplier { get; set; }

        public PhieuNhapKhoVTPT() { }

        public PhieuNhapKhoVTPT(DateTime ngayNhap, Supplier supplier)
        {
            ngayNhap = ngayNhap;
            supplier = supplier;
        }

    }
}