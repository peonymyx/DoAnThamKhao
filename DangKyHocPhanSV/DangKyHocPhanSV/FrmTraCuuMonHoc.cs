using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BusinessLogicLayer;
using System.Data.SqlClient;

namespace DangKyHocPhanSV
{
    public partial class FrmTraCuuMonHoc : Form
    {
        DBLopHoc lh = new DBLopHoc();
        public FrmTraCuuMonHoc()
        {
            InitializeComponent();
            lh.SinhVienConnect();
        }

        public void loadDSLopHoc()
        {
            this.dgvDanhSachLopHoc.DataSource = lh.TimKiemLopHocTheoMH(txtMonhoc.Text).Tables[0];
            dgvDanhSachLopHoc.Columns[0].HeaderText = "Mã Lớp Học";
            dgvDanhSachLopHoc.Columns[1].HeaderText = "Tên Giảng Viên";
            dgvDanhSachLopHoc.Columns[2].HeaderText = "Giới Hạn";
            dgvDanhSachLopHoc.Columns[3].HeaderText = "Tên Phòng";
            dgvDanhSachLopHoc.Columns[4].HeaderText = "Thứ";
            dgvDanhSachLopHoc.Columns[5].HeaderText = "Tiết Bắt Đầu";
            dgvDanhSachLopHoc.Columns[6].HeaderText = "Tiết Kết Thúc";
            dgvDanhSachLopHoc.Columns[7].HeaderText = "Thời Gian Bắt Đầu";
            dgvDanhSachLopHoc.Columns[8].HeaderText = "Thời gian Kết Thúc";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.dgvDanhSachLopHoc.DataSource = lh.TimKiemLopHocTheoMH(txtMonhoc.Text).Tables[0];
            dgvDanhSachLopHoc.Columns[0].HeaderText = "Mã Lớp Học";
            dgvDanhSachLopHoc.Columns[1].HeaderText = "Tên Giảng Viên";
            dgvDanhSachLopHoc.Columns[2].HeaderText = "Giới Hạn";
            dgvDanhSachLopHoc.Columns[3].HeaderText = "Tên Phòng";
            dgvDanhSachLopHoc.Columns[4].HeaderText = "Thứ";
            dgvDanhSachLopHoc.Columns[5].HeaderText = "Tiết Bắt Đầu";
            dgvDanhSachLopHoc.Columns[6].HeaderText = "Tiết Kết Thúc";
            dgvDanhSachLopHoc.Columns[7].HeaderText = "Thời Gian Bắt Đầu";
            dgvDanhSachLopHoc.Columns[8].HeaderText = "Thời gian Kết Thúc";

            dgvDanhSachLopHoc.Columns[1].Width = 150;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTraCuuMonHoc_Load(object sender, EventArgs e)
        {

        }
    }
}
