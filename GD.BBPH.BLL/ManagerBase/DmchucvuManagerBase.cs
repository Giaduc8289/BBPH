


/*
'===============================================================================
'  GD.BBPH.BL.DmchucvuManagerBase
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
	public class DmchucvuManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Macv="Macv";				
		
		public const String Field_Tenchucvu="Tenchucvu";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmchucvuManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Macv,typeof(System.String));
			
			dt.Columns.Add(Field_Tenchucvu,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmchucvuEntity _DmchucvuEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Macv]=_DmchucvuEntity.Macv;
			}
			catch { }
			
			try
			{
				r[Field_Tenchucvu]=_DmchucvuEntity.Tenchucvu;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmchucvuEntity Convert(DataRow r)
		{	
			
			DmchucvuEntity _DmchucvuEntity=new DmchucvuEntity(r[Field_Macv].ToString());					
						
			
			
			try
			{
				_DmchucvuEntity.Tenchucvu= r[Field_Tenchucvu].ToString();						
			}
			catch { }
									
									
			return _DmchucvuEntity;
		}			
		
		public DmchucvuEntity Convert_Entity(DmchucvuEntity _DmchucvuEntity,DmchucvuEntity _DmchucvuEntity_XML)
		{	
			
			
			_DmchucvuEntity.Macv= _DmchucvuEntity_XML.Macv;
			
			_DmchucvuEntity.Tenchucvu= _DmchucvuEntity_XML.Tenchucvu;
									
				
			return _DmchucvuEntity;
		}	
		
		public String InsertV2(DmchucvuEntity _DmchucvuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmchucvuManagerBase()).Insert(_DmchucvuEntity).Macv.ToString();
			
			
			try
			{
				r.SetField(Field_Macv,_DmchucvuEntity.Macv);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenchucvu,_DmchucvuEntity.Tenchucvu);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmchucvuEntity _DmchucvuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmchucvuManagerBase()).Update(_DmchucvuEntity);
			r.SetField(Field_Macv,_DmchucvuEntity.Macv);
									
			
			
			
			try
			{
				r.SetField(Field_Tenchucvu,_DmchucvuEntity.Tenchucvu);
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

		public DmchucvuEntity Insert(DmchucvuEntity DmchucvuEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmchucvuEntity, true);
			}
			return DmchucvuEntity;
		}

		public DmchucvuEntity Insert(System.String  Macv, System.String  Tenchucvu)
		{
			DmchucvuEntity _DmchucvuEntity = new DmchucvuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmchucvuEntity.Macv = Macv;
				
				_DmchucvuEntity.Tenchucvu = Tenchucvu;
					
					
				adapter.SaveEntity(_DmchucvuEntity, true);
			}
			return _DmchucvuEntity;
		}

		public DmchucvuEntity Insert(System.String Tenchucvu)//ko co mahieu
		{
			DmchucvuEntity _DmchucvuEntity = new DmchucvuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmchucvuEntity.Tenchucvu = Tenchucvu;
					

				adapter.SaveEntity(_DmchucvuEntity, true);
			}
			return _DmchucvuEntity;
		}

		public bool Update(DmchucvuEntity _DmchucvuEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmchucvuFields.Macv == _DmchucvuEntity.Macv);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmchucvuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmchucvuEntity _DmchucvuEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmchucvuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Macv, System.String Tenchucvu)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmchucvuEntity _DmchucvuEntity = new DmchucvuEntity(Macv);
				if (adapter.FetchEntity(_DmchucvuEntity))
				{
				
					
					
					_DmchucvuEntity.Tenchucvu = Tenchucvu;
						

					adapter.SaveEntity(_DmchucvuEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Macv)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmchucvuEntity _DmchucvuEntity = new DmchucvuEntity(Macv);
				if (adapter.FetchEntity(_DmchucvuEntity))
				{
					adapter.DeleteEntity(_DmchucvuEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmchucvuEntity", null);
			}
		}
		
		
		
		public int DeleteByMacv(System.String Macv)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Macv == Macv);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchucvuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenchucvu(System.String Tenchucvu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Tenchucvu == Tenchucvu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchucvuEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmchucvuEntity SelectOne(System.String Macv)
		{
			DmchucvuEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmchucvuEntity _DmchucvuEntity = new DmchucvuEntity(Macv);
				if (adapter.FetchEntity(_DmchucvuEntity))
				{
					toReturn = _DmchucvuEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmchucvuCollection = new EntityCollection( new DmchucvuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchucvuCollection, null, 0, null);
			}
			return _DmchucvuCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMacv(System.String Macv)
		{
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Macv == Macv);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchucvuCollection, filter, 0, null);
			}
			return _DmchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByMacvRDT(System.String Macv)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Macv == Macv);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenchucvu(System.String Tenchucvu)
		{
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Tenchucvu == Tenchucvu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchucvuCollection, filter, 0, null);
			}
			return _DmchucvuCollection;
		}
		// Return DataTable
		public DataTable SelectByTenchucvuRDT(System.String Tenchucvu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchucvuCollection = new EntityCollection(new DmchucvuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchucvuFields.Tenchucvu == Tenchucvu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchucvuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
