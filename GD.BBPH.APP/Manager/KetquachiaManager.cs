
/*
'===============================================================================
'  GD.BBPH.BL.KetquachiaManager
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
	public class KetquachiaManager : KetquachiaManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquachiaManager()
		{
			// Nothing for now.
		}

        public DataTable SelectByNgayCaMamayRDT(System.DateTime Ngay, System.Int32 Ca, System.String Mamay)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(KetquachiaFields.Ngay == Ngay);
            _PredicateExpression.Add(KetquachiaFields.Ca == Ca);
            _PredicateExpression.Add(KetquachiaFields.Mamay == Mamay);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }

    }
}
