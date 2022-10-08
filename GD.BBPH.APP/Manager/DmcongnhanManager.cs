
/*
'===============================================================================
'  GD.BBPH.BL.DmcongnhanManager
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
	public class DmcongnhanManager : DmcongnhanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmcongnhanManager()
		{
			// Nothing for now.
		}

        public DataTable SelectPhongbanChuanghi(string[] arrPhongban)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());

            RelationPredicateBucket filter = new RelationPredicateBucket();
            IPredicateExpression _PredicateExpression = new PredicateExpression();
            if (arrPhongban.Length > 0)
            {
                _PredicateExpression.Add(DmcongnhanFields.Mabp == arrPhongban[0]);
                for (int i = 1; i < arrPhongban.Length; i++)
                    _PredicateExpression.AddWithOr(DmcongnhanFields.Mabp == arrPhongban[i]);
            }
            filter.PredicateExpression.Add(_PredicateExpression);
            filter.PredicateExpression.AddWithAnd(DmcongnhanFields.Danghi == 0);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }

    }
}
