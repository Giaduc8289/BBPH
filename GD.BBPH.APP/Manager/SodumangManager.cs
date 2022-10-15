
/*
'===============================================================================
'  GD.BBPH.BL.SodumangManager
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
	public class SodumangManager : SodumangManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SodumangManager()
		{
			// Nothing for now.
		}
        public DataTable SelectByNgaykiemkeMakhoRDT(System.DateTime Ngaykiemke, System.String Makho)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(SodumangFields.Ngaykiemke == Ngaykiemke);
            _PredicateExpression.Add(SodumangFields.Makho == Makho);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_SodumangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }

    }
}
