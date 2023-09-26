using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callwebapi_bai6
{
    internal class DonVi
    {
        public string MaDonVi { get; set; }
        public string TenDonVi { get; set; }
        public DonVi() { }
        public DonVi(string maDonVi, string tenDonVi)
        {
            MaDonVi = maDonVi;
            TenDonVi = tenDonVi;
        }
    }
}
