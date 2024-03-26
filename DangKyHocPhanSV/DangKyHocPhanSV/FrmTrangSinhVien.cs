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
    public partial class FrmTrangSinhVien : Form
    {
        private string maso;
        DBSinhVien sv = new DBSinhVien();
        

        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmTrangSinhVien()
        {
            InitializeComponent();
        }
        private void FrmTrangSinhVien_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        void LoadThongTin()
        {
            this.txtTenSV.Text = sv.ThongTin(maso).Tables[0].Rows[0].Field<string>("HoTenSV");
            this.txtMssv.Text = sv.ThongTin(maso).Tables[0].Rows[0].Field<string>("MaSV");
            this.dgvShow.DataSource = sv.HocPhanCTDTSV(maso).Tables[0];

            dgvShow.Columns[0].HeaderText = "Mã Môn Học";
            dgvShow.Columns[1].HeaderText = "Tên Môn Học";
            dgvShow.Columns[2].HeaderText = "Số Tín Chỉ";

            dgvShow.Columns[0].Width = 170;
            dgvShow.Columns[1].Width = 400;
            dgvShow.Columns[2].Width = 100;
        }

        private void btnDangKyKh_Click(object sender, EventArgs e)
        {
               
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            FrmTraCuuMonHoc tcmh = new FrmTraCuuMonHoc();
            tcmh.Show();
        }

        private void btnTKB_Click(object sender, EventArgs e)
        {
            FrmThoiKhoaBieuSV tkb = new FrmThoiKhoaBieuSV();
            tkb.MaSo = maso;
            tkb.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKyMonHoc dk = new FrmDangKyMonHoc();
            dk.MaSo = maso;
            dk.Show();
        }

        private void btnDoiMk_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhauSV dmk = new FrmDoiMatKhauSV();
            dmk.MaSo = maso;
            dmk.ShowDialog();
        }
    }
}
