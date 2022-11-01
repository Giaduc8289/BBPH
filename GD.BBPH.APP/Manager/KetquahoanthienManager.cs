
/*
'===============================================================================
'  GD.BBPH.BL.KetquahoanthienManager
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
	public class KetquahoanthienManager : KetquahoanthienManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquahoanthienManager()
		{
			// Nothing for now.
		}

        public DataTable SelectByNgayCaMamayRDT(System.DateTime Ngay, System.Int32 Ca, System.String Mamay)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _KetquahoanthienCollection = new EntityCollection(new KetquahoanthienEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(KetquahoanthienFields.Ngay == Ngay);
            _PredicateExpression.Add(KetquahoanthienFields.Ca == Ca);
            _PredicateExpression.Add(KetquahoanthienFields.Mamay == Mamay);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_KetquahoanthienCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }

    }
}
