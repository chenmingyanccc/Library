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
                return "server=MS-20160107RORB\\SQL2005;database=book;uid=sa;pwd=123321";
            }
		}
	}
}
