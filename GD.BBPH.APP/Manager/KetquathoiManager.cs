
/*
'===============================================================================
'  GD.BBPH.BL.KetquathoiManager
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
	public class KetquathoiManager : KetquathoiManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquathoiManager()
		{
			// Nothing for now.
		}
        public DataTable SelectByNgayCaMamayRDT(System.DateTime Ngay,System.Int32 Ca, System.String Mamay)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _KetquathoiCollection = new EntityCollection(new KetquathoiEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(KetquathoiFields.Ngay == Ngay);
            _PredicateExpression.Add(KetquathoiFields.Ca == Ca);
            _PredicateExpression.Add(KetquathoiFields.Mamay == Mamay);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_KetquathoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }
    }
}
