
/*
'===============================================================================
'  GD.BBPH.BL.MangcuahangManager
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
	public class MangcuahangManager : MangcuahangManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MangcuahangManager()
		{
			// Nothing for now.
		}

        public DataTable SelectManginByMaspRDT(System.String Masp)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(MangcuahangFields.Masp == Masp);
            _PredicateExpression.Add(MangcuahangFields.Mangin == true);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }

    }
}
