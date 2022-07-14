using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryMIS.BLL
{
    class Modifytypes
    {
        private SqlConnection oleConnection1 = null;
        DataSet ds;

        public void ModifynewType(string Name, string Remark, string Tag)
        {
            this.oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);
            if (Name == "" || Remark == "")
                //MessageBox.Show("请填写完整信息","提示");
                throw new Exception("请填写完整信息");
            else
            {
                oleConnection1.Open();
                string sql = "select * from type where [type] ='" + Name + "' and TID<>" + Tag + "";
                SqlCommand cmd = new SqlCommand(sql, oleConnection1);
                if (null != cmd.ExecuteScalar())
                    //MessageBox.Show("类型重复","提示");
                    throw new Exception("类型重复");
                else
                {
                    sql = "update type set [type]='" + Name + "',tRemark='" + Remark + "' where TID=" + Tag+"";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("修改成功","提示");
                    //this.Close();
                }
                oleConnection1.Close();
            }
        }
    }
}
