using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.BBPH.BLL
{
	public class DataAccessAdapterFactory
	{
		public static DataAccessAdapterBase CreateAdapter(string DatabaseType)
		{
			DataAccessAdapterBase toReturn = null;
            toReturn = new GD.BBPH.DAL.DatabaseSpecific.DataAccessAdapter();   
			return toReturn;
		}

		public DataAccessAdapterBase CreateAdapter()
		{
            return CreateAdapter(ConfigurationSettings.AppSettings["DefaultDatabaseType"]);
		}
	}
}

