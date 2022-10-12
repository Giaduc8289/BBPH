
/*
'===============================================================================
'  GD.BBPH.BL.DonhangDManager
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
	public class DonhangDManager : DonhangDManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DonhangDManager()
		{
			// Nothing for now.
		}

        public DataTable SelectByMahangRDT(System.String Mahang)
        {
            DataTable toReturn = new DataTable();
            EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.Add(DonhangDFields.Masp == Mahang);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
            }
            return toReturn;
        }
    }
}
