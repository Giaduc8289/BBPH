
/*
'===============================================================================
'  GD.BBPH.BL.DmnguyenlieuManager
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
	public class DmnguyenlieuManager : DmnguyenlieuManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmnguyenlieuManager()
		{
			// Nothing for now.
		}

        public DataTable SelectByManlNgayRDT(System.String Manl, DateTime Ngay)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(DmnguyenlieuFields.Manl == Manl);
            _PredicateExpression.AddWithAnd(DmnguyenlieuFields.Ngay <= Ngay);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }


    }
}
