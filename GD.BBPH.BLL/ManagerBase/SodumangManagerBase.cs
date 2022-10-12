


/*
'===============================================================================
'  GD.BBPH.BL.SodumangManagerBase
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
	public class SodumangManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngaykiemke="Ngaykiemke";				
		
		public const String Field_Makho="Makho";				
		
		public const String Field_Tenkho="Tenkho";				
		
		public const String Field_Mamang="Mamang";				
		
		public const String Field_Tenmang="Tenmang";				
		
		public const String Field_Somet="Somet";				
		
		public const String Field_Sokg="Sokg";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SodumangManagerBase()
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
			
			dt.Columns.Add(Field_Mamang,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmang,typeof(System.String));
			
			dt.Columns.Add(Field_Somet,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokg,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(SodumangEntity _SodumangEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_SodumangEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngaykiemke]=_SodumangEntity.Ngaykiemke;
			}
			catch { }
			
			try
			{
				r[Field_Makho]=_SodumangEntity.Makho;
			}
			catch { }
			
			try
			{
				r[Field_Tenkho]=_SodumangEntity.Tenkho;
			}
			catch { }
			
			try
			{
				r[Field_Mamang]=_SodumangEntity.Mamang;
			}
			catch { }
			
			try
			{
				r[Field_Tenmang]=_SodumangEntity.Tenmang;
			}
			catch { }
			
			try
			{
				r[Field_Somet]=_SodumangEntity.Somet;
			}
			catch { }
			
			try
			{
				r[Field_Sokg]=_SodumangEntity.Sokg;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_SodumangEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_SodumangEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_SodumangEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_SodumangEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public SodumangEntity Convert(DataRow r)
		{	
			
			SodumangEntity _SodumangEntity=new SodumangEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_SodumangEntity.Ngaykiemke= System.DateTime.Parse(r[Field_Ngaykiemke].ToString());						
			}
			catch { }
			
			try
			{
				_SodumangEntity.Makho= r[Field_Makho].ToString();						
			}
			catch { }
			
			try
			{
				_SodumangEntity.Tenkho= r[Field_Tenkho].ToString();						
			}
			catch { }
			
			try
			{
				_SodumangEntity.Mamang= r[Field_Mamang].ToString();						
			}
			catch { }
			
			try
			{
				_SodumangEntity.Tenmang= r[Field_Tenmang].ToString();						
			}
			catch { }
			
			try
			{
				_SodumangEntity.Somet= System.Decimal.Parse(r[Field_Somet].ToString());						
			}
			catch { }
			
			try
			{
				_SodumangEntity.Sokg= System.Decimal.Parse(r[Field_Sokg].ToString());						
			}
			catch { }
			
			try
			{
				_SodumangEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_SodumangEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_SodumangEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_SodumangEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _SodumangEntity;
		}			
		
		public SodumangEntity Convert_Entity(SodumangEntity _SodumangEntity,SodumangEntity _SodumangEntity_XML)
		{	
			
			
			_SodumangEntity.Id= _SodumangEntity_XML.Id;
			
			_SodumangEntity.Ngaykiemke= _SodumangEntity_XML.Ngaykiemke;
			
			_SodumangEntity.Makho= _SodumangEntity_XML.Makho;
			
			_SodumangEntity.Tenkho= _SodumangEntity_XML.Tenkho;
			
			_SodumangEntity.Mamang= _SodumangEntity_XML.Mamang;
			
			_SodumangEntity.Tenmang= _SodumangEntity_XML.Tenmang;
			
			_SodumangEntity.Somet= _SodumangEntity_XML.Somet;
			
			_SodumangEntity.Sokg= _SodumangEntity_XML.Sokg;
			
			_SodumangEntity.Ngaytao= _SodumangEntity_XML.Ngaytao;
			
			_SodumangEntity.Nguoitao= _SodumangEntity_XML.Nguoitao;
			
			_SodumangEntity.Ngaysua= _SodumangEntity_XML.Ngaysua;
			
			_SodumangEntity.Nguoisua= _SodumangEntity_XML.Nguoisua;
									
				
			return _SodumangEntity;
		}	
		
		public String InsertV2(SodumangEntity _SodumangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new SodumangManagerBase()).Insert(_SodumangEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_SodumangEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngaykiemke,_SodumangEntity.Ngaykiemke);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_SodumangEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_SodumangEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang,_SodumangEntity.Mamang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang,_SodumangEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_SodumangEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_SodumangEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_SodumangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_SodumangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_SodumangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_SodumangEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(SodumangEntity _SodumangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new SodumangManagerBase()).Update(_SodumangEntity);
			r.SetField(Field_Id,_SodumangEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngaykiemke,_SodumangEntity.Ngaykiemke);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makho,_SodumangEntity.Makho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkho,_SodumangEntity.Tenkho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang,_SodumangEntity.Mamang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang,_SodumangEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somet,_SodumangEntity.Somet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokg,_SodumangEntity.Sokg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_SodumangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_SodumangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_SodumangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_SodumangEntity.Nguoisua);
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

		public SodumangEntity Insert(SodumangEntity SodumangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(SodumangEntity, true);
			}
			return SodumangEntity;
		}

		public SodumangEntity Insert(System.Int64  Id, System.DateTime  Ngaykiemke, System.String  Makho, System.String  Tenkho, System.String  Mamang, System.String  Tenmang, System.Decimal  Somet, System.Decimal  Sokg, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			SodumangEntity _SodumangEntity = new SodumangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_SodumangEntity.Id = Id;
				
				_SodumangEntity.Ngaykiemke = Ngaykiemke;
				
				_SodumangEntity.Makho = Makho;
				
				_SodumangEntity.Tenkho = Tenkho;
				
				_SodumangEntity.Mamang = Mamang;
				
				_SodumangEntity.Tenmang = Tenmang;
				
				_SodumangEntity.Somet = Somet;
				
				_SodumangEntity.Sokg = Sokg;
				
				_SodumangEntity.Ngaytao = Ngaytao;
				
				_SodumangEntity.Nguoitao = Nguoitao;
				
				_SodumangEntity.Ngaysua = Ngaysua;
				
				_SodumangEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_SodumangEntity, true);
			}
			return _SodumangEntity;
		}

		public SodumangEntity Insert(System.DateTime Ngaykiemke, System.String Makho, System.String Tenkho, System.String Mamang, System.String Tenmang, System.Decimal Somet, System.Decimal Sokg, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			SodumangEntity _SodumangEntity = new SodumangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_SodumangEntity.Ngaykiemke = Ngaykiemke;
				
				_SodumangEntity.Makho = Makho;
				
				_SodumangEntity.Tenkho = Tenkho;
				
				_SodumangEntity.Mamang = Mamang;
				
				_SodumangEntity.Tenmang = Tenmang;
				
				_SodumangEntity.Somet = Somet;
				
				_SodumangEntity.Sokg = Sokg;
				
				_SodumangEntity.Ngaytao = Ngaytao;
				
				_SodumangEntity.Nguoitao = Nguoitao;
				
				_SodumangEntity.Ngaysua = Ngaysua;
				
				_SodumangEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_SodumangEntity, true);
			}
			return _SodumangEntity;
		}

		public bool Update(SodumangEntity _SodumangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(SodumangFields.Id == _SodumangEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_SodumangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(SodumangEntity _SodumangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_SodumangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngaykiemke, System.String Makho, System.String Tenkho, System.String Mamang, System.String Tenmang, System.Decimal Somet, System.Decimal Sokg, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SodumangEntity _SodumangEntity = new SodumangEntity(Id);
				if (adapter.FetchEntity(_SodumangEntity))
				{
				
					
					
					_SodumangEntity.Ngaykiemke = Ngaykiemke;
					
					_SodumangEntity.Makho = Makho;
					
					_SodumangEntity.Tenkho = Tenkho;
					
					_SodumangEntity.Mamang = Mamang;
					
					_SodumangEntity.Tenmang = Tenmang;
					
					_SodumangEntity.Somet = Somet;
					
					_SodumangEntity.Sokg = Sokg;
					
					_SodumangEntity.Ngaytao = Ngaytao;
					
					_SodumangEntity.Nguoitao = Nguoitao;
					
					_SodumangEntity.Ngaysua = Ngaysua;
					
					_SodumangEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_SodumangEntity, true);
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
				SodumangEntity _SodumangEntity = new SodumangEntity(Id);
				if (adapter.FetchEntity(_SodumangEntity))
				{
					adapter.DeleteEntity(_SodumangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("SodumangEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodumangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaykiemke(System.DateTime Ngaykiemke)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Ngaykiemke == Ngaykiemke);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodumangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakho(System.String Makho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodumangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkho(System.String Tenkho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodumangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamang(System.String Mamang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodumangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmang(System.String Tenmang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodumangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomet(System.Decimal Somet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodumangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokg(System.Decimal Sokg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodumangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodumangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodumangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodumangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SodumangEntity", filter);
			}
			return toReturn;
		}		
			
		
		public SodumangEntity SelectOne(System.Int64 Id)
		{
			SodumangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SodumangEntity _SodumangEntity = new SodumangEntity(Id);
				if (adapter.FetchEntity(_SodumangEntity))
				{
					toReturn = _SodumangEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _SodumangCollection = new EntityCollection( new SodumangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodumangCollection, null, 0, null);
			}
			return _SodumangCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodumangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodumangCollection, filter, 0, null);
			}
			return _SodumangCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodumangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaykiemke(System.DateTime Ngaykiemke)
		{
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Ngaykiemke == Ngaykiemke);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodumangCollection, filter, 0, null);
			}
			return _SodumangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaykiemkeRDT(System.DateTime Ngaykiemke)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Ngaykiemke == Ngaykiemke);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodumangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakho(System.String Makho)
		{
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodumangCollection, filter, 0, null);
			}
			return _SodumangCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhoRDT(System.String Makho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Makho == Makho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodumangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkho(System.String Tenkho)
		{
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodumangCollection, filter, 0, null);
			}
			return _SodumangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhoRDT(System.String Tenkho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Tenkho == Tenkho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodumangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamang(System.String Mamang)
		{
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodumangCollection, filter, 0, null);
			}
			return _SodumangCollection;
		}
		// Return DataTable
		public DataTable SelectByMamangRDT(System.String Mamang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodumangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmang(System.String Tenmang)
		{
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodumangCollection, filter, 0, null);
			}
			return _SodumangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmangRDT(System.String Tenmang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodumangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomet(System.Decimal Somet)
		{
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodumangCollection, filter, 0, null);
			}
			return _SodumangCollection;
		}
		// Return DataTable
		public DataTable SelectBySometRDT(System.Decimal Somet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Somet == Somet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodumangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokg(System.Decimal Sokg)
		{
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodumangCollection, filter, 0, null);
			}
			return _SodumangCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgRDT(System.Decimal Sokg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Sokg == Sokg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodumangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodumangCollection, filter, 0, null);
			}
			return _SodumangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodumangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodumangCollection, filter, 0, null);
			}
			return _SodumangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodumangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodumangCollection, filter, 0, null);
			}
			return _SodumangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodumangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SodumangCollection, filter, 0, null);
			}
			return _SodumangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SodumangCollection = new EntityCollection(new SodumangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SodumangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SodumangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
