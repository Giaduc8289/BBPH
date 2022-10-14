
/*
'===============================================================================
'  GD.BBPH.BL.KetquainManager
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
	public class KetquainManager : KetquainManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquainManager()
		{
			// Nothing for now.
		}
        public DataTable SelectByNgayCaMamayRDT(System.DateTime Ngay, System.Int32 Ca, System.String Mamay)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _KetquainCollection = new EntityCollection(new KetquainEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(KetquainFields.Ngay == Ngay);
            _PredicateExpression.Add(KetquainFields.Ca == Ca);
            _PredicateExpression.Add(KetquainFields.Mamay == Mamay);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_KetquainCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }
    }
}
