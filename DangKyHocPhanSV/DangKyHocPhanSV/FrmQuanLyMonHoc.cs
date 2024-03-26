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
    public partial class FrmQuanLyMonHoc : Form
    {
        DBMonHoc_DaoTao mhdt = new DBMonHoc_DaoTao();
        DBMonHoc mh = new DBMonHoc();
        DBNganh nganh = new DBNganh();
        DBChuongTrinhDT ctdt = new DBChuongTrinhDT();
        public FrmQuanLyMonHoc()
        {
            InitializeComponent();
        }
        
        public void loadMHDT()
        {
            dgvDanhSach.DataSource = mhdt.DSMHDT().Tables[0];
            dgvDanhSach.Columns[0].HeaderText = "Mã MHDT";
            dgvDanhSach.Columns[1].HeaderText = "Tên Môn Học";
            dgvDanhSach.Columns[2].HeaderText = "Số tín chỉ";
            dgvDanhSach.Columns[3].HeaderText = "Tên Chương Trình Đào Tạo";
            dgvDanhSach.Columns[4].HeaderText = "Ngôn Ngữ Đào Tạo";
            dgvDanhSach.Columns[5].HeaderText = "Tên Ngành";

            dgvDanhSach.Columns[0].Width = 100;
            dgvDanhSach.Columns[1].Width = 200;
            dgvDanhSach.Columns[5].Width = 200;

        }

        public void loadMonHoc()
        {
            dgvDanhSach.DataSource = mh.DSMonHoc().Tables[0];
            dgvDanhSach.Columns[0].HeaderText = "Mã Môn Học";
            dgvDanhSach.Columns[1].HeaderText = "Tên Môn Học";
            dgvDanhSach.Columns[2].HeaderText = "Số tín chỉ";
        }

        public void loadcbbMonHoc()
        {
            cbbMonHoc.DataSource = mh.DSMonHoc().Tables[0];
            cbbMonHoc.DisplayMember = "TenMH";
            cbbMonHoc.ValueMember = "MaMH";
        }

        public void loadcbbNganh()
        {
            cbbNganh.DataSource = nganh.DanhSachNganh().Tables[0];
            cbbNganh.DisplayMember = "TenNganh";
            cbbNganh.ValueMember = "MaNganh";
        }

        public void loadcbbCTDT()
        {
            cbbCTDT.DataSource = ctdt.DanhSachCTDT().Tables[0];
            cbbCTDT.DisplayMember = "MaCTDT";
            cbbCTDT.ValueMember = "MaCTDT";
        }

        private void FrmQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            loadMHDT();
            loadcbbMonHoc();
            loadcbbNganh();
            loadcbbCTDT();

        }

        private void btnTimMH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaMonHoc.Text == "")
                {
                    loadMonHoc();
                }
                else
                {
                    dgvDanhSach.DataSource = mh.TimKiemMH(txtMaMonHoc.Text).Tables[0];
                    dgvDanhSach.Columns[0].HeaderText = "Mã Môn Học";
                    dgvDanhSach.Columns[1].HeaderText = "Tên Môn Học";
                    dgvDanhSach.Columns[2].HeaderText = "Số tín chỉ";
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimMHDT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaMHDT.Text == "")
                {
                    loadMHDT();
                }
                else
                {
                    dgvDanhSach.DataSource = mhdt.TimKiemMHDT(txtMaMHDT.Text).Tables[0];
                    dgvDanhSach.Columns[0].HeaderText = "Mã MHDT";
                    dgvDanhSach.Columns[1].HeaderText = "Tên Môn Học";
                    dgvDanhSach.Columns[2].HeaderText = "Số tín chỉ";
                    dgvDanhSach.Columns[3].HeaderText = "Tên Chương Trình Đào Tạo";
                    dgvDanhSach.Columns[4].HeaderText = "Ngôn Ngữ Đào Tạo";
                    dgvDanhSach.Columns[5].HeaderText = "Tên Ngành";

                    dgvDanhSach.Columns[0].Width = 100;
                    dgvDanhSach.Columns[1].Width = 200;
                    dgvDanhSach.Columns[5].Width = 200;
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = mh.ThemMonHoc(ref err, txtNhapMaMH.Text, txtNhapTenMH.Text, int.Parse(txtNhapTinChi.Text));
                if (kq)
                {
                    loadMonHoc();
                    MessageBox.Show("Đã thêm thành công!");
                }
                else
                {
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = mh.XoaMonHoc(ref err, txtMaMonHoc.Text);
                if (kq)
                {
                    loadMonHoc();
                    MessageBox.Show("Đã xóa thành công!");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMHDT_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = mhdt.ThemMHDT(ref err, txtNhapMaMHDT.Text, cbbMonHoc.SelectedValue.ToString(), cbbCTDT.SelectedValue.ToString(), cbbNganh.SelectedValue.ToString());
                if (kq)
                {
                    loadMHDT();
                    MessageBox.Show("Đã thêm thành công!");
                }
                else
                {
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaMHDT_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = mhdt.XoaMHDT(ref err, txtMaMHDT.Text);
                if (kq)
                {
                    loadMHDT();
                    MessageBox.Show("Đã xóa thành công!");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
