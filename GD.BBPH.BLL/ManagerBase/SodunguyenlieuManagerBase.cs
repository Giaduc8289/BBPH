


/*
'===============================================================================
'  GD.BBPH.BL.SodunguyenlieuManagerBase
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
	public class SodunguyenlieuManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngaykiemke="Ngaykiemke";				
		
		public const String Field_Makho="Makho";				
		
		public const String Field_Tenkho="Tenkho";				
		
		public const String Field_Manguyenlieu="Manguyenlieu";				
		
		public const String Field_Tennguyenlieu="Tennguyenlieu";				
		
		public const String Field_Donvitinh="Donvitinh";				
		
		public const String Field_Soluong="Soluong";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SodunguyenlieuManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Ngaykiemke,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Makho,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkho,typeof(System.String));
			
			dt.Columns.Add(Field_Manguyenlieu,typeof(System.String));
			
			dt.Columns.Add(Field_Tennguyenlieu,typeof(System.String));
			
			dt.Columns.Add(Field_Donvitinh,typeof(System.String));
			
			dt.Columns.Add(Field_Soluong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(SodunguyenlieuEntity _SodunguyenlieuEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_SodunguyenlieuEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngaykiemke]=_SodunguyenlieuEntity.Ngaykiemke;
			}
			catch { }
			
			try
			{
				r[Field_Makho]=_SodunguyenlieuEntity.Makho;
			}
			catch { }
			
			try
			{
				r[Field_Tenkho]=_SodunguyenlieuEntity.Tenkho;
			}
			catch { }
			
			try
			{
				r[Field_Manguyenlieu]=_SodunguyenlieuEntity.Manguyenlieu;
			}
			catch { }
			
			try
			{
				r[Field_Tennguyenlieu]=_SodunguyenlieuEntity.Tennguyenlieu;
			}
			catch { }
			
			try
			{
				r[Field_Donvitinh]=_SodunguyenlieuEntity.Donvitinh;
			}
			catch { }
			
			try
			{
				r[Field_Soluong]=_SodunguyenlieuEntity.Soluong;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_SodunguyenlieuEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_SodunguyenlieuEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_SodunguyenlieuEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_SodunguyenlieuEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public SodunguyenlieuEntity Convert(DataRow r)
		{	
			
			SodunguyenlieuEntity _SodunguyenlieuEntity=new SodunguyenlieuEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_SodunguyenlieuEntity.Ngaykiemke= System.DateTime.Parse(r[Field_Ngaykiemke].ToString());						
			}
			catch { }
			
			try
			{
				_SodunguyenlieuEntity.Makho= r[Field_Makho].ToString();						
			}
			catch { }
			
			try
			{
				_SodunguyenlieuEntity.Tenkho= r[Field_Tenkho].ToString();						
			}
			catch { }
			
			try
			{
				_SodunguyenlieuEntity.Manguyenlieu= r[Field_Manguyenlieu].ToString();						
			}
			catch { }
			
			try
			{
				_SodunguyenlieuEntity.Tennguyenlieu= r[Field_Tennguyenlieu].ToString();						
			}
			catch { }
			
			try
			{
				_SodunguyenlieuEntity.Donvitinh= r[Field_Donvitinh].ToString();						
			}
			catch { }
			
			try
			{
				_SodunguyenlieuEntity.Soluong= System.Decimal.Parse(r[Field_Soluong].ToString());						
			}
			catch { }
			
			try
			{
				_SodunguyenlieuEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_SodunguyenlieuEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_SodunguyenlieuEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_SodunguyenlieuEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _SodunguyenlieuEntity;
		}			
		
		public SodunguyenlieuEntity Convert_Entity(SodunguyenlieuEntity _SodunguyenlieuEntity,SodunguyenlieuEntity _SodunguyenlieuEntity_XML)
		{	
			
			
			_SodunguyenlieuEntity.Id= _SodunguyenlieuEntity_XML.Id;
			
			_SodunguyenlieuEntity.Ngaykiemke= _SodunguyenlieuEntity_XML.Ngaykiemke;
			
			_SodunguyenlieuEntity.Makho= _SodunguyenlieuEntity_XML.Makho;
			
			_SodunguyenlieuEntity.Tenkho= _SodunguyenlieuEntity_XML.Tenkho;
			
			_SodunguyenlieuEntity.Manguyenlieu= _SodunguyenlieuEntity_XML.Manguyenlieu;
			
			_SodunguyenlieuEntity.Tennguyenlieu= _SodunguyenlieuEntity_XML.Tennguyenlieu;
			
			_SodunguyenlieuEntity.Donvitinh= _SodunguyenlieuEntity_XML.Donvitinh;
			
			_SodunguyenlieuEntity.Soluong= _SodunguyenlieuEntity_XML.Soluong;
			
			_SodunguyenlieuEntity.Ngaytao= _SodunguyenlieuEntity_XML.Ngaytao;
			
			_SodunguyenlieuEntity.Nguoitao= _SodunguyenlieuEntity_XML.Nguoitao;
			
			_SodunguyenlieuEntity.Ngaysua= _SodunguyenlieuEntity_XML.Ngaysua;
			
			_SodunguyenlieuEntity.Nguoisua= _SodunguyenlieuEntity_XML.Nguoisua;
									
				
			return _SodunguyenlieuEntity;
		}	
		
		public String InsertV2(SodunguyenlieuEntity _SodunguyenlieuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new SodunguyenlieuManagerBase()).Insert(_SodunguyenlieuEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_SodunguyenlieuEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngaykiemke,_SodunguyenlieuEntity.Ngaykiemke);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_SodunguyenlieuEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_SodunguyenlieuEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manguyenlieu,_SodunguyenlieuEntity.Manguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennguyenlieu,_SodunguyenlieuEntity.Tennguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Donvitinh,_SodunguyenlieuEntity.Donvitinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_SodunguyenlieuEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_SodunguyenlieuEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_SodunguyenlieuEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_SodunguyenlieuEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_SodunguyenlieuEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(SodunguyenlieuEntity _SodunguyenlieuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new SodunguyenlieuManagerBase()).Update(_SodunguyenlieuEntity);
			r.SetField(Field_Id,_SodunguyenlieuEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngaykiemke,_SodunguyenlieuEntity.Ngaykiemke);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_SodunguyenlieuEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_SodunguyenlieuEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manguyenlieu,_SodunguyenlieuEntity.Manguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennguyenlieu,_SodunguyenlieuEntity.Tennguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Donvitinh,_SodunguyenlieuEntity.Donvitinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_SodunguyenlieuEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_SodunguyenlieuEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_SodunguyenlieuEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_SodunguyenlieuEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_SodunguyenlieuEntity.Nguoisua);
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

		public SodunguyenlieuEntity Insert(SodunguyenlieuEntity SodunguyenlieuEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(SodunguyenlieuEntity, true);
			}
			return SodunguyenlieuEntity;
		}

		public SodunguyenlieuEntity Insert(System.Int64  Id, System.DateTime  Ngaykiemke, System.String  Makho, System.String  Tenkho, System.String  Manguyenlieu, System.String  Tennguyenlieu, System.String  Donvitinh, System.Decimal  Soluong, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			SodunguyenlieuEntity _SodunguyenlieuEntity = new SodunguyenlieuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_SodunguyenlieuEntity.Id = Id;
				
				_SodunguyenlieuEntity.Ngaykiemke = Ngaykiemke;
				
				_SodunguyenlieuEntity.Makho = Makho;
				
				_SodunguyenlieuEntity.Tenkho = Tenkho;
				
				_SodunguyenlieuEntity.Manguyenlieu = Manguyenlieu;
				
				_SodunguyenlieuEntity.Tennguyenlieu = Tennguyenlieu;
				
				_SodunguyenlieuEntity.Donvitinh = Donvitinh;
				
				_SodunguyenlieuEntity.Soluong = Soluong;
				
				_SodunguyenlieuEntity.Ngaytao = Ngaytao;
				
				_SodunguyenlieuEntity.Nguoitao = Nguoitao;
				
				_SodunguyenlieuEntity.Ngaysua = Ngaysua;
				
				_SodunguyenlieuEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_SodunguyenlieuEntity, true);
			}
			return _SodunguyenlieuEntity;
		}

		public SodunguyenlieuEntity Insert(System.DateTime Ngaykiemke, System.String Makho, System.String Tenkho, System.String Manguyenlieu, System.String Tennguyenlieu, System.String Donvitinh, System.Decimal Soluong, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			SodunguyenlieuEntity _SodunguyenlieuEntity = new SodunguyenlieuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_SodunguyenlieuEntity.Ngaykiemke = Ngaykiemke;
				
				_SodunguyenlieuEntity.Makho = Makho;
				
				_SodunguyenlieuEntity.Tenkho = Tenkho;
				
				_SodunguyenlieuEntity.Manguyenlieu = Manguyenlieu;
				
				_SodunguyenlieuEntity.Tennguyenlieu = Tennguyenlieu;
				
				_SodunguyenlieuEntity.Donvitinh = Donvitinh;
				
				_SodunguyenlieuEntity.Soluong = Soluong;
				
				_SodunguyenlieuEntity.Ngaytao = Ngaytao;
				
				_SodunguyenlieuEntity.Nguoitao = Nguoitao;
				
				_SodunguyenlieuEntity.Ngaysua = Ngaysua;
				
				_SodunguyenlieuEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_SodunguyenlieuEntity, true);
			}
			return _SodunguyenlieuEntity;
		}

		public bool Update(SodunguyenlieuEntity _SodunguyenlieuEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(SodunguyenlieuFields.Id == _SodunguyenlieuEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_SodunguyenlieuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(SodunguyenlieuEntity _SodunguyenlieuEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_SodunguyenlieuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngaykiemke, System.String Makho, System.String Tenkho, System.String Manguyenlieu, System.String Tennguyenlieu, System.String Donvitinh, System.Decimal Soluong, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SodunguyenlieuEntity _SodunguyenlieuEntity = new SodunguyenlieuEntity(Id);
				if (adapter.FetchEntity(_SodunguyenlieuEntity))
				{
				
					
					
					_SodunguyenlieuEntity.Ngaykiemke = Ngaykiemke;
					
					_SodunguyenlieuEntity.Makho = Makho;
					
					_SodunguyenlieuEntity.Tenkho = Tenkho;
					
					_SodunguyenlieuEntity.Manguyenlieu = Manguyenlieu;
					
					_SodunguyenlieuEntity.Tennguyenlieu = Tennguyenlieu;
					
					_SodunguyenlieuEntity.Donvitinh = Donvitinh;
					
					_SodunguyenlieuEntity.Soluong = Soluong;
					
					_SodunguyenlieuEntity.Ngaytao = Ngaytao;
					
					_SodunguyenlieuEntity.Nguoitao = Nguoitao;
					
					_SodunguyenlieuEntity.Ngaysua = Ngaysua;
					
					_SodunguyenlieuEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_SodunguyenlieuEntity, true);
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
				SodunguyenlieuEntity _SodunguyenlieuEntity = new SodunguyenlieuEntity(Id);
				if (adapter.FetchEntity(_SodunguyenlieuEntity))
				{
					adapter.DeleteEntity(_SodunguyenlieuEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("SodunguyenlieuEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodunguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaykiemke(System.DateTime Ngaykiemke)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Ngaykiemke == Ngaykiemke);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodunguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakho(System.String Makho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodunguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkho(System.String Tenkho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodunguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByManguyenlieu(System.String Manguyenlieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Manguyenlieu == Manguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodunguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennguyenlieu(System.String Tennguyenlieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Tennguyenlieu == Tennguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodunguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDonvitinh(System.String Donvitinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Donvitinh == Donvitinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodunguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluong(System.Decimal Soluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodunguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodunguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodunguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodunguyenlieuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodunguyenlieuEntity", filter);
			}
			return toReturn;
		}		
			
		
		public SodunguyenlieuEntity SelectOne(System.Int64 Id)
		{
			SodunguyenlieuEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SodunguyenlieuEntity _SodunguyenlieuEntity = new SodunguyenlieuEntity(Id);
				if (adapter.FetchEntity(_SodunguyenlieuEntity))
				{
					toReturn = _SodunguyenlieuEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _SodunguyenlieuCollection = new EntityCollection( new SodunguyenlieuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodunguyenlieuCollection, null, 0, null);
			}
			return _SodunguyenlieuCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodunguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodunguyenlieuCollection, filter, 0, null);
			}
			return _SodunguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodunguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaykiemke(System.DateTime Ngaykiemke)
		{
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Ngaykiemke == Ngaykiemke);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodunguyenlieuCollection, filter, 0, null);
			}
			return _SodunguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaykiemkeRDT(System.DateTime Ngaykiemke)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Ngaykiemke == Ngaykiemke);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodunguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakho(System.String Makho)
		{
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodunguyenlieuCollection, filter, 0, null);
			}
			return _SodunguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhoRDT(System.String Makho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodunguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkho(System.String Tenkho)
		{
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodunguyenlieuCollection, filter, 0, null);
			}
			return _SodunguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhoRDT(System.String Tenkho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodunguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByManguyenlieu(System.String Manguyenlieu)
		{
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Manguyenlieu == Manguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodunguyenlieuCollection, filter, 0, null);
			}
			return _SodunguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByManguyenlieuRDT(System.String Manguyenlieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Manguyenlieu == Manguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodunguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennguyenlieu(System.String Tennguyenlieu)
		{
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Tennguyenlieu == Tennguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodunguyenlieuCollection, filter, 0, null);
			}
			return _SodunguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByTennguyenlieuRDT(System.String Tennguyenlieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Tennguyenlieu == Tennguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodunguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDonvitinh(System.String Donvitinh)
		{
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Donvitinh == Donvitinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodunguyenlieuCollection, filter, 0, null);
			}
			return _SodunguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByDonvitinhRDT(System.String Donvitinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Donvitinh == Donvitinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodunguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluong(System.Decimal Soluong)
		{
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodunguyenlieuCollection, filter, 0, null);
			}
			return _SodunguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongRDT(System.Decimal Soluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodunguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodunguyenlieuCollection, filter, 0, null);
			}
			return _SodunguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodunguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodunguyenlieuCollection, filter, 0, null);
			}
			return _SodunguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodunguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodunguyenlieuCollection, filter, 0, null);
			}
			return _SodunguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodunguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodunguyenlieuCollection, filter, 0, null);
			}
			return _SodunguyenlieuCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodunguyenlieuCollection = new EntityCollection(new SodunguyenlieuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodunguyenlieuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodunguyenlieuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
