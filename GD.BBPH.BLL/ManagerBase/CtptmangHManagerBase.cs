


/*
'===============================================================================
'  GD.BBPH.BL.CtptmangHManagerBase
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
	public class CtptmangHManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Mactpt="Mactpt";				
		
		public const String Field_Tenctpt="Tenctpt";				
		
		public const String Field_Ngayapdung="Ngayapdung";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CtptmangHManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Mactpt,typeof(System.String));
			
			dt.Columns.Add(Field_Tenctpt,typeof(System.String));
			
			dt.Columns.Add(Field_Ngayapdung,typeof(System.DateTime));
									
		            
			return dt;			
		}
		public DataRow Convert(CtptmangHEntity _CtptmangHEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_CtptmangHEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Mactpt]=_CtptmangHEntity.Mactpt;
			}
			catch { }
			
			try
			{
				r[Field_Tenctpt]=_CtptmangHEntity.Tenctpt;
			}
			catch { }
			
			try
			{
				r[Field_Ngayapdung]=_CtptmangHEntity.Ngayapdung;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public CtptmangHEntity Convert(DataRow r)
		{	
			
			CtptmangHEntity _CtptmangHEntity=new CtptmangHEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_CtptmangHEntity.Mactpt= r[Field_Mactpt].ToString();						
			}
			catch { }
			
			try
			{
				_CtptmangHEntity.Tenctpt= r[Field_Tenctpt].ToString();						
			}
			catch { }
			
			try
			{
				_CtptmangHEntity.Ngayapdung= System.DateTime.Parse(r[Field_Ngayapdung].ToString());						
			}
			catch { }
									
									
			return _CtptmangHEntity;
		}			
		
		public CtptmangHEntity Convert_Entity(CtptmangHEntity _CtptmangHEntity,CtptmangHEntity _CtptmangHEntity_XML)
		{	
			
			
			_CtptmangHEntity.Id= _CtptmangHEntity_XML.Id;
			
			_CtptmangHEntity.Mactpt= _CtptmangHEntity_XML.Mactpt;
			
			_CtptmangHEntity.Tenctpt= _CtptmangHEntity_XML.Tenctpt;
			
			_CtptmangHEntity.Ngayapdung= _CtptmangHEntity_XML.Ngayapdung;
									
				
			return _CtptmangHEntity;
		}	
		
		public String InsertV2(CtptmangHEntity _CtptmangHEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new CtptmangHManagerBase()).Insert(_CtptmangHEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_CtptmangHEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Mactpt,_CtptmangHEntity.Mactpt);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenctpt,_CtptmangHEntity.Tenctpt);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngayapdung,_CtptmangHEntity.Ngayapdung);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(CtptmangHEntity _CtptmangHEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new CtptmangHManagerBase()).Update(_CtptmangHEntity);
			r.SetField(Field_Id,_CtptmangHEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Mactpt,_CtptmangHEntity.Mactpt);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenctpt,_CtptmangHEntity.Tenctpt);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngayapdung,_CtptmangHEntity.Ngayapdung);
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

		public CtptmangHEntity Insert(CtptmangHEntity CtptmangHEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(CtptmangHEntity, true);
			}
			return CtptmangHEntity;
		}

		public CtptmangHEntity Insert(System.Int64  Id, System.String  Mactpt, System.String  Tenctpt, System.DateTime  Ngayapdung)
		{
			CtptmangHEntity _CtptmangHEntity = new CtptmangHEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CtptmangHEntity.Id = Id;
				
				_CtptmangHEntity.Mactpt = Mactpt;
				
				_CtptmangHEntity.Tenctpt = Tenctpt;
				
				_CtptmangHEntity.Ngayapdung = Ngayapdung;
					
					
				adapter.SaveEntity(_CtptmangHEntity, true);
			}
			return _CtptmangHEntity;
		}

		public CtptmangHEntity Insert(System.String Mactpt, System.String Tenctpt, System.DateTime Ngayapdung)//ko co mahieu
		{
			CtptmangHEntity _CtptmangHEntity = new CtptmangHEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_CtptmangHEntity.Mactpt = Mactpt;
				
				_CtptmangHEntity.Tenctpt = Tenctpt;
				
				_CtptmangHEntity.Ngayapdung = Ngayapdung;
					

				adapter.SaveEntity(_CtptmangHEntity, true);
			}
			return _CtptmangHEntity;
		}

		public bool Update(CtptmangHEntity _CtptmangHEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(CtptmangHFields.Id == _CtptmangHEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_CtptmangHEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(CtptmangHEntity _CtptmangHEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_CtptmangHEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Mactpt, System.String Tenctpt, System.DateTime Ngayapdung)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CtptmangHEntity _CtptmangHEntity = new CtptmangHEntity(Id);
				if (adapter.FetchEntity(_CtptmangHEntity))
				{
				
					
					
					_CtptmangHEntity.Mactpt = Mactpt;
					
					_CtptmangHEntity.Tenctpt = Tenctpt;
					
					_CtptmangHEntity.Ngayapdung = Ngayapdung;
						

					adapter.SaveEntity(_CtptmangHEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.Int64 Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CtptmangHEntity _CtptmangHEntity = new CtptmangHEntity(Id);
				if (adapter.FetchEntity(_CtptmangHEntity))
				{
					adapter.DeleteEntity(_CtptmangHEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("CtptmangHEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CtptmangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMactpt(System.String Mactpt)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Mactpt == Mactpt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CtptmangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenctpt(System.String Tenctpt)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Tenctpt == Tenctpt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CtptmangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgayapdung(System.DateTime Ngayapdung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Ngayapdung == Ngayapdung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CtptmangHEntity", filter);
			}
			return toReturn;
		}		
			
		
		public CtptmangHEntity SelectOne(System.Int64 Id)
		{
			CtptmangHEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CtptmangHEntity _CtptmangHEntity = new CtptmangHEntity(Id);
				if (adapter.FetchEntity(_CtptmangHEntity))
				{
					toReturn = _CtptmangHEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _CtptmangHCollection = new EntityCollection( new CtptmangHEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangHCollection, null, 0, null);
			}
			return _CtptmangHCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangHCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangHCollection, filter, 0, null);
			}
			return _CtptmangHCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMactpt(System.String Mactpt)
		{
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Mactpt == Mactpt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangHCollection, filter, 0, null);
			}
			return _CtptmangHCollection;
		}
		// Return DataTable
		public DataTable SelectByMactptRDT(System.String Mactpt)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Mactpt == Mactpt);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenctpt(System.String Tenctpt)
		{
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Tenctpt == Tenctpt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangHCollection, filter, 0, null);
			}
			return _CtptmangHCollection;
		}
		// Return DataTable
		public DataTable SelectByTenctptRDT(System.String Tenctpt)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Tenctpt == Tenctpt);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgayapdung(System.DateTime Ngayapdung)
		{
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Ngayapdung == Ngayapdung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangHCollection, filter, 0, null);
			}
			return _CtptmangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayapdungRDT(System.DateTime Ngayapdung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Ngayapdung == Ngayapdung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
