using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Model
{
    public class Supplier
    {
        public static Supplier Instance = new Supplier();
        public string maNCC { get; set; }
        public string tenNCC { get; set; }
        public string soDT { get; set; }
        public string email { get; set; }
    }
}
