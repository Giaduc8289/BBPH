
/*
'===============================================================================
'  GD.BBPH.BL.SodunguyenlieuManager
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
	public class SodunguyenlieuManager : SodunguyenlieuManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SodunguyenlieuManager()
		{
			// Nothing for now.
		}

        public DataTable SelectByNgaykiemkhoRDT(System.DateTime Ngaykiemke, System.String Makho)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(SodunguyenlieuFields.Ngaykiemke == Ngaykiemke);
            _PredicateExpression.Add(SodunguyenlieuFields.Makho == Makho);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_SodunguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }
    }
}
