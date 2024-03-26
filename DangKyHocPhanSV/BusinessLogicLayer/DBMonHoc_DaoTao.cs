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
    public class DBMonHoc_DaoTao
    {
        DAL db = null;
        public DBMonHoc_DaoTao()
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

        public DataSet DSMHDT()
        {
            return db.ExecuteQueryDataSet("NonP_DanhSachMHDT", CommandType.StoredProcedure);
        }

        public DataSet TimKiemMHDT(String mamhdt)
        {
            return db.ExecuteQueryDataSet($"SELECT * FROM dbo.RTO_TimKiemMHDT(N'{mamhdt}')", CommandType.Text);
        }

        public bool ThemMHDT(ref string err, string MaMHDT , string MaMH, string MaCTDT, string MaNganh )
        {
            return db.MyExecuteNonQuery("Re_ThemMHDT", CommandType.StoredProcedure,
                ref err, new SqlParameter("@MaMHDT", MaMHDT),
                new SqlParameter("@MaMH", MaMH),
                new SqlParameter("@MaCTDT", MaCTDT),
                new SqlParameter("@MaNganh", MaNganh));
        }

        public bool XoaMHDT(ref string err, string MaMHDT)
        {
            return db.MyExecuteNonQuery("Re_XoaMHDT", CommandType.StoredProcedure,
                ref err, new SqlParameter("@MaMHDT", MaMHDT));
        }
    }
}
