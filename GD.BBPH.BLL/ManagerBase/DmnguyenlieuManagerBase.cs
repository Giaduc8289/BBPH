


/*
'===============================================================================
'  GD.BBPH.BL.DmnguyenlieuManagerBase
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
	public class DmnguyenlieuManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Manl="Manl";				
		
		public const String Field_Tenrutgon="Tenrutgon";				
		
		public const String Field_Manhom="Manhom";				
		
		public const String Field_Tennhom="Tennhom";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmnguyenlieuManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Manl,typeof(System.String));
			
			dt.Columns.Add(Field_Tenrutgon,typeof(System.String));
			
			dt.Columns.Add(Field_Manhom,typeof(System.String));
			
			dt.Columns.Add(Field_Tennhom,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmnguyenlieuEntity _DmnguyenlieuEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Manl]=_DmnguyenlieuEntity.Manl;
			}
			catch { }
			
			try
			{
				r[Field_Tenrutgon]=_DmnguyenlieuEntity.Tenrutgon;
			}
			catch { }
			
			try
			{
				r[Field_Manhom]=_DmnguyenlieuEntity.Manhom;
			}
			catch { }
			
			try
			{
				r[Field_Tennhom]=_DmnguyenlieuEntity.Tennhom;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmnguyenlieuEntity Convert(DataRow r)
		{	
			
			DmnguyenlieuEntity _DmnguyenlieuEntity=new DmnguyenlieuEntity(r[Field_Manl].ToString());					
						
			
			
			try
			{
				_DmnguyenlieuEntity.Tenrutgon= r[Field_Tenrutgon].ToString();						
			}
			catch { }
			
			try
			{
				_DmnguyenlieuEntity.Manhom= r[Field_Manhom].ToString();						
			}
			catch { }
			
			try
			{
				_DmnguyenlieuEntity.Tennhom= r[Field_Tennhom].ToString();						
			}
			catch { }
									
									
			return _DmnguyenlieuEntity;
		}			
		
		public DmnguyenlieuEntity Convert_Entity(DmnguyenlieuEntity _DmnguyenlieuEntity,DmnguyenlieuEntity _DmnguyenlieuEntity_XML)
		{	
			
			
			_DmnguyenlieuEntity.Manl= _DmnguyenlieuEntity_XML.Manl;
			
			_DmnguyenlieuEntity.Tenrutgon= _DmnguyenlieuEntity_XML.Tenrutgon;
			
			_DmnguyenlieuEntity.Manhom= _DmnguyenlieuEntity_XML.Manhom;
			
			_DmnguyenlieuEntity.Tennhom= _DmnguyenlieuEntity_XML.Tennhom;
									
				
			return _DmnguyenlieuEntity;
		}	
		
		public String InsertV2(DmnguyenlieuEntity _DmnguyenlieuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmnguyenlieuManagerBase()).Insert(_DmnguyenlieuEntity).Manl.ToString();
			
			
			try
			{
				r.SetField(Field_Manl,_DmnguyenlieuEntity.Manl);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenrutgon,_DmnguyenlieuEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manhom,_DmnguyenlieuEntity.Manhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennhom,_DmnguyenlieuEntity.Tennhom);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmnguyenlieuEntity _DmnguyenlieuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmnguyenlieuManagerBase()).Update(_DmnguyenlieuEntity);
			r.SetField(Field_Manl,_DmnguyenlieuEntity.Manl);
									
			
			
			
			try
			{
				r.SetField(Field_Tenrutgon,_DmnguyenlieuEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manhom,_DmnguyenlieuEntity.Manhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennhom,_DmnguyenlieuEntity.Tennhom);
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

		public DmnguyenlieuEntity Insert(DmnguyenlieuEntity DmnguyenlieuEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmnguyenlieuEntity, true);
			}
			return DmnguyenlieuEntity;
		}

		public DmnguyenlieuEntity Insert(System.String  Manl, System.String  Tenrutgon, System.String  Manhom, System.String  Tennhom)
		{
			DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmnguyenlieuEntity.Manl = Manl;
				
				_DmnguyenlieuEntity.Tenrutgon = Tenrutgon;
				
				_DmnguyenlieuEntity.Manhom = Manhom;
				
				_DmnguyenlieuEntity.Tennhom = Tennhom;
					
					
				adapter.SaveEntity(_DmnguyenlieuEntity, true);
			}
			return _DmnguyenlieuEntity;
		}

		public DmnguyenlieuEntity Insert(System.String Tenrutgon, System.String Manhom, System.String Tennhom)//ko co mahieu
		{
			DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmnguyenlieuEntity.Tenrutgon = Tenrutgon;
				
				_DmnguyenlieuEntity.Manhom = Manhom;
				
				_DmnguyenlieuEntity.Tennhom = Tennhom;
					

				adapter.SaveEntity(_DmnguyenlieuEntity, true);
			}
			return _DmnguyenlieuEntity;
		}

		public bool Update(DmnguyenlieuEntity _DmnguyenlieuEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmnguyenlieuFields.Manl == _DmnguyenlieuEntity.Manl);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmnguyenlieuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmnguyenlieuEntity _DmnguyenlieuEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmnguyenlieuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Manl, System.String Tenrutgon, System.String Manhom, System.String Tennhom)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity(Manl);
				if (adapter.FetchEntity(_DmnguyenlieuEntity))
				{
				
					
					
					_DmnguyenlieuEntity.Tenrutgon = Tenrutgon;
					
					_DmnguyenlieuEntity.Manhom = Manhom;
					
					_DmnguyenlieuEntity.Tennhom = Tennhom;
						

					adapter.SaveEntity(_DmnguyenlieuEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Manl)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity(Manl);
				if (adapter.FetchEntity(_DmnguyenlieuEntity))
				{
					adapter.DeleteEntity(_DmnguyenlieuEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", null);
			}
		}
		
		
		
		public int DeleteByManl(System.String Manl)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Manl == Manl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenrutgon(System.String Tenrutgon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByManhom(System.String Manhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennhom(System.String Tennhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnguyenlieuEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmnguyenlieuEntity SelectOne(System.String Manl)
		{
			DmnguyenlieuEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity(Manl);
				if (adapter.FetchEntity(_DmnguyenlieuEntity))
				{
					toReturn = _DmnguyenlieuEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection( new DmnguyenlieuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, null, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByManl(System.String Manl)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Manl == Manl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByManlRDT(System.String Manl)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Manl == Manl);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenrutgon(System.String Tenrutgon)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTenrutgonRDT(System.String Tenrutgon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByManhom(System.String Manhom)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByManhomRDT(System.String Manhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennhom(System.String Tennhom)
		{
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnguyenlieuCollection, filter, 0, null);
			}
			return _DmnguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTennhomRDT(System.String Tennhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnguyenlieuCollection = new EntityCollection(new DmnguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnguyenlieuFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
