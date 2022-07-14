using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryMIS.BLL
{
    class BookDelete
    {
        private SqlConnection oleConnection1 = null;
        DataSet ds;

        public void DeleteBook(int a1, object a2, object a3, object a4)
        {
            this.oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);
            if (a1 >= 0 && a2 != null && a3 != null)
            {
                oleConnection1.Open();
                string sql = "select * from bookOut where BID='" + a4 + "'";
                SqlCommand cmd = new SqlCommand(sql, oleConnection1);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //MessageBox.Show("删除图书'"+ds.Tables["book"].Rows[dataGrid1.CurrentCell.RowNumber][1].ToString().Trim()+"'失败，该图书正在流通中！","提示");
                    throw new Exception("删除类型失败，该图书正在流通中！");
                    //dr.Close();
                }
                else
                {
                    dr.Close();
                    sql = "delete from book where BID not in(select distinct BID from bookOut) and BID " +
                        "= '" + a4 + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("删除图书'"+ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][1].ToString().Trim()+"'成功","提示");
                }
                oleConnection1.Close();
            }
            else
                return;
        }
    }
}
