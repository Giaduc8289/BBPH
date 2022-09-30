


/*
'===============================================================================
'  GD.BBPH.BL.DmmayManagerBase
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
	public class DmmayManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Mamay="Mamay";				
		
		public const String Field_Tenmay="Tenmay";				
		
		public const String Field_Madm="Madm";				
		
		public const String Field_Vitri="Vitri";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmmayManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Mamay,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmay,typeof(System.String));
			
			dt.Columns.Add(Field_Madm,typeof(System.String));
			
			dt.Columns.Add(Field_Vitri,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmmayEntity _DmmayEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mamay]=_DmmayEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_Tenmay]=_DmmayEntity.Tenmay;
			}
			catch { }
			
			try
			{
				r[Field_Madm]=_DmmayEntity.Madm;
			}
			catch { }
			
			try
			{
				r[Field_Vitri]=_DmmayEntity.Vitri;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmmayEntity Convert(DataRow r)
		{	
			
			DmmayEntity _DmmayEntity=new DmmayEntity(r[Field_Mamay].ToString());					
						
			
			
			try
			{
				_DmmayEntity.Tenmay= r[Field_Tenmay].ToString();						
			}
			catch { }
			
			try
			{
				_DmmayEntity.Madm= r[Field_Madm].ToString();						
			}
			catch { }
			
			try
			{
				_DmmayEntity.Vitri= r[Field_Vitri].ToString();						
			}
			catch { }
									
									
			return _DmmayEntity;
		}			
		
		public DmmayEntity Convert_Entity(DmmayEntity _DmmayEntity,DmmayEntity _DmmayEntity_XML)
		{	
			
			
			_DmmayEntity.Mamay= _DmmayEntity_XML.Mamay;
			
			_DmmayEntity.Tenmay= _DmmayEntity_XML.Tenmay;
			
			_DmmayEntity.Madm= _DmmayEntity_XML.Madm;
			
			_DmmayEntity.Vitri= _DmmayEntity_XML.Vitri;
									
				
			return _DmmayEntity;
		}	
		
		public String InsertV2(DmmayEntity _DmmayEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmmayManagerBase()).Insert(_DmmayEntity).Mamay.ToString();
			
			
			try
			{
				r.SetField(Field_Mamay,_DmmayEntity.Mamay);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenmay,_DmmayEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madm,_DmmayEntity.Madm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Vitri,_DmmayEntity.Vitri);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmmayEntity _DmmayEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmmayManagerBase()).Update(_DmmayEntity);
			r.SetField(Field_Mamay,_DmmayEntity.Mamay);
									
			
			
			
			try
			{
				r.SetField(Field_Tenmay,_DmmayEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madm,_DmmayEntity.Madm);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Vitri,_DmmayEntity.Vitri);
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

		public DmmayEntity Insert(DmmayEntity DmmayEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmmayEntity, true);
			}
			return DmmayEntity;
		}

		public DmmayEntity Insert(System.String  Mamay, System.String  Tenmay, System.String  Madm, System.String  Vitri)
		{
			DmmayEntity _DmmayEntity = new DmmayEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmmayEntity.Mamay = Mamay;
				
				_DmmayEntity.Tenmay = Tenmay;
				
				_DmmayEntity.Madm = Madm;
				
				_DmmayEntity.Vitri = Vitri;
					
					
				adapter.SaveEntity(_DmmayEntity, true);
			}
			return _DmmayEntity;
		}

		public DmmayEntity Insert(System.String Tenmay, System.String Madm, System.String Vitri)//ko co mahieu
		{
			DmmayEntity _DmmayEntity = new DmmayEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmmayEntity.Tenmay = Tenmay;
				
				_DmmayEntity.Madm = Madm;
				
				_DmmayEntity.Vitri = Vitri;
					

				adapter.SaveEntity(_DmmayEntity, true);
			}
			return _DmmayEntity;
		}

		public bool Update(DmmayEntity _DmmayEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmmayFields.Mamay == _DmmayEntity.Mamay);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmmayEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmmayEntity _DmmayEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmmayEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mamay, System.String Tenmay, System.String Madm, System.String Vitri)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmmayEntity _DmmayEntity = new DmmayEntity(Mamay);
				if (adapter.FetchEntity(_DmmayEntity))
				{
				
					
					
					_DmmayEntity.Tenmay = Tenmay;
					
					_DmmayEntity.Madm = Madm;
					
					_DmmayEntity.Vitri = Vitri;
						

					adapter.SaveEntity(_DmmayEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Mamay)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmmayEntity _DmmayEntity = new DmmayEntity(Mamay);
				if (adapter.FetchEntity(_DmmayEntity))
				{
					adapter.DeleteEntity(_DmmayEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmmayEntity", null);
			}
		}
		
		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmayFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmay(System.String Tenmay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmayFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMadm(System.String Madm)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmayFields.Madm == Madm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmayEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByVitri(System.String Vitri)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmayFields.Vitri == Vitri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmayEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmmayEntity SelectOne(System.String Mamay)
		{
			DmmayEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmmayEntity _DmmayEntity = new DmmayEntity(Mamay);
				if (adapter.FetchEntity(_DmmayEntity))
				{
					toReturn = _DmmayEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmmayCollection = new EntityCollection( new DmmayEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmayCollection, null, 0, null);
			}
			return _DmmayCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmayCollection = new EntityCollection(new DmmayEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmayCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _DmmayCollection = new EntityCollection(new DmmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmayFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmayCollection, filter, 0, null);
			}
			return _DmmayCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmayCollection = new EntityCollection(new DmmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmayFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmay(System.String Tenmay)
		{
			EntityCollection _DmmayCollection = new EntityCollection(new DmmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmayFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmayCollection, filter, 0, null);
			}
			return _DmmayCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmayRDT(System.String Tenmay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmayCollection = new EntityCollection(new DmmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmayFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMadm(System.String Madm)
		{
			EntityCollection _DmmayCollection = new EntityCollection(new DmmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmayFields.Madm == Madm);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmayCollection, filter, 0, null);
			}
			return _DmmayCollection;
		}
		// Return DataTable
		public DataTable SelectByMadmRDT(System.String Madm)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmayCollection = new EntityCollection(new DmmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmayFields.Madm == Madm);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByVitri(System.String Vitri)
		{
			EntityCollection _DmmayCollection = new EntityCollection(new DmmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmayFields.Vitri == Vitri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmayCollection, filter, 0, null);
			}
			return _DmmayCollection;
		}
		// Return DataTable
		public DataTable SelectByVitriRDT(System.String Vitri)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmayCollection = new EntityCollection(new DmmayEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmayFields.Vitri == Vitri);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmayCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
