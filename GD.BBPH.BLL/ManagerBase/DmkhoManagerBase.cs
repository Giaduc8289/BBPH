


/*
'===============================================================================
'  GD.BBPH.BL.DmkhoManagerBase
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
	public class DmkhoManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Makho="Makho";				
		
		public const String Field_Tenkho="Tenkho";				
		
		public const String Field_Tenrutgon="Tenrutgon";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmkhoManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Makho,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkho,typeof(System.String));
			
			dt.Columns.Add(Field_Tenrutgon,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmkhoEntity _DmkhoEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Makho]=_DmkhoEntity.Makho;
			}
			catch { }
			
			try
			{
				r[Field_Tenkho]=_DmkhoEntity.Tenkho;
			}
			catch { }
			
			try
			{
				r[Field_Tenrutgon]=_DmkhoEntity.Tenrutgon;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmkhoEntity Convert(DataRow r)
		{	
			
			DmkhoEntity _DmkhoEntity=new DmkhoEntity(r[Field_Makho].ToString());					
						
			
			
			try
			{
				_DmkhoEntity.Tenkho= r[Field_Tenkho].ToString();						
			}
			catch { }
			
			try
			{
				_DmkhoEntity.Tenrutgon= r[Field_Tenrutgon].ToString();						
			}
			catch { }
									
									
			return _DmkhoEntity;
		}			
		
		public DmkhoEntity Convert_Entity(DmkhoEntity _DmkhoEntity,DmkhoEntity _DmkhoEntity_XML)
		{	
			
			
			_DmkhoEntity.Makho= _DmkhoEntity_XML.Makho;
			
			_DmkhoEntity.Tenkho= _DmkhoEntity_XML.Tenkho;
			
			_DmkhoEntity.Tenrutgon= _DmkhoEntity_XML.Tenrutgon;
									
				
			return _DmkhoEntity;
		}	
		
		public String InsertV2(DmkhoEntity _DmkhoEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmkhoManagerBase()).Insert(_DmkhoEntity).Makho.ToString();
			
			
			try
			{
				r.SetField(Field_Makho,_DmkhoEntity.Makho);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenkho,_DmkhoEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DmkhoEntity.Tenrutgon);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmkhoEntity _DmkhoEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmkhoManagerBase()).Update(_DmkhoEntity);
			r.SetField(Field_Makho,_DmkhoEntity.Makho);
									
			
			
			
			try
			{
				r.SetField(Field_Tenkho,_DmkhoEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DmkhoEntity.Tenrutgon);
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

		public DmkhoEntity Insert(DmkhoEntity DmkhoEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmkhoEntity, true);
			}
			return DmkhoEntity;
		}

		public DmkhoEntity Insert(System.String  Makho, System.String  Tenkho, System.String  Tenrutgon)
		{
			DmkhoEntity _DmkhoEntity = new DmkhoEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmkhoEntity.Makho = Makho;
				
				_DmkhoEntity.Tenkho = Tenkho;
				
				_DmkhoEntity.Tenrutgon = Tenrutgon;
					
					
				adapter.SaveEntity(_DmkhoEntity, true);
			}
			return _DmkhoEntity;
		}

		public DmkhoEntity Insert(System.String Tenkho, System.String Tenrutgon)//ko co mahieu
		{
			DmkhoEntity _DmkhoEntity = new DmkhoEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmkhoEntity.Tenkho = Tenkho;
				
				_DmkhoEntity.Tenrutgon = Tenrutgon;
					

				adapter.SaveEntity(_DmkhoEntity, true);
			}
			return _DmkhoEntity;
		}

		public bool Update(DmkhoEntity _DmkhoEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmkhoFields.Makho == _DmkhoEntity.Makho);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmkhoEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmkhoEntity _DmkhoEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmkhoEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Makho, System.String Tenkho, System.String Tenrutgon)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmkhoEntity _DmkhoEntity = new DmkhoEntity(Makho);
				if (adapter.FetchEntity(_DmkhoEntity))
				{
				
					
					
					_DmkhoEntity.Tenkho = Tenkho;
					
					_DmkhoEntity.Tenrutgon = Tenrutgon;
						

					adapter.SaveEntity(_DmkhoEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Makho)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmkhoEntity _DmkhoEntity = new DmkhoEntity(Makho);
				if (adapter.FetchEntity(_DmkhoEntity))
				{
					adapter.DeleteEntity(_DmkhoEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmkhoEntity", null);
			}
		}
		
		
		
		public int DeleteByMakho(System.String Makho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhoFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkho(System.String Tenkho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhoFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenrutgon(System.String Tenrutgon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhoFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhoEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmkhoEntity SelectOne(System.String Makho)
		{
			DmkhoEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmkhoEntity _DmkhoEntity = new DmkhoEntity(Makho);
				if (adapter.FetchEntity(_DmkhoEntity))
				{
					toReturn = _DmkhoEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmkhoCollection = new EntityCollection( new DmkhoEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhoCollection, null, 0, null);
			}
			return _DmkhoCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhoCollection = new EntityCollection(new DmkhoEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhoCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMakho(System.String Makho)
		{
			EntityCollection _DmkhoCollection = new EntityCollection(new DmkhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhoFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhoCollection, filter, 0, null);
			}
			return _DmkhoCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhoRDT(System.String Makho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhoCollection = new EntityCollection(new DmkhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhoFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkho(System.String Tenkho)
		{
			EntityCollection _DmkhoCollection = new EntityCollection(new DmkhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhoFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhoCollection, filter, 0, null);
			}
			return _DmkhoCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhoRDT(System.String Tenkho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhoCollection = new EntityCollection(new DmkhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhoFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenrutgon(System.String Tenrutgon)
		{
			EntityCollection _DmkhoCollection = new EntityCollection(new DmkhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhoFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhoCollection, filter, 0, null);
			}
			return _DmkhoCollection;
		}
		// Return DataTable
		public DataTable SelectByTenrutgonRDT(System.String Tenrutgon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhoCollection = new EntityCollection(new DmkhoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhoFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
