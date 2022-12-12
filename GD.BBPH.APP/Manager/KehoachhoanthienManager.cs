
/*
'===============================================================================
'  GD.BBPH.BL.KehoachhoanthienManager
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
	public class KehoachhoanthienManager : KehoachhoanthienManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KehoachhoanthienManager()
		{
			// Nothing for now.
		}
        public DataTable SelectByCondition(DateTime Tungay, DateTime Denngay)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _KehoachhoanthienCollection = new EntityCollection(new KehoachhoanthienEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(KehoachhoanthienFields.Ngaychay >= Tungay);
            _PredicateExpression.AddWithAnd(KehoachhoanthienFields.Ngaychay <= Denngay);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_KehoachhoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }
    }
}
