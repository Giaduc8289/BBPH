
/*
'===============================================================================
'  GD.BBPH.BL.DmnhomquycachManager
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
	public class DmnhomquycachManager : DmnhomquycachManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmnhomquycachManager()
		{
			// Nothing for now.
		}

        public DataTable SelectByManhoms(string[] arrManhom)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());

            RelationPredicateBucket filter = new RelationPredicateBucket();
            IPredicateExpression _PredicateExpression = new PredicateExpression();
            if (arrManhom.Length > 0)
            {
                _PredicateExpression.Add(DmnhomquycachFields.Manhom == arrManhom[0]);
                for (int i = 1; i < arrManhom.Length; i++)
                    _PredicateExpression.AddWithOr(DmnhomquycachFields.Manhom == arrManhom[i]);
            }
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_DmnhomquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }

    }
}
