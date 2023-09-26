using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace callwebapi_bai6
{
    class NhanVien
    {
        public string Ma { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public double HsLuong { get; set; }
        public string MaDonVi { get; set; }
        public NhanVien() { }
        public NhanVien(string ma, string hoTen, DateTime ngaySinh, string gioiTinh, double hsLuong, string maDonVi)
        {
            Ma = ma;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            HsLuong = hsLuong;
            MaDonVi = maDonVi;
        }
    }
}
