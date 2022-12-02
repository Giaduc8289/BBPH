


/*
'===============================================================================
'  GD.BBPH.BL.KehoachinManagerBase
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
	public class KehoachinManagerBase
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
		public KehoachinManagerBase()
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
		public DataRow Convert(KehoachinEntity _KehoachinEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_KehoachinEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Solenhsx]=_KehoachinEntity.Solenhsx;
			}
			catch { }
			
			try
			{
				r[Field_Ngaydat]=_KehoachinEntity.Ngaydat;
			}
			catch { }
			
			try
			{
				r[Field_Ngaygiao]=_KehoachinEntity.Ngaygiao;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_KehoachinEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Mamay]=_KehoachinEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_Ngaychay]=_KehoachinEntity.Ngaychay;
			}
			catch { }
			
			try
			{
				r[Field_Ca]=_KehoachinEntity.Ca;
			}
			catch { }
			
			try
			{
				r[Field_Somet]=_KehoachinEntity.Somet;
			}
			catch { }
			
			try
			{
				r[Field_Sokg]=_KehoachinEntity.Sokg;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_KehoachinEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_KehoachinEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_KehoachinEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_KehoachinEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Sometdukien]=_KehoachinEntity.Sometdukien;
			}
			catch { }
			
			try
			{
				r[Field_Sokgdukien]=_KehoachinEntity.Sokgdukien;
			}
			catch { }
			
			try
			{
				r[Field_Soluong]=_KehoachinEntity.Soluong;
			}
			catch { }
			
			try
			{
				r[Field_Sldukien]=_KehoachinEntity.Sldukien;
			}
			catch { }
			
			try
			{
				r[Field_Tgdukien]=_KehoachinEntity.Tgdukien;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public KehoachinEntity Convert(DataRow r)
		{	
			
			KehoachinEntity _KehoachinEntity=new KehoachinEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_KehoachinEntity.Solenhsx= r[Field_Solenhsx].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Ngaydat= System.DateTime.Parse(r[Field_Ngaydat].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Ngaygiao= System.DateTime.Parse(r[Field_Ngaygiao].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Mamay= r[Field_Mamay].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Ngaychay= System.DateTime.Parse(r[Field_Ngaychay].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Ca= System.Int32.Parse(r[Field_Ca].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Somet= System.Decimal.Parse(r[Field_Somet].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Sokg= System.Decimal.Parse(r[Field_Sokg].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Sometdukien= System.Decimal.Parse(r[Field_Sometdukien].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Sokgdukien= System.Decimal.Parse(r[Field_Sokgdukien].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Soluong= System.Int32.Parse(r[Field_Soluong].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Sldukien= System.Int32.Parse(r[Field_Sldukien].ToString());						
			}
			catch { }
			
			try
			{
				_KehoachinEntity.Tgdukien= System.Int32.Parse(r[Field_Tgdukien].ToString());						
			}
			catch { }
									
									
			return _KehoachinEntity;
		}			
		
		public KehoachinEntity Convert_Entity(KehoachinEntity _KehoachinEntity,KehoachinEntity _KehoachinEntity_XML)
		{	
			
			
			_KehoachinEntity.Id= _KehoachinEntity_XML.Id;
			
			_KehoachinEntity.Solenhsx= _KehoachinEntity_XML.Solenhsx;
			
			_KehoachinEntity.Ngaydat= _KehoachinEntity_XML.Ngaydat;
			
			_KehoachinEntity.Ngaygiao= _KehoachinEntity_XML.Ngaygiao;
			
			_KehoachinEntity.Masanpham= _KehoachinEntity_XML.Masanpham;
			
			_KehoachinEntity.Mamay= _KehoachinEntity_XML.Mamay;
			
			_KehoachinEntity.Ngaychay= _KehoachinEntity_XML.Ngaychay;
			
			_KehoachinEntity.Ca= _KehoachinEntity_XML.Ca;
			
			_KehoachinEntity.Somet= _KehoachinEntity_XML.Somet;
			
			_KehoachinEntity.Sokg= _KehoachinEntity_XML.Sokg;
			
			_KehoachinEntity.Ngaytao= _KehoachinEntity_XML.Ngaytao;
			
			_KehoachinEntity.Nguoitao= _KehoachinEntity_XML.Nguoitao;
			
			_KehoachinEntity.Ngaysua= _KehoachinEntity_XML.Ngaysua;
			
			_KehoachinEntity.Nguoisua= _KehoachinEntity_XML.Nguoisua;
			
			_KehoachinEntity.Sometdukien= _KehoachinEntity_XML.Sometdukien;
			
			_KehoachinEntity.Sokgdukien= _KehoachinEntity_XML.Sokgdukien;
			
			_KehoachinEntity.Soluong= _KehoachinEntity_XML.Soluong;
			
			_KehoachinEntity.Sldukien= _KehoachinEntity_XML.Sldukien;
			
			_KehoachinEntity.Tgdukien= _KehoachinEntity_XML.Tgdukien;
									
				
			return _KehoachinEntity;
		}	
		
		public String InsertV2(KehoachinEntity _KehoachinEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new KehoachinManagerBase()).Insert(_KehoachinEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_KehoachinEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Solenhsx,_KehoachinEntity.Solenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_KehoachinEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_KehoachinEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KehoachinEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KehoachinEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaychay,_KehoachinEntity.Ngaychay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KehoachinEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_KehoachinEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_KehoachinEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KehoachinEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KehoachinEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KehoachinEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KehoachinEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometdukien,_KehoachinEntity.Sometdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgdukien,_KehoachinEntity.Sokgdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_KehoachinEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sldukien,_KehoachinEntity.Sldukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tgdukien,_KehoachinEntity.Tgdukien);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(KehoachinEntity _KehoachinEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new KehoachinManagerBase()).Update(_KehoachinEntity);
			r.SetField(Field_Id,_KehoachinEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Solenhsx,_KehoachinEntity.Solenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_KehoachinEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_KehoachinEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KehoachinEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KehoachinEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaychay,_KehoachinEntity.Ngaychay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KehoachinEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_KehoachinEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_KehoachinEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KehoachinEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KehoachinEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KehoachinEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KehoachinEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometdukien,_KehoachinEntity.Sometdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgdukien,_KehoachinEntity.Sokgdukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_KehoachinEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sldukien,_KehoachinEntity.Sldukien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tgdukien,_KehoachinEntity.Tgdukien);
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

		public KehoachinEntity Insert(KehoachinEntity KehoachinEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(KehoachinEntity, true);
			}
			return KehoachinEntity;
		}

		public KehoachinEntity Insert(System.Int64  Id, System.String  Solenhsx, System.DateTime  Ngaydat, System.DateTime  Ngaygiao, System.String  Masanpham, System.String  Mamay, System.DateTime  Ngaychay, System.Int32  Ca, System.Decimal  Somet, System.Decimal  Sokg, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.Decimal  Sometdukien, System.Decimal  Sokgdukien, System.Int32  Soluong, System.Int32  Sldukien, System.Int32  Tgdukien)
		{
			KehoachinEntity _KehoachinEntity = new KehoachinEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KehoachinEntity.Id = Id;
				
				_KehoachinEntity.Solenhsx = Solenhsx;
				
				_KehoachinEntity.Ngaydat = Ngaydat;
				
				_KehoachinEntity.Ngaygiao = Ngaygiao;
				
				_KehoachinEntity.Masanpham = Masanpham;
				
				_KehoachinEntity.Mamay = Mamay;
				
				_KehoachinEntity.Ngaychay = Ngaychay;
				
				_KehoachinEntity.Ca = Ca;
				
				_KehoachinEntity.Somet = Somet;
				
				_KehoachinEntity.Sokg = Sokg;
				
				_KehoachinEntity.Ngaytao = Ngaytao;
				
				_KehoachinEntity.Nguoitao = Nguoitao;
				
				_KehoachinEntity.Ngaysua = Ngaysua;
				
				_KehoachinEntity.Nguoisua = Nguoisua;
				
				_KehoachinEntity.Sometdukien = Sometdukien;
				
				_KehoachinEntity.Sokgdukien = Sokgdukien;
				
				_KehoachinEntity.Soluong = Soluong;
				
				_KehoachinEntity.Sldukien = Sldukien;
				
				_KehoachinEntity.Tgdukien = Tgdukien;
					
					
				adapter.SaveEntity(_KehoachinEntity, true);
			}
			return _KehoachinEntity;
		}

		public KehoachinEntity Insert(System.String Solenhsx, System.DateTime Ngaydat, System.DateTime Ngaygiao, System.String Masanpham, System.String Mamay, System.DateTime Ngaychay, System.Int32 Ca, System.Decimal Somet, System.Decimal Sokg, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Sometdukien, System.Decimal Sokgdukien, System.Int32 Soluong, System.Int32 Sldukien, System.Int32 Tgdukien)//ko co mahieu
		{
			KehoachinEntity _KehoachinEntity = new KehoachinEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_KehoachinEntity.Solenhsx = Solenhsx;
				
				_KehoachinEntity.Ngaydat = Ngaydat;
				
				_KehoachinEntity.Ngaygiao = Ngaygiao;
				
				_KehoachinEntity.Masanpham = Masanpham;
				
				_KehoachinEntity.Mamay = Mamay;
				
				_KehoachinEntity.Ngaychay = Ngaychay;
				
				_KehoachinEntity.Ca = Ca;
				
				_KehoachinEntity.Somet = Somet;
				
				_KehoachinEntity.Sokg = Sokg;
				
				_KehoachinEntity.Ngaytao = Ngaytao;
				
				_KehoachinEntity.Nguoitao = Nguoitao;
				
				_KehoachinEntity.Ngaysua = Ngaysua;
				
				_KehoachinEntity.Nguoisua = Nguoisua;
				
				_KehoachinEntity.Sometdukien = Sometdukien;
				
				_KehoachinEntity.Sokgdukien = Sokgdukien;
				
				_KehoachinEntity.Soluong = Soluong;
				
				_KehoachinEntity.Sldukien = Sldukien;
				
				_KehoachinEntity.Tgdukien = Tgdukien;
					

				adapter.SaveEntity(_KehoachinEntity, true);
			}
			return _KehoachinEntity;
		}

		public bool Update(KehoachinEntity _KehoachinEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(KehoachinFields.Id == _KehoachinEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KehoachinEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KehoachinEntity _KehoachinEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KehoachinEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Solenhsx, System.DateTime Ngaydat, System.DateTime Ngaygiao, System.String Masanpham, System.String Mamay, System.DateTime Ngaychay, System.Int32 Ca, System.Decimal Somet, System.Decimal Sokg, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Sometdukien, System.Decimal Sokgdukien, System.Int32 Soluong, System.Int32 Sldukien, System.Int32 Tgdukien)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KehoachinEntity _KehoachinEntity = new KehoachinEntity(Id);
				if (adapter.FetchEntity(_KehoachinEntity))
				{
				
					
					
					_KehoachinEntity.Solenhsx = Solenhsx;
					
					_KehoachinEntity.Ngaydat = Ngaydat;
					
					_KehoachinEntity.Ngaygiao = Ngaygiao;
					
					_KehoachinEntity.Masanpham = Masanpham;
					
					_KehoachinEntity.Mamay = Mamay;
					
					_KehoachinEntity.Ngaychay = Ngaychay;
					
					_KehoachinEntity.Ca = Ca;
					
					_KehoachinEntity.Somet = Somet;
					
					_KehoachinEntity.Sokg = Sokg;
					
					_KehoachinEntity.Ngaytao = Ngaytao;
					
					_KehoachinEntity.Nguoitao = Nguoitao;
					
					_KehoachinEntity.Ngaysua = Ngaysua;
					
					_KehoachinEntity.Nguoisua = Nguoisua;
					
					_KehoachinEntity.Sometdukien = Sometdukien;
					
					_KehoachinEntity.Sokgdukien = Sokgdukien;
					
					_KehoachinEntity.Soluong = Soluong;
					
					_KehoachinEntity.Sldukien = Sldukien;
					
					_KehoachinEntity.Tgdukien = Tgdukien;
						

					adapter.SaveEntity(_KehoachinEntity, true);
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
				KehoachinEntity _KehoachinEntity = new KehoachinEntity(Id);
				if (adapter.FetchEntity(_KehoachinEntity))
				{
					adapter.DeleteEntity(_KehoachinEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KehoachinEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySolenhsx(System.String Solenhsx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaydat(System.DateTime Ngaydat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaygiao(System.DateTime Ngaygiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaychay(System.DateTime Ngaychay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ngaychay == Ngaychay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCa(System.Int32 Ca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomet(System.Decimal Somet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokg(System.Decimal Sokg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySometdukien(System.Decimal Sometdukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Sometdukien == Sometdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokgdukien(System.Decimal Sokgdukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Sokgdukien == Sokgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluong(System.Int32 Soluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySldukien(System.Int32 Sldukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Sldukien == Sldukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTgdukien(System.Int32 Tgdukien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Tgdukien == Tgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KehoachinEntity", filter);
			}
			return toReturn;
		}		
			
		
		public KehoachinEntity SelectOne(System.Int64 Id)
		{
			KehoachinEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KehoachinEntity _KehoachinEntity = new KehoachinEntity(Id);
				if (adapter.FetchEntity(_KehoachinEntity))
				{
					toReturn = _KehoachinEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _KehoachinCollection = new EntityCollection( new KehoachinEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, null, 0, null);
			}
			return _KehoachinCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySolenhsx(System.String Solenhsx)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectBySolenhsxRDT(System.String Solenhsx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Solenhsx == Solenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaydat(System.DateTime Ngaydat)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaydatRDT(System.DateTime Ngaydat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaygiao(System.DateTime Ngaygiao)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaygiaoRDT(System.DateTime Ngaygiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaychay(System.DateTime Ngaychay)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ngaychay == Ngaychay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaychayRDT(System.DateTime Ngaychay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ngaychay == Ngaychay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCa(System.Int32 Ca)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectByCaRDT(System.Int32 Ca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomet(System.Decimal Somet)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectBySometRDT(System.Decimal Somet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokg(System.Decimal Sokg)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgRDT(System.Decimal Sokg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySometdukien(System.Decimal Sometdukien)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Sometdukien == Sometdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectBySometdukienRDT(System.Decimal Sometdukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Sometdukien == Sometdukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokgdukien(System.Decimal Sokgdukien)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Sokgdukien == Sokgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgdukienRDT(System.Decimal Sokgdukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Sokgdukien == Sokgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluong(System.Int32 Soluong)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongRDT(System.Int32 Soluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySldukien(System.Int32 Sldukien)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Sldukien == Sldukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectBySldukienRDT(System.Int32 Sldukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Sldukien == Sldukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTgdukien(System.Int32 Tgdukien)
		{
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Tgdukien == Tgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KehoachinCollection, filter, 0, null);
			}
			return _KehoachinCollection;
		}
		// Return DataTable
		public DataTable SelectByTgdukienRDT(System.Int32 Tgdukien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KehoachinCollection = new EntityCollection(new KehoachinEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KehoachinFields.Tgdukien == Tgdukien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KehoachinCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(KehoachinFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
