


/*
'===============================================================================
'  GD.BBPH.BL.DmkhachManagerBase
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
	public class DmkhachManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Tenrutgon="Tenrutgon";				
		
		public const String Field_Truyenthong="Truyenthong";				
		
		public const String Field_Diachi="Diachi";				
		
		public const String Field_Sodienthoai="Sodienthoai";				
		
		public const String Field_Email="Email";				
		
		public const String Field_Tknganhang="Tknganhang";				
		
		public const String Field_Tennganhang="Tennganhang";				
		
		public const String Field_Noidia="Noidia";				
		
		public const String Field_Tennguoilh="Tennguoilh";				
		
		public const String Field_Chucvu="Chucvu";				
		
		public const String Field_Sodienthoailh="Sodienthoailh";				
		
		public const String Field_Thongtinbosung="Thongtinbosung";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmkhachManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenrutgon,typeof(System.String));
			
			dt.Columns.Add(Field_Truyenthong,typeof(System.Boolean));
			
			dt.Columns.Add(Field_Diachi,typeof(System.String));
			
			dt.Columns.Add(Field_Sodienthoai,typeof(System.String));
			
			dt.Columns.Add(Field_Email,typeof(System.String));
			
			dt.Columns.Add(Field_Tknganhang,typeof(System.String));
			
			dt.Columns.Add(Field_Tennganhang,typeof(System.String));
			
			dt.Columns.Add(Field_Noidia,typeof(System.Boolean));
			
			dt.Columns.Add(Field_Tennguoilh,typeof(System.String));
			
			dt.Columns.Add(Field_Chucvu,typeof(System.String));
			
			dt.Columns.Add(Field_Sodienthoailh,typeof(System.String));
			
			dt.Columns.Add(Field_Thongtinbosung,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmkhachEntity _DmkhachEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Makhach]=_DmkhachEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_DmkhachEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenrutgon]=_DmkhachEntity.Tenrutgon;
			}
			catch { }
			
			try
			{
				r[Field_Truyenthong]=_DmkhachEntity.Truyenthong;
			}
			catch { }
			
			try
			{
				r[Field_Diachi]=_DmkhachEntity.Diachi;
			}
			catch { }
			
			try
			{
				r[Field_Sodienthoai]=_DmkhachEntity.Sodienthoai;
			}
			catch { }
			
			try
			{
				r[Field_Email]=_DmkhachEntity.Email;
			}
			catch { }
			
			try
			{
				r[Field_Tknganhang]=_DmkhachEntity.Tknganhang;
			}
			catch { }
			
			try
			{
				r[Field_Tennganhang]=_DmkhachEntity.Tennganhang;
			}
			catch { }
			
			try
			{
				r[Field_Noidia]=_DmkhachEntity.Noidia;
			}
			catch { }
			
			try
			{
				r[Field_Tennguoilh]=_DmkhachEntity.Tennguoilh;
			}
			catch { }
			
			try
			{
				r[Field_Chucvu]=_DmkhachEntity.Chucvu;
			}
			catch { }
			
			try
			{
				r[Field_Sodienthoailh]=_DmkhachEntity.Sodienthoailh;
			}
			catch { }
			
			try
			{
				r[Field_Thongtinbosung]=_DmkhachEntity.Thongtinbosung;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmkhachEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmkhachEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmkhachEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmkhachEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmkhachEntity Convert(DataRow r)
		{	
			
			DmkhachEntity _DmkhachEntity=new DmkhachEntity(r[Field_Makhach].ToString());					
						
			
			
			try
			{
				_DmkhachEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Tenrutgon= r[Field_Tenrutgon].ToString();						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Truyenthong= System.Boolean.Parse(r[Field_Truyenthong].ToString());						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Diachi= r[Field_Diachi].ToString();						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Sodienthoai= r[Field_Sodienthoai].ToString();						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Email= r[Field_Email].ToString();						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Tknganhang= r[Field_Tknganhang].ToString();						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Tennganhang= r[Field_Tennganhang].ToString();						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Noidia= System.Boolean.Parse(r[Field_Noidia].ToString());						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Tennguoilh= r[Field_Tennguoilh].ToString();						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Chucvu= r[Field_Chucvu].ToString();						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Sodienthoailh= r[Field_Sodienthoailh].ToString();						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Thongtinbosung= r[Field_Thongtinbosung].ToString();						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmkhachEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DmkhachEntity;
		}			
		
		public DmkhachEntity Convert_Entity(DmkhachEntity _DmkhachEntity,DmkhachEntity _DmkhachEntity_XML)
		{	
			
			
			_DmkhachEntity.Makhach= _DmkhachEntity_XML.Makhach;
			
			_DmkhachEntity.Tenkhach= _DmkhachEntity_XML.Tenkhach;
			
			_DmkhachEntity.Tenrutgon= _DmkhachEntity_XML.Tenrutgon;
			
			_DmkhachEntity.Truyenthong= _DmkhachEntity_XML.Truyenthong;
			
			_DmkhachEntity.Diachi= _DmkhachEntity_XML.Diachi;
			
			_DmkhachEntity.Sodienthoai= _DmkhachEntity_XML.Sodienthoai;
			
			_DmkhachEntity.Email= _DmkhachEntity_XML.Email;
			
			_DmkhachEntity.Tknganhang= _DmkhachEntity_XML.Tknganhang;
			
			_DmkhachEntity.Tennganhang= _DmkhachEntity_XML.Tennganhang;
			
			_DmkhachEntity.Noidia= _DmkhachEntity_XML.Noidia;
			
			_DmkhachEntity.Tennguoilh= _DmkhachEntity_XML.Tennguoilh;
			
			_DmkhachEntity.Chucvu= _DmkhachEntity_XML.Chucvu;
			
			_DmkhachEntity.Sodienthoailh= _DmkhachEntity_XML.Sodienthoailh;
			
			_DmkhachEntity.Thongtinbosung= _DmkhachEntity_XML.Thongtinbosung;
			
			_DmkhachEntity.Ngaytao= _DmkhachEntity_XML.Ngaytao;
			
			_DmkhachEntity.Nguoitao= _DmkhachEntity_XML.Nguoitao;
			
			_DmkhachEntity.Ngaysua= _DmkhachEntity_XML.Ngaysua;
			
			_DmkhachEntity.Nguoisua= _DmkhachEntity_XML.Nguoisua;
									
				
			return _DmkhachEntity;
		}	
		
		public String InsertV2(DmkhachEntity _DmkhachEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmkhachManagerBase()).Insert(_DmkhachEntity).Makhach.ToString();
			
			
			try
			{
				r.SetField(Field_Makhach,_DmkhachEntity.Makhach);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenkhach,_DmkhachEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DmkhachEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Truyenthong,_DmkhachEntity.Truyenthong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diachi,_DmkhachEntity.Diachi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sodienthoai,_DmkhachEntity.Sodienthoai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Email,_DmkhachEntity.Email);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tknganhang,_DmkhachEntity.Tknganhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennganhang,_DmkhachEntity.Tennganhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Noidia,_DmkhachEntity.Noidia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennguoilh,_DmkhachEntity.Tennguoilh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chucvu,_DmkhachEntity.Chucvu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sodienthoailh,_DmkhachEntity.Sodienthoailh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thongtinbosung,_DmkhachEntity.Thongtinbosung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmkhachEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmkhachEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmkhachEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmkhachEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmkhachEntity _DmkhachEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmkhachManagerBase()).Update(_DmkhachEntity);
			r.SetField(Field_Makhach,_DmkhachEntity.Makhach);
									
			
			
			
			try
			{
				r.SetField(Field_Tenkhach,_DmkhachEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DmkhachEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Truyenthong,_DmkhachEntity.Truyenthong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diachi,_DmkhachEntity.Diachi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sodienthoai,_DmkhachEntity.Sodienthoai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Email,_DmkhachEntity.Email);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tknganhang,_DmkhachEntity.Tknganhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennganhang,_DmkhachEntity.Tennganhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Noidia,_DmkhachEntity.Noidia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennguoilh,_DmkhachEntity.Tennguoilh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chucvu,_DmkhachEntity.Chucvu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sodienthoailh,_DmkhachEntity.Sodienthoailh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thongtinbosung,_DmkhachEntity.Thongtinbosung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmkhachEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmkhachEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmkhachEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmkhachEntity.Nguoisua);
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

		public DmkhachEntity Insert(DmkhachEntity DmkhachEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmkhachEntity, true);
			}
			return DmkhachEntity;
		}

		public DmkhachEntity Insert(System.String  Makhach, System.String  Tenkhach, System.String  Tenrutgon, System.Boolean  Truyenthong, System.String  Diachi, System.String  Sodienthoai, System.String  Email, System.String  Tknganhang, System.String  Tennganhang, System.Boolean  Noidia, System.String  Tennguoilh, System.String  Chucvu, System.String  Sodienthoailh, System.String  Thongtinbosung, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DmkhachEntity _DmkhachEntity = new DmkhachEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmkhachEntity.Makhach = Makhach;
				
				_DmkhachEntity.Tenkhach = Tenkhach;
				
				_DmkhachEntity.Tenrutgon = Tenrutgon;
				
				_DmkhachEntity.Truyenthong = Truyenthong;
				
				_DmkhachEntity.Diachi = Diachi;
				
				_DmkhachEntity.Sodienthoai = Sodienthoai;
				
				_DmkhachEntity.Email = Email;
				
				_DmkhachEntity.Tknganhang = Tknganhang;
				
				_DmkhachEntity.Tennganhang = Tennganhang;
				
				_DmkhachEntity.Noidia = Noidia;
				
				_DmkhachEntity.Tennguoilh = Tennguoilh;
				
				_DmkhachEntity.Chucvu = Chucvu;
				
				_DmkhachEntity.Sodienthoailh = Sodienthoailh;
				
				_DmkhachEntity.Thongtinbosung = Thongtinbosung;
				
				_DmkhachEntity.Ngaytao = Ngaytao;
				
				_DmkhachEntity.Nguoitao = Nguoitao;
				
				_DmkhachEntity.Ngaysua = Ngaysua;
				
				_DmkhachEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DmkhachEntity, true);
			}
			return _DmkhachEntity;
		}

		public DmkhachEntity Insert(System.String Tenkhach, System.String Tenrutgon, System.Boolean Truyenthong, System.String Diachi, System.String Sodienthoai, System.String Email, System.String Tknganhang, System.String Tennganhang, System.Boolean Noidia, System.String Tennguoilh, System.String Chucvu, System.String Sodienthoailh, System.String Thongtinbosung, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DmkhachEntity _DmkhachEntity = new DmkhachEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmkhachEntity.Tenkhach = Tenkhach;
				
				_DmkhachEntity.Tenrutgon = Tenrutgon;
				
				_DmkhachEntity.Truyenthong = Truyenthong;
				
				_DmkhachEntity.Diachi = Diachi;
				
				_DmkhachEntity.Sodienthoai = Sodienthoai;
				
				_DmkhachEntity.Email = Email;
				
				_DmkhachEntity.Tknganhang = Tknganhang;
				
				_DmkhachEntity.Tennganhang = Tennganhang;
				
				_DmkhachEntity.Noidia = Noidia;
				
				_DmkhachEntity.Tennguoilh = Tennguoilh;
				
				_DmkhachEntity.Chucvu = Chucvu;
				
				_DmkhachEntity.Sodienthoailh = Sodienthoailh;
				
				_DmkhachEntity.Thongtinbosung = Thongtinbosung;
				
				_DmkhachEntity.Ngaytao = Ngaytao;
				
				_DmkhachEntity.Nguoitao = Nguoitao;
				
				_DmkhachEntity.Ngaysua = Ngaysua;
				
				_DmkhachEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DmkhachEntity, true);
			}
			return _DmkhachEntity;
		}

		public bool Update(DmkhachEntity _DmkhachEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmkhachFields.Makhach == _DmkhachEntity.Makhach);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmkhachEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmkhachEntity _DmkhachEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmkhachEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Makhach, System.String Tenkhach, System.String Tenrutgon, System.Boolean Truyenthong, System.String Diachi, System.String Sodienthoai, System.String Email, System.String Tknganhang, System.String Tennganhang, System.Boolean Noidia, System.String Tennguoilh, System.String Chucvu, System.String Sodienthoailh, System.String Thongtinbosung, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmkhachEntity _DmkhachEntity = new DmkhachEntity(Makhach);
				if (adapter.FetchEntity(_DmkhachEntity))
				{
				
					
					
					_DmkhachEntity.Tenkhach = Tenkhach;
					
					_DmkhachEntity.Tenrutgon = Tenrutgon;
					
					_DmkhachEntity.Truyenthong = Truyenthong;
					
					_DmkhachEntity.Diachi = Diachi;
					
					_DmkhachEntity.Sodienthoai = Sodienthoai;
					
					_DmkhachEntity.Email = Email;
					
					_DmkhachEntity.Tknganhang = Tknganhang;
					
					_DmkhachEntity.Tennganhang = Tennganhang;
					
					_DmkhachEntity.Noidia = Noidia;
					
					_DmkhachEntity.Tennguoilh = Tennguoilh;
					
					_DmkhachEntity.Chucvu = Chucvu;
					
					_DmkhachEntity.Sodienthoailh = Sodienthoailh;
					
					_DmkhachEntity.Thongtinbosung = Thongtinbosung;
					
					_DmkhachEntity.Ngaytao = Ngaytao;
					
					_DmkhachEntity.Nguoitao = Nguoitao;
					
					_DmkhachEntity.Ngaysua = Ngaysua;
					
					_DmkhachEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DmkhachEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Makhach)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmkhachEntity _DmkhachEntity = new DmkhachEntity(Makhach);
				if (adapter.FetchEntity(_DmkhachEntity))
				{
					adapter.DeleteEntity(_DmkhachEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmkhachEntity", null);
			}
		}
		
		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenrutgon(System.String Tenrutgon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTruyenthong(System.Boolean Truyenthong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Truyenthong == Truyenthong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDiachi(System.String Diachi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Diachi == Diachi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySodienthoai(System.String Sodienthoai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Sodienthoai == Sodienthoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByEmail(System.String Email)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTknganhang(System.String Tknganhang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Tknganhang == Tknganhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennganhang(System.String Tennganhang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Tennganhang == Tennganhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNoidia(System.Boolean Noidia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Noidia == Noidia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennguoilh(System.String Tennguoilh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Tennguoilh == Tennguoilh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByChucvu(System.String Chucvu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Chucvu == Chucvu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySodienthoailh(System.String Sodienthoailh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Sodienthoailh == Sodienthoailh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThongtinbosung(System.String Thongtinbosung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Thongtinbosung == Thongtinbosung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmkhachEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmkhachEntity SelectOne(System.String Makhach)
		{
			DmkhachEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmkhachEntity _DmkhachEntity = new DmkhachEntity(Makhach);
				if (adapter.FetchEntity(_DmkhachEntity))
				{
					toReturn = _DmkhachEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmkhachCollection = new EntityCollection( new DmkhachEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, null, 0, null);
			}
			return _DmkhachCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenrutgon(System.String Tenrutgon)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByTenrutgonRDT(System.String Tenrutgon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTruyenthong(System.Boolean Truyenthong)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Truyenthong == Truyenthong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByTruyenthongRDT(System.Boolean Truyenthong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Truyenthong == Truyenthong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDiachi(System.String Diachi)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Diachi == Diachi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByDiachiRDT(System.String Diachi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Diachi == Diachi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySodienthoai(System.String Sodienthoai)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Sodienthoai == Sodienthoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectBySodienthoaiRDT(System.String Sodienthoai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Sodienthoai == Sodienthoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByEmail(System.String Email)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByEmailRDT(System.String Email)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTknganhang(System.String Tknganhang)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Tknganhang == Tknganhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByTknganhangRDT(System.String Tknganhang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Tknganhang == Tknganhang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennganhang(System.String Tennganhang)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Tennganhang == Tennganhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByTennganhangRDT(System.String Tennganhang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Tennganhang == Tennganhang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNoidia(System.Boolean Noidia)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Noidia == Noidia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByNoidiaRDT(System.Boolean Noidia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Noidia == Noidia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennguoilh(System.String Tennguoilh)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Tennguoilh == Tennguoilh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByTennguoilhRDT(System.String Tennguoilh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Tennguoilh == Tennguoilh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByChucvu(System.String Chucvu)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Chucvu == Chucvu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByChucvuRDT(System.String Chucvu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Chucvu == Chucvu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySodienthoailh(System.String Sodienthoailh)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Sodienthoailh == Sodienthoailh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectBySodienthoailhRDT(System.String Sodienthoailh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Sodienthoailh == Sodienthoailh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThongtinbosung(System.String Thongtinbosung)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Thongtinbosung == Thongtinbosung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByThongtinbosungRDT(System.String Thongtinbosung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Thongtinbosung == Thongtinbosung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmkhachCollection, filter, 0, null);
			}
			return _DmkhachCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmkhachCollection = new EntityCollection(new DmkhachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmkhachFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmkhachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(DmkhachFields.Makhach.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
