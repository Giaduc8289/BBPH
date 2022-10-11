


/*
'===============================================================================
'  GD.BBPH.BL.KetquainmauManagerBase
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
	public class KetquainmauManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_KetquainId="KetquainId";				
		
		public const String Field_Masp="Masp";				
		
		public const String Field_Tensp="Tensp";				
		
		public const String Field_Mamau="Mamau";				
		
		public const String Field_Tenmau="Tenmau";				
		
		public const String Field_Xuatdodang="Xuatdodang";				
		
		public const String Field_Xuatnguyen="Xuatnguyen";				
		
		public const String Field_Nhapdodang="Nhapdodang";				
		
		public const String Field_Nhapnguyen="Nhapnguyen";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquainmauManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_KetquainId,typeof(System.Int64));
			
			dt.Columns.Add(Field_Masp,typeof(System.String));
			
			dt.Columns.Add(Field_Tensp,typeof(System.String));
			
			dt.Columns.Add(Field_Mamau,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmau,typeof(System.String));
			
			dt.Columns.Add(Field_Xuatdodang,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Xuatnguyen,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Nhapdodang,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Nhapnguyen,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(KetquainmauEntity _KetquainmauEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_KetquainmauEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_KetquainId]=_KetquainmauEntity.KetquainId;
			}
			catch { }
			
			try
			{
				r[Field_Masp]=_KetquainmauEntity.Masp;
			}
			catch { }
			
			try
			{
				r[Field_Tensp]=_KetquainmauEntity.Tensp;
			}
			catch { }
			
			try
			{
				r[Field_Mamau]=_KetquainmauEntity.Mamau;
			}
			catch { }
			
			try
			{
				r[Field_Tenmau]=_KetquainmauEntity.Tenmau;
			}
			catch { }
			
			try
			{
				r[Field_Xuatdodang]=_KetquainmauEntity.Xuatdodang;
			}
			catch { }
			
			try
			{
				r[Field_Xuatnguyen]=_KetquainmauEntity.Xuatnguyen;
			}
			catch { }
			
			try
			{
				r[Field_Nhapdodang]=_KetquainmauEntity.Nhapdodang;
			}
			catch { }
			
			try
			{
				r[Field_Nhapnguyen]=_KetquainmauEntity.Nhapnguyen;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_KetquainmauEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_KetquainmauEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_KetquainmauEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_KetquainmauEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public KetquainmauEntity Convert(DataRow r)
		{	
			
			KetquainmauEntity _KetquainmauEntity=new KetquainmauEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_KetquainmauEntity.KetquainId= System.Int64.Parse(r[Field_KetquainId].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainmauEntity.Masp= r[Field_Masp].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainmauEntity.Tensp= r[Field_Tensp].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainmauEntity.Mamau= r[Field_Mamau].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainmauEntity.Tenmau= r[Field_Tenmau].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainmauEntity.Xuatdodang= System.Decimal.Parse(r[Field_Xuatdodang].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainmauEntity.Xuatnguyen= System.Decimal.Parse(r[Field_Xuatnguyen].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainmauEntity.Nhapdodang= System.Decimal.Parse(r[Field_Nhapdodang].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainmauEntity.Nhapnguyen= System.Decimal.Parse(r[Field_Nhapnguyen].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainmauEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainmauEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_KetquainmauEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_KetquainmauEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _KetquainmauEntity;
		}			
		
		public KetquainmauEntity Convert_Entity(KetquainmauEntity _KetquainmauEntity,KetquainmauEntity _KetquainmauEntity_XML)
		{	
			
			
			_KetquainmauEntity.Id= _KetquainmauEntity_XML.Id;
			
			_KetquainmauEntity.KetquainId= _KetquainmauEntity_XML.KetquainId;
			
			_KetquainmauEntity.Masp= _KetquainmauEntity_XML.Masp;
			
			_KetquainmauEntity.Tensp= _KetquainmauEntity_XML.Tensp;
			
			_KetquainmauEntity.Mamau= _KetquainmauEntity_XML.Mamau;
			
			_KetquainmauEntity.Tenmau= _KetquainmauEntity_XML.Tenmau;
			
			_KetquainmauEntity.Xuatdodang= _KetquainmauEntity_XML.Xuatdodang;
			
			_KetquainmauEntity.Xuatnguyen= _KetquainmauEntity_XML.Xuatnguyen;
			
			_KetquainmauEntity.Nhapdodang= _KetquainmauEntity_XML.Nhapdodang;
			
			_KetquainmauEntity.Nhapnguyen= _KetquainmauEntity_XML.Nhapnguyen;
			
			_KetquainmauEntity.Ngaytao= _KetquainmauEntity_XML.Ngaytao;
			
			_KetquainmauEntity.Nguoitao= _KetquainmauEntity_XML.Nguoitao;
			
			_KetquainmauEntity.Ngaysua= _KetquainmauEntity_XML.Ngaysua;
			
			_KetquainmauEntity.Nguoisua= _KetquainmauEntity_XML.Nguoisua;
									
				
			return _KetquainmauEntity;
		}	
		
		public String InsertV2(KetquainmauEntity _KetquainmauEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new KetquainmauManagerBase()).Insert(_KetquainmauEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_KetquainmauEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_KetquainId,_KetquainmauEntity.KetquainId);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masp,_KetquainmauEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensp,_KetquainmauEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamau,_KetquainmauEntity.Mamau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmau,_KetquainmauEntity.Tenmau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Xuatdodang,_KetquainmauEntity.Xuatdodang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Xuatnguyen,_KetquainmauEntity.Xuatnguyen);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nhapdodang,_KetquainmauEntity.Nhapdodang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nhapnguyen,_KetquainmauEntity.Nhapnguyen);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquainmauEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquainmauEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquainmauEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquainmauEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(KetquainmauEntity _KetquainmauEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new KetquainmauManagerBase()).Update(_KetquainmauEntity);
			r.SetField(Field_Id,_KetquainmauEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_KetquainId,_KetquainmauEntity.KetquainId);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masp,_KetquainmauEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensp,_KetquainmauEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamau,_KetquainmauEntity.Mamau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmau,_KetquainmauEntity.Tenmau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Xuatdodang,_KetquainmauEntity.Xuatdodang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Xuatnguyen,_KetquainmauEntity.Xuatnguyen);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nhapdodang,_KetquainmauEntity.Nhapdodang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nhapnguyen,_KetquainmauEntity.Nhapnguyen);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquainmauEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquainmauEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquainmauEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquainmauEntity.Nguoisua);
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

		public KetquainmauEntity Insert(KetquainmauEntity KetquainmauEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(KetquainmauEntity, true);
			}
			return KetquainmauEntity;
		}

		public KetquainmauEntity Insert(System.Int64  Id, System.Int64  KetquainId, System.String  Masp, System.String  Tensp, System.String  Mamau, System.String  Tenmau, System.Decimal  Xuatdodang, System.Decimal  Xuatnguyen, System.Decimal  Nhapdodang, System.Decimal  Nhapnguyen, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			KetquainmauEntity _KetquainmauEntity = new KetquainmauEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KetquainmauEntity.Id = Id;
				
				_KetquainmauEntity.KetquainId = KetquainId;
				
				_KetquainmauEntity.Masp = Masp;
				
				_KetquainmauEntity.Tensp = Tensp;
				
				_KetquainmauEntity.Mamau = Mamau;
				
				_KetquainmauEntity.Tenmau = Tenmau;
				
				_KetquainmauEntity.Xuatdodang = Xuatdodang;
				
				_KetquainmauEntity.Xuatnguyen = Xuatnguyen;
				
				_KetquainmauEntity.Nhapdodang = Nhapdodang;
				
				_KetquainmauEntity.Nhapnguyen = Nhapnguyen;
				
				_KetquainmauEntity.Ngaytao = Ngaytao;
				
				_KetquainmauEntity.Nguoitao = Nguoitao;
				
				_KetquainmauEntity.Ngaysua = Ngaysua;
				
				_KetquainmauEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_KetquainmauEntity, true);
			}
			return _KetquainmauEntity;
		}

		public KetquainmauEntity Insert(System.Int64 KetquainId, System.String Masp, System.String Tensp, System.String Mamau, System.String Tenmau, System.Decimal Xuatdodang, System.Decimal Xuatnguyen, System.Decimal Nhapdodang, System.Decimal Nhapnguyen, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			KetquainmauEntity _KetquainmauEntity = new KetquainmauEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_KetquainmauEntity.KetquainId = KetquainId;
				
				_KetquainmauEntity.Masp = Masp;
				
				_KetquainmauEntity.Tensp = Tensp;
				
				_KetquainmauEntity.Mamau = Mamau;
				
				_KetquainmauEntity.Tenmau = Tenmau;
				
				_KetquainmauEntity.Xuatdodang = Xuatdodang;
				
				_KetquainmauEntity.Xuatnguyen = Xuatnguyen;
				
				_KetquainmauEntity.Nhapdodang = Nhapdodang;
				
				_KetquainmauEntity.Nhapnguyen = Nhapnguyen;
				
				_KetquainmauEntity.Ngaytao = Ngaytao;
				
				_KetquainmauEntity.Nguoitao = Nguoitao;
				
				_KetquainmauEntity.Ngaysua = Ngaysua;
				
				_KetquainmauEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_KetquainmauEntity, true);
			}
			return _KetquainmauEntity;
		}

		public bool Update(KetquainmauEntity _KetquainmauEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(KetquainmauFields.Id == _KetquainmauEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KetquainmauEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KetquainmauEntity _KetquainmauEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KetquainmauEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.Int64 KetquainId, System.String Masp, System.String Tensp, System.String Mamau, System.String Tenmau, System.Decimal Xuatdodang, System.Decimal Xuatnguyen, System.Decimal Nhapdodang, System.Decimal Nhapnguyen, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquainmauEntity _KetquainmauEntity = new KetquainmauEntity(Id);
				if (adapter.FetchEntity(_KetquainmauEntity))
				{
				
					
					
					_KetquainmauEntity.KetquainId = KetquainId;
					
					_KetquainmauEntity.Masp = Masp;
					
					_KetquainmauEntity.Tensp = Tensp;
					
					_KetquainmauEntity.Mamau = Mamau;
					
					_KetquainmauEntity.Tenmau = Tenmau;
					
					_KetquainmauEntity.Xuatdodang = Xuatdodang;
					
					_KetquainmauEntity.Xuatnguyen = Xuatnguyen;
					
					_KetquainmauEntity.Nhapdodang = Nhapdodang;
					
					_KetquainmauEntity.Nhapnguyen = Nhapnguyen;
					
					_KetquainmauEntity.Ngaytao = Ngaytao;
					
					_KetquainmauEntity.Nguoitao = Nguoitao;
					
					_KetquainmauEntity.Ngaysua = Ngaysua;
					
					_KetquainmauEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_KetquainmauEntity, true);
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
				KetquainmauEntity _KetquainmauEntity = new KetquainmauEntity(Id);
				if (adapter.FetchEntity(_KetquainmauEntity))
				{
					adapter.DeleteEntity(_KetquainmauEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KetquainmauEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKetquainId(System.Int64 KetquainId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.KetquainId == KetquainId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasp(System.String Masp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensp(System.String Tensp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamau(System.String Mamau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Mamau == Mamau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmau(System.String Tenmau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Tenmau == Tenmau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByXuatdodang(System.Decimal Xuatdodang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Xuatdodang == Xuatdodang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByXuatnguyen(System.Decimal Xuatnguyen)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Xuatnguyen == Xuatnguyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNhapdodang(System.Decimal Nhapdodang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Nhapdodang == Nhapdodang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNhapnguyen(System.Decimal Nhapnguyen)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Nhapnguyen == Nhapnguyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquainmauEntity", filter);
			}
			return toReturn;
		}		
			
		
		public KetquainmauEntity SelectOne(System.Int64 Id)
		{
			KetquainmauEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquainmauEntity _KetquainmauEntity = new KetquainmauEntity(Id);
				if (adapter.FetchEntity(_KetquainmauEntity))
				{
					toReturn = _KetquainmauEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _KetquainmauCollection = new EntityCollection( new KetquainmauEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainmauCollection, null, 0, null);
			}
			return _KetquainmauCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainmauCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainmauCollection, filter, 0, null);
			}
			return _KetquainmauCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKetquainId(System.Int64 KetquainId)
		{
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.KetquainId == KetquainId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainmauCollection, filter, 0, null);
			}
			return _KetquainmauCollection;
		}
		// Return DataTable
		public DataTable SelectByKetquainIdRDT(System.Int64 KetquainId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.KetquainId == KetquainId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasp(System.String Masp)
		{
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainmauCollection, filter, 0, null);
			}
			return _KetquainmauCollection;
		}
		// Return DataTable
		public DataTable SelectByMaspRDT(System.String Masp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensp(System.String Tensp)
		{
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainmauCollection, filter, 0, null);
			}
			return _KetquainmauCollection;
		}
		// Return DataTable
		public DataTable SelectByTenspRDT(System.String Tensp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamau(System.String Mamau)
		{
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Mamau == Mamau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainmauCollection, filter, 0, null);
			}
			return _KetquainmauCollection;
		}
		// Return DataTable
		public DataTable SelectByMamauRDT(System.String Mamau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Mamau == Mamau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmau(System.String Tenmau)
		{
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Tenmau == Tenmau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainmauCollection, filter, 0, null);
			}
			return _KetquainmauCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmauRDT(System.String Tenmau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Tenmau == Tenmau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByXuatdodang(System.Decimal Xuatdodang)
		{
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Xuatdodang == Xuatdodang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainmauCollection, filter, 0, null);
			}
			return _KetquainmauCollection;
		}
		// Return DataTable
		public DataTable SelectByXuatdodangRDT(System.Decimal Xuatdodang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Xuatdodang == Xuatdodang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByXuatnguyen(System.Decimal Xuatnguyen)
		{
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Xuatnguyen == Xuatnguyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainmauCollection, filter, 0, null);
			}
			return _KetquainmauCollection;
		}
		// Return DataTable
		public DataTable SelectByXuatnguyenRDT(System.Decimal Xuatnguyen)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Xuatnguyen == Xuatnguyen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNhapdodang(System.Decimal Nhapdodang)
		{
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Nhapdodang == Nhapdodang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainmauCollection, filter, 0, null);
			}
			return _KetquainmauCollection;
		}
		// Return DataTable
		public DataTable SelectByNhapdodangRDT(System.Decimal Nhapdodang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Nhapdodang == Nhapdodang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNhapnguyen(System.Decimal Nhapnguyen)
		{
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Nhapnguyen == Nhapnguyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainmauCollection, filter, 0, null);
			}
			return _KetquainmauCollection;
		}
		// Return DataTable
		public DataTable SelectByNhapnguyenRDT(System.Decimal Nhapnguyen)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Nhapnguyen == Nhapnguyen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainmauCollection, filter, 0, null);
			}
			return _KetquainmauCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainmauCollection, filter, 0, null);
			}
			return _KetquainmauCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainmauCollection, filter, 0, null);
			}
			return _KetquainmauCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquainmauCollection, filter, 0, null);
			}
			return _KetquainmauCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquainmauCollection = new EntityCollection(new KetquainmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquainmauFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquainmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
