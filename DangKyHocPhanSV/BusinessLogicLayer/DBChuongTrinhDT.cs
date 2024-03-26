using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DBChuongTrinhDT
    {
        DAL db = null;
        public DBChuongTrinhDT()
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

        public DataSet DanhSachCTDT()
        {
            return db.ExecuteQueryDataSet("NonP_DanhSachCTDT", CommandType.StoredProcedure);
        }
    }
}
