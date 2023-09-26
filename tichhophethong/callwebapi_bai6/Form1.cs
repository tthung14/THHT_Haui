using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace callwebapi_bai6
{
    public partial class Form1 : Form
    {
        private List<NhanVien> employees;
        public Form1()
        {
            InitializeComponent();
        }

        // hien thi
        private void Form1_Load(object sender, EventArgs e)
        {
            //dgvDanhSach.AutoGenerateColumns = false;
            employees = HienThi();
            dgvDanhSach.DataSource = employees;
        }     
        private List<NhanVien> HienThi()
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44320/api/")
            };
            var response = client.GetAsync("nhanvien").Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<NhanVien>>().Result;
            }
            else
            {
                return null;
            }
        }

        // ket thuc
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        // tim
        private void btnTim_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = employees.FirstOrDefault(nv => nv.Ma == txtMa.Text);

            if (nhanVien != null)
            {
                // Hiển thị thông tin nhân viên tìm thấy
                txtHoTen.Text = nhanVien.HoTen;
                dtpNgaySinh.Value = nhanVien.NgaySinh;
                if (nhanVien.GioiTinh == "Nam")
                {
                    rbtNam.Checked = true;
                    rbtNu.Checked = false;
                }
                else
                {
                    rbtNam.Checked = false;
                    rbtNu.Checked = true;
                }
                txtHsLuong.Text = nhanVien.HsLuong.ToString();
                txtMaDonVi.Text = nhanVien.MaDonVi;
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien co ma " + txtMa.Text);
            }
        }

        // them
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Them(new NhanVien() { Ma =  txtMa.Text, HoTen = txtHoTen.Text, NgaySinh = dtpNgaySinh.Value, GioiTinh = rbtNam.Checked ? "Nam" : "Nữ", HsLuong = Convert.ToDouble(txtHsLuong.Text), MaDonVi = txtMaDonVi.Text}))
            {
                MessageBox.Show("Them thanh cong");
                dgvDanhSach.DataSource = HienThi();
            }
            else
                MessageBox.Show("Khong them duoc nhan vien");
        }
        private bool Them(NhanVien employee)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44320/api/")
            };
            var response = client.PostAsJsonAsync("nhanvien", employee).Result;
            return response.IsSuccessStatusCode;
        }

        // sua
        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = employees.FirstOrDefault(nv => nv.Ma == txtMa.Text);

            nhanVien.HoTen = txtHoTen.Text;
            nhanVien.NgaySinh = dtpNgaySinh.Value;
            nhanVien.GioiTinh = rbtNam.Checked ? "Nam" : "Nữ";
            nhanVien.HsLuong = Convert.ToDouble(txtHsLuong.Text);
            nhanVien.MaDonVi = txtMaDonVi.Text;
            if (Sua(nhanVien))
            {
                MessageBox.Show("Sua thanh cong");
                dgvDanhSach.DataSource = HienThi();
            }    
            else
                MessageBox.Show("Khong sua duoc nhan vien");
        }
        private bool Sua(NhanVien employee)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44320/api/")
            };
            var response = client.PutAsJsonAsync("nhanvien", employee).Result;
            return response.IsSuccessStatusCode;
        }

        // xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon xoa?", "Thong bao", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Xoa(txtMa.Text))
                {
                    MessageBox.Show("Xoa thanh cong");
                    dgvDanhSach.DataSource = HienThi();
                }
                else
                    MessageBox.Show("Khong xoa duoc nhan vien");
            }
        }
        private bool Xoa(string Ma)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44320/api/")
            };
            var response = client.DeleteAsync($"nhanvien?Ma={Ma}").Result;
            return response.IsSuccessStatusCode;
        }

        // clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rbtNam.Checked = false;
            rbtNu.Checked = false;
            txtHsLuong.Clear();
            txtMaDonVi.Clear();
        }

        //chon dong
        private void dgvDanhSach_SeletionChanged(object sender, EventArgs e)
        {
            var row = dgvDanhSach.CurrentRow;
            txtMa.Text = row.Cells["Ma"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            rbtNam.Checked = row.Cells["GioiTinh"].Value.ToString() == "Nam";
            rbtNu.Checked = !(row.Cells["GioiTinh"].Value.ToString() == "Nam");
            txtHsLuong.Text = row.Cells["HsLuong"].Value.ToString();
            txtMaDonVi.Text = row.Cells["MaDonVi"].Value.ToString();
        }
    }
}
