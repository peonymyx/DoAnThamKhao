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
    public partial class FrmDangNhap : Form
    {
        DBTaiKhoan tk = new DBTaiKhoan();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblThongBao.ResetText();
            string err = "Sai tên người dùng hoặc mật khẩu! Vui lòng nhập lại!";
            int check = tk.DangNhap(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (check == 1)
            {
                FrmTrangAdmin ad = new FrmTrangAdmin();
                ad.MaSo = txtUsername.Text.Trim();
                ad.ShowDialog();
                txtUsername.ResetText();
                txtPassword.ResetText();
                this.Hide();
                this.Show();
            }
            else if (check == 2)
            {
                FrmTrangSinhVien usr = new FrmTrangSinhVien();
                usr.MaSo = txtUsername.Text.Trim();
                usr.ShowDialog();
                txtUsername.ResetText();
                txtPassword.ResetText();
                this.Hide();
                this.Show();
            }
            else if (check == 3)
            {
                FrmTrangGiangVien usr = new FrmTrangGiangVien();
                usr.MaSo = txtUsername.Text.Trim();
                usr.ShowDialog();
                txtUsername.ResetText();
                txtPassword.ResetText();
                this.Hide();
                this.Show();
            }
            else // không đúng thì xuất ra thông báo!
            {
                lblThongBao.Text = err;
                txtUsername.ResetText();
                txtPassword.ResetText();
                txtUsername.Focus();
            }
        }

        private void rdbtnShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnShowPass.Checked)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
