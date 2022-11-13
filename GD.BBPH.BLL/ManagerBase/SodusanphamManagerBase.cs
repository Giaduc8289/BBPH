


/*
'===============================================================================
'  GD.BBPH.BL.SodusanphamManagerBase
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
	public class SodusanphamManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngaykiemke="Ngaykiemke";				
		
		public const String Field_Makho="Makho";				
		
		public const String Field_Tenkho="Tenkho";				
		
		public const String Field_Masanpham="Masanpham";				
		
		public const String Field_Tensanpham="Tensanpham";				
		
		public const String Field_Somet="Somet";				
		
		public const String Field_Soluong="Soluong";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Sokg="Sokg";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SodusanphamManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Ngaykiemke,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Makho,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkho,typeof(System.String));
			
			dt.Columns.Add(Field_Masanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Tensanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Somet,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Soluong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Sokg,typeof(System.Decimal));
									
		            
			return dt;			
		}
		public DataRow Convert(SodusanphamEntity _SodusanphamEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_SodusanphamEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngaykiemke]=_SodusanphamEntity.Ngaykiemke;
			}
			catch { }
			
			try
			{
				r[Field_Makho]=_SodusanphamEntity.Makho;
			}
			catch { }
			
			try
			{
				r[Field_Tenkho]=_SodusanphamEntity.Tenkho;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_SodusanphamEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Tensanpham]=_SodusanphamEntity.Tensanpham;
			}
			catch { }
			
			try
			{
				r[Field_Somet]=_SodusanphamEntity.Somet;
			}
			catch { }
			
			try
			{
				r[Field_Soluong]=_SodusanphamEntity.Soluong;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_SodusanphamEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_SodusanphamEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_SodusanphamEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_SodusanphamEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Sokg]=_SodusanphamEntity.Sokg;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public SodusanphamEntity Convert(DataRow r)
		{	
			
			SodusanphamEntity _SodusanphamEntity=new SodusanphamEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_SodusanphamEntity.Ngaykiemke= System.DateTime.Parse(r[Field_Ngaykiemke].ToString());						
			}
			catch { }
			
			try
			{
				_SodusanphamEntity.Makho= r[Field_Makho].ToString();						
			}
			catch { }
			
			try
			{
				_SodusanphamEntity.Tenkho= r[Field_Tenkho].ToString();						
			}
			catch { }
			
			try
			{
				_SodusanphamEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_SodusanphamEntity.Tensanpham= r[Field_Tensanpham].ToString();						
			}
			catch { }
			
			try
			{
				_SodusanphamEntity.Somet= System.Decimal.Parse(r[Field_Somet].ToString());						
			}
			catch { }
			
			try
			{
				_SodusanphamEntity.Soluong= System.Decimal.Parse(r[Field_Soluong].ToString());						
			}
			catch { }
			
			try
			{
				_SodusanphamEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_SodusanphamEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_SodusanphamEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_SodusanphamEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_SodusanphamEntity.Sokg= System.Decimal.Parse(r[Field_Sokg].ToString());						
			}
			catch { }
									
									
			return _SodusanphamEntity;
		}			
		
		public SodusanphamEntity Convert_Entity(SodusanphamEntity _SodusanphamEntity,SodusanphamEntity _SodusanphamEntity_XML)
		{	
			
			
			_SodusanphamEntity.Id= _SodusanphamEntity_XML.Id;
			
			_SodusanphamEntity.Ngaykiemke= _SodusanphamEntity_XML.Ngaykiemke;
			
			_SodusanphamEntity.Makho= _SodusanphamEntity_XML.Makho;
			
			_SodusanphamEntity.Tenkho= _SodusanphamEntity_XML.Tenkho;
			
			_SodusanphamEntity.Masanpham= _SodusanphamEntity_XML.Masanpham;
			
			_SodusanphamEntity.Tensanpham= _SodusanphamEntity_XML.Tensanpham;
			
			_SodusanphamEntity.Somet= _SodusanphamEntity_XML.Somet;
			
			_SodusanphamEntity.Soluong= _SodusanphamEntity_XML.Soluong;
			
			_SodusanphamEntity.Ngaytao= _SodusanphamEntity_XML.Ngaytao;
			
			_SodusanphamEntity.Nguoitao= _SodusanphamEntity_XML.Nguoitao;
			
			_SodusanphamEntity.Ngaysua= _SodusanphamEntity_XML.Ngaysua;
			
			_SodusanphamEntity.Nguoisua= _SodusanphamEntity_XML.Nguoisua;
			
			_SodusanphamEntity.Sokg= _SodusanphamEntity_XML.Sokg;
									
				
			return _SodusanphamEntity;
		}	
		
		public String InsertV2(SodusanphamEntity _SodusanphamEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new SodusanphamManagerBase()).Insert(_SodusanphamEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_SodusanphamEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngaykiemke,_SodusanphamEntity.Ngaykiemke);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_SodusanphamEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_SodusanphamEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_SodusanphamEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_SodusanphamEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_SodusanphamEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_SodusanphamEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_SodusanphamEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_SodusanphamEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_SodusanphamEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_SodusanphamEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_SodusanphamEntity.Sokg);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(SodusanphamEntity _SodusanphamEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new SodusanphamManagerBase()).Update(_SodusanphamEntity);
			r.SetField(Field_Id,_SodusanphamEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngaykiemke,_SodusanphamEntity.Ngaykiemke);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_SodusanphamEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_SodusanphamEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_SodusanphamEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_SodusanphamEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_SodusanphamEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluong,_SodusanphamEntity.Soluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_SodusanphamEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_SodusanphamEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_SodusanphamEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_SodusanphamEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_SodusanphamEntity.Sokg);
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

		public SodusanphamEntity Insert(SodusanphamEntity SodusanphamEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(SodusanphamEntity, true);
			}
			return SodusanphamEntity;
		}

		public SodusanphamEntity Insert(System.Int64  Id, System.DateTime  Ngaykiemke, System.String  Makho, System.String  Tenkho, System.String  Masanpham, System.String  Tensanpham, System.Decimal  Somet, System.Decimal  Soluong, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.Decimal  Sokg)
		{
			SodusanphamEntity _SodusanphamEntity = new SodusanphamEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_SodusanphamEntity.Id = Id;
				
				_SodusanphamEntity.Ngaykiemke = Ngaykiemke;
				
				_SodusanphamEntity.Makho = Makho;
				
				_SodusanphamEntity.Tenkho = Tenkho;
				
				_SodusanphamEntity.Masanpham = Masanpham;
				
				_SodusanphamEntity.Tensanpham = Tensanpham;
				
				_SodusanphamEntity.Somet = Somet;
				
				_SodusanphamEntity.Soluong = Soluong;
				
				_SodusanphamEntity.Ngaytao = Ngaytao;
				
				_SodusanphamEntity.Nguoitao = Nguoitao;
				
				_SodusanphamEntity.Ngaysua = Ngaysua;
				
				_SodusanphamEntity.Nguoisua = Nguoisua;
				
				_SodusanphamEntity.Sokg = Sokg;
					
					
				adapter.SaveEntity(_SodusanphamEntity, true);
			}
			return _SodusanphamEntity;
		}

		public SodusanphamEntity Insert(System.DateTime Ngaykiemke, System.String Makho, System.String Tenkho, System.String Masanpham, System.String Tensanpham, System.Decimal Somet, System.Decimal Soluong, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Sokg)//ko co mahieu
		{
			SodusanphamEntity _SodusanphamEntity = new SodusanphamEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_SodusanphamEntity.Ngaykiemke = Ngaykiemke;
				
				_SodusanphamEntity.Makho = Makho;
				
				_SodusanphamEntity.Tenkho = Tenkho;
				
				_SodusanphamEntity.Masanpham = Masanpham;
				
				_SodusanphamEntity.Tensanpham = Tensanpham;
				
				_SodusanphamEntity.Somet = Somet;
				
				_SodusanphamEntity.Soluong = Soluong;
				
				_SodusanphamEntity.Ngaytao = Ngaytao;
				
				_SodusanphamEntity.Nguoitao = Nguoitao;
				
				_SodusanphamEntity.Ngaysua = Ngaysua;
				
				_SodusanphamEntity.Nguoisua = Nguoisua;
				
				_SodusanphamEntity.Sokg = Sokg;
					

				adapter.SaveEntity(_SodusanphamEntity, true);
			}
			return _SodusanphamEntity;
		}

		public bool Update(SodusanphamEntity _SodusanphamEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(SodusanphamFields.Id == _SodusanphamEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_SodusanphamEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(SodusanphamEntity _SodusanphamEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_SodusanphamEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngaykiemke, System.String Makho, System.String Tenkho, System.String Masanpham, System.String Tensanpham, System.Decimal Somet, System.Decimal Soluong, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Sokg)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SodusanphamEntity _SodusanphamEntity = new SodusanphamEntity(Id);
				if (adapter.FetchEntity(_SodusanphamEntity))
				{
				
					
					
					_SodusanphamEntity.Ngaykiemke = Ngaykiemke;
					
					_SodusanphamEntity.Makho = Makho;
					
					_SodusanphamEntity.Tenkho = Tenkho;
					
					_SodusanphamEntity.Masanpham = Masanpham;
					
					_SodusanphamEntity.Tensanpham = Tensanpham;
					
					_SodusanphamEntity.Somet = Somet;
					
					_SodusanphamEntity.Soluong = Soluong;
					
					_SodusanphamEntity.Ngaytao = Ngaytao;
					
					_SodusanphamEntity.Nguoitao = Nguoitao;
					
					_SodusanphamEntity.Ngaysua = Ngaysua;
					
					_SodusanphamEntity.Nguoisua = Nguoisua;
					
					_SodusanphamEntity.Sokg = Sokg;
						

					adapter.SaveEntity(_SodusanphamEntity, true);
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
				SodusanphamEntity _SodusanphamEntity = new SodusanphamEntity(Id);
				if (adapter.FetchEntity(_SodusanphamEntity))
				{
					adapter.DeleteEntity(_SodusanphamEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("SodusanphamEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodusanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaykiemke(System.DateTime Ngaykiemke)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Ngaykiemke == Ngaykiemke);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodusanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakho(System.String Makho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodusanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkho(System.String Tenkho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodusanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodusanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensanpham(System.String Tensanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodusanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomet(System.Decimal Somet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodusanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluong(System.Decimal Soluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodusanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodusanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodusanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodusanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodusanphamEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokg(System.Decimal Sokg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodusanphamEntity", filter);
			}
			return toReturn;
		}		
			
		
		public SodusanphamEntity SelectOne(System.Int64 Id)
		{
			SodusanphamEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SodusanphamEntity _SodusanphamEntity = new SodusanphamEntity(Id);
				if (adapter.FetchEntity(_SodusanphamEntity))
				{
					toReturn = _SodusanphamEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _SodusanphamCollection = new EntityCollection( new SodusanphamEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodusanphamCollection, null, 0, null);
			}
			return _SodusanphamCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodusanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodusanphamCollection, filter, 0, null);
			}
			return _SodusanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodusanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaykiemke(System.DateTime Ngaykiemke)
		{
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Ngaykiemke == Ngaykiemke);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodusanphamCollection, filter, 0, null);
			}
			return _SodusanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaykiemkeRDT(System.DateTime Ngaykiemke)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Ngaykiemke == Ngaykiemke);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodusanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakho(System.String Makho)
		{
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodusanphamCollection, filter, 0, null);
			}
			return _SodusanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhoRDT(System.String Makho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodusanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkho(System.String Tenkho)
		{
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodusanphamCollection, filter, 0, null);
			}
			return _SodusanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhoRDT(System.String Tenkho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodusanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodusanphamCollection, filter, 0, null);
			}
			return _SodusanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodusanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensanpham(System.String Tensanpham)
		{
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodusanphamCollection, filter, 0, null);
			}
			return _SodusanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByTensanphamRDT(System.String Tensanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodusanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomet(System.Decimal Somet)
		{
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodusanphamCollection, filter, 0, null);
			}
			return _SodusanphamCollection;
		}
		// Return DataTable
		public DataTable SelectBySometRDT(System.Decimal Somet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodusanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluong(System.Decimal Soluong)
		{
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodusanphamCollection, filter, 0, null);
			}
			return _SodusanphamCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongRDT(System.Decimal Soluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Soluong == Soluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodusanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodusanphamCollection, filter, 0, null);
			}
			return _SodusanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodusanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodusanphamCollection, filter, 0, null);
			}
			return _SodusanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodusanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodusanphamCollection, filter, 0, null);
			}
			return _SodusanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodusanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodusanphamCollection, filter, 0, null);
			}
			return _SodusanphamCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodusanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokg(System.Decimal Sokg)
		{
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodusanphamCollection, filter, 0, null);
			}
			return _SodusanphamCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgRDT(System.Decimal Sokg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodusanphamCollection = new EntityCollection(new SodusanphamEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodusanphamFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodusanphamCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(SodusanphamFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
