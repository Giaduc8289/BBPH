


/*
'===============================================================================
'  GD.BBPH.BL.DmbophanManagerBase
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
using System.Windows.Forms;
namespace GD.BBPH.BLL
{
	public class DmbophanManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Mabp="Mabp";				
		
		public const String Field_Tenbophan="Tenbophan";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmbophanManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Mabp,typeof(System.String));
			
			dt.Columns.Add(Field_Tenbophan,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmbophanEntity _DmbophanEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mabp]=_DmbophanEntity.Mabp;
			}
			catch { }
			
			try
			{
				r[Field_Tenbophan]=_DmbophanEntity.Tenbophan;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmbophanEntity Convert(DataRow r)
		{	
			
			DmbophanEntity _DmbophanEntity=new DmbophanEntity(r[Field_Mabp].ToString());					
						
			
			
			try
			{
				_DmbophanEntity.Tenbophan= r[Field_Tenbophan].ToString();						
			}
			catch { }
									
									
			return _DmbophanEntity;
		}			
		
		public DmbophanEntity Convert_Entity(DmbophanEntity _DmbophanEntity,DmbophanEntity _DmbophanEntity_XML)
		{	
			
			
			_DmbophanEntity.Mabp= _DmbophanEntity_XML.Mabp;
			
			_DmbophanEntity.Tenbophan= _DmbophanEntity_XML.Tenbophan;
									
				
			return _DmbophanEntity;
		}	
		
		public String InsertV2(DmbophanEntity _DmbophanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmbophanManagerBase()).Insert(_DmbophanEntity).Mabp.ToString();
			
			
			try
			{
				r.SetField(Field_Mabp,_DmbophanEntity.Mabp);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenbophan,_DmbophanEntity.Tenbophan);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmbophanEntity _DmbophanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmbophanManagerBase()).Update(_DmbophanEntity);
			r.SetField(Field_Mabp,_DmbophanEntity.Mabp);
									
			
			
			
			try
			{
				r.SetField(Field_Tenbophan,_DmbophanEntity.Tenbophan);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
		}

		public void InsertCollection(EntityCollection _Collection)
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntityCollection(_Collection);
			}
		}

		public DmbophanEntity Insert(DmbophanEntity DmbophanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmbophanEntity, true);
			}
			return DmbophanEntity;
		}

		public DmbophanEntity Insert(System.String  Mabp, System.String  Tenbophan)
		{
			DmbophanEntity _DmbophanEntity = new DmbophanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmbophanEntity.Mabp = Mabp;
				
				_DmbophanEntity.Tenbophan = Tenbophan;
					
					
				adapter.SaveEntity(_DmbophanEntity, true);
			}
			return _DmbophanEntity;
		}

		public DmbophanEntity Insert(System.String Tenbophan)//ko co mahieu
		{
			DmbophanEntity _DmbophanEntity = new DmbophanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmbophanEntity.Tenbophan = Tenbophan;
					

				adapter.SaveEntity(_DmbophanEntity, true);
			}
			return _DmbophanEntity;
		}

		public bool Update(DmbophanEntity _DmbophanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmbophanFields.Mabp == _DmbophanEntity.Mabp);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmbophanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmbophanEntity _DmbophanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmbophanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mabp, System.String Tenbophan)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmbophanEntity _DmbophanEntity = new DmbophanEntity(Mabp);
				if (adapter.FetchEntity(_DmbophanEntity))
				{
				
					
					
					_DmbophanEntity.Tenbophan = Tenbophan;
						

					adapter.SaveEntity(_DmbophanEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Mabp)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmbophanEntity _DmbophanEntity = new DmbophanEntity(Mabp);
				if (adapter.FetchEntity(_DmbophanEntity))
				{
					adapter.DeleteEntity(_DmbophanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmbophanEntity", null);
			}
		}
		
		
		
		public int DeleteByMabp(System.String Mabp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Mabp == Mabp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmbophanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenbophan(System.String Tenbophan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Tenbophan == Tenbophan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmbophanEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmbophanEntity SelectOne(System.String Mabp)
		{
			DmbophanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmbophanEntity _DmbophanEntity = new DmbophanEntity(Mabp);
				if (adapter.FetchEntity(_DmbophanEntity))
				{
					toReturn = _DmbophanEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmbophanCollection = new EntityCollection( new DmbophanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmbophanCollection, null, 0, null);
			}
			return _DmbophanCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmbophanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMabp(System.String Mabp)
		{
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Mabp == Mabp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmbophanCollection, filter, 0, null);
			}
			return _DmbophanCollection;
		}
		// Return DataTable
		public DataTable SelectByMabpRDT(System.String Mabp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Mabp == Mabp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmbophanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenbophan(System.String Tenbophan)
		{
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Tenbophan == Tenbophan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmbophanCollection, filter, 0, null);
			}
			return _DmbophanCollection;
		}
		// Return DataTable
		public DataTable SelectByTenbophanRDT(System.String Tenbophan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Tenbophan == Tenbophan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmbophanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
