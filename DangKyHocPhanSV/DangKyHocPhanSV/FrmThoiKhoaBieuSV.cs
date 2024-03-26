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
    public partial class FrmThoiKhoaBieuSV : Form
    {
        private string maso;
        DBLopHoc lh = new DBLopHoc();
        DBDangKy dk = new DBDangKy();
        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmThoiKhoaBieuSV()
        {
            InitializeComponent();
            lh.SinhVienConnect();
        }

        public void loadTKB()
        {
            this.dgvDanhSach.DataSource = lh.ThoiKhoaBieuSV(maso).Tables[0];
            dgvDanhSach.Columns[0].HeaderText = "Mã lớp học";
            dgvDanhSach.Columns[1].HeaderText = "Thứ";
            dgvDanhSach.Columns[2].HeaderText = "Tiết Bắt Đầu";
            dgvDanhSach.Columns[3].HeaderText = "Tiết Kết Thúc";
            dgvDanhSach.Columns[4].HeaderText = "Tên Phòng";
            dgvDanhSach.Columns[5].HeaderText = "Tên Môn Học";
            dgvDanhSach.Columns[6].HeaderText = "Tên Giảng Viên";

            dgvDanhSach.Columns[4].Width = 150;
            dgvDanhSach.Columns[5].Width = 150;
        }

        private void FrmThoiKhoaBieuSV_Load(object sender, EventArgs e)
        {
            loadTKB();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaDangKyLH_Click(object sender, EventArgs e)
        {
            int index = dgvDanhSach.CurrentCell.RowIndex;
            string malh = dgvDanhSach.Rows[index].Cells[0].Value.ToString();
            bool kq = false;
            string err = "";
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa lớp {malh}?", "Xóa lớp học", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    kq = dk.XoaDangKyLH(ref err, malh, maso);
                    if (kq)
                    {
                        MessageBox.Show("Đã xóa đăng ký thành công!");
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
        }
    }
}
