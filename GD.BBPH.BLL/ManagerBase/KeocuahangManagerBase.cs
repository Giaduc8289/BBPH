


/*
'===============================================================================
'  GD.BBPH.BL.KeocuahangManagerBase
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
	public class KeocuahangManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Masp="Masp";				
		
		public const String Field_Tensp="Tensp";				
		
		public const String Field_MakeoDongran="MakeoDongran";				
		
		public const String Field_TenkeoDongran="TenkeoDongran";				
		
		public const String Field_DinhmuckeoDongran="DinhmuckeoDongran";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KeocuahangManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Masp,typeof(System.String));
			
			dt.Columns.Add(Field_Tensp,typeof(System.String));
			
			dt.Columns.Add(Field_MakeoDongran,typeof(System.String));
			
			dt.Columns.Add(Field_TenkeoDongran,typeof(System.String));
			
			dt.Columns.Add(Field_DinhmuckeoDongran,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(KeocuahangEntity _KeocuahangEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_KeocuahangEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Masp]=_KeocuahangEntity.Masp;
			}
			catch { }
			
			try
			{
				r[Field_Tensp]=_KeocuahangEntity.Tensp;
			}
			catch { }
			
			try
			{
				r[Field_MakeoDongran]=_KeocuahangEntity.MakeoDongran;
			}
			catch { }
			
			try
			{
				r[Field_TenkeoDongran]=_KeocuahangEntity.TenkeoDongran;
			}
			catch { }
			
			try
			{
				r[Field_DinhmuckeoDongran]=_KeocuahangEntity.DinhmuckeoDongran;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_KeocuahangEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_KeocuahangEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_KeocuahangEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_KeocuahangEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public KeocuahangEntity Convert(DataRow r)
		{	
			
			KeocuahangEntity _KeocuahangEntity=new KeocuahangEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_KeocuahangEntity.Masp= r[Field_Masp].ToString();						
			}
			catch { }
			
			try
			{
				_KeocuahangEntity.Tensp= r[Field_Tensp].ToString();						
			}
			catch { }
			
			try
			{
				_KeocuahangEntity.MakeoDongran= r[Field_MakeoDongran].ToString();						
			}
			catch { }
			
			try
			{
				_KeocuahangEntity.TenkeoDongran= r[Field_TenkeoDongran].ToString();						
			}
			catch { }
			
			try
			{
				_KeocuahangEntity.DinhmuckeoDongran= System.Decimal.Parse(r[Field_DinhmuckeoDongran].ToString());						
			}
			catch { }
			
			try
			{
				_KeocuahangEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_KeocuahangEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_KeocuahangEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_KeocuahangEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _KeocuahangEntity;
		}			
		
		public KeocuahangEntity Convert_Entity(KeocuahangEntity _KeocuahangEntity,KeocuahangEntity _KeocuahangEntity_XML)
		{	
			
			
			_KeocuahangEntity.Id= _KeocuahangEntity_XML.Id;
			
			_KeocuahangEntity.Masp= _KeocuahangEntity_XML.Masp;
			
			_KeocuahangEntity.Tensp= _KeocuahangEntity_XML.Tensp;
			
			_KeocuahangEntity.MakeoDongran= _KeocuahangEntity_XML.MakeoDongran;
			
			_KeocuahangEntity.TenkeoDongran= _KeocuahangEntity_XML.TenkeoDongran;
			
			_KeocuahangEntity.DinhmuckeoDongran= _KeocuahangEntity_XML.DinhmuckeoDongran;
			
			_KeocuahangEntity.Ngaytao= _KeocuahangEntity_XML.Ngaytao;
			
			_KeocuahangEntity.Nguoitao= _KeocuahangEntity_XML.Nguoitao;
			
			_KeocuahangEntity.Ngaysua= _KeocuahangEntity_XML.Ngaysua;
			
			_KeocuahangEntity.Nguoisua= _KeocuahangEntity_XML.Nguoisua;
									
				
			return _KeocuahangEntity;
		}	
		
		public String InsertV2(KeocuahangEntity _KeocuahangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new KeocuahangManagerBase()).Insert(_KeocuahangEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_KeocuahangEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Masp,_KeocuahangEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensp,_KeocuahangEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_MakeoDongran,_KeocuahangEntity.MakeoDongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_TenkeoDongran,_KeocuahangEntity.TenkeoDongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_DinhmuckeoDongran,_KeocuahangEntity.DinhmuckeoDongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KeocuahangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KeocuahangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KeocuahangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KeocuahangEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(KeocuahangEntity _KeocuahangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new KeocuahangManagerBase()).Update(_KeocuahangEntity);
			r.SetField(Field_Id,_KeocuahangEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Masp,_KeocuahangEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensp,_KeocuahangEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_MakeoDongran,_KeocuahangEntity.MakeoDongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_TenkeoDongran,_KeocuahangEntity.TenkeoDongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_DinhmuckeoDongran,_KeocuahangEntity.DinhmuckeoDongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KeocuahangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KeocuahangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KeocuahangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KeocuahangEntity.Nguoisua);
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

		public KeocuahangEntity Insert(KeocuahangEntity KeocuahangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(KeocuahangEntity, true);
			}
			return KeocuahangEntity;
		}

		public KeocuahangEntity Insert(System.Int64  Id, System.String  Masp, System.String  Tensp, System.String  MakeoDongran, System.String  TenkeoDongran, System.Decimal  DinhmuckeoDongran, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			KeocuahangEntity _KeocuahangEntity = new KeocuahangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KeocuahangEntity.Id = Id;
				
				_KeocuahangEntity.Masp = Masp;
				
				_KeocuahangEntity.Tensp = Tensp;
				
				_KeocuahangEntity.MakeoDongran = MakeoDongran;
				
				_KeocuahangEntity.TenkeoDongran = TenkeoDongran;
				
				_KeocuahangEntity.DinhmuckeoDongran = DinhmuckeoDongran;
				
				_KeocuahangEntity.Ngaytao = Ngaytao;
				
				_KeocuahangEntity.Nguoitao = Nguoitao;
				
				_KeocuahangEntity.Ngaysua = Ngaysua;
				
				_KeocuahangEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_KeocuahangEntity, true);
			}
			return _KeocuahangEntity;
		}

		public KeocuahangEntity Insert(System.String Masp, System.String Tensp, System.String MakeoDongran, System.String TenkeoDongran, System.Decimal DinhmuckeoDongran, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			KeocuahangEntity _KeocuahangEntity = new KeocuahangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_KeocuahangEntity.Masp = Masp;
				
				_KeocuahangEntity.Tensp = Tensp;
				
				_KeocuahangEntity.MakeoDongran = MakeoDongran;
				
				_KeocuahangEntity.TenkeoDongran = TenkeoDongran;
				
				_KeocuahangEntity.DinhmuckeoDongran = DinhmuckeoDongran;
				
				_KeocuahangEntity.Ngaytao = Ngaytao;
				
				_KeocuahangEntity.Nguoitao = Nguoitao;
				
				_KeocuahangEntity.Ngaysua = Ngaysua;
				
				_KeocuahangEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_KeocuahangEntity, true);
			}
			return _KeocuahangEntity;
		}

		public bool Update(KeocuahangEntity _KeocuahangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(KeocuahangFields.Id == _KeocuahangEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KeocuahangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KeocuahangEntity _KeocuahangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KeocuahangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Masp, System.String Tensp, System.String MakeoDongran, System.String TenkeoDongran, System.Decimal DinhmuckeoDongran, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KeocuahangEntity _KeocuahangEntity = new KeocuahangEntity(Id);
				if (adapter.FetchEntity(_KeocuahangEntity))
				{
				
					
					
					_KeocuahangEntity.Masp = Masp;
					
					_KeocuahangEntity.Tensp = Tensp;
					
					_KeocuahangEntity.MakeoDongran = MakeoDongran;
					
					_KeocuahangEntity.TenkeoDongran = TenkeoDongran;
					
					_KeocuahangEntity.DinhmuckeoDongran = DinhmuckeoDongran;
					
					_KeocuahangEntity.Ngaytao = Ngaytao;
					
					_KeocuahangEntity.Nguoitao = Nguoitao;
					
					_KeocuahangEntity.Ngaysua = Ngaysua;
					
					_KeocuahangEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_KeocuahangEntity, true);
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
				KeocuahangEntity _KeocuahangEntity = new KeocuahangEntity(Id);
				if (adapter.FetchEntity(_KeocuahangEntity))
				{
					adapter.DeleteEntity(_KeocuahangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KeocuahangEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KeocuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasp(System.String Masp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KeocuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensp(System.String Tensp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KeocuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakeoDongran(System.String MakeoDongran)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.MakeoDongran == MakeoDongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KeocuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkeoDongran(System.String TenkeoDongran)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.TenkeoDongran == TenkeoDongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KeocuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDinhmuckeoDongran(System.Decimal DinhmuckeoDongran)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.DinhmuckeoDongran == DinhmuckeoDongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KeocuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KeocuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KeocuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KeocuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KeocuahangEntity", filter);
			}
			return toReturn;
		}		
			
		
		public KeocuahangEntity SelectOne(System.Int64 Id)
		{
			KeocuahangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KeocuahangEntity _KeocuahangEntity = new KeocuahangEntity(Id);
				if (adapter.FetchEntity(_KeocuahangEntity))
				{
					toReturn = _KeocuahangEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _KeocuahangCollection = new EntityCollection( new KeocuahangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KeocuahangCollection, null, 0, null);
			}
			return _KeocuahangCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KeocuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KeocuahangCollection, filter, 0, null);
			}
			return _KeocuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KeocuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasp(System.String Masp)
		{
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KeocuahangCollection, filter, 0, null);
			}
			return _KeocuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaspRDT(System.String Masp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KeocuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensp(System.String Tensp)
		{
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KeocuahangCollection, filter, 0, null);
			}
			return _KeocuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenspRDT(System.String Tensp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KeocuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakeoDongran(System.String MakeoDongran)
		{
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.MakeoDongran == MakeoDongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KeocuahangCollection, filter, 0, null);
			}
			return _KeocuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMakeoDongranRDT(System.String MakeoDongran)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.MakeoDongran == MakeoDongran);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KeocuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkeoDongran(System.String TenkeoDongran)
		{
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.TenkeoDongran == TenkeoDongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KeocuahangCollection, filter, 0, null);
			}
			return _KeocuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkeoDongranRDT(System.String TenkeoDongran)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.TenkeoDongran == TenkeoDongran);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KeocuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDinhmuckeoDongran(System.Decimal DinhmuckeoDongran)
		{
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.DinhmuckeoDongran == DinhmuckeoDongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KeocuahangCollection, filter, 0, null);
			}
			return _KeocuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByDinhmuckeoDongranRDT(System.Decimal DinhmuckeoDongran)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.DinhmuckeoDongran == DinhmuckeoDongran);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KeocuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KeocuahangCollection, filter, 0, null);
			}
			return _KeocuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KeocuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KeocuahangCollection, filter, 0, null);
			}
			return _KeocuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KeocuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KeocuahangCollection, filter, 0, null);
			}
			return _KeocuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KeocuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KeocuahangCollection, filter, 0, null);
			}
			return _KeocuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KeocuahangCollection = new EntityCollection(new KeocuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KeocuahangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KeocuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(KeocuahangFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
