


/*
'===============================================================================
'  GD.BBPH.BL.PhieugiaohangHManagerBase
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
	public class PhieugiaohangHManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Sophieu="Sophieu";				
		
		public const String Field_Ngaygiao="Ngaygiao";				
		
		public const String Field_Madon="Madon";				
		
		public const String Field_Ngaydat="Ngaydat";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Tongtien="Tongtien";				
		
		public const String Field_Vat="Vat";				
		
		public const String Field_Ghichu="Ghichu";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhieugiaohangHManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Sophieu,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaygiao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Madon,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaydat,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tongtien,typeof(System.Int32));
			
			dt.Columns.Add(Field_Vat,typeof(System.Int32));
			
			dt.Columns.Add(Field_Ghichu,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(PhieugiaohangHEntity _PhieugiaohangHEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Sophieu]=_PhieugiaohangHEntity.Sophieu;
			}
			catch { }
			
			try
			{
				r[Field_Ngaygiao]=_PhieugiaohangHEntity.Ngaygiao;
			}
			catch { }
			
			try
			{
				r[Field_Madon]=_PhieugiaohangHEntity.Madon;
			}
			catch { }
			
			try
			{
				r[Field_Ngaydat]=_PhieugiaohangHEntity.Ngaydat;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_PhieugiaohangHEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_PhieugiaohangHEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Tongtien]=_PhieugiaohangHEntity.Tongtien;
			}
			catch { }
			
			try
			{
				r[Field_Vat]=_PhieugiaohangHEntity.Vat;
			}
			catch { }
			
			try
			{
				r[Field_Ghichu]=_PhieugiaohangHEntity.Ghichu;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_PhieugiaohangHEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_PhieugiaohangHEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_PhieugiaohangHEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_PhieugiaohangHEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public PhieugiaohangHEntity Convert(DataRow r)
		{	
			
			PhieugiaohangHEntity _PhieugiaohangHEntity=new PhieugiaohangHEntity(r[Field_Sophieu].ToString());					
						
			
			
			try
			{
				_PhieugiaohangHEntity.Ngaygiao= System.DateTime.Parse(r[Field_Ngaygiao].ToString());						
			}
			catch { }
			
			try
			{
				_PhieugiaohangHEntity.Madon= r[Field_Madon].ToString();						
			}
			catch { }
			
			try
			{
				_PhieugiaohangHEntity.Ngaydat= System.DateTime.Parse(r[Field_Ngaydat].ToString());						
			}
			catch { }
			
			try
			{
				_PhieugiaohangHEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_PhieugiaohangHEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_PhieugiaohangHEntity.Tongtien= System.Int32.Parse(r[Field_Tongtien].ToString());						
			}
			catch { }
			
			try
			{
				_PhieugiaohangHEntity.Vat= System.Int32.Parse(r[Field_Vat].ToString());						
			}
			catch { }
			
			try
			{
				_PhieugiaohangHEntity.Ghichu= r[Field_Ghichu].ToString();						
			}
			catch { }
			
			try
			{
				_PhieugiaohangHEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_PhieugiaohangHEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_PhieugiaohangHEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_PhieugiaohangHEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _PhieugiaohangHEntity;
		}			
		
		public PhieugiaohangHEntity Convert_Entity(PhieugiaohangHEntity _PhieugiaohangHEntity,PhieugiaohangHEntity _PhieugiaohangHEntity_XML)
		{	
			
			
			_PhieugiaohangHEntity.Sophieu= _PhieugiaohangHEntity_XML.Sophieu;
			
			_PhieugiaohangHEntity.Ngaygiao= _PhieugiaohangHEntity_XML.Ngaygiao;
			
			_PhieugiaohangHEntity.Madon= _PhieugiaohangHEntity_XML.Madon;
			
			_PhieugiaohangHEntity.Ngaydat= _PhieugiaohangHEntity_XML.Ngaydat;
			
			_PhieugiaohangHEntity.Makhach= _PhieugiaohangHEntity_XML.Makhach;
			
			_PhieugiaohangHEntity.Tenkhach= _PhieugiaohangHEntity_XML.Tenkhach;
			
			_PhieugiaohangHEntity.Tongtien= _PhieugiaohangHEntity_XML.Tongtien;
			
			_PhieugiaohangHEntity.Vat= _PhieugiaohangHEntity_XML.Vat;
			
			_PhieugiaohangHEntity.Ghichu= _PhieugiaohangHEntity_XML.Ghichu;
			
			_PhieugiaohangHEntity.Ngaytao= _PhieugiaohangHEntity_XML.Ngaytao;
			
			_PhieugiaohangHEntity.Nguoitao= _PhieugiaohangHEntity_XML.Nguoitao;
			
			_PhieugiaohangHEntity.Ngaysua= _PhieugiaohangHEntity_XML.Ngaysua;
			
			_PhieugiaohangHEntity.Nguoisua= _PhieugiaohangHEntity_XML.Nguoisua;
									
				
			return _PhieugiaohangHEntity;
		}	
		
		public String InsertV2(PhieugiaohangHEntity _PhieugiaohangHEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new PhieugiaohangHManagerBase()).Insert(_PhieugiaohangHEntity).Sophieu.ToString();
			
			
			try
			{
				r.SetField(Field_Sophieu,_PhieugiaohangHEntity.Sophieu);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngaygiao,_PhieugiaohangHEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madon,_PhieugiaohangHEntity.Madon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_PhieugiaohangHEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_PhieugiaohangHEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_PhieugiaohangHEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tongtien,_PhieugiaohangHEntity.Tongtien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Vat,_PhieugiaohangHEntity.Vat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ghichu,_PhieugiaohangHEntity.Ghichu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_PhieugiaohangHEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_PhieugiaohangHEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_PhieugiaohangHEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_PhieugiaohangHEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(PhieugiaohangHEntity _PhieugiaohangHEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new PhieugiaohangHManagerBase()).Update(_PhieugiaohangHEntity);
			r.SetField(Field_Sophieu,_PhieugiaohangHEntity.Sophieu);
									
			
			
			
			try
			{
				r.SetField(Field_Ngaygiao,_PhieugiaohangHEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madon,_PhieugiaohangHEntity.Madon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_PhieugiaohangHEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_PhieugiaohangHEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_PhieugiaohangHEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tongtien,_PhieugiaohangHEntity.Tongtien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Vat,_PhieugiaohangHEntity.Vat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ghichu,_PhieugiaohangHEntity.Ghichu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_PhieugiaohangHEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_PhieugiaohangHEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_PhieugiaohangHEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_PhieugiaohangHEntity.Nguoisua);
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

		public PhieugiaohangHEntity Insert(PhieugiaohangHEntity PhieugiaohangHEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(PhieugiaohangHEntity, true);
			}
			return PhieugiaohangHEntity;
		}

		public PhieugiaohangHEntity Insert(System.String  Sophieu, System.DateTime  Ngaygiao, System.String  Madon, System.DateTime  Ngaydat, System.String  Makhach, System.String  Tenkhach, System.Int32  Tongtien, System.Int32  Vat, System.String  Ghichu, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			PhieugiaohangHEntity _PhieugiaohangHEntity = new PhieugiaohangHEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PhieugiaohangHEntity.Sophieu = Sophieu;
				
				_PhieugiaohangHEntity.Ngaygiao = Ngaygiao;
				
				_PhieugiaohangHEntity.Madon = Madon;
				
				_PhieugiaohangHEntity.Ngaydat = Ngaydat;
				
				_PhieugiaohangHEntity.Makhach = Makhach;
				
				_PhieugiaohangHEntity.Tenkhach = Tenkhach;
				
				_PhieugiaohangHEntity.Tongtien = Tongtien;
				
				_PhieugiaohangHEntity.Vat = Vat;
				
				_PhieugiaohangHEntity.Ghichu = Ghichu;
				
				_PhieugiaohangHEntity.Ngaytao = Ngaytao;
				
				_PhieugiaohangHEntity.Nguoitao = Nguoitao;
				
				_PhieugiaohangHEntity.Ngaysua = Ngaysua;
				
				_PhieugiaohangHEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_PhieugiaohangHEntity, true);
			}
			return _PhieugiaohangHEntity;
		}

		public PhieugiaohangHEntity Insert(System.DateTime Ngaygiao, System.String Madon, System.DateTime Ngaydat, System.String Makhach, System.String Tenkhach, System.Int32 Tongtien, System.Int32 Vat, System.String Ghichu, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			PhieugiaohangHEntity _PhieugiaohangHEntity = new PhieugiaohangHEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_PhieugiaohangHEntity.Ngaygiao = Ngaygiao;
				
				_PhieugiaohangHEntity.Madon = Madon;
				
				_PhieugiaohangHEntity.Ngaydat = Ngaydat;
				
				_PhieugiaohangHEntity.Makhach = Makhach;
				
				_PhieugiaohangHEntity.Tenkhach = Tenkhach;
				
				_PhieugiaohangHEntity.Tongtien = Tongtien;
				
				_PhieugiaohangHEntity.Vat = Vat;
				
				_PhieugiaohangHEntity.Ghichu = Ghichu;
				
				_PhieugiaohangHEntity.Ngaytao = Ngaytao;
				
				_PhieugiaohangHEntity.Nguoitao = Nguoitao;
				
				_PhieugiaohangHEntity.Ngaysua = Ngaysua;
				
				_PhieugiaohangHEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_PhieugiaohangHEntity, true);
			}
			return _PhieugiaohangHEntity;
		}

		public bool Update(PhieugiaohangHEntity _PhieugiaohangHEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(PhieugiaohangHFields.Sophieu == _PhieugiaohangHEntity.Sophieu);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_PhieugiaohangHEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(PhieugiaohangHEntity _PhieugiaohangHEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_PhieugiaohangHEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Sophieu, System.DateTime Ngaygiao, System.String Madon, System.DateTime Ngaydat, System.String Makhach, System.String Tenkhach, System.Int32 Tongtien, System.Int32 Vat, System.String Ghichu, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhieugiaohangHEntity _PhieugiaohangHEntity = new PhieugiaohangHEntity(Sophieu);
				if (adapter.FetchEntity(_PhieugiaohangHEntity))
				{
				
					
					
					_PhieugiaohangHEntity.Ngaygiao = Ngaygiao;
					
					_PhieugiaohangHEntity.Madon = Madon;
					
					_PhieugiaohangHEntity.Ngaydat = Ngaydat;
					
					_PhieugiaohangHEntity.Makhach = Makhach;
					
					_PhieugiaohangHEntity.Tenkhach = Tenkhach;
					
					_PhieugiaohangHEntity.Tongtien = Tongtien;
					
					_PhieugiaohangHEntity.Vat = Vat;
					
					_PhieugiaohangHEntity.Ghichu = Ghichu;
					
					_PhieugiaohangHEntity.Ngaytao = Ngaytao;
					
					_PhieugiaohangHEntity.Nguoitao = Nguoitao;
					
					_PhieugiaohangHEntity.Ngaysua = Ngaysua;
					
					_PhieugiaohangHEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_PhieugiaohangHEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Sophieu)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhieugiaohangHEntity _PhieugiaohangHEntity = new PhieugiaohangHEntity(Sophieu);
				if (adapter.FetchEntity(_PhieugiaohangHEntity))
				{
					adapter.DeleteEntity(_PhieugiaohangHEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("PhieugiaohangHEntity", null);
			}
		}
		
		
		
		public int DeleteBySophieu(System.String Sophieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Sophieu == Sophieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaygiao(System.DateTime Ngaygiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMadon(System.String Madon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaydat(System.DateTime Ngaydat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTongtien(System.Int32 Tongtien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Tongtien == Tongtien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByVat(System.Int32 Vat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Vat == Vat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByGhichu(System.String Ghichu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangHEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhieugiaohangHEntity", filter);
			}
			return toReturn;
		}		
			
		
		public PhieugiaohangHEntity SelectOne(System.String Sophieu)
		{
			PhieugiaohangHEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhieugiaohangHEntity _PhieugiaohangHEntity = new PhieugiaohangHEntity(Sophieu);
				if (adapter.FetchEntity(_PhieugiaohangHEntity))
				{
					toReturn = _PhieugiaohangHEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _PhieugiaohangHCollection = new EntityCollection( new PhieugiaohangHEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangHCollection, null, 0, null);
			}
			return _PhieugiaohangHCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangHCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectBySophieu(System.String Sophieu)
		{
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Sophieu == Sophieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangHCollection, filter, 0, null);
			}
			return _PhieugiaohangHCollection;
		}
		// Return DataTable
		public DataTable SelectBySophieuRDT(System.String Sophieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Sophieu == Sophieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaygiao(System.DateTime Ngaygiao)
		{
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangHCollection, filter, 0, null);
			}
			return _PhieugiaohangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaygiaoRDT(System.DateTime Ngaygiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMadon(System.String Madon)
		{
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangHCollection, filter, 0, null);
			}
			return _PhieugiaohangHCollection;
		}
		// Return DataTable
		public DataTable SelectByMadonRDT(System.String Madon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaydat(System.DateTime Ngaydat)
		{
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangHCollection, filter, 0, null);
			}
			return _PhieugiaohangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaydatRDT(System.DateTime Ngaydat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangHCollection, filter, 0, null);
			}
			return _PhieugiaohangHCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangHCollection, filter, 0, null);
			}
			return _PhieugiaohangHCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTongtien(System.Int32 Tongtien)
		{
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Tongtien == Tongtien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangHCollection, filter, 0, null);
			}
			return _PhieugiaohangHCollection;
		}
		// Return DataTable
		public DataTable SelectByTongtienRDT(System.Int32 Tongtien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Tongtien == Tongtien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByVat(System.Int32 Vat)
		{
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Vat == Vat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangHCollection, filter, 0, null);
			}
			return _PhieugiaohangHCollection;
		}
		// Return DataTable
		public DataTable SelectByVatRDT(System.Int32 Vat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Vat == Vat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByGhichu(System.String Ghichu)
		{
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangHCollection, filter, 0, null);
			}
			return _PhieugiaohangHCollection;
		}
		// Return DataTable
		public DataTable SelectByGhichuRDT(System.String Ghichu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangHCollection, filter, 0, null);
			}
			return _PhieugiaohangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangHCollection, filter, 0, null);
			}
			return _PhieugiaohangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangHCollection, filter, 0, null);
			}
			return _PhieugiaohangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhieugiaohangHCollection, filter, 0, null);
			}
			return _PhieugiaohangHCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhieugiaohangHCollection = new EntityCollection(new PhieugiaohangHEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhieugiaohangHFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhieugiaohangHCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(PhieugiaohangHFields.Sophieu.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
