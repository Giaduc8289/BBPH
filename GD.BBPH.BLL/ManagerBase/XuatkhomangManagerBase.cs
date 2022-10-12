


/*
'===============================================================================
'  GD.BBPH.BL.XuatkhomangManagerBase
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
	public class XuatkhomangManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngayxuat="Ngayxuat";				
		
		public const String Field_Makho="Makho";				
		
		public const String Field_Tenkho="Tenkho";				
		
		public const String Field_Mamang="Mamang";				
		
		public const String Field_Tenmang="Tenmang";				
		
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
		public XuatkhomangManagerBase()
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
			
			dt.Columns.Add(Field_Mamang,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmang,typeof(System.String));
			
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
		public DataRow Convert(XuatkhomangEntity _XuatkhomangEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_XuatkhomangEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngayxuat]=_XuatkhomangEntity.Ngayxuat;
			}
			catch { }
			
			try
			{
				r[Field_Makho]=_XuatkhomangEntity.Makho;
			}
			catch { }
			
			try
			{
				r[Field_Tenkho]=_XuatkhomangEntity.Tenkho;
			}
			catch { }
			
			try
			{
				r[Field_Mamang]=_XuatkhomangEntity.Mamang;
			}
			catch { }
			
			try
			{
				r[Field_Tenmang]=_XuatkhomangEntity.Tenmang;
			}
			catch { }
			
			try
			{
				r[Field_Somet]=_XuatkhomangEntity.Somet;
			}
			catch { }
			
			try
			{
				r[Field_Sokg]=_XuatkhomangEntity.Sokg;
			}
			catch { }
			
			try
			{
				r[Field_Malydo]=_XuatkhomangEntity.Malydo;
			}
			catch { }
			
			try
			{
				r[Field_Tenlydo]=_XuatkhomangEntity.Tenlydo;
			}
			catch { }
			
			try
			{
				r[Field_Lenhsx]=_XuatkhomangEntity.Lenhsx;
			}
			catch { }
			
			try
			{
				r[Field_Sophieugiao]=_XuatkhomangEntity.Sophieugiao;
			}
			catch { }
			
			try
			{
				r[Field_Madonhang]=_XuatkhomangEntity.Madonhang;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_XuatkhomangEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_XuatkhomangEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_XuatkhomangEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_XuatkhomangEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public XuatkhomangEntity Convert(DataRow r)
		{	
			
			XuatkhomangEntity _XuatkhomangEntity=new XuatkhomangEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_XuatkhomangEntity.Ngayxuat= System.DateTime.Parse(r[Field_Ngayxuat].ToString());						
			}
			catch { }
			
			try
			{
				_XuatkhomangEntity.Makho= r[Field_Makho].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhomangEntity.Tenkho= r[Field_Tenkho].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhomangEntity.Mamang= r[Field_Mamang].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhomangEntity.Tenmang= r[Field_Tenmang].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhomangEntity.Somet= System.Decimal.Parse(r[Field_Somet].ToString());						
			}
			catch { }
			
			try
			{
				_XuatkhomangEntity.Sokg= System.Decimal.Parse(r[Field_Sokg].ToString());						
			}
			catch { }
			
			try
			{
				_XuatkhomangEntity.Malydo= r[Field_Malydo].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhomangEntity.Tenlydo= r[Field_Tenlydo].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhomangEntity.Lenhsx= r[Field_Lenhsx].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhomangEntity.Sophieugiao= r[Field_Sophieugiao].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhomangEntity.Madonhang= r[Field_Madonhang].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhomangEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_XuatkhomangEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhomangEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_XuatkhomangEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _XuatkhomangEntity;
		}			
		
		public XuatkhomangEntity Convert_Entity(XuatkhomangEntity _XuatkhomangEntity,XuatkhomangEntity _XuatkhomangEntity_XML)
		{	
			
			
			_XuatkhomangEntity.Id= _XuatkhomangEntity_XML.Id;
			
			_XuatkhomangEntity.Ngayxuat= _XuatkhomangEntity_XML.Ngayxuat;
			
			_XuatkhomangEntity.Makho= _XuatkhomangEntity_XML.Makho;
			
			_XuatkhomangEntity.Tenkho= _XuatkhomangEntity_XML.Tenkho;
			
			_XuatkhomangEntity.Mamang= _XuatkhomangEntity_XML.Mamang;
			
			_XuatkhomangEntity.Tenmang= _XuatkhomangEntity_XML.Tenmang;
			
			_XuatkhomangEntity.Somet= _XuatkhomangEntity_XML.Somet;
			
			_XuatkhomangEntity.Sokg= _XuatkhomangEntity_XML.Sokg;
			
			_XuatkhomangEntity.Malydo= _XuatkhomangEntity_XML.Malydo;
			
			_XuatkhomangEntity.Tenlydo= _XuatkhomangEntity_XML.Tenlydo;
			
			_XuatkhomangEntity.Lenhsx= _XuatkhomangEntity_XML.Lenhsx;
			
			_XuatkhomangEntity.Sophieugiao= _XuatkhomangEntity_XML.Sophieugiao;
			
			_XuatkhomangEntity.Madonhang= _XuatkhomangEntity_XML.Madonhang;
			
			_XuatkhomangEntity.Ngaytao= _XuatkhomangEntity_XML.Ngaytao;
			
			_XuatkhomangEntity.Nguoitao= _XuatkhomangEntity_XML.Nguoitao;
			
			_XuatkhomangEntity.Ngaysua= _XuatkhomangEntity_XML.Ngaysua;
			
			_XuatkhomangEntity.Nguoisua= _XuatkhomangEntity_XML.Nguoisua;
									
				
			return _XuatkhomangEntity;
		}	
		
		public String InsertV2(XuatkhomangEntity _XuatkhomangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new XuatkhomangManagerBase()).Insert(_XuatkhomangEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_XuatkhomangEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngayxuat,_XuatkhomangEntity.Ngayxuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_XuatkhomangEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_XuatkhomangEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang,_XuatkhomangEntity.Mamang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang,_XuatkhomangEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_XuatkhomangEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_XuatkhomangEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Malydo,_XuatkhomangEntity.Malydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenlydo,_XuatkhomangEntity.Tenlydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhsx,_XuatkhomangEntity.Lenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sophieugiao,_XuatkhomangEntity.Sophieugiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madonhang,_XuatkhomangEntity.Madonhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_XuatkhomangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_XuatkhomangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_XuatkhomangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_XuatkhomangEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(XuatkhomangEntity _XuatkhomangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new XuatkhomangManagerBase()).Update(_XuatkhomangEntity);
			r.SetField(Field_Id,_XuatkhomangEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngayxuat,_XuatkhomangEntity.Ngayxuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_XuatkhomangEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_XuatkhomangEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang,_XuatkhomangEntity.Mamang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang,_XuatkhomangEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_XuatkhomangEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_XuatkhomangEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Malydo,_XuatkhomangEntity.Malydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenlydo,_XuatkhomangEntity.Tenlydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhsx,_XuatkhomangEntity.Lenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sophieugiao,_XuatkhomangEntity.Sophieugiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madonhang,_XuatkhomangEntity.Madonhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_XuatkhomangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_XuatkhomangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_XuatkhomangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_XuatkhomangEntity.Nguoisua);
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

		public XuatkhomangEntity Insert(XuatkhomangEntity XuatkhomangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(XuatkhomangEntity, true);
			}
			return XuatkhomangEntity;
		}

		public XuatkhomangEntity Insert(System.Int64  Id, System.DateTime  Ngayxuat, System.String  Makho, System.String  Tenkho, System.String  Mamang, System.String  Tenmang, System.Decimal  Somet, System.Decimal  Sokg, System.String  Malydo, System.String  Tenlydo, System.String  Lenhsx, System.String  Sophieugiao, System.String  Madonhang, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			XuatkhomangEntity _XuatkhomangEntity = new XuatkhomangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_XuatkhomangEntity.Id = Id;
				
				_XuatkhomangEntity.Ngayxuat = Ngayxuat;
				
				_XuatkhomangEntity.Makho = Makho;
				
				_XuatkhomangEntity.Tenkho = Tenkho;
				
				_XuatkhomangEntity.Mamang = Mamang;
				
				_XuatkhomangEntity.Tenmang = Tenmang;
				
				_XuatkhomangEntity.Somet = Somet;
				
				_XuatkhomangEntity.Sokg = Sokg;
				
				_XuatkhomangEntity.Malydo = Malydo;
				
				_XuatkhomangEntity.Tenlydo = Tenlydo;
				
				_XuatkhomangEntity.Lenhsx = Lenhsx;
				
				_XuatkhomangEntity.Sophieugiao = Sophieugiao;
				
				_XuatkhomangEntity.Madonhang = Madonhang;
				
				_XuatkhomangEntity.Ngaytao = Ngaytao;
				
				_XuatkhomangEntity.Nguoitao = Nguoitao;
				
				_XuatkhomangEntity.Ngaysua = Ngaysua;
				
				_XuatkhomangEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_XuatkhomangEntity, true);
			}
			return _XuatkhomangEntity;
		}

		public XuatkhomangEntity Insert(System.DateTime Ngayxuat, System.String Makho, System.String Tenkho, System.String Mamang, System.String Tenmang, System.Decimal Somet, System.Decimal Sokg, System.String Malydo, System.String Tenlydo, System.String Lenhsx, System.String Sophieugiao, System.String Madonhang, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			XuatkhomangEntity _XuatkhomangEntity = new XuatkhomangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_XuatkhomangEntity.Ngayxuat = Ngayxuat;
				
				_XuatkhomangEntity.Makho = Makho;
				
				_XuatkhomangEntity.Tenkho = Tenkho;
				
				_XuatkhomangEntity.Mamang = Mamang;
				
				_XuatkhomangEntity.Tenmang = Tenmang;
				
				_XuatkhomangEntity.Somet = Somet;
				
				_XuatkhomangEntity.Sokg = Sokg;
				
				_XuatkhomangEntity.Malydo = Malydo;
				
				_XuatkhomangEntity.Tenlydo = Tenlydo;
				
				_XuatkhomangEntity.Lenhsx = Lenhsx;
				
				_XuatkhomangEntity.Sophieugiao = Sophieugiao;
				
				_XuatkhomangEntity.Madonhang = Madonhang;
				
				_XuatkhomangEntity.Ngaytao = Ngaytao;
				
				_XuatkhomangEntity.Nguoitao = Nguoitao;
				
				_XuatkhomangEntity.Ngaysua = Ngaysua;
				
				_XuatkhomangEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_XuatkhomangEntity, true);
			}
			return _XuatkhomangEntity;
		}

		public bool Update(XuatkhomangEntity _XuatkhomangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(XuatkhomangFields.Id == _XuatkhomangEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_XuatkhomangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(XuatkhomangEntity _XuatkhomangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_XuatkhomangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngayxuat, System.String Makho, System.String Tenkho, System.String Mamang, System.String Tenmang, System.Decimal Somet, System.Decimal Sokg, System.String Malydo, System.String Tenlydo, System.String Lenhsx, System.String Sophieugiao, System.String Madonhang, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				XuatkhomangEntity _XuatkhomangEntity = new XuatkhomangEntity(Id);
				if (adapter.FetchEntity(_XuatkhomangEntity))
				{
				
					
					
					_XuatkhomangEntity.Ngayxuat = Ngayxuat;
					
					_XuatkhomangEntity.Makho = Makho;
					
					_XuatkhomangEntity.Tenkho = Tenkho;
					
					_XuatkhomangEntity.Mamang = Mamang;
					
					_XuatkhomangEntity.Tenmang = Tenmang;
					
					_XuatkhomangEntity.Somet = Somet;
					
					_XuatkhomangEntity.Sokg = Sokg;
					
					_XuatkhomangEntity.Malydo = Malydo;
					
					_XuatkhomangEntity.Tenlydo = Tenlydo;
					
					_XuatkhomangEntity.Lenhsx = Lenhsx;
					
					_XuatkhomangEntity.Sophieugiao = Sophieugiao;
					
					_XuatkhomangEntity.Madonhang = Madonhang;
					
					_XuatkhomangEntity.Ngaytao = Ngaytao;
					
					_XuatkhomangEntity.Nguoitao = Nguoitao;
					
					_XuatkhomangEntity.Ngaysua = Ngaysua;
					
					_XuatkhomangEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_XuatkhomangEntity, true);
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
				XuatkhomangEntity _XuatkhomangEntity = new XuatkhomangEntity(Id);
				if (adapter.FetchEntity(_XuatkhomangEntity))
				{
					adapter.DeleteEntity(_XuatkhomangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("XuatkhomangEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgayxuat(System.DateTime Ngayxuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Ngayxuat == Ngayxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakho(System.String Makho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkho(System.String Tenkho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamang(System.String Mamang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmang(System.String Tenmang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomet(System.Decimal Somet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokg(System.Decimal Sokg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMalydo(System.String Malydo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenlydo(System.String Tenlydo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLenhsx(System.String Lenhsx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Lenhsx == Lenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySophieugiao(System.String Sophieugiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Sophieugiao == Sophieugiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMadonhang(System.String Madonhang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Madonhang == Madonhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhomangEntity", filter);
			}
			return toReturn;
		}		
			
		
		public XuatkhomangEntity SelectOne(System.Int64 Id)
		{
			XuatkhomangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				XuatkhomangEntity _XuatkhomangEntity = new XuatkhomangEntity(Id);
				if (adapter.FetchEntity(_XuatkhomangEntity))
				{
					toReturn = _XuatkhomangEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection( new XuatkhomangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, null, 0, null);
			}
			return _XuatkhomangCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgayxuat(System.DateTime Ngayxuat)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Ngayxuat == Ngayxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayxuatRDT(System.DateTime Ngayxuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Ngayxuat == Ngayxuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakho(System.String Makho)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhoRDT(System.String Makho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkho(System.String Tenkho)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhoRDT(System.String Tenkho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamang(System.String Mamang)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByMamangRDT(System.String Mamang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmang(System.String Tenmang)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmangRDT(System.String Tenmang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomet(System.Decimal Somet)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectBySometRDT(System.Decimal Somet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokg(System.Decimal Sokg)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgRDT(System.Decimal Sokg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMalydo(System.String Malydo)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByMalydoRDT(System.String Malydo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenlydo(System.String Tenlydo)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenlydoRDT(System.String Tenlydo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLenhsx(System.String Lenhsx)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Lenhsx == Lenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByLenhsxRDT(System.String Lenhsx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Lenhsx == Lenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySophieugiao(System.String Sophieugiao)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Sophieugiao == Sophieugiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectBySophieugiaoRDT(System.String Sophieugiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Sophieugiao == Sophieugiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMadonhang(System.String Madonhang)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Madonhang == Madonhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByMadonhangRDT(System.String Madonhang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Madonhang == Madonhang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhomangCollection, filter, 0, null);
			}
			return _XuatkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhomangCollection = new EntityCollection(new XuatkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhomangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
