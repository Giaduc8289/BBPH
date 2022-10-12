


/*
'===============================================================================
'  GD.BBPH.BL.BaogiaDManagerBase
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
	public class BaogiaDManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Sobaogia="Sobaogia";				
		
		public const String Field_Machungloai="Machungloai";				
		
		public const String Field_Tenchungloai="Tenchungloai";				
		
		public const String Field_Masp="Masp";				
		
		public const String Field_Tenhang="Tenhang";				
		
		public const String Field_Kichthuoc="Kichthuoc";				
		
		public const String Field_Trongluong="Trongluong";				
		
		public const String Field_Mota="Mota";				
		
		public const String Field_DongiakhongVat="DongiakhongVat";				
		
		public const String Field_DongiaVat="DongiaVat";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public BaogiaDManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Sobaogia,typeof(System.String));
			
			dt.Columns.Add(Field_Machungloai,typeof(System.Int64));
			
			dt.Columns.Add(Field_Tenchungloai,typeof(System.String));
			
			dt.Columns.Add(Field_Masp,typeof(System.String));
			
			dt.Columns.Add(Field_Tenhang,typeof(System.String));
			
			dt.Columns.Add(Field_Kichthuoc,typeof(System.String));
			
			dt.Columns.Add(Field_Trongluong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Mota,typeof(System.String));
			
			dt.Columns.Add(Field_DongiakhongVat,typeof(System.Int32));
			
			dt.Columns.Add(Field_DongiaVat,typeof(System.Int32));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(BaogiaDEntity _BaogiaDEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_BaogiaDEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Sobaogia]=_BaogiaDEntity.Sobaogia;
			}
			catch { }
			
			try
			{
				r[Field_Machungloai]=_BaogiaDEntity.Machungloai;
			}
			catch { }
			
			try
			{
				r[Field_Tenchungloai]=_BaogiaDEntity.Tenchungloai;
			}
			catch { }
			
			try
			{
				r[Field_Masp]=_BaogiaDEntity.Masp;
			}
			catch { }
			
			try
			{
				r[Field_Tenhang]=_BaogiaDEntity.Tenhang;
			}
			catch { }
			
			try
			{
				r[Field_Kichthuoc]=_BaogiaDEntity.Kichthuoc;
			}
			catch { }
			
			try
			{
				r[Field_Trongluong]=_BaogiaDEntity.Trongluong;
			}
			catch { }
			
			try
			{
				r[Field_Mota]=_BaogiaDEntity.Mota;
			}
			catch { }
			
			try
			{
				r[Field_DongiakhongVat]=_BaogiaDEntity.DongiakhongVat;
			}
			catch { }
			
			try
			{
				r[Field_DongiaVat]=_BaogiaDEntity.DongiaVat;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_BaogiaDEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_BaogiaDEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_BaogiaDEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_BaogiaDEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public BaogiaDEntity Convert(DataRow r)
		{	
			
			BaogiaDEntity _BaogiaDEntity=new BaogiaDEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_BaogiaDEntity.Sobaogia= r[Field_Sobaogia].ToString();						
			}
			catch { }
			
			try
			{
				_BaogiaDEntity.Machungloai= System.Int64.Parse(r[Field_Machungloai].ToString());						
			}
			catch { }
			
			try
			{
				_BaogiaDEntity.Tenchungloai= r[Field_Tenchungloai].ToString();						
			}
			catch { }
			
			try
			{
				_BaogiaDEntity.Masp= r[Field_Masp].ToString();						
			}
			catch { }
			
			try
			{
				_BaogiaDEntity.Tenhang= r[Field_Tenhang].ToString();						
			}
			catch { }
			
			try
			{
				_BaogiaDEntity.Kichthuoc= r[Field_Kichthuoc].ToString();						
			}
			catch { }
			
			try
			{
				_BaogiaDEntity.Trongluong= System.Decimal.Parse(r[Field_Trongluong].ToString());						
			}
			catch { }
			
			try
			{
				_BaogiaDEntity.Mota= r[Field_Mota].ToString();						
			}
			catch { }
			
			try
			{
				_BaogiaDEntity.DongiakhongVat= System.Int32.Parse(r[Field_DongiakhongVat].ToString());						
			}
			catch { }
			
			try
			{
				_BaogiaDEntity.DongiaVat= System.Int32.Parse(r[Field_DongiaVat].ToString());						
			}
			catch { }
			
			try
			{
				_BaogiaDEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_BaogiaDEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_BaogiaDEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_BaogiaDEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _BaogiaDEntity;
		}			
		
		public BaogiaDEntity Convert_Entity(BaogiaDEntity _BaogiaDEntity,BaogiaDEntity _BaogiaDEntity_XML)
		{	
			
			
			_BaogiaDEntity.Id= _BaogiaDEntity_XML.Id;
			
			_BaogiaDEntity.Sobaogia= _BaogiaDEntity_XML.Sobaogia;
			
			_BaogiaDEntity.Machungloai= _BaogiaDEntity_XML.Machungloai;
			
			_BaogiaDEntity.Tenchungloai= _BaogiaDEntity_XML.Tenchungloai;
			
			_BaogiaDEntity.Masp= _BaogiaDEntity_XML.Masp;
			
			_BaogiaDEntity.Tenhang= _BaogiaDEntity_XML.Tenhang;
			
			_BaogiaDEntity.Kichthuoc= _BaogiaDEntity_XML.Kichthuoc;
			
			_BaogiaDEntity.Trongluong= _BaogiaDEntity_XML.Trongluong;
			
			_BaogiaDEntity.Mota= _BaogiaDEntity_XML.Mota;
			
			_BaogiaDEntity.DongiakhongVat= _BaogiaDEntity_XML.DongiakhongVat;
			
			_BaogiaDEntity.DongiaVat= _BaogiaDEntity_XML.DongiaVat;
			
			_BaogiaDEntity.Ngaytao= _BaogiaDEntity_XML.Ngaytao;
			
			_BaogiaDEntity.Nguoitao= _BaogiaDEntity_XML.Nguoitao;
			
			_BaogiaDEntity.Ngaysua= _BaogiaDEntity_XML.Ngaysua;
			
			_BaogiaDEntity.Nguoisua= _BaogiaDEntity_XML.Nguoisua;
									
				
			return _BaogiaDEntity;
		}	
		
		public String InsertV2(BaogiaDEntity _BaogiaDEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new BaogiaDManagerBase()).Insert(_BaogiaDEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_BaogiaDEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Sobaogia,_BaogiaDEntity.Sobaogia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Machungloai,_BaogiaDEntity.Machungloai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenchungloai,_BaogiaDEntity.Tenchungloai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masp,_BaogiaDEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenhang,_BaogiaDEntity.Tenhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kichthuoc,_BaogiaDEntity.Kichthuoc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trongluong,_BaogiaDEntity.Trongluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mota,_BaogiaDEntity.Mota);
			}
			catch { }
			
			try
			{
				r.SetField(Field_DongiakhongVat,_BaogiaDEntity.DongiakhongVat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_DongiaVat,_BaogiaDEntity.DongiaVat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_BaogiaDEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_BaogiaDEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_BaogiaDEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_BaogiaDEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(BaogiaDEntity _BaogiaDEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new BaogiaDManagerBase()).Update(_BaogiaDEntity);
			r.SetField(Field_Id,_BaogiaDEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Sobaogia,_BaogiaDEntity.Sobaogia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Machungloai,_BaogiaDEntity.Machungloai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenchungloai,_BaogiaDEntity.Tenchungloai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masp,_BaogiaDEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenhang,_BaogiaDEntity.Tenhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kichthuoc,_BaogiaDEntity.Kichthuoc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trongluong,_BaogiaDEntity.Trongluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mota,_BaogiaDEntity.Mota);
			}
			catch { }
			
			try
			{
				r.SetField(Field_DongiakhongVat,_BaogiaDEntity.DongiakhongVat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_DongiaVat,_BaogiaDEntity.DongiaVat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_BaogiaDEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_BaogiaDEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_BaogiaDEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_BaogiaDEntity.Nguoisua);
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

		public BaogiaDEntity Insert(BaogiaDEntity BaogiaDEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(BaogiaDEntity, true);
			}
			return BaogiaDEntity;
		}

		public BaogiaDEntity Insert(System.Int64  Id, System.String  Sobaogia, System.Int64  Machungloai, System.String  Tenchungloai, System.String  Masp, System.String  Tenhang, System.String  Kichthuoc, System.Decimal  Trongluong, System.String  Mota, System.Int32  DongiakhongVat, System.Int32  DongiaVat, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			BaogiaDEntity _BaogiaDEntity = new BaogiaDEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_BaogiaDEntity.Id = Id;
				
				_BaogiaDEntity.Sobaogia = Sobaogia;
				
				_BaogiaDEntity.Machungloai = Machungloai;
				
				_BaogiaDEntity.Tenchungloai = Tenchungloai;
				
				_BaogiaDEntity.Masp = Masp;
				
				_BaogiaDEntity.Tenhang = Tenhang;
				
				_BaogiaDEntity.Kichthuoc = Kichthuoc;
				
				_BaogiaDEntity.Trongluong = Trongluong;
				
				_BaogiaDEntity.Mota = Mota;
				
				_BaogiaDEntity.DongiakhongVat = DongiakhongVat;
				
				_BaogiaDEntity.DongiaVat = DongiaVat;
				
				_BaogiaDEntity.Ngaytao = Ngaytao;
				
				_BaogiaDEntity.Nguoitao = Nguoitao;
				
				_BaogiaDEntity.Ngaysua = Ngaysua;
				
				_BaogiaDEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_BaogiaDEntity, true);
			}
			return _BaogiaDEntity;
		}

		public BaogiaDEntity Insert(System.String Sobaogia, System.Int64 Machungloai, System.String Tenchungloai, System.String Masp, System.String Tenhang, System.String Kichthuoc, System.Decimal Trongluong, System.String Mota, System.Int32 DongiakhongVat, System.Int32 DongiaVat, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			BaogiaDEntity _BaogiaDEntity = new BaogiaDEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_BaogiaDEntity.Sobaogia = Sobaogia;
				
				_BaogiaDEntity.Machungloai = Machungloai;
				
				_BaogiaDEntity.Tenchungloai = Tenchungloai;
				
				_BaogiaDEntity.Masp = Masp;
				
				_BaogiaDEntity.Tenhang = Tenhang;
				
				_BaogiaDEntity.Kichthuoc = Kichthuoc;
				
				_BaogiaDEntity.Trongluong = Trongluong;
				
				_BaogiaDEntity.Mota = Mota;
				
				_BaogiaDEntity.DongiakhongVat = DongiakhongVat;
				
				_BaogiaDEntity.DongiaVat = DongiaVat;
				
				_BaogiaDEntity.Ngaytao = Ngaytao;
				
				_BaogiaDEntity.Nguoitao = Nguoitao;
				
				_BaogiaDEntity.Ngaysua = Ngaysua;
				
				_BaogiaDEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_BaogiaDEntity, true);
			}
			return _BaogiaDEntity;
		}

		public bool Update(BaogiaDEntity _BaogiaDEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(BaogiaDFields.Id == _BaogiaDEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_BaogiaDEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(BaogiaDEntity _BaogiaDEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_BaogiaDEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Sobaogia, System.Int64 Machungloai, System.String Tenchungloai, System.String Masp, System.String Tenhang, System.String Kichthuoc, System.Decimal Trongluong, System.String Mota, System.Int32 DongiakhongVat, System.Int32 DongiaVat, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				BaogiaDEntity _BaogiaDEntity = new BaogiaDEntity(Id);
				if (adapter.FetchEntity(_BaogiaDEntity))
				{
				
					
					
					_BaogiaDEntity.Sobaogia = Sobaogia;
					
					_BaogiaDEntity.Machungloai = Machungloai;
					
					_BaogiaDEntity.Tenchungloai = Tenchungloai;
					
					_BaogiaDEntity.Masp = Masp;
					
					_BaogiaDEntity.Tenhang = Tenhang;
					
					_BaogiaDEntity.Kichthuoc = Kichthuoc;
					
					_BaogiaDEntity.Trongluong = Trongluong;
					
					_BaogiaDEntity.Mota = Mota;
					
					_BaogiaDEntity.DongiakhongVat = DongiakhongVat;
					
					_BaogiaDEntity.DongiaVat = DongiaVat;
					
					_BaogiaDEntity.Ngaytao = Ngaytao;
					
					_BaogiaDEntity.Nguoitao = Nguoitao;
					
					_BaogiaDEntity.Ngaysua = Ngaysua;
					
					_BaogiaDEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_BaogiaDEntity, true);
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
				BaogiaDEntity _BaogiaDEntity = new BaogiaDEntity(Id);
				if (adapter.FetchEntity(_BaogiaDEntity))
				{
					adapter.DeleteEntity(_BaogiaDEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("BaogiaDEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySobaogia(System.String Sobaogia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Sobaogia == Sobaogia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMachungloai(System.Int64 Machungloai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Machungloai == Machungloai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenchungloai(System.String Tenchungloai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Tenchungloai == Tenchungloai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasp(System.String Masp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenhang(System.String Tenhang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Tenhang == Tenhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKichthuoc(System.String Kichthuoc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTrongluong(System.Decimal Trongluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMota(System.String Mota)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Mota == Mota);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDongiakhongVat(System.Int32 DongiakhongVat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.DongiakhongVat == DongiakhongVat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDongiaVat(System.Int32 DongiaVat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.DongiaVat == DongiaVat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaDEntity", filter);
			}
			return toReturn;
		}		
			
		
		public BaogiaDEntity SelectOne(System.Int64 Id)
		{
			BaogiaDEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				BaogiaDEntity _BaogiaDEntity = new BaogiaDEntity(Id);
				if (adapter.FetchEntity(_BaogiaDEntity))
				{
					toReturn = _BaogiaDEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _BaogiaDCollection = new EntityCollection( new BaogiaDEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, null, 0, null);
			}
			return _BaogiaDCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, filter, 0, null);
			}
			return _BaogiaDCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySobaogia(System.String Sobaogia)
		{
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Sobaogia == Sobaogia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, filter, 0, null);
			}
			return _BaogiaDCollection;
		}
		// Return DataTable
		public DataTable SelectBySobaogiaRDT(System.String Sobaogia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Sobaogia == Sobaogia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMachungloai(System.Int64 Machungloai)
		{
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Machungloai == Machungloai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, filter, 0, null);
			}
			return _BaogiaDCollection;
		}
		// Return DataTable
		public DataTable SelectByMachungloaiRDT(System.Int64 Machungloai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Machungloai == Machungloai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenchungloai(System.String Tenchungloai)
		{
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Tenchungloai == Tenchungloai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, filter, 0, null);
			}
			return _BaogiaDCollection;
		}
		// Return DataTable
		public DataTable SelectByTenchungloaiRDT(System.String Tenchungloai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Tenchungloai == Tenchungloai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasp(System.String Masp)
		{
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, filter, 0, null);
			}
			return _BaogiaDCollection;
		}
		// Return DataTable
		public DataTable SelectByMaspRDT(System.String Masp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenhang(System.String Tenhang)
		{
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Tenhang == Tenhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, filter, 0, null);
			}
			return _BaogiaDCollection;
		}
		// Return DataTable
		public DataTable SelectByTenhangRDT(System.String Tenhang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Tenhang == Tenhang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKichthuoc(System.String Kichthuoc)
		{
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, filter, 0, null);
			}
			return _BaogiaDCollection;
		}
		// Return DataTable
		public DataTable SelectByKichthuocRDT(System.String Kichthuoc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTrongluong(System.Decimal Trongluong)
		{
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, filter, 0, null);
			}
			return _BaogiaDCollection;
		}
		// Return DataTable
		public DataTable SelectByTrongluongRDT(System.Decimal Trongluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMota(System.String Mota)
		{
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Mota == Mota);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, filter, 0, null);
			}
			return _BaogiaDCollection;
		}
		// Return DataTable
		public DataTable SelectByMotaRDT(System.String Mota)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Mota == Mota);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDongiakhongVat(System.Int32 DongiakhongVat)
		{
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.DongiakhongVat == DongiakhongVat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, filter, 0, null);
			}
			return _BaogiaDCollection;
		}
		// Return DataTable
		public DataTable SelectByDongiakhongVatRDT(System.Int32 DongiakhongVat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.DongiakhongVat == DongiakhongVat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDongiaVat(System.Int32 DongiaVat)
		{
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.DongiaVat == DongiaVat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, filter, 0, null);
			}
			return _BaogiaDCollection;
		}
		// Return DataTable
		public DataTable SelectByDongiaVatRDT(System.Int32 DongiaVat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.DongiaVat == DongiaVat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, filter, 0, null);
			}
			return _BaogiaDCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, filter, 0, null);
			}
			return _BaogiaDCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, filter, 0, null);
			}
			return _BaogiaDCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaDCollection, filter, 0, null);
			}
			return _BaogiaDCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaDCollection = new EntityCollection(new BaogiaDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaDFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
