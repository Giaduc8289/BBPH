
/*
'===============================================================================
'  GD.BBPH.BL.DanhmucManager
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using GD.BBPH.BLL;
using GD.BBPH.DAL;
using GD.BBPH.DAL.EntityClasses;
using GD.BBPH.DAL.FactoryClasses;
using GD.BBPH.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.BBPH.BLL
{
	public class RolesManager : RolesManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
        public static string ROLE_ADMINISTRATOR = "ADMINISTRATOR";
        public RolesManager()
		{
			// Nothing for now.
		}
	}
}
