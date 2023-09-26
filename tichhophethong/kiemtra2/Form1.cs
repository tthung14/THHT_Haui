using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using training;

namespace kiemtra2
{
    public partial class Form1 : Form
    {
        private DataUtil dataUtil = new DataUtil();
        private List<NgayLamViec> ngayLamViec = new List<NgayLamViec>();
        public Form1()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dgvNgayLamViec.Rows.Clear();
            dgvNgayLamViec.Columns.Clear();

            dgvNgayLamViec.Columns.Add("ngay", "Ngày");
            dgvNgayLamViec.Columns.Add("maNV", "Mã NV");
            dgvNgayLamViec.Columns.Add("lyDo", "Lý Do");
            dgvNgayLamViec.Columns.Add("donVi", "Đơn Vị");
            dgvNgayLamViec.Columns.Add("trangThai", "Trạng Thái");

            ngayLamViec.Clear();
            ngayLamViec = dataUtil.Show();

            foreach (var ngay in ngayLamViec)
            {
                foreach (var nv in ngay.listNhanVien)
                {
                    dgvNgayLamViec.Rows.Add(ngay.ngay, nv.maNV, nv.lyDo, nv.donVi, nv.trangThai);
                }
            }
        }

        private void KiemTra_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNgayLamViec_SelectionChanged(object sender, EventArgs e)
        {
            var row = dgvNgayLamViec.CurrentRow;

            txtNgay.Text = row.Cells["ngay"].Value?.ToString();
            txtMaNV.Text = row.Cells["maNV"].Value?.ToString();
            txtLyDo.Text = row.Cells["lyDo"].Value?.ToString();
            txtDonVi.Text = row.Cells["donVi"].Value?.ToString();
            txtTrangThai.Text = row.Cells["trangThai"].Value?.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dataUtil.CheckWorkDay(txtNgay.Text))
            {
                MessageBox.Show("Ngày làm việc đã tồn tại");
            }
            else
            {
                NhanVien nv = new NhanVien
                {
                    maNV = txtMaNV.Text,
                    lyDo = txtLyDo.Text,
                    donVi = Convert.ToInt32(txtDonVi.Text),
                    trangThai = txtTrangThai.Text
                };

                NgayLamViec nlv = new NgayLamViec
                {
                    ngay = txtNgay.Text,
                    listNhanVien = new List<NhanVien> { nv }
                };
                dataUtil.Add(nlv);
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dataUtil.Edit(txtNgay.Text, txtMaNV.Text, txtLyDo.Text, Convert.ToDouble(txtDonVi.Text), txtTrangThai.Text);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa ngày này?", "Thông báo", MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Question) == DialogResult.OK)
            {
                dataUtil.Remove(txtNgay.Text);
                LoadData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextboxs();
        }
        private void ClearTextboxs()
        {
            txtNgay.Clear();
            txtMaNV.Clear();
            txtLyDo.Clear();
            txtDonVi.Clear();
            txtTrangThai.Clear();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNgayLamViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
