


/*
'===============================================================================
'  GD.BBPH.BL.BaogiaHManagerBase
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
	public class BaogiaHManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Sobaogia="Sobaogia";				
		
		public const String Field_Ngaybaogia="Ngaybaogia";				
		
		public const String Field_Ngayhieuluc="Ngayhieuluc";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Noidung="Noidung";				
		
		public const String Field_Phuongthuctt="Phuongthuctt";				
		
		public const String Field_Diadiemgiao="Diadiemgiao";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public BaogiaHManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Sobaogia,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaybaogia,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Ngayhieuluc,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Noidung,typeof(System.String));
			
			dt.Columns.Add(Field_Phuongthuctt,typeof(System.String));
			
			dt.Columns.Add(Field_Diadiemgiao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(BaogiaHEntity _BaogiaHEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Sobaogia]=_BaogiaHEntity.Sobaogia;
			}
			catch { }
			
			try
			{
				r[Field_Ngaybaogia]=_BaogiaHEntity.Ngaybaogia;
			}
			catch { }
			
			try
			{
				r[Field_Ngayhieuluc]=_BaogiaHEntity.Ngayhieuluc;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_BaogiaHEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_BaogiaHEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Noidung]=_BaogiaHEntity.Noidung;
			}
			catch { }
			
			try
			{
				r[Field_Phuongthuctt]=_BaogiaHEntity.Phuongthuctt;
			}
			catch { }
			
			try
			{
				r[Field_Diadiemgiao]=_BaogiaHEntity.Diadiemgiao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_BaogiaHEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_BaogiaHEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_BaogiaHEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_BaogiaHEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public BaogiaHEntity Convert(DataRow r)
		{	
			
			BaogiaHEntity _BaogiaHEntity=new BaogiaHEntity(r[Field_Sobaogia].ToString());					
						
			
			
			try
			{
				_BaogiaHEntity.Ngaybaogia= System.DateTime.Parse(r[Field_Ngaybaogia].ToString());						
			}
			catch { }
			
			try
			{
				_BaogiaHEntity.Ngayhieuluc= System.DateTime.Parse(r[Field_Ngayhieuluc].ToString());						
			}
			catch { }
			
			try
			{
				_BaogiaHEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_BaogiaHEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_BaogiaHEntity.Noidung= r[Field_Noidung].ToString();						
			}
			catch { }
			
			try
			{
				_BaogiaHEntity.Phuongthuctt= r[Field_Phuongthuctt].ToString();						
			}
			catch { }
			
			try
			{
				_BaogiaHEntity.Diadiemgiao= r[Field_Diadiemgiao].ToString();						
			}
			catch { }
			
			try
			{
				_BaogiaHEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_BaogiaHEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_BaogiaHEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_BaogiaHEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _BaogiaHEntity;
		}			
		
		public BaogiaHEntity Convert_Entity(BaogiaHEntity _BaogiaHEntity,BaogiaHEntity _BaogiaHEntity_XML)
		{	
			
			
			_BaogiaHEntity.Sobaogia= _BaogiaHEntity_XML.Sobaogia;
			
			_BaogiaHEntity.Ngaybaogia= _BaogiaHEntity_XML.Ngaybaogia;
			
			_BaogiaHEntity.Ngayhieuluc= _BaogiaHEntity_XML.Ngayhieuluc;
			
			_BaogiaHEntity.Makhach= _BaogiaHEntity_XML.Makhach;
			
			_BaogiaHEntity.Tenkhach= _BaogiaHEntity_XML.Tenkhach;
			
			_BaogiaHEntity.Noidung= _BaogiaHEntity_XML.Noidung;
			
			_BaogiaHEntity.Phuongthuctt= _BaogiaHEntity_XML.Phuongthuctt;
			
			_BaogiaHEntity.Diadiemgiao= _BaogiaHEntity_XML.Diadiemgiao;
			
			_BaogiaHEntity.Ngaytao= _BaogiaHEntity_XML.Ngaytao;
			
			_BaogiaHEntity.Nguoitao= _BaogiaHEntity_XML.Nguoitao;
			
			_BaogiaHEntity.Ngaysua= _BaogiaHEntity_XML.Ngaysua;
			
			_BaogiaHEntity.Nguoisua= _BaogiaHEntity_XML.Nguoisua;
									
				
			return _BaogiaHEntity;
		}	
		
		public String InsertV2(BaogiaHEntity _BaogiaHEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new BaogiaHManagerBase()).Insert(_BaogiaHEntity).Sobaogia.ToString();
			
			
			try
			{
				r.SetField(Field_Sobaogia,_BaogiaHEntity.Sobaogia);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngaybaogia,_BaogiaHEntity.Ngaybaogia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngayhieuluc,_BaogiaHEntity.Ngayhieuluc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_BaogiaHEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_BaogiaHEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Noidung,_BaogiaHEntity.Noidung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phuongthuctt,_BaogiaHEntity.Phuongthuctt);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diadiemgiao,_BaogiaHEntity.Diadiemgiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_BaogiaHEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_BaogiaHEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_BaogiaHEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_BaogiaHEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(BaogiaHEntity _BaogiaHEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new BaogiaHManagerBase()).Update(_BaogiaHEntity);
			r.SetField(Field_Sobaogia,_BaogiaHEntity.Sobaogia);
									
			
			
			
			try
			{
				r.SetField(Field_Ngaybaogia,_BaogiaHEntity.Ngaybaogia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngayhieuluc,_BaogiaHEntity.Ngayhieuluc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_BaogiaHEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_BaogiaHEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Noidung,_BaogiaHEntity.Noidung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phuongthuctt,_BaogiaHEntity.Phuongthuctt);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Diadiemgiao,_BaogiaHEntity.Diadiemgiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_BaogiaHEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_BaogiaHEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_BaogiaHEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_BaogiaHEntity.Nguoisua);
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

		public BaogiaHEntity Insert(BaogiaHEntity BaogiaHEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(BaogiaHEntity, true);
			}
			return BaogiaHEntity;
		}

		public BaogiaHEntity Insert(System.String  Sobaogia, System.DateTime  Ngaybaogia, System.DateTime  Ngayhieuluc, System.String  Makhach, System.String  Tenkhach, System.String  Noidung, System.String  Phuongthuctt, System.String  Diadiemgiao, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			BaogiaHEntity _BaogiaHEntity = new BaogiaHEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_BaogiaHEntity.Sobaogia = Sobaogia;
				
				_BaogiaHEntity.Ngaybaogia = Ngaybaogia;
				
				_BaogiaHEntity.Ngayhieuluc = Ngayhieuluc;
				
				_BaogiaHEntity.Makhach = Makhach;
				
				_BaogiaHEntity.Tenkhach = Tenkhach;
				
				_BaogiaHEntity.Noidung = Noidung;
				
				_BaogiaHEntity.Phuongthuctt = Phuongthuctt;
				
				_BaogiaHEntity.Diadiemgiao = Diadiemgiao;
				
				_BaogiaHEntity.Ngaytao = Ngaytao;
				
				_BaogiaHEntity.Nguoitao = Nguoitao;
				
				_BaogiaHEntity.Ngaysua = Ngaysua;
				
				_BaogiaHEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_BaogiaHEntity, true);
			}
			return _BaogiaHEntity;
		}

		public BaogiaHEntity Insert(System.DateTime Ngaybaogia, System.DateTime Ngayhieuluc, System.String Makhach, System.String Tenkhach, System.String Noidung, System.String Phuongthuctt, System.String Diadiemgiao, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			BaogiaHEntity _BaogiaHEntity = new BaogiaHEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_BaogiaHEntity.Ngaybaogia = Ngaybaogia;
				
				_BaogiaHEntity.Ngayhieuluc = Ngayhieuluc;
				
				_BaogiaHEntity.Makhach = Makhach;
				
				_BaogiaHEntity.Tenkhach = Tenkhach;
				
				_BaogiaHEntity.Noidung = Noidung;
				
				_BaogiaHEntity.Phuongthuctt = Phuongthuctt;
				
				_BaogiaHEntity.Diadiemgiao = Diadiemgiao;
				
				_BaogiaHEntity.Ngaytao = Ngaytao;
				
				_BaogiaHEntity.Nguoitao = Nguoitao;
				
				_BaogiaHEntity.Ngaysua = Ngaysua;
				
				_BaogiaHEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_BaogiaHEntity, true);
			}
			return _BaogiaHEntity;
		}

		public bool Update(BaogiaHEntity _BaogiaHEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(BaogiaHFields.Sobaogia == _BaogiaHEntity.Sobaogia);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_BaogiaHEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(BaogiaHEntity _BaogiaHEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_BaogiaHEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Sobaogia, System.DateTime Ngaybaogia, System.DateTime Ngayhieuluc, System.String Makhach, System.String Tenkhach, System.String Noidung, System.String Phuongthuctt, System.String Diadiemgiao, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				BaogiaHEntity _BaogiaHEntity = new BaogiaHEntity(Sobaogia);
				if (adapter.FetchEntity(_BaogiaHEntity))
				{
				
					
					
					_BaogiaHEntity.Ngaybaogia = Ngaybaogia;
					
					_BaogiaHEntity.Ngayhieuluc = Ngayhieuluc;
					
					_BaogiaHEntity.Makhach = Makhach;
					
					_BaogiaHEntity.Tenkhach = Tenkhach;
					
					_BaogiaHEntity.Noidung = Noidung;
					
					_BaogiaHEntity.Phuongthuctt = Phuongthuctt;
					
					_BaogiaHEntity.Diadiemgiao = Diadiemgiao;
					
					_BaogiaHEntity.Ngaytao = Ngaytao;
					
					_BaogiaHEntity.Nguoitao = Nguoitao;
					
					_BaogiaHEntity.Ngaysua = Ngaysua;
					
					_BaogiaHEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_BaogiaHEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Sobaogia)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				BaogiaHEntity _BaogiaHEntity = new BaogiaHEntity(Sobaogia);
				if (adapter.FetchEntity(_BaogiaHEntity))
				{
					adapter.DeleteEntity(_BaogiaHEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("BaogiaHEntity", null);
			}
		}
		
		
		
		public int DeleteBySobaogia(System.String Sobaogia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Sobaogia == Sobaogia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaybaogia(System.DateTime Ngaybaogia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Ngaybaogia == Ngaybaogia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgayhieuluc(System.DateTime Ngayhieuluc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Ngayhieuluc == Ngayhieuluc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNoidung(System.String Noidung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Noidung == Noidung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhuongthuctt(System.String Phuongthuctt)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Phuongthuctt == Phuongthuctt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDiadiemgiao(System.String Diadiemgiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Diadiemgiao == Diadiemgiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BaogiaHEntity", filter);
			}
			return toReturn;
		}		
			
		
		public BaogiaHEntity SelectOne(System.String Sobaogia)
		{
			BaogiaHEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				BaogiaHEntity _BaogiaHEntity = new BaogiaHEntity(Sobaogia);
				if (adapter.FetchEntity(_BaogiaHEntity))
				{
					toReturn = _BaogiaHEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _BaogiaHCollection = new EntityCollection( new BaogiaHEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaHCollection, null, 0, null);
			}
			return _BaogiaHCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaHCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectBySobaogia(System.String Sobaogia)
		{
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Sobaogia == Sobaogia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaHCollection, filter, 0, null);
			}
			return _BaogiaHCollection;
		}
		// Return DataTable
		public DataTable SelectBySobaogiaRDT(System.String Sobaogia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Sobaogia == Sobaogia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaybaogia(System.DateTime Ngaybaogia)
		{
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Ngaybaogia == Ngaybaogia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaHCollection, filter, 0, null);
			}
			return _BaogiaHCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaybaogiaRDT(System.DateTime Ngaybaogia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Ngaybaogia == Ngaybaogia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgayhieuluc(System.DateTime Ngayhieuluc)
		{
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Ngayhieuluc == Ngayhieuluc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaHCollection, filter, 0, null);
			}
			return _BaogiaHCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayhieulucRDT(System.DateTime Ngayhieuluc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Ngayhieuluc == Ngayhieuluc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaHCollection, filter, 0, null);
			}
			return _BaogiaHCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaHCollection, filter, 0, null);
			}
			return _BaogiaHCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNoidung(System.String Noidung)
		{
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Noidung == Noidung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaHCollection, filter, 0, null);
			}
			return _BaogiaHCollection;
		}
		// Return DataTable
		public DataTable SelectByNoidungRDT(System.String Noidung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Noidung == Noidung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhuongthuctt(System.String Phuongthuctt)
		{
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Phuongthuctt == Phuongthuctt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaHCollection, filter, 0, null);
			}
			return _BaogiaHCollection;
		}
		// Return DataTable
		public DataTable SelectByPhuongthucttRDT(System.String Phuongthuctt)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Phuongthuctt == Phuongthuctt);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDiadiemgiao(System.String Diadiemgiao)
		{
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Diadiemgiao == Diadiemgiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaHCollection, filter, 0, null);
			}
			return _BaogiaHCollection;
		}
		// Return DataTable
		public DataTable SelectByDiadiemgiaoRDT(System.String Diadiemgiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Diadiemgiao == Diadiemgiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaHCollection, filter, 0, null);
			}
			return _BaogiaHCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaHCollection, filter, 0, null);
			}
			return _BaogiaHCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaHCollection, filter, 0, null);
			}
			return _BaogiaHCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BaogiaHCollection, filter, 0, null);
			}
			return _BaogiaHCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BaogiaHCollection = new EntityCollection(new BaogiaHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BaogiaHFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BaogiaHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
