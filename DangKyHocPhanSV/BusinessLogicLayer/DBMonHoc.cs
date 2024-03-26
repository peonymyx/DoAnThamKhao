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
    public class DBMonHoc
    {
        DAL db = null;
        public DBMonHoc()
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

        public DataSet DSMonHoc()
        {
            return db.ExecuteQueryDataSet("NonP_DanhSachMonHoc", CommandType.StoredProcedure);
        }

        public DataSet TimKiemMH(String mamh)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM dbo.RTO_TimKiemMonHoc(N'{mamh}')", CommandType.Text);
        }

        public bool ThemMonHoc(ref string err, string MaMH, string TenMH, int SoTinChi)
        {
            return db.MyExecuteNonQuery("Re_ThemMonHoc", CommandType.StoredProcedure,
                ref err, new SqlParameter("@MaMH", MaMH),
                new SqlParameter("@TenMH", TenMH),
                new SqlParameter("@SoTinChi", SoTinChi));
        }

        public bool XoaMonHoc(ref string err, string MaMH)
        {
            return db.MyExecuteNonQuery("Re_XoaMonHoc", CommandType.StoredProcedure,
                ref err, new SqlParameter("@MaMH", MaMH));
        }
    }
}
