


/*
'===============================================================================
'  GD.BBPH.BL.KehoachtuaManagerBase
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
	public class KehoachtuaManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Solenhsx="Solenhsx";				
		
		public const String Field_Ngaydat="Ngaydat";				
		
		public const String Field_Ngaygiao="Ngaygiao";				
		
		public const String Field_Masanpham="Masanpham";				
		
		public const String Field_Mamay="Mamay";				
		
		public const String Field_Ngaychay="Ngaychay";				
		
		public const String Field_Ca="Ca";				
		
		public const String Field_Somet="Somet";				
		
		public const String Field_Sokg="Sokg";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Sometdukien="Sometdukien";				
		
		public const String Field_Sokgdukien="Sokgdukien";				
		
		public const String Field_Soluong="Soluong";				
		
		public const String Field_Sldukien="Sldukien";				
		
		public const String Field_Tgdukien="Tgdukien";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KehoachtuaManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Solenhsx,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaydat,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Ngaygiao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Masanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Mamay,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaychay,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Ca,typeof(System.Int32));
			
			dt.Columns.Add(Field_Somet,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokg,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Sometdukien,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokgdukien,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Soluong,typeof(System.Int32));
			
			dt.Columns.Add(Field_Sldukien,typeof(System.Int32));
			
			dt.Columns.Add(Field_Tgdukien,typeof(System.Int32));
									
		            
			return dt;			
		}
		public DataRow Convert(KehoachtuaEntity _KehoachtuaEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_KehoachtuaEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Solenhsx]=_KehoachtuaEntity.Solenhsx;
			}
			catch { }
			
			try
			{
				r[Field_Ngaydat]=_KehoachtuaEntity.Ngaydat;
			}
			catch { }
			
			try
			{
				r[Field_Ngaygiao]=_KehoachtuaEntity.Ngaygiao;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_KehoachtuaEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Mamay]=_KehoachtuaEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_Ngaychay]=_KehoachtuaEntity.Ngaychay;
			}
			catch { }
			
			try
			{
				r[Field_Ca]=_KehoachtuaEntity.Ca;
			}
			catch { }
			
			try
			{
				r[Field_Somet]=_KehoachtuaEntity.Somet;
			}
			catch { }
			
			try
			{
				r[Field_Sokg]=_KehoachtuaEntity.Sokg;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_KehoachtuaEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_KehoachtuaEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_KehoachtuaEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_KehoachtuaEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Sometdukien]=_KehoachtuaEntity.Sometdukien;
			}
			catch { }
			
			try
			{
				r[Field_Sokgdukien]=_KehoachtuaEntity.Sokgdukien;
			}
			catch { }
			
			try
			{
				r[Field_Soluong]=_KehoachtuaEntity.Soluong;
			}
			catch { }
			
			try
			{
				r[Field_Sldukien]=_KehoachtuaEntity.Sldukien;
			}
			catch { }
			
			try
			{
				r[Field_Tgdukien]=_KehoachtuaEntity.Tgdukien;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public KehoachtuaEntity Convert(DataRow r)
		{	
			
			KehoachtuaEntity _KehoachtuaEntity=new KehoachtuaEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_KehoachtuaEntity.Solenhsx= r[Field_Solenhsx].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Ngaydat= System.DateTime.Parse(r[Field_Ngaydat].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Ngaygiao= System.DateTime.Parse(r[Field_Ngaygiao].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Mamay= r[Field_Mamay].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Ngaychay= System.DateTime.Parse(r[Field_Ngaychay].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Ca= System.Int32.Parse(r[Field_Ca].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Somet= System.Decimal.Parse(r[Field_Somet].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Sokg= System.Decimal.Parse(r[Field_Sokg].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Sometdukien= System.Decimal.Parse(r[Field_Sometdukien].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Sokgdukien= System.Decimal.Parse(r[Field_Sokgdukien].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Soluong= System.Int32.Parse(r[Field_Soluong].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Sldukien= System.Int32.Parse(r[Field_Sldukien].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachtuaEntity.Tgdukien= System.Int32.Parse(r[Field_Tgdukien].ToString());						
			}
			catch { }
									
									
			return _KehoachtuaEntity;
		}			
		
		public KehoachtuaEntity Convert_Entity(KehoachtuaEntity _KehoachtuaEntity,KehoachtuaEntity _KehoachtuaEntity_XML)
		{	
			
			
			_KehoachtuaEntity.Id= _KehoachtuaEntity_XML.Id;
			
			_KehoachtuaEntity.Solenhsx= _KehoachtuaEntity_XML.Solenhsx;
			
			_KehoachtuaEntity.Ngaydat= _KehoachtuaEntity_XML.Ngaydat;
			
			_KehoachtuaEntity.Ngaygiao= _KehoachtuaEntity_XML.Ngaygiao;
			
			_KehoachtuaEntity.Masanpham= _KehoachtuaEntity_XML.Masanpham;
			
			_KehoachtuaEntity.Mamay= _KehoachtuaEntity_XML.Mamay;
			
			_KehoachtuaEntity.Ngaychay= _KehoachtuaEntity_XML.Ngaychay;
			
			_KehoachtuaEntity.Ca= _KehoachtuaEntity_XML.Ca;
			
			_KehoachtuaEntity.Somet= _KehoachtuaEntity_XML.Somet;
			
			_KehoachtuaEntity.Sokg= _KehoachtuaEntity_XML.Sokg;
			
			_KehoachtuaEntity.Ngaytao= _KehoachtuaEntity_XML.Ngaytao;
			
			_KehoachtuaEntity.Nguoitao= _KehoachtuaEntity_XML.Nguoitao;
			
			_KehoachtuaEntity.Ngaysua= _KehoachtuaEntity_XML.Ngaysua;
			
			_KehoachtuaEntity.Nguoisua= _KehoachtuaEntity_XML.Nguoisua;
			
			_KehoachtuaEntity.Sometdukien= _KehoachtuaEntity_XML.Sometdukien;
			
			_KehoachtuaEntity.Sokgdukien= _KehoachtuaEntity_XML.Sokgdukien;
			
			_KehoachtuaEntity.Soluong= _KehoachtuaEntity_XML.Soluong;
			
			_KehoachtuaEntity.Sldukien= _KehoachtuaEntity_XML.Sldukien;
			
			_KehoachtuaEntity.Tgdukien= _KehoachtuaEntity_XML.Tgdukien;
									
				
			return _KehoachtuaEntity;
		}	
		
		public String InsertV2(KehoachtuaEntity _KehoachtuaEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new KehoachtuaManagerBase()).Insert(_KehoachtuaEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_KehoachtuaEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Solenhsx,_KehoachtuaEntity.Solenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_KehoachtuaEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_KehoachtuaEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KehoachtuaEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KehoachtuaEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaychay,_KehoachtuaEntity.Ngaychay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KehoachtuaEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_KehoachtuaEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_KehoachtuaEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KehoachtuaEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KehoachtuaEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KehoachtuaEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KehoachtuaEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometdukien,_KehoachtuaEntity.Sometdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgdukien,_KehoachtuaEntity.Sokgdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_KehoachtuaEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sldukien,_KehoachtuaEntity.Sldukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tgdukien,_KehoachtuaEntity.Tgdukien);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(KehoachtuaEntity _KehoachtuaEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new KehoachtuaManagerBase()).Update(_KehoachtuaEntity);
			r.SetField(Field_Id,_KehoachtuaEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Solenhsx,_KehoachtuaEntity.Solenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_KehoachtuaEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_KehoachtuaEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KehoachtuaEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KehoachtuaEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaychay,_KehoachtuaEntity.Ngaychay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KehoachtuaEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_KehoachtuaEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_KehoachtuaEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KehoachtuaEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KehoachtuaEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KehoachtuaEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KehoachtuaEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometdukien,_KehoachtuaEntity.Sometdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgdukien,_KehoachtuaEntity.Sokgdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_KehoachtuaEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sldukien,_KehoachtuaEntity.Sldukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tgdukien,_KehoachtuaEntity.Tgdukien);
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

		public KehoachtuaEntity Insert(KehoachtuaEntity KehoachtuaEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(KehoachtuaEntity, true);
			}
			return KehoachtuaEntity;
		}

		public KehoachtuaEntity Insert(System.Int64  Id, System.String  Solenhsx, System.DateTime  Ngaydat, System.DateTime  Ngaygiao, System.String  Masanpham, System.String  Mamay, System.DateTime  Ngaychay, System.Int32  Ca, System.Decimal  Somet, System.Decimal  Sokg, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.Decimal  Sometdukien, System.Decimal  Sokgdukien, System.Int32  Soluong, System.Int32  Sldukien, System.Int32  Tgdukien)
		{
			KehoachtuaEntity _KehoachtuaEntity = new KehoachtuaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KehoachtuaEntity.Id = Id;
				
				_KehoachtuaEntity.Solenhsx = Solenhsx;
				
				_KehoachtuaEntity.Ngaydat = Ngaydat;
				
				_KehoachtuaEntity.Ngaygiao = Ngaygiao;
				
				_KehoachtuaEntity.Masanpham = Masanpham;
				
				_KehoachtuaEntity.Mamay = Mamay;
				
				_KehoachtuaEntity.Ngaychay = Ngaychay;
				
				_KehoachtuaEntity.Ca = Ca;
				
				_KehoachtuaEntity.Somet = Somet;
				
				_KehoachtuaEntity.Sokg = Sokg;
				
				_KehoachtuaEntity.Ngaytao = Ngaytao;
				
				_KehoachtuaEntity.Nguoitao = Nguoitao;
				
				_KehoachtuaEntity.Ngaysua = Ngaysua;
				
				_KehoachtuaEntity.Nguoisua = Nguoisua;
				
				_KehoachtuaEntity.Sometdukien = Sometdukien;
				
				_KehoachtuaEntity.Sokgdukien = Sokgdukien;
				
				_KehoachtuaEntity.Soluong = Soluong;
				
				_KehoachtuaEntity.Sldukien = Sldukien;
				
				_KehoachtuaEntity.Tgdukien = Tgdukien;
					
					
				adapter.SaveEntity(_KehoachtuaEntity, true);
			}
			return _KehoachtuaEntity;
		}

		public KehoachtuaEntity Insert(System.String Solenhsx, System.DateTime Ngaydat, System.DateTime Ngaygiao, System.String Masanpham, System.String Mamay, System.DateTime Ngaychay, System.Int32 Ca, System.Decimal Somet, System.Decimal Sokg, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Sometdukien, System.Decimal Sokgdukien, System.Int32 Soluong, System.Int32 Sldukien, System.Int32 Tgdukien)//ko co mahieu
		{
			KehoachtuaEntity _KehoachtuaEntity = new KehoachtuaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_KehoachtuaEntity.Solenhsx = Solenhsx;
				
				_KehoachtuaEntity.Ngaydat = Ngaydat;
				
				_KehoachtuaEntity.Ngaygiao = Ngaygiao;
				
				_KehoachtuaEntity.Masanpham = Masanpham;
				
				_KehoachtuaEntity.Mamay = Mamay;
				
				_KehoachtuaEntity.Ngaychay = Ngaychay;
				
				_KehoachtuaEntity.Ca = Ca;
				
				_KehoachtuaEntity.Somet = Somet;
				
				_KehoachtuaEntity.Sokg = Sokg;
				
				_KehoachtuaEntity.Ngaytao = Ngaytao;
				
				_KehoachtuaEntity.Nguoitao = Nguoitao;
				
				_KehoachtuaEntity.Ngaysua = Ngaysua;
				
				_KehoachtuaEntity.Nguoisua = Nguoisua;
				
				_KehoachtuaEntity.Sometdukien = Sometdukien;
				
				_KehoachtuaEntity.Sokgdukien = Sokgdukien;
				
				_KehoachtuaEntity.Soluong = Soluong;
				
				_KehoachtuaEntity.Sldukien = Sldukien;
				
				_KehoachtuaEntity.Tgdukien = Tgdukien;
					

				adapter.SaveEntity(_KehoachtuaEntity, true);
			}
			return _KehoachtuaEntity;
		}

		public bool Update(KehoachtuaEntity _KehoachtuaEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(KehoachtuaFields.Id == _KehoachtuaEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KehoachtuaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KehoachtuaEntity _KehoachtuaEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KehoachtuaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Solenhsx, System.DateTime Ngaydat, System.DateTime Ngaygiao, System.String Masanpham, System.String Mamay, System.DateTime Ngaychay, System.Int32 Ca, System.Decimal Somet, System.Decimal Sokg, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Sometdukien, System.Decimal Sokgdukien, System.Int32 Soluong, System.Int32 Sldukien, System.Int32 Tgdukien)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KehoachtuaEntity _KehoachtuaEntity = new KehoachtuaEntity(Id);
				if (adapter.FetchEntity(_KehoachtuaEntity))
				{
				
					
					
					_KehoachtuaEntity.Solenhsx = Solenhsx;
					
					_KehoachtuaEntity.Ngaydat = Ngaydat;
					
					_KehoachtuaEntity.Ngaygiao = Ngaygiao;
					
					_KehoachtuaEntity.Masanpham = Masanpham;
					
					_KehoachtuaEntity.Mamay = Mamay;
					
					_KehoachtuaEntity.Ngaychay = Ngaychay;
					
					_KehoachtuaEntity.Ca = Ca;
					
					_KehoachtuaEntity.Somet = Somet;
					
					_KehoachtuaEntity.Sokg = Sokg;
					
					_KehoachtuaEntity.Ngaytao = Ngaytao;
					
					_KehoachtuaEntity.Nguoitao = Nguoitao;
					
					_KehoachtuaEntity.Ngaysua = Ngaysua;
					
					_KehoachtuaEntity.Nguoisua = Nguoisua;
					
					_KehoachtuaEntity.Sometdukien = Sometdukien;
					
					_KehoachtuaEntity.Sokgdukien = Sokgdukien;
					
					_KehoachtuaEntity.Soluong = Soluong;
					
					_KehoachtuaEntity.Sldukien = Sldukien;
					
					_KehoachtuaEntity.Tgdukien = Tgdukien;
						

					adapter.SaveEntity(_KehoachtuaEntity, true);
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
				KehoachtuaEntity _KehoachtuaEntity = new KehoachtuaEntity(Id);
				if (adapter.FetchEntity(_KehoachtuaEntity))
				{
					adapter.DeleteEntity(_KehoachtuaEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KehoachtuaEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySolenhsx(System.String Solenhsx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaydat(System.DateTime Ngaydat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaygiao(System.DateTime Ngaygiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaychay(System.DateTime Ngaychay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ngaychay == Ngaychay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCa(System.Int32 Ca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomet(System.Decimal Somet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokg(System.Decimal Sokg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySometdukien(System.Decimal Sometdukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Sometdukien == Sometdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokgdukien(System.Decimal Sokgdukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Sokgdukien == Sokgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluong(System.Int32 Soluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySldukien(System.Int32 Sldukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Sldukien == Sldukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTgdukien(System.Int32 Tgdukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Tgdukien == Tgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachtuaEntity", filter);
			}
			return toReturn;
		}		
			
		
		public KehoachtuaEntity SelectOne(System.Int64 Id)
		{
			KehoachtuaEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KehoachtuaEntity _KehoachtuaEntity = new KehoachtuaEntity(Id);
				if (adapter.FetchEntity(_KehoachtuaEntity))
				{
					toReturn = _KehoachtuaEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection( new KehoachtuaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, null, 0, null);
			}
			return _KehoachtuaCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySolenhsx(System.String Solenhsx)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectBySolenhsxRDT(System.String Solenhsx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaydat(System.DateTime Ngaydat)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaydatRDT(System.DateTime Ngaydat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaygiao(System.DateTime Ngaygiao)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaygiaoRDT(System.DateTime Ngaygiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaychay(System.DateTime Ngaychay)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ngaychay == Ngaychay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaychayRDT(System.DateTime Ngaychay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ngaychay == Ngaychay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCa(System.Int32 Ca)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectByCaRDT(System.Int32 Ca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomet(System.Decimal Somet)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectBySometRDT(System.Decimal Somet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokg(System.Decimal Sokg)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgRDT(System.Decimal Sokg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySometdukien(System.Decimal Sometdukien)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Sometdukien == Sometdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectBySometdukienRDT(System.Decimal Sometdukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Sometdukien == Sometdukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokgdukien(System.Decimal Sokgdukien)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Sokgdukien == Sokgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgdukienRDT(System.Decimal Sokgdukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Sokgdukien == Sokgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluong(System.Int32 Soluong)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongRDT(System.Int32 Soluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySldukien(System.Int32 Sldukien)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Sldukien == Sldukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectBySldukienRDT(System.Int32 Sldukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Sldukien == Sldukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTgdukien(System.Int32 Tgdukien)
		{
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Tgdukien == Tgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachtuaCollection, filter, 0, null);
			}
			return _KehoachtuaCollection;
		}
		// Return DataTable
		public DataTable SelectByTgdukienRDT(System.Int32 Tgdukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachtuaCollection = new EntityCollection(new KehoachtuaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachtuaFields.Tgdukien == Tgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachtuaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(KehoachtuaFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
