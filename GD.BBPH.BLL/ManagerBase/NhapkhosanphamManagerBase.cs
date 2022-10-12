


/*
'===============================================================================
'  GD.BBPH.BL.NhapkhosanphamManagerBase
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
	public class NhapkhosanphamManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngaynhap="Ngaynhap";				
		
		public const String Field_Makho="Makho";				
		
		public const String Field_Tenkho="Tenkho";				
		
		public const String Field_Masanpham="Masanpham";				
		
		public const String Field_Tensanpham="Tensanpham";				
		
		public const String Field_Soluong="Soluong";				
		
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
		public NhapkhosanphamManagerBase()
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
			
			dt.Columns.Add(Field_Masanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Tensanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Soluong,typeof(System.Decimal));
			
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
		public DataRow Convert(NhapkhosanphamEntity _NhapkhosanphamEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_NhapkhosanphamEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngaynhap]=_NhapkhosanphamEntity.Ngaynhap;
			}
			catch { }
			
			try
			{
				r[Field_Makho]=_NhapkhosanphamEntity.Makho;
			}
			catch { }
			
			try
			{
				r[Field_Tenkho]=_NhapkhosanphamEntity.Tenkho;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_NhapkhosanphamEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Tensanpham]=_NhapkhosanphamEntity.Tensanpham;
			}
			catch { }
			
			try
			{
				r[Field_Soluong]=_NhapkhosanphamEntity.Soluong;
			}
			catch { }
			
			try
			{
				r[Field_Somet]=_NhapkhosanphamEntity.Somet;
			}
			catch { }
			
			try
			{
				r[Field_Sokg]=_NhapkhosanphamEntity.Sokg;
			}
			catch { }
			
			try
			{
				r[Field_Malydo]=_NhapkhosanphamEntity.Malydo;
			}
			catch { }
			
			try
			{
				r[Field_Tenlydo]=_NhapkhosanphamEntity.Tenlydo;
			}
			catch { }
			
			try
			{
				r[Field_Lenhsx]=_NhapkhosanphamEntity.Lenhsx;
			}
			catch { }
			
			try
			{
				r[Field_Sohopdongmua]=_NhapkhosanphamEntity.Sohopdongmua;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_NhapkhosanphamEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_NhapkhosanphamEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_NhapkhosanphamEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_NhapkhosanphamEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public NhapkhosanphamEntity Convert(DataRow r)
		{	
			
			NhapkhosanphamEntity _NhapkhosanphamEntity=new NhapkhosanphamEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_NhapkhosanphamEntity.Ngaynhap= System.DateTime.Parse(r[Field_Ngaynhap].ToString());						
			}
			catch { }
			
			try
			{
				_NhapkhosanphamEntity.Makho= r[Field_Makho].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhosanphamEntity.Tenkho= r[Field_Tenkho].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhosanphamEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhosanphamEntity.Tensanpham= r[Field_Tensanpham].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhosanphamEntity.Soluong= System.Decimal.Parse(r[Field_Soluong].ToString());						
			}
			catch { }
			
			try
			{
				_NhapkhosanphamEntity.Somet= System.Decimal.Parse(r[Field_Somet].ToString());						
			}
			catch { }
			
			try
			{
				_NhapkhosanphamEntity.Sokg= System.Decimal.Parse(r[Field_Sokg].ToString());						
			}
			catch { }
			
			try
			{
				_NhapkhosanphamEntity.Malydo= r[Field_Malydo].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhosanphamEntity.Tenlydo= r[Field_Tenlydo].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhosanphamEntity.Lenhsx= r[Field_Lenhsx].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhosanphamEntity.Sohopdongmua= r[Field_Sohopdongmua].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhosanphamEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_NhapkhosanphamEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_NhapkhosanphamEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_NhapkhosanphamEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _NhapkhosanphamEntity;
		}			
		
		public NhapkhosanphamEntity Convert_Entity(NhapkhosanphamEntity _NhapkhosanphamEntity,NhapkhosanphamEntity _NhapkhosanphamEntity_XML)
		{	
			
			
			_NhapkhosanphamEntity.Id= _NhapkhosanphamEntity_XML.Id;
			
			_NhapkhosanphamEntity.Ngaynhap= _NhapkhosanphamEntity_XML.Ngaynhap;
			
			_NhapkhosanphamEntity.Makho= _NhapkhosanphamEntity_XML.Makho;
			
			_NhapkhosanphamEntity.Tenkho= _NhapkhosanphamEntity_XML.Tenkho;
			
			_NhapkhosanphamEntity.Masanpham= _NhapkhosanphamEntity_XML.Masanpham;
			
			_NhapkhosanphamEntity.Tensanpham= _NhapkhosanphamEntity_XML.Tensanpham;
			
			_NhapkhosanphamEntity.Soluong= _NhapkhosanphamEntity_XML.Soluong;
			
			_NhapkhosanphamEntity.Somet= _NhapkhosanphamEntity_XML.Somet;
			
			_NhapkhosanphamEntity.Sokg= _NhapkhosanphamEntity_XML.Sokg;
			
			_NhapkhosanphamEntity.Malydo= _NhapkhosanphamEntity_XML.Malydo;
			
			_NhapkhosanphamEntity.Tenlydo= _NhapkhosanphamEntity_XML.Tenlydo;
			
			_NhapkhosanphamEntity.Lenhsx= _NhapkhosanphamEntity_XML.Lenhsx;
			
			_NhapkhosanphamEntity.Sohopdongmua= _NhapkhosanphamEntity_XML.Sohopdongmua;
			
			_NhapkhosanphamEntity.Ngaytao= _NhapkhosanphamEntity_XML.Ngaytao;
			
			_NhapkhosanphamEntity.Nguoitao= _NhapkhosanphamEntity_XML.Nguoitao;
			
			_NhapkhosanphamEntity.Ngaysua= _NhapkhosanphamEntity_XML.Ngaysua;
			
			_NhapkhosanphamEntity.Nguoisua= _NhapkhosanphamEntity_XML.Nguoisua;
									
				
			return _NhapkhosanphamEntity;
		}	
		
		public String InsertV2(NhapkhosanphamEntity _NhapkhosanphamEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new NhapkhosanphamManagerBase()).Insert(_NhapkhosanphamEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_NhapkhosanphamEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngaynhap,_NhapkhosanphamEntity.Ngaynhap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_NhapkhosanphamEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_NhapkhosanphamEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_NhapkhosanphamEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_NhapkhosanphamEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_NhapkhosanphamEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_NhapkhosanphamEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_NhapkhosanphamEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Malydo,_NhapkhosanphamEntity.Malydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenlydo,_NhapkhosanphamEntity.Tenlydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhsx,_NhapkhosanphamEntity.Lenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohopdongmua,_NhapkhosanphamEntity.Sohopdongmua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_NhapkhosanphamEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_NhapkhosanphamEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_NhapkhosanphamEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_NhapkhosanphamEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(NhapkhosanphamEntity _NhapkhosanphamEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new NhapkhosanphamManagerBase()).Update(_NhapkhosanphamEntity);
			r.SetField(Field_Id,_NhapkhosanphamEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngaynhap,_NhapkhosanphamEntity.Ngaynhap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_NhapkhosanphamEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_NhapkhosanphamEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_NhapkhosanphamEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_NhapkhosanphamEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_NhapkhosanphamEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_NhapkhosanphamEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_NhapkhosanphamEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Malydo,_NhapkhosanphamEntity.Malydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenlydo,_NhapkhosanphamEntity.Tenlydo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhsx,_NhapkhosanphamEntity.Lenhsx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohopdongmua,_NhapkhosanphamEntity.Sohopdongmua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_NhapkhosanphamEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_NhapkhosanphamEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_NhapkhosanphamEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_NhapkhosanphamEntity.Nguoisua);
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

		public NhapkhosanphamEntity Insert(NhapkhosanphamEntity NhapkhosanphamEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(NhapkhosanphamEntity, true);
			}
			return NhapkhosanphamEntity;
		}

		public NhapkhosanphamEntity Insert(System.Int64  Id, System.DateTime  Ngaynhap, System.String  Makho, System.String  Tenkho, System.String  Masanpham, System.String  Tensanpham, System.Decimal  Soluong, System.Decimal  Somet, System.Decimal  Sokg, System.String  Malydo, System.String  Tenlydo, System.String  Lenhsx, System.String  Sohopdongmua, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			NhapkhosanphamEntity _NhapkhosanphamEntity = new NhapkhosanphamEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NhapkhosanphamEntity.Id = Id;
				
				_NhapkhosanphamEntity.Ngaynhap = Ngaynhap;
				
				_NhapkhosanphamEntity.Makho = Makho;
				
				_NhapkhosanphamEntity.Tenkho = Tenkho;
				
				_NhapkhosanphamEntity.Masanpham = Masanpham;
				
				_NhapkhosanphamEntity.Tensanpham = Tensanpham;
				
				_NhapkhosanphamEntity.Soluong = Soluong;
				
				_NhapkhosanphamEntity.Somet = Somet;
				
				_NhapkhosanphamEntity.Sokg = Sokg;
				
				_NhapkhosanphamEntity.Malydo = Malydo;
				
				_NhapkhosanphamEntity.Tenlydo = Tenlydo;
				
				_NhapkhosanphamEntity.Lenhsx = Lenhsx;
				
				_NhapkhosanphamEntity.Sohopdongmua = Sohopdongmua;
				
				_NhapkhosanphamEntity.Ngaytao = Ngaytao;
				
				_NhapkhosanphamEntity.Nguoitao = Nguoitao;
				
				_NhapkhosanphamEntity.Ngaysua = Ngaysua;
				
				_NhapkhosanphamEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_NhapkhosanphamEntity, true);
			}
			return _NhapkhosanphamEntity;
		}

		public NhapkhosanphamEntity Insert(System.DateTime Ngaynhap, System.String Makho, System.String Tenkho, System.String Masanpham, System.String Tensanpham, System.Decimal Soluong, System.Decimal Somet, System.Decimal Sokg, System.String Malydo, System.String Tenlydo, System.String Lenhsx, System.String Sohopdongmua, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			NhapkhosanphamEntity _NhapkhosanphamEntity = new NhapkhosanphamEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_NhapkhosanphamEntity.Ngaynhap = Ngaynhap;
				
				_NhapkhosanphamEntity.Makho = Makho;
				
				_NhapkhosanphamEntity.Tenkho = Tenkho;
				
				_NhapkhosanphamEntity.Masanpham = Masanpham;
				
				_NhapkhosanphamEntity.Tensanpham = Tensanpham;
				
				_NhapkhosanphamEntity.Soluong = Soluong;
				
				_NhapkhosanphamEntity.Somet = Somet;
				
				_NhapkhosanphamEntity.Sokg = Sokg;
				
				_NhapkhosanphamEntity.Malydo = Malydo;
				
				_NhapkhosanphamEntity.Tenlydo = Tenlydo;
				
				_NhapkhosanphamEntity.Lenhsx = Lenhsx;
				
				_NhapkhosanphamEntity.Sohopdongmua = Sohopdongmua;
				
				_NhapkhosanphamEntity.Ngaytao = Ngaytao;
				
				_NhapkhosanphamEntity.Nguoitao = Nguoitao;
				
				_NhapkhosanphamEntity.Ngaysua = Ngaysua;
				
				_NhapkhosanphamEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_NhapkhosanphamEntity, true);
			}
			return _NhapkhosanphamEntity;
		}

		public bool Update(NhapkhosanphamEntity _NhapkhosanphamEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(NhapkhosanphamFields.Id == _NhapkhosanphamEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_NhapkhosanphamEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(NhapkhosanphamEntity _NhapkhosanphamEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_NhapkhosanphamEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngaynhap, System.String Makho, System.String Tenkho, System.String Masanpham, System.String Tensanpham, System.Decimal Soluong, System.Decimal Somet, System.Decimal Sokg, System.String Malydo, System.String Tenlydo, System.String Lenhsx, System.String Sohopdongmua, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NhapkhosanphamEntity _NhapkhosanphamEntity = new NhapkhosanphamEntity(Id);
				if (adapter.FetchEntity(_NhapkhosanphamEntity))
				{
				
					
					
					_NhapkhosanphamEntity.Ngaynhap = Ngaynhap;
					
					_NhapkhosanphamEntity.Makho = Makho;
					
					_NhapkhosanphamEntity.Tenkho = Tenkho;
					
					_NhapkhosanphamEntity.Masanpham = Masanpham;
					
					_NhapkhosanphamEntity.Tensanpham = Tensanpham;
					
					_NhapkhosanphamEntity.Soluong = Soluong;
					
					_NhapkhosanphamEntity.Somet = Somet;
					
					_NhapkhosanphamEntity.Sokg = Sokg;
					
					_NhapkhosanphamEntity.Malydo = Malydo;
					
					_NhapkhosanphamEntity.Tenlydo = Tenlydo;
					
					_NhapkhosanphamEntity.Lenhsx = Lenhsx;
					
					_NhapkhosanphamEntity.Sohopdongmua = Sohopdongmua;
					
					_NhapkhosanphamEntity.Ngaytao = Ngaytao;
					
					_NhapkhosanphamEntity.Nguoitao = Nguoitao;
					
					_NhapkhosanphamEntity.Ngaysua = Ngaysua;
					
					_NhapkhosanphamEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_NhapkhosanphamEntity, true);
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
				NhapkhosanphamEntity _NhapkhosanphamEntity = new NhapkhosanphamEntity(Id);
				if (adapter.FetchEntity(_NhapkhosanphamEntity))
				{
					adapter.DeleteEntity(_NhapkhosanphamEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaynhap(System.DateTime Ngaynhap)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Ngaynhap == Ngaynhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakho(System.String Makho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkho(System.String Tenkho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensanpham(System.String Tensanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluong(System.Decimal Soluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomet(System.Decimal Somet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokg(System.Decimal Sokg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMalydo(System.String Malydo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenlydo(System.String Tenlydo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLenhsx(System.String Lenhsx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Lenhsx == Lenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySohopdongmua(System.String Sohopdongmua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Sohopdongmua == Sohopdongmua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NhapkhosanphamEntity", filter);
			}
			return toReturn;
		}		
			
		
		public NhapkhosanphamEntity SelectOne(System.Int64 Id)
		{
			NhapkhosanphamEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NhapkhosanphamEntity _NhapkhosanphamEntity = new NhapkhosanphamEntity(Id);
				if (adapter.FetchEntity(_NhapkhosanphamEntity))
				{
					toReturn = _NhapkhosanphamEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection( new NhapkhosanphamEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, null, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaynhap(System.DateTime Ngaynhap)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Ngaynhap == Ngaynhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaynhapRDT(System.DateTime Ngaynhap)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Ngaynhap == Ngaynhap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakho(System.String Makho)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhoRDT(System.String Makho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkho(System.String Tenkho)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhoRDT(System.String Tenkho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensanpham(System.String Tensanpham)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByTensanphamRDT(System.String Tensanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluong(System.Decimal Soluong)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongRDT(System.Decimal Soluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomet(System.Decimal Somet)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectBySometRDT(System.Decimal Somet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokg(System.Decimal Sokg)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgRDT(System.Decimal Sokg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMalydo(System.String Malydo)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByMalydoRDT(System.String Malydo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Malydo == Malydo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenlydo(System.String Tenlydo)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByTenlydoRDT(System.String Tenlydo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Tenlydo == Tenlydo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLenhsx(System.String Lenhsx)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Lenhsx == Lenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByLenhsxRDT(System.String Lenhsx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Lenhsx == Lenhsx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySohopdongmua(System.String Sohopdongmua)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Sohopdongmua == Sohopdongmua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectBySohopdongmuaRDT(System.String Sohopdongmua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Sohopdongmua == Sohopdongmua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NhapkhosanphamCollection, filter, 0, null);
			}
			return _NhapkhosanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NhapkhosanphamCollection = new EntityCollection(new NhapkhosanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NhapkhosanphamFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NhapkhosanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
