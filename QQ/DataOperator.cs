using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QQ
{
    class DataOperator
    {
       private static string connstring = "Data Source=CN-20201211KYDA;Database=QQ;User ID=sa;Pwd=chen199876;";
       public static SqlConnection conn = new SqlConnection(connstring);
        public SqlDataReader GetDataReader(string sql)
        {
            if (conn.State == ConnectionState.Open)//如果当前数据连接处于打开状态??
                conn.Close();
            conn.Open();
            SqlCommand command = new SqlCommand(sql,conn);
            return  command.ExecuteReader();            
            
        }
        public DataSet GetDataSet(string sql)
        {
            /*if(conn.State == System.Data.ConnectionState.Closed)
                conn.Open();*/
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds =new DataSet();
            da.Fill(ds);
            return ds;
        }
        public int ExecuteSql(string sql)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand(sql, conn);
            int num=Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
           return num;
        }
        public int ExecuteSqlResult(string sql)
        {
            SqlCommand command = new SqlCommand(sql, conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open(); 
            int result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }


    }
}
