using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace bai4
{
    internal class DataUtil
    {
        XmlDocument doc;
        XmlElement root;
        string fileName;

        public DataUtil()
        {
            fileName = @"D:\tichhophethong\tichhophethong\bai4\CongTy.xml";
            doc = new XmlDocument();
            if (!File.Exists(fileName))
            {
                root = doc.CreateElement("congty");
                doc.AppendChild(root);
                doc.Save(fileName);
            }
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public List<NhanVien> Show()
        {
            List<NhanVien> nhanVien = new List<NhanVien>();
            XmlNodeList nodeList = root.SelectNodes("nhanvien");
            foreach (XmlNode node in nodeList)
            {
                NhanVien nv = new NhanVien
                {
                    maNV = node.Attributes["manv"].InnerText,
                    hoTen = node.SelectSingleNode("hoten").InnerText,
                    tuoi = Convert.ToInt32(node.SelectSingleNode("tuoi").InnerText),
                    luong = Convert.ToInt32(node.SelectSingleNode("luong").InnerText),
                    xa = node.SelectSingleNode("diachi/xa").InnerText,
                    huyen = node.SelectSingleNode("diachi/huyen").InnerText,
                    tinh = node.SelectSingleNode("diachi/tinh").InnerText,
                    dienThoai = node.SelectSingleNode("dienthoai").InnerText
                };
                nhanVien.Add(nv);
            }
            return nhanVien;
        }
        public bool CheckMaNV(string maNV)
        {
            return root.SelectSingleNode($"/congty/nhanvien[@manv='{maNV}']") != null;
        }
        public void Add(NhanVien nv)
        {
            if (root.SelectSingleNode($"/congty/nhanvien[@manv='{nv.maNV}']") == null)
            {
                XmlElement nhanVien = doc.CreateElement("nhanvien");
                XmlAttribute maNV = doc.CreateAttribute("manv");
                XmlElement hoTen = doc.CreateElement("hoten");
                XmlElement tuoi = doc.CreateElement("tuoi");
                XmlElement luong = doc.CreateElement("luong");
                XmlElement diaChi = doc.CreateElement("diachi");
                XmlElement xa = doc.CreateElement("xa");
                XmlElement huyen = doc.CreateElement("huyen");
                XmlElement tinh = doc.CreateElement("tinh");
                XmlElement dienThoai = doc.CreateElement("dienthoai");

                maNV.InnerText = nv.maNV;
                hoTen.InnerText = nv.hoTen;
                tuoi.InnerText = nv.tuoi.ToString();
                luong.InnerText = nv.luong.ToString();
                xa.InnerText = nv.xa;
                huyen.InnerText = nv.huyen;
                tinh.InnerText = nv.tinh;
                dienThoai.InnerText = nv.dienThoai;

                nhanVien.Attributes.Append(maNV);
                nhanVien.AppendChild(hoTen);
                nhanVien.AppendChild(tuoi);
                nhanVien.AppendChild(luong);
                nhanVien.AppendChild(diaChi);
                diaChi.AppendChild(xa);
                diaChi.AppendChild(huyen);
                diaChi.AppendChild(tinh);
                nhanVien.AppendChild(dienThoai);
                root.AppendChild(nhanVien);
                doc.Save(fileName);
            }
        }
        public void Edit(NhanVien nv)
        {
            XmlNode node = root.SelectSingleNode($"/congty/nhanvien[@manv='{nv.maNV}']");
            if (node != null)
            {
                node.SelectSingleNode("hoten").InnerText = nv.hoTen;
                node.SelectSingleNode("tuoi").InnerText = nv.tuoi.ToString();
                node.SelectSingleNode("luong").InnerText = nv.luong.ToString();
                node.SelectSingleNode("diachi/xa").InnerText = nv.xa;
                node.SelectSingleNode("diachi/huyen").InnerText = nv.huyen;
                node.SelectSingleNode("diachi/tinh").InnerText = nv.tinh;
                node.SelectSingleNode("dienthoai").InnerText = nv.dienThoai;

                doc.Save(fileName);
            }
        }

        public void Delete(string maNV)
        {
            XmlNode node = root.SelectSingleNode($"/congty/nhanvien[@manv='{maNV}']");
            if (node != null)
            {
                root.RemoveChild(node);

                doc.Save(fileName);
            }
        }

        public void Find()
        {
            XmlNodeList nodeList = root.SelectNodes($"/congty/nhanvien[luong>1000]");
            int salary = 0;
            foreach (XmlNode node in nodeList)
            {
                salary += Convert.ToInt32(node.SelectSingleNode("luong").InnerText);
            }
            MessageBox.Show(nodeList.Count.ToString() + " " + salary.ToString());
        }

        public List<NhanVien> Find(string diaChi)
        {
            List<NhanVien> nhanVien = new List<NhanVien>();
            XmlNodeList nodeList = root.SelectNodes($"/congty/nhanvien[diachi/tinh='{diaChi}']");
            
            foreach (XmlNode node in nodeList)
            {
                NhanVien nv = new NhanVien
                {
                    maNV = node.Attributes["manv"].InnerText,
                    hoTen = node.SelectSingleNode("hoten").InnerText,
                    tuoi = Convert.ToInt32(node.SelectSingleNode("tuoi").InnerText),
                    luong = Convert.ToInt32(node.SelectSingleNode("luong").InnerText),
                    xa = node.SelectSingleNode("diachi/xa").InnerText,
                    huyen = node.SelectSingleNode("diachi/huyen").InnerText,
                    tinh = node.SelectSingleNode("diachi/tinh").InnerText,
                    dienThoai = node.SelectSingleNode("dienthoai").InnerText
                };
                nhanVien.Add(nv);
            }      
            return nhanVien;
        }
    }
}
