using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class DBDangKy
    {
        DAL db = null;
        public DBDangKy()
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

        public bool DangKyLH(ref string err, string MaLopHoc, string MaSV)
        {
            return db.MyExecuteNonQuery("Re_DangKyLH", CommandType.StoredProcedure,
                ref err, new SqlParameter("@MaLopHoc", MaLopHoc),
                new SqlParameter("@MaSV", MaSV));
        }

        public bool XoaDangKyLH(ref string err, string MaLopHoc, string MaSV)
        {
            return db.MyExecuteNonQuery("Re_XoaDangKyLH", CommandType.StoredProcedure,
                ref err, new SqlParameter("@MaLopHoc", MaLopHoc),
                new SqlParameter("@MaSV", MaSV));
        }
    }
}
