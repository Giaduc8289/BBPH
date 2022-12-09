
/*
'===============================================================================
'  GD.BBPH.BL.KehoachchiaManager
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
	public class KehoachchiaManager : KehoachchiaManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KehoachchiaManager()
		{
			// Nothing for now.
		}

        // Return DataTable
        public DataTable SelectByCondition(DateTime Tungay, DateTime Denngay)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(KehoachchiaFields.Ngaychay >= Tungay);
            _PredicateExpression.AddWithAnd(KehoachchiaFields.Ngaychay <= Denngay);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }

    }
}
