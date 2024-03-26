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
    public partial class FrmDanhSachLopHocGV : Form
    {
        private string maso;
        DBLopHoc lh = new DBLopHoc();
        DBGiangVien gv = new DBGiangVien();
        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmDanhSachLopHocGV()
        {
            InitializeComponent();
            lh.GiangVienConnect();
            gv.GiangVienConnect();
        }

        public void loadChiTiet()
        {
            dgvSinhVienLH.DataSource = lh.ChiTietLopHocGV(maso).Tables[0];
            dgvSinhVienLH.Columns[0].HeaderText = "Mã Lớp Học";
            dgvSinhVienLH.Columns[1].HeaderText = "Tên Môn Học";
            dgvSinhVienLH.Columns[2].HeaderText = "Tên Phòng";
            dgvSinhVienLH.Columns[3].HeaderText = "Thứ";
            dgvSinhVienLH.Columns[4].HeaderText = "Tiết Bắt Đầu";
            dgvSinhVienLH.Columns[5].HeaderText = "Tiết Kết Thúc";
            dgvSinhVienLH.Columns[6].HeaderText = "Số Lượng Sinh Viên";

            dgvSinhVienLH.Columns[1].Width = 150;
            dgvSinhVienLH.Columns[6].Width = 150;

        }

        private void btnTimKiemLH_Click(object sender, EventArgs e)
        {
            txtSVLH.Text = lh.TongSVLopHoc(txtMaLH.Text).ToString();

            dgvSinhVienLH.DataSource = lh.DanhSachSVLH(txtMaLH.Text).Tables[0];
            dgvSinhVienLH.Columns[0].HeaderText = "Mã Sinh Viên";
            dgvSinhVienLH.Columns[1].HeaderText = "Họ và tên Sinh Viên";
            dgvSinhVienLH.Columns[2].HeaderText = "Giới Tính";
            dgvSinhVienLH.Columns[3].HeaderText = "Ngày Sinh";
            dgvSinhVienLH.Columns[4].HeaderText = "Mã Lớp";

            dgvSinhVienLH.Columns[1].Width = 150;
        }

        private void FrmDanhSachLopHocGV_Load(object sender, EventArgs e)
        {
            loadChiTiet();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
