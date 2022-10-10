﻿
/*
'===============================================================================
'  GD.BBPH.BL.PhieugiaohangDManager
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
	public class PhieugiaohangDManager : PhieugiaohangDManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhieugiaohangDManager()
		{
			// Nothing for now.
		}

        public int DeleteBySophieugiao(System.String Sophieugiao)
        {
            int toReturn = 0;
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(PhieugiaohangDFields.Sophieu == Sophieugiao);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
            }
            return toReturn;
        }
    }

}
