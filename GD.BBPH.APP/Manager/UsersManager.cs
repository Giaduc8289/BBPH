
/*
'===============================================================================
'  GD.BBPH.BL.UsersManager
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
	public class UsersManager : UsersManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public UsersManager()
		{
			// Nothing for now.
		}
        public EntityCollection SelectBy_Username_Passwords( string Username, string Passwords)
        {
            EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
            RelationPredicateBucket filter = new RelationPredicateBucket();

            IPredicateExpression _PredicateExpression = new PredicateExpression();
            _PredicateExpression.AddWithAnd(UsersFields.Username == Username);
            _PredicateExpression.AddWithAnd(UsersFields.Password == Passwords);
            filter.PredicateExpression.Add(_PredicateExpression);

            using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
            {
                adapter.FetchEntityCollection(_UsersCollection, filter, 0, null);
            }
            return _UsersCollection;
        }
	}
}
