using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryMIS.BLL
{
    class TypeDelete
    {
        private SqlConnection oleConnection1 = null;
        DataSet ds;


        public void DeleteType(int a1, object a2, object a3, object a4, object a5)
        {
            this.oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);
            if (a1 >= 0 && a2 != null && a3 != null)
            {
                oleConnection1.Open();
                string sql = "select * from book where type='" + a4 + "'";
                SqlCommand cmd = new SqlCommand(sql, oleConnection1);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //MessageBox.Show("删除类型'"+a4+"'失败，请先删掉该类型图书！","提示");
                    throw new Exception("删除类型失败，请先删掉该类型图书！");
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    sql = "delete from type where type not in(select distinct type from book) and TID " +
                        "= " + a5 + "";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("删除类型'"+a4+"'成功","提示");
                }
                oleConnection1.Close();
            }
            else
                return;
        }
    }
}
