


/*
'===============================================================================
'  GD.BBPH.BL.DmhangManagerBase
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
	public class DmhangManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Masp="Masp";				
		
		public const String Field_Tensp="Tensp";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Kichthuoc="Kichthuoc";				
		
		public const String Field_Khoiluongmuc="Khoiluongmuc";				
		
		public const String Field_Sohinh="Sohinh";				
		
		public const String Field_Cautrucin="Cautrucin";				
		
		public const String Field_Somau="Somau";				
		
		public const String Field_Loaimuc="Loaimuc";				
		
		public const String Field_Kichthuoctruc="Kichthuoctruc";				
		
		public const String Field_Vitri="Vitri";				
		
		public const String Field_Quycachdonggoi="Quycachdonggoi";				
		
		public const String Field_Loaithung="Loaithung";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmhangManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Masp,typeof(System.String));
			
			dt.Columns.Add(Field_Tensp,typeof(System.String));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Kichthuoc,typeof(System.String));
			
			dt.Columns.Add(Field_Khoiluongmuc,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sohinh,typeof(System.Int32));
			
			dt.Columns.Add(Field_Cautrucin,typeof(System.String));
			
			dt.Columns.Add(Field_Somau,typeof(System.Int32));
			
			dt.Columns.Add(Field_Loaimuc,typeof(System.String));
			
			dt.Columns.Add(Field_Kichthuoctruc,typeof(System.String));
			
			dt.Columns.Add(Field_Vitri,typeof(System.String));
			
			dt.Columns.Add(Field_Quycachdonggoi,typeof(System.String));
			
			dt.Columns.Add(Field_Loaithung,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmhangEntity _DmhangEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Masp]=_DmhangEntity.Masp;
			}
			catch { }
			
			try
			{
				r[Field_Tensp]=_DmhangEntity.Tensp;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_DmhangEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_DmhangEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Kichthuoc]=_DmhangEntity.Kichthuoc;
			}
			catch { }
			
			try
			{
				r[Field_Khoiluongmuc]=_DmhangEntity.Khoiluongmuc;
			}
			catch { }
			
			try
			{
				r[Field_Sohinh]=_DmhangEntity.Sohinh;
			}
			catch { }
			
			try
			{
				r[Field_Cautrucin]=_DmhangEntity.Cautrucin;
			}
			catch { }
			
			try
			{
				r[Field_Somau]=_DmhangEntity.Somau;
			}
			catch { }
			
			try
			{
				r[Field_Loaimuc]=_DmhangEntity.Loaimuc;
			}
			catch { }
			
			try
			{
				r[Field_Kichthuoctruc]=_DmhangEntity.Kichthuoctruc;
			}
			catch { }
			
			try
			{
				r[Field_Vitri]=_DmhangEntity.Vitri;
			}
			catch { }
			
			try
			{
				r[Field_Quycachdonggoi]=_DmhangEntity.Quycachdonggoi;
			}
			catch { }
			
			try
			{
				r[Field_Loaithung]=_DmhangEntity.Loaithung;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmhangEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmhangEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmhangEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmhangEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmhangEntity Convert(DataRow r)
		{	
			
			DmhangEntity _DmhangEntity=new DmhangEntity(r[Field_Masp].ToString());					
						
			
			
			try
			{
				_DmhangEntity.Tensp= r[Field_Tensp].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Kichthuoc= r[Field_Kichthuoc].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Khoiluongmuc= System.Decimal.Parse(r[Field_Khoiluongmuc].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Sohinh= System.Int32.Parse(r[Field_Sohinh].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Cautrucin= r[Field_Cautrucin].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Somau= System.Int32.Parse(r[Field_Somau].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Loaimuc= r[Field_Loaimuc].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Kichthuoctruc= r[Field_Kichthuoctruc].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Vitri= r[Field_Vitri].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Quycachdonggoi= r[Field_Quycachdonggoi].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Loaithung= r[Field_Loaithung].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DmhangEntity;
		}			
		
		public DmhangEntity Convert_Entity(DmhangEntity _DmhangEntity,DmhangEntity _DmhangEntity_XML)
		{	
			
			
			_DmhangEntity.Masp= _DmhangEntity_XML.Masp;
			
			_DmhangEntity.Tensp= _DmhangEntity_XML.Tensp;
			
			_DmhangEntity.Makhach= _DmhangEntity_XML.Makhach;
			
			_DmhangEntity.Tenkhach= _DmhangEntity_XML.Tenkhach;
			
			_DmhangEntity.Kichthuoc= _DmhangEntity_XML.Kichthuoc;
			
			_DmhangEntity.Khoiluongmuc= _DmhangEntity_XML.Khoiluongmuc;
			
			_DmhangEntity.Sohinh= _DmhangEntity_XML.Sohinh;
			
			_DmhangEntity.Cautrucin= _DmhangEntity_XML.Cautrucin;
			
			_DmhangEntity.Somau= _DmhangEntity_XML.Somau;
			
			_DmhangEntity.Loaimuc= _DmhangEntity_XML.Loaimuc;
			
			_DmhangEntity.Kichthuoctruc= _DmhangEntity_XML.Kichthuoctruc;
			
			_DmhangEntity.Vitri= _DmhangEntity_XML.Vitri;
			
			_DmhangEntity.Quycachdonggoi= _DmhangEntity_XML.Quycachdonggoi;
			
			_DmhangEntity.Loaithung= _DmhangEntity_XML.Loaithung;
			
			_DmhangEntity.Ngaytao= _DmhangEntity_XML.Ngaytao;
			
			_DmhangEntity.Nguoitao= _DmhangEntity_XML.Nguoitao;
			
			_DmhangEntity.Ngaysua= _DmhangEntity_XML.Ngaysua;
			
			_DmhangEntity.Nguoisua= _DmhangEntity_XML.Nguoisua;
									
				
			return _DmhangEntity;
		}	
		
		public String InsertV2(DmhangEntity _DmhangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmhangManagerBase()).Insert(_DmhangEntity).Masp.ToString();
			
			
			try
			{
				r.SetField(Field_Masp,_DmhangEntity.Masp);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tensp,_DmhangEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_DmhangEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_DmhangEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kichthuoc,_DmhangEntity.Kichthuoc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khoiluongmuc,_DmhangEntity.Khoiluongmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohinh,_DmhangEntity.Sohinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Cautrucin,_DmhangEntity.Cautrucin);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somau,_DmhangEntity.Somau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaimuc,_DmhangEntity.Loaimuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kichthuoctruc,_DmhangEntity.Kichthuoctruc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Vitri,_DmhangEntity.Vitri);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Quycachdonggoi,_DmhangEntity.Quycachdonggoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaithung,_DmhangEntity.Loaithung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmhangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmhangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmhangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmhangEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmhangEntity _DmhangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmhangManagerBase()).Update(_DmhangEntity);
			r.SetField(Field_Masp,_DmhangEntity.Masp);
									
			
			
			
			try
			{
				r.SetField(Field_Tensp,_DmhangEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_DmhangEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_DmhangEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kichthuoc,_DmhangEntity.Kichthuoc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khoiluongmuc,_DmhangEntity.Khoiluongmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohinh,_DmhangEntity.Sohinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Cautrucin,_DmhangEntity.Cautrucin);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somau,_DmhangEntity.Somau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaimuc,_DmhangEntity.Loaimuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kichthuoctruc,_DmhangEntity.Kichthuoctruc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Vitri,_DmhangEntity.Vitri);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Quycachdonggoi,_DmhangEntity.Quycachdonggoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaithung,_DmhangEntity.Loaithung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmhangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmhangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmhangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmhangEntity.Nguoisua);
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

		public DmhangEntity Insert(DmhangEntity DmhangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmhangEntity, true);
			}
			return DmhangEntity;
		}

		public DmhangEntity Insert(System.String  Masp, System.String  Tensp, System.String  Makhach, System.String  Tenkhach, System.String  Kichthuoc, System.Decimal  Khoiluongmuc, System.Int32  Sohinh, System.String  Cautrucin, System.Int32  Somau, System.String  Loaimuc, System.String  Kichthuoctruc, System.String  Vitri, System.String  Quycachdonggoi, System.String  Loaithung, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DmhangEntity _DmhangEntity = new DmhangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmhangEntity.Masp = Masp;
				
				_DmhangEntity.Tensp = Tensp;
				
				_DmhangEntity.Makhach = Makhach;
				
				_DmhangEntity.Tenkhach = Tenkhach;
				
				_DmhangEntity.Kichthuoc = Kichthuoc;
				
				_DmhangEntity.Khoiluongmuc = Khoiluongmuc;
				
				_DmhangEntity.Sohinh = Sohinh;
				
				_DmhangEntity.Cautrucin = Cautrucin;
				
				_DmhangEntity.Somau = Somau;
				
				_DmhangEntity.Loaimuc = Loaimuc;
				
				_DmhangEntity.Kichthuoctruc = Kichthuoctruc;
				
				_DmhangEntity.Vitri = Vitri;
				
				_DmhangEntity.Quycachdonggoi = Quycachdonggoi;
				
				_DmhangEntity.Loaithung = Loaithung;
				
				_DmhangEntity.Ngaytao = Ngaytao;
				
				_DmhangEntity.Nguoitao = Nguoitao;
				
				_DmhangEntity.Ngaysua = Ngaysua;
				
				_DmhangEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DmhangEntity, true);
			}
			return _DmhangEntity;
		}

		public DmhangEntity Insert(System.String Tensp, System.String Makhach, System.String Tenkhach, System.String Kichthuoc, System.Decimal Khoiluongmuc, System.Int32 Sohinh, System.String Cautrucin, System.Int32 Somau, System.String Loaimuc, System.String Kichthuoctruc, System.String Vitri, System.String Quycachdonggoi, System.String Loaithung, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DmhangEntity _DmhangEntity = new DmhangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmhangEntity.Tensp = Tensp;
				
				_DmhangEntity.Makhach = Makhach;
				
				_DmhangEntity.Tenkhach = Tenkhach;
				
				_DmhangEntity.Kichthuoc = Kichthuoc;
				
				_DmhangEntity.Khoiluongmuc = Khoiluongmuc;
				
				_DmhangEntity.Sohinh = Sohinh;
				
				_DmhangEntity.Cautrucin = Cautrucin;
				
				_DmhangEntity.Somau = Somau;
				
				_DmhangEntity.Loaimuc = Loaimuc;
				
				_DmhangEntity.Kichthuoctruc = Kichthuoctruc;
				
				_DmhangEntity.Vitri = Vitri;
				
				_DmhangEntity.Quycachdonggoi = Quycachdonggoi;
				
				_DmhangEntity.Loaithung = Loaithung;
				
				_DmhangEntity.Ngaytao = Ngaytao;
				
				_DmhangEntity.Nguoitao = Nguoitao;
				
				_DmhangEntity.Ngaysua = Ngaysua;
				
				_DmhangEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DmhangEntity, true);
			}
			return _DmhangEntity;
		}

		public bool Update(DmhangEntity _DmhangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmhangFields.Masp == _DmhangEntity.Masp);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmhangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmhangEntity _DmhangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmhangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Masp, System.String Tensp, System.String Makhach, System.String Tenkhach, System.String Kichthuoc, System.Decimal Khoiluongmuc, System.Int32 Sohinh, System.String Cautrucin, System.Int32 Somau, System.String Loaimuc, System.String Kichthuoctruc, System.String Vitri, System.String Quycachdonggoi, System.String Loaithung, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmhangEntity _DmhangEntity = new DmhangEntity(Masp);
				if (adapter.FetchEntity(_DmhangEntity))
				{
				
					
					
					_DmhangEntity.Tensp = Tensp;
					
					_DmhangEntity.Makhach = Makhach;
					
					_DmhangEntity.Tenkhach = Tenkhach;
					
					_DmhangEntity.Kichthuoc = Kichthuoc;
					
					_DmhangEntity.Khoiluongmuc = Khoiluongmuc;
					
					_DmhangEntity.Sohinh = Sohinh;
					
					_DmhangEntity.Cautrucin = Cautrucin;
					
					_DmhangEntity.Somau = Somau;
					
					_DmhangEntity.Loaimuc = Loaimuc;
					
					_DmhangEntity.Kichthuoctruc = Kichthuoctruc;
					
					_DmhangEntity.Vitri = Vitri;
					
					_DmhangEntity.Quycachdonggoi = Quycachdonggoi;
					
					_DmhangEntity.Loaithung = Loaithung;
					
					_DmhangEntity.Ngaytao = Ngaytao;
					
					_DmhangEntity.Nguoitao = Nguoitao;
					
					_DmhangEntity.Ngaysua = Ngaysua;
					
					_DmhangEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DmhangEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Masp)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmhangEntity _DmhangEntity = new DmhangEntity(Masp);
				if (adapter.FetchEntity(_DmhangEntity))
				{
					adapter.DeleteEntity(_DmhangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmhangEntity", null);
			}
		}
		
		
		
		public int DeleteByMasp(System.String Masp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensp(System.String Tensp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKichthuoc(System.String Kichthuoc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKhoiluongmuc(System.Decimal Khoiluongmuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Khoiluongmuc == Khoiluongmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySohinh(System.Int32 Sohinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Sohinh == Sohinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCautrucin(System.String Cautrucin)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Cautrucin == Cautrucin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomau(System.Int32 Somau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Somau == Somau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLoaimuc(System.String Loaimuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Loaimuc == Loaimuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKichthuoctruc(System.String Kichthuoctruc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Kichthuoctruc == Kichthuoctruc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByVitri(System.String Vitri)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Vitri == Vitri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByQuycachdonggoi(System.String Quycachdonggoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Quycachdonggoi == Quycachdonggoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLoaithung(System.String Loaithung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Loaithung == Loaithung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmhangEntity SelectOne(System.String Masp)
		{
			DmhangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmhangEntity _DmhangEntity = new DmhangEntity(Masp);
				if (adapter.FetchEntity(_DmhangEntity))
				{
					toReturn = _DmhangEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmhangCollection = new EntityCollection( new DmhangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, null, 0, null);
			}
			return _DmhangCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMasp(System.String Masp)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaspRDT(System.String Masp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensp(System.String Tensp)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenspRDT(System.String Tensp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKichthuoc(System.String Kichthuoc)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByKichthuocRDT(System.String Kichthuoc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKhoiluongmuc(System.Decimal Khoiluongmuc)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Khoiluongmuc == Khoiluongmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByKhoiluongmucRDT(System.Decimal Khoiluongmuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Khoiluongmuc == Khoiluongmuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySohinh(System.Int32 Sohinh)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Sohinh == Sohinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectBySohinhRDT(System.Int32 Sohinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Sohinh == Sohinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCautrucin(System.String Cautrucin)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Cautrucin == Cautrucin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByCautrucinRDT(System.String Cautrucin)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Cautrucin == Cautrucin);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomau(System.Int32 Somau)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Somau == Somau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectBySomauRDT(System.Int32 Somau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Somau == Somau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLoaimuc(System.String Loaimuc)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Loaimuc == Loaimuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByLoaimucRDT(System.String Loaimuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Loaimuc == Loaimuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKichthuoctruc(System.String Kichthuoctruc)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Kichthuoctruc == Kichthuoctruc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByKichthuoctrucRDT(System.String Kichthuoctruc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Kichthuoctruc == Kichthuoctruc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByVitri(System.String Vitri)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Vitri == Vitri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByVitriRDT(System.String Vitri)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Vitri == Vitri);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByQuycachdonggoi(System.String Quycachdonggoi)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Quycachdonggoi == Quycachdonggoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByQuycachdonggoiRDT(System.String Quycachdonggoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Quycachdonggoi == Quycachdonggoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLoaithung(System.String Loaithung)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Loaithung == Loaithung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByLoaithungRDT(System.String Loaithung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Loaithung == Loaithung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
