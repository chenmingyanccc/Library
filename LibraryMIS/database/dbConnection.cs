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
                return @"Data Source =.; Initial Catalog = Hotel; Integrated Security = True";
            }
		}
	}
}
