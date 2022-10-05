


/*
'===============================================================================
'  GD.BBPH.BL.DmtaikhoanManagerBase
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
	public class DmtaikhoanManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Matk="Matk";				
		
		public const String Field_Tentk="Tentk";				
		
		public const String Field_Bactk="Bactk";				
		
		public const String Field_Tinhchattk="Tinhchattk";				
		
		public const String Field_Matkcha="Matkcha";				
		
		public const String Field_Trongbang="Trongbang";				
		
		public const String Field_Doituongtd="Doituongtd";				
		
		public const String Field_Khoanmuctd="Khoanmuctd";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmtaikhoanManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Matk,typeof(System.String));
			
			dt.Columns.Add(Field_Tentk,typeof(System.String));
			
			dt.Columns.Add(Field_Bactk,typeof(System.String));
			
			dt.Columns.Add(Field_Tinhchattk,typeof(System.String));
			
			dt.Columns.Add(Field_Matkcha,typeof(System.String));
			
			dt.Columns.Add(Field_Trongbang,typeof(System.Boolean));
			
			dt.Columns.Add(Field_Doituongtd,typeof(System.String));
			
			dt.Columns.Add(Field_Khoanmuctd,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmtaikhoanEntity _DmtaikhoanEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Matk]=_DmtaikhoanEntity.Matk;
			}
			catch { }
			
			try
			{
				r[Field_Tentk]=_DmtaikhoanEntity.Tentk;
			}
			catch { }
			
			try
			{
				r[Field_Bactk]=_DmtaikhoanEntity.Bactk;
			}
			catch { }
			
			try
			{
				r[Field_Tinhchattk]=_DmtaikhoanEntity.Tinhchattk;
			}
			catch { }
			
			try
			{
				r[Field_Matkcha]=_DmtaikhoanEntity.Matkcha;
			}
			catch { }
			
			try
			{
				r[Field_Trongbang]=_DmtaikhoanEntity.Trongbang;
			}
			catch { }
			
			try
			{
				r[Field_Doituongtd]=_DmtaikhoanEntity.Doituongtd;
			}
			catch { }
			
			try
			{
				r[Field_Khoanmuctd]=_DmtaikhoanEntity.Khoanmuctd;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmtaikhoanEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmtaikhoanEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmtaikhoanEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmtaikhoanEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmtaikhoanEntity Convert(DataRow r)
		{	
			
			DmtaikhoanEntity _DmtaikhoanEntity=new DmtaikhoanEntity(r[Field_Matk].ToString());					
						
			
			
			try
			{
				_DmtaikhoanEntity.Tentk= r[Field_Tentk].ToString();						
			}
			catch { }
			
			try
			{
				_DmtaikhoanEntity.Bactk= r[Field_Bactk].ToString();						
			}
			catch { }
			
			try
			{
				_DmtaikhoanEntity.Tinhchattk= r[Field_Tinhchattk].ToString();						
			}
			catch { }
			
			try
			{
				_DmtaikhoanEntity.Matkcha= r[Field_Matkcha].ToString();						
			}
			catch { }
			
			try
			{
				_DmtaikhoanEntity.Trongbang= System.Boolean.Parse(r[Field_Trongbang].ToString());						
			}
			catch { }
			
			try
			{
				_DmtaikhoanEntity.Doituongtd= r[Field_Doituongtd].ToString();						
			}
			catch { }
			
			try
			{
				_DmtaikhoanEntity.Khoanmuctd= r[Field_Khoanmuctd].ToString();						
			}
			catch { }
			
			try
			{
				_DmtaikhoanEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmtaikhoanEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmtaikhoanEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmtaikhoanEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DmtaikhoanEntity;
		}			
		
		public DmtaikhoanEntity Convert_Entity(DmtaikhoanEntity _DmtaikhoanEntity,DmtaikhoanEntity _DmtaikhoanEntity_XML)
		{	
			
			
			_DmtaikhoanEntity.Matk= _DmtaikhoanEntity_XML.Matk;
			
			_DmtaikhoanEntity.Tentk= _DmtaikhoanEntity_XML.Tentk;
			
			_DmtaikhoanEntity.Bactk= _DmtaikhoanEntity_XML.Bactk;
			
			_DmtaikhoanEntity.Tinhchattk= _DmtaikhoanEntity_XML.Tinhchattk;
			
			_DmtaikhoanEntity.Matkcha= _DmtaikhoanEntity_XML.Matkcha;
			
			_DmtaikhoanEntity.Trongbang= _DmtaikhoanEntity_XML.Trongbang;
			
			_DmtaikhoanEntity.Doituongtd= _DmtaikhoanEntity_XML.Doituongtd;
			
			_DmtaikhoanEntity.Khoanmuctd= _DmtaikhoanEntity_XML.Khoanmuctd;
			
			_DmtaikhoanEntity.Ngaytao= _DmtaikhoanEntity_XML.Ngaytao;
			
			_DmtaikhoanEntity.Nguoitao= _DmtaikhoanEntity_XML.Nguoitao;
			
			_DmtaikhoanEntity.Ngaysua= _DmtaikhoanEntity_XML.Ngaysua;
			
			_DmtaikhoanEntity.Nguoisua= _DmtaikhoanEntity_XML.Nguoisua;
									
				
			return _DmtaikhoanEntity;
		}	
		
		public String InsertV2(DmtaikhoanEntity _DmtaikhoanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmtaikhoanManagerBase()).Insert(_DmtaikhoanEntity).Matk.ToString();
			
			
			try
			{
				r.SetField(Field_Matk,_DmtaikhoanEntity.Matk);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tentk,_DmtaikhoanEntity.Tentk);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Bactk,_DmtaikhoanEntity.Bactk);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tinhchattk,_DmtaikhoanEntity.Tinhchattk);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Matkcha,_DmtaikhoanEntity.Matkcha);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trongbang,_DmtaikhoanEntity.Trongbang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Doituongtd,_DmtaikhoanEntity.Doituongtd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khoanmuctd,_DmtaikhoanEntity.Khoanmuctd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmtaikhoanEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmtaikhoanEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmtaikhoanEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmtaikhoanEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmtaikhoanEntity _DmtaikhoanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmtaikhoanManagerBase()).Update(_DmtaikhoanEntity);
			r.SetField(Field_Matk,_DmtaikhoanEntity.Matk);
									
			
			
			
			try
			{
				r.SetField(Field_Tentk,_DmtaikhoanEntity.Tentk);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Bactk,_DmtaikhoanEntity.Bactk);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tinhchattk,_DmtaikhoanEntity.Tinhchattk);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Matkcha,_DmtaikhoanEntity.Matkcha);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trongbang,_DmtaikhoanEntity.Trongbang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Doituongtd,_DmtaikhoanEntity.Doituongtd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khoanmuctd,_DmtaikhoanEntity.Khoanmuctd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmtaikhoanEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmtaikhoanEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmtaikhoanEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmtaikhoanEntity.Nguoisua);
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

		public DmtaikhoanEntity Insert(DmtaikhoanEntity DmtaikhoanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmtaikhoanEntity, true);
			}
			return DmtaikhoanEntity;
		}

		public DmtaikhoanEntity Insert(System.String  Matk, System.String  Tentk, System.String  Bactk, System.String  Tinhchattk, System.String  Matkcha, System.Boolean  Trongbang, System.String  Doituongtd, System.String  Khoanmuctd, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DmtaikhoanEntity _DmtaikhoanEntity = new DmtaikhoanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmtaikhoanEntity.Matk = Matk;
				
				_DmtaikhoanEntity.Tentk = Tentk;
				
				_DmtaikhoanEntity.Bactk = Bactk;
				
				_DmtaikhoanEntity.Tinhchattk = Tinhchattk;
				
				_DmtaikhoanEntity.Matkcha = Matkcha;
				
				_DmtaikhoanEntity.Trongbang = Trongbang;
				
				_DmtaikhoanEntity.Doituongtd = Doituongtd;
				
				_DmtaikhoanEntity.Khoanmuctd = Khoanmuctd;
				
				_DmtaikhoanEntity.Ngaytao = Ngaytao;
				
				_DmtaikhoanEntity.Nguoitao = Nguoitao;
				
				_DmtaikhoanEntity.Ngaysua = Ngaysua;
				
				_DmtaikhoanEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DmtaikhoanEntity, true);
			}
			return _DmtaikhoanEntity;
		}

		public DmtaikhoanEntity Insert(System.String Tentk, System.String Bactk, System.String Tinhchattk, System.String Matkcha, System.Boolean Trongbang, System.String Doituongtd, System.String Khoanmuctd, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DmtaikhoanEntity _DmtaikhoanEntity = new DmtaikhoanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmtaikhoanEntity.Tentk = Tentk;
				
				_DmtaikhoanEntity.Bactk = Bactk;
				
				_DmtaikhoanEntity.Tinhchattk = Tinhchattk;
				
				_DmtaikhoanEntity.Matkcha = Matkcha;
				
				_DmtaikhoanEntity.Trongbang = Trongbang;
				
				_DmtaikhoanEntity.Doituongtd = Doituongtd;
				
				_DmtaikhoanEntity.Khoanmuctd = Khoanmuctd;
				
				_DmtaikhoanEntity.Ngaytao = Ngaytao;
				
				_DmtaikhoanEntity.Nguoitao = Nguoitao;
				
				_DmtaikhoanEntity.Ngaysua = Ngaysua;
				
				_DmtaikhoanEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DmtaikhoanEntity, true);
			}
			return _DmtaikhoanEntity;
		}

		public bool Update(DmtaikhoanEntity _DmtaikhoanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmtaikhoanFields.Matk == _DmtaikhoanEntity.Matk);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmtaikhoanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmtaikhoanEntity _DmtaikhoanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmtaikhoanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Matk, System.String Tentk, System.String Bactk, System.String Tinhchattk, System.String Matkcha, System.Boolean Trongbang, System.String Doituongtd, System.String Khoanmuctd, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmtaikhoanEntity _DmtaikhoanEntity = new DmtaikhoanEntity(Matk);
				if (adapter.FetchEntity(_DmtaikhoanEntity))
				{
				
					
					
					_DmtaikhoanEntity.Tentk = Tentk;
					
					_DmtaikhoanEntity.Bactk = Bactk;
					
					_DmtaikhoanEntity.Tinhchattk = Tinhchattk;
					
					_DmtaikhoanEntity.Matkcha = Matkcha;
					
					_DmtaikhoanEntity.Trongbang = Trongbang;
					
					_DmtaikhoanEntity.Doituongtd = Doituongtd;
					
					_DmtaikhoanEntity.Khoanmuctd = Khoanmuctd;
					
					_DmtaikhoanEntity.Ngaytao = Ngaytao;
					
					_DmtaikhoanEntity.Nguoitao = Nguoitao;
					
					_DmtaikhoanEntity.Ngaysua = Ngaysua;
					
					_DmtaikhoanEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DmtaikhoanEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Matk)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmtaikhoanEntity _DmtaikhoanEntity = new DmtaikhoanEntity(Matk);
				if (adapter.FetchEntity(_DmtaikhoanEntity))
				{
					adapter.DeleteEntity(_DmtaikhoanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", null);
			}
		}
		
		
		
		public int DeleteByMatk(System.String Matk)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Matk == Matk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTentk(System.String Tentk)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Tentk == Tentk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByBactk(System.String Bactk)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Bactk == Bactk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTinhchattk(System.String Tinhchattk)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Tinhchattk == Tinhchattk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMatkcha(System.String Matkcha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Matkcha == Matkcha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTrongbang(System.Boolean Trongbang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Trongbang == Trongbang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDoituongtd(System.String Doituongtd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Doituongtd == Doituongtd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKhoanmuctd(System.String Khoanmuctd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Khoanmuctd == Khoanmuctd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmtaikhoanEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmtaikhoanEntity SelectOne(System.String Matk)
		{
			DmtaikhoanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmtaikhoanEntity _DmtaikhoanEntity = new DmtaikhoanEntity(Matk);
				if (adapter.FetchEntity(_DmtaikhoanEntity))
				{
					toReturn = _DmtaikhoanEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection( new DmtaikhoanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, null, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMatk(System.String Matk)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Matk == Matk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByMatkRDT(System.String Matk)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Matk == Matk);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTentk(System.String Tentk)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Tentk == Tentk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByTentkRDT(System.String Tentk)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Tentk == Tentk);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByBactk(System.String Bactk)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Bactk == Bactk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByBactkRDT(System.String Bactk)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Bactk == Bactk);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTinhchattk(System.String Tinhchattk)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Tinhchattk == Tinhchattk);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByTinhchattkRDT(System.String Tinhchattk)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Tinhchattk == Tinhchattk);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMatkcha(System.String Matkcha)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Matkcha == Matkcha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByMatkchaRDT(System.String Matkcha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Matkcha == Matkcha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTrongbang(System.Boolean Trongbang)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Trongbang == Trongbang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByTrongbangRDT(System.Boolean Trongbang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Trongbang == Trongbang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDoituongtd(System.String Doituongtd)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Doituongtd == Doituongtd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByDoituongtdRDT(System.String Doituongtd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Doituongtd == Doituongtd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKhoanmuctd(System.String Khoanmuctd)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Khoanmuctd == Khoanmuctd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByKhoanmuctdRDT(System.String Khoanmuctd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Khoanmuctd == Khoanmuctd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmtaikhoanCollection, filter, 0, null);
			}
			return _DmtaikhoanCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmtaikhoanCollection = new EntityCollection(new DmtaikhoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmtaikhoanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmtaikhoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
