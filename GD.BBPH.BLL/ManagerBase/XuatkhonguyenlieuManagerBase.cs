


/*
'===============================================================================
'  GD.BBPH.BL.XuatkhonguyenlieuManagerBase
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
	public class XuatkhonguyenlieuManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngayxuat="Ngayxuat";				
		
		public const String Field_Makho="Makho";				
		
		public const String Field_Tenkho="Tenkho";				
		
		public const String Field_Manguyenlieu="Manguyenlieu";				
		
		public const String Field_Tennguyenlieu="Tennguyenlieu";				
		
		public const String Field_Donvitinh="Donvitinh";				
		
		public const String Field_Soluong="Soluong";				
		
		public const String Field_Malydo="Malydo";				
		
		public const String Field_Tenlydo="Tenlydo";				
		
		public const String Field_Lenhxuat="Lenhxuat";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XuatkhonguyenlieuManagerBase()
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
			
			dt.Columns.Add(Field_Manguyenlieu,typeof(System.String));
			
			dt.Columns.Add(Field_Tennguyenlieu,typeof(System.String));
			
			dt.Columns.Add(Field_Donvitinh,typeof(System.String));
			
			dt.Columns.Add(Field_Soluong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Malydo,typeof(System.String));
			
			dt.Columns.Add(Field_Tenlydo,typeof(System.String));
			
			dt.Columns.Add(Field_Lenhxuat,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_XuatkhonguyenlieuEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngayxuat]=_XuatkhonguyenlieuEntity.Ngayxuat;
			}
			catch { }
			
			try
			{
				r[Field_Makho]=_XuatkhonguyenlieuEntity.Makho;
			}
			catch { }
			
			try
			{
				r[Field_Tenkho]=_XuatkhonguyenlieuEntity.Tenkho;
			}
			catch { }
			
			try
			{
				r[Field_Manguyenlieu]=_XuatkhonguyenlieuEntity.Manguyenlieu;
			}
			catch { }
			
			try
			{
				r[Field_Tennguyenlieu]=_XuatkhonguyenlieuEntity.Tennguyenlieu;
			}
			catch { }
			
			try
			{
				r[Field_Donvitinh]=_XuatkhonguyenlieuEntity.Donvitinh;
			}
			catch { }
			
			try
			{
				r[Field_Soluong]=_XuatkhonguyenlieuEntity.Soluong;
			}
			catch { }
			
			try
			{
				r[Field_Malydo]=_XuatkhonguyenlieuEntity.Malydo;
			}
			catch { }
			
			try
			{
				r[Field_Tenlydo]=_XuatkhonguyenlieuEntity.Tenlydo;
			}
			catch { }
			
			try
			{
				r[Field_Lenhxuat]=_XuatkhonguyenlieuEntity.Lenhxuat;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_XuatkhonguyenlieuEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_XuatkhonguyenlieuEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_XuatkhonguyenlieuEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_XuatkhonguyenlieuEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public XuatkhonguyenlieuEntity Convert(DataRow r)
		{	
			
			XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity=new XuatkhonguyenlieuEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_XuatkhonguyenlieuEntity.Ngayxuat= System.DateTime.Parse(r[Field_Ngayxuat].ToString());						
			}
			catch { }
			
			try
			{
				_XuatkhonguyenlieuEntity.Makho= r[Field_Makho].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhonguyenlieuEntity.Tenkho= r[Field_Tenkho].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhonguyenlieuEntity.Manguyenlieu= r[Field_Manguyenlieu].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhonguyenlieuEntity.Tennguyenlieu= r[Field_Tennguyenlieu].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhonguyenlieuEntity.Donvitinh= r[Field_Donvitinh].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhonguyenlieuEntity.Soluong= System.Decimal.Parse(r[Field_Soluong].ToString());						
			}
			catch { }
			
			try
			{
				_XuatkhonguyenlieuEntity.Malydo= r[Field_Malydo].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhonguyenlieuEntity.Tenlydo= r[Field_Tenlydo].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhonguyenlieuEntity.Lenhxuat= r[Field_Lenhxuat].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhonguyenlieuEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_XuatkhonguyenlieuEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_XuatkhonguyenlieuEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_XuatkhonguyenlieuEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _XuatkhonguyenlieuEntity;
		}			
		
		public XuatkhonguyenlieuEntity Convert_Entity(XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity,XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity_XML)
		{	
			
			
			_XuatkhonguyenlieuEntity.Id= _XuatkhonguyenlieuEntity_XML.Id;
			
			_XuatkhonguyenlieuEntity.Ngayxuat= _XuatkhonguyenlieuEntity_XML.Ngayxuat;
			
			_XuatkhonguyenlieuEntity.Makho= _XuatkhonguyenlieuEntity_XML.Makho;
			
			_XuatkhonguyenlieuEntity.Tenkho= _XuatkhonguyenlieuEntity_XML.Tenkho;
			
			_XuatkhonguyenlieuEntity.Manguyenlieu= _XuatkhonguyenlieuEntity_XML.Manguyenlieu;
			
			_XuatkhonguyenlieuEntity.Tennguyenlieu= _XuatkhonguyenlieuEntity_XML.Tennguyenlieu;
			
			_XuatkhonguyenlieuEntity.Donvitinh= _XuatkhonguyenlieuEntity_XML.Donvitinh;
			
			_XuatkhonguyenlieuEntity.Soluong= _XuatkhonguyenlieuEntity_XML.Soluong;
			
			_XuatkhonguyenlieuEntity.Malydo= _XuatkhonguyenlieuEntity_XML.Malydo;
			
			_XuatkhonguyenlieuEntity.Tenlydo= _XuatkhonguyenlieuEntity_XML.Tenlydo;
			
			_XuatkhonguyenlieuEntity.Lenhxuat= _XuatkhonguyenlieuEntity_XML.Lenhxuat;
			
			_XuatkhonguyenlieuEntity.Ngaytao= _XuatkhonguyenlieuEntity_XML.Ngaytao;
			
			_XuatkhonguyenlieuEntity.Nguoitao= _XuatkhonguyenlieuEntity_XML.Nguoitao;
			
			_XuatkhonguyenlieuEntity.Ngaysua= _XuatkhonguyenlieuEntity_XML.Ngaysua;
			
			_XuatkhonguyenlieuEntity.Nguoisua= _XuatkhonguyenlieuEntity_XML.Nguoisua;
									
				
			return _XuatkhonguyenlieuEntity;
		}	
		
		public String InsertV2(XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new XuatkhonguyenlieuManagerBase()).Insert(_XuatkhonguyenlieuEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_XuatkhonguyenlieuEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngayxuat,_XuatkhonguyenlieuEntity.Ngayxuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_XuatkhonguyenlieuEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_XuatkhonguyenlieuEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manguyenlieu,_XuatkhonguyenlieuEntity.Manguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennguyenlieu,_XuatkhonguyenlieuEntity.Tennguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Donvitinh,_XuatkhonguyenlieuEntity.Donvitinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_XuatkhonguyenlieuEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Malydo,_XuatkhonguyenlieuEntity.Malydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenlydo,_XuatkhonguyenlieuEntity.Tenlydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhxuat,_XuatkhonguyenlieuEntity.Lenhxuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_XuatkhonguyenlieuEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_XuatkhonguyenlieuEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_XuatkhonguyenlieuEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_XuatkhonguyenlieuEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new XuatkhonguyenlieuManagerBase()).Update(_XuatkhonguyenlieuEntity);
			r.SetField(Field_Id,_XuatkhonguyenlieuEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngayxuat,_XuatkhonguyenlieuEntity.Ngayxuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_XuatkhonguyenlieuEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_XuatkhonguyenlieuEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manguyenlieu,_XuatkhonguyenlieuEntity.Manguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennguyenlieu,_XuatkhonguyenlieuEntity.Tennguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Donvitinh,_XuatkhonguyenlieuEntity.Donvitinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_XuatkhonguyenlieuEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Malydo,_XuatkhonguyenlieuEntity.Malydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenlydo,_XuatkhonguyenlieuEntity.Tenlydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhxuat,_XuatkhonguyenlieuEntity.Lenhxuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_XuatkhonguyenlieuEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_XuatkhonguyenlieuEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_XuatkhonguyenlieuEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_XuatkhonguyenlieuEntity.Nguoisua);
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

		public XuatkhonguyenlieuEntity Insert(XuatkhonguyenlieuEntity XuatkhonguyenlieuEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(XuatkhonguyenlieuEntity, true);
			}
			return XuatkhonguyenlieuEntity;
		}

		public XuatkhonguyenlieuEntity Insert(System.Int64  Id, System.DateTime  Ngayxuat, System.String  Makho, System.String  Tenkho, System.String  Manguyenlieu, System.String  Tennguyenlieu, System.String  Donvitinh, System.Decimal  Soluong, System.String  Malydo, System.String  Tenlydo, System.String  Lenhxuat, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity = new XuatkhonguyenlieuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_XuatkhonguyenlieuEntity.Id = Id;
				
				_XuatkhonguyenlieuEntity.Ngayxuat = Ngayxuat;
				
				_XuatkhonguyenlieuEntity.Makho = Makho;
				
				_XuatkhonguyenlieuEntity.Tenkho = Tenkho;
				
				_XuatkhonguyenlieuEntity.Manguyenlieu = Manguyenlieu;
				
				_XuatkhonguyenlieuEntity.Tennguyenlieu = Tennguyenlieu;
				
				_XuatkhonguyenlieuEntity.Donvitinh = Donvitinh;
				
				_XuatkhonguyenlieuEntity.Soluong = Soluong;
				
				_XuatkhonguyenlieuEntity.Malydo = Malydo;
				
				_XuatkhonguyenlieuEntity.Tenlydo = Tenlydo;
				
				_XuatkhonguyenlieuEntity.Lenhxuat = Lenhxuat;
				
				_XuatkhonguyenlieuEntity.Ngaytao = Ngaytao;
				
				_XuatkhonguyenlieuEntity.Nguoitao = Nguoitao;
				
				_XuatkhonguyenlieuEntity.Ngaysua = Ngaysua;
				
				_XuatkhonguyenlieuEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_XuatkhonguyenlieuEntity, true);
			}
			return _XuatkhonguyenlieuEntity;
		}

		public XuatkhonguyenlieuEntity Insert(System.DateTime Ngayxuat, System.String Makho, System.String Tenkho, System.String Manguyenlieu, System.String Tennguyenlieu, System.String Donvitinh, System.Decimal Soluong, System.String Malydo, System.String Tenlydo, System.String Lenhxuat, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity = new XuatkhonguyenlieuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_XuatkhonguyenlieuEntity.Ngayxuat = Ngayxuat;
				
				_XuatkhonguyenlieuEntity.Makho = Makho;
				
				_XuatkhonguyenlieuEntity.Tenkho = Tenkho;
				
				_XuatkhonguyenlieuEntity.Manguyenlieu = Manguyenlieu;
				
				_XuatkhonguyenlieuEntity.Tennguyenlieu = Tennguyenlieu;
				
				_XuatkhonguyenlieuEntity.Donvitinh = Donvitinh;
				
				_XuatkhonguyenlieuEntity.Soluong = Soluong;
				
				_XuatkhonguyenlieuEntity.Malydo = Malydo;
				
				_XuatkhonguyenlieuEntity.Tenlydo = Tenlydo;
				
				_XuatkhonguyenlieuEntity.Lenhxuat = Lenhxuat;
				
				_XuatkhonguyenlieuEntity.Ngaytao = Ngaytao;
				
				_XuatkhonguyenlieuEntity.Nguoitao = Nguoitao;
				
				_XuatkhonguyenlieuEntity.Ngaysua = Ngaysua;
				
				_XuatkhonguyenlieuEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_XuatkhonguyenlieuEntity, true);
			}
			return _XuatkhonguyenlieuEntity;
		}

		public bool Update(XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(XuatkhonguyenlieuFields.Id == _XuatkhonguyenlieuEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_XuatkhonguyenlieuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_XuatkhonguyenlieuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngayxuat, System.String Makho, System.String Tenkho, System.String Manguyenlieu, System.String Tennguyenlieu, System.String Donvitinh, System.Decimal Soluong, System.String Malydo, System.String Tenlydo, System.String Lenhxuat, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity = new XuatkhonguyenlieuEntity(Id);
				if (adapter.FetchEntity(_XuatkhonguyenlieuEntity))
				{
				
					
					
					_XuatkhonguyenlieuEntity.Ngayxuat = Ngayxuat;
					
					_XuatkhonguyenlieuEntity.Makho = Makho;
					
					_XuatkhonguyenlieuEntity.Tenkho = Tenkho;
					
					_XuatkhonguyenlieuEntity.Manguyenlieu = Manguyenlieu;
					
					_XuatkhonguyenlieuEntity.Tennguyenlieu = Tennguyenlieu;
					
					_XuatkhonguyenlieuEntity.Donvitinh = Donvitinh;
					
					_XuatkhonguyenlieuEntity.Soluong = Soluong;
					
					_XuatkhonguyenlieuEntity.Malydo = Malydo;
					
					_XuatkhonguyenlieuEntity.Tenlydo = Tenlydo;
					
					_XuatkhonguyenlieuEntity.Lenhxuat = Lenhxuat;
					
					_XuatkhonguyenlieuEntity.Ngaytao = Ngaytao;
					
					_XuatkhonguyenlieuEntity.Nguoitao = Nguoitao;
					
					_XuatkhonguyenlieuEntity.Ngaysua = Ngaysua;
					
					_XuatkhonguyenlieuEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_XuatkhonguyenlieuEntity, true);
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
				XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity = new XuatkhonguyenlieuEntity(Id);
				if (adapter.FetchEntity(_XuatkhonguyenlieuEntity))
				{
					adapter.DeleteEntity(_XuatkhonguyenlieuEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgayxuat(System.DateTime Ngayxuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Ngayxuat == Ngayxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakho(System.String Makho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkho(System.String Tenkho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByManguyenlieu(System.String Manguyenlieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Manguyenlieu == Manguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennguyenlieu(System.String Tennguyenlieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Tennguyenlieu == Tennguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDonvitinh(System.String Donvitinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Donvitinh == Donvitinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluong(System.Decimal Soluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMalydo(System.String Malydo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenlydo(System.String Tenlydo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLenhxuat(System.String Lenhxuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Lenhxuat == Lenhxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuatkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
			
		
		public XuatkhonguyenlieuEntity SelectOne(System.Int64 Id)
		{
			XuatkhonguyenlieuEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity = new XuatkhonguyenlieuEntity(Id);
				if (adapter.FetchEntity(_XuatkhonguyenlieuEntity))
				{
					toReturn = _XuatkhonguyenlieuEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection( new XuatkhonguyenlieuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, null, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, filter, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgayxuat(System.DateTime Ngayxuat)
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Ngayxuat == Ngayxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, filter, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayxuatRDT(System.DateTime Ngayxuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Ngayxuat == Ngayxuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakho(System.String Makho)
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, filter, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhoRDT(System.String Makho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkho(System.String Tenkho)
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, filter, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhoRDT(System.String Tenkho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByManguyenlieu(System.String Manguyenlieu)
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Manguyenlieu == Manguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, filter, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByManguyenlieuRDT(System.String Manguyenlieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Manguyenlieu == Manguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennguyenlieu(System.String Tennguyenlieu)
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Tennguyenlieu == Tennguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, filter, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTennguyenlieuRDT(System.String Tennguyenlieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Tennguyenlieu == Tennguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDonvitinh(System.String Donvitinh)
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Donvitinh == Donvitinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, filter, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByDonvitinhRDT(System.String Donvitinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Donvitinh == Donvitinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluong(System.Decimal Soluong)
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, filter, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongRDT(System.Decimal Soluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMalydo(System.String Malydo)
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, filter, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByMalydoRDT(System.String Malydo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenlydo(System.String Tenlydo)
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, filter, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTenlydoRDT(System.String Tenlydo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLenhxuat(System.String Lenhxuat)
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Lenhxuat == Lenhxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, filter, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByLenhxuatRDT(System.String Lenhxuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Lenhxuat == Lenhxuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, filter, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, filter, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, filter, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuatkhonguyenlieuCollection, filter, 0, null);
			}
			return _XuatkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuatkhonguyenlieuCollection = new EntityCollection(new XuatkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuatkhonguyenlieuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuatkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(XuatkhonguyenlieuFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
