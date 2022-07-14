using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryMIS.BLL
{
    class Addtypes
    {
        private SqlConnection oleConnection1 = null;
        DataSet ds;

        public void CreateType(string Name, string Remark)
        {
            this.oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);
            if (Name == "" || Remark == "")
                //MessageBox.Show("请填写完整信息","提示");
                throw new Exception("请填写完整信息");
            else
            {
                oleConnection1.Open();
                string sql = "select * from type where type='" + Name + "'";
                SqlCommand cmd = new SqlCommand(sql, oleConnection1);
                if (null != cmd.ExecuteScalar())
                    //MessageBox.Show("类型重复，请重新输入！","提示");
                    throw new Exception("类型重复，请重新输入！");
                else
                {
                    sql = "insert into type (type,tRemark) values ('" + Name + "','" + Remark + "')";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("类型添加成功！","提示");
                    //textName.Clear();
                    //textRemark.Clear();
                }
                oleConnection1.Close();
            }
        }
    }
}
