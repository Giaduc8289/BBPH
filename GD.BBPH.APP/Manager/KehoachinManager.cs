
/*
'===============================================================================
'  GD.BBPH.BL.KehoachinManager
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
	public class KehoachinManager : KehoachinManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KehoachinManager()
		{
			// Nothing for now.
		}

        // Return DataTable
        public DataTable SelectByCondition(DateTime Tungay, DateTime Denngay)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(KehoachinFields.Ngaychay >= Tungay);
            _PredicateExpression.AddWithAnd(KehoachinFields.Ngaychay <= Denngay);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }

        //public int DeleteByChuaphatlenhtruocngay(System.DateTime Truocngay)
        //{
        //    int toReturn = 0;
        //    RelationPredicateBucket filter = new RelationPredicateBucket();

        //    IPredicateExpression _PredicateExpression = new PredicateExpression();
        //    _PredicateExpression.Add(KehoachinFields.Ngaychay < Truocngay);
        //    _PredicateExpression.Add(KehoachinFields.Daphatlenh == 0);
        //    filter.PredicateExpression.Add(_PredicateExpression);

        //    using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
        //    {
        //        toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
        //    }
        //    return toReturn;
        //}

    }
}
