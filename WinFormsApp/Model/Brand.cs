using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Model
{
    internal class Brand
    {
        public static Brand Instance = new Brand();
        public string HieuXe { get; set; }
    }
}
