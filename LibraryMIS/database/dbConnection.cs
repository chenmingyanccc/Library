using System;

namespace LibraryMIS.database
{
	/// <summary>
	/// dbConnection ��ժҪ˵����
	/// </summary>
	public class dbConnection
	{
		public dbConnection()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
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
