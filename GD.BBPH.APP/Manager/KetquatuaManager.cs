
/*
'===============================================================================
'  GD.BBPH.BL.KetquatuaManager
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
	public class KetquatuaManager : KetquatuaManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquatuaManager()
		{
			// Nothing for now.
		}
        public DataTable SelectByNgayCaLenhtuaRDT(System.DateTime Ngay, System.String Ca, System.String Lenhtua )
        {
            DataTable toReturn = new DataTable();
            EntityCollection _KetquatuaCollection = new EntityCollection(new KetquatuaEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(KetquatuaFields.Ngay == Ngay);
            _PredicateExpression.Add(KetquatuaFields.Ca == Ca);
            _PredicateExpression.Add(KetquatuaFields.Lenhtua == Lenhtua);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_KetquatuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }
    }
}
