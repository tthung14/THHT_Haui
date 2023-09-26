using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bai6.Models
{
    public class NhanVien
    {
        [Key]
        public string Ma { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public double HsLuong { get; set; }
        public string MaDonVi { get; set; }
    }
}