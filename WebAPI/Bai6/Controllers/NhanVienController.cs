using Bai6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai6.Controllers
{
    public class NhanVienController : ApiController
    {
        public List<NhanVien> Get()
        {
            QLLuongContext db = new QLLuongContext();
            return db.NhanViens.ToList();
        }

        public IHttpActionResult Post([FromBody] NhanVien nhanVien)
        {
            using (QLLuongContext db = new QLLuongContext())
            {
                db.NhanViens.Add(nhanVien);
                db.SaveChanges();
            }
            return Ok();
        }

        public IHttpActionResult Put([FromBody] NhanVien nhanVien)
        {
            using (QLLuongContext db = new QLLuongContext())
            {
                NhanVien nv = db.NhanViens.Find(nhanVien.Ma);
                if (nv != null)
                {
                    if (nhanVien.HoTen != null)
                        nv.HoTen = nhanVien.HoTen;
                    if (nhanVien.NgaySinh != null)
                        nv.NgaySinh = nhanVien.NgaySinh;
                    if (nhanVien.GioiTinh != null)
                        nv.GioiTinh = nhanVien.GioiTinh;
                    if (nhanVien.HsLuong != 0)
                        nv.HsLuong = nhanVien.HsLuong;
                    if (nhanVien.MaDonVi != null)
                        nv.MaDonVi = nhanVien.MaDonVi;
                    db.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok(nhanVien);
        }

        public IHttpActionResult Delete(string Ma)
        {
            using (QLLuongContext db = new QLLuongContext())
            {
                NhanVien nhanVien = db.NhanViens.FirstOrDefault(nv => nv.Ma == Ma);
                if (nhanVien != null)
                {
                    db.NhanViens.Remove(nhanVien);
                    db.SaveChanges();
                }
                else
                    return NotFound();
            }
            return Ok();
        }
    }
}
