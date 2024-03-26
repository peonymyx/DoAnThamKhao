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
    public partial class FrmQuanLyPhongHoc : Form
    {
        DBLopHoc lh = new DBLopHoc();
        public FrmQuanLyPhongHoc()
        {
            InitializeComponent();
        }

        public void loadDSLopHoc()
        {
            dgvLopHoc.DataSource = lh.DSLopHoc().Tables[0];
            dgvLopHoc.Columns[0].HeaderText = "Mã lớp học";
            dgvLopHoc.Columns[1].HeaderText = "Mã MHDT";
            dgvLopHoc.Columns[2].HeaderText = "Mã giảng viên";
            dgvLopHoc.Columns[3].HeaderText = "Giới Hạn";
            dgvLopHoc.Columns[4].HeaderText = "Tên Phòng";
            dgvLopHoc.Columns[5].HeaderText = "Thứ";
            dgvLopHoc.Columns[6].HeaderText = "Tiết Bắt Đầu";
            dgvLopHoc.Columns[7].HeaderText = "Tiết Kết Thúc";
            dgvLopHoc.Columns[8].HeaderText = "Thời Gian Bắt Đầu";
            dgvLopHoc.Columns[9].HeaderText = "Thời gian Kết Thúc";
            dgvLopHoc.Columns[10].HeaderText = "Học kỳ";
            dgvLopHoc.Columns[11].HeaderText = "Năm";
        }

        private void FrmQuanLyPhongHoc_Load(object sender, EventArgs e)
        {
            loadDSLopHoc();
        }

        private void btnTimLopHoc_Click(object sender, EventArgs e)
        {
            
            try
            {
                dgvLopHoc.DataSource = lh.TimLopHoc(txtMaLopHoc.Text).Tables[0];
                dgvLopHoc.Columns[0].HeaderText = "Mã lớp học";
                dgvLopHoc.Columns[1].HeaderText = "Mã MHDT";
                dgvLopHoc.Columns[2].HeaderText = "Mã giảng viên";
                dgvLopHoc.Columns[3].HeaderText = "Giới Hạn";
                dgvLopHoc.Columns[4].HeaderText = "Tên Phòng";
                dgvLopHoc.Columns[5].HeaderText = "Thứ";
                dgvLopHoc.Columns[6].HeaderText = "Tiết Bắt Đầu";
                dgvLopHoc.Columns[7].HeaderText = "Tiết Kết Thúc";
                dgvLopHoc.Columns[8].HeaderText = "Thời Gian Bắt Đầu";
                dgvLopHoc.Columns[9].HeaderText = "Thời gian Kết Thúc";
                dgvLopHoc.Columns[10].HeaderText = "Học kỳ";
                dgvLopHoc.Columns[11].HeaderText = "Năm";
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemLopHoc_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {
                kq = lh.ThemLopHoc(ref err, txtNhapMaLopHoc.Text, txtMaMHDT.Text, txtMaGV.Text, int.Parse(txtGioiHan.Text), txtPhong.Text,
                    txtThu.Text, int.Parse(txtTietBatDau.Text), int.Parse(txtTietKetThuc.Text), Convert.ToDateTime(txtTGBD.Text).ToString("yyyy-MM-dd"),
                    Convert.ToDateTime(txtTGKT.Text).ToString("yyyy-MM-dd"), txtHocKy.Text, int.Parse(txtNam.Text));
                if (kq)
                {
                    txtNhapMaLopHoc.Clear();
                    txtMaMHDT.Clear();
                    txtMaGV.Clear();
                    txtGioiHan.Clear();
                    txtPhong.Clear();
                    txtThu.Clear();
                    txtTietBatDau.Clear();
                    txtTietKetThuc.Clear();
                    txtTGBD.Clear();
                    txtTGKT.Clear();
                    txtHocKy.Clear();
                    txtNam.Clear();

                    loadDSLopHoc();
                    MessageBox.Show("Đã thêm thành công!");
                }
                else
                {
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                kq = lh.XoaLopHoc(ref err, txtMaLopHoc.Text);
                if (kq)
                {
                    loadDSLopHoc();
                    MessageBox.Show("Đã xóa thành công!");
                }
                else
                {
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (SqlException)
            {
                err = "Không thể thêm!";
                MessageBox.Show(err);
            }
        }
    }
}
