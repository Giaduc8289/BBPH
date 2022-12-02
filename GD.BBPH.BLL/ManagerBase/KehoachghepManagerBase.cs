


/*
'===============================================================================
'  GD.BBPH.BL.KehoachghepManagerBase
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
	public class KehoachghepManagerBase
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
		public KehoachghepManagerBase()
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
		public DataRow Convert(KehoachghepEntity _KehoachghepEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_KehoachghepEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Solenhsx]=_KehoachghepEntity.Solenhsx;
			}
			catch { }
			
			try
			{
				r[Field_Ngaydat]=_KehoachghepEntity.Ngaydat;
			}
			catch { }
			
			try
			{
				r[Field_Ngaygiao]=_KehoachghepEntity.Ngaygiao;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_KehoachghepEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Mamay]=_KehoachghepEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_Ngaychay]=_KehoachghepEntity.Ngaychay;
			}
			catch { }
			
			try
			{
				r[Field_Ca]=_KehoachghepEntity.Ca;
			}
			catch { }
			
			try
			{
				r[Field_Somet]=_KehoachghepEntity.Somet;
			}
			catch { }
			
			try
			{
				r[Field_Sokg]=_KehoachghepEntity.Sokg;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_KehoachghepEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_KehoachghepEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_KehoachghepEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_KehoachghepEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Sometdukien]=_KehoachghepEntity.Sometdukien;
			}
			catch { }
			
			try
			{
				r[Field_Sokgdukien]=_KehoachghepEntity.Sokgdukien;
			}
			catch { }
			
			try
			{
				r[Field_Soluong]=_KehoachghepEntity.Soluong;
			}
			catch { }
			
			try
			{
				r[Field_Sldukien]=_KehoachghepEntity.Sldukien;
			}
			catch { }
			
			try
			{
				r[Field_Tgdukien]=_KehoachghepEntity.Tgdukien;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public KehoachghepEntity Convert(DataRow r)
		{	
			
			KehoachghepEntity _KehoachghepEntity=new KehoachghepEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_KehoachghepEntity.Solenhsx= r[Field_Solenhsx].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Ngaydat= System.DateTime.Parse(r[Field_Ngaydat].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Ngaygiao= System.DateTime.Parse(r[Field_Ngaygiao].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Mamay= r[Field_Mamay].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Ngaychay= System.DateTime.Parse(r[Field_Ngaychay].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Ca= System.Int32.Parse(r[Field_Ca].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Somet= System.Decimal.Parse(r[Field_Somet].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Sokg= System.Decimal.Parse(r[Field_Sokg].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Sometdukien= System.Decimal.Parse(r[Field_Sometdukien].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Sokgdukien= System.Decimal.Parse(r[Field_Sokgdukien].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Soluong= System.Int32.Parse(r[Field_Soluong].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Sldukien= System.Int32.Parse(r[Field_Sldukien].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachghepEntity.Tgdukien= System.Int32.Parse(r[Field_Tgdukien].ToString());						
			}
			catch { }
									
									
			return _KehoachghepEntity;
		}			
		
		public KehoachghepEntity Convert_Entity(KehoachghepEntity _KehoachghepEntity,KehoachghepEntity _KehoachghepEntity_XML)
		{	
			
			
			_KehoachghepEntity.Id= _KehoachghepEntity_XML.Id;
			
			_KehoachghepEntity.Solenhsx= _KehoachghepEntity_XML.Solenhsx;
			
			_KehoachghepEntity.Ngaydat= _KehoachghepEntity_XML.Ngaydat;
			
			_KehoachghepEntity.Ngaygiao= _KehoachghepEntity_XML.Ngaygiao;
			
			_KehoachghepEntity.Masanpham= _KehoachghepEntity_XML.Masanpham;
			
			_KehoachghepEntity.Mamay= _KehoachghepEntity_XML.Mamay;
			
			_KehoachghepEntity.Ngaychay= _KehoachghepEntity_XML.Ngaychay;
			
			_KehoachghepEntity.Ca= _KehoachghepEntity_XML.Ca;
			
			_KehoachghepEntity.Somet= _KehoachghepEntity_XML.Somet;
			
			_KehoachghepEntity.Sokg= _KehoachghepEntity_XML.Sokg;
			
			_KehoachghepEntity.Ngaytao= _KehoachghepEntity_XML.Ngaytao;
			
			_KehoachghepEntity.Nguoitao= _KehoachghepEntity_XML.Nguoitao;
			
			_KehoachghepEntity.Ngaysua= _KehoachghepEntity_XML.Ngaysua;
			
			_KehoachghepEntity.Nguoisua= _KehoachghepEntity_XML.Nguoisua;
			
			_KehoachghepEntity.Sometdukien= _KehoachghepEntity_XML.Sometdukien;
			
			_KehoachghepEntity.Sokgdukien= _KehoachghepEntity_XML.Sokgdukien;
			
			_KehoachghepEntity.Soluong= _KehoachghepEntity_XML.Soluong;
			
			_KehoachghepEntity.Sldukien= _KehoachghepEntity_XML.Sldukien;
			
			_KehoachghepEntity.Tgdukien= _KehoachghepEntity_XML.Tgdukien;
									
				
			return _KehoachghepEntity;
		}	
		
		public String InsertV2(KehoachghepEntity _KehoachghepEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new KehoachghepManagerBase()).Insert(_KehoachghepEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_KehoachghepEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Solenhsx,_KehoachghepEntity.Solenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_KehoachghepEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_KehoachghepEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KehoachghepEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KehoachghepEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaychay,_KehoachghepEntity.Ngaychay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KehoachghepEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_KehoachghepEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_KehoachghepEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KehoachghepEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KehoachghepEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KehoachghepEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KehoachghepEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometdukien,_KehoachghepEntity.Sometdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgdukien,_KehoachghepEntity.Sokgdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_KehoachghepEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sldukien,_KehoachghepEntity.Sldukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tgdukien,_KehoachghepEntity.Tgdukien);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(KehoachghepEntity _KehoachghepEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new KehoachghepManagerBase()).Update(_KehoachghepEntity);
			r.SetField(Field_Id,_KehoachghepEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Solenhsx,_KehoachghepEntity.Solenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_KehoachghepEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_KehoachghepEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KehoachghepEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KehoachghepEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaychay,_KehoachghepEntity.Ngaychay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KehoachghepEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_KehoachghepEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_KehoachghepEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KehoachghepEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KehoachghepEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KehoachghepEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KehoachghepEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometdukien,_KehoachghepEntity.Sometdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgdukien,_KehoachghepEntity.Sokgdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_KehoachghepEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sldukien,_KehoachghepEntity.Sldukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tgdukien,_KehoachghepEntity.Tgdukien);
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

		public KehoachghepEntity Insert(KehoachghepEntity KehoachghepEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(KehoachghepEntity, true);
			}
			return KehoachghepEntity;
		}

		public KehoachghepEntity Insert(System.Int64  Id, System.String  Solenhsx, System.DateTime  Ngaydat, System.DateTime  Ngaygiao, System.String  Masanpham, System.String  Mamay, System.DateTime  Ngaychay, System.Int32  Ca, System.Decimal  Somet, System.Decimal  Sokg, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.Decimal  Sometdukien, System.Decimal  Sokgdukien, System.Int32  Soluong, System.Int32  Sldukien, System.Int32  Tgdukien)
		{
			KehoachghepEntity _KehoachghepEntity = new KehoachghepEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KehoachghepEntity.Id = Id;
				
				_KehoachghepEntity.Solenhsx = Solenhsx;
				
				_KehoachghepEntity.Ngaydat = Ngaydat;
				
				_KehoachghepEntity.Ngaygiao = Ngaygiao;
				
				_KehoachghepEntity.Masanpham = Masanpham;
				
				_KehoachghepEntity.Mamay = Mamay;
				
				_KehoachghepEntity.Ngaychay = Ngaychay;
				
				_KehoachghepEntity.Ca = Ca;
				
				_KehoachghepEntity.Somet = Somet;
				
				_KehoachghepEntity.Sokg = Sokg;
				
				_KehoachghepEntity.Ngaytao = Ngaytao;
				
				_KehoachghepEntity.Nguoitao = Nguoitao;
				
				_KehoachghepEntity.Ngaysua = Ngaysua;
				
				_KehoachghepEntity.Nguoisua = Nguoisua;
				
				_KehoachghepEntity.Sometdukien = Sometdukien;
				
				_KehoachghepEntity.Sokgdukien = Sokgdukien;
				
				_KehoachghepEntity.Soluong = Soluong;
				
				_KehoachghepEntity.Sldukien = Sldukien;
				
				_KehoachghepEntity.Tgdukien = Tgdukien;
					
					
				adapter.SaveEntity(_KehoachghepEntity, true);
			}
			return _KehoachghepEntity;
		}

		public KehoachghepEntity Insert(System.String Solenhsx, System.DateTime Ngaydat, System.DateTime Ngaygiao, System.String Masanpham, System.String Mamay, System.DateTime Ngaychay, System.Int32 Ca, System.Decimal Somet, System.Decimal Sokg, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Sometdukien, System.Decimal Sokgdukien, System.Int32 Soluong, System.Int32 Sldukien, System.Int32 Tgdukien)//ko co mahieu
		{
			KehoachghepEntity _KehoachghepEntity = new KehoachghepEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_KehoachghepEntity.Solenhsx = Solenhsx;
				
				_KehoachghepEntity.Ngaydat = Ngaydat;
				
				_KehoachghepEntity.Ngaygiao = Ngaygiao;
				
				_KehoachghepEntity.Masanpham = Masanpham;
				
				_KehoachghepEntity.Mamay = Mamay;
				
				_KehoachghepEntity.Ngaychay = Ngaychay;
				
				_KehoachghepEntity.Ca = Ca;
				
				_KehoachghepEntity.Somet = Somet;
				
				_KehoachghepEntity.Sokg = Sokg;
				
				_KehoachghepEntity.Ngaytao = Ngaytao;
				
				_KehoachghepEntity.Nguoitao = Nguoitao;
				
				_KehoachghepEntity.Ngaysua = Ngaysua;
				
				_KehoachghepEntity.Nguoisua = Nguoisua;
				
				_KehoachghepEntity.Sometdukien = Sometdukien;
				
				_KehoachghepEntity.Sokgdukien = Sokgdukien;
				
				_KehoachghepEntity.Soluong = Soluong;
				
				_KehoachghepEntity.Sldukien = Sldukien;
				
				_KehoachghepEntity.Tgdukien = Tgdukien;
					

				adapter.SaveEntity(_KehoachghepEntity, true);
			}
			return _KehoachghepEntity;
		}

		public bool Update(KehoachghepEntity _KehoachghepEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(KehoachghepFields.Id == _KehoachghepEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KehoachghepEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KehoachghepEntity _KehoachghepEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KehoachghepEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Solenhsx, System.DateTime Ngaydat, System.DateTime Ngaygiao, System.String Masanpham, System.String Mamay, System.DateTime Ngaychay, System.Int32 Ca, System.Decimal Somet, System.Decimal Sokg, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Sometdukien, System.Decimal Sokgdukien, System.Int32 Soluong, System.Int32 Sldukien, System.Int32 Tgdukien)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KehoachghepEntity _KehoachghepEntity = new KehoachghepEntity(Id);
				if (adapter.FetchEntity(_KehoachghepEntity))
				{
				
					
					
					_KehoachghepEntity.Solenhsx = Solenhsx;
					
					_KehoachghepEntity.Ngaydat = Ngaydat;
					
					_KehoachghepEntity.Ngaygiao = Ngaygiao;
					
					_KehoachghepEntity.Masanpham = Masanpham;
					
					_KehoachghepEntity.Mamay = Mamay;
					
					_KehoachghepEntity.Ngaychay = Ngaychay;
					
					_KehoachghepEntity.Ca = Ca;
					
					_KehoachghepEntity.Somet = Somet;
					
					_KehoachghepEntity.Sokg = Sokg;
					
					_KehoachghepEntity.Ngaytao = Ngaytao;
					
					_KehoachghepEntity.Nguoitao = Nguoitao;
					
					_KehoachghepEntity.Ngaysua = Ngaysua;
					
					_KehoachghepEntity.Nguoisua = Nguoisua;
					
					_KehoachghepEntity.Sometdukien = Sometdukien;
					
					_KehoachghepEntity.Sokgdukien = Sokgdukien;
					
					_KehoachghepEntity.Soluong = Soluong;
					
					_KehoachghepEntity.Sldukien = Sldukien;
					
					_KehoachghepEntity.Tgdukien = Tgdukien;
						

					adapter.SaveEntity(_KehoachghepEntity, true);
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
				KehoachghepEntity _KehoachghepEntity = new KehoachghepEntity(Id);
				if (adapter.FetchEntity(_KehoachghepEntity))
				{
					adapter.DeleteEntity(_KehoachghepEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KehoachghepEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySolenhsx(System.String Solenhsx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaydat(System.DateTime Ngaydat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaygiao(System.DateTime Ngaygiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaychay(System.DateTime Ngaychay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ngaychay == Ngaychay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCa(System.Int32 Ca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomet(System.Decimal Somet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokg(System.Decimal Sokg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySometdukien(System.Decimal Sometdukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Sometdukien == Sometdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokgdukien(System.Decimal Sokgdukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Sokgdukien == Sokgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluong(System.Int32 Soluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySldukien(System.Int32 Sldukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Sldukien == Sldukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTgdukien(System.Int32 Tgdukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Tgdukien == Tgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachghepEntity", filter);
			}
			return toReturn;
		}		
			
		
		public KehoachghepEntity SelectOne(System.Int64 Id)
		{
			KehoachghepEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KehoachghepEntity _KehoachghepEntity = new KehoachghepEntity(Id);
				if (adapter.FetchEntity(_KehoachghepEntity))
				{
					toReturn = _KehoachghepEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _KehoachghepCollection = new EntityCollection( new KehoachghepEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, null, 0, null);
			}
			return _KehoachghepCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySolenhsx(System.String Solenhsx)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectBySolenhsxRDT(System.String Solenhsx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaydat(System.DateTime Ngaydat)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaydatRDT(System.DateTime Ngaydat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaygiao(System.DateTime Ngaygiao)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaygiaoRDT(System.DateTime Ngaygiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaychay(System.DateTime Ngaychay)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ngaychay == Ngaychay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaychayRDT(System.DateTime Ngaychay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ngaychay == Ngaychay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCa(System.Int32 Ca)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectByCaRDT(System.Int32 Ca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomet(System.Decimal Somet)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectBySometRDT(System.Decimal Somet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokg(System.Decimal Sokg)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgRDT(System.Decimal Sokg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySometdukien(System.Decimal Sometdukien)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Sometdukien == Sometdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectBySometdukienRDT(System.Decimal Sometdukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Sometdukien == Sometdukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokgdukien(System.Decimal Sokgdukien)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Sokgdukien == Sokgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgdukienRDT(System.Decimal Sokgdukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Sokgdukien == Sokgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluong(System.Int32 Soluong)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongRDT(System.Int32 Soluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySldukien(System.Int32 Sldukien)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Sldukien == Sldukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectBySldukienRDT(System.Int32 Sldukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Sldukien == Sldukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTgdukien(System.Int32 Tgdukien)
		{
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Tgdukien == Tgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachghepCollection, filter, 0, null);
			}
			return _KehoachghepCollection;
		}
		// Return DataTable
		public DataTable SelectByTgdukienRDT(System.Int32 Tgdukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachghepCollection = new EntityCollection(new KehoachghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachghepFields.Tgdukien == Tgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(KehoachghepFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
