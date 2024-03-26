using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;



namespace DataAccessLayer
{
    public class DAL
    {
        SqlConnection cnn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adp = null;

        string strConnect = "Data Source =ENVY; Initial Catalog = QUANLYSV; Integrated Security = True";

        public void changeStrConnectToSinhVien()
        {
            strConnect = "Data Source =ENVY; Initial Catalog = QUANLYSV; Persist Security Info = True; User ID = sinhvien; Password = sinhvien";
            cnn = new SqlConnection(strConnect);
            cmd = cnn.CreateCommand();
        }

        public void changeStrConnectToGiangVien()
        {
            strConnect = "Data Source = (local); Initial Catalog = QUANLYSV; Persist Security Info = True; User ID = giangvien; Password = giangvien";
            cnn = new SqlConnection(strConnect);
            cmd = cnn.CreateCommand();
        }

        public DAL()
        {
            cnn = new SqlConnection(strConnect);
            cmd = cnn.CreateCommand();
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            cmd.Parameters.Clear();
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public DataSet ExecuteQueryDataSetParam(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return f;
        }
        public int MyExecuteScalarFunction(string strSQL)
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();

            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = CommandType.Text;

            int result = 0;

            int? count = cmd.ExecuteScalar() as int?;
            if (count != null)
                result = count.Value;

            return result;
        }

        public string ExecuteQueryXML(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds.GetXml();
        }
    }
}
