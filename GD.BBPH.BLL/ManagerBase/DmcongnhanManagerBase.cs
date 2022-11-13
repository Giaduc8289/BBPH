


/*
'===============================================================================
'  GD.BBPH.BL.DmcongnhanManagerBase
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
	public class DmcongnhanManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Macn="Macn";				
		
		public const String Field_Hovatencongnhan="Hovatencongnhan";				
		
		public const String Field_Tencongnhan="Tencongnhan";				
		
		public const String Field_Mabp="Mabp";				
		
		public const String Field_Macv="Macv";				
		
		public const String Field_Sodienthoai="Sodienthoai";				
		
		public const String Field_Tinhtrang="Tinhtrang";				
		
		public const String Field_Phongban="Phongban";				
		
		public const String Field_Chucvu="Chucvu";				
		
		public const String Field_Danghi="Danghi";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmcongnhanManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Macn,typeof(System.String));
			
			dt.Columns.Add(Field_Hovatencongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_Tencongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_Mabp,typeof(System.String));
			
			dt.Columns.Add(Field_Macv,typeof(System.String));
			
			dt.Columns.Add(Field_Sodienthoai,typeof(System.String));
			
			dt.Columns.Add(Field_Tinhtrang,typeof(System.String));
			
			dt.Columns.Add(Field_Phongban,typeof(System.String));
			
			dt.Columns.Add(Field_Chucvu,typeof(System.String));
			
			dt.Columns.Add(Field_Danghi,typeof(System.Boolean));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmcongnhanEntity _DmcongnhanEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Macn]=_DmcongnhanEntity.Macn;
			}
			catch { }
			
			try
			{
				r[Field_Hovatencongnhan]=_DmcongnhanEntity.Hovatencongnhan;
			}
			catch { }
			
			try
			{
				r[Field_Tencongnhan]=_DmcongnhanEntity.Tencongnhan;
			}
			catch { }
			
			try
			{
				r[Field_Mabp]=_DmcongnhanEntity.Mabp;
			}
			catch { }
			
			try
			{
				r[Field_Macv]=_DmcongnhanEntity.Macv;
			}
			catch { }
			
			try
			{
				r[Field_Sodienthoai]=_DmcongnhanEntity.Sodienthoai;
			}
			catch { }
			
			try
			{
				r[Field_Tinhtrang]=_DmcongnhanEntity.Tinhtrang;
			}
			catch { }
			
			try
			{
				r[Field_Phongban]=_DmcongnhanEntity.Phongban;
			}
			catch { }
			
			try
			{
				r[Field_Chucvu]=_DmcongnhanEntity.Chucvu;
			}
			catch { }
			
			try
			{
				r[Field_Danghi]=_DmcongnhanEntity.Danghi;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmcongnhanEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmcongnhanEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmcongnhanEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmcongnhanEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmcongnhanEntity Convert(DataRow r)
		{	
			
			DmcongnhanEntity _DmcongnhanEntity=new DmcongnhanEntity(r[Field_Macn].ToString());					
						
			
			
			try
			{
				_DmcongnhanEntity.Hovatencongnhan= r[Field_Hovatencongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_DmcongnhanEntity.Tencongnhan= r[Field_Tencongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_DmcongnhanEntity.Mabp= r[Field_Mabp].ToString();						
			}
			catch { }
			
			try
			{
				_DmcongnhanEntity.Macv= r[Field_Macv].ToString();						
			}
			catch { }
			
			try
			{
				_DmcongnhanEntity.Sodienthoai= r[Field_Sodienthoai].ToString();						
			}
			catch { }
			
			try
			{
				_DmcongnhanEntity.Tinhtrang= r[Field_Tinhtrang].ToString();						
			}
			catch { }
			
			try
			{
				_DmcongnhanEntity.Phongban= r[Field_Phongban].ToString();						
			}
			catch { }
			
			try
			{
				_DmcongnhanEntity.Chucvu= r[Field_Chucvu].ToString();						
			}
			catch { }
			
			try
			{
				_DmcongnhanEntity.Danghi= System.Boolean.Parse(r[Field_Danghi].ToString());						
			}
			catch { }
			
			try
			{
				_DmcongnhanEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmcongnhanEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmcongnhanEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmcongnhanEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DmcongnhanEntity;
		}			
		
		public DmcongnhanEntity Convert_Entity(DmcongnhanEntity _DmcongnhanEntity,DmcongnhanEntity _DmcongnhanEntity_XML)
		{	
			
			
			_DmcongnhanEntity.Macn= _DmcongnhanEntity_XML.Macn;
			
			_DmcongnhanEntity.Hovatencongnhan= _DmcongnhanEntity_XML.Hovatencongnhan;
			
			_DmcongnhanEntity.Tencongnhan= _DmcongnhanEntity_XML.Tencongnhan;
			
			_DmcongnhanEntity.Mabp= _DmcongnhanEntity_XML.Mabp;
			
			_DmcongnhanEntity.Macv= _DmcongnhanEntity_XML.Macv;
			
			_DmcongnhanEntity.Sodienthoai= _DmcongnhanEntity_XML.Sodienthoai;
			
			_DmcongnhanEntity.Tinhtrang= _DmcongnhanEntity_XML.Tinhtrang;
			
			_DmcongnhanEntity.Phongban= _DmcongnhanEntity_XML.Phongban;
			
			_DmcongnhanEntity.Chucvu= _DmcongnhanEntity_XML.Chucvu;
			
			_DmcongnhanEntity.Danghi= _DmcongnhanEntity_XML.Danghi;
			
			_DmcongnhanEntity.Ngaytao= _DmcongnhanEntity_XML.Ngaytao;
			
			_DmcongnhanEntity.Nguoitao= _DmcongnhanEntity_XML.Nguoitao;
			
			_DmcongnhanEntity.Ngaysua= _DmcongnhanEntity_XML.Ngaysua;
			
			_DmcongnhanEntity.Nguoisua= _DmcongnhanEntity_XML.Nguoisua;
									
				
			return _DmcongnhanEntity;
		}	
		
		public String InsertV2(DmcongnhanEntity _DmcongnhanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmcongnhanManagerBase()).Insert(_DmcongnhanEntity).Macn.ToString();
			
			
			try
			{
				r.SetField(Field_Macn,_DmcongnhanEntity.Macn);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Hovatencongnhan,_DmcongnhanEntity.Hovatencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_DmcongnhanEntity.Tencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mabp,_DmcongnhanEntity.Mabp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macv,_DmcongnhanEntity.Macv);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sodienthoai,_DmcongnhanEntity.Sodienthoai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tinhtrang,_DmcongnhanEntity.Tinhtrang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phongban,_DmcongnhanEntity.Phongban);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chucvu,_DmcongnhanEntity.Chucvu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Danghi,_DmcongnhanEntity.Danghi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmcongnhanEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmcongnhanEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmcongnhanEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmcongnhanEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmcongnhanEntity _DmcongnhanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmcongnhanManagerBase()).Update(_DmcongnhanEntity);
			r.SetField(Field_Macn,_DmcongnhanEntity.Macn);
									
			
			
			
			try
			{
				r.SetField(Field_Hovatencongnhan,_DmcongnhanEntity.Hovatencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_DmcongnhanEntity.Tencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mabp,_DmcongnhanEntity.Mabp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macv,_DmcongnhanEntity.Macv);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sodienthoai,_DmcongnhanEntity.Sodienthoai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tinhtrang,_DmcongnhanEntity.Tinhtrang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phongban,_DmcongnhanEntity.Phongban);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chucvu,_DmcongnhanEntity.Chucvu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Danghi,_DmcongnhanEntity.Danghi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmcongnhanEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmcongnhanEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmcongnhanEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmcongnhanEntity.Nguoisua);
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

		public DmcongnhanEntity Insert(DmcongnhanEntity DmcongnhanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmcongnhanEntity, true);
			}
			return DmcongnhanEntity;
		}

		public DmcongnhanEntity Insert(System.String  Macn, System.String  Hovatencongnhan, System.String  Tencongnhan, System.String  Mabp, System.String  Macv, System.String  Sodienthoai, System.String  Tinhtrang, System.String  Phongban, System.String  Chucvu, System.Boolean  Danghi, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DmcongnhanEntity _DmcongnhanEntity = new DmcongnhanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmcongnhanEntity.Macn = Macn;
				
				_DmcongnhanEntity.Hovatencongnhan = Hovatencongnhan;
				
				_DmcongnhanEntity.Tencongnhan = Tencongnhan;
				
				_DmcongnhanEntity.Mabp = Mabp;
				
				_DmcongnhanEntity.Macv = Macv;
				
				_DmcongnhanEntity.Sodienthoai = Sodienthoai;
				
				_DmcongnhanEntity.Tinhtrang = Tinhtrang;
				
				_DmcongnhanEntity.Phongban = Phongban;
				
				_DmcongnhanEntity.Chucvu = Chucvu;
				
				_DmcongnhanEntity.Danghi = Danghi;
				
				_DmcongnhanEntity.Ngaytao = Ngaytao;
				
				_DmcongnhanEntity.Nguoitao = Nguoitao;
				
				_DmcongnhanEntity.Ngaysua = Ngaysua;
				
				_DmcongnhanEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DmcongnhanEntity, true);
			}
			return _DmcongnhanEntity;
		}

		public DmcongnhanEntity Insert(System.String Hovatencongnhan, System.String Tencongnhan, System.String Mabp, System.String Macv, System.String Sodienthoai, System.String Tinhtrang, System.String Phongban, System.String Chucvu, System.Boolean Danghi, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DmcongnhanEntity _DmcongnhanEntity = new DmcongnhanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmcongnhanEntity.Hovatencongnhan = Hovatencongnhan;
				
				_DmcongnhanEntity.Tencongnhan = Tencongnhan;
				
				_DmcongnhanEntity.Mabp = Mabp;
				
				_DmcongnhanEntity.Macv = Macv;
				
				_DmcongnhanEntity.Sodienthoai = Sodienthoai;
				
				_DmcongnhanEntity.Tinhtrang = Tinhtrang;
				
				_DmcongnhanEntity.Phongban = Phongban;
				
				_DmcongnhanEntity.Chucvu = Chucvu;
				
				_DmcongnhanEntity.Danghi = Danghi;
				
				_DmcongnhanEntity.Ngaytao = Ngaytao;
				
				_DmcongnhanEntity.Nguoitao = Nguoitao;
				
				_DmcongnhanEntity.Ngaysua = Ngaysua;
				
				_DmcongnhanEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DmcongnhanEntity, true);
			}
			return _DmcongnhanEntity;
		}

		public bool Update(DmcongnhanEntity _DmcongnhanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmcongnhanFields.Macn == _DmcongnhanEntity.Macn);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmcongnhanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmcongnhanEntity _DmcongnhanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmcongnhanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Macn, System.String Hovatencongnhan, System.String Tencongnhan, System.String Mabp, System.String Macv, System.String Sodienthoai, System.String Tinhtrang, System.String Phongban, System.String Chucvu, System.Boolean Danghi, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmcongnhanEntity _DmcongnhanEntity = new DmcongnhanEntity(Macn);
				if (adapter.FetchEntity(_DmcongnhanEntity))
				{
				
					
					
					_DmcongnhanEntity.Hovatencongnhan = Hovatencongnhan;
					
					_DmcongnhanEntity.Tencongnhan = Tencongnhan;
					
					_DmcongnhanEntity.Mabp = Mabp;
					
					_DmcongnhanEntity.Macv = Macv;
					
					_DmcongnhanEntity.Sodienthoai = Sodienthoai;
					
					_DmcongnhanEntity.Tinhtrang = Tinhtrang;
					
					_DmcongnhanEntity.Phongban = Phongban;
					
					_DmcongnhanEntity.Chucvu = Chucvu;
					
					_DmcongnhanEntity.Danghi = Danghi;
					
					_DmcongnhanEntity.Ngaytao = Ngaytao;
					
					_DmcongnhanEntity.Nguoitao = Nguoitao;
					
					_DmcongnhanEntity.Ngaysua = Ngaysua;
					
					_DmcongnhanEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DmcongnhanEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Macn)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmcongnhanEntity _DmcongnhanEntity = new DmcongnhanEntity(Macn);
				if (adapter.FetchEntity(_DmcongnhanEntity))
				{
					adapter.DeleteEntity(_DmcongnhanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmcongnhanEntity", null);
			}
		}
		
		
		
		public int DeleteByMacn(System.String Macn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Macn == Macn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongnhanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByHovatencongnhan(System.String Hovatencongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Hovatencongnhan == Hovatencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongnhanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTencongnhan(System.String Tencongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongnhanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMabp(System.String Mabp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Mabp == Mabp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongnhanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacv(System.String Macv)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Macv == Macv);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongnhanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySodienthoai(System.String Sodienthoai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Sodienthoai == Sodienthoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongnhanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTinhtrang(System.String Tinhtrang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Tinhtrang == Tinhtrang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongnhanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhongban(System.String Phongban)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Phongban == Phongban);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongnhanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByChucvu(System.String Chucvu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Chucvu == Chucvu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongnhanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDanghi(System.Boolean Danghi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Danghi == Danghi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongnhanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongnhanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongnhanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongnhanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmcongnhanEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmcongnhanEntity SelectOne(System.String Macn)
		{
			DmcongnhanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmcongnhanEntity _DmcongnhanEntity = new DmcongnhanEntity(Macn);
				if (adapter.FetchEntity(_DmcongnhanEntity))
				{
					toReturn = _DmcongnhanEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmcongnhanCollection = new EntityCollection( new DmcongnhanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongnhanCollection, null, 0, null);
			}
			return _DmcongnhanCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMacn(System.String Macn)
		{
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Macn == Macn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongnhanCollection, filter, 0, null);
			}
			return _DmcongnhanCollection;
		}
		// Return DataTable
		public DataTable SelectByMacnRDT(System.String Macn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Macn == Macn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByHovatencongnhan(System.String Hovatencongnhan)
		{
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Hovatencongnhan == Hovatencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongnhanCollection, filter, 0, null);
			}
			return _DmcongnhanCollection;
		}
		// Return DataTable
		public DataTable SelectByHovatencongnhanRDT(System.String Hovatencongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Hovatencongnhan == Hovatencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTencongnhan(System.String Tencongnhan)
		{
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongnhanCollection, filter, 0, null);
			}
			return _DmcongnhanCollection;
		}
		// Return DataTable
		public DataTable SelectByTencongnhanRDT(System.String Tencongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMabp(System.String Mabp)
		{
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Mabp == Mabp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongnhanCollection, filter, 0, null);
			}
			return _DmcongnhanCollection;
		}
		// Return DataTable
		public DataTable SelectByMabpRDT(System.String Mabp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Mabp == Mabp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacv(System.String Macv)
		{
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Macv == Macv);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongnhanCollection, filter, 0, null);
			}
			return _DmcongnhanCollection;
		}
		// Return DataTable
		public DataTable SelectByMacvRDT(System.String Macv)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Macv == Macv);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySodienthoai(System.String Sodienthoai)
		{
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Sodienthoai == Sodienthoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongnhanCollection, filter, 0, null);
			}
			return _DmcongnhanCollection;
		}
		// Return DataTable
		public DataTable SelectBySodienthoaiRDT(System.String Sodienthoai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Sodienthoai == Sodienthoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTinhtrang(System.String Tinhtrang)
		{
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Tinhtrang == Tinhtrang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongnhanCollection, filter, 0, null);
			}
			return _DmcongnhanCollection;
		}
		// Return DataTable
		public DataTable SelectByTinhtrangRDT(System.String Tinhtrang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Tinhtrang == Tinhtrang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhongban(System.String Phongban)
		{
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Phongban == Phongban);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongnhanCollection, filter, 0, null);
			}
			return _DmcongnhanCollection;
		}
		// Return DataTable
		public DataTable SelectByPhongbanRDT(System.String Phongban)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Phongban == Phongban);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByChucvu(System.String Chucvu)
		{
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Chucvu == Chucvu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongnhanCollection, filter, 0, null);
			}
			return _DmcongnhanCollection;
		}
		// Return DataTable
		public DataTable SelectByChucvuRDT(System.String Chucvu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Chucvu == Chucvu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDanghi(System.Boolean Danghi)
		{
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Danghi == Danghi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongnhanCollection, filter, 0, null);
			}
			return _DmcongnhanCollection;
		}
		// Return DataTable
		public DataTable SelectByDanghiRDT(System.Boolean Danghi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Danghi == Danghi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongnhanCollection, filter, 0, null);
			}
			return _DmcongnhanCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongnhanCollection, filter, 0, null);
			}
			return _DmcongnhanCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongnhanCollection, filter, 0, null);
			}
			return _DmcongnhanCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmcongnhanCollection, filter, 0, null);
			}
			return _DmcongnhanCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmcongnhanCollection = new EntityCollection(new DmcongnhanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmcongnhanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmcongnhanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(DmcongnhanFields.Macn.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
