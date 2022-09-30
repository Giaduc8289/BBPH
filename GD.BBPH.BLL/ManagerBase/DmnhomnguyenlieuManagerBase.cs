


/*
'===============================================================================
'  GD.BBPH.BL.DmnhomnguyenlieuManagerBase
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
	public class DmnhomnguyenlieuManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Manhom="Manhom";				
		
		public const String Field_Tennhomnguyenlieu="Tennhomnguyenlieu";				
		
		public const String Field_Tenrutgon="Tenrutgon";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmnhomnguyenlieuManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Manhom,typeof(System.String));
			
			dt.Columns.Add(Field_Tennhomnguyenlieu,typeof(System.String));
			
			dt.Columns.Add(Field_Tenrutgon,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Manhom]=_DmnhomnguyenlieuEntity.Manhom;
			}
			catch { }
			
			try
			{
				r[Field_Tennhomnguyenlieu]=_DmnhomnguyenlieuEntity.Tennhomnguyenlieu;
			}
			catch { }
			
			try
			{
				r[Field_Tenrutgon]=_DmnhomnguyenlieuEntity.Tenrutgon;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmnhomnguyenlieuEntity Convert(DataRow r)
		{	
			
			DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity=new DmnhomnguyenlieuEntity(r[Field_Manhom].ToString());					
						
			
			
			try
			{
				_DmnhomnguyenlieuEntity.Tennhomnguyenlieu= r[Field_Tennhomnguyenlieu].ToString();						
			}
			catch { }
			
			try
			{
				_DmnhomnguyenlieuEntity.Tenrutgon= r[Field_Tenrutgon].ToString();						
			}
			catch { }
									
									
			return _DmnhomnguyenlieuEntity;
		}			
		
		public DmnhomnguyenlieuEntity Convert_Entity(DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity,DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity_XML)
		{	
			
			
			_DmnhomnguyenlieuEntity.Manhom= _DmnhomnguyenlieuEntity_XML.Manhom;
			
			_DmnhomnguyenlieuEntity.Tennhomnguyenlieu= _DmnhomnguyenlieuEntity_XML.Tennhomnguyenlieu;
			
			_DmnhomnguyenlieuEntity.Tenrutgon= _DmnhomnguyenlieuEntity_XML.Tenrutgon;
									
				
			return _DmnhomnguyenlieuEntity;
		}	
		
		public String InsertV2(DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmnhomnguyenlieuManagerBase()).Insert(_DmnhomnguyenlieuEntity).Manhom.ToString();
			
			
			try
			{
				r.SetField(Field_Manhom,_DmnhomnguyenlieuEntity.Manhom);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tennhomnguyenlieu,_DmnhomnguyenlieuEntity.Tennhomnguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DmnhomnguyenlieuEntity.Tenrutgon);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmnhomnguyenlieuManagerBase()).Update(_DmnhomnguyenlieuEntity);
			r.SetField(Field_Manhom,_DmnhomnguyenlieuEntity.Manhom);
									
			
			
			
			try
			{
				r.SetField(Field_Tennhomnguyenlieu,_DmnhomnguyenlieuEntity.Tennhomnguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DmnhomnguyenlieuEntity.Tenrutgon);
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

		public DmnhomnguyenlieuEntity Insert(DmnhomnguyenlieuEntity DmnhomnguyenlieuEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmnhomnguyenlieuEntity, true);
			}
			return DmnhomnguyenlieuEntity;
		}

		public DmnhomnguyenlieuEntity Insert(System.String  Manhom, System.String  Tennhomnguyenlieu, System.String  Tenrutgon)
		{
			DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity = new DmnhomnguyenlieuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmnhomnguyenlieuEntity.Manhom = Manhom;
				
				_DmnhomnguyenlieuEntity.Tennhomnguyenlieu = Tennhomnguyenlieu;
				
				_DmnhomnguyenlieuEntity.Tenrutgon = Tenrutgon;
					
					
				adapter.SaveEntity(_DmnhomnguyenlieuEntity, true);
			}
			return _DmnhomnguyenlieuEntity;
		}

		public DmnhomnguyenlieuEntity Insert(System.String Tennhomnguyenlieu, System.String Tenrutgon)//ko co mahieu
		{
			DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity = new DmnhomnguyenlieuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmnhomnguyenlieuEntity.Tennhomnguyenlieu = Tennhomnguyenlieu;
				
				_DmnhomnguyenlieuEntity.Tenrutgon = Tenrutgon;
					

				adapter.SaveEntity(_DmnhomnguyenlieuEntity, true);
			}
			return _DmnhomnguyenlieuEntity;
		}

		public bool Update(DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmnhomnguyenlieuFields.Manhom == _DmnhomnguyenlieuEntity.Manhom);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmnhomnguyenlieuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmnhomnguyenlieuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Manhom, System.String Tennhomnguyenlieu, System.String Tenrutgon)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity = new DmnhomnguyenlieuEntity(Manhom);
				if (adapter.FetchEntity(_DmnhomnguyenlieuEntity))
				{
				
					
					
					_DmnhomnguyenlieuEntity.Tennhomnguyenlieu = Tennhomnguyenlieu;
					
					_DmnhomnguyenlieuEntity.Tenrutgon = Tenrutgon;
						

					adapter.SaveEntity(_DmnhomnguyenlieuEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Manhom)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity = new DmnhomnguyenlieuEntity(Manhom);
				if (adapter.FetchEntity(_DmnhomnguyenlieuEntity))
				{
					adapter.DeleteEntity(_DmnhomnguyenlieuEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmnhomnguyenlieuEntity", null);
			}
		}
		
		
		
		public int DeleteByManhom(System.String Manhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomnguyenlieuFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennhomnguyenlieu(System.String Tennhomnguyenlieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomnguyenlieuFields.Tennhomnguyenlieu == Tennhomnguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenrutgon(System.String Tenrutgon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomnguyenlieuFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmnhomnguyenlieuEntity SelectOne(System.String Manhom)
		{
			DmnhomnguyenlieuEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmnhomnguyenlieuEntity _DmnhomnguyenlieuEntity = new DmnhomnguyenlieuEntity(Manhom);
				if (adapter.FetchEntity(_DmnhomnguyenlieuEntity))
				{
					toReturn = _DmnhomnguyenlieuEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmnhomnguyenlieuCollection = new EntityCollection( new DmnhomnguyenlieuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomnguyenlieuCollection, null, 0, null);
			}
			return _DmnhomnguyenlieuCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomnguyenlieuCollection = new EntityCollection(new DmnhomnguyenlieuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByManhom(System.String Manhom)
		{
			EntityCollection _DmnhomnguyenlieuCollection = new EntityCollection(new DmnhomnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomnguyenlieuFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomnguyenlieuCollection, filter, 0, null);
			}
			return _DmnhomnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByManhomRDT(System.String Manhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomnguyenlieuCollection = new EntityCollection(new DmnhomnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomnguyenlieuFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennhomnguyenlieu(System.String Tennhomnguyenlieu)
		{
			EntityCollection _DmnhomnguyenlieuCollection = new EntityCollection(new DmnhomnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomnguyenlieuFields.Tennhomnguyenlieu == Tennhomnguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomnguyenlieuCollection, filter, 0, null);
			}
			return _DmnhomnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTennhomnguyenlieuRDT(System.String Tennhomnguyenlieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomnguyenlieuCollection = new EntityCollection(new DmnhomnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomnguyenlieuFields.Tennhomnguyenlieu == Tennhomnguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenrutgon(System.String Tenrutgon)
		{
			EntityCollection _DmnhomnguyenlieuCollection = new EntityCollection(new DmnhomnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomnguyenlieuFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomnguyenlieuCollection, filter, 0, null);
			}
			return _DmnhomnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTenrutgonRDT(System.String Tenrutgon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomnguyenlieuCollection = new EntityCollection(new DmnhomnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomnguyenlieuFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
