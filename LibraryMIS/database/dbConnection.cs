using System;

namespace LibraryMIS.database
{
	/// <summary>
	/// dbConnection 的摘要说明。
	/// </summary>
	public class dbConnection
	{
		public dbConnection()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		public static string connection
		{
			get
			{
                return "Data Source=.;Initial Catalog=LIBRARYMIS;Integrated Security=True";
            }
		}
	}
}
