
/*
'===============================================================================
'  GD.BBPH.BL.NhapkhonguyenlieuManager
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
	public class NhapkhonguyenlieuManager : NhapkhonguyenlieuManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NhapkhonguyenlieuManager()
		{
			// Nothing for now.
		}
        public DataTable SelectByNgayKhoLydoRDT(System.DateTime Ngay, System.String Makho, System.String Malydo)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(NhapkhonguyenlieuFields.Ngaynhap == Ngay);
            _PredicateExpression.Add(NhapkhonguyenlieuFields.Makho == Makho);
            _PredicateExpression.Add(NhapkhonguyenlieuFields.Malydo == Malydo);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }
    }
}
