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
    public class DBLop
    {
        DAL db = null;
        public DBLop()
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

        public DataSet DSLop()
        {
            return db.ExecuteQueryDataSet("NonP_DanhSachLop", CommandType.StoredProcedure);
        }

        public DataSet DSSinhVienLop(String ms)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM dbo.RTO_ThongTinSVLop(N'{ms}')", CommandType.Text);
        }

        public bool ThemLop(ref string err, string MaLop, string TenLop, string MaNganh, string MaCTDT)
        {
            return db.MyExecuteNonQuery("Re_ThemLop", CommandType.StoredProcedure,
                ref err, new SqlParameter("@MaLop", MaLop),
                new SqlParameter("@TenLop", TenLop),
                new SqlParameter("@MaNganh", MaNganh),
                new SqlParameter("@MaCTDT", MaCTDT));
        }

        public bool XoaLop(ref string err, string MaLop)
        {
            return db.MyExecuteNonQuery("Re_XoaLop", CommandType.StoredProcedure,
                ref err, new SqlParameter("@MaLop", MaLop));
        }


    }
}
