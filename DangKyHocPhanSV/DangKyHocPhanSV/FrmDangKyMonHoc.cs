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
    public partial class FrmDangKyMonHoc : Form
    {
        private string maso;
        DBSinhVien sv = new DBSinhVien();

        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }
        public FrmDangKyMonHoc()
        {
            InitializeComponent();
            sv.SinhVienConnect();
        }

        public void loadHocPhan()
        {
            this.dgvShow.DataSource = sv.HocPhanCTDTSV(maso).Tables[0];

            dgvShow.Columns[0].HeaderText = "Mã Môn Học";
            dgvShow.Columns[1].HeaderText = "Tên Môn Học";
            dgvShow.Columns[2].HeaderText = "Số Tín Chỉ";

            dgvShow.Columns[0].Width = 200;
            dgvShow.Columns[1].Width = 400;
            dgvShow.Columns[2].Width = 200;
        }

        private void FrmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            loadHocPhan();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int index = dgvShow.CurrentCell.RowIndex;
            string mamh = dgvShow.Rows[index].Cells[0].Value.ToString();
            FrmDangKy dk = new FrmDangKy();
            dk.Mamh = mamh;
            dk.MaSo = maso;
            dk.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
