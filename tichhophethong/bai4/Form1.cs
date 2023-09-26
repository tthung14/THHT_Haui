using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        private DataUtil data = new DataUtil();
        private List<NhanVien> nhanvien = new List<NhanVien>();

        public Form1()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            nhanvien.Clear();
            nhanvien = data.Show();
            dgvNhanVien.DataSource = nhanvien;
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            var row = dgvNhanVien.CurrentRow;

            txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
            txtTuoi.Text = row.Cells["Tuoi"].Value?.ToString();
            txtLuong.Text = row.Cells["Luong"].Value?.ToString();
            txtXa.Text = row.Cells["Xa"].Value?.ToString();
            txtHuyen.Text = row.Cells["Huyen"].Value?.ToString();
            txtTinh.Text = row.Cells["Tinh"].Value?.ToString();
            txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (data.CheckMaNV(txtMaNV.Text))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
            }
            else
            {
                data.Add(new NhanVien() { maNV = txtMaNV.Text, hoTen = txtHoTen.Text, tuoi = Convert.ToInt32(txtTuoi.Text), luong = Convert.ToInt32(txtLuong.Text), xa = txtXa.Text, huyen = txtHuyen.Text, tinh = txtTinh.Text, dienThoai = txtDienThoai.Text });
                LoadData();
            }  
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            data.Edit(new NhanVien() { maNV = txtMaNV.Text, hoTen = txtHoTen.Text, tuoi = Convert.ToInt32(txtTuoi.Text), luong = Convert.ToInt32(txtLuong.Text), xa = txtXa.Text, huyen = txtHuyen.Text, tinh = txtTinh.Text, dienThoai = txtDienThoai.Text });
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                data.Delete(txtMaNV.Text);
                LoadData();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = data.Find(txtTinh.Text);
        }
        private void btnTimKiemTongLuong_Click(object sender, EventArgs e)
        {
            data.Find();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextboxs();
        }
        private void ClearTextboxs()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtTuoi.Clear();
            txtLuong.Clear();
            txtXa.Clear();
            txtHuyen.Clear();
            txtTinh.Clear();
            txtDienThoai.Clear();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
