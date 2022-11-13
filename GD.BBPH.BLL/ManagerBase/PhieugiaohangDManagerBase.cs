


/*
'===============================================================================
'  GD.BBPH.BL.PhieugiaohangDManagerBase
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
	public class PhieugiaohangDManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Sophieu="Sophieu";				
		
		public const String Field_Ngaygiao="Ngaygiao";				
		
		public const String Field_Madon="Madon";				
		
		public const String Field_DonchitietId="DonchitietId";				
		
		public const String Field_Ngaydat="Ngaydat";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Loaihang="Loaihang";				
		
		public const String Field_Masp="Masp";				
		
		public const String Field_Tenhang="Tenhang";				
		
		public const String Field_Soluong="Soluong";				
		
		public const String Field_Dongia="Dongia";				
		
		public const String Field_Thanhtien="Thanhtien";				
		
		public const String Field_Ghichu="Ghichu";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhieugiaohangDManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Sophieu,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaygiao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Madon,typeof(System.String));
			
			dt.Columns.Add(Field_DonchitietId,typeof(System.Int64));
			
			dt.Columns.Add(Field_Ngaydat,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Loaihang,typeof(System.String));
			
			dt.Columns.Add(Field_Masp,typeof(System.String));
			
			dt.Columns.Add(Field_Tenhang,typeof(System.String));
			
			dt.Columns.Add(Field_Soluong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dongia,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thanhtien,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ghichu,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(PhieugiaohangDEntity _PhieugiaohangDEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_PhieugiaohangDEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Sophieu]=_PhieugiaohangDEntity.Sophieu;
			}
			catch { }
			
			try
			{
				r[Field_Ngaygiao]=_PhieugiaohangDEntity.Ngaygiao;
			}
			catch { }
			
			try
			{
				r[Field_Madon]=_PhieugiaohangDEntity.Madon;
			}
			catch { }
			
			try
			{
				r[Field_DonchitietId]=_PhieugiaohangDEntity.DonchitietId;
			}
			catch { }
			
			try
			{
				r[Field_Ngaydat]=_PhieugiaohangDEntity.Ngaydat;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_PhieugiaohangDEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_PhieugiaohangDEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Loaihang]=_PhieugiaohangDEntity.Loaihang;
			}
			catch { }
			
			try
			{
				r[Field_Masp]=_PhieugiaohangDEntity.Masp;
			}
			catch { }
			
			try
			{
				r[Field_Tenhang]=_PhieugiaohangDEntity.Tenhang;
			}
			catch { }
			
			try
			{
				r[Field_Soluong]=_PhieugiaohangDEntity.Soluong;
			}
			catch { }
			
			try
			{
				r[Field_Dongia]=_PhieugiaohangDEntity.Dongia;
			}
			catch { }
			
			try
			{
				r[Field_Thanhtien]=_PhieugiaohangDEntity.Thanhtien;
			}
			catch { }
			
			try
			{
				r[Field_Ghichu]=_PhieugiaohangDEntity.Ghichu;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_PhieugiaohangDEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_PhieugiaohangDEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_PhieugiaohangDEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_PhieugiaohangDEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public PhieugiaohangDEntity Convert(DataRow r)
		{	
			
			PhieugiaohangDEntity _PhieugiaohangDEntity=new PhieugiaohangDEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_PhieugiaohangDEntity.Sophieu= r[Field_Sophieu].ToString();						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Ngaygiao= System.DateTime.Parse(r[Field_Ngaygiao].ToString());						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Madon= r[Field_Madon].ToString();						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.DonchitietId= System.Int64.Parse(r[Field_DonchitietId].ToString());						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Ngaydat= System.DateTime.Parse(r[Field_Ngaydat].ToString());						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Loaihang= r[Field_Loaihang].ToString();						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Masp= r[Field_Masp].ToString();						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Tenhang= r[Field_Tenhang].ToString();						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Soluong= System.Decimal.Parse(r[Field_Soluong].ToString());						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Dongia= System.Decimal.Parse(r[Field_Dongia].ToString());						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Thanhtien= System.Decimal.Parse(r[Field_Thanhtien].ToString());						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Ghichu= r[Field_Ghichu].ToString();						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_PhieugiaohangDEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _PhieugiaohangDEntity;
		}			
		
		public PhieugiaohangDEntity Convert_Entity(PhieugiaohangDEntity _PhieugiaohangDEntity,PhieugiaohangDEntity _PhieugiaohangDEntity_XML)
		{	
			
			
			_PhieugiaohangDEntity.Id= _PhieugiaohangDEntity_XML.Id;
			
			_PhieugiaohangDEntity.Sophieu= _PhieugiaohangDEntity_XML.Sophieu;
			
			_PhieugiaohangDEntity.Ngaygiao= _PhieugiaohangDEntity_XML.Ngaygiao;
			
			_PhieugiaohangDEntity.Madon= _PhieugiaohangDEntity_XML.Madon;
			
			_PhieugiaohangDEntity.DonchitietId= _PhieugiaohangDEntity_XML.DonchitietId;
			
			_PhieugiaohangDEntity.Ngaydat= _PhieugiaohangDEntity_XML.Ngaydat;
			
			_PhieugiaohangDEntity.Makhach= _PhieugiaohangDEntity_XML.Makhach;
			
			_PhieugiaohangDEntity.Tenkhach= _PhieugiaohangDEntity_XML.Tenkhach;
			
			_PhieugiaohangDEntity.Loaihang= _PhieugiaohangDEntity_XML.Loaihang;
			
			_PhieugiaohangDEntity.Masp= _PhieugiaohangDEntity_XML.Masp;
			
			_PhieugiaohangDEntity.Tenhang= _PhieugiaohangDEntity_XML.Tenhang;
			
			_PhieugiaohangDEntity.Soluong= _PhieugiaohangDEntity_XML.Soluong;
			
			_PhieugiaohangDEntity.Dongia= _PhieugiaohangDEntity_XML.Dongia;
			
			_PhieugiaohangDEntity.Thanhtien= _PhieugiaohangDEntity_XML.Thanhtien;
			
			_PhieugiaohangDEntity.Ghichu= _PhieugiaohangDEntity_XML.Ghichu;
			
			_PhieugiaohangDEntity.Ngaytao= _PhieugiaohangDEntity_XML.Ngaytao;
			
			_PhieugiaohangDEntity.Nguoitao= _PhieugiaohangDEntity_XML.Nguoitao;
			
			_PhieugiaohangDEntity.Ngaysua= _PhieugiaohangDEntity_XML.Ngaysua;
			
			_PhieugiaohangDEntity.Nguoisua= _PhieugiaohangDEntity_XML.Nguoisua;
									
				
			return _PhieugiaohangDEntity;
		}	
		
		public String InsertV2(PhieugiaohangDEntity _PhieugiaohangDEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new PhieugiaohangDManagerBase()).Insert(_PhieugiaohangDEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_PhieugiaohangDEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Sophieu,_PhieugiaohangDEntity.Sophieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_PhieugiaohangDEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madon,_PhieugiaohangDEntity.Madon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_DonchitietId,_PhieugiaohangDEntity.DonchitietId);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_PhieugiaohangDEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_PhieugiaohangDEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_PhieugiaohangDEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaihang,_PhieugiaohangDEntity.Loaihang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masp,_PhieugiaohangDEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenhang,_PhieugiaohangDEntity.Tenhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_PhieugiaohangDEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongia,_PhieugiaohangDEntity.Dongia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thanhtien,_PhieugiaohangDEntity.Thanhtien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ghichu,_PhieugiaohangDEntity.Ghichu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_PhieugiaohangDEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_PhieugiaohangDEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_PhieugiaohangDEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_PhieugiaohangDEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(PhieugiaohangDEntity _PhieugiaohangDEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new PhieugiaohangDManagerBase()).Update(_PhieugiaohangDEntity);
			r.SetField(Field_Id,_PhieugiaohangDEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Sophieu,_PhieugiaohangDEntity.Sophieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_PhieugiaohangDEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madon,_PhieugiaohangDEntity.Madon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_DonchitietId,_PhieugiaohangDEntity.DonchitietId);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_PhieugiaohangDEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_PhieugiaohangDEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_PhieugiaohangDEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaihang,_PhieugiaohangDEntity.Loaihang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masp,_PhieugiaohangDEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenhang,_PhieugiaohangDEntity.Tenhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_PhieugiaohangDEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dongia,_PhieugiaohangDEntity.Dongia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thanhtien,_PhieugiaohangDEntity.Thanhtien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ghichu,_PhieugiaohangDEntity.Ghichu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_PhieugiaohangDEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_PhieugiaohangDEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_PhieugiaohangDEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_PhieugiaohangDEntity.Nguoisua);
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

		public PhieugiaohangDEntity Insert(PhieugiaohangDEntity PhieugiaohangDEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(PhieugiaohangDEntity, true);
			}
			return PhieugiaohangDEntity;
		}

		public PhieugiaohangDEntity Insert(System.Int64  Id, System.String  Sophieu, System.DateTime  Ngaygiao, System.String  Madon, System.Int64  DonchitietId, System.DateTime  Ngaydat, System.String  Makhach, System.String  Tenkhach, System.String  Loaihang, System.String  Masp, System.String  Tenhang, System.Decimal  Soluong, System.Decimal  Dongia, System.Decimal  Thanhtien, System.String  Ghichu, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			PhieugiaohangDEntity _PhieugiaohangDEntity = new PhieugiaohangDEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PhieugiaohangDEntity.Id = Id;
				
				_PhieugiaohangDEntity.Sophieu = Sophieu;
				
				_PhieugiaohangDEntity.Ngaygiao = Ngaygiao;
				
				_PhieugiaohangDEntity.Madon = Madon;
				
				_PhieugiaohangDEntity.DonchitietId = DonchitietId;
				
				_PhieugiaohangDEntity.Ngaydat = Ngaydat;
				
				_PhieugiaohangDEntity.Makhach = Makhach;
				
				_PhieugiaohangDEntity.Tenkhach = Tenkhach;
				
				_PhieugiaohangDEntity.Loaihang = Loaihang;
				
				_PhieugiaohangDEntity.Masp = Masp;
				
				_PhieugiaohangDEntity.Tenhang = Tenhang;
				
				_PhieugiaohangDEntity.Soluong = Soluong;
				
				_PhieugiaohangDEntity.Dongia = Dongia;
				
				_PhieugiaohangDEntity.Thanhtien = Thanhtien;
				
				_PhieugiaohangDEntity.Ghichu = Ghichu;
				
				_PhieugiaohangDEntity.Ngaytao = Ngaytao;
				
				_PhieugiaohangDEntity.Nguoitao = Nguoitao;
				
				_PhieugiaohangDEntity.Ngaysua = Ngaysua;
				
				_PhieugiaohangDEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_PhieugiaohangDEntity, true);
			}
			return _PhieugiaohangDEntity;
		}

		public PhieugiaohangDEntity Insert(System.String Sophieu, System.DateTime Ngaygiao, System.String Madon, System.Int64 DonchitietId, System.DateTime Ngaydat, System.String Makhach, System.String Tenkhach, System.String Loaihang, System.String Masp, System.String Tenhang, System.Decimal Soluong, System.Decimal Dongia, System.Decimal Thanhtien, System.String Ghichu, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			PhieugiaohangDEntity _PhieugiaohangDEntity = new PhieugiaohangDEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_PhieugiaohangDEntity.Sophieu = Sophieu;
				
				_PhieugiaohangDEntity.Ngaygiao = Ngaygiao;
				
				_PhieugiaohangDEntity.Madon = Madon;
				
				_PhieugiaohangDEntity.DonchitietId = DonchitietId;
				
				_PhieugiaohangDEntity.Ngaydat = Ngaydat;
				
				_PhieugiaohangDEntity.Makhach = Makhach;
				
				_PhieugiaohangDEntity.Tenkhach = Tenkhach;
				
				_PhieugiaohangDEntity.Loaihang = Loaihang;
				
				_PhieugiaohangDEntity.Masp = Masp;
				
				_PhieugiaohangDEntity.Tenhang = Tenhang;
				
				_PhieugiaohangDEntity.Soluong = Soluong;
				
				_PhieugiaohangDEntity.Dongia = Dongia;
				
				_PhieugiaohangDEntity.Thanhtien = Thanhtien;
				
				_PhieugiaohangDEntity.Ghichu = Ghichu;
				
				_PhieugiaohangDEntity.Ngaytao = Ngaytao;
				
				_PhieugiaohangDEntity.Nguoitao = Nguoitao;
				
				_PhieugiaohangDEntity.Ngaysua = Ngaysua;
				
				_PhieugiaohangDEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_PhieugiaohangDEntity, true);
			}
			return _PhieugiaohangDEntity;
		}

		public bool Update(PhieugiaohangDEntity _PhieugiaohangDEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(PhieugiaohangDFields.Id == _PhieugiaohangDEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_PhieugiaohangDEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(PhieugiaohangDEntity _PhieugiaohangDEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_PhieugiaohangDEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Sophieu, System.DateTime Ngaygiao, System.String Madon, System.Int64 DonchitietId, System.DateTime Ngaydat, System.String Makhach, System.String Tenkhach, System.String Loaihang, System.String Masp, System.String Tenhang, System.Decimal Soluong, System.Decimal Dongia, System.Decimal Thanhtien, System.String Ghichu, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhieugiaohangDEntity _PhieugiaohangDEntity = new PhieugiaohangDEntity(Id);
				if (adapter.FetchEntity(_PhieugiaohangDEntity))
				{
				
					
					
					_PhieugiaohangDEntity.Sophieu = Sophieu;
					
					_PhieugiaohangDEntity.Ngaygiao = Ngaygiao;
					
					_PhieugiaohangDEntity.Madon = Madon;
					
					_PhieugiaohangDEntity.DonchitietId = DonchitietId;
					
					_PhieugiaohangDEntity.Ngaydat = Ngaydat;
					
					_PhieugiaohangDEntity.Makhach = Makhach;
					
					_PhieugiaohangDEntity.Tenkhach = Tenkhach;
					
					_PhieugiaohangDEntity.Loaihang = Loaihang;
					
					_PhieugiaohangDEntity.Masp = Masp;
					
					_PhieugiaohangDEntity.Tenhang = Tenhang;
					
					_PhieugiaohangDEntity.Soluong = Soluong;
					
					_PhieugiaohangDEntity.Dongia = Dongia;
					
					_PhieugiaohangDEntity.Thanhtien = Thanhtien;
					
					_PhieugiaohangDEntity.Ghichu = Ghichu;
					
					_PhieugiaohangDEntity.Ngaytao = Ngaytao;
					
					_PhieugiaohangDEntity.Nguoitao = Nguoitao;
					
					_PhieugiaohangDEntity.Ngaysua = Ngaysua;
					
					_PhieugiaohangDEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_PhieugiaohangDEntity, true);
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
				PhieugiaohangDEntity _PhieugiaohangDEntity = new PhieugiaohangDEntity(Id);
				if (adapter.FetchEntity(_PhieugiaohangDEntity))
				{
					adapter.DeleteEntity(_PhieugiaohangDEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySophieu(System.String Sophieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Sophieu == Sophieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaygiao(System.DateTime Ngaygiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMadon(System.String Madon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDonchitietId(System.Int64 DonchitietId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.DonchitietId == DonchitietId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaydat(System.DateTime Ngaydat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLoaihang(System.String Loaihang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Loaihang == Loaihang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasp(System.String Masp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenhang(System.String Tenhang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Tenhang == Tenhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluong(System.Decimal Soluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDongia(System.Decimal Dongia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Dongia == Dongia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThanhtien(System.Decimal Thanhtien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Thanhtien == Thanhtien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByGhichu(System.String Ghichu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangDEntity", filter);
			}
			return toReturn;
		}		
			
		
		public PhieugiaohangDEntity SelectOne(System.Int64 Id)
		{
			PhieugiaohangDEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhieugiaohangDEntity _PhieugiaohangDEntity = new PhieugiaohangDEntity(Id);
				if (adapter.FetchEntity(_PhieugiaohangDEntity))
				{
					toReturn = _PhieugiaohangDEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection( new PhieugiaohangDEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, null, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySophieu(System.String Sophieu)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Sophieu == Sophieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectBySophieuRDT(System.String Sophieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Sophieu == Sophieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaygiao(System.DateTime Ngaygiao)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaygiaoRDT(System.DateTime Ngaygiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMadon(System.String Madon)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByMadonRDT(System.String Madon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDonchitietId(System.Int64 DonchitietId)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.DonchitietId == DonchitietId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByDonchitietIdRDT(System.Int64 DonchitietId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.DonchitietId == DonchitietId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaydat(System.DateTime Ngaydat)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaydatRDT(System.DateTime Ngaydat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLoaihang(System.String Loaihang)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Loaihang == Loaihang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByLoaihangRDT(System.String Loaihang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Loaihang == Loaihang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasp(System.String Masp)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByMaspRDT(System.String Masp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenhang(System.String Tenhang)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Tenhang == Tenhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByTenhangRDT(System.String Tenhang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Tenhang == Tenhang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluong(System.Decimal Soluong)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongRDT(System.Decimal Soluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDongia(System.Decimal Dongia)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Dongia == Dongia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByDongiaRDT(System.Decimal Dongia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Dongia == Dongia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThanhtien(System.Decimal Thanhtien)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Thanhtien == Thanhtien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByThanhtienRDT(System.Decimal Thanhtien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Thanhtien == Thanhtien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByGhichu(System.String Ghichu)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByGhichuRDT(System.String Ghichu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangDCollection, filter, 0, null);
			}
			return _PhieugiaohangDCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangDCollection = new EntityCollection(new PhieugiaohangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangDFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(PhieugiaohangDFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
