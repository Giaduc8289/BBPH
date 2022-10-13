
/*
'===============================================================================
'  GD.BBPH.BL.NhapkhosanphamManager
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
	public class NhapkhosanphamManager : NhapkhosanphamManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NhapkhosanphamManager()
		{
			// Nothing for now.
		}
        public DataTable SelectByNgaynhapMakhoRDT(System.DateTime Ngaynhap, System.String Makho)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(NhapkhosanphamFields.Ngaynhap == Ngaynhap);
            _PredicateExpression.Add(NhapkhosanphamFields.Makho == Makho);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }
    }
}
