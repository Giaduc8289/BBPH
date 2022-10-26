
/*
'===============================================================================
'  GD.BBPH.BL.KetquaghepManager
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
	public class KetquaghepManager : KetquaghepManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquaghepManager()
		{
			// Nothing for now.
		}

        public DataTable SelectByNgayCaMamayRDT(System.DateTime Ngay, System.Int32 Ca, System.String Mamay)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(KetquaghepFields.Ngay == Ngay);
            _PredicateExpression.Add(KetquaghepFields.Ca == Ca);
            _PredicateExpression.Add(KetquaghepFields.Mamay == Mamay);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }
    }
}
