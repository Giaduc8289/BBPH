


/*
'===============================================================================
'  GD.BBPH.BL.NhapkhonguyenlieuManagerBase
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
	public class NhapkhonguyenlieuManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngaynhap="Ngaynhap";				
		
		public const String Field_Makho="Makho";				
		
		public const String Field_Tenkho="Tenkho";				
		
		public const String Field_Manguyenlieu="Manguyenlieu";				
		
		public const String Field_Tennguyenlieu="Tennguyenlieu";				
		
		public const String Field_Donvitinh="Donvitinh";				
		
		public const String Field_Soluong="Soluong";				
		
		public const String Field_Malydo="Malydo";				
		
		public const String Field_Tenlydo="Tenlydo";				
		
		public const String Field_Sohopdongmua="Sohopdongmua";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NhapkhonguyenlieuManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Ngaynhap,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Makho,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkho,typeof(System.String));
			
			dt.Columns.Add(Field_Manguyenlieu,typeof(System.String));
			
			dt.Columns.Add(Field_Tennguyenlieu,typeof(System.String));
			
			dt.Columns.Add(Field_Donvitinh,typeof(System.String));
			
			dt.Columns.Add(Field_Soluong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Malydo,typeof(System.String));
			
			dt.Columns.Add(Field_Tenlydo,typeof(System.String));
			
			dt.Columns.Add(Field_Sohopdongmua,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_NhapkhonguyenlieuEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngaynhap]=_NhapkhonguyenlieuEntity.Ngaynhap;
			}
			catch { }
			
			try
			{
				r[Field_Makho]=_NhapkhonguyenlieuEntity.Makho;
			}
			catch { }
			
			try
			{
				r[Field_Tenkho]=_NhapkhonguyenlieuEntity.Tenkho;
			}
			catch { }
			
			try
			{
				r[Field_Manguyenlieu]=_NhapkhonguyenlieuEntity.Manguyenlieu;
			}
			catch { }
			
			try
			{
				r[Field_Tennguyenlieu]=_NhapkhonguyenlieuEntity.Tennguyenlieu;
			}
			catch { }
			
			try
			{
				r[Field_Donvitinh]=_NhapkhonguyenlieuEntity.Donvitinh;
			}
			catch { }
			
			try
			{
				r[Field_Soluong]=_NhapkhonguyenlieuEntity.Soluong;
			}
			catch { }
			
			try
			{
				r[Field_Malydo]=_NhapkhonguyenlieuEntity.Malydo;
			}
			catch { }
			
			try
			{
				r[Field_Tenlydo]=_NhapkhonguyenlieuEntity.Tenlydo;
			}
			catch { }
			
			try
			{
				r[Field_Sohopdongmua]=_NhapkhonguyenlieuEntity.Sohopdongmua;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_NhapkhonguyenlieuEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_NhapkhonguyenlieuEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_NhapkhonguyenlieuEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_NhapkhonguyenlieuEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public NhapkhonguyenlieuEntity Convert(DataRow r)
		{	
			
			NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity=new NhapkhonguyenlieuEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_NhapkhonguyenlieuEntity.Ngaynhap= System.DateTime.Parse(r[Field_Ngaynhap].ToString());						
			}
			catch { }
			
			try
			{
				_NhapkhonguyenlieuEntity.Makho= r[Field_Makho].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhonguyenlieuEntity.Tenkho= r[Field_Tenkho].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhonguyenlieuEntity.Manguyenlieu= r[Field_Manguyenlieu].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhonguyenlieuEntity.Tennguyenlieu= r[Field_Tennguyenlieu].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhonguyenlieuEntity.Donvitinh= r[Field_Donvitinh].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhonguyenlieuEntity.Soluong= System.Decimal.Parse(r[Field_Soluong].ToString());						
			}
			catch { }
			
			try
			{
				_NhapkhonguyenlieuEntity.Malydo= r[Field_Malydo].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhonguyenlieuEntity.Tenlydo= r[Field_Tenlydo].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhonguyenlieuEntity.Sohopdongmua= r[Field_Sohopdongmua].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhonguyenlieuEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_NhapkhonguyenlieuEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhonguyenlieuEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_NhapkhonguyenlieuEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _NhapkhonguyenlieuEntity;
		}			
		
		public NhapkhonguyenlieuEntity Convert_Entity(NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity,NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity_XML)
		{	
			
			
			_NhapkhonguyenlieuEntity.Id= _NhapkhonguyenlieuEntity_XML.Id;
			
			_NhapkhonguyenlieuEntity.Ngaynhap= _NhapkhonguyenlieuEntity_XML.Ngaynhap;
			
			_NhapkhonguyenlieuEntity.Makho= _NhapkhonguyenlieuEntity_XML.Makho;
			
			_NhapkhonguyenlieuEntity.Tenkho= _NhapkhonguyenlieuEntity_XML.Tenkho;
			
			_NhapkhonguyenlieuEntity.Manguyenlieu= _NhapkhonguyenlieuEntity_XML.Manguyenlieu;
			
			_NhapkhonguyenlieuEntity.Tennguyenlieu= _NhapkhonguyenlieuEntity_XML.Tennguyenlieu;
			
			_NhapkhonguyenlieuEntity.Donvitinh= _NhapkhonguyenlieuEntity_XML.Donvitinh;
			
			_NhapkhonguyenlieuEntity.Soluong= _NhapkhonguyenlieuEntity_XML.Soluong;
			
			_NhapkhonguyenlieuEntity.Malydo= _NhapkhonguyenlieuEntity_XML.Malydo;
			
			_NhapkhonguyenlieuEntity.Tenlydo= _NhapkhonguyenlieuEntity_XML.Tenlydo;
			
			_NhapkhonguyenlieuEntity.Sohopdongmua= _NhapkhonguyenlieuEntity_XML.Sohopdongmua;
			
			_NhapkhonguyenlieuEntity.Ngaytao= _NhapkhonguyenlieuEntity_XML.Ngaytao;
			
			_NhapkhonguyenlieuEntity.Nguoitao= _NhapkhonguyenlieuEntity_XML.Nguoitao;
			
			_NhapkhonguyenlieuEntity.Ngaysua= _NhapkhonguyenlieuEntity_XML.Ngaysua;
			
			_NhapkhonguyenlieuEntity.Nguoisua= _NhapkhonguyenlieuEntity_XML.Nguoisua;
									
				
			return _NhapkhonguyenlieuEntity;
		}	
		
		public String InsertV2(NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new NhapkhonguyenlieuManagerBase()).Insert(_NhapkhonguyenlieuEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_NhapkhonguyenlieuEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngaynhap,_NhapkhonguyenlieuEntity.Ngaynhap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_NhapkhonguyenlieuEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_NhapkhonguyenlieuEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manguyenlieu,_NhapkhonguyenlieuEntity.Manguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennguyenlieu,_NhapkhonguyenlieuEntity.Tennguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Donvitinh,_NhapkhonguyenlieuEntity.Donvitinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_NhapkhonguyenlieuEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Malydo,_NhapkhonguyenlieuEntity.Malydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenlydo,_NhapkhonguyenlieuEntity.Tenlydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohopdongmua,_NhapkhonguyenlieuEntity.Sohopdongmua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_NhapkhonguyenlieuEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_NhapkhonguyenlieuEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_NhapkhonguyenlieuEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_NhapkhonguyenlieuEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new NhapkhonguyenlieuManagerBase()).Update(_NhapkhonguyenlieuEntity);
			r.SetField(Field_Id,_NhapkhonguyenlieuEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngaynhap,_NhapkhonguyenlieuEntity.Ngaynhap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_NhapkhonguyenlieuEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_NhapkhonguyenlieuEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manguyenlieu,_NhapkhonguyenlieuEntity.Manguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennguyenlieu,_NhapkhonguyenlieuEntity.Tennguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Donvitinh,_NhapkhonguyenlieuEntity.Donvitinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_NhapkhonguyenlieuEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Malydo,_NhapkhonguyenlieuEntity.Malydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenlydo,_NhapkhonguyenlieuEntity.Tenlydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohopdongmua,_NhapkhonguyenlieuEntity.Sohopdongmua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_NhapkhonguyenlieuEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_NhapkhonguyenlieuEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_NhapkhonguyenlieuEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_NhapkhonguyenlieuEntity.Nguoisua);
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

		public NhapkhonguyenlieuEntity Insert(NhapkhonguyenlieuEntity NhapkhonguyenlieuEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(NhapkhonguyenlieuEntity, true);
			}
			return NhapkhonguyenlieuEntity;
		}

		public NhapkhonguyenlieuEntity Insert(System.Int64  Id, System.DateTime  Ngaynhap, System.String  Makho, System.String  Tenkho, System.String  Manguyenlieu, System.String  Tennguyenlieu, System.String  Donvitinh, System.Decimal  Soluong, System.String  Malydo, System.String  Tenlydo, System.String  Sohopdongmua, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity = new NhapkhonguyenlieuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NhapkhonguyenlieuEntity.Id = Id;
				
				_NhapkhonguyenlieuEntity.Ngaynhap = Ngaynhap;
				
				_NhapkhonguyenlieuEntity.Makho = Makho;
				
				_NhapkhonguyenlieuEntity.Tenkho = Tenkho;
				
				_NhapkhonguyenlieuEntity.Manguyenlieu = Manguyenlieu;
				
				_NhapkhonguyenlieuEntity.Tennguyenlieu = Tennguyenlieu;
				
				_NhapkhonguyenlieuEntity.Donvitinh = Donvitinh;
				
				_NhapkhonguyenlieuEntity.Soluong = Soluong;
				
				_NhapkhonguyenlieuEntity.Malydo = Malydo;
				
				_NhapkhonguyenlieuEntity.Tenlydo = Tenlydo;
				
				_NhapkhonguyenlieuEntity.Sohopdongmua = Sohopdongmua;
				
				_NhapkhonguyenlieuEntity.Ngaytao = Ngaytao;
				
				_NhapkhonguyenlieuEntity.Nguoitao = Nguoitao;
				
				_NhapkhonguyenlieuEntity.Ngaysua = Ngaysua;
				
				_NhapkhonguyenlieuEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_NhapkhonguyenlieuEntity, true);
			}
			return _NhapkhonguyenlieuEntity;
		}

		public NhapkhonguyenlieuEntity Insert(System.DateTime Ngaynhap, System.String Makho, System.String Tenkho, System.String Manguyenlieu, System.String Tennguyenlieu, System.String Donvitinh, System.Decimal Soluong, System.String Malydo, System.String Tenlydo, System.String Sohopdongmua, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity = new NhapkhonguyenlieuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_NhapkhonguyenlieuEntity.Ngaynhap = Ngaynhap;
				
				_NhapkhonguyenlieuEntity.Makho = Makho;
				
				_NhapkhonguyenlieuEntity.Tenkho = Tenkho;
				
				_NhapkhonguyenlieuEntity.Manguyenlieu = Manguyenlieu;
				
				_NhapkhonguyenlieuEntity.Tennguyenlieu = Tennguyenlieu;
				
				_NhapkhonguyenlieuEntity.Donvitinh = Donvitinh;
				
				_NhapkhonguyenlieuEntity.Soluong = Soluong;
				
				_NhapkhonguyenlieuEntity.Malydo = Malydo;
				
				_NhapkhonguyenlieuEntity.Tenlydo = Tenlydo;
				
				_NhapkhonguyenlieuEntity.Sohopdongmua = Sohopdongmua;
				
				_NhapkhonguyenlieuEntity.Ngaytao = Ngaytao;
				
				_NhapkhonguyenlieuEntity.Nguoitao = Nguoitao;
				
				_NhapkhonguyenlieuEntity.Ngaysua = Ngaysua;
				
				_NhapkhonguyenlieuEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_NhapkhonguyenlieuEntity, true);
			}
			return _NhapkhonguyenlieuEntity;
		}

		public bool Update(NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(NhapkhonguyenlieuFields.Id == _NhapkhonguyenlieuEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_NhapkhonguyenlieuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_NhapkhonguyenlieuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngaynhap, System.String Makho, System.String Tenkho, System.String Manguyenlieu, System.String Tennguyenlieu, System.String Donvitinh, System.Decimal Soluong, System.String Malydo, System.String Tenlydo, System.String Sohopdongmua, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity = new NhapkhonguyenlieuEntity(Id);
				if (adapter.FetchEntity(_NhapkhonguyenlieuEntity))
				{
				
					
					
					_NhapkhonguyenlieuEntity.Ngaynhap = Ngaynhap;
					
					_NhapkhonguyenlieuEntity.Makho = Makho;
					
					_NhapkhonguyenlieuEntity.Tenkho = Tenkho;
					
					_NhapkhonguyenlieuEntity.Manguyenlieu = Manguyenlieu;
					
					_NhapkhonguyenlieuEntity.Tennguyenlieu = Tennguyenlieu;
					
					_NhapkhonguyenlieuEntity.Donvitinh = Donvitinh;
					
					_NhapkhonguyenlieuEntity.Soluong = Soluong;
					
					_NhapkhonguyenlieuEntity.Malydo = Malydo;
					
					_NhapkhonguyenlieuEntity.Tenlydo = Tenlydo;
					
					_NhapkhonguyenlieuEntity.Sohopdongmua = Sohopdongmua;
					
					_NhapkhonguyenlieuEntity.Ngaytao = Ngaytao;
					
					_NhapkhonguyenlieuEntity.Nguoitao = Nguoitao;
					
					_NhapkhonguyenlieuEntity.Ngaysua = Ngaysua;
					
					_NhapkhonguyenlieuEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_NhapkhonguyenlieuEntity, true);
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
				NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity = new NhapkhonguyenlieuEntity(Id);
				if (adapter.FetchEntity(_NhapkhonguyenlieuEntity))
				{
					adapter.DeleteEntity(_NhapkhonguyenlieuEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaynhap(System.DateTime Ngaynhap)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Ngaynhap == Ngaynhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakho(System.String Makho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkho(System.String Tenkho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByManguyenlieu(System.String Manguyenlieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Manguyenlieu == Manguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennguyenlieu(System.String Tennguyenlieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Tennguyenlieu == Tennguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDonvitinh(System.String Donvitinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Donvitinh == Donvitinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluong(System.Decimal Soluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMalydo(System.String Malydo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenlydo(System.String Tenlydo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySohopdongmua(System.String Sohopdongmua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Sohopdongmua == Sohopdongmua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhonguyenlieuEntity", filter);
			}
			return toReturn;
		}		
			
		
		public NhapkhonguyenlieuEntity SelectOne(System.Int64 Id)
		{
			NhapkhonguyenlieuEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity = new NhapkhonguyenlieuEntity(Id);
				if (adapter.FetchEntity(_NhapkhonguyenlieuEntity))
				{
					toReturn = _NhapkhonguyenlieuEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection( new NhapkhonguyenlieuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, null, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, filter, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaynhap(System.DateTime Ngaynhap)
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Ngaynhap == Ngaynhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, filter, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaynhapRDT(System.DateTime Ngaynhap)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Ngaynhap == Ngaynhap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakho(System.String Makho)
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, filter, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhoRDT(System.String Makho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkho(System.String Tenkho)
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, filter, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhoRDT(System.String Tenkho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByManguyenlieu(System.String Manguyenlieu)
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Manguyenlieu == Manguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, filter, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByManguyenlieuRDT(System.String Manguyenlieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Manguyenlieu == Manguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennguyenlieu(System.String Tennguyenlieu)
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Tennguyenlieu == Tennguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, filter, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTennguyenlieuRDT(System.String Tennguyenlieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Tennguyenlieu == Tennguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDonvitinh(System.String Donvitinh)
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Donvitinh == Donvitinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, filter, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByDonvitinhRDT(System.String Donvitinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Donvitinh == Donvitinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluong(System.Decimal Soluong)
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, filter, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongRDT(System.Decimal Soluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMalydo(System.String Malydo)
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, filter, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByMalydoRDT(System.String Malydo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenlydo(System.String Tenlydo)
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, filter, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTenlydoRDT(System.String Tenlydo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySohopdongmua(System.String Sohopdongmua)
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Sohopdongmua == Sohopdongmua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, filter, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectBySohopdongmuaRDT(System.String Sohopdongmua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Sohopdongmua == Sohopdongmua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, filter, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, filter, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, filter, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhonguyenlieuCollection, filter, 0, null);
			}
			return _NhapkhonguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhonguyenlieuCollection = new EntityCollection(new NhapkhonguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhonguyenlieuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhonguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
