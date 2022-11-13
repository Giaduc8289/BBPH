


/*
'===============================================================================
'  GD.BBPH.BL.DonhangHManagerBase
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
	public class DonhangHManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Madon="Madon";				
		
		public const String Field_Ngaydat="Ngaydat";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Sobaogia="Sobaogia";				
		
		public const String Field_Ngaybaogia="Ngaybaogia";				
		
		public const String Field_Userid="Userid";				
		
		public const String Field_Tennv="Tennv";				
		
		public const String Field_Ghichu="Ghichu";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DonhangHManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Madon,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaydat,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Sobaogia,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaybaogia,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Userid,typeof(System.String));
			
			dt.Columns.Add(Field_Tennv,typeof(System.String));
			
			dt.Columns.Add(Field_Ghichu,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DonhangHEntity _DonhangHEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Madon]=_DonhangHEntity.Madon;
			}
			catch { }
			
			try
			{
				r[Field_Ngaydat]=_DonhangHEntity.Ngaydat;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_DonhangHEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_DonhangHEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Sobaogia]=_DonhangHEntity.Sobaogia;
			}
			catch { }
			
			try
			{
				r[Field_Ngaybaogia]=_DonhangHEntity.Ngaybaogia;
			}
			catch { }
			
			try
			{
				r[Field_Userid]=_DonhangHEntity.Userid;
			}
			catch { }
			
			try
			{
				r[Field_Tennv]=_DonhangHEntity.Tennv;
			}
			catch { }
			
			try
			{
				r[Field_Ghichu]=_DonhangHEntity.Ghichu;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DonhangHEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DonhangHEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DonhangHEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DonhangHEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DonhangHEntity Convert(DataRow r)
		{	
			
			DonhangHEntity _DonhangHEntity=new DonhangHEntity(r[Field_Madon].ToString());					
						
			
			
			try
			{
				_DonhangHEntity.Ngaydat= System.DateTime.Parse(r[Field_Ngaydat].ToString());						
			}
			catch { }
			
			try
			{
				_DonhangHEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_DonhangHEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_DonhangHEntity.Sobaogia= r[Field_Sobaogia].ToString();						
			}
			catch { }
			
			try
			{
				_DonhangHEntity.Ngaybaogia= System.DateTime.Parse(r[Field_Ngaybaogia].ToString());						
			}
			catch { }
			
			try
			{
				_DonhangHEntity.Userid= r[Field_Userid].ToString();						
			}
			catch { }
			
			try
			{
				_DonhangHEntity.Tennv= r[Field_Tennv].ToString();						
			}
			catch { }
			
			try
			{
				_DonhangHEntity.Ghichu= r[Field_Ghichu].ToString();						
			}
			catch { }
			
			try
			{
				_DonhangHEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DonhangHEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DonhangHEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DonhangHEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DonhangHEntity;
		}			
		
		public DonhangHEntity Convert_Entity(DonhangHEntity _DonhangHEntity,DonhangHEntity _DonhangHEntity_XML)
		{	
			
			
			_DonhangHEntity.Madon= _DonhangHEntity_XML.Madon;
			
			_DonhangHEntity.Ngaydat= _DonhangHEntity_XML.Ngaydat;
			
			_DonhangHEntity.Makhach= _DonhangHEntity_XML.Makhach;
			
			_DonhangHEntity.Tenkhach= _DonhangHEntity_XML.Tenkhach;
			
			_DonhangHEntity.Sobaogia= _DonhangHEntity_XML.Sobaogia;
			
			_DonhangHEntity.Ngaybaogia= _DonhangHEntity_XML.Ngaybaogia;
			
			_DonhangHEntity.Userid= _DonhangHEntity_XML.Userid;
			
			_DonhangHEntity.Tennv= _DonhangHEntity_XML.Tennv;
			
			_DonhangHEntity.Ghichu= _DonhangHEntity_XML.Ghichu;
			
			_DonhangHEntity.Ngaytao= _DonhangHEntity_XML.Ngaytao;
			
			_DonhangHEntity.Nguoitao= _DonhangHEntity_XML.Nguoitao;
			
			_DonhangHEntity.Ngaysua= _DonhangHEntity_XML.Ngaysua;
			
			_DonhangHEntity.Nguoisua= _DonhangHEntity_XML.Nguoisua;
									
				
			return _DonhangHEntity;
		}	
		
		public String InsertV2(DonhangHEntity _DonhangHEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DonhangHManagerBase()).Insert(_DonhangHEntity).Madon.ToString();
			
			
			try
			{
				r.SetField(Field_Madon,_DonhangHEntity.Madon);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngaydat,_DonhangHEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_DonhangHEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_DonhangHEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sobaogia,_DonhangHEntity.Sobaogia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaybaogia,_DonhangHEntity.Ngaybaogia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Userid,_DonhangHEntity.Userid);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennv,_DonhangHEntity.Tennv);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ghichu,_DonhangHEntity.Ghichu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DonhangHEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DonhangHEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DonhangHEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DonhangHEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DonhangHEntity _DonhangHEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DonhangHManagerBase()).Update(_DonhangHEntity);
			r.SetField(Field_Madon,_DonhangHEntity.Madon);
									
			
			
			
			try
			{
				r.SetField(Field_Ngaydat,_DonhangHEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_DonhangHEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_DonhangHEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sobaogia,_DonhangHEntity.Sobaogia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaybaogia,_DonhangHEntity.Ngaybaogia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Userid,_DonhangHEntity.Userid);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennv,_DonhangHEntity.Tennv);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ghichu,_DonhangHEntity.Ghichu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DonhangHEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DonhangHEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DonhangHEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DonhangHEntity.Nguoisua);
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

		public DonhangHEntity Insert(DonhangHEntity DonhangHEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DonhangHEntity, true);
			}
			return DonhangHEntity;
		}

		public DonhangHEntity Insert(System.String  Madon, System.DateTime  Ngaydat, System.String  Makhach, System.String  Tenkhach, System.String  Sobaogia, System.DateTime  Ngaybaogia, System.String  Userid, System.String  Tennv, System.String  Ghichu, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DonhangHEntity _DonhangHEntity = new DonhangHEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DonhangHEntity.Madon = Madon;
				
				_DonhangHEntity.Ngaydat = Ngaydat;
				
				_DonhangHEntity.Makhach = Makhach;
				
				_DonhangHEntity.Tenkhach = Tenkhach;
				
				_DonhangHEntity.Sobaogia = Sobaogia;
				
				_DonhangHEntity.Ngaybaogia = Ngaybaogia;
				
				_DonhangHEntity.Userid = Userid;
				
				_DonhangHEntity.Tennv = Tennv;
				
				_DonhangHEntity.Ghichu = Ghichu;
				
				_DonhangHEntity.Ngaytao = Ngaytao;
				
				_DonhangHEntity.Nguoitao = Nguoitao;
				
				_DonhangHEntity.Ngaysua = Ngaysua;
				
				_DonhangHEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DonhangHEntity, true);
			}
			return _DonhangHEntity;
		}

		public DonhangHEntity Insert(System.DateTime Ngaydat, System.String Makhach, System.String Tenkhach, System.String Sobaogia, System.DateTime Ngaybaogia, System.String Userid, System.String Tennv, System.String Ghichu, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DonhangHEntity _DonhangHEntity = new DonhangHEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DonhangHEntity.Ngaydat = Ngaydat;
				
				_DonhangHEntity.Makhach = Makhach;
				
				_DonhangHEntity.Tenkhach = Tenkhach;
				
				_DonhangHEntity.Sobaogia = Sobaogia;
				
				_DonhangHEntity.Ngaybaogia = Ngaybaogia;
				
				_DonhangHEntity.Userid = Userid;
				
				_DonhangHEntity.Tennv = Tennv;
				
				_DonhangHEntity.Ghichu = Ghichu;
				
				_DonhangHEntity.Ngaytao = Ngaytao;
				
				_DonhangHEntity.Nguoitao = Nguoitao;
				
				_DonhangHEntity.Ngaysua = Ngaysua;
				
				_DonhangHEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DonhangHEntity, true);
			}
			return _DonhangHEntity;
		}

		public bool Update(DonhangHEntity _DonhangHEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DonhangHFields.Madon == _DonhangHEntity.Madon);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DonhangHEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DonhangHEntity _DonhangHEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DonhangHEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Madon, System.DateTime Ngaydat, System.String Makhach, System.String Tenkhach, System.String Sobaogia, System.DateTime Ngaybaogia, System.String Userid, System.String Tennv, System.String Ghichu, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DonhangHEntity _DonhangHEntity = new DonhangHEntity(Madon);
				if (adapter.FetchEntity(_DonhangHEntity))
				{
				
					
					
					_DonhangHEntity.Ngaydat = Ngaydat;
					
					_DonhangHEntity.Makhach = Makhach;
					
					_DonhangHEntity.Tenkhach = Tenkhach;
					
					_DonhangHEntity.Sobaogia = Sobaogia;
					
					_DonhangHEntity.Ngaybaogia = Ngaybaogia;
					
					_DonhangHEntity.Userid = Userid;
					
					_DonhangHEntity.Tennv = Tennv;
					
					_DonhangHEntity.Ghichu = Ghichu;
					
					_DonhangHEntity.Ngaytao = Ngaytao;
					
					_DonhangHEntity.Nguoitao = Nguoitao;
					
					_DonhangHEntity.Ngaysua = Ngaysua;
					
					_DonhangHEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DonhangHEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Madon)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DonhangHEntity _DonhangHEntity = new DonhangHEntity(Madon);
				if (adapter.FetchEntity(_DonhangHEntity))
				{
					adapter.DeleteEntity(_DonhangHEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DonhangHEntity", null);
			}
		}
		
		
		
		public int DeleteByMadon(System.String Madon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaydat(System.DateTime Ngaydat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySobaogia(System.String Sobaogia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Sobaogia == Sobaogia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaybaogia(System.DateTime Ngaybaogia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Ngaybaogia == Ngaybaogia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByUserid(System.String Userid)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Userid == Userid);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennv(System.String Tennv)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Tennv == Tennv);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByGhichu(System.String Ghichu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DonhangHEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DonhangHEntity SelectOne(System.String Madon)
		{
			DonhangHEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DonhangHEntity _DonhangHEntity = new DonhangHEntity(Madon);
				if (adapter.FetchEntity(_DonhangHEntity))
				{
					toReturn = _DonhangHEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DonhangHCollection = new EntityCollection( new DonhangHEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangHCollection, null, 0, null);
			}
			return _DonhangHCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangHCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMadon(System.String Madon)
		{
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangHCollection, filter, 0, null);
			}
			return _DonhangHCollection;
		}
		// Return DataTable
		public DataTable SelectByMadonRDT(System.String Madon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaydat(System.DateTime Ngaydat)
		{
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangHCollection, filter, 0, null);
			}
			return _DonhangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaydatRDT(System.DateTime Ngaydat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangHCollection, filter, 0, null);
			}
			return _DonhangHCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangHCollection, filter, 0, null);
			}
			return _DonhangHCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySobaogia(System.String Sobaogia)
		{
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Sobaogia == Sobaogia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangHCollection, filter, 0, null);
			}
			return _DonhangHCollection;
		}
		// Return DataTable
		public DataTable SelectBySobaogiaRDT(System.String Sobaogia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Sobaogia == Sobaogia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaybaogia(System.DateTime Ngaybaogia)
		{
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Ngaybaogia == Ngaybaogia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangHCollection, filter, 0, null);
			}
			return _DonhangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaybaogiaRDT(System.DateTime Ngaybaogia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Ngaybaogia == Ngaybaogia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByUserid(System.String Userid)
		{
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Userid == Userid);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangHCollection, filter, 0, null);
			}
			return _DonhangHCollection;
		}
		// Return DataTable
		public DataTable SelectByUseridRDT(System.String Userid)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Userid == Userid);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennv(System.String Tennv)
		{
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Tennv == Tennv);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangHCollection, filter, 0, null);
			}
			return _DonhangHCollection;
		}
		// Return DataTable
		public DataTable SelectByTennvRDT(System.String Tennv)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Tennv == Tennv);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByGhichu(System.String Ghichu)
		{
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangHCollection, filter, 0, null);
			}
			return _DonhangHCollection;
		}
		// Return DataTable
		public DataTable SelectByGhichuRDT(System.String Ghichu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangHCollection, filter, 0, null);
			}
			return _DonhangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangHCollection, filter, 0, null);
			}
			return _DonhangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangHCollection, filter, 0, null);
			}
			return _DonhangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DonhangHCollection, filter, 0, null);
			}
			return _DonhangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DonhangHCollection = new EntityCollection(new DonhangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DonhangHFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DonhangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(DonhangHFields.Madon.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
