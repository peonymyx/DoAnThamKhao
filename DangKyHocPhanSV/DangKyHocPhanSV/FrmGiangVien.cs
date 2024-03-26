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
using System.Data.SqlClient;

namespace DangKyHocPhanSV
{
    public partial class FrmGiangVien : Form
    {
        DBKhoa khoa = new DBKhoa();
        DBGiangVien gv = new DBGiangVien();

        public FrmGiangVien()
        {
            InitializeComponent();
        }

        public void loadGiangVien()
        {
            dgvThongTinGV.DataSource =  gv.DSGiangVien().Tables[0];
            dgvThongTinGV.Columns[0].HeaderText = "Mã giảng viên";
            dgvThongTinGV.Columns[1].HeaderText = "Họ và tên giảng viên";
            dgvThongTinGV.Columns[2].HeaderText = "Khoa";

            dgvThongTinGV.Columns[0].Width = 50;
            dgvThongTinGV.Columns[1].Width = 70;
            dgvThongTinGV.Columns[2].Width = 250;
        }

        public void loadDSKhoa()
        {
            cbbKhoa.DataSource = khoa.DanhSachKhoa().Tables[0];
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";
        }
        private void FrmGiangVien_Load(object sender, EventArgs e)
        {
            loadGiangVien();
            loadDSKhoa();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvThongTinGV.DataSource = gv.ThongTinGV(txtMaGV.Text).Tables[0];
            dgvThongTinGV.Columns[0].HeaderText = "Mã giảng viên";
            dgvThongTinGV.Columns[1].HeaderText = "Họ và tên giảng viên";
            dgvThongTinGV.Columns[2].HeaderText = "Khoa";

            dgvThongTinGV.Columns[0].Width = 50;
            dgvThongTinGV.Columns[1].Width = 70;
            dgvThongTinGV.Columns[2].Width = 250;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = gv.ThemGV(ref err, txtNhapMaGV.Text, txtNhapMk.Text, txtNhapHoTen.Text, cbbKhoa.SelectedValue.ToString());
                if (kq)
                {
                    loadGiangVien();
                    MessageBox.Show("Đã thêm thành công!");
                }

            }
            catch (SqlException)
            {
                err = "Không thể thêm!";
                MessageBox.Show(err);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = gv.XoaGV(ref err, txtMaGV.Text);
                if (kq)
                {
                    loadGiangVien();
                    MessageBox.Show("Đã xóa thành công!");
                }

            }
            catch (SqlException)
            {
                err = "Không thể xóa!";
                MessageBox.Show(err);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
