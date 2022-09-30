


/*
'===============================================================================
'  GD.BBPH.BL.DmmangManagerBase
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
	public class DmmangManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Mamang="Mamang";				
		
		public const String Field_Tenmang="Tenmang";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Kichthuoc="Kichthuoc";				
		
		public const String Field_Trongluong="Trongluong";				
		
		public const String Field_Mactpt="Mactpt";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmmangManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Mamang,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmang,typeof(System.String));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Kichthuoc,typeof(System.String));
			
			dt.Columns.Add(Field_Trongluong,typeof(System.String));
			
			dt.Columns.Add(Field_Mactpt,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmmangEntity _DmmangEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mamang]=_DmmangEntity.Mamang;
			}
			catch { }
			
			try
			{
				r[Field_Tenmang]=_DmmangEntity.Tenmang;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_DmmangEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_DmmangEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Kichthuoc]=_DmmangEntity.Kichthuoc;
			}
			catch { }
			
			try
			{
				r[Field_Trongluong]=_DmmangEntity.Trongluong;
			}
			catch { }
			
			try
			{
				r[Field_Mactpt]=_DmmangEntity.Mactpt;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmmangEntity Convert(DataRow r)
		{	
			
			DmmangEntity _DmmangEntity=new DmmangEntity(r[Field_Mamang].ToString());					
						
			
			
			try
			{
				_DmmangEntity.Tenmang= r[Field_Tenmang].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Kichthuoc= r[Field_Kichthuoc].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Trongluong= r[Field_Trongluong].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Mactpt= r[Field_Mactpt].ToString();						
			}
			catch { }
									
									
			return _DmmangEntity;
		}			
		
		public DmmangEntity Convert_Entity(DmmangEntity _DmmangEntity,DmmangEntity _DmmangEntity_XML)
		{	
			
			
			_DmmangEntity.Mamang= _DmmangEntity_XML.Mamang;
			
			_DmmangEntity.Tenmang= _DmmangEntity_XML.Tenmang;
			
			_DmmangEntity.Makhach= _DmmangEntity_XML.Makhach;
			
			_DmmangEntity.Tenkhach= _DmmangEntity_XML.Tenkhach;
			
			_DmmangEntity.Kichthuoc= _DmmangEntity_XML.Kichthuoc;
			
			_DmmangEntity.Trongluong= _DmmangEntity_XML.Trongluong;
			
			_DmmangEntity.Mactpt= _DmmangEntity_XML.Mactpt;
									
				
			return _DmmangEntity;
		}	
		
		public String InsertV2(DmmangEntity _DmmangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmmangManagerBase()).Insert(_DmmangEntity).Mamang.ToString();
			
			
			try
			{
				r.SetField(Field_Mamang,_DmmangEntity.Mamang);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenmang,_DmmangEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_DmmangEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_DmmangEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kichthuoc,_DmmangEntity.Kichthuoc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trongluong,_DmmangEntity.Trongluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mactpt,_DmmangEntity.Mactpt);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmmangEntity _DmmangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmmangManagerBase()).Update(_DmmangEntity);
			r.SetField(Field_Mamang,_DmmangEntity.Mamang);
									
			
			
			
			try
			{
				r.SetField(Field_Tenmang,_DmmangEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_DmmangEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_DmmangEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kichthuoc,_DmmangEntity.Kichthuoc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trongluong,_DmmangEntity.Trongluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mactpt,_DmmangEntity.Mactpt);
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

		public DmmangEntity Insert(DmmangEntity DmmangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmmangEntity, true);
			}
			return DmmangEntity;
		}

		public DmmangEntity Insert(System.String  Mamang, System.String  Tenmang, System.String  Makhach, System.String  Tenkhach, System.String  Kichthuoc, System.String  Trongluong, System.String  Mactpt)
		{
			DmmangEntity _DmmangEntity = new DmmangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmmangEntity.Mamang = Mamang;
				
				_DmmangEntity.Tenmang = Tenmang;
				
				_DmmangEntity.Makhach = Makhach;
				
				_DmmangEntity.Tenkhach = Tenkhach;
				
				_DmmangEntity.Kichthuoc = Kichthuoc;
				
				_DmmangEntity.Trongluong = Trongluong;
				
				_DmmangEntity.Mactpt = Mactpt;
					
					
				adapter.SaveEntity(_DmmangEntity, true);
			}
			return _DmmangEntity;
		}

		public DmmangEntity Insert(System.String Tenmang, System.String Makhach, System.String Tenkhach, System.String Kichthuoc, System.String Trongluong, System.String Mactpt)//ko co mahieu
		{
			DmmangEntity _DmmangEntity = new DmmangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmmangEntity.Tenmang = Tenmang;
				
				_DmmangEntity.Makhach = Makhach;
				
				_DmmangEntity.Tenkhach = Tenkhach;
				
				_DmmangEntity.Kichthuoc = Kichthuoc;
				
				_DmmangEntity.Trongluong = Trongluong;
				
				_DmmangEntity.Mactpt = Mactpt;
					

				adapter.SaveEntity(_DmmangEntity, true);
			}
			return _DmmangEntity;
		}

		public bool Update(DmmangEntity _DmmangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmmangFields.Mamang == _DmmangEntity.Mamang);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmmangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmmangEntity _DmmangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmmangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mamang, System.String Tenmang, System.String Makhach, System.String Tenkhach, System.String Kichthuoc, System.String Trongluong, System.String Mactpt)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmmangEntity _DmmangEntity = new DmmangEntity(Mamang);
				if (adapter.FetchEntity(_DmmangEntity))
				{
				
					
					
					_DmmangEntity.Tenmang = Tenmang;
					
					_DmmangEntity.Makhach = Makhach;
					
					_DmmangEntity.Tenkhach = Tenkhach;
					
					_DmmangEntity.Kichthuoc = Kichthuoc;
					
					_DmmangEntity.Trongluong = Trongluong;
					
					_DmmangEntity.Mactpt = Mactpt;
						

					adapter.SaveEntity(_DmmangEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Mamang)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmmangEntity _DmmangEntity = new DmmangEntity(Mamang);
				if (adapter.FetchEntity(_DmmangEntity))
				{
					adapter.DeleteEntity(_DmmangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmmangEntity", null);
			}
		}
		
		
		
		public int DeleteByMamang(System.String Mamang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmang(System.String Tenmang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKichthuoc(System.String Kichthuoc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTrongluong(System.String Trongluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMactpt(System.String Mactpt)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Mactpt == Mactpt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmmangEntity SelectOne(System.String Mamang)
		{
			DmmangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmmangEntity _DmmangEntity = new DmmangEntity(Mamang);
				if (adapter.FetchEntity(_DmmangEntity))
				{
					toReturn = _DmmangEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmmangCollection = new EntityCollection( new DmmangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, null, 0, null);
			}
			return _DmmangCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMamang(System.String Mamang)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByMamangRDT(System.String Mamang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmang(System.String Tenmang)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmangRDT(System.String Tenmang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKichthuoc(System.String Kichthuoc)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByKichthuocRDT(System.String Kichthuoc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTrongluong(System.String Trongluong)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByTrongluongRDT(System.String Trongluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMactpt(System.String Mactpt)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Mactpt == Mactpt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByMactptRDT(System.String Mactpt)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Mactpt == Mactpt);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
