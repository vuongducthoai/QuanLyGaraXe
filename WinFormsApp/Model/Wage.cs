using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Model
{
    internal class Wage
    {
        public static Wage Instance = new Wage();
        public string MaTienCong { get; set; }
        public string NoiDung { get; set; }
        public string TienCong { get; set; }

    }
}
