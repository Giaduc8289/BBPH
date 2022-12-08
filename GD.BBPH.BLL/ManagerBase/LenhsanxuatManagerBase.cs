


/*
'===============================================================================
'  GD.BBPH.BL.LenhsanxuatManagerBase
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
	public class LenhsanxuatManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Solenhsx="Solenhsx";				
		
		public const String Field_Ngayphatlenh="Ngayphatlenh";				
		
		public const String Field_Ngaybatdausx="Ngaybatdausx";				
		
		public const String Field_Ngayhoanthanhsx="Ngayhoanthanhsx";				
		
		public const String Field_Madon="Madon";				
		
		public const String Field_Ngaydat="Ngaydat";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Madonhangchitiet="Madonhangchitiet";				
		
		public const String Field_Loaihang="Loaihang";				
		
		public const String Field_Soluong="Soluong";				
		
		public const String Field_Ngaygiao="Ngaygiao";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Masanpham="Masanpham";				
		
		public const String Field_Tensanpham="Tensanpham";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LenhsanxuatManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Solenhsx,typeof(System.String));
			
			dt.Columns.Add(Field_Ngayphatlenh,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Ngaybatdausx,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Ngayhoanthanhsx,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Madon,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaydat,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Madonhangchitiet,typeof(System.Int64));
			
			dt.Columns.Add(Field_Loaihang,typeof(System.Int32));
			
			dt.Columns.Add(Field_Soluong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaygiao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Masanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Tensanpham,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(LenhsanxuatEntity _LenhsanxuatEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Solenhsx]=_LenhsanxuatEntity.Solenhsx;
			}
			catch { }
			
			try
			{
				r[Field_Ngayphatlenh]=_LenhsanxuatEntity.Ngayphatlenh;
			}
			catch { }
			
			try
			{
				r[Field_Ngaybatdausx]=_LenhsanxuatEntity.Ngaybatdausx;
			}
			catch { }
			
			try
			{
				r[Field_Ngayhoanthanhsx]=_LenhsanxuatEntity.Ngayhoanthanhsx;
			}
			catch { }
			
			try
			{
				r[Field_Madon]=_LenhsanxuatEntity.Madon;
			}
			catch { }
			
			try
			{
				r[Field_Ngaydat]=_LenhsanxuatEntity.Ngaydat;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_LenhsanxuatEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_LenhsanxuatEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Madonhangchitiet]=_LenhsanxuatEntity.Madonhangchitiet;
			}
			catch { }
			
			try
			{
				r[Field_Loaihang]=_LenhsanxuatEntity.Loaihang;
			}
			catch { }
			
			try
			{
				r[Field_Soluong]=_LenhsanxuatEntity.Soluong;
			}
			catch { }
			
			try
			{
				r[Field_Ngaygiao]=_LenhsanxuatEntity.Ngaygiao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_LenhsanxuatEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_LenhsanxuatEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_LenhsanxuatEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_LenhsanxuatEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_LenhsanxuatEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Tensanpham]=_LenhsanxuatEntity.Tensanpham;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public LenhsanxuatEntity Convert(DataRow r)
		{	
			
			LenhsanxuatEntity _LenhsanxuatEntity=new LenhsanxuatEntity(r[Field_Solenhsx].ToString());					
						
			
			
			try
			{
				_LenhsanxuatEntity.Ngayphatlenh= System.DateTime.Parse(r[Field_Ngayphatlenh].ToString());						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Ngaybatdausx= System.DateTime.Parse(r[Field_Ngaybatdausx].ToString());						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Ngayhoanthanhsx= System.DateTime.Parse(r[Field_Ngayhoanthanhsx].ToString());						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Madon= r[Field_Madon].ToString();						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Ngaydat= System.DateTime.Parse(r[Field_Ngaydat].ToString());						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Madonhangchitiet= System.Int64.Parse(r[Field_Madonhangchitiet].ToString());						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Loaihang= System.Int32.Parse(r[Field_Loaihang].ToString());						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Soluong= System.Decimal.Parse(r[Field_Soluong].ToString());						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Ngaygiao= System.DateTime.Parse(r[Field_Ngaygiao].ToString());						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_LenhsanxuatEntity.Tensanpham= r[Field_Tensanpham].ToString();						
			}
			catch { }
									
									
			return _LenhsanxuatEntity;
		}			
		
		public LenhsanxuatEntity Convert_Entity(LenhsanxuatEntity _LenhsanxuatEntity,LenhsanxuatEntity _LenhsanxuatEntity_XML)
		{	
			
			
			_LenhsanxuatEntity.Solenhsx= _LenhsanxuatEntity_XML.Solenhsx;
			
			_LenhsanxuatEntity.Ngayphatlenh= _LenhsanxuatEntity_XML.Ngayphatlenh;
			
			_LenhsanxuatEntity.Ngaybatdausx= _LenhsanxuatEntity_XML.Ngaybatdausx;
			
			_LenhsanxuatEntity.Ngayhoanthanhsx= _LenhsanxuatEntity_XML.Ngayhoanthanhsx;
			
			_LenhsanxuatEntity.Madon= _LenhsanxuatEntity_XML.Madon;
			
			_LenhsanxuatEntity.Ngaydat= _LenhsanxuatEntity_XML.Ngaydat;
			
			_LenhsanxuatEntity.Makhach= _LenhsanxuatEntity_XML.Makhach;
			
			_LenhsanxuatEntity.Tenkhach= _LenhsanxuatEntity_XML.Tenkhach;
			
			_LenhsanxuatEntity.Madonhangchitiet= _LenhsanxuatEntity_XML.Madonhangchitiet;
			
			_LenhsanxuatEntity.Loaihang= _LenhsanxuatEntity_XML.Loaihang;
			
			_LenhsanxuatEntity.Soluong= _LenhsanxuatEntity_XML.Soluong;
			
			_LenhsanxuatEntity.Ngaygiao= _LenhsanxuatEntity_XML.Ngaygiao;
			
			_LenhsanxuatEntity.Ngaytao= _LenhsanxuatEntity_XML.Ngaytao;
			
			_LenhsanxuatEntity.Nguoitao= _LenhsanxuatEntity_XML.Nguoitao;
			
			_LenhsanxuatEntity.Ngaysua= _LenhsanxuatEntity_XML.Ngaysua;
			
			_LenhsanxuatEntity.Nguoisua= _LenhsanxuatEntity_XML.Nguoisua;
			
			_LenhsanxuatEntity.Masanpham= _LenhsanxuatEntity_XML.Masanpham;
			
			_LenhsanxuatEntity.Tensanpham= _LenhsanxuatEntity_XML.Tensanpham;
									
				
			return _LenhsanxuatEntity;
		}	
		
		public String InsertV2(LenhsanxuatEntity _LenhsanxuatEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new LenhsanxuatManagerBase()).Insert(_LenhsanxuatEntity).Solenhsx.ToString();
			
			
			try
			{
				r.SetField(Field_Solenhsx,_LenhsanxuatEntity.Solenhsx);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngayphatlenh,_LenhsanxuatEntity.Ngayphatlenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaybatdausx,_LenhsanxuatEntity.Ngaybatdausx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngayhoanthanhsx,_LenhsanxuatEntity.Ngayhoanthanhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madon,_LenhsanxuatEntity.Madon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_LenhsanxuatEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_LenhsanxuatEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_LenhsanxuatEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madonhangchitiet,_LenhsanxuatEntity.Madonhangchitiet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaihang,_LenhsanxuatEntity.Loaihang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_LenhsanxuatEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_LenhsanxuatEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_LenhsanxuatEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_LenhsanxuatEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_LenhsanxuatEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_LenhsanxuatEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_LenhsanxuatEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_LenhsanxuatEntity.Tensanpham);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(LenhsanxuatEntity _LenhsanxuatEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new LenhsanxuatManagerBase()).Update(_LenhsanxuatEntity);
			r.SetField(Field_Solenhsx,_LenhsanxuatEntity.Solenhsx);
									
			
			
			
			try
			{
				r.SetField(Field_Ngayphatlenh,_LenhsanxuatEntity.Ngayphatlenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaybatdausx,_LenhsanxuatEntity.Ngaybatdausx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngayhoanthanhsx,_LenhsanxuatEntity.Ngayhoanthanhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madon,_LenhsanxuatEntity.Madon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_LenhsanxuatEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_LenhsanxuatEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_LenhsanxuatEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madonhangchitiet,_LenhsanxuatEntity.Madonhangchitiet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaihang,_LenhsanxuatEntity.Loaihang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_LenhsanxuatEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_LenhsanxuatEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_LenhsanxuatEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_LenhsanxuatEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_LenhsanxuatEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_LenhsanxuatEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_LenhsanxuatEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_LenhsanxuatEntity.Tensanpham);
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

		public LenhsanxuatEntity Insert(LenhsanxuatEntity LenhsanxuatEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(LenhsanxuatEntity, true);
			}
			return LenhsanxuatEntity;
		}

		public LenhsanxuatEntity Insert(System.String  Solenhsx, System.DateTime  Ngayphatlenh, System.DateTime  Ngaybatdausx, System.DateTime  Ngayhoanthanhsx, System.String  Madon, System.DateTime  Ngaydat, System.String  Makhach, System.String  Tenkhach, System.Int64  Madonhangchitiet, System.Int32  Loaihang, System.Decimal  Soluong, System.DateTime  Ngaygiao, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.String  Masanpham, System.String  Tensanpham)
		{
			LenhsanxuatEntity _LenhsanxuatEntity = new LenhsanxuatEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_LenhsanxuatEntity.Solenhsx = Solenhsx;
				
				_LenhsanxuatEntity.Ngayphatlenh = Ngayphatlenh;
				
				_LenhsanxuatEntity.Ngaybatdausx = Ngaybatdausx;
				
				_LenhsanxuatEntity.Ngayhoanthanhsx = Ngayhoanthanhsx;
				
				_LenhsanxuatEntity.Madon = Madon;
				
				_LenhsanxuatEntity.Ngaydat = Ngaydat;
				
				_LenhsanxuatEntity.Makhach = Makhach;
				
				_LenhsanxuatEntity.Tenkhach = Tenkhach;
				
				_LenhsanxuatEntity.Madonhangchitiet = Madonhangchitiet;
				
				_LenhsanxuatEntity.Loaihang = Loaihang;
				
				_LenhsanxuatEntity.Soluong = Soluong;
				
				_LenhsanxuatEntity.Ngaygiao = Ngaygiao;
				
				_LenhsanxuatEntity.Ngaytao = Ngaytao;
				
				_LenhsanxuatEntity.Nguoitao = Nguoitao;
				
				_LenhsanxuatEntity.Ngaysua = Ngaysua;
				
				_LenhsanxuatEntity.Nguoisua = Nguoisua;
				
				_LenhsanxuatEntity.Masanpham = Masanpham;
				
				_LenhsanxuatEntity.Tensanpham = Tensanpham;
					
					
				adapter.SaveEntity(_LenhsanxuatEntity, true);
			}
			return _LenhsanxuatEntity;
		}

		public LenhsanxuatEntity Insert(System.DateTime Ngayphatlenh, System.DateTime Ngaybatdausx, System.DateTime Ngayhoanthanhsx, System.String Madon, System.DateTime Ngaydat, System.String Makhach, System.String Tenkhach, System.Int64 Madonhangchitiet, System.Int32 Loaihang, System.Decimal Soluong, System.DateTime Ngaygiao, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.String Masanpham, System.String Tensanpham)//ko co mahieu
		{
			LenhsanxuatEntity _LenhsanxuatEntity = new LenhsanxuatEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_LenhsanxuatEntity.Ngayphatlenh = Ngayphatlenh;
				
				_LenhsanxuatEntity.Ngaybatdausx = Ngaybatdausx;
				
				_LenhsanxuatEntity.Ngayhoanthanhsx = Ngayhoanthanhsx;
				
				_LenhsanxuatEntity.Madon = Madon;
				
				_LenhsanxuatEntity.Ngaydat = Ngaydat;
				
				_LenhsanxuatEntity.Makhach = Makhach;
				
				_LenhsanxuatEntity.Tenkhach = Tenkhach;
				
				_LenhsanxuatEntity.Madonhangchitiet = Madonhangchitiet;
				
				_LenhsanxuatEntity.Loaihang = Loaihang;
				
				_LenhsanxuatEntity.Soluong = Soluong;
				
				_LenhsanxuatEntity.Ngaygiao = Ngaygiao;
				
				_LenhsanxuatEntity.Ngaytao = Ngaytao;
				
				_LenhsanxuatEntity.Nguoitao = Nguoitao;
				
				_LenhsanxuatEntity.Ngaysua = Ngaysua;
				
				_LenhsanxuatEntity.Nguoisua = Nguoisua;
				
				_LenhsanxuatEntity.Masanpham = Masanpham;
				
				_LenhsanxuatEntity.Tensanpham = Tensanpham;
					

				adapter.SaveEntity(_LenhsanxuatEntity, true);
			}
			return _LenhsanxuatEntity;
		}

		public bool Update(LenhsanxuatEntity _LenhsanxuatEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(LenhsanxuatFields.Solenhsx == _LenhsanxuatEntity.Solenhsx);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_LenhsanxuatEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(LenhsanxuatEntity _LenhsanxuatEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_LenhsanxuatEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Solenhsx, System.DateTime Ngayphatlenh, System.DateTime Ngaybatdausx, System.DateTime Ngayhoanthanhsx, System.String Madon, System.DateTime Ngaydat, System.String Makhach, System.String Tenkhach, System.Int64 Madonhangchitiet, System.Int32 Loaihang, System.Decimal Soluong, System.DateTime Ngaygiao, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.String Masanpham, System.String Tensanpham)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LenhsanxuatEntity _LenhsanxuatEntity = new LenhsanxuatEntity(Solenhsx);
				if (adapter.FetchEntity(_LenhsanxuatEntity))
				{
				
					
					
					_LenhsanxuatEntity.Ngayphatlenh = Ngayphatlenh;
					
					_LenhsanxuatEntity.Ngaybatdausx = Ngaybatdausx;
					
					_LenhsanxuatEntity.Ngayhoanthanhsx = Ngayhoanthanhsx;
					
					_LenhsanxuatEntity.Madon = Madon;
					
					_LenhsanxuatEntity.Ngaydat = Ngaydat;
					
					_LenhsanxuatEntity.Makhach = Makhach;
					
					_LenhsanxuatEntity.Tenkhach = Tenkhach;
					
					_LenhsanxuatEntity.Madonhangchitiet = Madonhangchitiet;
					
					_LenhsanxuatEntity.Loaihang = Loaihang;
					
					_LenhsanxuatEntity.Soluong = Soluong;
					
					_LenhsanxuatEntity.Ngaygiao = Ngaygiao;
					
					_LenhsanxuatEntity.Ngaytao = Ngaytao;
					
					_LenhsanxuatEntity.Nguoitao = Nguoitao;
					
					_LenhsanxuatEntity.Ngaysua = Ngaysua;
					
					_LenhsanxuatEntity.Nguoisua = Nguoisua;
					
					_LenhsanxuatEntity.Masanpham = Masanpham;
					
					_LenhsanxuatEntity.Tensanpham = Tensanpham;
						

					adapter.SaveEntity(_LenhsanxuatEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Solenhsx)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LenhsanxuatEntity _LenhsanxuatEntity = new LenhsanxuatEntity(Solenhsx);
				if (adapter.FetchEntity(_LenhsanxuatEntity))
				{
					adapter.DeleteEntity(_LenhsanxuatEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", null);
			}
		}
		
		
		
		public int DeleteBySolenhsx(System.String Solenhsx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgayphatlenh(System.DateTime Ngayphatlenh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngayphatlenh == Ngayphatlenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaybatdausx(System.DateTime Ngaybatdausx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngaybatdausx == Ngaybatdausx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgayhoanthanhsx(System.DateTime Ngayhoanthanhsx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngayhoanthanhsx == Ngayhoanthanhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMadon(System.String Madon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaydat(System.DateTime Ngaydat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMadonhangchitiet(System.Int64 Madonhangchitiet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Madonhangchitiet == Madonhangchitiet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLoaihang(System.Int32 Loaihang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Loaihang == Loaihang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluong(System.Decimal Soluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaygiao(System.DateTime Ngaygiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensanpham(System.String Tensanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LenhsanxuatEntity", filter);
			}
			return toReturn;
		}		
			
		
		public LenhsanxuatEntity SelectOne(System.String Solenhsx)
		{
			LenhsanxuatEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LenhsanxuatEntity _LenhsanxuatEntity = new LenhsanxuatEntity(Solenhsx);
				if (adapter.FetchEntity(_LenhsanxuatEntity))
				{
					toReturn = _LenhsanxuatEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection( new LenhsanxuatEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, null, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectBySolenhsx(System.String Solenhsx)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectBySolenhsxRDT(System.String Solenhsx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgayphatlenh(System.DateTime Ngayphatlenh)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngayphatlenh == Ngayphatlenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayphatlenhRDT(System.DateTime Ngayphatlenh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngayphatlenh == Ngayphatlenh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaybatdausx(System.DateTime Ngaybatdausx)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngaybatdausx == Ngaybatdausx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaybatdausxRDT(System.DateTime Ngaybatdausx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngaybatdausx == Ngaybatdausx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgayhoanthanhsx(System.DateTime Ngayhoanthanhsx)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngayhoanthanhsx == Ngayhoanthanhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayhoanthanhsxRDT(System.DateTime Ngayhoanthanhsx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngayhoanthanhsx == Ngayhoanthanhsx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMadon(System.String Madon)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByMadonRDT(System.String Madon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaydat(System.DateTime Ngaydat)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaydatRDT(System.DateTime Ngaydat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMadonhangchitiet(System.Int64 Madonhangchitiet)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Madonhangchitiet == Madonhangchitiet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByMadonhangchitietRDT(System.Int64 Madonhangchitiet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Madonhangchitiet == Madonhangchitiet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLoaihang(System.Int32 Loaihang)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Loaihang == Loaihang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByLoaihangRDT(System.Int32 Loaihang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Loaihang == Loaihang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluong(System.Decimal Soluong)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongRDT(System.Decimal Soluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaygiao(System.DateTime Ngaygiao)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaygiaoRDT(System.DateTime Ngaygiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensanpham(System.String Tensanpham)
		{
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LenhsanxuatCollection, filter, 0, null);
			}
			return _LenhsanxuatCollection;
		}
		// Return DataTable
		public DataTable SelectByTensanphamRDT(System.String Tensanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LenhsanxuatCollection = new EntityCollection(new LenhsanxuatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LenhsanxuatFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LenhsanxuatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(LenhsanxuatFields.Solenhsx.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
