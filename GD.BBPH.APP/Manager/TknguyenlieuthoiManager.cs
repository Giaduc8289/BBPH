
/*
'===============================================================================
'  GD.BBPH.BL.TknguyenlieuthoiManager
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
	public class TknguyenlieuthoiManager : TknguyenlieuthoiManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TknguyenlieuthoiManager()
		{
			// Nothing for now.
		}

        public DataTable SelectByNgayCaRDT(System.DateTime Ngay, System.Int32 Ca)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(TknguyenlieuthoiFields.Ngay == Ngay);
            _PredicateExpression.Add(TknguyenlieuthoiFields.Ca == Ca);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_TknguyenlieuthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }

    }
}
