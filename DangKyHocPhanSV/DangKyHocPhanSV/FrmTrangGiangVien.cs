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
    public partial class FrmTrangGiangVien : Form
    {
        private string maso;
        DBLopHoc lh = new DBLopHoc();
        DBGiangVien gv = new DBGiangVien();
        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmTrangGiangVien()
        {
            InitializeComponent();
            gv.GiangVienConnect();
        }

        private void FrmTrangGiangVien_Load(object sender, EventArgs e)
        {
            this.txtTenGV.Text = gv.ThongTinGV(maso).Tables[0].Rows[0].Field<string>("HoTenGV");

            this.dgvDanhSach.DataSource = lh.ThoiKhoaBieuGV(maso).Tables[0];
            dgvDanhSach.Columns[0].HeaderText = "Thứ";
            dgvDanhSach.Columns[1].HeaderText = "Tiết Bắt Đầu";
            dgvDanhSach.Columns[2].HeaderText = "Tiết Kết Thúc";
            dgvDanhSach.Columns[3].HeaderText = "Tên Phòng";
            dgvDanhSach.Columns[4].HeaderText = "Tên Môn Học";

            dgvDanhSach.Columns[4].Width = 270;
        }

        private void btnDSLH_Click(object sender, EventArgs e)
        {
            FrmDanhSachLopHocGV ds = new FrmDanhSachLopHocGV();
            ds.MaSo = maso;
            ds.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMk_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhauGV dmk = new FrmDoiMatKhauGV();
            dmk.MaSo = maso;
            dmk.ShowDialog();
        }
    }
}
