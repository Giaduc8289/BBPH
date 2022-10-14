
/*
'===============================================================================
'  GD.BBPH.BL.SodusanphamManager
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
	public class SodusanphamManager : SodusanphamManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SodusanphamManager()
		{
			// Nothing for now.
		}

        public DataTable SelectByNgaykiemkeMakhoRDT(System.DateTime Ngaykiemke, System.String Makho)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(SodusanphamFields.Ngaykiemke == Ngaykiemke);
            _PredicateExpression.Add(SodusanphamFields.Makho == Makho);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_SodusanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }
    }
}
