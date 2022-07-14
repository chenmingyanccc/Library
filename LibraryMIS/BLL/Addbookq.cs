using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryMIS.BLL
{
    class Addbookq
    {
        private SqlConnection oleConnection1 = null;
        DataSet ds;

        public void Createbook(string ID, string Name, string Num, string Writer, string Publish, string Price, string Type, string Remark, DateTime datee)
        {
            if (ID == "" || Name == "" || textNum.Text.Trim() == "" || Writer == "")
                //MessageBox.Show("请填写完整信息","提示");
                throw new Exception("请填写完整信息");
            else
            {
                oleConnection1.Open();
                string sql = "select * from book where BID='" + ID + "'";
                SqlCommand cmd = new SqlCommand(sql, oleConnection1);
                if (null != cmd.ExecuteScalar())
                    //MessageBox.Show("图书编号重复","提示");
                    throw new Exception("类型重复，请重新输入！");
                else
                {
                    sql = "insert into book values ('" + ID + "','" + Name + "','" + Writer + "'," +
                        "'" + Publish + "','" + datee + "','" + Price + "','" + Num + "'," +
                        "'" + Type + "','" + Remark + "')";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("添加成功","提示");
                    //clear();
                }
                oleConnection1.Close();
            }
        }
    }
}
