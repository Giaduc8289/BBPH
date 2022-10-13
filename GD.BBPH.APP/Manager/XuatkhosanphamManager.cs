
/*
'===============================================================================
'  GD.BBPH.BL.XuatkhosanphamManager
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
	public class XuatkhosanphamManager : XuatkhosanphamManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XuatkhosanphamManager()
		{
			// Nothing for now.
		}
        public DataTable SelectByNgayxuatMakhoRDT(System.DateTime Ngayxuat, System.String Makho)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(XuatkhosanphamFields.Ngayxuat == Ngayxuat);
            _PredicateExpression.Add(XuatkhosanphamFields.Makho == Makho);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }
    }
}
