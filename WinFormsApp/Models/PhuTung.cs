using WinFormsApp.Model;

namespace WinFormsApp.Models
{
    public class PhuTung
    {
        public string MaVTPT { get; set; }
        public string TenVTPT { get; set; }
        public int SoLuongTon { get; set; }
        public decimal DonGia { get; set; }

        public PhuTung() { }

        public PhuTung(string tenVTPT, decimal donGia)
        {
            TenVTPT = tenVTPT;
            DonGia = donGia;
        }
    }
}