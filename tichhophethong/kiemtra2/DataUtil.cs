using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace training
{
    internal class DataUtil
    {
        XmlDocument doc;
        XmlElement root;
        string fileName;

        public DataUtil()
        {
            fileName = @"D:\tichhophethong\tichhophethong\kiemtra2\DangKyNghi.xml";
            doc = new XmlDocument();
            if (!File.Exists(fileName))
            {
                root = doc.CreateElement("DangKyNghi");
                doc.AppendChild(root);
                doc.Save(fileName);
            }
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public List<NgayLamViec> Show()
        {
            List<NgayLamViec> listNgayLamViec = new List<NgayLamViec>();

            XmlNodeList nodeList = root.SelectNodes("NgayLamViec");
            foreach (XmlNode node in nodeList)
            {
                NgayLamViec nlv = new NgayLamViec
                {
                    ngay = node.Attributes["Ngay"].InnerText,
                    listNhanVien = new List<NhanVien>()
                };

                XmlNodeList nodeList2 = node.SelectNodes("NhanVien");
                foreach (XmlNode node2 in nodeList2)
                {
                    NhanVien nv = new NhanVien
                    {
                        maNV = node2.Attributes["MaNV"].InnerText,
                        lyDo = node2.SelectSingleNode("LyDo").InnerText,
                        donVi = Convert.ToInt32(node2.SelectSingleNode("DonVi").InnerText),
                        trangThai = node2.SelectSingleNode("TrangThai").InnerText
                    };
                    nlv.listNhanVien.Add(nv);
                }
                listNgayLamViec.Add(nlv);
            }
            return listNgayLamViec;
        }

        public bool CheckWorkDay(string ngay)
        {
            return root.SelectSingleNode($"/DangKyNghi/NgayLamViec[Ngay='{ngay}']") != null;
        }
        public void Add(NgayLamViec nlv)
        {
            if (root.SelectSingleNode($"/DangKyNghi/NgayLamViec[@Ngay='{nlv.ngay}']") == null)
            {
                XmlElement ngayLamViec = doc.CreateElement("NgayLamViec");
                XmlAttribute ngay = doc.CreateAttribute("Ngay");
                ngay.InnerText = nlv.ngay;
                ngayLamViec.Attributes.Append(ngay);

                foreach (var nv in nlv.listNhanVien)
                {
                    XmlElement nhanVien = doc.CreateElement("NhanVien");
                    XmlAttribute maNV = doc.CreateAttribute("MaNV");
                    maNV.InnerText = nv.maNV;
                    nhanVien.Attributes.Append(maNV);

                    XmlElement lyDo = doc.CreateElement("LyDo");
                    lyDo.InnerText = nv.lyDo;
                    nhanVien.AppendChild(lyDo);

                    XmlElement donVi = doc.CreateElement("DonVi");
                    donVi.InnerText = nv.donVi.ToString();
                    nhanVien.AppendChild(donVi);

                    XmlElement trangThai = doc.CreateElement("TrangThai");
                    trangThai.InnerText = nv.trangThai;
                    nhanVien.AppendChild(trangThai);

                    ngayLamViec.AppendChild(nhanVien);
                }

                root.SelectSingleNode("/DangKyNghi").AppendChild(ngayLamViec);
                doc.Save(fileName);
            }
        }
        public void Edit(string ngay, string maNV, string lyDo, double donVi, string trangThai)
        {
            XmlNode node = root.SelectSingleNode($"/DangKyNghi/NgayLamViec[@Ngay='{ngay}']");
            if (node != null)
            {
                XmlNode node2 = node.SelectSingleNode($"NhanVien[@MaNV='{maNV}']");

                if (node2 != null)
                {
                    node2.SelectSingleNode("LyDo").InnerText = lyDo;
                    node2.SelectSingleNode("DonVi").InnerText = donVi.ToString();
                    node2.SelectSingleNode("TrangThai").InnerText = trangThai;

                    doc.Save(fileName);
                }
            }
        }
        public void Remove(string ngay)
        {
            XmlNode node = root.SelectSingleNode($"/DangKyNghi/NgayLamViec[@Ngay='{ngay}']");

            if (node != null)
            {
                root.RemoveChild(node);
                doc.Save(fileName);
            }
        }
        
    }
}
