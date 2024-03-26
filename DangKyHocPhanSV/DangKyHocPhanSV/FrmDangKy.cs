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
    public partial class FrmDangKy : Form
    {
        private string maso;
        private string mamh;
        DBSinhVien sv = new DBSinhVien();
        DBLopHoc lh = new DBLopHoc();
        DBDangKy dk = new DBDangKy();

        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }

        public string Mamh {
            get { return mamh; }
            set { mamh = value; }
        }
        public FrmDangKy()
        {
            InitializeComponent();
            sv.SinhVienConnect();
            lh.SinhVienConnect();
            dk.SinhVienConnect();
        }

        public void loadLopHoc()
        {
            this.dgvShow.DataSource = lh.DanhSachLH(mamh, maso).Tables[0];
            dgvShow.Columns[0].HeaderText = "Mã Lớp Học";
            dgvShow.Columns[1].HeaderText = "Tên Giảng Viên";
            dgvShow.Columns[2].HeaderText = "Giới Hạn";
            dgvShow.Columns[3].HeaderText = "Tên Phòng";
            dgvShow.Columns[4].HeaderText = "Thứ";
            dgvShow.Columns[5].HeaderText = "Tiết Bắt Đầu";
            dgvShow.Columns[6].HeaderText = "Tiết Kết Thúc";
            dgvShow.Columns[7].HeaderText = "Thời Gian Bắt Đầu";
            dgvShow.Columns[8].HeaderText = "Thời gian Kết Thúc";

            dgvShow.Columns[1].Width = 150;
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            loadLopHoc();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            int index = dgvShow.CurrentCell.RowIndex;
            string malh = dgvShow.Rows[index].Cells[0].Value.ToString();
            bool kq = false;
            string err = "";
            try
            {
                kq = dk.DangKyLH(ref err, malh, maso);
                if (kq)
                {
                    MessageBox.Show("Đã đăng ký thành công!");
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
