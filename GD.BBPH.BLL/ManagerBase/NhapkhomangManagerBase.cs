


/*
'===============================================================================
'  GD.BBPH.BL.NhapkhomangManagerBase
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
	public class NhapkhomangManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngaynhap="Ngaynhap";				
		
		public const String Field_Makho="Makho";				
		
		public const String Field_Tenkho="Tenkho";				
		
		public const String Field_Mamang="Mamang";				
		
		public const String Field_Tenmang="Tenmang";				
		
		public const String Field_Somet="Somet";				
		
		public const String Field_Sokg="Sokg";				
		
		public const String Field_Malydo="Malydo";				
		
		public const String Field_Tenlydo="Tenlydo";				
		
		public const String Field_Lenhsx="Lenhsx";				
		
		public const String Field_Sohopdongmua="Sohopdongmua";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NhapkhomangManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Ngaynhap,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Makho,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkho,typeof(System.String));
			
			dt.Columns.Add(Field_Mamang,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmang,typeof(System.String));
			
			dt.Columns.Add(Field_Somet,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokg,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Malydo,typeof(System.String));
			
			dt.Columns.Add(Field_Tenlydo,typeof(System.String));
			
			dt.Columns.Add(Field_Lenhsx,typeof(System.String));
			
			dt.Columns.Add(Field_Sohopdongmua,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(NhapkhomangEntity _NhapkhomangEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_NhapkhomangEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngaynhap]=_NhapkhomangEntity.Ngaynhap;
			}
			catch { }
			
			try
			{
				r[Field_Makho]=_NhapkhomangEntity.Makho;
			}
			catch { }
			
			try
			{
				r[Field_Tenkho]=_NhapkhomangEntity.Tenkho;
			}
			catch { }
			
			try
			{
				r[Field_Mamang]=_NhapkhomangEntity.Mamang;
			}
			catch { }
			
			try
			{
				r[Field_Tenmang]=_NhapkhomangEntity.Tenmang;
			}
			catch { }
			
			try
			{
				r[Field_Somet]=_NhapkhomangEntity.Somet;
			}
			catch { }
			
			try
			{
				r[Field_Sokg]=_NhapkhomangEntity.Sokg;
			}
			catch { }
			
			try
			{
				r[Field_Malydo]=_NhapkhomangEntity.Malydo;
			}
			catch { }
			
			try
			{
				r[Field_Tenlydo]=_NhapkhomangEntity.Tenlydo;
			}
			catch { }
			
			try
			{
				r[Field_Lenhsx]=_NhapkhomangEntity.Lenhsx;
			}
			catch { }
			
			try
			{
				r[Field_Sohopdongmua]=_NhapkhomangEntity.Sohopdongmua;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_NhapkhomangEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_NhapkhomangEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_NhapkhomangEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_NhapkhomangEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public NhapkhomangEntity Convert(DataRow r)
		{	
			
			NhapkhomangEntity _NhapkhomangEntity=new NhapkhomangEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_NhapkhomangEntity.Ngaynhap= System.DateTime.Parse(r[Field_Ngaynhap].ToString());						
			}
			catch { }
			
			try
			{
				_NhapkhomangEntity.Makho= r[Field_Makho].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhomangEntity.Tenkho= r[Field_Tenkho].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhomangEntity.Mamang= r[Field_Mamang].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhomangEntity.Tenmang= r[Field_Tenmang].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhomangEntity.Somet= System.Decimal.Parse(r[Field_Somet].ToString());						
			}
			catch { }
			
			try
			{
				_NhapkhomangEntity.Sokg= System.Decimal.Parse(r[Field_Sokg].ToString());						
			}
			catch { }
			
			try
			{
				_NhapkhomangEntity.Malydo= r[Field_Malydo].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhomangEntity.Tenlydo= r[Field_Tenlydo].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhomangEntity.Lenhsx= r[Field_Lenhsx].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhomangEntity.Sohopdongmua= r[Field_Sohopdongmua].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhomangEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_NhapkhomangEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhomangEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_NhapkhomangEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _NhapkhomangEntity;
		}			
		
		public NhapkhomangEntity Convert_Entity(NhapkhomangEntity _NhapkhomangEntity,NhapkhomangEntity _NhapkhomangEntity_XML)
		{	
			
			
			_NhapkhomangEntity.Id= _NhapkhomangEntity_XML.Id;
			
			_NhapkhomangEntity.Ngaynhap= _NhapkhomangEntity_XML.Ngaynhap;
			
			_NhapkhomangEntity.Makho= _NhapkhomangEntity_XML.Makho;
			
			_NhapkhomangEntity.Tenkho= _NhapkhomangEntity_XML.Tenkho;
			
			_NhapkhomangEntity.Mamang= _NhapkhomangEntity_XML.Mamang;
			
			_NhapkhomangEntity.Tenmang= _NhapkhomangEntity_XML.Tenmang;
			
			_NhapkhomangEntity.Somet= _NhapkhomangEntity_XML.Somet;
			
			_NhapkhomangEntity.Sokg= _NhapkhomangEntity_XML.Sokg;
			
			_NhapkhomangEntity.Malydo= _NhapkhomangEntity_XML.Malydo;
			
			_NhapkhomangEntity.Tenlydo= _NhapkhomangEntity_XML.Tenlydo;
			
			_NhapkhomangEntity.Lenhsx= _NhapkhomangEntity_XML.Lenhsx;
			
			_NhapkhomangEntity.Sohopdongmua= _NhapkhomangEntity_XML.Sohopdongmua;
			
			_NhapkhomangEntity.Ngaytao= _NhapkhomangEntity_XML.Ngaytao;
			
			_NhapkhomangEntity.Nguoitao= _NhapkhomangEntity_XML.Nguoitao;
			
			_NhapkhomangEntity.Ngaysua= _NhapkhomangEntity_XML.Ngaysua;
			
			_NhapkhomangEntity.Nguoisua= _NhapkhomangEntity_XML.Nguoisua;
									
				
			return _NhapkhomangEntity;
		}	
		
		public String InsertV2(NhapkhomangEntity _NhapkhomangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new NhapkhomangManagerBase()).Insert(_NhapkhomangEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_NhapkhomangEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngaynhap,_NhapkhomangEntity.Ngaynhap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_NhapkhomangEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_NhapkhomangEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang,_NhapkhomangEntity.Mamang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang,_NhapkhomangEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_NhapkhomangEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_NhapkhomangEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Malydo,_NhapkhomangEntity.Malydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenlydo,_NhapkhomangEntity.Tenlydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhsx,_NhapkhomangEntity.Lenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohopdongmua,_NhapkhomangEntity.Sohopdongmua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_NhapkhomangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_NhapkhomangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_NhapkhomangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_NhapkhomangEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(NhapkhomangEntity _NhapkhomangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new NhapkhomangManagerBase()).Update(_NhapkhomangEntity);
			r.SetField(Field_Id,_NhapkhomangEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngaynhap,_NhapkhomangEntity.Ngaynhap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_NhapkhomangEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_NhapkhomangEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang,_NhapkhomangEntity.Mamang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang,_NhapkhomangEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_NhapkhomangEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_NhapkhomangEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Malydo,_NhapkhomangEntity.Malydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenlydo,_NhapkhomangEntity.Tenlydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhsx,_NhapkhomangEntity.Lenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohopdongmua,_NhapkhomangEntity.Sohopdongmua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_NhapkhomangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_NhapkhomangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_NhapkhomangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_NhapkhomangEntity.Nguoisua);
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

		public NhapkhomangEntity Insert(NhapkhomangEntity NhapkhomangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(NhapkhomangEntity, true);
			}
			return NhapkhomangEntity;
		}

		public NhapkhomangEntity Insert(System.Int64  Id, System.DateTime  Ngaynhap, System.String  Makho, System.String  Tenkho, System.String  Mamang, System.String  Tenmang, System.Decimal  Somet, System.Decimal  Sokg, System.String  Malydo, System.String  Tenlydo, System.String  Lenhsx, System.String  Sohopdongmua, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			NhapkhomangEntity _NhapkhomangEntity = new NhapkhomangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NhapkhomangEntity.Id = Id;
				
				_NhapkhomangEntity.Ngaynhap = Ngaynhap;
				
				_NhapkhomangEntity.Makho = Makho;
				
				_NhapkhomangEntity.Tenkho = Tenkho;
				
				_NhapkhomangEntity.Mamang = Mamang;
				
				_NhapkhomangEntity.Tenmang = Tenmang;
				
				_NhapkhomangEntity.Somet = Somet;
				
				_NhapkhomangEntity.Sokg = Sokg;
				
				_NhapkhomangEntity.Malydo = Malydo;
				
				_NhapkhomangEntity.Tenlydo = Tenlydo;
				
				_NhapkhomangEntity.Lenhsx = Lenhsx;
				
				_NhapkhomangEntity.Sohopdongmua = Sohopdongmua;
				
				_NhapkhomangEntity.Ngaytao = Ngaytao;
				
				_NhapkhomangEntity.Nguoitao = Nguoitao;
				
				_NhapkhomangEntity.Ngaysua = Ngaysua;
				
				_NhapkhomangEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_NhapkhomangEntity, true);
			}
			return _NhapkhomangEntity;
		}

		public NhapkhomangEntity Insert(System.DateTime Ngaynhap, System.String Makho, System.String Tenkho, System.String Mamang, System.String Tenmang, System.Decimal Somet, System.Decimal Sokg, System.String Malydo, System.String Tenlydo, System.String Lenhsx, System.String Sohopdongmua, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			NhapkhomangEntity _NhapkhomangEntity = new NhapkhomangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_NhapkhomangEntity.Ngaynhap = Ngaynhap;
				
				_NhapkhomangEntity.Makho = Makho;
				
				_NhapkhomangEntity.Tenkho = Tenkho;
				
				_NhapkhomangEntity.Mamang = Mamang;
				
				_NhapkhomangEntity.Tenmang = Tenmang;
				
				_NhapkhomangEntity.Somet = Somet;
				
				_NhapkhomangEntity.Sokg = Sokg;
				
				_NhapkhomangEntity.Malydo = Malydo;
				
				_NhapkhomangEntity.Tenlydo = Tenlydo;
				
				_NhapkhomangEntity.Lenhsx = Lenhsx;
				
				_NhapkhomangEntity.Sohopdongmua = Sohopdongmua;
				
				_NhapkhomangEntity.Ngaytao = Ngaytao;
				
				_NhapkhomangEntity.Nguoitao = Nguoitao;
				
				_NhapkhomangEntity.Ngaysua = Ngaysua;
				
				_NhapkhomangEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_NhapkhomangEntity, true);
			}
			return _NhapkhomangEntity;
		}

		public bool Update(NhapkhomangEntity _NhapkhomangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(NhapkhomangFields.Id == _NhapkhomangEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_NhapkhomangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(NhapkhomangEntity _NhapkhomangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_NhapkhomangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngaynhap, System.String Makho, System.String Tenkho, System.String Mamang, System.String Tenmang, System.Decimal Somet, System.Decimal Sokg, System.String Malydo, System.String Tenlydo, System.String Lenhsx, System.String Sohopdongmua, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NhapkhomangEntity _NhapkhomangEntity = new NhapkhomangEntity(Id);
				if (adapter.FetchEntity(_NhapkhomangEntity))
				{
				
					
					
					_NhapkhomangEntity.Ngaynhap = Ngaynhap;
					
					_NhapkhomangEntity.Makho = Makho;
					
					_NhapkhomangEntity.Tenkho = Tenkho;
					
					_NhapkhomangEntity.Mamang = Mamang;
					
					_NhapkhomangEntity.Tenmang = Tenmang;
					
					_NhapkhomangEntity.Somet = Somet;
					
					_NhapkhomangEntity.Sokg = Sokg;
					
					_NhapkhomangEntity.Malydo = Malydo;
					
					_NhapkhomangEntity.Tenlydo = Tenlydo;
					
					_NhapkhomangEntity.Lenhsx = Lenhsx;
					
					_NhapkhomangEntity.Sohopdongmua = Sohopdongmua;
					
					_NhapkhomangEntity.Ngaytao = Ngaytao;
					
					_NhapkhomangEntity.Nguoitao = Nguoitao;
					
					_NhapkhomangEntity.Ngaysua = Ngaysua;
					
					_NhapkhomangEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_NhapkhomangEntity, true);
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
				NhapkhomangEntity _NhapkhomangEntity = new NhapkhomangEntity(Id);
				if (adapter.FetchEntity(_NhapkhomangEntity))
				{
					adapter.DeleteEntity(_NhapkhomangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("NhapkhomangEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaynhap(System.DateTime Ngaynhap)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Ngaynhap == Ngaynhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakho(System.String Makho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkho(System.String Tenkho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamang(System.String Mamang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmang(System.String Tenmang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomet(System.Decimal Somet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokg(System.Decimal Sokg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMalydo(System.String Malydo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenlydo(System.String Tenlydo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLenhsx(System.String Lenhsx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Lenhsx == Lenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySohopdongmua(System.String Sohopdongmua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Sohopdongmua == Sohopdongmua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhomangEntity", filter);
			}
			return toReturn;
		}		
			
		
		public NhapkhomangEntity SelectOne(System.Int64 Id)
		{
			NhapkhomangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NhapkhomangEntity _NhapkhomangEntity = new NhapkhomangEntity(Id);
				if (adapter.FetchEntity(_NhapkhomangEntity))
				{
					toReturn = _NhapkhomangEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection( new NhapkhomangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, null, 0, null);
			}
			return _NhapkhomangCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaynhap(System.DateTime Ngaynhap)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Ngaynhap == Ngaynhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaynhapRDT(System.DateTime Ngaynhap)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Ngaynhap == Ngaynhap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakho(System.String Makho)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhoRDT(System.String Makho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkho(System.String Tenkho)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhoRDT(System.String Tenkho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamang(System.String Mamang)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByMamangRDT(System.String Mamang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmang(System.String Tenmang)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmangRDT(System.String Tenmang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomet(System.Decimal Somet)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectBySometRDT(System.Decimal Somet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokg(System.Decimal Sokg)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgRDT(System.Decimal Sokg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMalydo(System.String Malydo)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByMalydoRDT(System.String Malydo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenlydo(System.String Tenlydo)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenlydoRDT(System.String Tenlydo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLenhsx(System.String Lenhsx)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Lenhsx == Lenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByLenhsxRDT(System.String Lenhsx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Lenhsx == Lenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySohopdongmua(System.String Sohopdongmua)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Sohopdongmua == Sohopdongmua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectBySohopdongmuaRDT(System.String Sohopdongmua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Sohopdongmua == Sohopdongmua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhomangCollection, filter, 0, null);
			}
			return _NhapkhomangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhomangCollection = new EntityCollection(new NhapkhomangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhomangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhomangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(NhapkhomangFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
