using Bai6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai6.Controllers
{
    public class DonViController : ApiController
    {
        public List<DonVi> Get()
        {
            QLLuongContext db = new QLLuongContext();
            return db.DonVis.ToList();
        }

        public IHttpActionResult Post([FromBody] DonVi donVi)
        {
            using (QLLuongContext db = new QLLuongContext())
            {
                db.DonVis.Add(donVi);
                db.SaveChanges();
            }
            return Ok();
        }

        public IHttpActionResult Put([FromBody] DonVi donVi)
        {
            using (QLLuongContext db = new QLLuongContext())
            {
                DonVi dv = db.DonVis.Find(donVi.MaDonVi);
                if (dv != null)
                {
                    dv.TenDonVi = donVi.TenDonVi;
                    db.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok(donVi);
        }

        public IHttpActionResult Delete([FromBody] DonVi donVi)
        {
            using (QLLuongContext db = new QLLuongContext())
            {
                DonVi dv = db.DonVis.Find(donVi.MaDonVi);
                if (dv != null)
                {
                    db.DonVis.Remove(dv);
                    db.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok();
        }
    }
}
