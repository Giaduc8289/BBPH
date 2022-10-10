


/*
'===============================================================================
'  GD.BBPH.BL.TruccuahangManagerBase
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
	public class TruccuahangManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Masp="Masp";				
		
		public const String Field_Tensp="Tensp";				
		
		public const String Field_Stttruc="Stttruc";				
		
		public const String Field_Matruc="Matruc";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TruccuahangManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Masp,typeof(System.String));
			
			dt.Columns.Add(Field_Tensp,typeof(System.String));
			
			dt.Columns.Add(Field_Stttruc,typeof(System.Int32));
			
			dt.Columns.Add(Field_Matruc,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(TruccuahangEntity _TruccuahangEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_TruccuahangEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Masp]=_TruccuahangEntity.Masp;
			}
			catch { }
			
			try
			{
				r[Field_Tensp]=_TruccuahangEntity.Tensp;
			}
			catch { }
			
			try
			{
				r[Field_Stttruc]=_TruccuahangEntity.Stttruc;
			}
			catch { }
			
			try
			{
				r[Field_Matruc]=_TruccuahangEntity.Matruc;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_TruccuahangEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_TruccuahangEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_TruccuahangEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_TruccuahangEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public TruccuahangEntity Convert(DataRow r)
		{	
			
			TruccuahangEntity _TruccuahangEntity=new TruccuahangEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_TruccuahangEntity.Masp= r[Field_Masp].ToString();						
			}
			catch { }
			
			try
			{
				_TruccuahangEntity.Tensp= r[Field_Tensp].ToString();						
			}
			catch { }
			
			try
			{
				_TruccuahangEntity.Stttruc= System.Int32.Parse(r[Field_Stttruc].ToString());						
			}
			catch { }
			
			try
			{
				_TruccuahangEntity.Matruc= r[Field_Matruc].ToString();						
			}
			catch { }
			
			try
			{
				_TruccuahangEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_TruccuahangEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_TruccuahangEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_TruccuahangEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _TruccuahangEntity;
		}			
		
		public TruccuahangEntity Convert_Entity(TruccuahangEntity _TruccuahangEntity,TruccuahangEntity _TruccuahangEntity_XML)
		{	
			
			
			_TruccuahangEntity.Id= _TruccuahangEntity_XML.Id;
			
			_TruccuahangEntity.Masp= _TruccuahangEntity_XML.Masp;
			
			_TruccuahangEntity.Tensp= _TruccuahangEntity_XML.Tensp;
			
			_TruccuahangEntity.Stttruc= _TruccuahangEntity_XML.Stttruc;
			
			_TruccuahangEntity.Matruc= _TruccuahangEntity_XML.Matruc;
			
			_TruccuahangEntity.Ngaytao= _TruccuahangEntity_XML.Ngaytao;
			
			_TruccuahangEntity.Nguoitao= _TruccuahangEntity_XML.Nguoitao;
			
			_TruccuahangEntity.Ngaysua= _TruccuahangEntity_XML.Ngaysua;
			
			_TruccuahangEntity.Nguoisua= _TruccuahangEntity_XML.Nguoisua;
									
				
			return _TruccuahangEntity;
		}	
		
		public String InsertV2(TruccuahangEntity _TruccuahangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new TruccuahangManagerBase()).Insert(_TruccuahangEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_TruccuahangEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Masp,_TruccuahangEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensp,_TruccuahangEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Stttruc,_TruccuahangEntity.Stttruc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Matruc,_TruccuahangEntity.Matruc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_TruccuahangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_TruccuahangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_TruccuahangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_TruccuahangEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(TruccuahangEntity _TruccuahangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new TruccuahangManagerBase()).Update(_TruccuahangEntity);
			r.SetField(Field_Id,_TruccuahangEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Masp,_TruccuahangEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensp,_TruccuahangEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Stttruc,_TruccuahangEntity.Stttruc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Matruc,_TruccuahangEntity.Matruc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_TruccuahangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_TruccuahangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_TruccuahangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_TruccuahangEntity.Nguoisua);
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

		public TruccuahangEntity Insert(TruccuahangEntity TruccuahangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(TruccuahangEntity, true);
			}
			return TruccuahangEntity;
		}

		public TruccuahangEntity Insert(System.Int64  Id, System.String  Masp, System.String  Tensp, System.Int32  Stttruc, System.String  Matruc, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			TruccuahangEntity _TruccuahangEntity = new TruccuahangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TruccuahangEntity.Id = Id;
				
				_TruccuahangEntity.Masp = Masp;
				
				_TruccuahangEntity.Tensp = Tensp;
				
				_TruccuahangEntity.Stttruc = Stttruc;
				
				_TruccuahangEntity.Matruc = Matruc;
				
				_TruccuahangEntity.Ngaytao = Ngaytao;
				
				_TruccuahangEntity.Nguoitao = Nguoitao;
				
				_TruccuahangEntity.Ngaysua = Ngaysua;
				
				_TruccuahangEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_TruccuahangEntity, true);
			}
			return _TruccuahangEntity;
		}

		public TruccuahangEntity Insert(System.String Masp, System.String Tensp, System.Int32 Stttruc, System.String Matruc, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			TruccuahangEntity _TruccuahangEntity = new TruccuahangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_TruccuahangEntity.Masp = Masp;
				
				_TruccuahangEntity.Tensp = Tensp;
				
				_TruccuahangEntity.Stttruc = Stttruc;
				
				_TruccuahangEntity.Matruc = Matruc;
				
				_TruccuahangEntity.Ngaytao = Ngaytao;
				
				_TruccuahangEntity.Nguoitao = Nguoitao;
				
				_TruccuahangEntity.Ngaysua = Ngaysua;
				
				_TruccuahangEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_TruccuahangEntity, true);
			}
			return _TruccuahangEntity;
		}

		public bool Update(TruccuahangEntity _TruccuahangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(TruccuahangFields.Id == _TruccuahangEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_TruccuahangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(TruccuahangEntity _TruccuahangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_TruccuahangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Masp, System.String Tensp, System.Int32 Stttruc, System.String Matruc, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TruccuahangEntity _TruccuahangEntity = new TruccuahangEntity(Id);
				if (adapter.FetchEntity(_TruccuahangEntity))
				{
				
					
					
					_TruccuahangEntity.Masp = Masp;
					
					_TruccuahangEntity.Tensp = Tensp;
					
					_TruccuahangEntity.Stttruc = Stttruc;
					
					_TruccuahangEntity.Matruc = Matruc;
					
					_TruccuahangEntity.Ngaytao = Ngaytao;
					
					_TruccuahangEntity.Nguoitao = Nguoitao;
					
					_TruccuahangEntity.Ngaysua = Ngaysua;
					
					_TruccuahangEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_TruccuahangEntity, true);
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
				TruccuahangEntity _TruccuahangEntity = new TruccuahangEntity(Id);
				if (adapter.FetchEntity(_TruccuahangEntity))
				{
					adapter.DeleteEntity(_TruccuahangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("TruccuahangEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasp(System.String Masp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensp(System.String Tensp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByStttruc(System.Int32 Stttruc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Stttruc == Stttruc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMatruc(System.String Matruc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Matruc == Matruc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TruccuahangEntity", filter);
			}
			return toReturn;
		}		
			
		
		public TruccuahangEntity SelectOne(System.Int64 Id)
		{
			TruccuahangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TruccuahangEntity _TruccuahangEntity = new TruccuahangEntity(Id);
				if (adapter.FetchEntity(_TruccuahangEntity))
				{
					toReturn = _TruccuahangEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _TruccuahangCollection = new EntityCollection( new TruccuahangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TruccuahangCollection, null, 0, null);
			}
			return _TruccuahangCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TruccuahangCollection, filter, 0, null);
			}
			return _TruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasp(System.String Masp)
		{
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TruccuahangCollection, filter, 0, null);
			}
			return _TruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaspRDT(System.String Masp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensp(System.String Tensp)
		{
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TruccuahangCollection, filter, 0, null);
			}
			return _TruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenspRDT(System.String Tensp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByStttruc(System.Int32 Stttruc)
		{
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Stttruc == Stttruc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TruccuahangCollection, filter, 0, null);
			}
			return _TruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByStttrucRDT(System.Int32 Stttruc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Stttruc == Stttruc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMatruc(System.String Matruc)
		{
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Matruc == Matruc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TruccuahangCollection, filter, 0, null);
			}
			return _TruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMatrucRDT(System.String Matruc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Matruc == Matruc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TruccuahangCollection, filter, 0, null);
			}
			return _TruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TruccuahangCollection, filter, 0, null);
			}
			return _TruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TruccuahangCollection, filter, 0, null);
			}
			return _TruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TruccuahangCollection, filter, 0, null);
			}
			return _TruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TruccuahangCollection = new EntityCollection(new TruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TruccuahangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
