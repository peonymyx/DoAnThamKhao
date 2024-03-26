using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;


namespace BusinessLogicLayer
{

    public class DBSinhVien
    {
        DAL db = null;
        public DBSinhVien()
        {
            db = new DAL();
        }

        public void SinhVienConnect()
        {
            db.changeStrConnectToSinhVien();
        }

        public void GiangVienConnect()
        {
            db.changeStrConnectToGiangVien();
        }

        //Hiển thị thông tin sinh viên
        public DataSet ThongTin(string Mssv)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM dbo.RTO_ThongTinSV('{Mssv}')", CommandType.Text);
        }

        public DataSet HocPhanCTDTSV(string Mssv)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM dbo.RTM_HocPhanCTDTSV('{Mssv}')", CommandType.Text);
        }

        public DataSet DSSinhVienDKMH()
        {
            return db.ExecuteQueryDataSet("NonP_DanhSachDKMH", CommandType.StoredProcedure);
        }

        public bool ThemSV(ref string err, string TenDangNhap, string MatKhau, string HoTenSV, string GioiTinh, string NgaySinh, string MaLop)
        {
            return db.MyExecuteNonQuery("Re_ThemSinhVien", CommandType.StoredProcedure,
                ref err, new SqlParameter("@TenDangNhap", TenDangNhap),
                new SqlParameter("@MatKhau", MatKhau),
                new SqlParameter("@HoTenSV", HoTenSV),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@MaLop ", MaLop));
        }

        public bool XoaSV(ref string err, string mssv)
        {
            return db.MyExecuteNonQuery("Re_XoaSinhVien", CommandType.StoredProcedure,
                ref err, new SqlParameter("@mssv", mssv));
        }

        public bool CapNhatSV(ref string err, string TenDangNhap, string HoTenSV, string GioiTinh, string NgaySinh, string MaLop, string Tinhtrang)
        {
            return db.MyExecuteNonQuery("Re_CapNhatSinhVien", CommandType.StoredProcedure,
                ref err, new SqlParameter("@TenDangNhap", TenDangNhap),
                new SqlParameter("@HoTenSV", HoTenSV),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@MaLop ", MaLop),
                new SqlParameter("@Tinhtrang", Tinhtrang));
        }
    }
}
