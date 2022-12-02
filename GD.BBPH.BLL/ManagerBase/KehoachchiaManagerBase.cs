


/*
'===============================================================================
'  GD.BBPH.BL.KehoachchiaManagerBase
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
	public class KehoachchiaManagerBase
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
		public KehoachchiaManagerBase()
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
		public DataRow Convert(KehoachchiaEntity _KehoachchiaEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_KehoachchiaEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Solenhsx]=_KehoachchiaEntity.Solenhsx;
			}
			catch { }
			
			try
			{
				r[Field_Ngaydat]=_KehoachchiaEntity.Ngaydat;
			}
			catch { }
			
			try
			{
				r[Field_Ngaygiao]=_KehoachchiaEntity.Ngaygiao;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_KehoachchiaEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Mamay]=_KehoachchiaEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_Ngaychay]=_KehoachchiaEntity.Ngaychay;
			}
			catch { }
			
			try
			{
				r[Field_Ca]=_KehoachchiaEntity.Ca;
			}
			catch { }
			
			try
			{
				r[Field_Somet]=_KehoachchiaEntity.Somet;
			}
			catch { }
			
			try
			{
				r[Field_Sokg]=_KehoachchiaEntity.Sokg;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_KehoachchiaEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_KehoachchiaEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_KehoachchiaEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_KehoachchiaEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Sometdukien]=_KehoachchiaEntity.Sometdukien;
			}
			catch { }
			
			try
			{
				r[Field_Sokgdukien]=_KehoachchiaEntity.Sokgdukien;
			}
			catch { }
			
			try
			{
				r[Field_Soluong]=_KehoachchiaEntity.Soluong;
			}
			catch { }
			
			try
			{
				r[Field_Sldukien]=_KehoachchiaEntity.Sldukien;
			}
			catch { }
			
			try
			{
				r[Field_Tgdukien]=_KehoachchiaEntity.Tgdukien;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public KehoachchiaEntity Convert(DataRow r)
		{	
			
			KehoachchiaEntity _KehoachchiaEntity=new KehoachchiaEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_KehoachchiaEntity.Solenhsx= r[Field_Solenhsx].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Ngaydat= System.DateTime.Parse(r[Field_Ngaydat].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Ngaygiao= System.DateTime.Parse(r[Field_Ngaygiao].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Mamay= r[Field_Mamay].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Ngaychay= System.DateTime.Parse(r[Field_Ngaychay].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Ca= System.Int32.Parse(r[Field_Ca].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Somet= System.Decimal.Parse(r[Field_Somet].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Sokg= System.Decimal.Parse(r[Field_Sokg].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Sometdukien= System.Decimal.Parse(r[Field_Sometdukien].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Sokgdukien= System.Decimal.Parse(r[Field_Sokgdukien].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Soluong= System.Int32.Parse(r[Field_Soluong].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Sldukien= System.Int32.Parse(r[Field_Sldukien].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachchiaEntity.Tgdukien= System.Int32.Parse(r[Field_Tgdukien].ToString());						
			}
			catch { }
									
									
			return _KehoachchiaEntity;
		}			
		
		public KehoachchiaEntity Convert_Entity(KehoachchiaEntity _KehoachchiaEntity,KehoachchiaEntity _KehoachchiaEntity_XML)
		{	
			
			
			_KehoachchiaEntity.Id= _KehoachchiaEntity_XML.Id;
			
			_KehoachchiaEntity.Solenhsx= _KehoachchiaEntity_XML.Solenhsx;
			
			_KehoachchiaEntity.Ngaydat= _KehoachchiaEntity_XML.Ngaydat;
			
			_KehoachchiaEntity.Ngaygiao= _KehoachchiaEntity_XML.Ngaygiao;
			
			_KehoachchiaEntity.Masanpham= _KehoachchiaEntity_XML.Masanpham;
			
			_KehoachchiaEntity.Mamay= _KehoachchiaEntity_XML.Mamay;
			
			_KehoachchiaEntity.Ngaychay= _KehoachchiaEntity_XML.Ngaychay;
			
			_KehoachchiaEntity.Ca= _KehoachchiaEntity_XML.Ca;
			
			_KehoachchiaEntity.Somet= _KehoachchiaEntity_XML.Somet;
			
			_KehoachchiaEntity.Sokg= _KehoachchiaEntity_XML.Sokg;
			
			_KehoachchiaEntity.Ngaytao= _KehoachchiaEntity_XML.Ngaytao;
			
			_KehoachchiaEntity.Nguoitao= _KehoachchiaEntity_XML.Nguoitao;
			
			_KehoachchiaEntity.Ngaysua= _KehoachchiaEntity_XML.Ngaysua;
			
			_KehoachchiaEntity.Nguoisua= _KehoachchiaEntity_XML.Nguoisua;
			
			_KehoachchiaEntity.Sometdukien= _KehoachchiaEntity_XML.Sometdukien;
			
			_KehoachchiaEntity.Sokgdukien= _KehoachchiaEntity_XML.Sokgdukien;
			
			_KehoachchiaEntity.Soluong= _KehoachchiaEntity_XML.Soluong;
			
			_KehoachchiaEntity.Sldukien= _KehoachchiaEntity_XML.Sldukien;
			
			_KehoachchiaEntity.Tgdukien= _KehoachchiaEntity_XML.Tgdukien;
									
				
			return _KehoachchiaEntity;
		}	
		
		public String InsertV2(KehoachchiaEntity _KehoachchiaEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new KehoachchiaManagerBase()).Insert(_KehoachchiaEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_KehoachchiaEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Solenhsx,_KehoachchiaEntity.Solenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_KehoachchiaEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_KehoachchiaEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KehoachchiaEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KehoachchiaEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaychay,_KehoachchiaEntity.Ngaychay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KehoachchiaEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_KehoachchiaEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_KehoachchiaEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KehoachchiaEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KehoachchiaEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KehoachchiaEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KehoachchiaEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometdukien,_KehoachchiaEntity.Sometdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgdukien,_KehoachchiaEntity.Sokgdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_KehoachchiaEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sldukien,_KehoachchiaEntity.Sldukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tgdukien,_KehoachchiaEntity.Tgdukien);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(KehoachchiaEntity _KehoachchiaEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new KehoachchiaManagerBase()).Update(_KehoachchiaEntity);
			r.SetField(Field_Id,_KehoachchiaEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Solenhsx,_KehoachchiaEntity.Solenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_KehoachchiaEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_KehoachchiaEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KehoachchiaEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KehoachchiaEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaychay,_KehoachchiaEntity.Ngaychay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KehoachchiaEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_KehoachchiaEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_KehoachchiaEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KehoachchiaEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KehoachchiaEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KehoachchiaEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KehoachchiaEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometdukien,_KehoachchiaEntity.Sometdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgdukien,_KehoachchiaEntity.Sokgdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_KehoachchiaEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sldukien,_KehoachchiaEntity.Sldukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tgdukien,_KehoachchiaEntity.Tgdukien);
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

		public KehoachchiaEntity Insert(KehoachchiaEntity KehoachchiaEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(KehoachchiaEntity, true);
			}
			return KehoachchiaEntity;
		}

		public KehoachchiaEntity Insert(System.Int64  Id, System.String  Solenhsx, System.DateTime  Ngaydat, System.DateTime  Ngaygiao, System.String  Masanpham, System.String  Mamay, System.DateTime  Ngaychay, System.Int32  Ca, System.Decimal  Somet, System.Decimal  Sokg, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.Decimal  Sometdukien, System.Decimal  Sokgdukien, System.Int32  Soluong, System.Int32  Sldukien, System.Int32  Tgdukien)
		{
			KehoachchiaEntity _KehoachchiaEntity = new KehoachchiaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KehoachchiaEntity.Id = Id;
				
				_KehoachchiaEntity.Solenhsx = Solenhsx;
				
				_KehoachchiaEntity.Ngaydat = Ngaydat;
				
				_KehoachchiaEntity.Ngaygiao = Ngaygiao;
				
				_KehoachchiaEntity.Masanpham = Masanpham;
				
				_KehoachchiaEntity.Mamay = Mamay;
				
				_KehoachchiaEntity.Ngaychay = Ngaychay;
				
				_KehoachchiaEntity.Ca = Ca;
				
				_KehoachchiaEntity.Somet = Somet;
				
				_KehoachchiaEntity.Sokg = Sokg;
				
				_KehoachchiaEntity.Ngaytao = Ngaytao;
				
				_KehoachchiaEntity.Nguoitao = Nguoitao;
				
				_KehoachchiaEntity.Ngaysua = Ngaysua;
				
				_KehoachchiaEntity.Nguoisua = Nguoisua;
				
				_KehoachchiaEntity.Sometdukien = Sometdukien;
				
				_KehoachchiaEntity.Sokgdukien = Sokgdukien;
				
				_KehoachchiaEntity.Soluong = Soluong;
				
				_KehoachchiaEntity.Sldukien = Sldukien;
				
				_KehoachchiaEntity.Tgdukien = Tgdukien;
					
					
				adapter.SaveEntity(_KehoachchiaEntity, true);
			}
			return _KehoachchiaEntity;
		}

		public KehoachchiaEntity Insert(System.String Solenhsx, System.DateTime Ngaydat, System.DateTime Ngaygiao, System.String Masanpham, System.String Mamay, System.DateTime Ngaychay, System.Int32 Ca, System.Decimal Somet, System.Decimal Sokg, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Sometdukien, System.Decimal Sokgdukien, System.Int32 Soluong, System.Int32 Sldukien, System.Int32 Tgdukien)//ko co mahieu
		{
			KehoachchiaEntity _KehoachchiaEntity = new KehoachchiaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_KehoachchiaEntity.Solenhsx = Solenhsx;
				
				_KehoachchiaEntity.Ngaydat = Ngaydat;
				
				_KehoachchiaEntity.Ngaygiao = Ngaygiao;
				
				_KehoachchiaEntity.Masanpham = Masanpham;
				
				_KehoachchiaEntity.Mamay = Mamay;
				
				_KehoachchiaEntity.Ngaychay = Ngaychay;
				
				_KehoachchiaEntity.Ca = Ca;
				
				_KehoachchiaEntity.Somet = Somet;
				
				_KehoachchiaEntity.Sokg = Sokg;
				
				_KehoachchiaEntity.Ngaytao = Ngaytao;
				
				_KehoachchiaEntity.Nguoitao = Nguoitao;
				
				_KehoachchiaEntity.Ngaysua = Ngaysua;
				
				_KehoachchiaEntity.Nguoisua = Nguoisua;
				
				_KehoachchiaEntity.Sometdukien = Sometdukien;
				
				_KehoachchiaEntity.Sokgdukien = Sokgdukien;
				
				_KehoachchiaEntity.Soluong = Soluong;
				
				_KehoachchiaEntity.Sldukien = Sldukien;
				
				_KehoachchiaEntity.Tgdukien = Tgdukien;
					

				adapter.SaveEntity(_KehoachchiaEntity, true);
			}
			return _KehoachchiaEntity;
		}

		public bool Update(KehoachchiaEntity _KehoachchiaEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(KehoachchiaFields.Id == _KehoachchiaEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KehoachchiaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KehoachchiaEntity _KehoachchiaEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KehoachchiaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Solenhsx, System.DateTime Ngaydat, System.DateTime Ngaygiao, System.String Masanpham, System.String Mamay, System.DateTime Ngaychay, System.Int32 Ca, System.Decimal Somet, System.Decimal Sokg, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Sometdukien, System.Decimal Sokgdukien, System.Int32 Soluong, System.Int32 Sldukien, System.Int32 Tgdukien)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KehoachchiaEntity _KehoachchiaEntity = new KehoachchiaEntity(Id);
				if (adapter.FetchEntity(_KehoachchiaEntity))
				{
				
					
					
					_KehoachchiaEntity.Solenhsx = Solenhsx;
					
					_KehoachchiaEntity.Ngaydat = Ngaydat;
					
					_KehoachchiaEntity.Ngaygiao = Ngaygiao;
					
					_KehoachchiaEntity.Masanpham = Masanpham;
					
					_KehoachchiaEntity.Mamay = Mamay;
					
					_KehoachchiaEntity.Ngaychay = Ngaychay;
					
					_KehoachchiaEntity.Ca = Ca;
					
					_KehoachchiaEntity.Somet = Somet;
					
					_KehoachchiaEntity.Sokg = Sokg;
					
					_KehoachchiaEntity.Ngaytao = Ngaytao;
					
					_KehoachchiaEntity.Nguoitao = Nguoitao;
					
					_KehoachchiaEntity.Ngaysua = Ngaysua;
					
					_KehoachchiaEntity.Nguoisua = Nguoisua;
					
					_KehoachchiaEntity.Sometdukien = Sometdukien;
					
					_KehoachchiaEntity.Sokgdukien = Sokgdukien;
					
					_KehoachchiaEntity.Soluong = Soluong;
					
					_KehoachchiaEntity.Sldukien = Sldukien;
					
					_KehoachchiaEntity.Tgdukien = Tgdukien;
						

					adapter.SaveEntity(_KehoachchiaEntity, true);
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
				KehoachchiaEntity _KehoachchiaEntity = new KehoachchiaEntity(Id);
				if (adapter.FetchEntity(_KehoachchiaEntity))
				{
					adapter.DeleteEntity(_KehoachchiaEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KehoachchiaEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySolenhsx(System.String Solenhsx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaydat(System.DateTime Ngaydat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaygiao(System.DateTime Ngaygiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaychay(System.DateTime Ngaychay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ngaychay == Ngaychay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCa(System.Int32 Ca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomet(System.Decimal Somet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokg(System.Decimal Sokg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySometdukien(System.Decimal Sometdukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Sometdukien == Sometdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokgdukien(System.Decimal Sokgdukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Sokgdukien == Sokgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluong(System.Int32 Soluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySldukien(System.Int32 Sldukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Sldukien == Sldukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTgdukien(System.Int32 Tgdukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Tgdukien == Tgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachchiaEntity", filter);
			}
			return toReturn;
		}		
			
		
		public KehoachchiaEntity SelectOne(System.Int64 Id)
		{
			KehoachchiaEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KehoachchiaEntity _KehoachchiaEntity = new KehoachchiaEntity(Id);
				if (adapter.FetchEntity(_KehoachchiaEntity))
				{
					toReturn = _KehoachchiaEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection( new KehoachchiaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, null, 0, null);
			}
			return _KehoachchiaCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySolenhsx(System.String Solenhsx)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySolenhsxRDT(System.String Solenhsx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaydat(System.DateTime Ngaydat)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaydatRDT(System.DateTime Ngaydat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaygiao(System.DateTime Ngaygiao)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaygiaoRDT(System.DateTime Ngaygiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaychay(System.DateTime Ngaychay)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ngaychay == Ngaychay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaychayRDT(System.DateTime Ngaychay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ngaychay == Ngaychay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCa(System.Int32 Ca)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectByCaRDT(System.Int32 Ca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomet(System.Decimal Somet)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySometRDT(System.Decimal Somet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokg(System.Decimal Sokg)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgRDT(System.Decimal Sokg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySometdukien(System.Decimal Sometdukien)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Sometdukien == Sometdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySometdukienRDT(System.Decimal Sometdukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Sometdukien == Sometdukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokgdukien(System.Decimal Sokgdukien)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Sokgdukien == Sokgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgdukienRDT(System.Decimal Sokgdukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Sokgdukien == Sokgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluong(System.Int32 Soluong)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongRDT(System.Int32 Soluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySldukien(System.Int32 Sldukien)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Sldukien == Sldukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySldukienRDT(System.Int32 Sldukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Sldukien == Sldukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTgdukien(System.Int32 Tgdukien)
		{
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Tgdukien == Tgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachchiaCollection, filter, 0, null);
			}
			return _KehoachchiaCollection;
		}
		// Return DataTable
		public DataTable SelectByTgdukienRDT(System.Int32 Tgdukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachchiaCollection = new EntityCollection(new KehoachchiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachchiaFields.Tgdukien == Tgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachchiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(KehoachchiaFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
