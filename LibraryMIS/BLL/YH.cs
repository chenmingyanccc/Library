using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LibraryMIS.BLL
{
    class YH
    {
        private System.ComponentModel.Container components = null;
        private SqlConnection oleConnection1 = null;
        DataSet ds;
        public YH()
        {
            this.oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);
        }
        public DataTable UserTable()
        {
            oleConnection1.Open();
            string sql = "select MName as 用户名,MCode as 密码,manage as 权限1,work as 权限2,query as 权限3 from manager";
            SqlDataAdapter adp = new SqlDataAdapter(sql, oleConnection1);
            ds = new DataSet();
            ds.Clear();
            adp.Fill(ds, "user");
            DataTable userdataTable = ds.Tables["user"];
            oleConnection1.Close();
            return userdataTable;
        }
        public void AddUsers(string Name, string pwd, string pwdnew, bool manager, bool work)
        {
            if (Name == "" || pwd == "" || pwdnew == "" || manager == false && work == false)
            {
                MessageBox.Show("请输入完整信息！", "警告");
            }
            else
            {
                if (pwd != pwdnew)
                {
                    MessageBox.Show("两次密码输入不一致！", "警告");
                }
                else
                {
                    oleConnection1.Open();
                    SqlCommand cmd = new SqlCommand("", oleConnection1);
                    string sql = "select * from manager where MName = '" + Name + "'";
                    cmd.CommandText = sql;

                    if (null == cmd.ExecuteScalar())
                    {
                        if (manager == true)
                            sql = "insert into manager " +
                                "values ('" + Name + "','" + pwdnew + "',0,1,0)";
                        else
                            sql = "insert into manager " +
                                "values ('" + Name + "','" + pwdnew + "',1,0,1)";

                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("添加用户成功！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("用户名" + Name + "已经存在！", "提示");
                        pwdnew = "";
                        pwd = "";
                    }

                    oleConnection1.Close();
                }

            }
        }
        public void delUser(int x)
        {
            oleConnection1.Open();
            string sql = "delete  from manager where MName = '" + ds.Tables["user"].Rows[x][0].ToString().Trim() + "'";
            SqlCommand cmd = new SqlCommand(sql, oleConnection1);
            cmd.ExecuteNonQuery();
            oleConnection1.Close();
            MessageBox.Show("删除用户'" + ds.Tables[0].Rows[x][0].ToString().Trim() + "'成功", "提示");
        }
    }
}
