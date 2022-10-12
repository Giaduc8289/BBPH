


/*
'===============================================================================
'  GD.BBPH.BL.XuatkhosanphamManagerBase
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
	public class XuatkhosanphamManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngayxuat="Ngayxuat";				
		
		public const String Field_Makho="Makho";				
		
		public const String Field_Tenkho="Tenkho";				
		
		public const String Field_Masanpham="Masanpham";				
		
		public const String Field_Tensanpham="Tensanpham";				
		
		public const String Field_Soluong="Soluong";				
		
		public const String Field_Somet="Somet";				
		
		public const String Field_Sokg="Sokg";				
		
		public const String Field_Malydo="Malydo";				
		
		public const String Field_Tenlydo="Tenlydo";				
		
		public const String Field_Lenhsx="Lenhsx";				
		
		public const String Field_Sophieugiao="Sophieugiao";				
		
		public const String Field_Madonhang="Madonhang";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XuatkhosanphamManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Ngayxuat,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Makho,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkho,typeof(System.String));
			
			dt.Columns.Add(Field_Masanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Tensanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Soluong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Somet,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokg,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Malydo,typeof(System.String));
			
			dt.Columns.Add(Field_Tenlydo,typeof(System.String));
			
			dt.Columns.Add(Field_Lenhsx,typeof(System.String));
			
			dt.Columns.Add(Field_Sophieugiao,typeof(System.String));
			
			dt.Columns.Add(Field_Madonhang,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(XuatkhosanphamEntity _XuatkhosanphamEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_XuatkhosanphamEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngayxuat]=_XuatkhosanphamEntity.Ngayxuat;
			}
			catch { }
			
			try
			{
				r[Field_Makho]=_XuatkhosanphamEntity.Makho;
			}
			catch { }
			
			try
			{
				r[Field_Tenkho]=_XuatkhosanphamEntity.Tenkho;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_XuatkhosanphamEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Tensanpham]=_XuatkhosanphamEntity.Tensanpham;
			}
			catch { }
			
			try
			{
				r[Field_Soluong]=_XuatkhosanphamEntity.Soluong;
			}
			catch { }
			
			try
			{
				r[Field_Somet]=_XuatkhosanphamEntity.Somet;
			}
			catch { }
			
			try
			{
				r[Field_Sokg]=_XuatkhosanphamEntity.Sokg;
			}
			catch { }
			
			try
			{
				r[Field_Malydo]=_XuatkhosanphamEntity.Malydo;
			}
			catch { }
			
			try
			{
				r[Field_Tenlydo]=_XuatkhosanphamEntity.Tenlydo;
			}
			catch { }
			
			try
			{
				r[Field_Lenhsx]=_XuatkhosanphamEntity.Lenhsx;
			}
			catch { }
			
			try
			{
				r[Field_Sophieugiao]=_XuatkhosanphamEntity.Sophieugiao;
			}
			catch { }
			
			try
			{
				r[Field_Madonhang]=_XuatkhosanphamEntity.Madonhang;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_XuatkhosanphamEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_XuatkhosanphamEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_XuatkhosanphamEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_XuatkhosanphamEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public XuatkhosanphamEntity Convert(DataRow r)
		{	
			
			XuatkhosanphamEntity _XuatkhosanphamEntity=new XuatkhosanphamEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_XuatkhosanphamEntity.Ngayxuat= System.DateTime.Parse(r[Field_Ngayxuat].ToString());						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Makho= r[Field_Makho].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Tenkho= r[Field_Tenkho].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Tensanpham= r[Field_Tensanpham].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Soluong= System.Decimal.Parse(r[Field_Soluong].ToString());						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Somet= System.Decimal.Parse(r[Field_Somet].ToString());						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Sokg= System.Decimal.Parse(r[Field_Sokg].ToString());						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Malydo= r[Field_Malydo].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Tenlydo= r[Field_Tenlydo].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Lenhsx= r[Field_Lenhsx].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Sophieugiao= r[Field_Sophieugiao].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Madonhang= r[Field_Madonhang].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_XuatkhosanphamEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _XuatkhosanphamEntity;
		}			
		
		public XuatkhosanphamEntity Convert_Entity(XuatkhosanphamEntity _XuatkhosanphamEntity,XuatkhosanphamEntity _XuatkhosanphamEntity_XML)
		{	
			
			
			_XuatkhosanphamEntity.Id= _XuatkhosanphamEntity_XML.Id;
			
			_XuatkhosanphamEntity.Ngayxuat= _XuatkhosanphamEntity_XML.Ngayxuat;
			
			_XuatkhosanphamEntity.Makho= _XuatkhosanphamEntity_XML.Makho;
			
			_XuatkhosanphamEntity.Tenkho= _XuatkhosanphamEntity_XML.Tenkho;
			
			_XuatkhosanphamEntity.Masanpham= _XuatkhosanphamEntity_XML.Masanpham;
			
			_XuatkhosanphamEntity.Tensanpham= _XuatkhosanphamEntity_XML.Tensanpham;
			
			_XuatkhosanphamEntity.Soluong= _XuatkhosanphamEntity_XML.Soluong;
			
			_XuatkhosanphamEntity.Somet= _XuatkhosanphamEntity_XML.Somet;
			
			_XuatkhosanphamEntity.Sokg= _XuatkhosanphamEntity_XML.Sokg;
			
			_XuatkhosanphamEntity.Malydo= _XuatkhosanphamEntity_XML.Malydo;
			
			_XuatkhosanphamEntity.Tenlydo= _XuatkhosanphamEntity_XML.Tenlydo;
			
			_XuatkhosanphamEntity.Lenhsx= _XuatkhosanphamEntity_XML.Lenhsx;
			
			_XuatkhosanphamEntity.Sophieugiao= _XuatkhosanphamEntity_XML.Sophieugiao;
			
			_XuatkhosanphamEntity.Madonhang= _XuatkhosanphamEntity_XML.Madonhang;
			
			_XuatkhosanphamEntity.Ngaytao= _XuatkhosanphamEntity_XML.Ngaytao;
			
			_XuatkhosanphamEntity.Nguoitao= _XuatkhosanphamEntity_XML.Nguoitao;
			
			_XuatkhosanphamEntity.Ngaysua= _XuatkhosanphamEntity_XML.Ngaysua;
			
			_XuatkhosanphamEntity.Nguoisua= _XuatkhosanphamEntity_XML.Nguoisua;
									
				
			return _XuatkhosanphamEntity;
		}	
		
		public String InsertV2(XuatkhosanphamEntity _XuatkhosanphamEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new XuatkhosanphamManagerBase()).Insert(_XuatkhosanphamEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_XuatkhosanphamEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngayxuat,_XuatkhosanphamEntity.Ngayxuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_XuatkhosanphamEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_XuatkhosanphamEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_XuatkhosanphamEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_XuatkhosanphamEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_XuatkhosanphamEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_XuatkhosanphamEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_XuatkhosanphamEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Malydo,_XuatkhosanphamEntity.Malydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenlydo,_XuatkhosanphamEntity.Tenlydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhsx,_XuatkhosanphamEntity.Lenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sophieugiao,_XuatkhosanphamEntity.Sophieugiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madonhang,_XuatkhosanphamEntity.Madonhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_XuatkhosanphamEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_XuatkhosanphamEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_XuatkhosanphamEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_XuatkhosanphamEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(XuatkhosanphamEntity _XuatkhosanphamEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new XuatkhosanphamManagerBase()).Update(_XuatkhosanphamEntity);
			r.SetField(Field_Id,_XuatkhosanphamEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngayxuat,_XuatkhosanphamEntity.Ngayxuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_XuatkhosanphamEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_XuatkhosanphamEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_XuatkhosanphamEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_XuatkhosanphamEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_XuatkhosanphamEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_XuatkhosanphamEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_XuatkhosanphamEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Malydo,_XuatkhosanphamEntity.Malydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenlydo,_XuatkhosanphamEntity.Tenlydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhsx,_XuatkhosanphamEntity.Lenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sophieugiao,_XuatkhosanphamEntity.Sophieugiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madonhang,_XuatkhosanphamEntity.Madonhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_XuatkhosanphamEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_XuatkhosanphamEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_XuatkhosanphamEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_XuatkhosanphamEntity.Nguoisua);
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

		public XuatkhosanphamEntity Insert(XuatkhosanphamEntity XuatkhosanphamEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(XuatkhosanphamEntity, true);
			}
			return XuatkhosanphamEntity;
		}

		public XuatkhosanphamEntity Insert(System.Int64  Id, System.DateTime  Ngayxuat, System.String  Makho, System.String  Tenkho, System.String  Masanpham, System.String  Tensanpham, System.Decimal  Soluong, System.Decimal  Somet, System.Decimal  Sokg, System.String  Malydo, System.String  Tenlydo, System.String  Lenhsx, System.String  Sophieugiao, System.String  Madonhang, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			XuatkhosanphamEntity _XuatkhosanphamEntity = new XuatkhosanphamEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_XuatkhosanphamEntity.Id = Id;
				
				_XuatkhosanphamEntity.Ngayxuat = Ngayxuat;
				
				_XuatkhosanphamEntity.Makho = Makho;
				
				_XuatkhosanphamEntity.Tenkho = Tenkho;
				
				_XuatkhosanphamEntity.Masanpham = Masanpham;
				
				_XuatkhosanphamEntity.Tensanpham = Tensanpham;
				
				_XuatkhosanphamEntity.Soluong = Soluong;
				
				_XuatkhosanphamEntity.Somet = Somet;
				
				_XuatkhosanphamEntity.Sokg = Sokg;
				
				_XuatkhosanphamEntity.Malydo = Malydo;
				
				_XuatkhosanphamEntity.Tenlydo = Tenlydo;
				
				_XuatkhosanphamEntity.Lenhsx = Lenhsx;
				
				_XuatkhosanphamEntity.Sophieugiao = Sophieugiao;
				
				_XuatkhosanphamEntity.Madonhang = Madonhang;
				
				_XuatkhosanphamEntity.Ngaytao = Ngaytao;
				
				_XuatkhosanphamEntity.Nguoitao = Nguoitao;
				
				_XuatkhosanphamEntity.Ngaysua = Ngaysua;
				
				_XuatkhosanphamEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_XuatkhosanphamEntity, true);
			}
			return _XuatkhosanphamEntity;
		}

		public XuatkhosanphamEntity Insert(System.DateTime Ngayxuat, System.String Makho, System.String Tenkho, System.String Masanpham, System.String Tensanpham, System.Decimal Soluong, System.Decimal Somet, System.Decimal Sokg, System.String Malydo, System.String Tenlydo, System.String Lenhsx, System.String Sophieugiao, System.String Madonhang, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			XuatkhosanphamEntity _XuatkhosanphamEntity = new XuatkhosanphamEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_XuatkhosanphamEntity.Ngayxuat = Ngayxuat;
				
				_XuatkhosanphamEntity.Makho = Makho;
				
				_XuatkhosanphamEntity.Tenkho = Tenkho;
				
				_XuatkhosanphamEntity.Masanpham = Masanpham;
				
				_XuatkhosanphamEntity.Tensanpham = Tensanpham;
				
				_XuatkhosanphamEntity.Soluong = Soluong;
				
				_XuatkhosanphamEntity.Somet = Somet;
				
				_XuatkhosanphamEntity.Sokg = Sokg;
				
				_XuatkhosanphamEntity.Malydo = Malydo;
				
				_XuatkhosanphamEntity.Tenlydo = Tenlydo;
				
				_XuatkhosanphamEntity.Lenhsx = Lenhsx;
				
				_XuatkhosanphamEntity.Sophieugiao = Sophieugiao;
				
				_XuatkhosanphamEntity.Madonhang = Madonhang;
				
				_XuatkhosanphamEntity.Ngaytao = Ngaytao;
				
				_XuatkhosanphamEntity.Nguoitao = Nguoitao;
				
				_XuatkhosanphamEntity.Ngaysua = Ngaysua;
				
				_XuatkhosanphamEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_XuatkhosanphamEntity, true);
			}
			return _XuatkhosanphamEntity;
		}

		public bool Update(XuatkhosanphamEntity _XuatkhosanphamEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(XuatkhosanphamFields.Id == _XuatkhosanphamEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_XuatkhosanphamEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(XuatkhosanphamEntity _XuatkhosanphamEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_XuatkhosanphamEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngayxuat, System.String Makho, System.String Tenkho, System.String Masanpham, System.String Tensanpham, System.Decimal Soluong, System.Decimal Somet, System.Decimal Sokg, System.String Malydo, System.String Tenlydo, System.String Lenhsx, System.String Sophieugiao, System.String Madonhang, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				XuatkhosanphamEntity _XuatkhosanphamEntity = new XuatkhosanphamEntity(Id);
				if (adapter.FetchEntity(_XuatkhosanphamEntity))
				{
				
					
					
					_XuatkhosanphamEntity.Ngayxuat = Ngayxuat;
					
					_XuatkhosanphamEntity.Makho = Makho;
					
					_XuatkhosanphamEntity.Tenkho = Tenkho;
					
					_XuatkhosanphamEntity.Masanpham = Masanpham;
					
					_XuatkhosanphamEntity.Tensanpham = Tensanpham;
					
					_XuatkhosanphamEntity.Soluong = Soluong;
					
					_XuatkhosanphamEntity.Somet = Somet;
					
					_XuatkhosanphamEntity.Sokg = Sokg;
					
					_XuatkhosanphamEntity.Malydo = Malydo;
					
					_XuatkhosanphamEntity.Tenlydo = Tenlydo;
					
					_XuatkhosanphamEntity.Lenhsx = Lenhsx;
					
					_XuatkhosanphamEntity.Sophieugiao = Sophieugiao;
					
					_XuatkhosanphamEntity.Madonhang = Madonhang;
					
					_XuatkhosanphamEntity.Ngaytao = Ngaytao;
					
					_XuatkhosanphamEntity.Nguoitao = Nguoitao;
					
					_XuatkhosanphamEntity.Ngaysua = Ngaysua;
					
					_XuatkhosanphamEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_XuatkhosanphamEntity, true);
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
				XuatkhosanphamEntity _XuatkhosanphamEntity = new XuatkhosanphamEntity(Id);
				if (adapter.FetchEntity(_XuatkhosanphamEntity))
				{
					adapter.DeleteEntity(_XuatkhosanphamEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgayxuat(System.DateTime Ngayxuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Ngayxuat == Ngayxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakho(System.String Makho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkho(System.String Tenkho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensanpham(System.String Tensanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluong(System.Decimal Soluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomet(System.Decimal Somet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokg(System.Decimal Sokg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMalydo(System.String Malydo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenlydo(System.String Tenlydo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLenhsx(System.String Lenhsx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Lenhsx == Lenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySophieugiao(System.String Sophieugiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Sophieugiao == Sophieugiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMadonhang(System.String Madonhang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Madonhang == Madonhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhosanphamEntity", filter);
			}
			return toReturn;
		}		
			
		
		public XuatkhosanphamEntity SelectOne(System.Int64 Id)
		{
			XuatkhosanphamEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				XuatkhosanphamEntity _XuatkhosanphamEntity = new XuatkhosanphamEntity(Id);
				if (adapter.FetchEntity(_XuatkhosanphamEntity))
				{
					toReturn = _XuatkhosanphamEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection( new XuatkhosanphamEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, null, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgayxuat(System.DateTime Ngayxuat)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Ngayxuat == Ngayxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayxuatRDT(System.DateTime Ngayxuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Ngayxuat == Ngayxuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakho(System.String Makho)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhoRDT(System.String Makho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkho(System.String Tenkho)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhoRDT(System.String Tenkho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensanpham(System.String Tensanpham)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByTensanphamRDT(System.String Tensanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluong(System.Decimal Soluong)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongRDT(System.Decimal Soluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomet(System.Decimal Somet)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectBySometRDT(System.Decimal Somet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokg(System.Decimal Sokg)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgRDT(System.Decimal Sokg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMalydo(System.String Malydo)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByMalydoRDT(System.String Malydo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenlydo(System.String Tenlydo)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByTenlydoRDT(System.String Tenlydo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLenhsx(System.String Lenhsx)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Lenhsx == Lenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByLenhsxRDT(System.String Lenhsx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Lenhsx == Lenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySophieugiao(System.String Sophieugiao)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Sophieugiao == Sophieugiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectBySophieugiaoRDT(System.String Sophieugiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Sophieugiao == Sophieugiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMadonhang(System.String Madonhang)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Madonhang == Madonhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByMadonhangRDT(System.String Madonhang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Madonhang == Madonhang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhosanphamCollection, filter, 0, null);
			}
			return _XuatkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhosanphamCollection = new EntityCollection(new XuatkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhosanphamFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
