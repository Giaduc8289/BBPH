


/*
'===============================================================================
'  GD.BBPH.BL.DonhangDManagerBase
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
	public class DonhangDManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Madon="Madon";				
		
		public const String Field_Ngaydat="Ngaydat";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Sobaogia="Sobaogia";				
		
		public const String Field_Loaihang="Loaihang";				
		
		public const String Field_Masp="Masp";				
		
		public const String Field_Tenhang="Tenhang";				
		
		public const String Field_Soluong="Soluong";				
		
		public const String Field_Dongia="Dongia";				
		
		public const String Field_Ngaygiao="Ngaygiao";				
		
		public const String Field_Ghichu="Ghichu";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Ngaybaogia="Ngaybaogia";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DonhangDManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Madon,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaydat,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Sobaogia,typeof(System.String));
			
			dt.Columns.Add(Field_Loaihang,typeof(System.Int32));
			
			dt.Columns.Add(Field_Masp,typeof(System.String));
			
			dt.Columns.Add(Field_Tenhang,typeof(System.String));
			
			dt.Columns.Add(Field_Soluong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dongia,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaygiao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Ghichu,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaybaogia,typeof(System.DateTime));
									
		            
			return dt;			
		}
		public DataRow Convert(DonhangDEntity _DonhangDEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_DonhangDEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Madon]=_DonhangDEntity.Madon;
			}
			catch { }
			
			try
			{
				r[Field_Ngaydat]=_DonhangDEntity.Ngaydat;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_DonhangDEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Sobaogia]=_DonhangDEntity.Sobaogia;
			}
			catch { }
			
			try
			{
				r[Field_Loaihang]=_DonhangDEntity.Loaihang;
			}
			catch { }
			
			try
			{
				r[Field_Masp]=_DonhangDEntity.Masp;
			}
			catch { }
			
			try
			{
				r[Field_Tenhang]=_DonhangDEntity.Tenhang;
			}
			catch { }
			
			try
			{
				r[Field_Soluong]=_DonhangDEntity.Soluong;
			}
			catch { }
			
			try
			{
				r[Field_Dongia]=_DonhangDEntity.Dongia;
			}
			catch { }
			
			try
			{
				r[Field_Ngaygiao]=_DonhangDEntity.Ngaygiao;
			}
			catch { }
			
			try
			{
				r[Field_Ghichu]=_DonhangDEntity.Ghichu;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DonhangDEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DonhangDEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DonhangDEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DonhangDEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Ngaybaogia]=_DonhangDEntity.Ngaybaogia;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DonhangDEntity Convert(DataRow r)
		{	
			
			DonhangDEntity _DonhangDEntity=new DonhangDEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_DonhangDEntity.Madon= r[Field_Madon].ToString();						
			}
			catch { }
			
			try
			{
				_DonhangDEntity.Ngaydat= System.DateTime.Parse(r[Field_Ngaydat].ToString());						
			}
			catch { }
			
			try
			{
				_DonhangDEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_DonhangDEntity.Sobaogia= r[Field_Sobaogia].ToString();						
			}
			catch { }
			
			try
			{
				_DonhangDEntity.Loaihang= System.Int32.Parse(r[Field_Loaihang].ToString());						
			}
			catch { }
			
			try
			{
				_DonhangDEntity.Masp= r[Field_Masp].ToString();						
			}
			catch { }
			
			try
			{
				_DonhangDEntity.Tenhang= r[Field_Tenhang].ToString();						
			}
			catch { }
			
			try
			{
				_DonhangDEntity.Soluong= System.Decimal.Parse(r[Field_Soluong].ToString());						
			}
			catch { }
			
			try
			{
				_DonhangDEntity.Dongia= System.Decimal.Parse(r[Field_Dongia].ToString());						
			}
			catch { }
			
			try
			{
				_DonhangDEntity.Ngaygiao= System.DateTime.Parse(r[Field_Ngaygiao].ToString());						
			}
			catch { }
			
			try
			{
				_DonhangDEntity.Ghichu= r[Field_Ghichu].ToString();						
			}
			catch { }
			
			try
			{
				_DonhangDEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DonhangDEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DonhangDEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DonhangDEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_DonhangDEntity.Ngaybaogia= System.DateTime.Parse(r[Field_Ngaybaogia].ToString());						
			}
			catch { }
									
									
			return _DonhangDEntity;
		}			
		
		public DonhangDEntity Convert_Entity(DonhangDEntity _DonhangDEntity,DonhangDEntity _DonhangDEntity_XML)
		{	
			
			
			_DonhangDEntity.Id= _DonhangDEntity_XML.Id;
			
			_DonhangDEntity.Madon= _DonhangDEntity_XML.Madon;
			
			_DonhangDEntity.Ngaydat= _DonhangDEntity_XML.Ngaydat;
			
			_DonhangDEntity.Makhach= _DonhangDEntity_XML.Makhach;
			
			_DonhangDEntity.Sobaogia= _DonhangDEntity_XML.Sobaogia;
			
			_DonhangDEntity.Loaihang= _DonhangDEntity_XML.Loaihang;
			
			_DonhangDEntity.Masp= _DonhangDEntity_XML.Masp;
			
			_DonhangDEntity.Tenhang= _DonhangDEntity_XML.Tenhang;
			
			_DonhangDEntity.Soluong= _DonhangDEntity_XML.Soluong;
			
			_DonhangDEntity.Dongia= _DonhangDEntity_XML.Dongia;
			
			_DonhangDEntity.Ngaygiao= _DonhangDEntity_XML.Ngaygiao;
			
			_DonhangDEntity.Ghichu= _DonhangDEntity_XML.Ghichu;
			
			_DonhangDEntity.Ngaytao= _DonhangDEntity_XML.Ngaytao;
			
			_DonhangDEntity.Nguoitao= _DonhangDEntity_XML.Nguoitao;
			
			_DonhangDEntity.Ngaysua= _DonhangDEntity_XML.Ngaysua;
			
			_DonhangDEntity.Nguoisua= _DonhangDEntity_XML.Nguoisua;
			
			_DonhangDEntity.Ngaybaogia= _DonhangDEntity_XML.Ngaybaogia;
									
				
			return _DonhangDEntity;
		}	
		
		public String InsertV2(DonhangDEntity _DonhangDEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DonhangDManagerBase()).Insert(_DonhangDEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_DonhangDEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Madon,_DonhangDEntity.Madon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_DonhangDEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_DonhangDEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sobaogia,_DonhangDEntity.Sobaogia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaihang,_DonhangDEntity.Loaihang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masp,_DonhangDEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenhang,_DonhangDEntity.Tenhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_DonhangDEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongia,_DonhangDEntity.Dongia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_DonhangDEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ghichu,_DonhangDEntity.Ghichu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DonhangDEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DonhangDEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DonhangDEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DonhangDEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaybaogia,_DonhangDEntity.Ngaybaogia);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DonhangDEntity _DonhangDEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DonhangDManagerBase()).Update(_DonhangDEntity);
			r.SetField(Field_Id,_DonhangDEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Madon,_DonhangDEntity.Madon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_DonhangDEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_DonhangDEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sobaogia,_DonhangDEntity.Sobaogia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaihang,_DonhangDEntity.Loaihang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masp,_DonhangDEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenhang,_DonhangDEntity.Tenhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_DonhangDEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongia,_DonhangDEntity.Dongia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_DonhangDEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ghichu,_DonhangDEntity.Ghichu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DonhangDEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DonhangDEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DonhangDEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DonhangDEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaybaogia,_DonhangDEntity.Ngaybaogia);
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

		public DonhangDEntity Insert(DonhangDEntity DonhangDEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DonhangDEntity, true);
			}
			return DonhangDEntity;
		}

		public DonhangDEntity Insert(System.Int64  Id, System.String  Madon, System.DateTime  Ngaydat, System.String  Makhach, System.String  Sobaogia, System.Int32  Loaihang, System.String  Masp, System.String  Tenhang, System.Decimal  Soluong, System.Decimal  Dongia, System.DateTime  Ngaygiao, System.String  Ghichu, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.DateTime  Ngaybaogia)
		{
			DonhangDEntity _DonhangDEntity = new DonhangDEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DonhangDEntity.Id = Id;
				
				_DonhangDEntity.Madon = Madon;
				
				_DonhangDEntity.Ngaydat = Ngaydat;
				
				_DonhangDEntity.Makhach = Makhach;
				
				_DonhangDEntity.Sobaogia = Sobaogia;
				
				_DonhangDEntity.Loaihang = Loaihang;
				
				_DonhangDEntity.Masp = Masp;
				
				_DonhangDEntity.Tenhang = Tenhang;
				
				_DonhangDEntity.Soluong = Soluong;
				
				_DonhangDEntity.Dongia = Dongia;
				
				_DonhangDEntity.Ngaygiao = Ngaygiao;
				
				_DonhangDEntity.Ghichu = Ghichu;
				
				_DonhangDEntity.Ngaytao = Ngaytao;
				
				_DonhangDEntity.Nguoitao = Nguoitao;
				
				_DonhangDEntity.Ngaysua = Ngaysua;
				
				_DonhangDEntity.Nguoisua = Nguoisua;
				
				_DonhangDEntity.Ngaybaogia = Ngaybaogia;
					
					
				adapter.SaveEntity(_DonhangDEntity, true);
			}
			return _DonhangDEntity;
		}

		public DonhangDEntity Insert(System.String Madon, System.DateTime Ngaydat, System.String Makhach, System.String Sobaogia, System.Int32 Loaihang, System.String Masp, System.String Tenhang, System.Decimal Soluong, System.Decimal Dongia, System.DateTime Ngaygiao, System.String Ghichu, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.DateTime Ngaybaogia)//ko co mahieu
		{
			DonhangDEntity _DonhangDEntity = new DonhangDEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DonhangDEntity.Madon = Madon;
				
				_DonhangDEntity.Ngaydat = Ngaydat;
				
				_DonhangDEntity.Makhach = Makhach;
				
				_DonhangDEntity.Sobaogia = Sobaogia;
				
				_DonhangDEntity.Loaihang = Loaihang;
				
				_DonhangDEntity.Masp = Masp;
				
				_DonhangDEntity.Tenhang = Tenhang;
				
				_DonhangDEntity.Soluong = Soluong;
				
				_DonhangDEntity.Dongia = Dongia;
				
				_DonhangDEntity.Ngaygiao = Ngaygiao;
				
				_DonhangDEntity.Ghichu = Ghichu;
				
				_DonhangDEntity.Ngaytao = Ngaytao;
				
				_DonhangDEntity.Nguoitao = Nguoitao;
				
				_DonhangDEntity.Ngaysua = Ngaysua;
				
				_DonhangDEntity.Nguoisua = Nguoisua;
				
				_DonhangDEntity.Ngaybaogia = Ngaybaogia;
					

				adapter.SaveEntity(_DonhangDEntity, true);
			}
			return _DonhangDEntity;
		}

		public bool Update(DonhangDEntity _DonhangDEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DonhangDFields.Id == _DonhangDEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DonhangDEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DonhangDEntity _DonhangDEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DonhangDEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Madon, System.DateTime Ngaydat, System.String Makhach, System.String Sobaogia, System.Int32 Loaihang, System.String Masp, System.String Tenhang, System.Decimal Soluong, System.Decimal Dongia, System.DateTime Ngaygiao, System.String Ghichu, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.DateTime Ngaybaogia)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DonhangDEntity _DonhangDEntity = new DonhangDEntity(Id);
				if (adapter.FetchEntity(_DonhangDEntity))
				{
				
					
					
					_DonhangDEntity.Madon = Madon;
					
					_DonhangDEntity.Ngaydat = Ngaydat;
					
					_DonhangDEntity.Makhach = Makhach;
					
					_DonhangDEntity.Sobaogia = Sobaogia;
					
					_DonhangDEntity.Loaihang = Loaihang;
					
					_DonhangDEntity.Masp = Masp;
					
					_DonhangDEntity.Tenhang = Tenhang;
					
					_DonhangDEntity.Soluong = Soluong;
					
					_DonhangDEntity.Dongia = Dongia;
					
					_DonhangDEntity.Ngaygiao = Ngaygiao;
					
					_DonhangDEntity.Ghichu = Ghichu;
					
					_DonhangDEntity.Ngaytao = Ngaytao;
					
					_DonhangDEntity.Nguoitao = Nguoitao;
					
					_DonhangDEntity.Ngaysua = Ngaysua;
					
					_DonhangDEntity.Nguoisua = Nguoisua;
					
					_DonhangDEntity.Ngaybaogia = Ngaybaogia;
						

					adapter.SaveEntity(_DonhangDEntity, true);
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
				DonhangDEntity _DonhangDEntity = new DonhangDEntity(Id);
				if (adapter.FetchEntity(_DonhangDEntity))
				{
					adapter.DeleteEntity(_DonhangDEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DonhangDEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMadon(System.String Madon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaydat(System.DateTime Ngaydat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySobaogia(System.String Sobaogia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Sobaogia == Sobaogia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLoaihang(System.Int32 Loaihang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Loaihang == Loaihang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasp(System.String Masp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenhang(System.String Tenhang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Tenhang == Tenhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluong(System.Decimal Soluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDongia(System.Decimal Dongia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Dongia == Dongia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaygiao(System.DateTime Ngaygiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByGhichu(System.String Ghichu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaybaogia(System.DateTime Ngaybaogia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ngaybaogia == Ngaybaogia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangDEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DonhangDEntity SelectOne(System.Int64 Id)
		{
			DonhangDEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DonhangDEntity _DonhangDEntity = new DonhangDEntity(Id);
				if (adapter.FetchEntity(_DonhangDEntity))
				{
					toReturn = _DonhangDEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DonhangDCollection = new EntityCollection( new DonhangDEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, null, 0, null);
			}
			return _DonhangDCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMadon(System.String Madon)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectByMadonRDT(System.String Madon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaydat(System.DateTime Ngaydat)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaydatRDT(System.DateTime Ngaydat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySobaogia(System.String Sobaogia)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Sobaogia == Sobaogia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectBySobaogiaRDT(System.String Sobaogia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Sobaogia == Sobaogia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLoaihang(System.Int32 Loaihang)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Loaihang == Loaihang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectByLoaihangRDT(System.Int32 Loaihang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Loaihang == Loaihang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasp(System.String Masp)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectByMaspRDT(System.String Masp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenhang(System.String Tenhang)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Tenhang == Tenhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectByTenhangRDT(System.String Tenhang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Tenhang == Tenhang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluong(System.Decimal Soluong)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongRDT(System.Decimal Soluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDongia(System.Decimal Dongia)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Dongia == Dongia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectByDongiaRDT(System.Decimal Dongia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Dongia == Dongia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaygiao(System.DateTime Ngaygiao)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaygiaoRDT(System.DateTime Ngaygiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByGhichu(System.String Ghichu)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectByGhichuRDT(System.String Ghichu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaybaogia(System.DateTime Ngaybaogia)
		{
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ngaybaogia == Ngaybaogia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangDCollection, filter, 0, null);
			}
			return _DonhangDCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaybaogiaRDT(System.DateTime Ngaybaogia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangDCollection = new EntityCollection(new DonhangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangDFields.Ngaybaogia == Ngaybaogia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(DonhangDFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
