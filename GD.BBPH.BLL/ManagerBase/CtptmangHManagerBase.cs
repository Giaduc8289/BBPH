


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
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
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
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
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
			
			try
			{
				r[Field_Ngaytao]=_CtptmangHEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_CtptmangHEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_CtptmangHEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_CtptmangHEntity.Nguoisua;
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
			
			try
			{
				_CtptmangHEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_CtptmangHEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_CtptmangHEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_CtptmangHEntity.Nguoisua= r[Field_Nguoisua].ToString();						
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
			
			_CtptmangHEntity.Ngaytao= _CtptmangHEntity_XML.Ngaytao;
			
			_CtptmangHEntity.Nguoitao= _CtptmangHEntity_XML.Nguoitao;
			
			_CtptmangHEntity.Ngaysua= _CtptmangHEntity_XML.Ngaysua;
			
			_CtptmangHEntity.Nguoisua= _CtptmangHEntity_XML.Nguoisua;
									
				
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
			
			try
			{
				r.SetField(Field_Ngaytao,_CtptmangHEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_CtptmangHEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_CtptmangHEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_CtptmangHEntity.Nguoisua);
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
			
			try
			{
				r.SetField(Field_Ngaytao,_CtptmangHEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_CtptmangHEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_CtptmangHEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_CtptmangHEntity.Nguoisua);
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

		public CtptmangHEntity Insert(System.Int64  Id, System.String  Mactpt, System.String  Tenctpt, System.DateTime  Ngayapdung, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			CtptmangHEntity _CtptmangHEntity = new CtptmangHEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CtptmangHEntity.Id = Id;
				
				_CtptmangHEntity.Mactpt = Mactpt;
				
				_CtptmangHEntity.Tenctpt = Tenctpt;
				
				_CtptmangHEntity.Ngayapdung = Ngayapdung;
				
				_CtptmangHEntity.Ngaytao = Ngaytao;
				
				_CtptmangHEntity.Nguoitao = Nguoitao;
				
				_CtptmangHEntity.Ngaysua = Ngaysua;
				
				_CtptmangHEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_CtptmangHEntity, true);
			}
			return _CtptmangHEntity;
		}

		public CtptmangHEntity Insert(System.String Mactpt, System.String Tenctpt, System.DateTime Ngayapdung, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			CtptmangHEntity _CtptmangHEntity = new CtptmangHEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_CtptmangHEntity.Mactpt = Mactpt;
				
				_CtptmangHEntity.Tenctpt = Tenctpt;
				
				_CtptmangHEntity.Ngayapdung = Ngayapdung;
				
				_CtptmangHEntity.Ngaytao = Ngaytao;
				
				_CtptmangHEntity.Nguoitao = Nguoitao;
				
				_CtptmangHEntity.Ngaysua = Ngaysua;
				
				_CtptmangHEntity.Nguoisua = Nguoisua;
					

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

		public bool Update(System.Int64 Id, System.String Mactpt, System.String Tenctpt, System.DateTime Ngayapdung, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
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
					
					_CtptmangHEntity.Ngaytao = Ngaytao;
					
					_CtptmangHEntity.Nguoitao = Nguoitao;
					
					_CtptmangHEntity.Ngaysua = Ngaysua;
					
					_CtptmangHEntity.Nguoisua = Nguoisua;
						

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
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CtptmangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CtptmangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CtptmangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Nguoisua == Nguoisua);
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
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangHCollection, filter, 0, null);
			}
			return _CtptmangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangHCollection, filter, 0, null);
			}
			return _CtptmangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangHCollection, filter, 0, null);
			}
			return _CtptmangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangHCollection, filter, 0, null);
			}
			return _CtptmangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangHCollection = new EntityCollection(new CtptmangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangHFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(CtptmangHFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
