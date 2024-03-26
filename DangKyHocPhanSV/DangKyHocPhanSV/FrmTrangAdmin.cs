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
    public partial class FrmTrangAdmin : Form
    {
        private string maso;
        DBSinhVien sv = new DBSinhVien();
        DBQuanLy ql = new DBQuanLy();

        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmTrangAdmin()
        {
            InitializeComponent();
        }

        private void FrmTrangAdmin_Load(object sender, EventArgs e)
        {
            this.txtTenQL.Text = ql.ThongTin(maso).Tables[0].Rows[0].Field<string>("TenNQL");
            this.dgvDSSinhVien.DataSource = sv.DSSinhVienDKMH().Tables[0];

            dgvDSSinhVien.Columns[0].HeaderText = "Mã Sinh Viên";
            dgvDSSinhVien.Columns[1].HeaderText = "Tên Sinh Viên";
            dgvDSSinhVien.Columns[2].HeaderText = "Tên Ngành";
            dgvDSSinhVien.Columns[3].HeaderText = "Tình trạng vi phạm";
            dgvDSSinhVien.Columns[0].Width = 150;
            dgvDSSinhVien.Columns[1].Width = 200;
            dgvDSSinhVien.Columns[2].Width = 200;
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            FrmQuanLySinhVien qlsv = new FrmQuanLySinhVien();
            qlsv.Show();
        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {
            FrmGiangVien gv = new FrmGiangVien();
            gv.Show();
        }

        private void btnQLKhoa_Click(object sender, EventArgs e)
        {
            FrmQuanLyKhoaNganh khng = new FrmQuanLyKhoaNganh();
            khng.Show();
        }

        private void btnQLPH_Click(object sender, EventArgs e)
        {
            FrmQuanLyPhongHoc ph = new FrmQuanLyPhongHoc();
            ph.Show();
        }

        private void btnQLMonHoc_Click(object sender, EventArgs e)
        {
            FrmQuanLyMonHoc mh = new FrmQuanLyMonHoc();
            mh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhauAdmin dmk = new FrmDoiMatKhauAdmin();
            dmk.MaSo = maso;
            dmk.ShowDialog();
        }
    }
}
