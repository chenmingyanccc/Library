using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryMIS.BLL
{
    class ModifyBooks
    {
        private SqlConnection oleConnection1 = null;
        DataSet ds;


        public void ModifyNewBooks(string ID, string Name, string Num, string Writer, string Publish, string Price, string Remark, DateTime datee)
        {
            this.oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);
            if (Name == "" || Writer == "" || Num == "")
                //MessageBox.Show("请填写完整信息","提示");
                throw new Exception("请填写完整信息");
            else
            {
                oleConnection1.Open();
                string sql = "update book set BName='" + Name + "',BWriter='" + Writer + "',BPublish='" + Publish + "'," +
                    "BDate='" + datee + "',BNum='" + Num + "',BPrice='" + Price + "',BRemark='" + Remark + "'" +
                    " where BID='" + ID + "'";
                SqlCommand cmd = new SqlCommand(sql, oleConnection1);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("修改成功","提示");
                //this.Close();
                oleConnection1.Close();
            }
        }
    }
}
