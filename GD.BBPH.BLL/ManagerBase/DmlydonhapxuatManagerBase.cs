


/*
'===============================================================================
'  GD.BBPH.BL.DmlydonhapxuatManagerBase
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
	public class DmlydonhapxuatManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Malydo="Malydo";				
		
		public const String Field_Tenlydo="Tenlydo";				
		
		public const String Field_Manhom="Manhom";				
		
		public const String Field_Tennhom="Tennhom";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmlydonhapxuatManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Malydo,typeof(System.String));
			
			dt.Columns.Add(Field_Tenlydo,typeof(System.String));
			
			dt.Columns.Add(Field_Manhom,typeof(System.String));
			
			dt.Columns.Add(Field_Tennhom,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmlydonhapxuatEntity _DmlydonhapxuatEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Malydo]=_DmlydonhapxuatEntity.Malydo;
			}
			catch { }
			
			try
			{
				r[Field_Tenlydo]=_DmlydonhapxuatEntity.Tenlydo;
			}
			catch { }
			
			try
			{
				r[Field_Manhom]=_DmlydonhapxuatEntity.Manhom;
			}
			catch { }
			
			try
			{
				r[Field_Tennhom]=_DmlydonhapxuatEntity.Tennhom;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmlydonhapxuatEntity Convert(DataRow r)
		{	
			
			DmlydonhapxuatEntity _DmlydonhapxuatEntity=new DmlydonhapxuatEntity(r[Field_Malydo].ToString());					
						
			
			
			try
			{
				_DmlydonhapxuatEntity.Tenlydo= r[Field_Tenlydo].ToString();						
			}
			catch { }
			
			try
			{
				_DmlydonhapxuatEntity.Manhom= r[Field_Manhom].ToString();						
			}
			catch { }
			
			try
			{
				_DmlydonhapxuatEntity.Tennhom= r[Field_Tennhom].ToString();						
			}
			catch { }
									
									
			return _DmlydonhapxuatEntity;
		}			
		
		public DmlydonhapxuatEntity Convert_Entity(DmlydonhapxuatEntity _DmlydonhapxuatEntity,DmlydonhapxuatEntity _DmlydonhapxuatEntity_XML)
		{	
			
			
			_DmlydonhapxuatEntity.Malydo= _DmlydonhapxuatEntity_XML.Malydo;
			
			_DmlydonhapxuatEntity.Tenlydo= _DmlydonhapxuatEntity_XML.Tenlydo;
			
			_DmlydonhapxuatEntity.Manhom= _DmlydonhapxuatEntity_XML.Manhom;
			
			_DmlydonhapxuatEntity.Tennhom= _DmlydonhapxuatEntity_XML.Tennhom;
									
				
			return _DmlydonhapxuatEntity;
		}	
		
		public String InsertV2(DmlydonhapxuatEntity _DmlydonhapxuatEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmlydonhapxuatManagerBase()).Insert(_DmlydonhapxuatEntity).Malydo.ToString();
			
			
			try
			{
				r.SetField(Field_Malydo,_DmlydonhapxuatEntity.Malydo);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenlydo,_DmlydonhapxuatEntity.Tenlydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manhom,_DmlydonhapxuatEntity.Manhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennhom,_DmlydonhapxuatEntity.Tennhom);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmlydonhapxuatEntity _DmlydonhapxuatEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmlydonhapxuatManagerBase()).Update(_DmlydonhapxuatEntity);
			r.SetField(Field_Malydo,_DmlydonhapxuatEntity.Malydo);
									
			
			
			
			try
			{
				r.SetField(Field_Tenlydo,_DmlydonhapxuatEntity.Tenlydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manhom,_DmlydonhapxuatEntity.Manhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennhom,_DmlydonhapxuatEntity.Tennhom);
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

		public DmlydonhapxuatEntity Insert(DmlydonhapxuatEntity DmlydonhapxuatEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmlydonhapxuatEntity, true);
			}
			return DmlydonhapxuatEntity;
		}

		public DmlydonhapxuatEntity Insert(System.String  Malydo, System.String  Tenlydo, System.String  Manhom, System.String  Tennhom)
		{
			DmlydonhapxuatEntity _DmlydonhapxuatEntity = new DmlydonhapxuatEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmlydonhapxuatEntity.Malydo = Malydo;
				
				_DmlydonhapxuatEntity.Tenlydo = Tenlydo;
				
				_DmlydonhapxuatEntity.Manhom = Manhom;
				
				_DmlydonhapxuatEntity.Tennhom = Tennhom;
					
					
				adapter.SaveEntity(_DmlydonhapxuatEntity, true);
			}
			return _DmlydonhapxuatEntity;
		}

		public DmlydonhapxuatEntity Insert(System.String Tenlydo, System.String Manhom, System.String Tennhom)//ko co mahieu
		{
			DmlydonhapxuatEntity _DmlydonhapxuatEntity = new DmlydonhapxuatEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmlydonhapxuatEntity.Tenlydo = Tenlydo;
				
				_DmlydonhapxuatEntity.Manhom = Manhom;
				
				_DmlydonhapxuatEntity.Tennhom = Tennhom;
					

				adapter.SaveEntity(_DmlydonhapxuatEntity, true);
			}
			return _DmlydonhapxuatEntity;
		}

		public bool Update(DmlydonhapxuatEntity _DmlydonhapxuatEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmlydonhapxuatFields.Malydo == _DmlydonhapxuatEntity.Malydo);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmlydonhapxuatEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmlydonhapxuatEntity _DmlydonhapxuatEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmlydonhapxuatEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Malydo, System.String Tenlydo, System.String Manhom, System.String Tennhom)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmlydonhapxuatEntity _DmlydonhapxuatEntity = new DmlydonhapxuatEntity(Malydo);
				if (adapter.FetchEntity(_DmlydonhapxuatEntity))
				{
				
					
					
					_DmlydonhapxuatEntity.Tenlydo = Tenlydo;
					
					_DmlydonhapxuatEntity.Manhom = Manhom;
					
					_DmlydonhapxuatEntity.Tennhom = Tennhom;
						

					adapter.SaveEntity(_DmlydonhapxuatEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Malydo)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmlydonhapxuatEntity _DmlydonhapxuatEntity = new DmlydonhapxuatEntity(Malydo);
				if (adapter.FetchEntity(_DmlydonhapxuatEntity))
				{
					adapter.DeleteEntity(_DmlydonhapxuatEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmlydonhapxuatEntity", null);
			}
		}
		
		
		
		public int DeleteByMalydo(System.String Malydo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmlydonhapxuatFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmlydonhapxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenlydo(System.String Tenlydo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmlydonhapxuatFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmlydonhapxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByManhom(System.String Manhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmlydonhapxuatFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmlydonhapxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennhom(System.String Tennhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmlydonhapxuatFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmlydonhapxuatEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmlydonhapxuatEntity SelectOne(System.String Malydo)
		{
			DmlydonhapxuatEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmlydonhapxuatEntity _DmlydonhapxuatEntity = new DmlydonhapxuatEntity(Malydo);
				if (adapter.FetchEntity(_DmlydonhapxuatEntity))
				{
					toReturn = _DmlydonhapxuatEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmlydonhapxuatCollection = new EntityCollection( new DmlydonhapxuatEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmlydonhapxuatCollection, null, 0, null);
			}
			return _DmlydonhapxuatCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmlydonhapxuatCollection = new EntityCollection(new DmlydonhapxuatEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmlydonhapxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMalydo(System.String Malydo)
		{
			EntityCollection _DmlydonhapxuatCollection = new EntityCollection(new DmlydonhapxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmlydonhapxuatFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmlydonhapxuatCollection, filter, 0, null);
			}
			return _DmlydonhapxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByMalydoRDT(System.String Malydo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmlydonhapxuatCollection = new EntityCollection(new DmlydonhapxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmlydonhapxuatFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmlydonhapxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenlydo(System.String Tenlydo)
		{
			EntityCollection _DmlydonhapxuatCollection = new EntityCollection(new DmlydonhapxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmlydonhapxuatFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmlydonhapxuatCollection, filter, 0, null);
			}
			return _DmlydonhapxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByTenlydoRDT(System.String Tenlydo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmlydonhapxuatCollection = new EntityCollection(new DmlydonhapxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmlydonhapxuatFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmlydonhapxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByManhom(System.String Manhom)
		{
			EntityCollection _DmlydonhapxuatCollection = new EntityCollection(new DmlydonhapxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmlydonhapxuatFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmlydonhapxuatCollection, filter, 0, null);
			}
			return _DmlydonhapxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByManhomRDT(System.String Manhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmlydonhapxuatCollection = new EntityCollection(new DmlydonhapxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmlydonhapxuatFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmlydonhapxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennhom(System.String Tennhom)
		{
			EntityCollection _DmlydonhapxuatCollection = new EntityCollection(new DmlydonhapxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmlydonhapxuatFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmlydonhapxuatCollection, filter, 0, null);
			}
			return _DmlydonhapxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByTennhomRDT(System.String Tennhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmlydonhapxuatCollection = new EntityCollection(new DmlydonhapxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmlydonhapxuatFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmlydonhapxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
