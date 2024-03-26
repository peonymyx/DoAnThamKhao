using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace DangKyHocPhanSV
{
    public partial class FrmQuanLySinhVien : Form
    {
        DBKhoa khoa = new DBKhoa();
        DBNganh nganh = new DBNganh();
        public FrmQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void btnTimKiemKhoa_Click(object sender, EventArgs e)
        {
            txtMaNganh.Clear();
            int n = khoa.TongSVKhoa(txtMaKhoa.Text);
            txtSVKhoa.Text = n.ToString();

            dgvSinhVienKhoa.DataSource = khoa.DanhSachSVKhoa(txtMaKhoa.Text).Tables[0];
            dgvSinhVienKhoa.Columns[0].HeaderText = "Mã số sinh viên";
            dgvSinhVienKhoa.Columns[1].HeaderText = "Họ và tên";
            dgvSinhVienKhoa.Columns[2].HeaderText = "Giới tính";
            dgvSinhVienKhoa.Columns[3].HeaderText = "Ngày Sinh";
            dgvSinhVienKhoa.Columns[4].HeaderText = "Mã Lớp";
            dgvSinhVienKhoa.Columns[5].HeaderText = "Tình trạng vi phạm";

            dgvSinhVienKhoa.Columns[0].Width = 150;
            dgvSinhVienKhoa.Columns[1].Width = 200;
            dgvSinhVienKhoa.Columns[2].Width = 100;
            dgvSinhVienKhoa.Columns[3].Width = 100;
            dgvSinhVienKhoa.Columns[4].Width = 100;
        }

        private void btnTimKiemNganh_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Clear();
            int n = nganh.TongSVNganh(txtMaNganh.Text);
            txtSVKhoa.Text = n.ToString();

            dgvSinhVienKhoa.DataSource = nganh.DanhSachSVNganh(txtMaNganh.Text).Tables[0];
            dgvSinhVienKhoa.Columns[0].HeaderText = "Mã số sinh viên";
            dgvSinhVienKhoa.Columns[1].HeaderText = "Họ và tên";
            dgvSinhVienKhoa.Columns[2].HeaderText = "Giới tính";
            dgvSinhVienKhoa.Columns[3].HeaderText = "Ngày Sinh";
            dgvSinhVienKhoa.Columns[4].HeaderText = "Mã Lớp";
            dgvSinhVienKhoa.Columns[5].HeaderText = "Tình trạng vi phạm";

            dgvSinhVienKhoa.Columns[0].Width = 150;
            dgvSinhVienKhoa.Columns[1].Width = 200;
            dgvSinhVienKhoa.Columns[2].Width = 100;
            dgvSinhVienKhoa.Columns[3].Width = 100;
            dgvSinhVienKhoa.Columns[4].Width = 100;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            FrmLopSV lopsv = new FrmLopSV();
            lopsv.Show();
        }

        private void FrmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            txtSVKhoa.Enabled = false;
        }
    }
}
