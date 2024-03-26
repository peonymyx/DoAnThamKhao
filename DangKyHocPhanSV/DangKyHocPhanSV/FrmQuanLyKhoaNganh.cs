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
    public partial class FrmQuanLyKhoaNganh : Form
    {
        DBKhoa khoa = new DBKhoa();
        DBNganh nganh = new DBNganh();
        
        public FrmQuanLyKhoaNganh()
        {
            InitializeComponent();
        }
        public void loadDSKhoa()
        {
            cbbKhoa.DataSource = khoa.DanhSachKhoa().Tables[0];
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";
        }
        public void loadDSNganh()
        {
            dgvDanhSach.DataSource = nganh.DanhSachNganh().Tables[0];
            dgvDanhSach.Columns[0].HeaderText = "Mã Ngành";
            dgvDanhSach.Columns[1].HeaderText = "Tên Ngành";
            dgvDanhSach.Columns[2].HeaderText = "Tên Khoa";

        }

        public void showDSKhoa()
        {
            dgvDanhSach.DataSource = khoa.DanhSachKhoa().Tables[0];
            dgvDanhSach.Columns[0].HeaderText = "Mã Khoa";
            dgvDanhSach.Columns[1].HeaderText = "Tên Khoa";
        }
        private void FrmQuanLyKhoaNganh_Load(object sender, EventArgs e)
        {
            loadDSKhoa();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKhoa.Text == "")
                {
                    showDSKhoa();
                }
                else
                {
                    dgvDanhSach.DataSource = khoa.TimKiemKhoa(txtMaKhoa.Text).Tables[0];
                    dgvDanhSach.Columns[0].HeaderText = "Mã Khoa";
                    dgvDanhSach.Columns[1].HeaderText = "Tên Khoa";
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnTimNganh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNganh.Text == "")
                {
                    loadDSNganh();
                }
                else
                {
                    dgvDanhSach.DataSource = nganh.TimKiemNganh(txtMaNganh.Text).Tables[0];
                    dgvDanhSach.Columns[0].HeaderText = "Mã Ngành";
                    dgvDanhSach.Columns[1].HeaderText = "Tên Ngành";
                    dgvDanhSach.Columns[2].HeaderText = "Tên Khoa";

                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemNganh_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = nganh.ThemNganh(ref err, txtNhapMaNganh.Text, txtNhaptenNganh.Text, cbbKhoa.SelectedValue.ToString());
                if (kq)
                {
                    loadDSNganh();
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

        private void btnXoaNganh_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = nganh.XoaNganh(ref err, txtMaNganh.Text);
                if (kq)
                {
                    loadDSNganh();
                    MessageBox.Show("Đã xóa thành công!");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = khoa.ThemKhoa(ref err, txtNhapMaKhoa.Text, txtNhapTenKhoa.Text);
                if (kq)
                {
                    showDSKhoa();
                    loadDSKhoa();
                    MessageBox.Show("Đã thêm thành công!");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = khoa.XoaKhoa(ref err, txtMaKhoa.Text);
                if (kq)
                {
                    showDSKhoa();
                    loadDSKhoa();
                    MessageBox.Show("Đã xóa thành công!");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
