
/*
'===============================================================================
'  GD.BBPH.BL.KehoachthoiManager
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
	public class KehoachthoiManager : KehoachthoiManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KehoachthoiManager()
		{
			// Nothing for now.
		}

        // Return DataTable
        public DataTable SelectByCondition(DateTime Tungay, DateTime Denngay)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _KehoachthoiCollection = new EntityCollection(new KehoachthoiEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(KehoachthoiFields.Ngaychay >= Tungay);
            _PredicateExpression.AddWithAnd(KehoachthoiFields.Ngaychay <= Denngay);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_KehoachthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }

    }
}
