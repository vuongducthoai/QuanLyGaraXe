namespace WinFormsApp.Models
{
    public class CT_PNKVTPT
    {
        public static CT_PNKVTPT Instance = new CT_PNKVTPT();
        public PhieuNhapKhoVTPT phieuNhapKhoVTPT { get; set; }
        public PhuTung phuTung { get; set; }
        public string TenVTPT { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaNhap { get; set; }
    }
}